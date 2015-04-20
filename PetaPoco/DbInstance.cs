namespace PetaPoco
{
    using System.Configuration;

    /// <summary>
    /// <Remark>作者：李小平 创建日期：2014-11-18</Remark>
    /// <Remark>描述：数据库提供者，返回数据库操作类</Remark>
    /// </summary>
    public class DbInstance
    {
        private static string ConnectionStringName
        {
            get
            {
                ConnectionStringSettings connStr = ConfigurationManager.ConnectionStrings["MemberShipMySqlServer"];

                if (connStr != null)
                {
                    return connStr.Name;
                }
                return "";
            }
        }

        //private static Database _instance = null;
        //private static readonly object SynchroObject = new object();    //线程安全

        /// <summary>
        /// <Remark>作者：李小平 创建日期：2014-11-18 修改日期：2014-11-28</Remark>
        /// <Remark>描述：返回数据库操作类</Remark>
        /// </summary>
        /// <returns>数据库操作类</returns>
        public static Database CreateDataBase()
        {
            //_instance = new Database(ConnectionStringName);
            //if (_instance == null)
            //{
            //    lock (SynchroObject)
            //    {
            //        if (_instance == null)
            //            _instance = new Database(ConnectionStringName);
            //    }
            //}

            return new Database(ConnectionStringName);
        }
    }
}
