using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TestApp

{
    public static class ClassCheck
    {
        private static bool t;

        public static string getconstr
        {
            get
            {
                string str="";
                string constr = "provider = microsoft.jet.oledb.4.0; data source = " + Classdata.rePath();
                string comstr = "select * from tableconstr";
                OleDbConnection con = new OleDbConnection(constr);
                con.Open();
                OleDbCommand com = new OleDbCommand(comstr, con);
               
                OleDbDataReader reader;
                reader = com.ExecuteReader();
                if (reader.Read())
                {
                    str=(string) reader.GetValue(1);
                }
                return str;

            }
        }

        public static string getstartstr
        {
            get
            {
                string path = Application.StartupPath + @"\start.exe";
                if (!File.Exists(path))
                {
                    path = @"E:\sky\inherent\study\computer\visual studio\csharp\test\longding\bin\Release\start.exe";
                }
                return path;
            }

        }
        public static string _link { get; set; }
        private static Boolean islink { set; get; }
        public static bool Issql
        {
            get
            {
                string constr = getconstr;
                string comstr = "select * from iser where id='1'";
                SqlConnection con = new SqlConnection(constr);
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand(comstr, con);
                    SqlDataReader reader;
                    reader = com.ExecuteReader();
                    if (reader.Read())
                    {
                        islink = (bool)reader["iser"];
                        if (islink == true)
                        {
                            t = true;
                            _link = "服务器已授权";
                        }
                        else
                        {
                            t = false;
                            _link = "服务器正在维护";
                        }
                    }
                }
                catch
                {
                    //MessageBox.Show("连接服务器失败","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    t = false;
                    _link = "连接服务器失败";
                }
                finally
                {
                    con.Close();
                }
                return t;
            }
        }
        public static bool resql()
        {


            string constr = "server=testbcxg.cn,19597;user=sa;pwd=sky;database=test";
            string comstr = "update iser set iser='0' where id='2'";

            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(comstr, con);
                com.ExecuteNonQuery();
            }
            catch
            {
                t = false;
                _link = "连接服务器失败";
            }
            finally
            {
                con.Close();
            }
            return t;
        }
        public static Boolean check()
        {
            
            object Is = false;
            string constr = "provider = microsoft.jet.oledb.4.0; data source = " + Classdata.rePath();
            string comstr = "select * from isadmin";
            OleDbConnection con = new OleDbConnection(constr);
            con.Open();
            OleDbCommand com = new OleDbCommand(comstr,con);
            OleDbDataReader reader;
            reader = com.ExecuteReader();
            if (reader.Read())
            {
                Is = reader.GetValue(1);
            }
            return (bool)Is;
        }

    }
}
