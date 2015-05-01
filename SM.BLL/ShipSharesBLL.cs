using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.DAL;
using SM.Entities.Model;
using SM.Entities.OrderEnum;
using SM.Entities.SearchModel;

namespace SM.BLL
{
    public class ShipSharesBLL
    {
        private readonly ShipSharesDAL _shipSharesDAL = new ShipSharesDAL();

        /// <summary>
        /// 新增股份实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddShipShares(ShipShares item)
        {
            return _shipSharesDAL.AddShipShares(item);
        }

        /// <summary>
        /// 根据Id获取股份实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ShipShares GetShipSharesById(int id)
        {
            return _shipSharesDAL.GetSharesById(id);
        }

        /// <summary>
        /// 修改股份实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool UpdateShipShares(ShipShares item)
        {
            return _shipSharesDAL.UpdateShipShares(item);
        }

        /// <summary>
        /// 删除股份实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteShip(int id)
        {
            return _shipSharesDAL.DeleteShipShares(id);
        }

        /// <summary>
        /// 分页获取股份列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchEntity"></param>
        /// <param name="orderEnums"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public List<ShipShares> GetListByPager(int pageIndex, int pageSize, SearchShipShares searchEntity, IEnumerable<ShipSharesEnum> orderEnums, out int recordCount)
        {
            return _shipSharesDAL.GetListByPager(pageIndex, pageSize, searchEntity, orderEnums, out recordCount);
        }
    }
}
