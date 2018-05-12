using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reformers
{
    class Suggestions
    {
        private string suggestion;
        private string yourname;
        private string email2;

        public string Suggestion
        {
            get
            {
                return suggestion;
            }
            set
            {
                suggestion = value;
            }
        }

        public string Yourname
        {
            get
            {
                return yourname;
            }
            set
            {
                yourname = value;
            }
        }

        public string Email2
        {
            get
            {
                return email2;
            }
            set
            {
                email2 = value;
            }
        }
    }
}
