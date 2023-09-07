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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFarmAnimalForm));
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
            this.lblAddFarmAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFarmAnimal.Location = new System.Drawing.Point(260, 21);
            this.lblAddFarmAnimal.Name = "lblAddFarmAnimal";
            this.lblAddFarmAnimal.Size = new System.Drawing.Size(244, 36);
            this.lblAddFarmAnimal.TabIndex = 0;
            this.lblAddFarmAnimal.Text = "Add Farm Animal";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(85, 92);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(161, 20);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Enter Animal Species";
            // 
            // cbxSpecies
            // 
            this.cbxSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpecies.FormattingEnabled = true;
            this.cbxSpecies.Location = new System.Drawing.Point(89, 115);
            this.cbxSpecies.Name = "cbxSpecies";
            this.cbxSpecies.Size = new System.Drawing.Size(151, 28);
            this.cbxSpecies.TabIndex = 2;
            this.cbxSpecies.SelectedIndexChanged += new System.EventHandler(this.cbxSpecies_SelectedIndexChanged);
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(85, 162);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(147, 20);
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
            this.cbxBreed.Location = new System.Drawing.Point(89, 185);
            this.cbxBreed.Name = "cbxBreed";
            this.cbxBreed.Size = new System.Drawing.Size(151, 28);
            this.cbxBreed.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(85, 226);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Enter Animal Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(89, 249);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(151, 26);
            this.tbxName.TabIndex = 6;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(85, 295);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(139, 20);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "Enter Animal DOB";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(89, 318);
            this.dtpDOB.MaxDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(150, 26);
            this.dtpDOB.TabIndex = 8;
            this.dtpDOB.Value = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.White;
            this.btnAddAnimal.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnimal.Location = new System.Drawing.Point(106, 377);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(118, 35);
            this.btnAddAnimal.TabIndex = 9;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(586, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbxAnimal
            // 
            this.pbxAnimal.Location = new System.Drawing.Point(458, 103);
            this.pbxAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxAnimal.Name = "pbxAnimal";
            this.pbxAnimal.Size = new System.Drawing.Size(276, 212);
            this.pbxAnimal.TabIndex = 11;
            this.pbxAnimal.TabStop = false;
            // 
            // AddFarmAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 449);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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