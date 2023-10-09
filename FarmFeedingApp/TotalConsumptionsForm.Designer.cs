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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalConsumptionsForm));
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
            this.lblTotalConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalConsumption.Location = new System.Drawing.Point(163, 28);
            this.lblTotalConsumption.Name = "lblTotalConsumption";
            this.lblTotalConsumption.Size = new System.Drawing.Size(534, 36);
            this.lblTotalConsumption.TabIndex = 0;
            this.lblTotalConsumption.Text = "Species Total Consumption Summarys:";
            // 
            // rtbxConsumptionSummarys
            // 
            this.rtbxConsumptionSummarys.BackColor = System.Drawing.Color.White;
            this.rtbxConsumptionSummarys.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbxConsumptionSummarys.Location = new System.Drawing.Point(27, 85);
            this.rtbxConsumptionSummarys.Name = "rtbxConsumptionSummarys";
            this.rtbxConsumptionSummarys.ReadOnly = true;
            this.rtbxConsumptionSummarys.Size = new System.Drawing.Size(433, 253);
            this.rtbxConsumptionSummarys.TabIndex = 1;
            this.rtbxConsumptionSummarys.Text = "";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(669, 380);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(86, 43);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConsumptionsTotals
            // 
            this.btnConsumptionsTotals.BackColor = System.Drawing.Color.White;
            this.btnConsumptionsTotals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsumptionsTotals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumptionsTotals.Location = new System.Drawing.Point(27, 360);
            this.btnConsumptionsTotals.Name = "btnConsumptionsTotals";
            this.btnConsumptionsTotals.Size = new System.Drawing.Size(187, 78);
            this.btnConsumptionsTotals.TabIndex = 3;
            this.btnConsumptionsTotals.Text = "Consumption Cost Summarys";
            this.btnConsumptionsTotals.UseVisualStyleBackColor = false;
            this.btnConsumptionsTotals.Click += new System.EventHandler(this.btnConsumptionsCosts_Click);
            // 
            // pbxFeedPicture
            // 
            this.pbxFeedPicture.Location = new System.Drawing.Point(495, 89);
            this.pbxFeedPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxFeedPicture.Name = "pbxFeedPicture";
            this.pbxFeedPicture.Size = new System.Drawing.Size(258, 249);
            this.pbxFeedPicture.TabIndex = 4;
            this.pbxFeedPicture.TabStop = false;
            // 
            // TotalConsumptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.pbxFeedPicture);
            this.Controls.Add(this.btnConsumptionsTotals);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.rtbxConsumptionSummarys);
            this.Controls.Add(this.lblTotalConsumption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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