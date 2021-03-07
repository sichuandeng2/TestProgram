using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TestApp

{
    public static class myinfo
    {
        public static Form2Main _main { set; get; }
        public static Form1 _Myform1;
        public static test _MyTest;
        public static Users _MyUsers { set; get; }
        public static info _myinfo { get; set; }

        public static string _name { set; get; }
        public static Boolean _isadmini;

        static string _textbl;
        public static string Textbl  
        {
            get
            {
                return _textbl;
            }
            set
            {
                if(value !="")
                if (double.Parse(value) > double.Parse("0.01") && double.Parse(value) < double.Parse("1.00"))

                {
                    _textbl = value;
                }
                else
                {
                    _textbl = "0.618";
                }
            }
        }

        static string _max;
        public static string Max
        {
            get
            {
                return _max;
            }
        set
            {
                if (value != "")
                if (double.Parse(value) > 0.96 && double.Parse(value) < 1.35)
                {
                    _max = value;
                } 
                else
                {
                    _max = "1.23";
                }
            }
        }
        static string _mid;
        public static string Mid
        {
            get
            {
                return _mid;
            }
            set
            {                
                _mid = value;
            }
        }
        private static string _mini;
        public static string Mini
        {
            get
            {
                return _mini;
            }
            set
            {
                _mini = value;
            }
        }
    }
}
