using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Library.CharacteristicsFolder
{
    public class Characteristic
    {
        public string Name { get; set; }
        public int fullValue { get; set; }
        int halfValue;
        int fifthValue;

        public Characteristic(Enums.Characteristics name, int value)
        {
            Name = name.ToString();
            fullValue = value;
            halfValue = fullValue / 2;
            fifthValue = fullValue / 5;
        }
    }
}
