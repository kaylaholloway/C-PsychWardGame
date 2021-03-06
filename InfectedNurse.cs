﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    public class InfectedNurse: IEnemy
    {
        private readonly string name = "Infected Nurse";
        public override string Name { get { return name; } }

        private int attack;
        public override int Attack { get { return attack; } set { attack = value; } }
        private int health;
        public override int Health { get { return health; } set { health = value; } }

        private int hitProbability;
        public override int HitProbability { get { return hitProbability; } }

        private int playerExp;
        public override int PlayerExp { get { return playerExp; } set { playerExp = value; } }
        private int numItems;
        public override int NumItems { get { return numItems; } }
        /*private I_Item drops = new FirstAidKit();
        public override I_Item getDrops()
        {
            return new FirstAidKit();
        } */
        private I_Item[] list = { new RatTail(), new FirstAidKit(), new BandAid() };
        private Dictionary<int, I_Item> drops;
        public override Dictionary<int, I_Item> Drops { get { return drops; } }
        public override I_Item getDrops(int num)
        {
            return Drops[num];
        }
        public override int killValue()
        {
            return 100;
        }
        public InfectedNurse()
        {
            attack = 4;
            health = 13;
            hitProbability = 2;
            playerExp = 5;
            numItems = 2;
            drops = new Dictionary<int, I_Item>();
            for (int i = 0; i < list.Length; i++)
            {
                drops[i] = list[i];
            }
        }
        public override string battleGreeting()
        {
            return "The Infected Nurse is coming at you!";
        }

        //Description of the Rat attacking the player to display. We can write more these in this method
        //and make it so that random ones display each time. 
        public override string attackDescription()
        {
            return "\nThe Infected Nurse stabs you with a nasty syringe!";
        }
    }
}
