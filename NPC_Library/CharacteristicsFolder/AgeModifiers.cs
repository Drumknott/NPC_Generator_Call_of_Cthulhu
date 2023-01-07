using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Library.CharacteristicsFolder
{
    public class AgeModifiers
    {
        Random random = new();

        public  Dictionary<Enums.Characteristics, int> ApplyAgeModifiers(int[] initialCharacteristics, int age)
        {
            Dictionary<Enums.Characteristics, int> adjustedCharacteristics = new Dictionary<Enums.Characteristics, int>();
            int STR = initialCharacteristics[0];
            int DEX = initialCharacteristics[1];
            int SIZ = initialCharacteristics[2];
            int INT = initialCharacteristics[3];
            int APP = initialCharacteristics[4];
            int CON = initialCharacteristics[5];
            int POW = initialCharacteristics[6];
            int EDU = initialCharacteristics[7];
            

            if (age >= 15 && age <= 19)
            {

            }
            else if (age >= 40 && age <=49)
            {
                DeductPoints(STR, CON, DEX, 5);
                APP -= 5;
                ImprovementCheck(EDU);
                ImprovementCheck(EDU);
            }
            else if (age >= 50 && age <= 59)
            {
                DeductPoints(STR, CON, DEX, 10);
                APP -= 10;
                for (int i = 0; i <3; i++)
                {
                    ImprovementCheck(EDU);
                }
            }
            else if (age >= 60 && age <= 69)
            {
                DeductPoints(STR, CON, DEX, 20);
                APP -= 15;
                for (int i = 0; i <4; i++)
                {
                    ImprovementCheck(EDU);
                }
            }

            adjustedCharacteristics.Add(Enums.Characteristics.STR, STR);
            adjustedCharacteristics.Add(Enums.Characteristics.DEX, DEX);
            adjustedCharacteristics.Add(Enums.Characteristics.SIZ, SIZ);
            adjustedCharacteristics.Add(Enums.Characteristics.INT, INT);
            adjustedCharacteristics.Add(Enums.Characteristics.APP, APP);
            adjustedCharacteristics.Add(Enums.Characteristics.CON, CON);
            adjustedCharacteristics.Add(Enums.Characteristics.POW, POW);
            adjustedCharacteristics.Add(Enums.Characteristics.EDU, EDU);

            return adjustedCharacteristics;
        }

        void DeductPoints(int STR, int CON, int DEX, int amount)
        {
            while (amount > 0)
            {
                if (STR >= CON && STR >= DEX)
                {
                    STR -= 5;
                    amount -= 5;
                }
                else if (DEX >= STR && DEX >= CON)
                {
                    DEX -= 5;
                    amount -= 5;
                }
                else
                {
                    CON -= 5;
                    amount -= 5;
                }
            }
        }

        int ImprovementCheck(int CHA)
        {
            int d100 = random.Next(1, 101);

            if (d100 > CHA)
            {
                int improvementValue = random.Next(1, 11);
                int improvedCHA = CHA + improvementValue;
                if (improvedCHA > 99)
                {
                    improvedCHA = 99;
                }
                return improvedCHA;
            }
            else
            {
                return CHA;
            }
        }
    }
}
