namespace FarmFeedingApp
{
    partial class AnimalCostsForm
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
            this.rtbxCostSummarys = new System.Windows.Forms.RichTextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCostTotals = new System.Windows.Forms.Button();
            this.lblCostSummarys = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbxCostSummarys
            // 
            this.rtbxCostSummarys.Location = new System.Drawing.Point(183, 67);
            this.rtbxCostSummarys.Name = "rtbxCostSummarys";
            this.rtbxCostSummarys.ReadOnly = true;
            this.rtbxCostSummarys.Size = new System.Drawing.Size(407, 266);
            this.rtbxCostSummarys.TabIndex = 0;
            this.rtbxCostSummarys.Text = "";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(623, 377);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(106, 37);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCostTotals
            // 
            this.btnCostTotals.Location = new System.Drawing.Point(45, 362);
            this.btnCostTotals.Name = "btnCostTotals";
            this.btnCostTotals.Size = new System.Drawing.Size(116, 52);
            this.btnCostTotals.TabIndex = 2;
            this.btnCostTotals.Text = "Consumption Summarys";
            this.btnCostTotals.UseVisualStyleBackColor = true;
            this.btnCostTotals.Click += new System.EventHandler(this.btnCostTotals_Click);
            // 
            // lblCostSummarys
            // 
            this.lblCostSummarys.AutoSize = true;
            this.lblCostSummarys.Location = new System.Drawing.Point(253, 16);
            this.lblCostSummarys.Name = "lblCostSummarys";
            this.lblCostSummarys.Size = new System.Drawing.Size(284, 20);
            this.lblCostSummarys.TabIndex = 3;
            this.lblCostSummarys.Text = "Species Consumption Cost Summarys:";
            // 
            // AnimalCostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCostSummarys);
            this.Controls.Add(this.btnCostTotals);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.rtbxCostSummarys);
            this.Name = "AnimalCostsForm";
            this.Text = "AnimalCostsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxCostSummarys;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCostTotals;
        private System.Windows.Forms.Label lblCostSummarys;
    }
}