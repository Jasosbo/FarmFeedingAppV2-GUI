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
    public partial class HomeForm : Form
    {
        AnimalManager am;
        public HomeForm(AnimalManager am)
        {
            this.am = am;
            InitializeComponent();
            
            pbxLogo.ImageLocation = $"Images/Farm-Feeding-App-logo.jpg";
        }

        //opens add animal form
        private void btnAnimal_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            AddFarmAnimalForm myNewForm = new AddFarmAnimalForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //opens farm manager form
        private void btnFarmManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            FarmManagerForm myNewForm = new FarmManagerForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //opens tbe search form for animals
        private void btnAddToAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAnimalForm myNewForm = new SearchAnimalForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
    
}
