using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Entities.OrderEnum
{
    public enum ShipSharesEnum
    {
        /// <summary>
        /// 按股份所属轮船Id升序
        /// </summary>
        ShipId_ASC,

        /// <summary>
        /// 按股份所属轮船Id降序
        /// </summary>
        ShipId_DESC,

        /// <summary>
        /// 按股东Id升序
        /// </summary>
        ShareHolderId_ASC,

        /// <summary>
        /// 按股东Id降序
        /// </summary>
        ShareHolderId_DESC
    }
}
