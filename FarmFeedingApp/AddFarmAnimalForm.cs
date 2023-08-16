using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmFeedingApp
{
    public partial class AddFarmAnimalForm : Form
    {
        AnimalManager am;

        public const string errorMessage = "ERROR: Please Select a option.";
        public AddFarmAnimalForm(AnimalManager am)
        {
            this.am = am;
            InitializeComponent();
            pbxAnimal.ImageLocation = $"farmAnimals.jpg";

            dtpDOB.MaxDate = DateTime.Now;
            dtpDOB.Value = DateTime.Now;
            foreach (string species in am.GetSpecies())
            {
                cbxSpecies.Items.Add(species);
            }
            

        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbxSpecies.Text) || String.IsNullOrWhiteSpace(cbxBreed.Text) || String.IsNullOrWhiteSpace(tbxName.Text)) 
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                
                am.AddAnimal(new FarmAnimal(cbxSpecies.Text, cbxBreed.Text, CapitaliseName(), dtpDOB.Value));

                
                // close add animal form and open consumption form
                this.Hide();
                AnimalConsumptionForm myNewForm = new AnimalConsumptionForm(am);
                myNewForm.Closed += (s, args) => this.Close();
                myNewForm.Show();
            }
            

        }

        private void cbxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxBreed.Items.Clear();

            pbxAnimal.ImageLocation = $"{cbxSpecies.Text}.jpg";

            foreach (string breed in am.GetBreeds(cbxSpecies.Text))
            {
                cbxBreed.Items.Add(breed);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close animal form and open home form
            this.Hide();
            HomeForm myNewForm = new HomeForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
        //return the ticket holder name as a captitalised string
        private string CapitaliseName()
        {
            string name = tbxName.Text[0].ToString().ToUpper();

            for (int characterIndex = 1; characterIndex < tbxName.Text.Length; characterIndex++)
            {
                name += tbxName.Text[characterIndex].ToString().ToLower();
            }



            return name;
        }
    }
}
