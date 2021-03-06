﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Entities.SearchModel
{
    public class SearchCargoType
    {
        /// <summary>
        /// 货物名Like
        /// </summary>
        public string CargoNameLike { get; set; }

        /// <summary>
        /// 记录删除状态（1:正常，0：删除）
        /// </summary>
        public int? RecordStatusEqual { get; set; }
    }
}
