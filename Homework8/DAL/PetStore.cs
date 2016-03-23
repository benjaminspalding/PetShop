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
        public PetsStoreContext() : base("PetsStoreContext")
    {

    }

    }
}