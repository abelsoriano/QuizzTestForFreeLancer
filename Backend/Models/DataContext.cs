﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();



        }

        public System.Data.Entity.DbSet<Backend.Models.Answer> Answers { get; set; }

        public System.Data.Entity.DbSet<Backend.Models.Question> Questions { get; set; }

        public System.Data.Entity.DbSet<Backend.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<Backend.Models.UserQuestionAnswer> UserQuestionAnswers { get; set; }

        public System.Data.Entity.DbSet<Backend.Models.VideoLink> VideoLinks { get; set; }

    }
}