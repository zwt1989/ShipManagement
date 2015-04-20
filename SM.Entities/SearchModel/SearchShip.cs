using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Entities.SearchModel
{
    public class SearchShip
    {
        /// <summary>
        /// 记录状态（1:正常，0：删除）
        /// </summary>
        public int? RecordStatusEqual { get; set; }

        /// <summary>
        /// 轮船名Like
        /// </summary>
        public string ShipNameLike { get; set; }
    }
}
