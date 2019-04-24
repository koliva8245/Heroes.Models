﻿namespace Heroes.Models.AbilityTalents
{
    public enum AbilityType
    {
        Q,
        W,
        E,
        Heroic,
        Z,
        Trait,
        Active,
        Passive,
        B,
        Attack,
        Stop,
        Hold,
        Cancel,
        Interact,
        Taunt,
        Dance,
        Spray,
        Voice,
        ForceMove,

        Standard = Q | W | E | Heroic | Z | Trait | Active | Passive | B,
        Misc = Attack | Stop | Stop | Hold | Cancel | Interact | Taunt | Dance | Spray | Voice | ForceMove,
    }
}
