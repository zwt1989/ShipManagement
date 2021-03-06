﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Entities.SearchModel
{
    public class SearchShipShares
    {
        /// <summary>
        /// 记录状态（1:正常，0：删除）
        /// </summary>
        public int? RecordStatusEqual { get; set; }

        /// <summary>
        /// 股权人名字Like
        /// </summary>
        public string SharesHolderNameLike { get; set; }
    }
}
