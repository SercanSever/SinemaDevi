//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SinemaDevi.Entities.Concrete
{
    using System;
    using System.Collections.Generic;
    
    public partial class TvSeriesCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int TvSeriesId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Tv Tv { get; set; }
    }
}
