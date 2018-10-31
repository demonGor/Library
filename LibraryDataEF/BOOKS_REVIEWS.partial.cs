using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace LibraryDataEF
{
    [MetadataType(typeof(BOOKS_REVIEWSMD))]
    partial class BOOKS_REVIEWS
    {
        public class BOOKS_REVIEWSMD
        {
            [HiddenInput(DisplayValue = false)]
            public int BR_ID { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int BR_BK { get; set; }

            [Required(ErrorMessage = "Це поле не може бути порожнім")]
            [UIHint("String")]
            [Display(Name = "Відгук")]
            public string BR_R { get; set; }
        }
    }
}
