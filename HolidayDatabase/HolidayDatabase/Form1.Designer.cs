namespace HolidayDatabase
{
    partial class frmHoliday
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
            System.Windows.Forms.Label holidayNoLabel;
            System.Windows.Forms.Label destinationLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label departureDateLabel;
            System.Windows.Forms.Label noOfDaysLabel;
            System.Windows.Forms.Label availableLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoliday));
            this.labMain = new System.Windows.Forms.Label();
            this.travelDBDataSet = new HolidayDatabase.TravelDBDataSet();
            this.tblHolidayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHolidayTableAdapter = new HolidayDatabase.TravelDBDataSetTableAdapters.tblHolidayTableAdapter();
            this.tableAdapterManager = new HolidayDatabase.TravelDBDataSetTableAdapters.TableAdapterManager();
            this.holidayNoTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.departureDateTextBox = new System.Windows.Forms.TextBox();
            this.noOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtRecordNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            holidayNoLabel = new System.Windows.Forms.Label();
            destinationLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            departureDateLabel = new System.Windows.Forms.Label();
            noOfDaysLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHolidayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labMain
            // 
            this.labMain.AutoSize = true;
            this.labMain.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMain.ForeColor = System.Drawing.Color.Green;
            this.labMain.Location = new System.Drawing.Point(126, 23);
            this.labMain.Name = "labMain";
            this.labMain.Size = new System.Drawing.Size(167, 27);
            this.labMain.TabIndex = 0;
            this.labMain.Text = "Downtown Travel";
            // 
            // travelDBDataSet
            // 
            this.travelDBDataSet.DataSetName = "TravelDBDataSet";
            this.travelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHolidayBindingSource
            // 
            this.tblHolidayBindingSource.DataMember = "tblHoliday";
            this.tblHolidayBindingSource.DataSource = this.travelDBDataSet;
            // 
            // tblHolidayTableAdapter
            // 
            this.tblHolidayTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblHolidayTableAdapter = this.tblHolidayTableAdapter;
            this.tableAdapterManager.UpdateOrder = HolidayDatabase.TravelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // holidayNoLabel
            // 
            holidayNoLabel.AutoSize = true;
            holidayNoLabel.Location = new System.Drawing.Point(12, 81);
            holidayNoLabel.Name = "holidayNoLabel";
            holidayNoLabel.Size = new System.Drawing.Size(62, 13);
            holidayNoLabel.TabIndex = 2;
            holidayNoLabel.Text = "Holiday No:";
            // 
            // holidayNoTextBox
            // 
            this.holidayNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "HolidayNo", true));
            this.holidayNoTextBox.Location = new System.Drawing.Point(101, 78);
            this.holidayNoTextBox.Name = "holidayNoTextBox";
            this.holidayNoTextBox.Size = new System.Drawing.Size(47, 20);
            this.holidayNoTextBox.TabIndex = 3;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new System.Drawing.Point(12, 107);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new System.Drawing.Size(63, 13);
            destinationLabel.TabIndex = 4;
            destinationLabel.Text = "Destination:";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "Destination", true));
            this.destinationTextBox.Location = new System.Drawing.Point(101, 104);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(163, 20);
            this.destinationTextBox.TabIndex = 5;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(12, 133);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 6;
            costLabel.Text = "Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "Cost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.costTextBox.Location = new System.Drawing.Point(101, 130);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 7;
            this.costTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.Location = new System.Drawing.Point(12, 159);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new System.Drawing.Size(83, 13);
            departureDateLabel.TabIndex = 8;
            departureDateLabel.Text = "Departure Date:";
            // 
            // departureDateTextBox
            // 
            this.departureDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "DepartureDate", true));
            this.departureDateTextBox.Location = new System.Drawing.Point(101, 156);
            this.departureDateTextBox.Name = "departureDateTextBox";
            this.departureDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.departureDateTextBox.TabIndex = 9;
            // 
            // noOfDaysLabel
            // 
            noOfDaysLabel.AutoSize = true;
            noOfDaysLabel.Location = new System.Drawing.Point(12, 185);
            noOfDaysLabel.Name = "noOfDaysLabel";
            noOfDaysLabel.Size = new System.Drawing.Size(65, 13);
            noOfDaysLabel.TabIndex = 10;
            noOfDaysLabel.Text = "No Of Days:";
            // 
            // noOfDaysTextBox
            // 
            this.noOfDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "NoOfDays", true));
            this.noOfDaysTextBox.Location = new System.Drawing.Point(101, 182);
            this.noOfDaysTextBox.Name = "noOfDaysTextBox";
            this.noOfDaysTextBox.Size = new System.Drawing.Size(47, 20);
            this.noOfDaysTextBox.TabIndex = 11;
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new System.Drawing.Point(12, 213);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(53, 13);
            availableLabel.TabIndex = 12;
            availableLabel.Text = "Available:";
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblHolidayBindingSource, "Available", true));
            this.availableCheckBox.Location = new System.Drawing.Point(101, 208);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(27, 24);
            this.availableCheckBox.TabIndex = 13;
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 318);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(53, 35);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(62, 318);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(53, 35);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(251, 318);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(53, 35);
            this.btnLast.TabIndex = 17;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(201, 318);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 35);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtRecordNumber
            // 
            this.txtRecordNumber.Location = new System.Drawing.Point(121, 326);
            this.txtRecordNumber.Name = "txtRecordNumber";
            this.txtRecordNumber.ReadOnly = true;
            this.txtRecordNumber.Size = new System.Drawing.Size(74, 20);
            this.txtRecordNumber.TabIndex = 18;
            this.txtRecordNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(381, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 34);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(381, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 34);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(381, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 34);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(381, 198);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 34);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 34);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(381, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 34);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(472, 365);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRecordNumber);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(availableLabel);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(noOfDaysLabel);
            this.Controls.Add(this.noOfDaysTextBox);
            this.Controls.Add(departureDateLabel);
            this.Controls.Add(this.departureDateTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(holidayNoLabel);
            this.Controls.Add(this.holidayNoTextBox);
            this.Controls.Add(this.labMain);
            this.Name = "frmHoliday";
            this.Text = "Task A Khaelim Ramsey 22/06/2020";
            this.Load += new System.EventHandler(this.frmHoliday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHolidayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMain;
        private TravelDBDataSet travelDBDataSet;
        private System.Windows.Forms.BindingSource tblHolidayBindingSource;
        private TravelDBDataSetTableAdapters.tblHolidayTableAdapter tblHolidayTableAdapter;
        private TravelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox holidayNoTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox departureDateTextBox;
        private System.Windows.Forms.TextBox noOfDaysTextBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtRecordNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}

