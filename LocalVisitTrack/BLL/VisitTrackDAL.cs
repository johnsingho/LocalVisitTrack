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
        private static readonly string SQL_VISIT_LOG = @"insert into tbl_visit_log(SystemName, ModuleName, LoginUser, Memo)
                                                        values(@sysname, @modname, @loginuser, @memo)
                                                        ";
        public static bool Visit(string sysname, string modname, string loginuser, string memo)
        {
            if (string.IsNullOrEmpty(sysname)) { return false; }

            var sql = SQL_VISIT_LOG;
            var para = new MySqlParameter[]
            {
                new MySqlParameter("@sysname", sysname),
                new MySqlParameter("@modname", modname),
                new MySqlParameter("@loginuser", loginuser),
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