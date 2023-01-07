using NPC_Library.CharacteristicsFolder;
using NPC_Library.Enums;
using NPC_Library.Occupations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Library.SkillsFolder
{
    class Skills_Manager
    {
        Dictionary<Enums.Skills, Skill> skills = new Dictionary<Skills, Skill>();
        Dictionary<Enums.Skills, int> skillListWithInitialValues = new Dictionary<Skills, int>();
        public List<Skills> occupationSkillList { get; set; }
        int occupationSkillPoints;
        int personalInterestPoints;
        public static string[] AllSkills = Enum.GetNames(typeof(Enums.Skills));
        public static string[] InterpersonalSkills = { Skills.Charm.ToString(), Skills.Persuade.ToString(), Skills.Intimidate.ToString(), Skills.Fast_Talk.ToString()};

        public Dictionary<Skills, Skill> CreateSkillList(Enums.Occupations occupation, Dictionary<Enums.Characteristics, Characteristic> characteristics)
        {
            personalInterestPoints = characteristics[Enums.Characteristics.INT].fullValue * 2;

            (occupationSkillList, occupationSkillPoints) = Occupations_Manager.GetOccupationSkillList(occupation, characteristics);
            List<Skills> updatedOccupationList = new(occupationSkillList);

            foreach (Skills skill in occupationSkillList)
            {
                int i = occupationSkillList.IndexOf(skill);

                if (skill == Skills._random) //assign random skill if required
                {                    
                    updatedOccupationList[i] = RandomSkill(updatedOccupationList);
                }

                else if (skill == Skills._interpersonal) //assign random interpersonal skill if required
                {                    
                    updatedOccupationList[i] = RandomInterpersonalSkill(updatedOccupationList);
                }

                int baseValue = CheckBaseValue(updatedOccupationList[i]);

                skillListWithInitialValues.Add(updatedOccupationList[i], baseValue);                
            }

            skillListWithInitialValues = AllocateSkillPoints.AllocateOccupationSkillPoints(skillListWithInitialValues, occupationSkillPoints, occupationSkillList);
            skillListWithInitialValues = AllocateSkillPoints.AllocatePersonalInterestPoints(skillListWithInitialValues, personalInterestPoints, occupationSkillList);

            foreach (KeyValuePair<Enums.Skills, int> pair in skillListWithInitialValues)
            {
                Skill skill = new(pair.Key, pair.Value);
                skills.Add(pair.Key, skill);
            }

            return skills;
        }

        Enums.Skills RandomSkill(List<Skills> _updatedOccupationList)
        {
            Random random = new();

            while (true)
            {
                string randomSkill = AllSkills[random.Next(0, AllSkills.Length)];
                bool isValid = Enum.TryParse(randomSkill, out Enums.Skills validSkill);

                if (isValid && !_updatedOccupationList.Contains(validSkill)) //parse is successful and the skill list doesn't already contain the random skill
                {
                    return validSkill;
                }
            }
        }

        Enums.Skills RandomInterpersonalSkill(List<Skills> _updatedOccupationList)
        {
            Random random = new();

            while (true)
            {
                string randomInterpersonalSkill = InterpersonalSkills[random.Next(0, InterpersonalSkills.Length)];
                bool isValid = Enum.TryParse(randomInterpersonalSkill, out Enums.Skills validSkill);

                if (isValid && !_updatedOccupationList.Contains(validSkill))
                {
                    return validSkill;
                }
            }
        }

        public static int CheckBaseValue(Enums.Skills skill)
        {
            switch (skill)
            {
                default: return 1;
                case Skills.Accounting:
                case Skills.Appraise:
                case Skills.Art_Craft:
                case Skills.Disguise:
                case Skills.Fast_Talk:
                case Skills.History:
                case Skills.Law:
                case Skills.Occult:
                case Skills.Ride:
                    return 5;
                case Skills.Electrical_Repair:
                case Skills.Mechanical_Repair:
                case Skills.Natural_World:
                case Skills.Navigate:
                case Skills.Persuade:
                case Skills.Psychology:
                case Skills.Slight_Of_Hand:
                case Skills.Survival:
                case Skills.Track:
                    return 10;
                case Skills.Charm:
                case Skills.Intimidate:
                    return 15;
                case Skills.Climb:
                case Skills.Drive_Auto:
                case Skills.Firearms_Handgun:
                case Skills.Jump:
                case Skills.Library_Use:
                case Skills.Listen:
                case Skills.Stealth:
                case Skills.Swim:
                case Skills.Throw:
                    return 20;
                case Skills.Fighting_Brawl:
                case Skills.Firearms_Rifle_Shotgun:
                case Skills.Spot_Hidden:
                    return 25;
                case Skills.First_Aid: return 30;
            }
        }
    }
}
