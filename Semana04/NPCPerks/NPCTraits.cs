using System;

namespace NPCPerks
{
    [Flags]
    public enum NPCTraits
    {
        Strenght = 1 << 0,
        Agility = 1 << 1,
        Charisma = 1 << 2,
        Luck = 1 << 3


    }
}
