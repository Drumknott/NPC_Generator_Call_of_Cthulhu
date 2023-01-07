using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace NPC_Library
{
    public class OutputFormat
    {
        public string GetOutput(NPC npc)
        {
            return $"Name: {npc._name}\n" +
                $"{npc._gender}, {npc._age}\n" +
                $"{npc._occupation}\n" +
                $"\n" +
                $"STR {npc.characteristics[Enums.Characteristics.STR].fullValue}\tDEX {npc.characteristics[Enums.Characteristics.DEX].fullValue}\tPOW {npc.characteristics[Enums.Characteristics.POW].fullValue}\n" +
                $"CON {npc.characteristics[Enums.Characteristics.CON].fullValue}\tAPP {npc.characteristics[Enums.Characteristics.APP].fullValue}\tEDU {npc.characteristics[Enums.Characteristics.EDU].fullValue}\n" +
                $"SIZ {npc.characteristics[Enums.Characteristics.SIZ].fullValue}\tINT {npc.characteristics[Enums.Characteristics.INT].fullValue}\tMove {npc.characteristics[Enums.Characteristics.Move].fullValue}\n" +
                $"\n" +
                $"Skills\n" +
                $"";
        }
    }
}
