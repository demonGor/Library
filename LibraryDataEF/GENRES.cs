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
    
    public partial class GENRES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GENRES()
        {
            this.BOOKS_GENRES = new HashSet<BOOKS_GENRES>();
        }
    
        public int GN_ID { get; set; }
        public string GN_NAME { get; set; }
        public string GN_INFO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOKS_GENRES> BOOKS_GENRES { get; set; }
    }
}