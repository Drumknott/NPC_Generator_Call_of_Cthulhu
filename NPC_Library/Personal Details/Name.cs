using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Library.Personal_Details
{
    public class Name
    {
        private static readonly string[] MaleNames = Enum.GetNames(typeof(Enums.MaleNames));
        private static readonly string[] FemaleNames = Enum.GetNames(typeof(Enums.FemaleNames));
        private static readonly string[] NonBinaryNames = Enum.GetNames(typeof(Enums.NonBinaryNames));
        private static readonly string[] Surnames = Enum.GetNames(typeof(Enums.Surnames));

        public static string RandomName(string gender)
        {
            Random random = new();

            string firstName = RandomiseFirstName(gender);
            string surname = Surnames[random.Next(0, Surnames.Length)];
            string NPCName = $"{firstName} {surname}";
            return NPCName;

            string RandomiseFirstName(string gender)
            {
                return gender switch
                {
                    "Male" => MaleNames[random.Next(0, MaleNames.Length)],
                    "Female" => FemaleNames[random.Next(0, FemaleNames.Length)],
                    _ => NonBinaryNames[random.Next(0, NonBinaryNames.Length)],
                };
            }
        }
    }
}