﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Blog_Db_Entities : DbContext
    {
        public Blog_Db_Entities()
            : base("name=Blog_Db_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BlogPostCategory> BlogPostCategories { get; set; }
        public virtual DbSet<BlogPost> BlogPosts { get; set; }
        public virtual DbSet<BlogPostsPostCategory> BlogPostsPostCategories { get; set; }
        public virtual DbSet<BlogPostsPostTag> BlogPostsPostTags { get; set; }
        public virtual DbSet<BlogPostTag> BlogPostTags { get; set; }
        public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
        public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
    }
}
