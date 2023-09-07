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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnFarmManager = new System.Windows.Forms.Button();
            this.btnAddToAnimal = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnimal
            // 
            this.btnAnimal.BackColor = System.Drawing.Color.White;
            this.btnAnimal.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Location = new System.Drawing.Point(435, 75);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(246, 61);
            this.btnAnimal.TabIndex = 1;
            this.btnAnimal.Text = "Create Farm Animal";
            this.btnAnimal.UseVisualStyleBackColor = false;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnFarmManager
            // 
            this.btnFarmManager.BackColor = System.Drawing.Color.White;
            this.btnFarmManager.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnFarmManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFarmManager.Location = new System.Drawing.Point(435, 298);
            this.btnFarmManager.Name = "btnFarmManager";
            this.btnFarmManager.Size = new System.Drawing.Size(246, 61);
            this.btnFarmManager.TabIndex = 2;
            this.btnFarmManager.Text = "Farm Manager";
            this.btnFarmManager.UseVisualStyleBackColor = false;
            this.btnFarmManager.Click += new System.EventHandler(this.btnFarmManager_Click);
            // 
            // btnAddToAnimal
            // 
            this.btnAddToAnimal.BackColor = System.Drawing.Color.White;
            this.btnAddToAnimal.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddToAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToAnimal.Location = new System.Drawing.Point(435, 186);
            this.btnAddToAnimal.Name = "btnAddToAnimal";
            this.btnAddToAnimal.Size = new System.Drawing.Size(246, 61);
            this.btnAddToAnimal.TabIndex = 3;
            this.btnAddToAnimal.Text = "Search Farm Animals";
            this.btnAddToAnimal.UseVisualStyleBackColor = false;
            this.btnAddToAnimal.Click += new System.EventHandler(this.btnAddToAnimal_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Location = new System.Drawing.Point(115, 106);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(225, 225);
            this.pbxLogo.TabIndex = 4;
            this.pbxLogo.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnAddToAnimal);
            this.Controls.Add(this.btnFarmManager);
            this.Controls.Add(this.btnAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "Farm Feeding App";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnFarmManager;
        private System.Windows.Forms.Button btnAddToAnimal;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}

