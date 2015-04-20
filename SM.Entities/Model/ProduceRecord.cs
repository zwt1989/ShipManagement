using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace SM.Entities.Model
{
    [TableName("ProduceRecord")]
    [PrimaryKey("Id")]
    [ExplicitColumns]
    public class ProduceRecord
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public int ShipId { get; set; }

        [Column]
        public int CargoId { get; set; }

        [Column]
        public DateTime TransTime { get; set; }

        [Column]
        public double Count { get; set; }

        [Column]
        public int ModifyUser { get; set; }

        [Column]
        public DateTime ModifyTime { get; set; }

        [Column]
        public int RecordStatus { get; set; }
    }
}
