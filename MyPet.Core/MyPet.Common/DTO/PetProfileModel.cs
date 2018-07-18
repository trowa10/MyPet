using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Common.DTO
{    public class PetProfileModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
