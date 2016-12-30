namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("An")]
    public partial class An
    {
        [Key]
        public Guid An_id { get; set; }

        public Guid id_account { get; set; }

        public Guid id_category { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateFinish { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public decimal? price { get; set; }

        public string description { get; set; }
    }
}
