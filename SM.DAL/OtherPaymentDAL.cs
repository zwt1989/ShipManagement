using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using PetaPoco;
using SM.Entities.Model;
using SM.Entities.OrderEnum;
using SM.Entities.SearchModel;

namespace SM.DAL
{
    public class OtherPaymentDAL
    {
        /// <summary>
        /// 获取其他收支项实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OtherPayment GetOtherPaymentById(int id)
        {
            return DatabaseProvider.SingleOrDefault<OtherPayment>(id);
        }

        /// <summary>
        /// 新增其他收支项实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddOtherPayment(OtherPayment item)
        {
            var obj = DatabaseProvider.Insert(item);
            if (obj != null)
            {
                return Convert.ToInt32(obj) > 0;
            }
            return false;
        }

        /// <summary>
        /// 修改其他收支项实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool UpdateOtherPayment(OtherPayment item)
        {
            var obj = DatabaseProvider.Update(item);
            return Convert.ToInt32(obj) > 0;
        }

        /// <summary>
        /// 获取其他收支项列表
        /// </summary>
        /// <param name="orderEnums"></param>
        /// <param name="searchEntity"></param>
        /// <returns></returns>
        public List<OtherPayment> GetList(IEnumerable<OtherPaymentEnum> orderEnums, SearchOtherPayment searchEntity)
        {
            string sqlStr =
                @"select * from OtherPayment t";
            Sql sql = AppendSqlWhere(sqlStr, "t", searchEntity);
            if (orderEnums != null && orderEnums.Any())
            {
                sql = sql.OrderByT(orderEnums);
            }
            return DatabaseProvider.Query<OtherPayment>(sql).ToList();
        }

        /// <summary>
        /// 附加where条件
        /// </summary>
        /// <param name="initSqlString">sql字符串</param>
        /// <param name="tableAlias">topic表在查询中的别名</param>
        /// <param name="searchEntity">查询条件实体</param>
        /// <returns></returns>
        public Sql AppendSqlWhere(string initSqlString, string tableAlias, SearchOtherPayment searchEntity)
        {
            Sql sql = Sql.Builder.Append(initSqlString);
            if (searchEntity.ShipIdEqual.HasValue)
            {
                sql.Where(string.Format(" {0}.CargoName = {1}", tableAlias, searchEntity.ShipIdEqual.Value));
            }
            return sql;
        }
    }
}
