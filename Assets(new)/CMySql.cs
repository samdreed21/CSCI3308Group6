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
	static string pwd = "houym1996813";  //password  
	static string database = "wanghou";//name of database    
	static string result = "";
    static string strCommand2="MATH";
	private string strCommand = "Select * from projectdatafinal;";    
	public static DataSet MyObj;
    public static DataSet result2;
    bool is_click;
    bool is_click2;
    void OnGUI()    
	{    
		host = GUILayout.TextField( host, 200, GUILayout.Width(200));    
		id = GUILayout.TextField( id, 200, GUILayout.Width(200));    
		pwd = GUILayout.TextField( pwd, 200, GUILayout.Width(200));
        strCommand2= GUILayout.TextField(strCommand2, 200, GUILayout.Width(200));

        if (GUILayout.Button("Test"))    
		{
            string connectionString = string.Format("Server = {0}; Database = {1}; User ID = {2}; Password = {3};", host, database, id, pwd);
            openSqlConnection(connectionString);
            MyObj = GetDataSet(strCommand);
            

            //读取数据函数  
            ReaderData();
            is_click = true;
		}     
		GUILayout.Label(result);
        if (is_click)
        {
            for (int i = 0; i < MyObj.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < MyObj.Tables[0].Columns.Count; j++)
                {
                    GUI.Box(new Rect(100 + (50 * j), 100 + (i * 40), 50, 40), MyObj.Tables[0].Rows[i][j].ToString());
                }
            }
        }
        if (GUILayout.Button("Test2"))
        {
            string connectionString = string.Format("Server = {0}; Database = {1}; User ID = {2}; Password = {3};", host, database, id, pwd);
            openSqlConnection(connectionString);
            string commd = "Select * from projectdatafinal where Department = '"+strCommand2+"';";
            result2 = GetDataSet(commd);
            is_click2 = true;
        }
        if (is_click2)
        {
            for (int a = 0; a < result2.Tables[0].Rows.Count; a++)
            {
                for (int b = 0; b < result2.Tables[0].Columns.Count; b++)
                {
                    GUI.Box(new Rect(100 + (50 * b), 100 + (a * 40), 50, 40), result2.Tables[0].Rows[a][b].ToString());
                }
            }
        }
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
	public  DataSet GetDataSet(string sqlString)    
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

	//读取数据函数  
	void ReaderData()  
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
	}  
}  