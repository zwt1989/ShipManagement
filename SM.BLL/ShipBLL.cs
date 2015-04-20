using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.DAL;
using SM.Entities.Model;
using SM.Entities.SearchModel;
using SM.Entities.OrderEnum;

namespace SM.BLL
{
    public class ShipBLL
    {
        private readonly ShipDAL _shipDAL = new ShipDAL();

        /// <summary>
        /// 新增轮船实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddShip(Ship item)
        {
            return _shipDAL.AddShip(item);
        }

        /// <summary>
        /// 分页获取轮船列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchEntity"></param>
        /// <param name="orderEnums"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public List<Ship> GetListByPager(int pageIndex, int pageSize, SearchShip searchEntity, IEnumerable<ShipEnum> orderEnums, out int recordCount)
        {
            return _shipDAL.GetListByPager(pageIndex, pageSize, searchEntity, orderEnums, out recordCount);
        }
    }
}
