﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebLibrary.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBLibraryEntities1 : DbContext
    {
        public DBLibraryEntities1()
            : base("name=DBLibraryEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AUTHORS> AUTHORS { get; set; }
        public virtual DbSet<AUTHORS_REVIEWS> AUTHORS_REVIEWS { get; set; }
        public virtual DbSet<BOOKS> BOOKS { get; set; }
        public virtual DbSet<BOOKS_REVIEWS> BOOKS_REVIEWS { get; set; }
        public virtual DbSet<BOOKS_SOURCES> BOOKS_SOURCES { get; set; }
        public virtual DbSet<BOOKS_AUTHORS> BOOKS_AUTHORS { get; set; }
        public virtual DbSet<BOOKS_GENRES> BOOKS_GENRES { get; set; }
        public virtual DbSet<DICTIONARY_AGE_CATEGORIES> DICTIONARY_AGE_CATEGORIES { get; set; }
        public virtual DbSet<GENRES> GENRES { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}