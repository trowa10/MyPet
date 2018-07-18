using MyPet.Common;
using MyPet.Common.DTO;
using System;
using System.Collections.Generic;

namespace MyPet.Persistense
{
    //Layer to retrieved data from the database
    public class PetProfilePersistence
    {
        public List<PetProfileModel> GetPetProfiles()
        {
         
            return (new List<PetProfileModel>() {
               new PetProfileModel {
                Id = new Guid("753960a3-5ca1-426d-a810-708be592cc99"),
                Name = "Rover",
                Description = "",
                Category = PetCategory.Dog.ToString()
               },
                new PetProfileModel {
                Id = new Guid("ca49fb02-4db0-49c1-b587-dadc0da9970b"),
                Name = "Fido",
                Description = "",
                Category = PetCategory.Dog.ToString()
               },
                new PetProfileModel {
                Id = new Guid("ca49fb02-4db0-49c1-b587-dadc0da9970b"),
                Name = "Pixie",
                Description = "",
                Category = PetCategory.Cat.ToString()
               },
            });


        }
    }
}
