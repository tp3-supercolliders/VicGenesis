namespace VicGenesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Area
    {
        public int Id { get; set; }

        [Column("​Area_Name​")]
        [Required]
        public string C_Area_Name_ { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Facilities { get; set; }

        [Required]
        public string Population { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Longitude { get; set; }
    }
}
