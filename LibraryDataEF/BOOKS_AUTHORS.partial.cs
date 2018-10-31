using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace LibraryDataEF
{
    [MetadataType(typeof(BOOKS_AUTHORSMD))]
    partial class BOOKS_AUTHORS
    {
        public class BOOKS_AUTHORSMD
        {
            [HiddenInput(DisplayValue = false)]
            public int BA_ID { get; set; }
            [HiddenInput(DisplayValue = false)]
            public int BA_BK { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int BA_AU { get; set; }

        }
    }
}
