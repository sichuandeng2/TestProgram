using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
namespace TestApp
{
    class Classsql
    {
        private static string constr = ClassCheck.getconstr;
       
        private static SqlConnection con;
        private static SqlCommand com;
        
        private static SqlDataReader reader;
        private static SqlDataAdapter adapter;

        /// <summary>
        /// 打开远程数据库
        /// </summary>
        private static void linksql()
        {
            con = new SqlConnection(constr);
            
            try
            {   
                con.Open();         
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                con.Close();
            }

        }
        /// <summary>
        /// 查找数据表还回值
        /// </summary>
        /// <param name="Table">远程数据库需要访问的数据表</param>
        /// <param name="Columne">获取表中的列号</param>
        /// <returns></returns>
        public static object SelectValue(string Table,string ColumneName,string Value,int Columne)
        {
            linksql();
            object GetValue=null;
            string comstr = "select * from "+Table+ " where "+ColumneName+"='"+Value+"'";
            try
            {
                com = new SqlCommand(comstr, con);
               
                reader = com.ExecuteReader();

                if (reader.Read())
                {
                    GetValue = reader.GetValue(Columne);
                }
                else
                {
                    GetValue = null;
                }
            }
            catch 
            {
                con.Close();
                //System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            con.Close();
            return GetValue;
        }
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="comstr">插入sql server 语句</param>
        /// <returns></returns>
        public static string Insert(string comstr)
        {
            string error=null;
            linksql();
            try
            {
                com = new SqlCommand(comstr, con);
                com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
            finally
            {
                con.Close();
            }
            return error;
        }
        /// <summary>
        /// 填充数据库表
        /// </summary>
        /// <param name="Table">要填充的数据表名</param>
        /// <returns></returns>
        public static DataSet getDataSet(string Table)
        {
            DataSet mydata = new DataSet();
            string adapterstr = "select * from "+Table;
            linksql();
            try
            {
                adapter = new SqlDataAdapter(adapterstr, con);
                adapter.Fill(mydata, Table);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message.ToString());
                throw;
            }
            finally
            {
               
                con.Close();
            }
            return mydata;
        }

    }
}
