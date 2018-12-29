using LocalVisitTrack.comm;
using MySql.Data.MySqlClient;
using System;

namespace LocalVisitTrack.BLL
{
    /// <summary>
    /// 访问记录
    /// 2018-12-29 johnsing
    /// </summary>
    public class VisitTrackDAL
    {
        public static bool Visit(string sysname, string modname, string memo)
        {
            var sql = string.Format(@"insert into tbl_visit_log(SystemName, ModuleName, Memo)
                                    values(@sysname, @modname, @memo)"
                                    );
            var para = new MySqlParameter[]
            {
                new MySqlParameter("@sysname", sysname),
                new MySqlParameter("@modname", modname),
                new MySqlParameter("@memo", memo),
            };
            int nRet = -1;
            try
            {
                nRet = MySqlClientHelper.ExecuteNonQuery(CustomConfig.ConnStrMain, System.Data.CommandType.Text, sql, para);
            }
            catch(Exception ex)
            {
                //TODO
            }
            
            return nRet > 0;
        }
    }
}