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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public An()
        {
            Liked = new HashSet<Liked>();
            Photo = new HashSet<Photo>();
        }

        public Guid ID { get; set; }

        public Guid AccountID { get; set; }

        [Display(Name = "���������")]
        public Guid CategoryID { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "���� ���������")]
        public DateTime DateStart { get; set; }

        [Display(Name = "���� ������������")]
        [Column(TypeName = "date")]
        public DateTime? DateFinish { get; set; }

        [StringLength(50)]
        [Display(Name = "�������� ������")]
        public string Name { get; set; }

        [Display(Name = "����")]
        public decimal? Price { get; set; }

        [Display(Name = "��������")]
        public string Description { get; set; }

        public virtual Account Account { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liked> Liked { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photo> Photo { get; set; }
    }
}
