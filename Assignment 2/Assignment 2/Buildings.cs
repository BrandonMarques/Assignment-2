﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    abstract class Building
    {
        protected int x;
        protected int y;
        protected int health;
        protected int maxHealth;
        protected string faction;
        protected char symbol;
        protected bool isDestroyed = false;

        public Building(int x, int y, int health, string faction, char symbol) // constructor for building
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.maxHealth = health;
            this.faction = faction;
            this.symbol = symbol;
        }

        public Building() { }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Faction
        {
            get { return faction; }
        }

        public char Symbol
        {
            get { return symbol; }
        }

        public abstract void Destroy(); // calling the destroy, save methods 

        public abstract string Save();

        public override string ToString()
        {
            return
               "Faction: " + faction + Environment.NewLine +
               "Position: " + x + ", " + y + Environment.NewLine +
         "Health: " + health + " / " + maxHealth + Environment.NewLine;
        }

        public enum ResourceType // resource list 
        {
            WOOD,
            FOOD,
            ROCK,
            GOLD
        }

        public enum FactoryType // factory type
        {
            MELEE,
            RANGE
        }
    }
}
