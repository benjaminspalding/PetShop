using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Homework8.Models
{
    public class Pet
    {
        
        public int ID { get; set; }
        public string petName{ get; set; }
        public string petDesc{ get; set; }
        public DateTime dateRecieved{ get; set; }
        public int quantity{ get; set; }
        public decimal price{ get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}