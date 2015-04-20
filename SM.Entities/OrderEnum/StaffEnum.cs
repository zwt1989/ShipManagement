using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Entities.OrderEnum
{
    public enum StaffEnum
    {
        /// <summary>
        /// 按职位升序
        /// </summary>
        Position_ASC,

        /// <summary>
        /// 按职位降序
        /// </summary>
        Position_DESC,

        /// <summary>
        /// 按所属轮船Id升序
        /// </summary>
        ShipId_ASC,

        /// <summary>
        /// 按所属轮船Id降序
        /// </summary>
        ShipId_DESC
    }
}
