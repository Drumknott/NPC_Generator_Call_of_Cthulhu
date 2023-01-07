using NPC_Library;
using NPC_Library.CharacteristicsFolder;
using NPC_Library.Enums;
using NPC_Library.Occupations;
using NPC_Library.Personal_Details;
using NPC_Library.SkillsFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NPC_Generator_Call_of_Cthulhu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<string> gender = Gender.gender.ToList();
            List<string> occupations = Occupations_Manager.CompleteOccupationsList.ToList();

            InitializeComponent();

            genderDropDown.ItemsSource = gender;
            occupationDropDown.ItemsSource = occupations;
            
            
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayNPC displayNPC = new DisplayNPC();
            displayNPC.InitializeComponent();

            bool isValid = Enum.TryParse(occupationDropDown.SelectedItem.ToString(), out NPC_Library.Enums.Occupations validOccupation);

            //MessageBox.Show(validOccupation.ToString());
            //MessageBox.Show(genderDropDown.SelectedItem.ToString());

            if (isValid)
            {
                NPC npc = new(genderDropDown.SelectedItem.ToString(), validOccupation);

                //MessageBox.Show(npc._gender, npc._occupation.ToString());

                string _characteristics = "";
                string _skills = "";

                //foreach(KeyValuePair<Characteristics, Characteristic> _characteristic in npc.characteristics)
                //{
                //    _characteristics += $"{_characteristic.Value.Name} {_characteristic.Value.fullValue}\t";
                //}

                //foreach(KeyValuePair<Skills, Skill> _skill in npc.skills)
                //{
                //    _skills += $"{_skill.Value.name} {_skill.Value.fullValue}% ";
                //}

                //outputTextBlock.Text = $"{npc._name}\n{npc._gender}, {npc._age}\n{npc._occupation}\n\n{_characteristics}\n{_skills}";

                OutputFormat output = new();
                outputTextBlock.Text = output.GetOutput(npc);
            }
            else throw new Exception ("Invalid Occupation");


        }       
    }
}
