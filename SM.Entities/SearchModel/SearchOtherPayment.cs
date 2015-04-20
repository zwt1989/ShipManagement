using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Entities.SearchModel
{
    public class SearchOtherPayment
    {
        /// <summary>
        /// 关联轮船Id等于
        /// </summary>
        public int? ShipIdEqual { get; set; }

        /// <summary>
        /// 收支发生时间大于等于
        /// </summary>
        public DateTime? OccurTimeEqualAndGreaterThan { get; set; }

        /// <summary>
        /// 收支发生时间小于等于
        /// </summary>
        public DateTime? OccurTimeEqualAndLessThan { get; set; }

        /// <summary>
        /// 记录状态（1:正常，0：删除）
        /// </summary>
        public int? RecordStatusEqual { get; set; }
    }
}
