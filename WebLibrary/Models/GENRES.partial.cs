using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebLibrary.Models
{
    [MetadataType(typeof(GENRESMD))]
    partial class GENRES
    {
        public class GENRESMD
        {
            [HiddenInput(DisplayValue = false)]
            public int GN_ID { get; set; }
            [Required(ErrorMessage = "Це поле не може бути порожнім")]
            [UIHint("String")]
            [Display(Name = "Назва жанру")]
            public string GN_NAME { get; set; }

            [UIHint("String")]
            [Display(Name = "Інформація")]
            public string GN_INFO { get; set; }
        }
    }
}
