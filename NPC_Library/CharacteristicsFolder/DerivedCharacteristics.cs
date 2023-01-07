using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPC_Library.Characteristics;
using NPC_Library.Enums;

namespace NPC_Library.CharacteristicsFolder
{
    public class DerivedCharacteristics
    {        
        public Dictionary<Enums.Characteristics, int> CalculateDerivedCharacteristics(Dictionary<Enums.Characteristics, int> _characteristics)
        {
            int SAN = _characteristics[Enums.Characteristics.POW];
            int MP = _characteristics[Enums.Characteristics.POW] / 5;
            int Luck = Characteristics_Manager.ThreeDSix();
            int HP = (_characteristics[Enums.Characteristics.SIZ] + _characteristics[Enums.Characteristics.CON]) / 10;
            (int DB, int Build) = CalculateDBandBuild(_characteristics[Enums.Characteristics.STR], _characteristics[Enums.Characteristics.SIZ]); 
            int Move = CalculateMove(_characteristics[Enums.Characteristics.DEX], _characteristics[Enums.Characteristics.STR], _characteristics[Enums.Characteristics.SIZ]);

            _characteristics.Add(Enums.Characteristics.SAN, SAN);
            _characteristics.Add(Enums.Characteristics.MP, MP);
            _characteristics.Add(Enums.Characteristics.Luck, Luck);
            _characteristics.Add(Enums.Characteristics.HP, HP);
            _characteristics.Add(Enums.Characteristics.DB, DB);
            _characteristics.Add(Enums.Characteristics.Build, Build);
            _characteristics.Add(Enums.Characteristics.Move, Move);

            return _characteristics;
        }

        (int, int) CalculateDBandBuild(int STR, int SIZ)
        {
            int STRplusSIZ = STR + SIZ;
            if (STRplusSIZ >= 2 && STRplusSIZ <= 64)
            {
                return (-2, -2);
            }
            else if (STRplusSIZ >= 65 && STRplusSIZ <= 84)
            {
                return (-1, -1);
            }
            else if (STRplusSIZ >= 125 && STRplusSIZ <= 164)
            {
                return (4, 1);
            }
            else if (STRplusSIZ >= 165 && STRplusSIZ <= 204)
            {
                return (6, 2);
            }
            else return (0, 0);
        }

        int CalculateMove(int dex, int str, int siz)
        {
            if (siz > dex && siz > str) return 7;
            else if (str > siz && dex > siz) return 9;
            else return 8;
        }
    }
}
