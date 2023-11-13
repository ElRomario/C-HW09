using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09StructsEnums
{

    public enum Race
    {
        Orc,
        Elf,
        Human,
        Gnome,
        Troll,
        Goblin
    }

    public enum Role
    {
        Warrior,
        Mage,
        Priest,
        Rogue,
        Hunter,
        Druid
    }
    public struct Character
        {
            public Race CharacterRace { get; }
            public Role CharacterRole { get; }
            public int Attack { get; }
            public int Health { get; }

            public Character(Race race, Role role)
            {
                CharacterRace = race;
                CharacterRole = role;
                int baseAttack = 10;
                int baseHealth = 100;

                switch (role)
                {
                    case Role.Warrior:
                        baseAttack -= 5;
                        baseHealth += 60;
                        break;
                    case Role.Mage:
                        baseAttack += 20;
                        baseHealth -= 30;
                        break;
                    case Role.Priest:
                        baseAttack -= 3;
                        baseHealth += 50;
                        break;
                    case Role.Rogue:
                        baseAttack += 10;
                        baseHealth -= 20;
                        break;
                    case Role.Hunter:
                        baseAttack += 5;
                        baseHealth += 10;
                        break;
                    case Role.Druid:
                        baseAttack += 2;
                        baseHealth += 20;
                        break;
                }

                Attack = baseAttack;
                Health = baseHealth;
            }

            public void Show()
            {
                Console.WriteLine($"Вы {CharacterRace}-{CharacterRole} 1 уровня:");
                Console.WriteLine($"У вас {Attack} атаки и {Health} здоровья.");
            }
        }


    }

