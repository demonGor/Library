using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LibraryDataEF
{
    [MetadataType(typeof(BOOKS_GENRESMD))]
    partial class BOOKS_GENRES
    {
        public class BOOKS_GENRESMD
        {
            [HiddenInput(DisplayValue = false)]
            public int BG_ID { get; set; }
            [HiddenInput(DisplayValue = false)]
            public int BG_GN { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int BG_BK { get; set; }
            
        }
    }
}
