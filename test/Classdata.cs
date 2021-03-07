using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace TestApp

{
    public class Classdata
    {
        //static public string path = Application.StartupPath;
       
        private OleDbConnection con;
        private OleDbCommand com;
        private OleDbDataAdapter dadp;
        private OleDbDataReader rd;
        private int _totalValue;
        
        public int TotalValue
        {
            get
            {
                if(_totalValue==0)
                {
                    MessageBox.Show("未对数据初始化", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return _totalValue;
            }
        }

        public static string Web {
            get {
                return "http://www.testbcxg.cn/";
            }
        }
                //构造默认路径
        public Classdata()
        {
            con = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" +rePath());
        }
        /// <summary>
        /// 构造绝对路径数据连接
        /// </summary>
        /// <param name="str">指定文件路径</param>
        public Classdata(string str)
        {
            string constr = "provider=microsoft.jet.oledb.4.0;data source=";
            constr += str;
            con.ConnectionString = constr;
        }
        /// <summary>
        /// com所有函数集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string data(string sql)
        {
            try
            {
                con.Open();
                com = new OleDbCommand(sql, con);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return "";

        }
        /// <summary>
        /// 更改数据
        /// </summary>
        /// <param name="TableName">要修改工作表名称</param>
        /// <param name="SetHeadColumn">设置数据的列名</param>
        /// <param name="SetValue">设置的值</param>
        /// <param name="WhereHeadColumn">标准列名称</param>
        /// <param name="WhereValue">标准值</param>
        /// <returns></returns>
        public string UpDate(string TableName,string SetHeadColumn,string SetValue,string WhereHeadColumn,string WhereValue)
        {
            string sql = "UpDate "+TableName+" set " +SetHeadColumn+"='"+SetValue+"' where "+WhereHeadColumn+"="+WhereValue;
            try
            {
                con.Open();
                com = new OleDbCommand(sql, con);
                com.ExecuteNonQuery();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            finally
            {
                con.Close();
            }
            return "";
        }
       /// <summary>
       /// 查找数据
       /// </summary>
       /// <param name="Table">表明</param>
       /// <param name="Columnhead">列名称</param>
       /// <param name="columnval">列值</param>
       /// <param name="Column">第几列数据</param>
       /// <returns></returns>
        public object dataselect(string Table,string Columnhead,string columnval,int  Column)
        {
            object obj = "";
            try
            {
                con.Open();
                com = new OleDbCommand("select * from " + Table + " where " + Columnhead + "='" + columnval+"'", con);
                rd = com.ExecuteReader();

                if (rd.Read())
                {
                   obj = rd.GetValue(Column);
                }
                rd.Close();
            }
            catch (Exception ex )
            {
               
               obj = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return obj;
        }
        /// <summary>
        /// 填充数据
        /// </summary>
        /// <param name="StartValue">起始值</param>
        /// <param name="PageValue">列数量</param>
        /// <param name="TableName">表名</param>
        /// <returns></returns>
        public DataSet GetData(int StartValue ,int PageValue,string TableName)
        {
            DataSet myset= GetData("myqd");
            myset.Clear();
            dadp.Fill(myset,StartValue,PageValue,TableName);
            return myset;
        }

        /// <summary>
        /// 填充数据
        /// </summary>
        /// <param name="Table">表名</param>
        /// <returns></returns>
        public DataSet GetData(string Table)
        {
           
            DataSet mydata = new DataSet("mydata");
         
            try
            {
                con.Open();
                string sql = "select * from "+Table;
                dadp = new OleDbDataAdapter(sql, con);
                dadp.Fill(mydata, Table);
                _totalValue = mydata.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);       
            }
            finally
            {
                con.Close();
            }
            return mydata;
        }
  
        /// <summary>
        /// 生成文件路径
        /// </summary>
        /// <returns></returns>
        static public string rePath()
        {
            string path = Application.StartupPath + @"\mydata.mdb";
            if (!File.Exists(path))
                path = @"E:\sky\inherent\study\computer\visual studio\csharp\test\mydata.mdb";
            return path;

        }

        public static void update()
        {
            string constr = "provider = microsoft.jet.oledb.4.0; data source = " + rePath();
            string comstr = "update isadmin set [islond]=0 where [id]=2";

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
