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
            this.pbxMoney = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbxCostSummarys
            // 
            this.rtbxCostSummarys.Location = new System.Drawing.Point(11, 38);
            this.rtbxCostSummarys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbxCostSummarys.Name = "rtbxCostSummarys";
            this.rtbxCostSummarys.ReadOnly = true;
            this.rtbxCostSummarys.Size = new System.Drawing.Size(273, 174);
            this.rtbxCostSummarys.TabIndex = 0;
            this.rtbxCostSummarys.Text = "";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(415, 245);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(71, 24);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCostTotals
            // 
            this.btnCostTotals.Location = new System.Drawing.Point(30, 235);
            this.btnCostTotals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCostTotals.Name = "btnCostTotals";
            this.btnCostTotals.Size = new System.Drawing.Size(77, 34);
            this.btnCostTotals.TabIndex = 2;
            this.btnCostTotals.Text = "Consumption Summarys";
            this.btnCostTotals.UseVisualStyleBackColor = true;
            this.btnCostTotals.Click += new System.EventHandler(this.btnCostTotals_Click);
            // 
            // lblCostSummarys
            // 
            this.lblCostSummarys.AutoSize = true;
            this.lblCostSummarys.Location = new System.Drawing.Point(169, 10);
            this.lblCostSummarys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostSummarys.Name = "lblCostSummarys";
            this.lblCostSummarys.Size = new System.Drawing.Size(187, 13);
            this.lblCostSummarys.TabIndex = 3;
            this.lblCostSummarys.Text = "Species Consumption Cost Summarys:";
            // 
            // pbxMoney
            // 
            this.pbxMoney.Location = new System.Drawing.Point(331, 37);
            this.pbxMoney.Name = "pbxMoney";
            this.pbxMoney.Size = new System.Drawing.Size(155, 188);
            this.pbxMoney.TabIndex = 4;
            this.pbxMoney.TabStop = false;
            // 
            // AnimalCostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.pbxMoney);
            this.Controls.Add(this.lblCostSummarys);
            this.Controls.Add(this.btnCostTotals);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.rtbxCostSummarys);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AnimalCostsForm";
            this.Text = "AnimalCostsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxCostSummarys;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCostTotals;
        private System.Windows.Forms.Label lblCostSummarys;
        private System.Windows.Forms.PictureBox pbxMoney;
    }
}