using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Library.Personal_Details
{
    public class Gender
    {
        public static readonly string[] gender = { "Male", "Female", "Other", "_random" };

        public static string RandomiseGender()
        {            
            string _gender = gender[WeightedRandomiser()];
            return _gender;
        }

        static int WeightedRandomiser()
        {
            Random random = new();
            int d100 = random.Next(0, 100);
            if (d100 >= 0 && d100 <= 45)
            {
                return 0;
            }
            else if (d100 >= 46 && d100 <= 90)
            {
                return 1;
            }
            else return 2;
        }
    }
}
