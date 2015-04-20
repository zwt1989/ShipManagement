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
    public class CargoTypeDAL
    {
        /// <summary>
        /// 获取货物类型实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CargoType GetCargoTypeById(int id)
        {
            return DatabaseProvider.SingleOrDefault<CargoType>(id);
        }

        /// <summary>
        /// 新增货物类型实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddCargoType(CargoType item)
        {
            var obj = DatabaseProvider.Insert(item);
            if (obj != null)
            {
                return Convert.ToInt32(obj) > 0;
            }
            return false;
        }

        /// <summary>
        /// 修改货物类型实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool UpdateCargoType(CargoType item)
        {
            var obj = DatabaseProvider.Update(item);
            return Convert.ToInt32(obj) > 0;
        }

        /// <summary>
        /// 获取货物类型列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchEntity"></param>
        /// <param name="orderEnums"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public List<CargoType> GetListByPager(int pageIndex, int pageSize, SearchCargoType searchEntity, IEnumerable<CargoTypeEnum> orderEnums, out int recordCount)
        {
            string sqlStr =
                @"select * from cargotype t";
            Sql sql = AppendSqlWhere(sqlStr, "t", searchEntity);
            if (orderEnums != null && orderEnums.Any())
            {
                sql = sql.OrderByT(orderEnums);
            }
            return DatabaseProvider.GetEntitiesByPager<CargoType>(pageIndex, pageSize, sql, out recordCount);
        }

        /// <summary>
        /// 附加where条件
        /// </summary>
        /// <param name="initSqlString">sql字符串</param>
        /// <param name="tableAlias">topic表在查询中的别名</param>
        /// <param name="searchEntity">查询条件实体</param>
        /// <returns></returns>
        public Sql AppendSqlWhere(string initSqlString, string tableAlias, SearchCargoType searchEntity)
        {
            Sql sql = Sql.Builder.Append(initSqlString);
            if (!string.IsNullOrEmpty(searchEntity.CargoNameLike))
            {
                sql.Where(string.Format(" {0}.CargoName like '%{1}%'", tableAlias, searchEntity.CargoNameLike));
            }
            return sql;
        }
    }
}
