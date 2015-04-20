using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Entities.SearchModel
{
    public class SearchProduceRecord
    {
        /// <summary>
        /// 记录状态（1:正常，0：删除）
        /// </summary>
        public int? RecordStatusEqual { get; set; }
    }
}
