//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oefening29092020
{
    using System;
    using System.Collections.Generic;
    
    public partial class BoekenGenre
    {
        public int Id { get; set; }
        public int BoekId { get; set; }
        public Nullable<int> GenreId { get; set; }
    
        public virtual Boeken Boeken { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
