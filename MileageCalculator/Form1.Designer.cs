namespace MileageCalculator
{
    partial class Form1
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
            this.numUpDown_StartingMileage = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_EndingMileage = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_GasPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mileageCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMileageCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMileageCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickTripsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickupBenjaminAndHannahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneWayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundTripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekendErrandsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitJohnAndJoAnnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneWayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roundTripToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Calculate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.trackBar_minMaxMPG = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Lbl_MPG = new System.Windows.Forms.Label();
            this.Text_MPG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_StartingMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_EndingMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_GasPrice)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_minMaxMPG)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDown_StartingMileage
            // 
            this.numUpDown_StartingMileage.Location = new System.Drawing.Point(206, 100);
            this.numUpDown_StartingMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUpDown_StartingMileage.Name = "numUpDown_StartingMileage";
            this.numUpDown_StartingMileage.Size = new System.Drawing.Size(120, 31);
            this.numUpDown_StartingMileage.TabIndex = 0;
            // 
            // numUpDown_EndingMileage
            // 
            this.numUpDown_EndingMileage.Location = new System.Drawing.Point(572, 100);
            this.numUpDown_EndingMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUpDown_EndingMileage.Name = "numUpDown_EndingMileage";
            this.numUpDown_EndingMileage.Size = new System.Drawing.Size(120, 31);
            this.numUpDown_EndingMileage.TabIndex = 1;
            // 
            // numUpDown_GasPrice
            // 
            this.numUpDown_GasPrice.DecimalPlaces = 2;
            this.numUpDown_GasPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numUpDown_GasPrice.Location = new System.Drawing.Point(965, 96);
            this.numUpDown_GasPrice.Name = "numUpDown_GasPrice";
            this.numUpDown_GasPrice.Size = new System.Drawing.Size(120, 31);
            this.numUpDown_GasPrice.TabIndex = 3;
            this.numUpDown_GasPrice.Value = new decimal(new int[] {
            350,
            0,
            0,
            131072});
            this.numUpDown_GasPrice.ValueChanged += new System.EventHandler(this.numUpDown_GasPrice_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price per Gallon:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Starting Mileage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ending Mileage:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mileageCalculatorToolStripMenuItem,
            this.quickTripsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mileageCalculatorToolStripMenuItem
            // 
            this.mileageCalculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMileageCalculatorToolStripMenuItem,
            this.quitMileageCalculatorToolStripMenuItem,
            this.carSettingsToolStripMenuItem});
            this.mileageCalculatorToolStripMenuItem.Name = "mileageCalculatorToolStripMenuItem";
            this.mileageCalculatorToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.mileageCalculatorToolStripMenuItem.Text = "Mileage Calculator";
            // 
            // aboutMileageCalculatorToolStripMenuItem
            // 
            this.aboutMileageCalculatorToolStripMenuItem.Name = "aboutMileageCalculatorToolStripMenuItem";
            this.aboutMileageCalculatorToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.aboutMileageCalculatorToolStripMenuItem.Text = "About Mileage Calculator";
            this.aboutMileageCalculatorToolStripMenuItem.Click += new System.EventHandler(this.aboutMileageCalculatorToolStripMenuItem_Click);
            // 
            // quitMileageCalculatorToolStripMenuItem
            // 
            this.quitMileageCalculatorToolStripMenuItem.Name = "quitMileageCalculatorToolStripMenuItem";
            this.quitMileageCalculatorToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.quitMileageCalculatorToolStripMenuItem.Text = "Quit Mileage Calculator";
            this.quitMileageCalculatorToolStripMenuItem.Click += new System.EventHandler(this.quitMileageCalculatorToolStripMenuItem_Click);
            // 
            // carSettingsToolStripMenuItem
            // 
            this.carSettingsToolStripMenuItem.Name = "carSettingsToolStripMenuItem";
            this.carSettingsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.carSettingsToolStripMenuItem.Text = "Car Settings...";
            this.carSettingsToolStripMenuItem.Click += new System.EventHandler(this.carSettingsToolStripMenuItem_Click);
            // 
            // quickTripsToolStripMenuItem
            // 
            this.quickTripsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickupBenjaminAndHannahToolStripMenuItem,
            this.weekendErrandsMenuItem,
            this.visitJohnAndJoAnnToolStripMenuItem});
            this.quickTripsToolStripMenuItem.Name = "quickTripsToolStripMenuItem";
            this.quickTripsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.quickTripsToolStripMenuItem.Text = "Quick Trips";
            // 
            // pickupBenjaminAndHannahToolStripMenuItem
            // 
            this.pickupBenjaminAndHannahToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneWayToolStripMenuItem,
            this.roundTripToolStripMenuItem});
            this.pickupBenjaminAndHannahToolStripMenuItem.Name = "pickupBenjaminAndHannahToolStripMenuItem";
            this.pickupBenjaminAndHannahToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.pickupBenjaminAndHannahToolStripMenuItem.Text = "Pickup Benjamin and Hannah";
            // 
            // oneWayToolStripMenuItem
            // 
            this.oneWayToolStripMenuItem.Name = "oneWayToolStripMenuItem";
            this.oneWayToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.oneWayToolStripMenuItem.Text = "One-Way";
            this.oneWayToolStripMenuItem.Click += new System.EventHandler(this.oneWayToolStripMenuItem_Click);
            // 
            // roundTripToolStripMenuItem
            // 
            this.roundTripToolStripMenuItem.Name = "roundTripToolStripMenuItem";
            this.roundTripToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.roundTripToolStripMenuItem.Text = "Round-Trip";
            this.roundTripToolStripMenuItem.Click += new System.EventHandler(this.roundTripToolStripMenuItem_Click);
            // 
            // weekendErrandsMenuItem
            // 
            this.weekendErrandsMenuItem.Name = "weekendErrandsMenuItem";
            this.weekendErrandsMenuItem.Size = new System.Drawing.Size(231, 22);
            this.weekendErrandsMenuItem.Text = "Weekend Errands";
            this.weekendErrandsMenuItem.Click += new System.EventHandler(this.pickUpBenjaminAndHannahroundTripToolStripMenuItem_Click);
            // 
            // visitJohnAndJoAnnToolStripMenuItem
            // 
            this.visitJohnAndJoAnnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneWayToolStripMenuItem1,
            this.roundTripToolStripMenuItem1});
            this.visitJohnAndJoAnnToolStripMenuItem.Name = "visitJohnAndJoAnnToolStripMenuItem";
            this.visitJohnAndJoAnnToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.visitJohnAndJoAnnToolStripMenuItem.Text = "Visit John and JoAnn";
            // 
            // oneWayToolStripMenuItem1
            // 
            this.oneWayToolStripMenuItem1.Name = "oneWayToolStripMenuItem1";
            this.oneWayToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.oneWayToolStripMenuItem1.Text = "One-Way";
            this.oneWayToolStripMenuItem1.Click += new System.EventHandler(this.oneWayToolStripMenuItem1_Click);
            // 
            // roundTripToolStripMenuItem1
            // 
            this.roundTripToolStripMenuItem1.Name = "roundTripToolStripMenuItem1";
            this.roundTripToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.roundTripToolStripMenuItem1.Text = "Round-Trip";
            this.roundTripToolStripMenuItem1.Click += new System.EventHandler(this.roundTripToolStripMenuItem1_Click);
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.Location = new System.Drawing.Point(449, 409);
            this.Btn_Calculate.Name = "Btn_Calculate";
            this.Btn_Calculate.Size = new System.Drawing.Size(329, 51);
            this.Btn_Calculate.TabIndex = 8;
            this.Btn_Calculate.Text = "Calculate Cost";
            this.Btn_Calculate.UseVisualStyleBackColor = true;
            this.Btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Set as starting mileage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1156, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // trackBar_minMaxMPG
            // 
            this.trackBar_minMaxMPG.Location = new System.Drawing.Point(390, 268);
            this.trackBar_minMaxMPG.Maximum = 46;
            this.trackBar_minMaxMPG.Minimum = 1;
            this.trackBar_minMaxMPG.Name = "trackBar_minMaxMPG";
            this.trackBar_minMaxMPG.Size = new System.Drawing.Size(440, 45);
            this.trackBar_minMaxMPG.TabIndex = 11;
            this.trackBar_minMaxMPG.Value = 23;
            this.trackBar_minMaxMPG.Scroll += new System.EventHandler(this.trackBar_minMaxMPG_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "How gas efficient is your driving?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(860, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "I\'m a penny pincher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "I\'m a bat outta hell";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::MileageCalculator.Properties.Resources.New_Icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton1.Text = "New Trip";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Lbl_MPG
            // 
            this.Lbl_MPG.AutoSize = true;
            this.Lbl_MPG.Location = new System.Drawing.Point(466, 328);
            this.Lbl_MPG.Name = "Lbl_MPG";
            this.Lbl_MPG.Size = new System.Drawing.Size(66, 25);
            this.Lbl_MPG.TabIndex = 14;
            this.Lbl_MPG.Text = "MPG:";
            // 
            // Text_MPG
            // 
            this.Text_MPG.AutoSize = true;
            this.Text_MPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_MPG.Location = new System.Drawing.Point(582, 316);
            this.Text_MPG.Name = "Text_MPG";
            this.Text_MPG.Size = new System.Drawing.Size(38, 25);
            this.Text_MPG.TabIndex = 15;
            this.Text_MPG.Text = "23";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 487);
            this.Controls.Add(this.Text_MPG);
            this.Controls.Add(this.Lbl_MPG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar_minMaxMPG);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDown_GasPrice);
            this.Controls.Add(this.numUpDown_EndingMileage);
            this.Controls.Add(this.numUpDown_StartingMileage);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "MIleage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_StartingMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_EndingMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_GasPrice)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_minMaxMPG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDown_StartingMileage;
        private System.Windows.Forms.NumericUpDown numUpDown_EndingMileage;
        private System.Windows.Forms.NumericUpDown numUpDown_GasPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mileageCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMileageCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitMileageCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickTripsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickupBenjaminAndHannahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneWayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roundTripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weekendErrandsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitJohnAndJoAnnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneWayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roundTripToolStripMenuItem1;
        private System.Windows.Forms.Button Btn_Calculate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TrackBar trackBar_minMaxMPG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        
        private System.Windows.Forms.Label Lbl_MPG;
        private System.Windows.Forms.Label Text_MPG;
    }
}

