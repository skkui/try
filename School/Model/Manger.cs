namespace School.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Manger")]
    public partial class Manger
    {
        public int ID { get; set; }

        public int Passwork { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }
    }
}
