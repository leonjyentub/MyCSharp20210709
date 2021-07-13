using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassConsole
{
    class MyClass
    {
        public MyClass()
        {
            this.Name = "";
            this._score = 0;
        }

        public MyClass(String name, int myscore)
        {
            this.Name = name;
            this._score = myscore;
        }
        public String Name { get; set; }
        private int _score;  //一般普通欄位
        public int Score
        {
            get { return this._score; }
            set
            {
                if(_score >= 0 && _score <= 100)
                {
                    this._score = value;
                }
                else
                {
                    Console.WriteLine("設定錯誤");
                    this._score = 0;
                }
            }
        }
       
        public void HelloWorldTest()
        {
            Console.WriteLine($"我是{this.Name}分數是{this._score}");
        }
    }
}
