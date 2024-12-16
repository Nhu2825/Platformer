
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    public class User
    {
        public string NameUser { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }
        public int Lives { get; set; }
        public void Users(string NameUser, string Subject)
        {
            this.NameUser = NameUser;
            this.Subject = Subject;
            this.Score = 0;
            this.Lives = 3;
        }
    }
}
