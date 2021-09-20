using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DataLayer.ViewModels
{
    public class EmailInfo
    {
        [Required(ErrorMessage = "الاسم حقل إجباري")]
        [Display(Name = "الاسم")]
        public string Name { get; set; }

        [Required(ErrorMessage = "البريدالالكتروني حقل إجباري")]
        
        [EmailAddress(ErrorMessage = "البريد الالكتروني غير صحيح")]
        [Display(Name = "البريد الالكتروني")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "رقم الهاتف حقل إجباري")]
        [Display(Name = "رقم الهاتف")]
        public string Phoneumer { get; set; }


        [Required(ErrorMessage = "الأسئلة والاستفسارات حقل إجباري")]
        [Display(Name = "الأسئلة والاستفسارات")]
        public string Comments { get; set; }
    }
}
