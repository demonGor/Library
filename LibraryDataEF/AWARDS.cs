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
    
    public partial class AWARDS
    {
        public int AW_ID { get; set; }
        public string AW_NAME { get; set; }
        public Nullable<System.DateTime> AW_DATE { get; set; }
        public string AW_INFO { get; set; }
        public int AW_BA { get; set; }
    
        public virtual BOOKS_AUTHORS BOOKS_AUTHORS { get; set; }
    }
}