namespace Dungeons.Models
{
    using System;
    
    public interface ICharacter
    {
        //properties
        public string Name { get; set; }
        public int MaxHitPoints { get; set; }
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public string Weapon { get; set; }
        public int Attack { get; set; }
        public string[] Inventory { get; set; }
        public string Race { get; set; }
        public string CharacterClass { get; set; }
    }

    public class Player : ICharacter
    {
        //Player properties
        public string Name { get; set; }
        public int MaxHitPoints { get; set; }
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public string Weapon { get; set; }
        public int Attack { get; set; }
        public string[] Inventory { get; set; }
        public string Race { get; set; }
        public string CharacterClass { get; set; }
        public int Experience { get; set; } = 0;
        public int Level { get; set; } = 1;

        //Constructor
        public Player(string name, int maxhitpoints, int strength, int intelligence, int wisdom, int dexterity, int constitution, string weapon, string race, string characterclass)
        {
            Name = name;
            MaxHitPoints = maxhitpoints;
            Strength = strength;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Dexterity = dexterity;
            Constitution = constitution;
            Weapon = weapon;
            Race = race;
            CharacterClass = characterclass;
            HitPoints = maxhitpoints;
        }

        //Damage Method
        public void Damaged(int damage)
        {
            HitPoints -= damage;
            if (HitPoints < 0)
            {
                Console.WriteLine($"{Name} has died frome thier injuries.");
                return;
            }

            if (HitPoints > 0)
            {
                Console.WriteLine($"{Name} takes {damage} damage.  Remaining Hit Points is {HitPoints}.");
                return;
            }
        }

        //Healing Method
        public void Healing(int heal)
        {
            HitPoints += heal;
            if (HitPoints > MaxHitPoints)
            {
                HitPoints = MaxHitPoints;
                Console.WriteLine($"{Name} has completely healed, Hit Points are {HitPoints}.");
                return;
            }

            Console.WriteLine($"{Name} has healed some, Hit Points are {HitPoints}.");
        }

        //Print Player Method
        public void PrintPlayer()
        {
            Console.WriteLine($"Character {Name} stats:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Max Hit Points: {MaxHitPoints}");
            Console.WriteLine($"Current Hit Points: {HitPoints}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Wisdom: {Wisdom}");
            Console.WriteLine($"Dexterity: {Dexterity}");
            Console.WriteLine($"Contitution: {Constitution}");
            Console.WriteLine($"Weapon: {Weapon}");
            Console.WriteLine($"Race: {Race}");
            Console.WriteLine($"Class: {CharacterClass}");
            Console.WriteLine($"Experience: {Experience}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Inventory: {Inventory}");
        }
    }

}
