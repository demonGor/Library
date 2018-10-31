using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebLibrary.Models
{
    [MetadataType(typeof(BOOKS_SOURCESMD))]
    partial class BOOKS_SOURCES
    {
        public class BOOKS_SOURCESMD
        {
            [HiddenInput(DisplayValue = false)]
            public int BS_ID{ get; set; }

            [HiddenInput(DisplayValue = false)]
            public int BS_BK { get; set; }

            [Required(ErrorMessage = "Це поле не може бути порожнім")]
            [UIHint("String")]
            [Display(Name = "Посилання")]
            public string BS_S { get; set; }
            [Display(Name = "Інформація")]
            [UIHint("String")]
            public string BS_INFO { get; set; }
        }
    }
}
