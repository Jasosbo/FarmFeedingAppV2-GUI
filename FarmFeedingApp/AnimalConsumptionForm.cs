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
    public partial class AnimalConsumptionForm : Form
    {
        AnimalManager am;
        string selectedAnimal;

        public AnimalConsumptionForm(AnimalManager am)
        {
            this.am = am;
            InitializeComponent();

            rtbAnimalSummary.Text = am.RecentAnimalSummary();
        }
        
        public AnimalConsumptionForm(AnimalManager am, string selectedAnimal)
        {
            this.am = am;
            this.selectedAnimal = selectedAnimal;
            InitializeComponent ();

            rtbAnimalSummary.Text = am.AnimalSummary(selectedAnimal);

        }
        //enters consumption into text file under the animals details
        private void btnEnterConsumption_Click(object sender, EventArgs e)
        {
            if (selectedAnimal==null)
            {
                am.AddConsumption((float)nudConsumption.Value);
                MessageBox.Show(am.RecentAnimalSummary());

            }
            else
            {
                am.AddConsumption((float)nudConsumption.Value,selectedAnimal);
                MessageBox.Show(am.AnimalSummary(selectedAnimal));
            }

            am.SaveAnimals();
            

            // close consumption form and open home form
            this.Hide();
            HomeForm myNewForm = new HomeForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //closes consumption form and takes the user back to the home page
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
