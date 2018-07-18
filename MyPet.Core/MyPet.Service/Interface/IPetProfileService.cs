using MyPet.Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Service.Interface
{
    public interface IPetProfileService
    {
        List<PetProfileModel> GetPetProfiles();
    }
}
