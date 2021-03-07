using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace admini
{
    class  ClassSql
    {
        public static string Constr { get; set; }
        public static string Comstr { get; set; }

        static SqlConnection con;
        static SqlCommand com;
        static SqlDataReader reader;
        static SqlDataAdapter adapter;

        public static Boolean open( string Server) {
            bool iser = false;
            Constr = "server=" + Server + ";user=sa;pwd=sky;database=test";
            con = new SqlConnection(Constr);
            try
            {
                con.Open();
                iser = true;
            }
            catch (Exception)
            {

                iser = false;
            }
            finally {

                con.Close();
            }

            return iser;
        }
        private static void open() {
            Constr = "server=.;user=sa;pwd=sky;database=test";
            con = new SqlConnection(Constr);
            con.Open();
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="Table">表名</param>
        /// <param name="SetName">设置字段</param>
        /// <param name="SetValue">设置值</param>
        /// <param name="GetName">查找的字段</param>
        /// <returns></returns>
        public static object GetValue(string Table,string SetName,string SetValue,string GetName) {
            object obj= null;
            Comstr = "select * from "+Table+" where ["+SetName+"]="+SetValue;
            try
            {
                open();
                com = new SqlCommand(Comstr, con);
                reader = com.ExecuteReader();
                if (reader.Read()) {
                    obj = reader[GetName];
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                reader.Close();
                con.Close();

            }

            return obj;
        }

        public static DataSet Getadapter(string Table) {
            DataSet set = new DataSet();
            try
            {
                Comstr = "select * from " + Table;
                open();
                adapter = new SqlDataAdapter(Comstr, con);
                adapter.Fill(set, Table);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                throw;
            }
            finally
            {
                con.Close();
            }
            return set;
        }
    }
}
