namespace PaintApp_Ass_Prep_
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
            this.components = new System.ComponentModel.Container();
            this.gbxPaint = new System.Windows.Forms.GroupBox();
            this.rbtGloss = new System.Windows.Forms.RadioButton();
            this.rbtWater = new System.Windows.Forms.RadioButton();
            this.rbtOil = new System.Windows.Forms.RadioButton();
            this.txtGloss = new System.Windows.Forms.TextBox();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.txtOil = new System.Windows.Forms.TextBox();
            this.lblPrices = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.gbxPaintType = new System.Windows.Forms.GroupBox();
            this.rbtRegular = new System.Windows.Forms.RadioButton();
            this.rbtPremium = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.gbxPaint.SuspendLayout();
            this.gbxPaintType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPaint
            // 
            this.gbxPaint.Controls.Add(this.rbtOil);
            this.gbxPaint.Controls.Add(this.rbtWater);
            this.gbxPaint.Controls.Add(this.rbtGloss);
            this.gbxPaint.Location = new System.Drawing.Point(12, 12);
            this.gbxPaint.Name = "gbxPaint";
            this.gbxPaint.Size = new System.Drawing.Size(101, 90);
            this.gbxPaint.TabIndex = 0;
            this.gbxPaint.TabStop = false;
            this.gbxPaint.Text = "Paint Options";
            // 
            // rbtGloss
            // 
            this.rbtGloss.AutoSize = true;
            this.rbtGloss.Location = new System.Drawing.Point(6, 19);
            this.rbtGloss.Name = "rbtGloss";
            this.rbtGloss.Size = new System.Drawing.Size(51, 17);
            this.rbtGloss.TabIndex = 1;
            this.rbtGloss.TabStop = true;
            this.rbtGloss.Text = "Gloss";
            this.rbtGloss.UseVisualStyleBackColor = true;
            this.rbtGloss.CheckedChanged += new System.EventHandler(this.rbtGloss_CheckedChanged);
            // 
            // rbtWater
            // 
            this.rbtWater.AutoSize = true;
            this.rbtWater.Location = new System.Drawing.Point(6, 42);
            this.rbtWater.Name = "rbtWater";
            this.rbtWater.Size = new System.Drawing.Size(87, 17);
            this.rbtWater.TabIndex = 2;
            this.rbtWater.TabStop = true;
            this.rbtWater.Text = "Water Based";
            this.rbtWater.UseVisualStyleBackColor = true;
            this.rbtWater.CheckedChanged += new System.EventHandler(this.rbtWater_CheckedChanged);
            // 
            // rbtOil
            // 
            this.rbtOil.AutoSize = true;
            this.rbtOil.Location = new System.Drawing.Point(6, 65);
            this.rbtOil.Name = "rbtOil";
            this.rbtOil.Size = new System.Drawing.Size(70, 17);
            this.rbtOil.TabIndex = 3;
            this.rbtOil.TabStop = true;
            this.rbtOil.Text = "Oil Based";
            this.rbtOil.UseVisualStyleBackColor = true;
            this.rbtOil.CheckedChanged += new System.EventHandler(this.rbtOil_CheckedChanged);
            // 
            // txtGloss
            // 
            this.txtGloss.Location = new System.Drawing.Point(120, 31);
            this.txtGloss.Name = "txtGloss";
            this.txtGloss.Size = new System.Drawing.Size(45, 20);
            this.txtGloss.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtGloss, "Price for gloss paint");
            // 
            // txtWater
            // 
            this.txtWater.Location = new System.Drawing.Point(120, 54);
            this.txtWater.Name = "txtWater";
            this.txtWater.Size = new System.Drawing.Size(45, 20);
            this.txtWater.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtWater, "Price for water based paint");
            // 
            // txtOil
            // 
            this.txtOil.Location = new System.Drawing.Point(120, 77);
            this.txtOil.Name = "txtOil";
            this.txtOil.Size = new System.Drawing.Size(45, 20);
            this.txtOil.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtOil, "Price for oil based paint");
            // 
            // lblPrices
            // 
            this.lblPrices.AutoSize = true;
            this.lblPrices.Location = new System.Drawing.Point(117, 12);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(39, 13);
            this.lblPrices.TabIndex = 4;
            this.lblPrices.Text = "Prices:";
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(171, 12);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(52, 13);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "Discount:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(229, 9);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtDiscount, "Discount percentage");
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(12, 108);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // gbxPaintType
            // 
            this.gbxPaintType.Controls.Add(this.rbtPremium);
            this.gbxPaintType.Controls.Add(this.rbtRegular);
            this.gbxPaintType.Location = new System.Drawing.Point(119, 12);
            this.gbxPaintType.Name = "gbxPaintType";
            this.gbxPaintType.Size = new System.Drawing.Size(123, 90);
            this.gbxPaintType.TabIndex = 8;
            this.gbxPaintType.TabStop = false;
            this.gbxPaintType.Text = "Paint Type";
            this.gbxPaintType.Visible = false;
            // 
            // rbtRegular
            // 
            this.rbtRegular.AutoSize = true;
            this.rbtRegular.Location = new System.Drawing.Point(6, 19);
            this.rbtRegular.Name = "rbtRegular";
            this.rbtRegular.Size = new System.Drawing.Size(62, 17);
            this.rbtRegular.TabIndex = 0;
            this.rbtRegular.TabStop = true;
            this.rbtRegular.Text = "Regular";
            this.rbtRegular.UseVisualStyleBackColor = true;
            this.rbtRegular.CheckedChanged += new System.EventHandler(this.rbtRegular_CheckedChanged);
            // 
            // rbtPremium
            // 
            this.rbtPremium.AutoSize = true;
            this.rbtPremium.Location = new System.Drawing.Point(6, 42);
            this.rbtPremium.Name = "rbtPremium";
            this.rbtPremium.Size = new System.Drawing.Size(97, 17);
            this.rbtPremium.TabIndex = 1;
            this.rbtPremium.TabStop = true;
            this.rbtPremium.Text = "Premium(+50%)";
            this.rbtPremium.UseVisualStyleBackColor = true;
            this.rbtPremium.CheckedChanged += new System.EventHandler(this.rbtPremium_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(248, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total Price:";
            this.lblTotal.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(251, 28);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 108);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(93, 108);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(251, 54);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(0, 13);
            this.lblSummary.TabIndex = 13;
            this.lblSummary.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 147);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbxPaintType);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblPrices);
            this.Controls.Add(this.txtOil);
            this.Controls.Add(this.txtWater);
            this.Controls.Add(this.txtGloss);
            this.Controls.Add(this.gbxPaint);
            this.Name = "Form1";
            this.Text = "Paint Order";
            this.gbxPaint.ResumeLayout(false);
            this.gbxPaint.PerformLayout();
            this.gbxPaintType.ResumeLayout(false);
            this.gbxPaintType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPaint;
        private System.Windows.Forms.RadioButton rbtOil;
        private System.Windows.Forms.RadioButton rbtWater;
        private System.Windows.Forms.RadioButton rbtGloss;
        private System.Windows.Forms.TextBox txtGloss;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.TextBox txtOil;
        private System.Windows.Forms.Label lblPrices;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.GroupBox gbxPaintType;
        private System.Windows.Forms.RadioButton rbtPremium;
        private System.Windows.Forms.RadioButton rbtRegular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSummary;
    }
}

