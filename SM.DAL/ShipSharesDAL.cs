using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;
using SM.Entities.Model;
using SM.Entities.OrderEnum;
using SM.Entities.SearchModel;

namespace SM.DAL
{
    public class ShipSharesDAL
    {
        /// <summary>
        /// 获取股份实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ShipShares GetSharesById(int id)
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

        /// <summary>
        /// 删除股份实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteShipShares(int id)
        {
            using (var db = DbInstance.CreateDataBase())
            {
                var obj = db.Delete<ShipShares>(id);
                return Convert.ToInt32(obj) > 0;
            }
        }

        /// <summary>
        /// 获取股权信息列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchEntity"></param>
        /// <param name="orderEnums"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public List<ShipShares> GetListByPager(int pageIndex, int pageSize, SearchShipShares searchEntity, IEnumerable<ShipSharesEnum> orderEnums, out int recordCount)
        {
            string sqlStr =
                @"select t.*,s.Name as ShipName,a.Name as ShareHolderName from shipshares t left join ship s on s.Id=t.ShipId left join account a on a.Id=t.ShareHolderId";
            Sql sql = AppendSqlWhere(sqlStr, "t", searchEntity);
            if (orderEnums != null && orderEnums.Any())
            {
                sql = sql.OrderByT(orderEnums);
            }
            return DatabaseProvider.GetEntitiesByPager<ShipShares>(pageIndex, pageSize, sql, out recordCount);
        }

        /// <summary>
        /// 附加where条件
        /// </summary>
        /// <param name="initSqlString">sql字符串</param>
        /// <param name="tableAlias">topic表在查询中的别名</param>
        /// <param name="searchEntity">查询条件实体</param>
        /// <returns></returns>
        public Sql AppendSqlWhere(string initSqlString, string tableAlias, SearchShipShares searchEntity)
        {
            Sql sql = Sql.Builder.Append(initSqlString);
            if (!string.IsNullOrEmpty(searchEntity.SharesHolderNameLike))
            {
                sql.Where(string.Format(" {0}.SharesHolderName like '%{1}%'", tableAlias, searchEntity.SharesHolderNameLike));
            }
            return sql;
        }
    }
}
