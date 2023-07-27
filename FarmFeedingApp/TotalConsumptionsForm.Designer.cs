namespace FarmFeedingApp
{
    partial class TotalConsumptionsForm
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
            this.lblTotalConsumption = new System.Windows.Forms.Label();
            this.rtbxConsumptionSummarys = new System.Windows.Forms.RichTextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConsumptionsTotals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalConsumption
            // 
            this.lblTotalConsumption.AutoSize = true;
            this.lblTotalConsumption.Location = new System.Drawing.Point(249, 42);
            this.lblTotalConsumption.Name = "lblTotalConsumption";
            this.lblTotalConsumption.Size = new System.Drawing.Size(286, 20);
            this.lblTotalConsumption.TabIndex = 0;
            this.lblTotalConsumption.Text = "Species Total Consumption Summarys:";
            // 
            // rtbxConsumptionSummarys
            // 
            this.rtbxConsumptionSummarys.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbxConsumptionSummarys.Location = new System.Drawing.Point(165, 102);
            this.rtbxConsumptionSummarys.Name = "rtbxConsumptionSummarys";
            this.rtbxConsumptionSummarys.ReadOnly = true;
            this.rtbxConsumptionSummarys.Size = new System.Drawing.Size(433, 290);
            this.rtbxConsumptionSummarys.TabIndex = 1;
            this.rtbxConsumptionSummarys.Text = "";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(669, 380);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(86, 43);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConsumptionsTotals
            // 
            this.btnConsumptionsTotals.Location = new System.Drawing.Point(27, 360);
            this.btnConsumptionsTotals.Name = "btnConsumptionsTotals";
            this.btnConsumptionsTotals.Size = new System.Drawing.Size(118, 78);
            this.btnConsumptionsTotals.TabIndex = 3;
            this.btnConsumptionsTotals.Text = "Consumption Cost Summarys";
            this.btnConsumptionsTotals.UseVisualStyleBackColor = true;
            this.btnConsumptionsTotals.Click += new System.EventHandler(this.btnConsumptionsCosts_Click);
            // 
            // TotalConsumptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsumptionsTotals);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.rtbxConsumptionSummarys);
            this.Controls.Add(this.lblTotalConsumption);
            this.Name = "TotalConsumptionsForm";
            this.Text = "TotalConsumptionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalConsumption;
        private System.Windows.Forms.RichTextBox rtbxConsumptionSummarys;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnConsumptionsTotals;
    }
}