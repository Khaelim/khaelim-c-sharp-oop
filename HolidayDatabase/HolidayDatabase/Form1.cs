using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidayDatabase
{
    public partial class frmHoliday : Form
    {
        public frmHoliday()
        {
            InitializeComponent();
        }

        private void tblHolidayBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblHolidayBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelDBDataSet);
        }

        private void frmHoliday_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDBDataSet.tblHoliday' table. You can move, or remove it, as needed.
            this.tblHolidayTableAdapter.Fill(this.travelDBDataSet.tblHoliday);
            txtRecordNumber.Text = "1 of " + tblHolidayBindingSource.Count;
        }
        //this code is used when the "<<" button is pressed and returns the user to the first record
        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.tblHolidayBindingSource.MoveFirst();
            int number = tblHolidayBindingSource.Position + 1;
            txtRecordNumber.Text = (number +" of "+ tblHolidayBindingSource.Count);

        }
        //this code is used when the "<" button is pressed and shows the user to the previous record
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.tblHolidayBindingSource.MovePrevious();
            int number = tblHolidayBindingSource.Position + 1;
            txtRecordNumber.Text = (number + " of " + tblHolidayBindingSource.Count);
        }
        //this code is used when the ">" button is pressed and shows the user to the next record
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tblHolidayBindingSource.MoveNext();
            int number = tblHolidayBindingSource.Position + 1;
            txtRecordNumber.Text = (number + " of " + tblHolidayBindingSource.Count);
        }
        //this code is used when the ">>" button is pressed and shows the user to the last record
        private void btnLast_Click(object sender, EventArgs e)
        {
            this.tblHolidayBindingSource.MoveLast();
            int number = tblHolidayBindingSource.Position + 1;
            txtRecordNumber.Text = (number + " of " + tblHolidayBindingSource.Count);
        }
        //this code is used when the "Exit" button is clicked and closes the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //this code is used when the "Cancel" button is clicked, it will cancel any non updated changes
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.tblHolidayTableAdapter.Fill(this.travelDBDataSet.tblHoliday);
            txtRecordNumber.Text = ((tblHolidayBindingSource.Position + 1) + " of " + tblHolidayBindingSource.Count);
        }
        //the "Add" button is used to add a new record to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(holidayNoTextBox.Text) > 1000 || Convert.ToInt32(holidayNoTextBox.Text) <200)
            {
                MessageBox.Show("1: Holiday number must be in range 200 to 1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String connStr = "Data Source=laptop-khae;Initial Catalog=TravelDB;Integrated Security=True";

            String commandStr = "INSERT INTO tblHoliday VALUES(@HolidayNo, @Destination, @Cost, @DepartureDate, @NoOfDays, @Available)";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sqlCommand = new SqlCommand(commandStr, conn);
            sqlCommand.Parameters.AddWithValue("@HolidayNo", holidayNoTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Destination", destinationTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Cost", costTextBox.Text.Substring(1));
            sqlCommand.Parameters.AddWithValue("@DepartureDate", Convert.ToDateTime(departureDateTextBox.Text));
            sqlCommand.Parameters.AddWithValue("@NoOfDays", noOfDaysTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Available", (availableCheckBox.Checked)); 

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                this.tblHolidayTableAdapter.Fill(this.travelDBDataSet.tblHoliday);
                txtRecordNumber.Text = ((tblHolidayBindingSource.Position + 1) + " of " + tblHolidayBindingSource.Count);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL exception");
            }
            finally
            {
                conn.Close();
            }
        }
        // The "Delete" button is used to delete a record from the database based on the holiday number
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String connStr = "Data Source=laptop-khae;Initial Catalog=TravelDB;Integrated Security=True";

            String commandStr = "DELETE FROM tblHoliday WHERE HolidayNo = @HolidayNo";

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sqlCommand = new SqlCommand(commandStr, conn);
            sqlCommand.Parameters.AddWithValue("@HolidayNo", holidayNoTextBox.Text);

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                this.tblHolidayTableAdapter.Fill(this.travelDBDataSet.tblHoliday);
                txtRecordNumber.Text = ((tblHolidayBindingSource.Position + 1) + " of " + tblHolidayBindingSource.Count);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL exception");
            }
            finally
            {
                conn.Close();
            }
        }
        //the "Update" button is usedto update a record based on the holiday number
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String connStr = "Data Source=laptop-khae;Initial Catalog=TravelDB;Integrated Security=True";

            String commandStr = "UPDATE tblHoliday SET Destination=@Destination, Cost=@Cost, DepartureDate=@DepartureDate, NoOfDays=@NoOfDays, Available=@Available WHERE HolidayNo = @HolidayNo";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sqlCommand = new SqlCommand(commandStr, conn);
            sqlCommand.Parameters.AddWithValue("@HolidayNo", holidayNoTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Destination", destinationTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Cost", costTextBox.Text.Substring(1));
            sqlCommand.Parameters.AddWithValue("@DepartureDate", Convert.ToDateTime(departureDateTextBox.Text));
            sqlCommand.Parameters.AddWithValue("@NoOfDays", noOfDaysTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Available", (availableCheckBox.Checked)); //Make a checkbox and use conditional operator

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                this.tblHolidayTableAdapter.Fill(this.travelDBDataSet.tblHoliday);
                txtRecordNumber.Text = ((tblHolidayBindingSource.Position + 1) + " of " + tblHolidayBindingSource.Count);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL exception");
            }
            finally
            {
                conn.Close();
            }
        }
        //The "Print" button is used to write all records to a text file
        private void btnPrint_Click(object sender, EventArgs e)
        {
            String connStr = "Data Source=laptop-khae;Initial Catalog=TravelDB;Integrated Security=True";

            String commandStr = "SELECT * FROM tblHoliday";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sqlCommand = new SqlCommand(commandStr, conn);
            SqlDataReader sqlReader = null;
            try
            {
                conn.Open();
                sqlReader = sqlCommand.ExecuteReader();
                this.tblHolidayTableAdapter.Fill(this.travelDBDataSet.tblHoliday);
                txtRecordNumber.Text = ((tblHolidayBindingSource.Position + 1) + " of " + tblHolidayBindingSource.Count);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL exception");
            }

            using (StreamWriter sw = new StreamWriter(File.Open("Records.txt", System.IO.FileMode.Create)))
            {
                sw.WriteLine("\t\t\t\tDownton Travel\t\t\t\t\tPage 1");
                sw.WriteLine("Holiday No\tDestination\t\tDate\t\tCost\t\tNo of Days\tAvailable");
                int counter = 2, i = 0;
                while (sqlReader.Read())
                {
                    i++;
                    if (i == 50)
                    {
                        sw.WriteLine("\t\t\t\tDownton Travel\t\t\t\t\tPage "+counter++);
                    }
                    sw.WriteLine(sqlReader.GetValue(0)+ "\t\t" + sqlReader.GetValue(1)+ "   \t\t" + sqlReader.GetValue(3).ToString().Substring(0, 10) + "\t€" + sqlReader.GetValue(2)+ "  \t\t" + sqlReader.GetValue(4) + "\t" + (sqlReader.GetValue(5).ToString()=="True" ? "Yes" : "No"));
                }
            }
            conn.Close();
        }
    }
}
