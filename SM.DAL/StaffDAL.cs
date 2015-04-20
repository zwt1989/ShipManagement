using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using PetaPoco;
using SM.Entities.Model;

namespace SM.DAL
{
    public class StaffDAL
    {
        /// <summary>
        /// 获取员工实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Staff GetStaffById(int id)
        {
            return DatabaseProvider.SingleOrDefault<Staff>(id);
        }

        /// <summary>
        /// 新增员工实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddStaff(Staff item)
        {
            var obj = DatabaseProvider.Insert(item);
            if (obj != null)
            {
                return Convert.ToInt32(obj) > 0;
            }
            return false;
        }

        /// <summary>
        /// 修改员工实体
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool UpdateStaff(Staff item)
        {
            var obj = DatabaseProvider.Update(item);
            return Convert.ToInt32(obj) > 0;
        }
    }
}
