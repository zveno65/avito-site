namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Liked")]
    public partial class Liked
    {
        public Guid ID { get; set; }

        public Guid AccountID { get; set; }

        public Guid AnID { get; set; }

        public virtual Account Account { get; set; }

        public virtual An An { get; set; }
    }
}
