namespace FarmFeedingApp
{
    partial class AnimalConsumptionForm
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
            this.nudConsumption = new System.Windows.Forms.NumericUpDown();
            this.lblFoodConsumed = new System.Windows.Forms.Label();
            this.lblconsumpD1 = new System.Windows.Forms.Label();
            this.btnEnterConsumption = new System.Windows.Forms.Button();
            this.rtbAnimalSummary = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsumption)).BeginInit();
            this.SuspendLayout();
            // 
            // nudConsumption
            // 
            this.nudConsumption.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudConsumption.Location = new System.Drawing.Point(84, 218);
            this.nudConsumption.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudConsumption.Name = "nudConsumption";
            this.nudConsumption.Size = new System.Drawing.Size(150, 26);
            this.nudConsumption.TabIndex = 0;
            // 
            // lblFoodConsumed
            // 
            this.lblFoodConsumed.AutoSize = true;
            this.lblFoodConsumed.Location = new System.Drawing.Point(280, 22);
            this.lblFoodConsumed.Name = "lblFoodConsumed";
            this.lblFoodConsumed.Size = new System.Drawing.Size(227, 20);
            this.lblFoodConsumed.TabIndex = 1;
            this.lblFoodConsumed.Text = "Add animals food consumption";
            // 
            // lblconsumpD1
            // 
            this.lblconsumpD1.AutoSize = true;
            this.lblconsumpD1.Location = new System.Drawing.Point(80, 177);
            this.lblconsumpD1.Name = "lblconsumpD1";
            this.lblconsumpD1.Size = new System.Drawing.Size(128, 20);
            this.lblconsumpD1.TabIndex = 2;
            this.lblconsumpD1.Text = "Food consumed:";
            // 
            // btnEnterConsumption
            // 
            this.btnEnterConsumption.Location = new System.Drawing.Point(140, 329);
            this.btnEnterConsumption.Name = "btnEnterConsumption";
            this.btnEnterConsumption.Size = new System.Drawing.Size(224, 50);
            this.btnEnterConsumption.TabIndex = 15;
            this.btnEnterConsumption.Text = "Enter Consumption";
            this.btnEnterConsumption.UseVisualStyleBackColor = true;
            this.btnEnterConsumption.Click += new System.EventHandler(this.btnEnterConsumption_Click);
            // 
            // rtbAnimalSummary
            // 
            this.rtbAnimalSummary.Location = new System.Drawing.Point(427, 116);
            this.rtbAnimalSummary.Name = "rtbAnimalSummary";
            this.rtbAnimalSummary.Size = new System.Drawing.Size(300, 232);
            this.rtbAnimalSummary.TabIndex = 18;
            this.rtbAnimalSummary.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(649, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 37);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AnimalConsumptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtbAnimalSummary);
            this.Controls.Add(this.btnEnterConsumption);
            this.Controls.Add(this.lblconsumpD1);
            this.Controls.Add(this.lblFoodConsumed);
            this.Controls.Add(this.nudConsumption);
            this.Name = "AnimalConsumptionForm";
            this.Text = "AnimalConsumptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudConsumption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudConsumption;
        private System.Windows.Forms.Label lblFoodConsumed;
        private System.Windows.Forms.Label lblconsumpD1;
        private System.Windows.Forms.Button btnEnterConsumption;
        private System.Windows.Forms.RichTextBox rtbAnimalSummary;
        private System.Windows.Forms.Button btnCancel;
    }
}