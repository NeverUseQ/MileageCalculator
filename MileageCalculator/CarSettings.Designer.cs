namespace MileageCalculator
{
    partial class CarSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_minMPG = new System.Windows.Forms.Label();
            this.numUpDown_minMPG = new System.Windows.Forms.NumericUpDown();
            this.Lbl_maxMPG = new System.Windows.Forms.Label();
            this.numUpDown_maxMPG = new System.Windows.Forms.NumericUpDown();
            this.Btn_saveCarSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_minMPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_maxMPG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Settings";
            // 
            // Lbl_minMPG
            // 
            this.Lbl_minMPG.AutoSize = true;
            this.Lbl_minMPG.Location = new System.Drawing.Point(35, 73);
            this.Lbl_minMPG.Name = "Lbl_minMPG";
            this.Lbl_minMPG.Size = new System.Drawing.Size(101, 25);
            this.Lbl_minMPG.TabIndex = 1;
            this.Lbl_minMPG.Text = "Min MPG";
            // 
            // numUpDown_minMPG
            // 
            this.numUpDown_minMPG.Location = new System.Drawing.Point(142, 71);
            this.numUpDown_minMPG.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpDown_minMPG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_minMPG.Name = "numUpDown_minMPG";
            this.numUpDown_minMPG.Size = new System.Drawing.Size(79, 31);
            this.numUpDown_minMPG.TabIndex = 2;
            this.numUpDown_minMPG.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Lbl_maxMPG
            // 
            this.Lbl_maxMPG.AutoSize = true;
            this.Lbl_maxMPG.Location = new System.Drawing.Point(29, 123);
            this.Lbl_maxMPG.Name = "Lbl_maxMPG";
            this.Lbl_maxMPG.Size = new System.Drawing.Size(107, 25);
            this.Lbl_maxMPG.TabIndex = 3;
            this.Lbl_maxMPG.Text = "Max MPG";
            // 
            // numUpDown_maxMPG
            // 
            this.numUpDown_maxMPG.Location = new System.Drawing.Point(142, 123);
            this.numUpDown_maxMPG.Maximum = new decimal(new int[] {
            46,
            0,
            0,
            0});
            this.numUpDown_maxMPG.Minimum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numUpDown_maxMPG.Name = "numUpDown_maxMPG";
            this.numUpDown_maxMPG.Size = new System.Drawing.Size(79, 31);
            this.numUpDown_maxMPG.TabIndex = 4;
            this.numUpDown_maxMPG.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // Btn_saveCarSettings
            // 
            this.Btn_saveCarSettings.Location = new System.Drawing.Point(293, 182);
            this.Btn_saveCarSettings.Name = "Btn_saveCarSettings";
            this.Btn_saveCarSettings.Size = new System.Drawing.Size(123, 38);
            this.Btn_saveCarSettings.TabIndex = 5;
            this.Btn_saveCarSettings.Text = "Save";
            this.Btn_saveCarSettings.UseVisualStyleBackColor = true;
            this.Btn_saveCarSettings.Click += new System.EventHandler(this.Btn_saveCarSettings_Click);
            // 
            // CarSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 239);
            this.Controls.Add(this.Btn_saveCarSettings);
            this.Controls.Add(this.numUpDown_maxMPG);
            this.Controls.Add(this.Lbl_maxMPG);
            this.Controls.Add(this.numUpDown_minMPG);
            this.Controls.Add(this.Lbl_minMPG);
            this.Controls.Add(this.label1);
            this.Name = "CarSettings";
            this.Text = "Car Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_minMPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_maxMPG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_minMPG;
        private System.Windows.Forms.NumericUpDown numUpDown_minMPG;
        private System.Windows.Forms.Label Lbl_maxMPG;
        private System.Windows.Forms.NumericUpDown numUpDown_maxMPG;
        private System.Windows.Forms.Button Btn_saveCarSettings;
    }
}