using System;
using System.Runtime.Serialization;

namespace MyPet.Common
{
    public enum PetCategory
    {
        [EnumMember(Value = "Dog")]
        Dog = 0,

        [EnumMember(Value = "Cat")]
        Cat = 1,

        [EnumMember(Value = "Unknown")]
        Unknown = 2,

    }
}
