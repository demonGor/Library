//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOOKS_REVIEWS
    {
        public int BR_ID { get; set; }
        public int BR_BK { get; set; }
        public string BR_R { get; set; }
    
        public virtual BOOKS BOOKS { get; set; }
    }
}