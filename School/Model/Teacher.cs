namespace School.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        public int ID { get; set; }

        public int D_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Touch { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string Passwork { get; set; }
    }
}
