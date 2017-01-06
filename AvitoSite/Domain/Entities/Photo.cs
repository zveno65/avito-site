namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Photo")]
    public partial class Photo
    {
        public Guid ID { get; set; }

        public Guid AnID { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public virtual An An { get; set; }
    }
}
