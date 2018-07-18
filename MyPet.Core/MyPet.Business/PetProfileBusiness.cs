using MyPet.Common.DTO;
using MyPet.Persistense;
using System;
using System.Collections.Generic;

namespace MyPet.Business
{
    public class PetProfileBusiness 
    {
        public List<PetProfileModel> GetPetProfiles()
        {
            return new PetProfilePersistence().GetPetProfiles();
        }
    }
}
