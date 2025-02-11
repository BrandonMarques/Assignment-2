﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class MeleeUnit : Unit
    {

        public MeleeUnit(int x, int y, string faction) : base(x, y, 200, 2, 20, 1, faction, '*', "Swordsman")
        {

        }

        public MeleeUnit(string values) : base(values)
        {

        }

        public override string Save()
        {
            return string.Format(
              $"Melee,{x},{y},{health},{maxHealth},{speed},{attack},{attackRange}," +
              $"{faction},{symbol},{name},{isDestroyed}");
        }
    }
}

