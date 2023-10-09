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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalCostsForm));
            this.rtbxCostSummarys = new System.Windows.Forms.RichTextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConsumptionTotals = new System.Windows.Forms.Button();
            this.lblCostSummarys = new System.Windows.Forms.Label();
            this.pbxMoney = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbxCostSummarys
            // 
            this.rtbxCostSummarys.BackColor = System.Drawing.Color.White;
            this.rtbxCostSummarys.Location = new System.Drawing.Point(16, 58);
            this.rtbxCostSummarys.Name = "rtbxCostSummarys";
            this.rtbxCostSummarys.ReadOnly = true;
            this.rtbxCostSummarys.Size = new System.Drawing.Size(408, 266);
            this.rtbxCostSummarys.TabIndex = 0;
            this.rtbxCostSummarys.Text = "";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(622, 377);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(106, 37);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConsumptionTotals
            // 
            this.btnConsumptionTotals.BackColor = System.Drawing.Color.White;
            this.btnConsumptionTotals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsumptionTotals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumptionTotals.Location = new System.Drawing.Point(45, 362);
            this.btnConsumptionTotals.Name = "btnConsumptionTotals";
            this.btnConsumptionTotals.Size = new System.Drawing.Size(154, 75);
            this.btnConsumptionTotals.TabIndex = 2;
            this.btnConsumptionTotals.Text = "Consumption Summarys";
            this.btnConsumptionTotals.UseVisualStyleBackColor = false;
            this.btnConsumptionTotals.Click += new System.EventHandler(this.btnConsumptionTotals_Click);
            // 
            // lblCostSummarys
            // 
            this.lblCostSummarys.AutoSize = true;
            this.lblCostSummarys.Location = new System.Drawing.Point(254, 15);
            this.lblCostSummarys.Name = "lblCostSummarys";
            this.lblCostSummarys.Size = new System.Drawing.Size(284, 20);
            this.lblCostSummarys.TabIndex = 3;
            this.lblCostSummarys.Text = "Species Consumption Cost Summarys:";
            // 
            // pbxMoney
            // 
            this.pbxMoney.Location = new System.Drawing.Point(496, 57);
            this.pbxMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxMoney.Name = "pbxMoney";
            this.pbxMoney.Size = new System.Drawing.Size(232, 289);
            this.pbxMoney.TabIndex = 4;
            this.pbxMoney.TabStop = false;
            // 
            // AnimalCostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.pbxMoney);
            this.Controls.Add(this.lblCostSummarys);
            this.Controls.Add(this.btnConsumptionTotals);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.rtbxCostSummarys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalCostsForm";
            this.Text = "AnimalCostsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxCostSummarys;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnConsumptionTotals;
        private System.Windows.Forms.Label lblCostSummarys;
        private System.Windows.Forms.PictureBox pbxMoney;
    }
}