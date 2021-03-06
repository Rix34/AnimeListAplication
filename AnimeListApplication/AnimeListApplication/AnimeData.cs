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
    using System.Collections.Generic;
    
    public partial class AnimeData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnimeData()
        {
            this.AnimeLists = new HashSet<AnimeList>();
        }
    
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Title { get; set; }
        public int GenreID { get; set; }
        public System.DateTime Aired { get; set; }
        public int StudioID { get; set; }
    
        public virtual Genre Genre { get; set; }
        public virtual Studio Studio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnimeList> AnimeLists { get; set; }
    }
}
