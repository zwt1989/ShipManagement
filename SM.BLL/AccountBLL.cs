using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.DAL;
using SM.Entities.Model;

namespace SM.BLL
{
    public class AccountBLL
    {
        private readonly AccountDAL _accountDAL = new AccountDAL();

        /// <summary>
        /// 获取账号信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="psd"></param>
        /// <returns></returns>
        public Account GetAccount(string name, string psd)
        {
            return _accountDAL.GetAccount(name, psd);
        }
    }
}
