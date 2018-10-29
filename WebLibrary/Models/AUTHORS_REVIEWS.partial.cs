using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebLibrary.Models
{
    [MetadataType(typeof(AUTHORS_REVIEWSMD))]
    partial class AUTHORS_REVIEWS
    {
        public class AUTHORS_REVIEWSMD
        {
            [HiddenInput(DisplayValue = false)]
            public int AR_ID { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int AR_AU { get; set; }

            [Required(ErrorMessage = "Це поле не може бути порожнім")]
            [UIHint("String")]
            [Display(Name = "Відгук")]
            public string AR_R { get; set; }
        }
    }
}
