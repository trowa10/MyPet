using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPet.Common.DTO;
using MyPet.Service.Interface;

namespace MyPet.Core.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PetProfileController : Controller
    {
        private readonly IPetProfileService _petProfile;
        public PetProfileController(IPetProfileService petProfile)
        {
            this._petProfile = petProfile;
        }

        [HttpGet]
        public IEnumerable<PetProfileModel> Get()
        {
            return this._petProfile.GetPetProfiles();
        }
    }
}