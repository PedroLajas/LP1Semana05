using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace DungeonStats
{
    public class Program
    {
        private static int Damage(int attack, int defense);
        {
            int stat = attack - defense;

            if (stat > 0)
            {
                return stat;
            }
            else
            {
                return 0;
            }
        }
    }
}

