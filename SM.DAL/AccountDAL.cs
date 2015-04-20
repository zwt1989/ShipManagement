using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using PetaPoco;
using SM.Entities.Model;

namespace SM.DAL
{
    public class AccountDAL
    {
        /// <summary>
        /// 获取账号
        /// </summary>
        /// <param name="name"></param>
        /// <param name="psd"></param>
        /// <returns></returns>
        public Account GetAccount(string name, string psd)
        {
            return DatabaseProvider.SingleOrDefault<Account>("select * from account where name=@0 and password =@1", name, psd);
        }
    }
}
