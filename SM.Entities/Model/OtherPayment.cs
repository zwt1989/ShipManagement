using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace SM.Entities.Model
{
    [TableName("OtherPayment")]
    [PrimaryKey("Id")]
    [ExplicitColumns]
    public class OtherPayment
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public int ShipId { get; set; }

        [Column]
        public string ItemName { get; set; }

        [Column]
        public DateTime OccurTime { get; set; }

        [Column]
        public double MoneyCount { get; set; }

        [Column]
        public int ModifyUser { get; set; }

        [Column]
        public DateTime ModifyTime { get; set; }

        [Column]
        public int RecordStatus { get; set; }
    }
}
