namespace FarmFeedingApp
{
    partial class SearchAnimalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAnimalForm));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lvSearchAnimal = new System.Windows.Forms.ListView();
            this.tbxSearchAnimal = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblSearchAnimal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lvSearchAnimal
            // 
            this.lvSearchAnimal.FullRowSelect = true;
            this.lvSearchAnimal.HideSelection = false;
            this.lvSearchAnimal.Location = new System.Drawing.Point(242, 133);
            this.lvSearchAnimal.Name = "lvSearchAnimal";
            this.lvSearchAnimal.Size = new System.Drawing.Size(292, 242);
            this.lvSearchAnimal.TabIndex = 0;
            this.lvSearchAnimal.UseCompatibleStateImageBehavior = false;
            this.lvSearchAnimal.SelectedIndexChanged += new System.EventHandler(this.lvSearchAnimal_SelectedIndexChanged);
            // 
            // tbxSearchAnimal
            // 
            this.tbxSearchAnimal.Location = new System.Drawing.Point(242, 83);
            this.tbxSearchAnimal.Name = "tbxSearchAnimal";
            this.tbxSearchAnimal.Size = new System.Drawing.Size(291, 26);
            this.tbxSearchAnimal.TabIndex = 1;
            this.tbxSearchAnimal.TextChanged += new System.EventHandler(this.tbxSearchAnimal_TextChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.White;
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Location = new System.Drawing.Point(607, 385);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(164, 53);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Add consumption";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblSearchAnimal
            // 
            this.lblSearchAnimal.AutoSize = true;
            this.lblSearchAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAnimal.Location = new System.Drawing.Point(246, 19);
            this.lblSearchAnimal.Name = "lblSearchAnimal";
            this.lblSearchAnimal.Size = new System.Drawing.Size(287, 36);
            this.lblSearchAnimal.TabIndex = 3;
            this.lblSearchAnimal.Text = "Search for an animal";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(35, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 53);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.BackColor = System.Drawing.Color.White;
            this.btnViewSummary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSummary.Location = new System.Drawing.Point(607, 320);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(164, 55);
            this.btnViewSummary.TabIndex = 5;
            this.btnViewSummary.Text = "View Summary";
            this.btnViewSummary.UseVisualStyleBackColor = false;
            this.btnViewSummary.Click += new System.EventHandler(this.btnViewSummary_Click);
            // 
            // SearchAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewSummary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSearchAnimal);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.tbxSearchAnimal);
            this.Controls.Add(this.lvSearchAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchAnimalForm";
            this.Text = "SearchAnimalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ListView lvSearchAnimal;
        private System.Windows.Forms.TextBox tbxSearchAnimal;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblSearchAnimal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewSummary;
    }
}