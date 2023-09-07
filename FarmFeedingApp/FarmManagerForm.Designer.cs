namespace FarmFeedingApp
{
    partial class FarmManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmManagerForm));
            this.lblFarmManager = new System.Windows.Forms.Label();
            this.btnAnimalCosts = new System.Windows.Forms.Button();
            this.btnAnimalConsumptions = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFarmManager
            // 
            this.lblFarmManager.AutoSize = true;
            this.lblFarmManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarmManager.Location = new System.Drawing.Point(305, 37);
            this.lblFarmManager.Name = "lblFarmManager";
            this.lblFarmManager.Size = new System.Drawing.Size(207, 36);
            this.lblFarmManager.TabIndex = 0;
            this.lblFarmManager.Text = "Farm Manager";
            this.lblFarmManager.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAnimalCosts
            // 
            this.btnAnimalCosts.BackColor = System.Drawing.Color.White;
            this.btnAnimalCosts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnimalCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimalCosts.Location = new System.Drawing.Point(449, 175);
            this.btnAnimalCosts.Name = "btnAnimalCosts";
            this.btnAnimalCosts.Size = new System.Drawing.Size(220, 84);
            this.btnAnimalCosts.TabIndex = 1;
            this.btnAnimalCosts.Text = "Animal costs $ ";
            this.btnAnimalCosts.UseVisualStyleBackColor = false;
            this.btnAnimalCosts.Click += new System.EventHandler(this.btnAnimalCosts_Click);
            // 
            // btnAnimalConsumptions
            // 
            this.btnAnimalConsumptions.BackColor = System.Drawing.Color.White;
            this.btnAnimalConsumptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnimalConsumptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimalConsumptions.Location = new System.Drawing.Point(109, 175);
            this.btnAnimalConsumptions.Name = "btnAnimalConsumptions";
            this.btnAnimalConsumptions.Size = new System.Drawing.Size(220, 84);
            this.btnAnimalConsumptions.TabIndex = 2;
            this.btnAnimalConsumptions.Text = "Animals Consumptions";
            this.btnAnimalConsumptions.UseVisualStyleBackColor = false;
            this.btnAnimalConsumptions.Click += new System.EventHandler(this.btnAnimalConsumptions_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(329, 335);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(115, 38);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // FarmManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAnimalConsumptions);
            this.Controls.Add(this.btnAnimalCosts);
            this.Controls.Add(this.lblFarmManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FarmManagerForm";
            this.Text = "FarmManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFarmManager;
        private System.Windows.Forms.Button btnAnimalCosts;
        private System.Windows.Forms.Button btnAnimalConsumptions;
        private System.Windows.Forms.Button btnHome;
    }
}