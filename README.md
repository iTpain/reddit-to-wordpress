# reddit-to-wordpress
Automatically posts content from reddit into a wordpress blog. Uses RedditSharp and JoeBlogs APIs.

To use:
----------------------------------
1. Enter credentials and urls:

Enter a username and password for a reddit account and also the username and password of the blog you want to post on. Enter the subreddit you want to take posts from and the URL of your wordpress blog. It should be the URL of the directory that contains the xmlrpc.php, not the file itself.

2.Select task:

The two options are
 a)Post Previous Posts - takes a specified amount of posts from the selected subreddit starting from the oldest post.
 b)Check/Post New Posts - monitors the subreddit for new posts. You can tweak this option by changing the check interval and buffer size. The buffer size is the maximum amount of posts that can be taken each time the program checks. For subreddits with frequent posts, the buffer size should be set high.

3.Specify format

Enter the title and body of the post to wordpress. The variables such as "!title" are replaced by the data from reddit before they are posted to wordpress. 
