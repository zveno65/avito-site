namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;
    [Table("An")]
    public partial class An
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public An()
        {
            Liked = new HashSet<Liked>();
            Photo = new HashSet<Photo>();
        }

        [HiddenInput(DisplayValue = false)]
        [Display(Name ="ID")]
        public Guid ID { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Display(Name = "AccID")]
        public Guid AccountID { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Display(Name = "CatID")]
        public Guid CategoryID { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "начало")]
        [Editable(false)]
        public DateTime DateStart { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "конец")]
        public DateTime? DateFinish { get; set; }

        [StringLength(50)]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Цена")]
        public decimal? Price { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Account")]
        public virtual Account Account { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Category")]
        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Liked")]
        public virtual ICollection<Liked> Liked { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Photo")]
        public virtual ICollection<Photo> Photo { get; set; }
    }
}
