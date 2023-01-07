using NPC_Library.CharacteristicsFolder;
using NPC_Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Library.Occupations
{
    public class Occupations_Manager
    {
        public static readonly string[] CompleteOccupationsList = Enum.GetNames(typeof(Enums.Occupations));

        //random occupation
        public static Enums.Occupations RandomiseOccupation()
        {
            Random random = new();

            while (true)
            {
                string randomOccupation = CompleteOccupationsList[random.Next(0, CompleteOccupationsList.Length)];
                bool isValid = Enum.TryParse(randomOccupation, out Enums.Occupations validOccupation);
                if (isValid)
                {
                    return validOccupation;
                }
            }
        }

        public static (List<Skills>, int) GetOccupationSkillList(Enums.Occupations occupation, Dictionary<Enums.Characteristics, Characteristic> characteristics)
        {
            List<Skills> skillList;
            int skillPoints;

            int EDU = characteristics[Enums.Characteristics.EDU].fullValue;
            int DEX = characteristics[Enums.Characteristics.DEX].fullValue;
            int APP = characteristics[Enums.Characteristics.APP].fullValue; 
            int STR = characteristics[Enums.Characteristics.STR].fullValue;
            int POW = characteristics[Enums.Characteristics.POW].fullValue;

            switch (occupation)
            {
                case Enums.Occupations.Accountant:
                    skillList = OccupationSkillLists.Accountant;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Acrobat:
                    skillList = OccupationSkillLists.Acrobat;
                    skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Actor:
                    skillList = OccupationSkillLists.Actor;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Agency_Detective:
                    skillList = OccupationSkillLists.AgencyDetective;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Alienist:
                    skillList = OccupationSkillLists.Alienist;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Animal_Trainer:
                    skillList = OccupationSkillLists.AnimalTrainer;
                    if (APP > POW) skillPoints = (EDU * 2) + (APP * 2);
                    else skillPoints = (EDU * 2) + (POW * 2); 
                    return (skillList, skillPoints);
                case Enums.Occupations.Antiquarian:
                    skillList = OccupationSkillLists.Antiquarian;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Antique_Dealer:
                    skillList = OccupationSkillLists.AntiqueDealer;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Archaeologist:
                    skillList = OccupationSkillLists.Archaeologist;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Architect:
                    skillList = OccupationSkillLists.Architect;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Artist:
                    skillList = OccupationSkillLists.Artist;
                    if (DEX > POW) skillPoints = (EDU * 2) + (DEX * 2);
                    else skillPoints = (EDU * 2) + (POW * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Asylum_Attendant:
                    skillList = OccupationSkillLists.Asylum_Attendant;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Athlete:
                    skillList = OccupationSkillLists.Athlete;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2); ;
                    return (skillList, skillPoints);
                case Enums.Occupations.Author:
                    skillList = OccupationSkillLists.Author;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Bartender:
                    skillList = OccupationSkillLists.Bartender;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Big_Game_Hunter:
                    skillList = OccupationSkillLists.BigGameHunter;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Book_Dealer:
                    skillList = OccupationSkillLists.BookDealer;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Bounty_Hunter:
                    skillList = OccupationSkillLists.BountyHunter;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Boxer:
                    skillList = OccupationSkillLists.Boxer;
                    skillPoints = (EDU * 2) + (STR * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Butler:
                    skillList = OccupationSkillLists.Butler;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Clergy_Member_of_the:
                    skillList = OccupationSkillLists.Clergy;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Cowboy:
                    skillList = OccupationSkillLists.Cowboy;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Craftsperson:
                    skillList = OccupationSkillLists.Craftsperson;
                    skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Assassin:
                    skillList = OccupationSkillLists.Assassin;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Bank_Robber:
                    skillList = OccupationSkillLists.BankRobber;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Bootlegger:
                    skillList = OccupationSkillLists.Bootlegger;
                    skillPoints = (EDU * 2) + (STR * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Burglar:
                    skillList = OccupationSkillLists.Burglar;
                    skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Conman:
                    skillList = OccupationSkillLists.Conman;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Criminal:
                default:
                    skillList = OccupationSkillLists.Criminal;
                    if (APP > DEX) skillPoints = (EDU * 2) + (APP * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Gun_Moll:
                    skillList = OccupationSkillLists.GunMoll;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Fence:
                    skillList = OccupationSkillLists.Fence;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Forger:
                    skillList = OccupationSkillLists.Forger;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Smuggler:
                    skillList = OccupationSkillLists.Smuggler;
                    if (APP > DEX) skillPoints = (EDU * 2) + (APP * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Cult_Leader:
                    skillList = OccupationSkillLists.CultLeader;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Designer:
                    skillList = OccupationSkillLists.Designer;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Dilettante:
                    skillList = OccupationSkillLists.Dilettante;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Diver:
                    skillList = OccupationSkillLists.Diver;
                    skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Doctor_Of_Medicine:
                    skillList = OccupationSkillLists.DoctorOfMedicine;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Drifter:
                    skillList = OccupationSkillLists.Drifter;
                    if (STR > DEX && STR > APP) skillPoints = (EDU * 2) + (STR * 2);
                    else if (DEX > STR && DEX > APP) skillPoints = (EDU * 2) + (DEX * 2);
                    else skillPoints = (EDU * 2) + (APP * 2);    
                    return (skillList, skillPoints);
                case Enums.Occupations.Driver:
                    skillList = OccupationSkillLists.Driver;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Editor:
                    skillList = OccupationSkillLists.Editor;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Elected_Official:
                    skillList = OccupationSkillLists.ElectedOfficial;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Engineer:
                    skillList = OccupationSkillLists.Engineer;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Entertainer:
                    skillList = OccupationSkillLists.Entertainer;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Explorer:
                    skillList = OccupationSkillLists.Explorer;
                    if (STR > DEX && STR > APP) skillPoints = (EDU * 2) + (STR * 2);
                    else if (DEX > STR && DEX > APP) skillPoints = (EDU * 2) + (DEX * 2);
                    else skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Farmer:
                    skillList = OccupationSkillLists.Farmer;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Federal_Agent:
                    skillList = OccupationSkillLists.FederalAgent;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Firefighter:
                    skillList = OccupationSkillLists.Firefighter;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Foreign_Correspondent:
                    skillList = OccupationSkillLists.ForeignCorrespondant;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Forensic_Surgeon:
                    skillList = OccupationSkillLists.ForensicSurgeon;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Gambler:
                    skillList = OccupationSkillLists.Gambler;
                    if (APP > DEX) skillPoints = (EDU * 2) + (APP * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Gangster:
                    skillList = OccupationSkillLists.Gangster;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Gentleman:
                    skillList = OccupationSkillLists.Gentleman;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Hobo:
                    skillList = OccupationSkillLists.Hobo;
                    if (APP > DEX) skillPoints = (EDU * 2) + (APP* 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Hospital_Orderly:
                    skillList = OccupationSkillLists.HospitalOrderly;
                    skillPoints = (EDU *2) + (STR *2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Journalist:
                case Enums.Occupations.Reporter:
                    skillList = OccupationSkillLists.Journalist;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Judge:
                    skillList = OccupationSkillLists.Judge;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Laboratory_Assistant:
                    skillList = OccupationSkillLists.Laboratory_Assistant;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Laborer:
                    skillList = OccupationSkillLists.Laborer;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Lumberjack:
                    skillList = OccupationSkillLists.Lumberjack;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Miner:
                    skillList = OccupationSkillLists.Miner;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Lawyer:
                    skillList = OccupationSkillLists.Lawyer;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Librarian:
                    skillList = OccupationSkillLists.Librarian;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Mechanic:
                    skillList = OccupationSkillLists.Mechanic;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Military_Officer:
                    skillList = OccupationSkillLists.MilitaryOfficer;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Missionary:
                    skillList = OccupationSkillLists.Missionary;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Mountain_Climber:
                    skillList = OccupationSkillLists.MountainClimber;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Museum_Curator:
                    skillList = OccupationSkillLists.MuseumCurator;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Musician:
                    skillList = OccupationSkillLists.Musician;
                    if (APP > DEX) skillPoints = (EDU * 2) + (APP* 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Nurse:
                    skillList = OccupationSkillLists.Nurse;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Occultist:
                    skillList = OccupationSkillLists.Occultist;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Outdoorsman:
                    skillList = OccupationSkillLists.Outdoorsman;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Parapsychologist:
                    skillList = OccupationSkillLists.Parapsychologist;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Pharmacist:
                    skillList = OccupationSkillLists.Pharmacist;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Photographer:
                case Enums.Occupations.Photojournalist:
                    skillList = OccupationSkillLists.Photographer;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Pilot:
                    skillList = OccupationSkillLists.Pilot;
                    skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Police_Detective:
                    skillList = OccupationSkillLists.Police_Detective;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Private_Investigator:
                    skillList = OccupationSkillLists.PrivateInvestigator;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Professor:
                    skillList = OccupationSkillLists.Professor;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Prospector:
                    skillList = OccupationSkillLists.Prospector;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Prostitute:
                    skillList = OccupationSkillLists.Prostitute;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Psychiatrist:
                    skillList = OccupationSkillLists.Psychiatrist;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Psychologist:
                    skillList = OccupationSkillLists.Psychologist;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Researcher:
                    skillList = OccupationSkillLists.Researcher;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Sailor:
                    skillList = OccupationSkillLists.Sailor;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Salesperson:
                    skillList = OccupationSkillLists.Salesperson;
                    skillPoints = (EDU * 2) + (APP * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Scientist:
                    skillList = OccupationSkillLists.Scientist;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Secretary:
                    skillList = OccupationSkillLists.Secretary;
                    if (APP > DEX) skillPoints = (EDU * 2) + (APP* 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Shopkeeper:
                    skillList = OccupationSkillLists.Shopkeeper;
                    if (APP > DEX) skillPoints = (EDU * 2) + (APP * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Soldier:
                    skillList = OccupationSkillLists.Soldier;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Spy:
                    skillList = OccupationSkillLists.Spy;
                    if (APP > DEX) skillPoints = (EDU * 2) + (APP * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Student:
                    skillList = OccupationSkillLists.Student;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Stuntman:
                    skillList = OccupationSkillLists.Stuntman;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Tribe_Member:
                    skillList = OccupationSkillLists.TribeMember;
                    if (STR > DEX) skillPoints = (EDU * 2) + (STR * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Undertaker:
                    skillList = OccupationSkillLists.Undertaker;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Union_Activist:
                    skillList = OccupationSkillLists.UnionActivist;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Waitress:
                    skillList = OccupationSkillLists.Waiter;
                    if (APP > DEX) skillPoints = (EDU * 2) + (APP * 2);
                    else skillPoints = (EDU * 2) + (DEX * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.White_Collar_Worker:
                    skillList = OccupationSkillLists.WhiteCollarWorker;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);
                case Enums.Occupations.Zealot:
                    skillList = OccupationSkillLists.Zealot;
                    if (APP > POW) skillPoints = (EDU * 2) + (APP * 2);
                    else skillPoints = (EDU * 2) + (POW * 2);
                    return (skillList, skillPoints);
                case Enums.Occupations.Zookeeper:
                    skillList = OccupationSkillLists.Zookeeper;
                    skillPoints = EDU * 4;
                    return (skillList, skillPoints);                
            }
        }
    }
}
