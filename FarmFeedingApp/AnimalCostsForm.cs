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
    public partial class AnimalCostsForm : Form
    {
        AnimalManager am;
        public AnimalCostsForm(AnimalManager am)
        {
            InitializeComponent();
            this.am = am;
            rtbxCostSummarys.Text = am.SpeciesConsumptionCostSummary();
            pbxMoney.ImageLocation = $"Images/Money.jpg";
        }
       //closes cost forms and opens home form
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
        //closes cost form and opens consumption totals page
        private void btnConsumptionTotals_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalConsumptionsForm myNewForm = new TotalConsumptionsForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
 