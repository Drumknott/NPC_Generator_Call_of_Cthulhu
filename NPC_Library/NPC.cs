using NPC_Library.Characteristics;
using NPC_Library.CharacteristicsFolder;
using NPC_Library.Enums;
using NPC_Library.Occupations;
using NPC_Library.Personal_Details;
using NPC_Library.SkillsFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Library
{
    public class NPC
    {
        public string _name { get; set; }
        public string _gender { get; set; }
        public int _age { get; set; }
        public Enums.Occupations _occupation;
        public Dictionary<Enums.Characteristics, Characteristic> characteristics { get; set; }
        public Dictionary<Enums.Skills, Skill> skills { get; set; }

        public NPC(string gender, Enums.Occupations occupation)
        {
            if (gender == "_random" || gender == "")
            {
                _gender = Gender.RandomiseGender();
            }
            else
            {
                _gender = gender;
            }

            if (occupation == Enums.Occupations._random)
            {
                _occupation = Occupations_Manager.RandomiseOccupation();
            }
            else
            {
                _occupation = occupation;
            }

            _name = Name.RandomName(_gender);
            _age = Age.RandomiseAge();

            Characteristics_Manager chManager = new();
            characteristics = chManager.CreateRandomisedCharacteristics(_age);

            Skills_Manager skManager = new();
            skills = skManager.CreateSkillList(_occupation, characteristics);
        }

        public void Print()
        {
            Console.WriteLine($"Name:\t{this._name}");
            Console.WriteLine($"{this._gender}, {this._age}");
            Console.WriteLine($"{this._occupation}\n");
            Console.WriteLine($"Characteristics: {this.characteristics}");
            Console.WriteLine($"Skills: {this.skills}");
        }
    }
}
