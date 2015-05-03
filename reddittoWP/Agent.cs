using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reddittoWP
{
    class Agent
    {
        string redditUsername;
        string redditPassword;
        string wordpressUsername;
        string wordpressPassword;

        public Agent(string ruser, string rpass, string wuser, string wpass)
        {
            redditUsername = ruser;
            redditPassword = rpass;
            wordpressUsername = wuser;
            wordpressPassword = wpass;
        }

        public string getRedditUsername() { return redditUsername; }
        public string getRedditPassword() { return redditPassword; }
        public string getWordpressPassword() { return wordpressPassword; }
        public string getWordpressUsername() { return wordpressUsername; }
    }
}
