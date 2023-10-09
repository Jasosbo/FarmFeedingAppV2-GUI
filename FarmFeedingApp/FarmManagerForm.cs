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
    public partial class FarmManagerForm : Form
    {
        AnimalManager am;
        public FarmManagerForm(AnimalManager am)
        {
            InitializeComponent();
            this.am = am;   
        }
        // close animal manager form form and open total consumption form
        private void btnAnimalCosts_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            AnimalCostsForm myNewForm = new AnimalCostsForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
        // close animal manager form form and opens home form
        private void btnHome_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            HomeForm myNewForm = new HomeForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnAnimalConsumptions_Click(object sender, EventArgs e)
        {
            // close animal manager form form and open total consumption form
            this.Hide();
            TotalConsumptionsForm myNewForm = new TotalConsumptionsForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
