using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;
using SM.Entities.Model;

namespace SM.DAL
{
    public class ProduceRecordDAL
    {
        /// <summary>
        /// 获取生产记录实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProduceRecord GetProduceRecordById(int id)
        {
            return DatabaseProvider.SingleOrDefault<ProduceRecord>(id);
        }

        /// <summary>
        /// 新增生产记录实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddProduceRecord(ProduceRecord item)
        {
            var obj = DatabaseProvider.Insert(item);
            if (obj != null)
            {
                return Convert.ToInt32(obj) > 0;
            }
            return false;
        }

        /// <summary>
        /// 修改生产记录实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool UpdateProduceRecord(ProduceRecord item)
        {
            var obj = DatabaseProvider.Update(item);
            return Convert.ToInt32(obj) > 0;
        }
    }
}
