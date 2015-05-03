using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Authentication;
using System.IO;
using System.Xml.Linq;

using JoeBlogs;
using RedditSharp;
using System.Diagnostics;

namespace reddittoWP
{
    public partial class Form1 : Form
    {

        const string REDDIT_TITLE_VAR = "!title";
        const string REDDIT_URL_VAR = "!url";
        const string REDDIT_OP_VAR = "!name";
        const string REDDIT_SELF_TEXT_VAR = "!text";
        const string IMGUR_DOMAIN = "imgur.com/";
        const string DIR_IGNORE_DOMAINS = "ignoredomains.txt";
        const string DIR_FILTER_REMOVE_LIST = "removelist.txt";


        List<string> ignoreDomains = new List<string>();
        List<string> removeList = new List<string>();

        static Reddit reddit;
        WordPressWrapper wp;

        Agent agent;
        Subreddit subreddit;
        RedditSharp.Post[] postArray;

        string mostRecentPostTitle;
        int postIndex;
        int numberOfPosts;

        int bufferSize = 5;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_category.SelectedIndex = 0;
            loadExternalFiles();
            rb_get_previous_posts.PerformClick();
        }

        private void loadExternalFiles()
        {
            if (!System.IO.File.Exists(Environment.CurrentDirectory + DIR_IGNORE_DOMAINS))
            {
                System.IO.File.Create(Environment.CurrentDirectory + DIR_IGNORE_DOMAINS);
                AddLogEntry("Ignore_domains not found. Created blank file.");
            }
            else
            {
                LoadIgnoreDomains();
                AddLogEntry("Ignore_domains loaded successfully.");

            }

            if (!System.IO.File.Exists(Environment.CurrentDirectory + DIR_FILTER_REMOVE_LIST))
            {
                System.IO.File.Create(Environment.CurrentDirectory + DIR_FILTER_REMOVE_LIST);
                AddLogEntry("Remove_list not found. Created blank file.");
            }
            else
            {
                LoadRemoveList();
                AddLogEntry("remove_list loaded successfully.");

            }
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            lbl_status.Text = "Logging In";
            AddLogEntry("Starting");
           
            bool isInputError = CheckInputs();
            AddLogEntry("Input Error:" + isInputError);

            if (!isInputError)
            {
                agent = new Agent(tb_reddit_username.Text, tb_reddit_password.Text, tb_wordpress_username.Text, tb_wordpress_password.Text);

                bool isRedditLoginError = LogInToReddit();
                AddLogEntry("Logged in to Reddit:" + !isRedditLoginError);
                bool isWordpressLoginError = LogInToWordPress();
                AddLogEntry("Logged in to WordPress:" + !isWordpressLoginError);

                bool isLoginError = (isRedditLoginError || isWordpressLoginError);

                if (!isLoginError)
                {

                    LoadIgnoreDomains();        
                    LoadRemoveList();
                   
                    subreddit = reddit.GetSubreddit(tb_subreddit.Text);   
                    numberOfPosts = Convert.ToInt32(tb_number_of_posts.Text);

                    lbl_status.Text = "Working";

                    var posts = subreddit.GetNew();
                    if (lb_category.SelectedIndex == 0)
                    {
                        posts = subreddit.GetHot();
                    }
                    else if (lb_category.SelectedIndex == 1)
                    {
                        posts = subreddit.GetNew();
                    }

                    btn_start.Enabled = false;
                    btn_stop_task.Enabled = true;
                    disableGroupBoxes(true);

                    if (rb_check_new_posts.Checked) //Check new posts
                    {
                        mostRecentPostTitle = posts.First().Title;
                        postIndex = 0;
                        postArray = posts.Take(bufferSize).ToArray();
                        Array.Reverse(postArray);

                        check_timer.Start();
                    }
                    else    //Post prev posts
                    {

                        postIndex = 0;

                        postArray = posts.Take(numberOfPosts).ToArray();
                        Array.Reverse(postArray);
                        post_timer.Start();

                    }

                }
            }

        }

        public void UpdateCurrentPostNumber()
        {
            lbl_current_post_number.Text = "" + postIndex + "/" + numberOfPosts;
        }

        public void PostToWordPress(string title, string body)
        {
            
            title = RemoveFilterWords(ReplaceWithRedditVariables(title));
            body = RemoveFilterWords(ReplaceWithRedditVariables(body));
            var WPpost = new JoeBlogs.Post();
            WPpost.DateCreated = DateTime.Now;
            WPpost.Title = title;
            WPpost.Body = body;

            wp.NewPost(WPpost, true);
            AddLogEntry("Posted to WordPress:" + title);
        }
        public void PostToWordPress(string title, string body, RedditSharp.Post post)
        {
            if (!IsIgnoredDomain(post.Domain))
            {
                title = ReplaceWithRedditVariables(title, post);
                body = ReplaceWithRedditVariables(body, post);
                var WPpost = new JoeBlogs.Post();
                WPpost.DateCreated = DateTime.Now;
                WPpost.Title = title;
                WPpost.Body = body;

                wp.NewPost(WPpost, true);
                AddLogEntry("Posted to WordPress:" + title);
            }
            else
            {
                AddLogEntry("Ignored: " + post.Domain);
            }
        }


        private string RemoveFilterWords(string instring)
        {
            string returnString = instring;
            foreach (string s in removeList)
            {
                while (returnString.Contains(s))
                {
                  // returnString.Trim(s.ToCharArray());
                    returnString = returnString.Replace(s, string.Empty);
                }
            }

            return returnString;
            
        }


        private void check_timer_Tick(object sender, EventArgs e)
        {

            RedditSharp.Post redditMostRecentPost = null;
            

            if (lb_category.SelectedIndex == 0) redditMostRecentPost = subreddit.GetHot().First(); //get hot   
            else if (lb_category.SelectedIndex == 1) redditMostRecentPost = subreddit.GetNew().First(); //get new

            Console.WriteLine("-----------------------------");
            Console.WriteLine("mostRecentPostTitle:" + mostRecentPostTitle);
            Console.WriteLine("mostRecentRedditTitle:" + redditMostRecentPost.Title);


            if (mostRecentPostTitle != redditMostRecentPost.Title) //new post?
            { //new post detected


                var posts = subreddit.GetNew();
                RedditSharp.Post[] newPostArray = posts.Take(bufferSize).ToArray();
                Array.Reverse(newPostArray); ///now they are in chronological order

                //console print arrays
                for (int j = 0; j < bufferSize; j++)
                {
                    try
                    {
                        Console.WriteLine("" + j + "  Old:" + postArray[j].Title.Substring(0, 5) + "          New:" + newPostArray[j].Title.Substring(0, 5));
                    }
                    catch { Console.WriteLine("" + j + "  Old:" + postArray[j].Title.Substring(0, 1) + "          New:" + newPostArray[j].Title.Substring(0, 1)); }
                }

                //find old mostrecent post index in the new post array
                int oldRecentPostIndex = 0;
                for (int i = 0; i < bufferSize; i++)
                {
                    if (newPostArray[i].Title == mostRecentPostTitle)
                    {
                        oldRecentPostIndex = i;
                        Console.WriteLine("Old post index: " + oldRecentPostIndex);

                        break;
                    }
                    if (i == bufferSize - 1)
                    {
                        MessageBox.Show("buffer overflow");
                        Console.WriteLine("old post not found in new post array");
                    }
                }




                for (int n = oldRecentPostIndex + 1; n < bufferSize; n++)
                {

                    string WPpostTitle = tb_wordpress_format_title.Text;
                    string WPpostBody = tb_wordpress_format_body.Text;
                    Console.WriteLine("Posting WP : " + n);
                    PostToWordPress(WPpostTitle, WPpostBody, newPostArray[n]);

                }
                postArray = newPostArray;
                mostRecentPostTitle = newPostArray[bufferSize - 1].Title;


                Console.WriteLine("---------------------------------");

            }
            else
            {
                AddLogEntry(System.DateTime.Now.TimeOfDay + ": Nothing new");
            }
            bufferSize = Convert.ToInt32(tb_buffer_size.Text);
            check_timer.Interval = Convert.ToInt32(tb_post_interval.Text);

        }

        private void post_timer_Tick(object sender, EventArgs e)
        {

            try
            {
                string WPpostTitle = tb_wordpress_format_title.Text;
                string WPpostBody = tb_wordpress_format_body.Text;

                if (!IsIgnoredDomain(postArray[postIndex].Domain))
                PostToWordPress(WPpostTitle, WPpostBody);
                else
                 AddLogEntry("Ignored: " + postArray[postIndex].Domain);
                

                postIndex++;
                lbl_current_post_number.Text = "" + postIndex + "/" + numberOfPosts;

                if (postIndex < numberOfPosts)
                {

                }
                else
                {
                    EndTask();
                }
            }
            catch
            {
                AddLogEntry("No more posts.");
                EndTask();
               
            }
            post_timer.Interval = Convert.ToInt32(tb_post_interval.Text);

        }
        private void EndTask()
        {
            AddLogEntry("End Task");
            lbl_status.Text = "";
            post_timer.Stop();
            btn_start.Enabled = true;
            btn_stop_task.Enabled = false;
            disableGroupBoxes(false);
        }
        public void AddLogEntry(string e)
        {
            log.Text += Environment.NewLine + e;
            ScrollLogToBottom();
        }
        private void ScrollLogToBottom()
        {
            log.SelectionStart = log.Text.Length;
            log.ScrollToCaret();
        }
        private bool CheckInputs()
        {
            if (tb_reddit_username.Equals(""))
            {
                MessageBox.Show("Enter reddit username");
                return true;
            }

            else if (tb_reddit_password.Equals(""))
            {
                MessageBox.Show("Enter reddit password");
                return true;
            }

            else if (tb_wordpress_username.Equals(""))
            {
                MessageBox.Show("Enter wordpress username");
                return true;
            }

            else if (tb_wordpress_password.Equals(""))
            {
                MessageBox.Show("Enter wordpress password");
                return true;
            }
            else if (lb_category.SelectedIndex == -1)
            {
                MessageBox.Show("Select category");
                return true;
            }
            else if (tb_wordpress_url.Equals(""))
            {
                MessageBox.Show("Enter wordpress url");
                return true;
            }
            else if (tb_subreddit.Equals(""))
            {
                MessageBox.Show("Enter subreddit");
                return true;
            }
            return false;
        }

        private bool LogInToReddit()
        {

            reddit = new Reddit();
            try
            {
                reddit.LogIn(agent.getRedditUsername(), agent.getRedditPassword());
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("Incorrect Reddit login.");
                return true;
            }
            return false;
        }
        private bool LogInToWordPress()
        {
            try
            {
                wp = new WordPressWrapper(tb_wordpress_url.Text + "/xmlrpc.php", agent.getWordpressUsername(), agent.getWordpressPassword());
                if (wp.GetUserInfo() == null)
                {
                    MessageBox.Show("Incorrect Wordpress login.");
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Incorrect Wordpress login.");
                return true;
            }

            return false;
        }


        private void disableGroupBoxes(bool b)
        {
            if (b)
            {
                gb1.Enabled = false;
                gb2.Enabled = false;
            }
            else
            {
                gb1.Enabled = true;
                gb2.Enabled = true;
            }
        }
        private bool IsIgnoredDomain(string dom)
        {
            for (int i = 0; i < ignoreDomains.Count; i++)
            {
                if (dom.Contains(ignoreDomains[i])) return true; 
            }
            return false;
        }
      
        private string ReplaceWithRedditVariables(string inputstring)
        {
            //if (postArray[postIndex].Url)
            string title = RemoveBrackets(postArray[postIndex].Title);
            string url = postArray[postIndex].Url;
            if (url.Contains(IMGUR_DOMAIN)) url = AddImgurExtensions(url);
            string authorName = postArray[postIndex].Author.Name;
            string text = postArray[postIndex].SelfText;

            inputstring = inputstring.Replace(REDDIT_TITLE_VAR, title);
            inputstring = inputstring.Replace(REDDIT_URL_VAR, url);
            inputstring = inputstring.Replace(REDDIT_OP_VAR, authorName);
            inputstring = inputstring.Replace(REDDIT_SELF_TEXT_VAR, text);
            return inputstring;
        }
        private string ReplaceWithRedditVariables(string inputstring, RedditSharp.Post post)
        {
            string url = post.Url;
            if (url.Contains(IMGUR_DOMAIN)) url = AddImgurExtensions(url);

            inputstring = inputstring.Replace(REDDIT_TITLE_VAR, RemoveBrackets(post.Title));
            inputstring = inputstring.Replace(REDDIT_URL_VAR, url);
            inputstring = inputstring.Replace(REDDIT_OP_VAR, post.Author.Name);
            inputstring = inputstring.Replace(REDDIT_SELF_TEXT_VAR, post.SelfText);
            return inputstring;
        }
        private string RemoveBrackets(string s)
        {
            if (s.Contains('[') && s.Contains(']'))
            {
                int b = s.IndexOf('[');
                int l = s.IndexOf(']') - b;
                return s.Remove(b, l + 1);
            }
            return s;
        }
        private string AddImgurExtensions(string s)
        {
          
            if (s.Contains("imgur.com/")) 
            {  
                if (s.Contains("imgur.com/a/"))
              {
                return s;
              }
                else if (!s.Contains(".png") && !s.Contains(".jpg") && !s.Contains(".gif") && !s.Contains(".bmp")) //already has extension?
                {
                    return s.Remove(s.Length - 1) + ".png";
                }
            }
            return s;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_check_new_posts.Checked)
            {
                lbl_current_task.Text = rb_check_new_posts.Text;
                lbl_interval.Text = "Check Interval (ms)";
                tb_buffer_size.Enabled = true;
                tb_post_interval.Text = "15000";
            }
            else
            {
                lbl_current_task.Text = rb_get_previous_posts.Text;
                lbl_interval.Text = "Post Interval (ms)";
                tb_buffer_size.Enabled = false;
                tb_post_interval.Text = "3000";
            }
        }

        private void tb_post_interval_TextChanged(object sender, EventArgs e)
        {
            post_timer.Interval = Convert.ToInt32(tb_post_interval.Text);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }




        private void btn_stop_task_Click(object sender, EventArgs e)
        {
            post_timer.Stop();
            check_timer.Stop();
            btn_start.Enabled = true;
            btn_stop_task.Enabled = false;
            disableGroupBoxes(false);
        }

        private void rb_check_new_posts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menu_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.CurrentDirectory;
            sfd.DefaultExt = ".xml";
            sfd.ShowDialog();

            WriteSettingsFile(sfd.FileName);



        }

        private void menu_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.DefaultExt = ".xml";
            ofd.ShowDialog();

            LoadSettingsFile(ofd.FileName);
        }
        private void LoadSettingsFile(string path)
        {
            try
            {
                XDocument xml = XDocument.Load(path);

                //  foreach (XElement element in xml.Elements().Elements().)
                //   {
                //   }

                int asd = xml.Descendants("Setting").Elements().Count();
                foreach (XElement setting in xml.Descendants("Setting"))
                {
                    Console.WriteLine(setting.Element("redditU").Value);
                    tb_reddit_username.Text = setting.Element("redditU").Value;
                    tb_reddit_password.Text = setting.Element("redditP").Value;
                    tb_wordpress_username.Text = setting.Element("wordpressU").Value;
                    tb_wordpress_password.Text = setting.Element("wordpressP").Value;
                    tb_subreddit.Text = setting.Element("subreddit").Value;
                    tb_number_of_posts.Text = setting.Element("numPosts").Value;
                    tb_wordpress_url.Text = setting.Element("wordpressUrl").Value;
                    tb_post_interval.Text = setting.Element("checkInterval").Value;
                    tb_buffer_size.Text = setting.Element("bufferSize").Value;
                    tb_wordpress_format_title.Text = setting.Element("wordpressTitleFormat").Value;
                    tb_wordpress_format_body.Text = setting.Element("wordpressBodyFormat").Value;
                    lb_category.SelectedIndex = Convert.ToInt32(setting.Element("category").Value);
                    if (setting.Element("task").Value == "1") rb_check_new_posts.PerformClick(); else rb_get_previous_posts.PerformClick();

                }
            }
            catch { MessageBox.Show("Load Settings Error"); }
        }


        private void WriteSettingsFile(string path)
        {
            
            XElement xml = new XElement("Setting",
            new XElement("redditU", tb_reddit_username.Text),
            new XElement("redditP", tb_reddit_password.Text),
            new XElement("wordpressU", tb_wordpress_username.Text),
            new XElement("wordpressP", tb_wordpress_password.Text),
            new XElement("subreddit", tb_subreddit),
            new XElement("wordpressUrl", tb_wordpress_url.Text),
            new XElement("numPosts", tb_number_of_posts.Text),
            new XElement("task", ((rb_check_new_posts.Checked) ? 1 : 0 )),
            new XElement("category", lb_category.SelectedIndex),
            new XElement("wordpressTitleFormat", tb_wordpress_format_title.Text),
            new XElement("wordpressBodyFormat", tb_wordpress_format_body.Text),
            new XElement("checkInterval", tb_post_interval.Text),
            new XElement("bufferSize", tb_buffer_size.Text)
            );

            xml.Save(path);
        }

        private void LoadIgnoreDomains()
        {
            using (StreamReader r = new StreamReader(Environment.CurrentDirectory + "ignoredomains.txt"))
            {
      
                string currentItem;
                while ((currentItem = r.ReadLine()) != null)
                {
                    ignoreDomains.Add(currentItem);
                }
            }
        }

        public void LoadRemoveList()
        {
            removeList.Clear();
            using (StreamReader r = new StreamReader(Environment.CurrentDirectory + "removelist.txt"))
            {
               
                string currentItem;
                while ((currentItem = r.ReadLine()) != null)
                {
                    if (currentItem.Length > 0)
                    {
                        removeList.Add(currentItem);
                    }
                }
            }
        }


        private void btn_edit_ignore_domains_Click(object sender, EventArgs e)
        {
            string dir = Environment.CurrentDirectory + "ignoredomains.txt";
       
           Process.Start("notepad.exe", dir);
        }

        private void tb_wordpress_url_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_filters_Click(object sender, EventArgs e)
        {
            FiltersForm ff = new FiltersForm(this);
            ff.ShowDialog();

        }

        public List<string> getRemoveList() { return removeList; }

        private void tb_buffer_size_TextChanged(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}
