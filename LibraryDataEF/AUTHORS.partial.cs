using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDataEF;
using System.Web.Mvc;

namespace LibraryDataEF
{
    [MetadataType(typeof(AUTHORSMD))]
    partial class AUTHORS
    {
        public class AUTHORSMD
        {
            [HiddenInput(DisplayValue = false)]
            public int AU_ID { get; set; }
            [Required(ErrorMessage ="Це поле не може бути порожнім")]
            [UIHint("String")]
            [Display(Name = "ПІБ автора")]

            public string AU_NAME { get; set; }

            [UIHint("String")]
            [Display(Name = "Інформація")]
            public string AU_INFO { get; set; }
        }
    }
}
