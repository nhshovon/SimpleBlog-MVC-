//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleBlog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlogPostsPostTag
    {
        public int Id { get; set; }
        public Nullable<int> PostId { get; set; }
        public Nullable<int> TagId { get; set; }
    
        public virtual BlogPost BlogPost { get; set; }
        public virtual BlogPostTag BlogPostTag { get; set; }
    }
}
