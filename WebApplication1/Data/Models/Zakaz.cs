using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Models
{
    public class Zakaz
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите ФИО")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина поля не менее 5 символов")]
        public string name { get; set; }
        [Display(Name = "Введите Адрес")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина поля не менее 5 символов")]
        public string adress { get; set; }
        [Display(Name = "Введите Номер телефона")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина поля не менее 5 символов")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }
        [Display(Name = "Введите Email")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина поля не менее 10 символов")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime zakazTime { get; set; }
        public List<ZakazDetail> zakazDetail { get; set; }


    }
}
