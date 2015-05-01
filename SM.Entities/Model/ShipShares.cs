using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace SM.Entities.Model
{
    [TableName("ShipShares")]
    [PrimaryKey("Id")]
    [ExplicitColumns]
    public class ShipShares
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public int ShipId { get; set; }

        /// <summary>
        /// 船名
        /// </summary>
        public string ShipName { get; set; }

        [Column]
        public int ShareHolderId { get; set; }

        /// <summary>
        /// 股权人姓名
        /// </summary>
        public string ShareHolderName { get; set; }

        [Column]
        public int SharesCount { get; set; }

        [Column]
        public int MoneyCount { get; set; }

        [Column]
        public int ModifyUser { get; set; }

        [Column]
        public DateTime ModifyTime { get; set; }

        [Column]
        public int RecordStatus { get; set; }
    }
}
