using System;
using System.Collections.Generic;
using SimpleAutoChess;

namespace SimpleAutoChess
{
    public enum Race
    {
        Beast = 50 | 5,
        Human = 45 | 5,
        Goblin = 60 | 10,
        Dragon = 50 | 10,
        Dwarf= 40 | 10
    }
    public enum Class //efek sinergi menambah nilai attack
    {
        Warior = 10,
        Knight = 20,
        Mage  = 5,
        Assassin = 15,
        Merch = 10
    }
    public enum Quality
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }
}