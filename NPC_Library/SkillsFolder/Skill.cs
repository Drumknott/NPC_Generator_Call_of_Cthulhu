using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Library.SkillsFolder
{
    public class Skill
    {
        public string name { get; set; }
        public int fullValue { get; set; }
        int halfValue;
        int fifthValue;

        public Skill(Enums.Skills skill, int percent)
        {
            name = skill.ToString();
            fullValue = percent;
            halfValue = percent / 2;
            fifthValue = percent / 5;
        }
    }
}
