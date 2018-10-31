using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace LibraryDataEF
{
   [MetadataType(typeof(DICTIONARY_AGE_CATEGORIESMD))]
   partial class DICTIONARY_AGE_CATEGORIES
    {
        public class DICTIONARY_AGE_CATEGORIESMD
        {
            [HiddenInput(DisplayValue =false)]
            public int DAC_ID { get; set; }
            [Required(ErrorMessage = "Це поле не може бути порожнім")]
            [UIHint("String")]
            [Display(Name = "Назва вікової категорії")]

            public string DAC_NAME { get; set; }
            [Range(0, 80, ErrorMessage = "Повинно бути в межах від 0 до 80")]
            [UIHint("Int32")]
            [Required(ErrorMessage = "Це поле не може бути порожнім або не цілим числом")]
            [Display(Name = "Від")]
            

            public int DAC_FROM { get; set; }
            [Range(0, 80, ErrorMessage = "Повинно бути в межах від 0 до 80")]
            [UIHint("Int32")]
            [Required(ErrorMessage = "Це поле не може бути порожнім або не цілим числом")]
            [Display(Name = "До")]

            public int DAC_TO { get; set; }

            [Display(Name = "Інформація")]

            public int DAC_INFO { get; set; }



        }
    }
}
