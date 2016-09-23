using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// 实现数据的增删该查
/// </summary>
public class MysqlOperate
{
	/// <summary>
    /// 实现insert delete update操作
	/// </summary>
	/// <param name="sqls">传入sql语句数组</param>
	/// <returns></returns>
    public Boolean IDU(String[] sqls) {
        MySqlConnection con = null;
        MysqlHelper mh = null;
        MySqlCommand msc = null;
        String sql = null;
        try {
            //数据库操作
            con = MysqlHelper.Connection();
            mh = new MysqlHelper();
            mh.OpenConnection();
            foreach (String s in sqls) {
                sql += s;
            }
            msc = new MySqlCommand(sql, con);
            msc.ExecuteNonQuery();
        } catch (Exception) {
            return false;
        } finally {
            mh.CloseConnection();
        }
        return true;
    }

    public List<Object> S(String sql) {
        List<Object> datas = new List<Object>();
        MySqlConnection con = MysqlHelper.Connection();
        MysqlHelper mh = new MysqlHelper();
        mh.OpenConnection();
        MySqlCommand msc = new MySqlCommand(sql, con);
        MySqlDataReader mdr = msc.ExecuteReader(CommandBehavior.CloseConnection);
        while (mdr.Read()) {
            //需要读取一行数据
        }
        mh.CloseConnection();
        return datas;
    }
}