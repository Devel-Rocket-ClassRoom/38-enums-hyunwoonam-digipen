using System;
using System.Collections.Generic;
using System.Text;

enum Animal
{
    Horse,
    Sheep = 5,
    Monkey
}

[Flags]
enum CharacterStatus
{
    None = 0,
    Poison = 1,
    Paralyzed = 1 << 1,
    Confused = 1 << 2,
    Invisible = 1 << 3
}

[Flags]
enum BuffStatus
{
    None = 0,
    AttackUp = 1,
    DefenseUp = 1 << 1,
    SpeedUp = 1 << 2,
    All = AttackUp | DefenseUp | SpeedUp
}
