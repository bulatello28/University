﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University.AdoApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UniversityEntities : DbContext
    {
        public UniversityEntities()
            : base("name=UniversityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcademicLoad> AcademicLoad { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ControlWork> ControlWork { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<StudyYear> StudyYear { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
    }
}