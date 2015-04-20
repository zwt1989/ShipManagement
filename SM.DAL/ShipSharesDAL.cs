using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;
using SM.Entities.Model;

namespace SM.DAL
{
    public class ShipSharesDAL
    {
        /// <summary>
        /// 获取股份实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ShipShares GetProduceRecordById(int id)
        {
            return DatabaseProvider.SingleOrDefault<ShipShares>(id);
        }

        /// <summary>
        /// 新增股份实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddShipShares(ShipShares item)
        {
            var obj = DatabaseProvider.Insert(item);
            if (obj != null)
            {
                return Convert.ToInt32(obj) > 0;
            }
            return false;
        }

        /// <summary>
        /// 修改股份实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool UpdateShipShares(ShipShares item)
        {
            var obj = DatabaseProvider.Update(item);
            return Convert.ToInt32(obj) > 0;
        }
    }
}
