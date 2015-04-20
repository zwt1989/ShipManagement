using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace SM.Entities.Model
{
    [TableName("Ship")]
    [PrimaryKey("Id")]
    [ExplicitColumns]
    public class Ship
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public int Tonnage { get; set; }

        [Column]
        public double Price { get; set; }

        [Column]
        public DateTime? BuyingTime { get; set; }

        [Column]
        public int? ModifyUser { get; set; }

        [Column]
        public DateTime? ModifyTime { get; set; }

        [Column]
        public int RecordStatus { get; set; }
    }
}
