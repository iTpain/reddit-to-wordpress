namespace reddittoWP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_reddit_username = new System.Windows.Forms.TextBox();
            this.tb_reddit_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_wordpress_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_wordpress_password = new System.Windows.Forms.TextBox();
            this.tb_subreddit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_category = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_wordpress_url = new System.Windows.Forms.TextBox();
            this.tb_number_of_posts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rb_get_previous_posts = new System.Windows.Forms.RadioButton();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.rb_check_new_posts = new System.Windows.Forms.RadioButton();
            this.tb_wordpress_format_title = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_wordpress_format_body = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_edit_filters = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_load = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit_ignore_domains = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_buffer_size = new System.Windows.Forms.TextBox();
            this.btn_stop_task = new System.Windows.Forms.Button();
            this.lbl_interval = new System.Windows.Forms.Label();
            this.tb_post_interval = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_current_post_number = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_current_task = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.post_timer = new System.Windows.Forms.Timer(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.check_timer = new System.Windows.Forms.Timer(this.components);
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subreddit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reddit Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reddit PW:";
            // 
            // tb_reddit_username
            // 
            this.tb_reddit_username.Location = new System.Drawing.Point(100, 15);
            this.tb_reddit_username.Name = "tb_reddit_username";
            this.tb_reddit_username.Size = new System.Drawing.Size(116, 20);
            this.tb_reddit_username.TabIndex = 3;
            // 
            // tb_reddit_password
            // 
            this.tb_reddit_password.Location = new System.Drawing.Point(100, 47);
            this.tb_reddit_password.Name = "tb_reddit_password";
            this.tb_reddit_password.Size = new System.Drawing.Size(116, 20);
            this.tb_reddit_password.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wordpress Username:";
            // 
            // tb_wordpress_username
            // 
            this.tb_wordpress_username.Location = new System.Drawing.Point(350, 15);
            this.tb_wordpress_username.Name = "tb_wordpress_username";
            this.tb_wordpress_username.Size = new System.Drawing.Size(116, 20);
            this.tb_wordpress_username.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wordpress PW:";
            // 
            // tb_wordpress_password
            // 
            this.tb_wordpress_password.Location = new System.Drawing.Point(350, 47);
            this.tb_wordpress_password.Name = "tb_wordpress_password";
            this.tb_wordpress_password.Size = new System.Drawing.Size(116, 20);
            this.tb_wordpress_password.TabIndex = 9;
            // 
            // tb_subreddit
            // 
            this.tb_subreddit.Location = new System.Drawing.Point(116, 81);
            this.tb_subreddit.Name = "tb_subreddit";
            this.tb_subreddit.Size = new System.Drawing.Size(349, 20);
            this.tb_subreddit.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Category";
            // 
            // lb_category
            // 
            this.lb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_category.FormattingEnabled = true;
            this.lb_category.ItemHeight = 15;
            this.lb_category.Items.AddRange(new object[] {
            "hot",
            "new"});
            this.lb_category.Location = new System.Drawing.Point(150, 84);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(45, 34);
            this.lb_category.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Wordpress URL:";
            // 
            // tb_wordpress_url
            // 
            this.tb_wordpress_url.Location = new System.Drawing.Point(100, 107);
            this.tb_wordpress_url.Name = "tb_wordpress_url";
            this.tb_wordpress_url.Size = new System.Drawing.Size(306, 20);
            this.tb_wordpress_url.TabIndex = 16;
            this.tb_wordpress_url.Text = " http://example/wp";
            this.tb_wordpress_url.TextChanged += new System.EventHandler(this.tb_wordpress_url_TextChanged);
            // 
            // tb_number_of_posts
            // 
            this.tb_number_of_posts.Location = new System.Drawing.Point(98, 73);
            this.tb_number_of_posts.Name = "tb_number_of_posts";
            this.tb_number_of_posts.Size = new System.Drawing.Size(23, 20);
            this.tb_number_of_posts.TabIndex = 17;
            this.tb_number_of_posts.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "# of posts:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "Leave blank for all posts";
            // 
            // rb_get_previous_posts
            // 
            this.rb_get_previous_posts.AutoSize = true;
            this.rb_get_previous_posts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_get_previous_posts.Location = new System.Drawing.Point(33, 15);
            this.rb_get_previous_posts.Name = "rb_get_previous_posts";
            this.rb_get_previous_posts.Size = new System.Drawing.Size(151, 19);
            this.rb_get_previous_posts.TabIndex = 20;
            this.rb_get_previous_posts.Text = "Post Previous Posts";
            this.rb_get_previous_posts.UseVisualStyleBackColor = true;
            this.rb_get_previous_posts.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.rb_check_new_posts);
            this.gb2.Controls.Add(this.rb_get_previous_posts);
            this.gb2.Controls.Add(this.label8);
            this.gb2.Controls.Add(this.label9);
            this.gb2.Controls.Add(this.tb_number_of_posts);
            this.gb2.Controls.Add(this.lb_category);
            this.gb2.Controls.Add(this.label6);
            this.gb2.Location = new System.Drawing.Point(487, 26);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(226, 134);
            this.gb2.TabIndex = 21;
            this.gb2.TabStop = false;
            // 
            // rb_check_new_posts
            // 
            this.rb_check_new_posts.AutoSize = true;
            this.rb_check_new_posts.Checked = true;
            this.rb_check_new_posts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_check_new_posts.Location = new System.Drawing.Point(33, 44);
            this.rb_check_new_posts.Name = "rb_check_new_posts";
            this.rb_check_new_posts.Size = new System.Drawing.Size(167, 19);
            this.rb_check_new_posts.TabIndex = 21;
            this.rb_check_new_posts.TabStop = true;
            this.rb_check_new_posts.Text = "Check/Post New Posts";
            this.rb_check_new_posts.UseVisualStyleBackColor = true;
            this.rb_check_new_posts.CheckedChanged += new System.EventHandler(this.rb_check_new_posts_CheckedChanged);
            // 
            // tb_wordpress_format_title
            // 
            this.tb_wordpress_format_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_wordpress_format_title.Location = new System.Drawing.Point(21, 46);
            this.tb_wordpress_format_title.Multiline = true;
            this.tb_wordpress_format_title.Name = "tb_wordpress_format_title";
            this.tb_wordpress_format_title.Size = new System.Drawing.Size(298, 26);
            this.tb_wordpress_format_title.TabIndex = 22;
            this.tb_wordpress_format_title.Text = "!title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Title";
            // 
            // tb_wordpress_format_body
            // 
            this.tb_wordpress_format_body.Location = new System.Drawing.Point(21, 91);
            this.tb_wordpress_format_body.Multiline = true;
            this.tb_wordpress_format_body.Name = "tb_wordpress_format_body";
            this.tb_wordpress_format_body.Size = new System.Drawing.Size(298, 138);
            this.tb_wordpress_format_body.TabIndex = 24;
            this.tb_wordpress_format_body.Text = "!url";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Body";
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.label23);
            this.gb3.Controls.Add(this.btn_edit_filters);
            this.gb3.Controls.Add(this.label21);
            this.gb3.Controls.Add(this.label14);
            this.gb3.Controls.Add(this.label13);
            this.gb3.Controls.Add(this.label12);
            this.gb3.Controls.Add(this.label10);
            this.gb3.Controls.Add(this.label11);
            this.gb3.Controls.Add(this.tb_wordpress_format_title);
            this.gb3.Controls.Add(this.tb_wordpress_format_body);
            this.gb3.Location = new System.Drawing.Point(9, 156);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(335, 259);
            this.gb3.TabIndex = 26;
            this.gb3.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(189, 235);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 15);
            this.label23.TabIndex = 33;
            this.label23.Text = "!text";
            // 
            // btn_edit_filters
            // 
            this.btn_edit_filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_filters.Location = new System.Drawing.Point(271, 233);
            this.btn_edit_filters.Name = "btn_edit_filters";
            this.btn_edit_filters.Size = new System.Drawing.Size(48, 21);
            this.btn_edit_filters.TabIndex = 32;
            this.btn_edit_filters.Text = "Filters";
            this.btn_edit_filters.UseVisualStyleBackColor = true;
            this.btn_edit_filters.Click += new System.EventHandler(this.btn_edit_filters_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(111, 235);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 15);
            this.label21.TabIndex = 31;
            this.label21.Text = "!username";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(72, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "!url";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "!title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "WordPress Post Format";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(16, 418);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(323, 36);
            this.btn_start.TabIndex = 27;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_save,
            this.menu_load,
            this.btn_edit_ignore_domains,
            this.menu_quit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_save
            // 
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(181, 22);
            this.menu_save.Text = "Save";
            this.menu_save.Click += new System.EventHandler(this.menu_save_Click);
            // 
            // menu_load
            // 
            this.menu_load.Name = "menu_load";
            this.menu_load.Size = new System.Drawing.Size(181, 22);
            this.menu_load.Text = "Load";
            this.menu_load.Click += new System.EventHandler(this.menu_load_Click);
            // 
            // btn_edit_ignore_domains
            // 
            this.btn_edit_ignore_domains.Name = "btn_edit_ignore_domains";
            this.btn_edit_ignore_domains.Size = new System.Drawing.Size(181, 22);
            this.btn_edit_ignore_domains.Text = "Edit Ignore Domains";
            this.btn_edit_ignore_domains.Click += new System.EventHandler(this.btn_edit_ignore_domains_Click);
            // 
            // menu_quit
            // 
            this.menu_quit.Name = "menu_quit";
            this.menu_quit.Size = new System.Drawing.Size(181, 22);
            this.menu_quit.Text = "Quit";
            this.menu_quit.Click += new System.EventHandler(this.menu_quit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(97, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "/r/";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.tb_buffer_size);
            this.groupBox3.Controls.Add(this.btn_stop_task);
            this.groupBox3.Controls.Add(this.lbl_interval);
            this.groupBox3.Controls.Add(this.tb_post_interval);
            this.groupBox3.Controls.Add(this.lbl_status);
            this.groupBox3.Controls.Add(this.lbl_current_post_number);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.lbl_current_task);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.log);
            this.groupBox3.Location = new System.Drawing.Point(350, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 298);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(303, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Buffer Size";
            // 
            // tb_buffer_size
            // 
            this.tb_buffer_size.Location = new System.Drawing.Point(367, 88);
            this.tb_buffer_size.Name = "tb_buffer_size";
            this.tb_buffer_size.Size = new System.Drawing.Size(50, 20);
            this.tb_buffer_size.TabIndex = 38;
            this.tb_buffer_size.Text = "5";
            this.tb_buffer_size.TextChanged += new System.EventHandler(this.tb_buffer_size_TextChanged);
            // 
            // btn_stop_task
            // 
            this.btn_stop_task.Enabled = false;
            this.btn_stop_task.Location = new System.Drawing.Point(180, 91);
            this.btn_stop_task.Name = "btn_stop_task";
            this.btn_stop_task.Size = new System.Drawing.Size(75, 23);
            this.btn_stop_task.TabIndex = 37;
            this.btn_stop_task.Text = "Stop task";
            this.btn_stop_task.UseVisualStyleBackColor = true;
            this.btn_stop_task.Click += new System.EventHandler(this.btn_stop_task_Click);
            // 
            // lbl_interval
            // 
            this.lbl_interval.AutoSize = true;
            this.lbl_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interval.Location = new System.Drawing.Point(265, 71);
            this.lbl_interval.Name = "lbl_interval";
            this.lbl_interval.Size = new System.Drawing.Size(98, 13);
            this.lbl_interval.TabIndex = 36;
            this.lbl_interval.Text = "Check Interval (ms)";
            // 
            // tb_post_interval
            // 
            this.tb_post_interval.Location = new System.Drawing.Point(367, 68);
            this.tb_post_interval.Name = "tb_post_interval";
            this.tb_post_interval.Size = new System.Drawing.Size(50, 20);
            this.tb_post_interval.TabIndex = 22;
            this.tb_post_interval.Text = "15000";
            this.tb_post_interval.TextChanged += new System.EventHandler(this.tb_post_interval_TextChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(7, 40);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(422, 18);
            this.lbl_status.TabIndex = 35;
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_current_post_number
            // 
            this.lbl_current_post_number.AutoSize = true;
            this.lbl_current_post_number.Location = new System.Drawing.Point(67, 91);
            this.lbl_current_post_number.Name = "lbl_current_post_number";
            this.lbl_current_post_number.Size = new System.Drawing.Size(13, 13);
            this.lbl_current_post_number.TabIndex = 34;
            this.lbl_current_post_number.Text = "a";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(18, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Post #:";
            // 
            // lbl_current_task
            // 
            this.lbl_current_task.AutoSize = true;
            this.lbl_current_task.Location = new System.Drawing.Point(54, 71);
            this.lbl_current_task.Name = "lbl_current_task";
            this.lbl_current_task.Size = new System.Drawing.Size(118, 13);
            this.lbl_current_task.TabIndex = 30;
            this.lbl_current_task.Text = "Check/Post New Posts";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Task:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(193, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 15);
            this.label16.TabIndex = 31;
            this.label16.Text = "Status";
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Black;
            this.log.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.SystemColors.Window;
            this.log.Location = new System.Drawing.Point(9, 116);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(419, 179);
            this.log.TabIndex = 31;
            this.log.Text = "---R2WP v1.1---";
            // 
            // post_timer
            // 
            this.post_timer.Interval = 2000;
            this.post_timer.Tick += new System.EventHandler(this.post_timer_Tick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(406, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "/xmlrpc.php";
            // 
            // check_timer
            // 
            this.check_timer.Interval = 10000;
            this.check_timer.Tick += new System.EventHandler(this.check_timer_Tick);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label20);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.tb_wordpress_url);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.tb_subreddit);
            this.gb1.Controls.Add(this.tb_reddit_username);
            this.gb1.Controls.Add(this.tb_reddit_password);
            this.gb1.Controls.Add(this.label15);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.tb_wordpress_username);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label7);
            this.gb1.Controls.Add(this.tb_wordpress_password);
            this.gb1.Location = new System.Drawing.Point(9, 26);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(472, 133);
            this.gb1.TabIndex = 31;
            this.gb1.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(721, 98);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 40);
            this.label22.TabIndex = 32;
            this.label22.Text = "v1.2";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::reddittoWP.Properties.Resources.r2wp_icon;
            this.pictureBox1.Location = new System.Drawing.Point(722, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 458);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "R2WP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_reddit_username;
        private System.Windows.Forms.TextBox tb_reddit_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_wordpress_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_wordpress_password;
        private System.Windows.Forms.TextBox tb_subreddit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lb_category;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_wordpress_url;
        private System.Windows.Forms.TextBox tb_number_of_posts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rb_get_previous_posts;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.RadioButton rb_check_new_posts;
        private System.Windows.Forms.TextBox tb_wordpress_format_title;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_wordpress_format_body;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_quit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_current_post_number;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_current_task;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label lbl_interval;
        private System.Windows.Forms.TextBox tb_post_interval;
        private System.Windows.Forms.Timer post_timer;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_stop_task;
        private System.Windows.Forms.Timer check_timer;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_buffer_size;
        private System.Windows.Forms.ToolStripMenuItem menu_save;
        private System.Windows.Forms.ToolStripMenuItem menu_load;
        private System.Windows.Forms.ToolStripMenuItem btn_edit_ignore_domains;
        private System.Windows.Forms.Button btn_edit_filters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

