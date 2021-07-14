using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFormsss
{
    public class MyScore
    {
        public String UserName { get; set; }
        public String SNo { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return $"{UserName}({SNo})，得分：{Score}";
        }
    }
}
