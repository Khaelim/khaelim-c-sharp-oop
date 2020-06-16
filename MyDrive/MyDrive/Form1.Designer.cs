namespace MyDrive
{
    partial class frmEstimate
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
            this.grpType = new System.Windows.Forms.GroupBox();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.lblExchangeRateTrailer = new System.Windows.Forms.Label();
            this.rbtBrick = new System.Windows.Forms.RadioButton();
            this.rbtConcrete = new System.Windows.Forms.RadioButton();
            this.rbtTarmac = new System.Windows.Forms.RadioButton();
            this.rbtGravel = new System.Windows.Forms.RadioButton();
            this.lblMeterPrice = new System.Windows.Forms.Label();
            this.txtBrickPrice = new System.Windows.Forms.TextBox();
            this.txtConcretePrice = new System.Windows.Forms.TextBox();
            this.txtTarmacPrice = new System.Windows.Forms.TextBox();
            this.txtGravelPrice = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdStart = new System.Windows.Forms.Button();
            this.grpFoundations = new System.Windows.Forms.GroupBox();
            this.rbtStandard = new System.Windows.Forms.RadioButton();
            this.rbtExtraDeep = new System.Windows.Forms.RadioButton();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblMeters1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblMeters2 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtGBP = new System.Windows.Forms.TextBox();
            this.lblGBP = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.grpType.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpFoundations.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(144, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Euro Drives or Patios";
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rbtGravel);
            this.grpType.Controls.Add(this.rbtTarmac);
            this.grpType.Controls.Add(this.rbtConcrete);
            this.grpType.Controls.Add(this.rbtBrick);
            this.grpType.Location = new System.Drawing.Point(12, 133);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(110, 110);
            this.grpType.TabIndex = 1;
            this.grpType.TabStop = false;
            this.grpType.Text = "Materials";
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Location = new System.Drawing.Point(97, 86);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(128, 13);
            this.lblExchangeRate.TabIndex = 2;
            this.lblExchangeRate.Text = "EXCHANGE RATE: £1 = ";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(231, 83);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(46, 20);
            this.txtExchangeRate.TabIndex = 3;
            this.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblExchangeRateTrailer
            // 
            this.lblExchangeRateTrailer.AutoSize = true;
            this.lblExchangeRateTrailer.Location = new System.Drawing.Point(284, 86);
            this.lblExchangeRateTrailer.Name = "lblExchangeRateTrailer";
            this.lblExchangeRateTrailer.Size = new System.Drawing.Size(45, 13);
            this.lblExchangeRateTrailer.TabIndex = 4;
            this.lblExchangeRateTrailer.Text = "EUROS";
            // 
            // rbtBrick
            // 
            this.rbtBrick.AutoSize = true;
            this.rbtBrick.Location = new System.Drawing.Point(6, 19);
            this.rbtBrick.Name = "rbtBrick";
            this.rbtBrick.Size = new System.Drawing.Size(57, 17);
            this.rbtBrick.TabIndex = 5;
            this.rbtBrick.TabStop = true;
            this.rbtBrick.Text = "BRICK";
            this.rbtBrick.UseVisualStyleBackColor = true;
            // 
            // rbtConcrete
            // 
            this.rbtConcrete.AutoSize = true;
            this.rbtConcrete.Location = new System.Drawing.Point(6, 42);
            this.rbtConcrete.Name = "rbtConcrete";
            this.rbtConcrete.Size = new System.Drawing.Size(84, 17);
            this.rbtConcrete.TabIndex = 6;
            this.rbtConcrete.TabStop = true;
            this.rbtConcrete.Text = "CONCRETE";
            this.rbtConcrete.UseVisualStyleBackColor = true;
            // 
            // rbtTarmac
            // 
            this.rbtTarmac.AutoSize = true;
            this.rbtTarmac.Location = new System.Drawing.Point(6, 65);
            this.rbtTarmac.Name = "rbtTarmac";
            this.rbtTarmac.Size = new System.Drawing.Size(70, 17);
            this.rbtTarmac.TabIndex = 7;
            this.rbtTarmac.TabStop = true;
            this.rbtTarmac.Text = "TARMAC";
            this.rbtTarmac.UseVisualStyleBackColor = true;
            // 
            // rbtGravel
            // 
            this.rbtGravel.AutoSize = true;
            this.rbtGravel.Location = new System.Drawing.Point(6, 87);
            this.rbtGravel.Name = "rbtGravel";
            this.rbtGravel.Size = new System.Drawing.Size(68, 17);
            this.rbtGravel.TabIndex = 8;
            this.rbtGravel.TabStop = true;
            this.rbtGravel.Text = "GRAVEL";
            this.rbtGravel.UseVisualStyleBackColor = true;
            // 
            // lblMeterPrice
            // 
            this.lblMeterPrice.AutoSize = true;
            this.lblMeterPrice.Location = new System.Drawing.Point(128, 133);
            this.lblMeterPrice.Name = "lblMeterPrice";
            this.lblMeterPrice.Size = new System.Drawing.Size(153, 13);
            this.lblMeterPrice.TabIndex = 5;
            this.lblMeterPrice.Text = "PRICE PER SQUARE METER";
            // 
            // txtBrickPrice
            // 
            this.txtBrickPrice.Location = new System.Drawing.Point(140, 151);
            this.txtBrickPrice.Name = "txtBrickPrice";
            this.txtBrickPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBrickPrice.TabIndex = 6;
            this.txtBrickPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConcretePrice
            // 
            this.txtConcretePrice.Location = new System.Drawing.Point(140, 174);
            this.txtConcretePrice.Name = "txtConcretePrice";
            this.txtConcretePrice.Size = new System.Drawing.Size(100, 20);
            this.txtConcretePrice.TabIndex = 7;
            this.txtConcretePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTarmacPrice
            // 
            this.txtTarmacPrice.Location = new System.Drawing.Point(140, 197);
            this.txtTarmacPrice.Name = "txtTarmacPrice";
            this.txtTarmacPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTarmacPrice.TabIndex = 8;
            this.txtTarmacPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGravelPrice
            // 
            this.txtGravelPrice.Location = new System.Drawing.Point(140, 219);
            this.txtGravelPrice.Name = "txtGravelPrice";
            this.txtGravelPrice.Size = new System.Drawing.Size(100, 20);
            this.txtGravelPrice.TabIndex = 9;
            this.txtGravelPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(213, 421);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 11;
            this.cmdStart.Text = "START";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpFoundations
            // 
            this.grpFoundations.Controls.Add(this.rbtExtraDeep);
            this.grpFoundations.Controls.Add(this.rbtStandard);
            this.grpFoundations.Location = new System.Drawing.Point(343, 133);
            this.grpFoundations.Name = "grpFoundations";
            this.grpFoundations.Size = new System.Drawing.Size(121, 71);
            this.grpFoundations.TabIndex = 12;
            this.grpFoundations.TabStop = false;
            this.grpFoundations.Text = "Foundations";
            this.grpFoundations.Visible = false;
            // 
            // rbtStandard
            // 
            this.rbtStandard.AutoSize = true;
            this.rbtStandard.Location = new System.Drawing.Point(6, 21);
            this.rbtStandard.Name = "rbtStandard";
            this.rbtStandard.Size = new System.Drawing.Size(85, 17);
            this.rbtStandard.TabIndex = 0;
            this.rbtStandard.TabStop = true;
            this.rbtStandard.Text = "STANDARD";
            this.rbtStandard.UseVisualStyleBackColor = true;
            // 
            // rbtExtraDeep
            // 
            this.rbtExtraDeep.AutoSize = true;
            this.rbtExtraDeep.Location = new System.Drawing.Point(6, 44);
            this.rbtExtraDeep.Name = "rbtExtraDeep";
            this.rbtExtraDeep.Size = new System.Drawing.Size(93, 17);
            this.rbtExtraDeep.TabIndex = 1;
            this.rbtExtraDeep.TabStop = true;
            this.rbtExtraDeep.Text = "EXTRA DEEP";
            this.rbtExtraDeep.UseVisualStyleBackColor = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(158, 297);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(51, 13);
            this.lblLength.TabIndex = 13;
            this.lblLength.Text = "LENGTH";
            this.lblLength.Visible = false;
            // 
            // lblMeters1
            // 
            this.lblMeters1.AutoSize = true;
            this.lblMeters1.Location = new System.Drawing.Point(284, 297);
            this.lblMeters1.Name = "lblMeters1";
            this.lblMeters1.Size = new System.Drawing.Size(52, 13);
            this.lblMeters1.TabIndex = 14;
            this.lblMeters1.Text = "METERS";
            this.lblMeters1.Visible = false;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(213, 294);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(64, 20);
            this.txtLength.TabIndex = 15;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLength.Visible = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(213, 320);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(64, 20);
            this.txtWidth.TabIndex = 18;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWidth.Visible = false;
            // 
            // lblMeters2
            // 
            this.lblMeters2.AutoSize = true;
            this.lblMeters2.Location = new System.Drawing.Point(284, 323);
            this.lblMeters2.Name = "lblMeters2";
            this.lblMeters2.Size = new System.Drawing.Size(52, 13);
            this.lblMeters2.TabIndex = 17;
            this.lblMeters2.Text = "METERS";
            this.lblMeters2.Visible = false;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(158, 323);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 13);
            this.lblWidth.TabIndex = 16;
            this.lblWidth.Text = "WIDTH";
            this.lblWidth.Visible = false;
            // 
            // txtGBP
            // 
            this.txtGBP.Location = new System.Drawing.Point(169, 354);
            this.txtGBP.Name = "txtGBP";
            this.txtGBP.ReadOnly = true;
            this.txtGBP.Size = new System.Drawing.Size(64, 20);
            this.txtGBP.TabIndex = 20;
            this.txtGBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGBP.Visible = false;
            // 
            // lblGBP
            // 
            this.lblGBP.AutoSize = true;
            this.lblGBP.Location = new System.Drawing.Point(114, 357);
            this.lblGBP.Name = "lblGBP";
            this.lblGBP.Size = new System.Drawing.Size(29, 13);
            this.lblGBP.TabIndex = 19;
            this.lblGBP.Text = "GBP";
            this.lblGBP.Visible = false;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(322, 354);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.ReadOnly = true;
            this.txtEuro.Size = new System.Drawing.Size(64, 20);
            this.txtEuro.TabIndex = 22;
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEuro.Visible = false;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(267, 357);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(38, 13);
            this.lblEuro.TabIndex = 21;
            this.lblEuro.Text = "EURO";
            this.lblEuro.Visible = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(114, 392);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(277, 19);
            this.lblOutput.TabIndex = 23;
            this.lblOutput.Text = "                                                                   ";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Visible = false;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(117, 421);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(85, 23);
            this.cmdCalculate.TabIndex = 24;
            this.cmdCalculate.Text = "CALCULATE";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Visible = false;
            this.cmdCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(299, 421);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(87, 23);
            this.cmdClear.TabIndex = 25;
            this.cmdClear.Text = "CLEAR";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Visible = false;
            this.cmdClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 456);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtGBP);
            this.Controls.Add(this.lblGBP);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblMeters2);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblMeters1);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.grpFoundations);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.txtGravelPrice);
            this.Controls.Add(this.txtTarmacPrice);
            this.Controls.Add(this.txtConcretePrice);
            this.Controls.Add(this.txtBrickPrice);
            this.Controls.Add(this.lblMeterPrice);
            this.Controls.Add(this.lblExchangeRateTrailer);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.lblExchangeRate);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drive Estimates";
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpFoundations.ResumeLayout(false);
            this.grpFoundations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton rbtGravel;
        private System.Windows.Forms.RadioButton rbtTarmac;
        private System.Windows.Forms.RadioButton rbtConcrete;
        private System.Windows.Forms.RadioButton rbtBrick;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Label lblExchangeRateTrailer;
        private System.Windows.Forms.Label lblMeterPrice;
        private System.Windows.Forms.TextBox txtBrickPrice;
        private System.Windows.Forms.TextBox txtConcretePrice;
        private System.Windows.Forms.TextBox txtTarmacPrice;
        private System.Windows.Forms.TextBox txtGravelPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.GroupBox grpFoundations;
        private System.Windows.Forms.RadioButton rbtExtraDeep;
        private System.Windows.Forms.RadioButton rbtStandard;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblMeters1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblMeters2;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtGBP;
        private System.Windows.Forms.Label lblGBP;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdClear;
    }
}

