namespace FarmFeedingApp
{
    partial class HomeForm
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
            this.lblFarmFeedingApp = new System.Windows.Forms.Label();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnFarmManager = new System.Windows.Forms.Button();
            this.btnAddToAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFarmFeedingApp
            // 
            this.lblFarmFeedingApp.AutoSize = true;
            this.lblFarmFeedingApp.Location = new System.Drawing.Point(325, 49);
            this.lblFarmFeedingApp.Name = "lblFarmFeedingApp";
            this.lblFarmFeedingApp.Size = new System.Drawing.Size(141, 20);
            this.lblFarmFeedingApp.TabIndex = 0;
            this.lblFarmFeedingApp.Text = "Farm Feeding App";
            this.lblFarmFeedingApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAnimal
            // 
            this.btnAnimal.Location = new System.Drawing.Point(524, 174);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(182, 49);
            this.btnAnimal.TabIndex = 1;
            this.btnAnimal.Text = "Create Farm Animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnFarmManager
            // 
            this.btnFarmManager.Location = new System.Drawing.Point(89, 174);
            this.btnFarmManager.Name = "btnFarmManager";
            this.btnFarmManager.Size = new System.Drawing.Size(200, 49);
            this.btnFarmManager.TabIndex = 2;
            this.btnFarmManager.Text = "Farm Manager";
            this.btnFarmManager.UseVisualStyleBackColor = true;
            this.btnFarmManager.Click += new System.EventHandler(this.btnFarmManager_Click);
            // 
            // btnAddToAnimal
            // 
            this.btnAddToAnimal.Location = new System.Drawing.Point(297, 275);
            this.btnAddToAnimal.Name = "btnAddToAnimal";
            this.btnAddToAnimal.Size = new System.Drawing.Size(196, 52);
            this.btnAddToAnimal.TabIndex = 3;
            this.btnAddToAnimal.Text = "Search Farm Animals";
            this.btnAddToAnimal.UseVisualStyleBackColor = true;
            this.btnAddToAnimal.Click += new System.EventHandler(this.btnAddToAnimal_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddToAnimal);
            this.Controls.Add(this.btnFarmManager);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.lblFarmFeedingApp);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFarmFeedingApp;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnFarmManager;
        private System.Windows.Forms.Button btnAddToAnimal;
    }
}

