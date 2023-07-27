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
            this.lblFarmManager = new System.Windows.Forms.Label();
            this.btnAnimalCosts = new System.Windows.Forms.Button();
            this.btnAnimalConsumptions = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFarmManager
            // 
            this.lblFarmManager.AutoSize = true;
            this.lblFarmManager.Location = new System.Drawing.Point(334, 39);
            this.lblFarmManager.Name = "lblFarmManager";
            this.lblFarmManager.Size = new System.Drawing.Size(113, 20);
            this.lblFarmManager.TabIndex = 0;
            this.lblFarmManager.Text = "Farm Manager";
            // 
            // btnAnimalCosts
            // 
            this.btnAnimalCosts.Location = new System.Drawing.Point(480, 175);
            this.btnAnimalCosts.Name = "btnAnimalCosts";
            this.btnAnimalCosts.Size = new System.Drawing.Size(217, 52);
            this.btnAnimalCosts.TabIndex = 1;
            this.btnAnimalCosts.Text = "Animal costs ";
            this.btnAnimalCosts.UseVisualStyleBackColor = true;
            this.btnAnimalCosts.Click += new System.EventHandler(this.btnAnimalCosts_Click);
            // 
            // btnAnimalConsumptions
            // 
            this.btnAnimalConsumptions.Location = new System.Drawing.Point(102, 175);
            this.btnAnimalConsumptions.Name = "btnAnimalConsumptions";
            this.btnAnimalConsumptions.Size = new System.Drawing.Size(217, 52);
            this.btnAnimalConsumptions.TabIndex = 2;
            this.btnAnimalConsumptions.Text = "Animals Consumptions";
            this.btnAnimalConsumptions.UseVisualStyleBackColor = true;
            this.btnAnimalConsumptions.Click += new System.EventHandler(this.btnAnimalConsumptions_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(631, 374);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(115, 38);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // FarmManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAnimalConsumptions);
            this.Controls.Add(this.btnAnimalCosts);
            this.Controls.Add(this.lblFarmManager);
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