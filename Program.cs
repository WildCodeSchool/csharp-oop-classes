using System;

namespace S5___Oriented_Object_Paradigm___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character();
            Character character2 = new Character();
            
            character1.name = "jean-françois";
            character1.lifePoints = 100;
            character1.strength = 10;
            character1.defense = 5;

            character2.name = "albert";
            character2.lifePoints = 100;
            character2.strength = 10;
            character2.defense = 3;
            
            while (character1.IsAlive() || character2.IsAlive())
            {
                character1.Attack(character2);
                character2.Attack(character1);
            }
            Console.WriteLine("Fight has ended");
        }
    }

    class Character
    {
        public string name;
        public int lifePoints;
        public int strength;
        public int defense;

        public bool IsAlive()
        {
            if (lifePoints > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Attack(Character attackedCharacter)
        {
            Console.WriteLine(name + " attacks " + attackedCharacter.name);
            int attackPower = Math.Abs(strength - attackedCharacter.defense);
            attackedCharacter.lifePoints = attackedCharacter.lifePoints - attackPower;
            Console.WriteLine(attackedCharacter.name + " has now " + attackedCharacter.lifePoints + " PV");
        }
    }
}