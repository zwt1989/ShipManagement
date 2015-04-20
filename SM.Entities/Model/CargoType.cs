using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace SM.Entities.Model
{
    [TableName("CargoType")]
    [PrimaryKey("Id")]
    [ExplicitColumns]
    public class CargoType
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public string CargoName { get; set; }

        [Column]
        public int UnitPrice { get; set; }

        [Column]
        public int ModifyUser { get; set; }

        [Column]
        public DateTime ModifyTime { get; set; }

        [Column]
        public int RecordStatus { get; set; }
    }
}
