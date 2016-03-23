using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Homework8.Models;

namespace Homework8.DAL
{
    public class PetStoreInitializer
    {
        protected void Seed(PetStoreContext context)
        {
            var pets = new List<Pet>
            {
                new Pet{ID=1,petName="Cat",petDesc="Cats are wonderful to have around the house", dateRecieved=DateTime.Parse("2016-03-01"),quantity=5,price=55.55m}
            };

            pets.ForEach(p => context.PetStore.Add(p));
            context.SaveChanges();
        }
    }
}