using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNote
{
    class Note
    {
        public String Title { get; set; }
        public String Content { get; set; }
        public String GetFullMessage() { return this.Title + " -" + this.Content; }
    }
}
