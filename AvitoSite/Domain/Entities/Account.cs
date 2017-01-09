namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Liked = new HashSet<Liked>();
            An = new HashSet<An>();
        }
        [HiddenInput(DisplayValue = false)]
        public Guid ID { get; set; }

        [StringLength(50)]
        [Display(Name = "�����")]
        [Required(ErrorMessage = "������� ���������� �����")]
        public string Login { get; set; }

        [StringLength(50)]
        [Display(Name = "������")]
        [Required(ErrorMessage = "������� ���������� ������")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "������� ���������� ��� ����������� �����")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "���������� ������� ���������� �������� �����")]
        [StringLength(50)]
        [Display(Name = "�����")]
        public string E_mail { get; set; }

        [Required(ErrorMessage = "������� ���������� ���� �������")]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "������� ���������� ���� ���")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "������� ���������� ���� ��������")]
        public string Otch { get; set; }

        [Required(ErrorMessage = "������� ���������� �����, � ������� �� ����������")]
        public string City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liked> Liked { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<An> An { get; set; }
    }
}
