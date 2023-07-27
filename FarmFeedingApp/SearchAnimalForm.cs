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
    public partial class SearchAnimalForm : Form
    {
        AnimalManager am;
        private DataTable dt;
        private DataView dv;
        private string selectedAnimal = "";

        public SearchAnimalForm(AnimalManager am)
        {
            InitializeComponent();
            this.am = am;

            //Listview Properties
            lvSearchAnimal.View = View.Details;
            lvSearchAnimal.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //Add Columns
            //add columns
            lvSearchAnimal.Columns.Add("Species");
            lvSearchAnimal.Columns.Add("Breed");
            lvSearchAnimal.Columns.Add("Name");

            //initalise datatable and add columns
            dt = new DataTable();
            dt.Columns.Add("Species");
            dt.Columns.Add("Breed");
            dt.Columns.Add("Name");

            //get datalist from animal manager
            List<FarmAnimal> animals = this.am.GetAnimals();

            foreach (var animal in animals)
            {
                dt.Rows.Add(animal.GetSpecies(),animal.GetBreed(),animal.GetName());
            }

            //fill datatable
            dv = new DataView(dt);
            PopulateListView(dv);

        }

        //fill listview from dataview
        private void PopulateListView(DataView dv)
        {
            lvSearchAnimal.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                
                lvSearchAnimal.Items.Add(new ListViewItem(new string[] { row[0].ToString()
                    , row[1].ToString(), row[2].ToString() }));

            }

        }
        //Perform the filter of animals
        private void FilterTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void tbxSearchAnimal_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Name Like '%{0}%'", tbxSearchAnimal.Text); // Code from https://www.youtube.com/watch?v=cycavkXug5U
            PopulateListView(dv);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalConsumptionForm myNewForm = new AnimalConsumptionForm(am,selectedAnimal);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void lvSearchAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAnimal = lvSearchAnimal.FocusedItem.SubItems[2].Text;
            
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            MessageBox.Show(am.AnimalSummary(selectedAnimal));
        }
    }
}
