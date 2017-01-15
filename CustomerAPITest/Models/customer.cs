namespace CustomerAPITest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("development.customer")]
    public partial class customer
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string customer_name { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [Required]
        [StringLength(2)]
        public string region_state { get; set; }

        public DateTime date_added { get; set; }
    }
}
