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
            this.SuspendLayout();
            // 
            // lblAddFarmAnimal
            // 
            this.lblAddFarmAnimal.AutoSize = true;
            this.lblAddFarmAnimal.Location = new System.Drawing.Point(315, 22);
            this.lblAddFarmAnimal.Name = "lblAddFarmAnimal";
            this.lblAddFarmAnimal.Size = new System.Drawing.Size(131, 20);
            this.lblAddFarmAnimal.TabIndex = 0;
            this.lblAddFarmAnimal.Text = "Add Farm Animal";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(42, 93);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(161, 20);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Enter Animal Species";
            // 
            // cbxSpecies
            // 
            this.cbxSpecies.FormattingEnabled = true;
            this.cbxSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxSpecies.Location = new System.Drawing.Point(42, 116);
            this.cbxSpecies.Name = "cbxSpecies";
            this.cbxSpecies.Size = new System.Drawing.Size(151, 28);
            this.cbxSpecies.TabIndex = 2;
            this.cbxSpecies.SelectedIndexChanged += new System.EventHandler(this.cbxSpecies_SelectedIndexChanged);
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(42, 161);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(147, 20);
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "Enter Animal Breed";
            // 
            // cbxBreed
            // 
            this.cbxBreed.FormattingEnabled = true;
            this.cbxBreed.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxBreed.Items.AddRange(new object[] {
            "Brown",
            "Silkie"});
            this.cbxBreed.Location = new System.Drawing.Point(42, 184);
            this.cbxBreed.Name = "cbxBreed";
            this.cbxBreed.Size = new System.Drawing.Size(151, 28);
            this.cbxBreed.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 226);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Enter Animal Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(42, 249);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(151, 26);
            this.tbxName.TabIndex = 6;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(42, 296);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(139, 20);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "Enter Animal DOB";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(42, 328);
            this.dtpDOB.MaxDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(151, 26);
            this.dtpDOB.TabIndex = 8;
            this.dtpDOB.Value = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(46, 379);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(119, 35);
            this.btnAddAnimal.TabIndex = 9;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(587, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddFarmAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "AddFarmAnimalForm";
            this.Text = "AddFarmAnimalForm";
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
    }
}