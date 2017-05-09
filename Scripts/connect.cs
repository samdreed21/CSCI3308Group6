using UnityEngine;    
using System;     
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using MySql.Data.MySqlClient;    

public class CMySql : MonoBehaviour {    
	public static MySqlConnection dbConnection;//Just like MyConn.conn in StoryTools before    
	static string host = "127.0.0.1";    
	static string id = "root";    
	static string pwd = "1qaz2wsx";  //password  
	static string database = "finalproject";//name of database    
	static string strCommand3="";
	static string strCommand2="";
	public static string strCommand1;
	public static string result="";
	public static DataSet MyObj;
	public static string result1;
	public static float result2;
	public static string depatment;
	public static string couresenumber;
	public static string special;
	public static void main()
	{     
			string connectionString = string.Format("Server = {0}; Database = {1}; User ID = {2}; Password = {3};", host, database, id, pwd);
			openSqlConnection(connectionString);
	    strCommand1 = "Select "+special+" from projectdatafinal where Department = '"+depatment+"'and Course_Number = '"+couresenumber+"';";
		MyObj = GetDataSet(strCommand1);
		result1 = MyObj.Tables[0].Rows[0][0].ToString();
	}    

	// On quit    
	public static void OnApplicationQuit()   
	{    
		closeSqlConnection();    
	}    

	// Connect to database    
	private static void openSqlConnection(string connectionString)   
	{    
		dbConnection = new MySqlConnection(connectionString);    
		dbConnection.Open();    
		result = dbConnection.ServerVersion;  //获得MySql的版本  
	}    

	// Disconnect from database    
	private static void closeSqlConnection()   
	{    
		dbConnection.Close();    
		dbConnection = null;    
	}    

	// MySQL Query    
	public static void doQuery(string sqlQuery)   
	{    
		IDbCommand dbCommand = dbConnection.CreateCommand();        
		dbCommand.CommandText = sqlQuery;    
		IDataReader reader = dbCommand.ExecuteReader();    
		reader.Close();    
		reader = null;    
		dbCommand.Dispose();    
		dbCommand = null;    
	}    
	#region Get DataSet    
	public  static DataSet GetDataSet(string sqlString)    
	{     
		DataSet ds = new DataSet();    
		try    
		{    
			MySqlDataAdapter da = new MySqlDataAdapter(sqlString, dbConnection);    
			da.Fill(ds);    

		}    
		catch (Exception ee)    
		{         
			throw new Exception("SQL:" + sqlString + "\n" + ee.Message.ToString());    
		}    
		return ds;    

	}    
	#endregion     
	/// </summary>
	//读取数据函数  
	/*void ReaderData()  
	{  
		MySqlCommand mySqlCommand = new MySqlCommand("Select * from projectdatafinal;", dbConnection);  
		MySqlDataReader reader = mySqlCommand.ExecuteReader();  
		try  
		{  
			while (reader.Read())  
			{  
				if (reader.HasRows)  
				{  
					print("ID:" + reader.GetInt32(0) + "--Depatment：" + reader.GetString(1) + "--Course_Number：" + reader.GetString(2)+ "--Number_Enrolled：" + reader.GetString(3)+ "--Average_Grade：" + reader.GetString(4)+ "--Percent_A：" + reader.GetString(5)+ "--Percent_B：" + reader.GetString(6)+ "--Hours_per_week：" + reader.GetString(7)+ "--Average_Course_Rating：" + reader.GetString(8)+ "--Average_Instructor_Rating：" + reader.GetString(9));  
				}  
			}  
		}  
		catch (Exception)  
		{  
			Console.WriteLine("查询失败了！");  
		}  
		finally  
		{  
			reader.Close();  
		}           
	} */ 
}  