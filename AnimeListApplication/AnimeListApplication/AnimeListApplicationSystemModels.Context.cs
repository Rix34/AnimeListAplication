//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimeListApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AnimeDataBaseEntities : DbContext
    {
        public AnimeDataBaseEntities()
            : base("name=AnimeDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Anime> Animes { get; set; }
        public virtual DbSet<AnimeData> AnimeDatas { get; set; }
        public virtual DbSet<AnimeList> AnimeLists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<LoginData> LoginDatas { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
