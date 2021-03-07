using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace longding
{
    public static class ClassCheck
    {
        private static string _dbpath;
        private static string _testpath;
        private static Process pro = new Process();
        public static string _link { get; set; }
        public static Boolean IsdbPath
        {
            get
            {
                _dbpath = Application.StartupPath+@"\mydata.mdb";
                if (!File.Exists(_dbpath))
                {
                    _dbpath = @"E:\sky\inherent\study\computer\visual studio\csharp\test\mydata.mdb";
                    if (!File.Exists(_dbpath))
                    {
                        return false;
                    } 
                }

                return true;
            }

        }
        public static Boolean IsTestPath
        {
            get
            {
                _testpath = Application.StartupPath + @"\test.exe";
                if (!File.Exists(_testpath))
                {
                    _testpath = @"e:\sky\inherent\study\computer\visual studio\csharp\test\test\bin\Release\test.exe";
                    if (!File.Exists(_testpath))
                    {                        
                        return false;
                    }
                }
                return true;
            }
        }
    
        public static void open()
        {
            pro.StartInfo.FileName = _testpath;
            pro.StartInfo.UseShellExecute = true;
            pro.StartInfo.CreateNoWindow = true;
            pro.Start();
            pro.Close(); 
        }

        public static void update()
        {
                string constr = "provider = microsoft.jet.oledb.4.0; data source = " + _dbpath;
                string comstr = "update isadmin set [islond]=1 where [id]=2";

                OleDbConnection con = new OleDbConnection(constr);
                try
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand(comstr, con);
                    com.ExecuteNonQuery();
                  }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    con.Close();
                }               
            }

        private static string getconstr()
        {
            string myconstr = "server=sql.testbcxg.cn;user=xds359839393;pwd=jerry3.14;database=xds359839393_db";
            string sqlstr = "select * from iser where [id]=1";
            SqlCommand com;
            SqlConnection mycon = new SqlConnection(myconstr);
                try
                { 
                    mycon.Open();
                    com = new SqlCommand(sqlstr, mycon);
                    SqlDataReader red = com.ExecuteReader();
                    if (red.Read()) {
                        myconstr = "server=" + (string)red["constr"] + ";user=xds359839393;pwd=jerry3.14;database=xds359839393_db";
                    }                  
                    mycon.Close();            
                }
                catch (Exception)
                {
                    myconstr = null;
                }
                finally
                {
                    mycon.Close();
                }
                return myconstr;
         }
        public static void updatestr()
        {
            string constr = "provider = microsoft.jet.oledb.4.0; data source = " + _dbpath;
            string comstr = "update tableconstr set [constr]='"+getconstr()+"' where [id]=1";

            OleDbConnection con = new OleDbConnection(constr);

            try
            {
                con.Open();
                OleDbCommand com = new OleDbCommand(comstr, con);
                com.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                con.Close();
            }

        }

    }



}
