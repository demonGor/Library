using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace WebLibrary.Models
{
    [MetadataType(typeof(BOOKSMD))]
    partial class BOOKS
    {
        public class BOOKSMD
        {
            [HiddenInput(DisplayValue = false)]
            public int BK_ID { get; set; }
            [Required(ErrorMessage = "Це поле не може бути порожнім")]
            [UIHint("String")]
            [Display(Name ="Назва книги")]
            public string BK_NAME { get; set; }
            [Required(ErrorMessage = "Це поле не може бути порожнім")]
            [Range(0,10,ErrorMessage ="Рейтинг повинен бути в межах від 1 до 10")]
            [Display(Name = "Рейтинг")]
            public int BK_RATING { get; set; }
            [HiddenInput(DisplayValue =false)]
            public int BK_DAC { get; set; }
            [Display(Name ="Інформація")]
            [UIHint("String")]
            public string BK_INFO { get; set; }
        }
    }
  
}
