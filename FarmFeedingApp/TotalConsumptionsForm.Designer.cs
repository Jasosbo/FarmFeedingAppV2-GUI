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
            this.pbxFeedPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFeedPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalConsumption
            // 
            this.lblTotalConsumption.AutoSize = true;
            this.lblTotalConsumption.Location = new System.Drawing.Point(166, 27);
            this.lblTotalConsumption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalConsumption.Name = "lblTotalConsumption";
            this.lblTotalConsumption.Size = new System.Drawing.Size(190, 13);
            this.lblTotalConsumption.TabIndex = 0;
            this.lblTotalConsumption.Text = "Species Total Consumption Summarys:";
            // 
            // rtbxConsumptionSummarys
            // 
            this.rtbxConsumptionSummarys.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbxConsumptionSummarys.Location = new System.Drawing.Point(18, 55);
            this.rtbxConsumptionSummarys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbxConsumptionSummarys.Name = "rtbxConsumptionSummarys";
            this.rtbxConsumptionSummarys.ReadOnly = true;
            this.rtbxConsumptionSummarys.Size = new System.Drawing.Size(290, 166);
            this.rtbxConsumptionSummarys.TabIndex = 1;
            this.rtbxConsumptionSummarys.Text = "";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(446, 247);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(57, 28);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConsumptionsTotals
            // 
            this.btnConsumptionsTotals.Location = new System.Drawing.Point(18, 234);
            this.btnConsumptionsTotals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsumptionsTotals.Name = "btnConsumptionsTotals";
            this.btnConsumptionsTotals.Size = new System.Drawing.Size(79, 51);
            this.btnConsumptionsTotals.TabIndex = 3;
            this.btnConsumptionsTotals.Text = "Consumption Cost Summarys";
            this.btnConsumptionsTotals.UseVisualStyleBackColor = true;
            this.btnConsumptionsTotals.Click += new System.EventHandler(this.btnConsumptionsCosts_Click);
            // 
            // pbxFeedPicture
            // 
            this.pbxFeedPicture.Location = new System.Drawing.Point(330, 58);
            this.pbxFeedPicture.Name = "pbxFeedPicture";
            this.pbxFeedPicture.Size = new System.Drawing.Size(172, 162);
            this.pbxFeedPicture.TabIndex = 4;
            this.pbxFeedPicture.TabStop = false;
            // 
            // TotalConsumptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.pbxFeedPicture);
            this.Controls.Add(this.btnConsumptionsTotals);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.rtbxConsumptionSummarys);
            this.Controls.Add(this.lblTotalConsumption);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TotalConsumptionsForm";
            this.Text = "TotalConsumptionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFeedPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalConsumption;
        private System.Windows.Forms.RichTextBox rtbxConsumptionSummarys;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnConsumptionsTotals;
        private System.Windows.Forms.PictureBox pbxFeedPicture;
    }
}