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
            this.btnContinue.Location = new System.Drawing.Point(625, 384);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(146, 54);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Add consumption";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblSearchAnimal
            // 
            this.lblSearchAnimal.AutoSize = true;
            this.lblSearchAnimal.Location = new System.Drawing.Point(264, 21);
            this.lblSearchAnimal.Name = "lblSearchAnimal";
            this.lblSearchAnimal.Size = new System.Drawing.Size(155, 20);
            this.lblSearchAnimal.TabIndex = 3;
            this.lblSearchAnimal.Text = "Search for an animal";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(35, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 41);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.Location = new System.Drawing.Point(625, 320);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(146, 55);
            this.btnViewSummary.TabIndex = 5;
            this.btnViewSummary.Text = "View Summary";
            this.btnViewSummary.UseVisualStyleBackColor = true;
            this.btnViewSummary.Click += new System.EventHandler(this.btnViewSummary_Click);
            // 
            // SearchAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewSummary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSearchAnimal);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.tbxSearchAnimal);
            this.Controls.Add(this.lvSearchAnimal);
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