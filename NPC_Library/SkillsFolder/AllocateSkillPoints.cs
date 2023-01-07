using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Library.SkillsFolder
{
    public  class AllocateSkillPoints
    {  
        public static Dictionary<Enums.Skills, int> AllocateOccupationSkillPoints(Dictionary<Enums.Skills, int> skillList, int occupationSkillPoints, List<Enums.Skills> occupationSkillList)
        {
            Random random = new();

            while (occupationSkillPoints > 0)
            {
                Enums.Skills randomSkill = skillList.ElementAt(random.Next(0, skillList.Count)).Key;
                skillList[randomSkill] += 5;
                occupationSkillPoints -= 5;
            }

            return skillList;
        }

        public static Dictionary<Enums.Skills, int> AllocatePersonalInterestPoints(Dictionary<Enums.Skills, int> skillList, int personalInterestPoints, List<Enums.Skills> occupationSkillList)
        {
            Random random = new();

            while (personalInterestPoints > 0)
            {
                string randomSkill = Skills_Manager.AllSkills[random.Next(0, Skills_Manager.AllSkills.Length)];
                bool isValid = Enum.TryParse(randomSkill, out Enums.Skills validSkill);                

                if (isValid)
                {
                    if (!skillList.ContainsKey(validSkill))
                    {
                        int baseValue = Skills_Manager.CheckBaseValue(validSkill);
                        skillList.Add(validSkill, baseValue);
                    }

                    skillList[validSkill] += 5;
                    personalInterestPoints -= 5;
                }
            }

            return skillList;
        }
    }
}
