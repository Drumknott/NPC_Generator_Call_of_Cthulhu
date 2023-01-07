using NPC_Library.CharacteristicsFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPC_Library.Enums;

namespace NPC_Library.Characteristics
{
    public class Characteristics_Manager
    {

        Dictionary<Enums.Characteristics, int> adjustedCharacteristics = new Dictionary<Enums.Characteristics, int>();
        Dictionary<Enums.Characteristics, Characteristic> finalCharacteristics = new Dictionary<Enums.Characteristics, Characteristic>();

        public Dictionary<Enums.Characteristics, Characteristic> CreateRandomisedCharacteristics(int age)
        {
            adjustedCharacteristics = GenerateRandomScores(age);            

            DerivedCharacteristics derived = new();
            adjustedCharacteristics = derived.CalculateDerivedCharacteristics(adjustedCharacteristics);

            foreach (KeyValuePair<Enums.Characteristics, int> pair in adjustedCharacteristics)
            {
                Characteristic characteristic = new(pair.Key, pair.Value);
                finalCharacteristics.Add(pair.Key, characteristic);
            }

            return finalCharacteristics;
        }

        Dictionary<Enums.Characteristics, int> GenerateRandomScores(int age)
        {
            int STR = ThreeDSix();
            int DEX = ThreeDSix();
            int SIZ = TwoDSixPlusFive();
            int INT = TwoDSixPlusFive();
            int APP = ThreeDSix();
            int CON = ThreeDSix();
            int POW = ThreeDSix();
            int EDU = TwoDSixPlusFive();

            int[] initialCharacteristics = {STR, DEX, SIZ, INT, APP, CON, POW, EDU};

            AgeModifiers modifiers = new();
            adjustedCharacteristics = modifiers.ApplyAgeModifiers(initialCharacteristics, age);            

            return adjustedCharacteristics;
        }

        

        public static int ThreeDSix()
        {
            Random random = new();
            return random.Next(3, 19) * 5;
        }

        public static int TwoDSixPlusFive()
        {
            Random random = new();
            return random.Next(8, 19) * 5;
        }
    }
}
