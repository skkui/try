namespace School.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Plan")]
    public partial class Plan
    {
        public int ID { get; set; }

        public int L_ID { get; set; }

        public int T_ID { get; set; }

        public int C_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Time { get; set; }
    }
}
