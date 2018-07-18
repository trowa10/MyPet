using MyPet.Business;
using MyPet.Common.DTO;
using MyPet.Service.Interface;
using System;
using System.Collections.Generic;

namespace MyPet.Service
{
    public class PetProfileService : IPetProfileService
    {
        public List<PetProfileModel> GetPetProfiles()
        {
            return new PetProfileBusiness().GetPetProfiles();
        }
    }
}
