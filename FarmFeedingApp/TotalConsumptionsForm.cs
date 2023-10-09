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
    public partial class TotalConsumptionsForm : Form
    {
        AnimalManager am;
        public TotalConsumptionsForm(AnimalManager am)
        {
            InitializeComponent();
            this.am = am;
            rtbxConsumptionSummarys.Text = am.SpeciesConsumptionSummarys();
            pbxFeedPicture.ImageLocation = @"Images/CowsFeeding.jpg";
        }
        //closes consumption form and opens the home form
        private void btnHome_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            HomeForm myNewForm = new HomeForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //closes consumption page and opens cost page
        private void btnConsumptionsCosts_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalCostsForm myNewForm = new AnimalCostsForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
