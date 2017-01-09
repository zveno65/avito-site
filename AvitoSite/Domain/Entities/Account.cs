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
        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Введите пожалуйста логин")]
        public string Login { get; set; }

        [StringLength(50)]
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Введите пожалуйста пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Введите пожалуйста ваш электронный адрес")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Пожалуйста введите корректный почтовый адрес")]
        [StringLength(50)]
        [Display(Name = "Почта")]
        public string E_mail { get; set; }

        [Required(ErrorMessage = "Введите пожалуйста вышу фамилию")]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Введите пожалуйста ваше имя")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите пожалуйста ваше отчество")]
        public string Otch { get; set; }

        [Required(ErrorMessage = "Введите пожалуйста город, в котором вы проживаете")]
        public string City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liked> Liked { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<An> An { get; set; }
    }
}
