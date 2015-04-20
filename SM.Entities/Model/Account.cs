using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace SM.Entities.Model
{
    [TableName("Account")]
    [PrimaryKey("Id")]
    [ExplicitColumns]
    public class Account
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Password { get; set; }

        [Column]
        public int ModifyUser { get; set; }

        [Column]
        public DateTime ModifyTime { get; set; }

        [Column]
        public int RecordStatus { get; set; }
    }
}
