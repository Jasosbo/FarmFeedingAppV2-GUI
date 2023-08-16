using System.Windows.Forms;

namespace FarmFeedingApp
{
    partial class AddFarmAnimalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddFarmAnimal = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.cbxSpecies = new System.Windows.Forms.ComboBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.cbxBreed = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbxAnimal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddFarmAnimal
            // 
            this.lblAddFarmAnimal.AutoSize = true;
            this.lblAddFarmAnimal.Location = new System.Drawing.Point(210, 14);
            this.lblAddFarmAnimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddFarmAnimal.Name = "lblAddFarmAnimal";
            this.lblAddFarmAnimal.Size = new System.Drawing.Size(86, 13);
            this.lblAddFarmAnimal.TabIndex = 0;
            this.lblAddFarmAnimal.Text = "Add Farm Animal";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(28, 60);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(107, 13);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Enter Animal Species";
            // 
            // cbxSpecies
            // 
            this.cbxSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpecies.FormattingEnabled = true;
            this.cbxSpecies.Location = new System.Drawing.Point(28, 75);
            this.cbxSpecies.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSpecies.Name = "cbxSpecies";
            this.cbxSpecies.Size = new System.Drawing.Size(102, 21);
            this.cbxSpecies.TabIndex = 2;
            this.cbxSpecies.SelectedIndexChanged += new System.EventHandler(this.cbxSpecies_SelectedIndexChanged);
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(28, 105);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(97, 13);
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "Enter Animal Breed";
            // 
            // cbxBreed
            // 
            this.cbxBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBreed.FormattingEnabled = true;
            this.cbxBreed.Items.AddRange(new object[] {
            "Brown",
            "Silkie"});
            this.cbxBreed.Location = new System.Drawing.Point(28, 120);
            this.cbxBreed.Margin = new System.Windows.Forms.Padding(2);
            this.cbxBreed.Name = "cbxBreed";
            this.cbxBreed.Size = new System.Drawing.Size(102, 21);
            this.cbxBreed.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 147);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Enter Animal Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(28, 162);
            this.tbxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(102, 20);
            this.tbxName.TabIndex = 6;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(28, 192);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(92, 13);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "Enter Animal DOB";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(28, 213);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDOB.MaxDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(102, 20);
            this.dtpDOB.TabIndex = 8;
            this.dtpDOB.Value = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(31, 246);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(79, 23);
            this.btnAddAnimal.TabIndex = 9;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(391, 242);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 26);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbxAnimal
            // 
            this.pbxAnimal.Location = new System.Drawing.Point(267, 60);
            this.pbxAnimal.Name = "pbxAnimal";
            this.pbxAnimal.Size = new System.Drawing.Size(184, 138);
            this.pbxAnimal.TabIndex = 11;
            this.pbxAnimal.TabStop = false;
            // 
            // AddFarmAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.pbxAnimal);
            this.Controls.Add(this.cbxSpecies);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxBreed);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.lblAddFarmAnimal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddFarmAnimalForm";
            this.Text = "AddFarmAnimalForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddFarmAnimal;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.ComboBox cbxSpecies;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.ComboBox cbxBreed;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnCancel;
        private PictureBox pbxAnimal;
    }
}