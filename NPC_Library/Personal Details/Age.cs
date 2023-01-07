using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Library.Personal_Details
{
    public class Age
    {
        public static int RandomiseAge()
        {
            Random random = new();
            int age = random.Next(18, 86);
            return age;
        }
    }
}
