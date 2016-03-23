using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Homework8.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Homework8.DAL
{
    public class PetStoreContext : DbContext
    {
        public PetStoreContext() : base("PetStoreContext")
        { }

        public DbSet<Pet> PetStore { get; set; }
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}