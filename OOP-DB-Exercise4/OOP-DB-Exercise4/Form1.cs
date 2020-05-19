using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_DB_Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eTBdbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eTBdbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.eTBdbDataSet.Employee);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String connStr = "Data Source=LAPTOP-khae;Initial Catalog=ETBdb;Integrated Security=True";
            String commandStr = "INSERT INTO Employee VALUES(@Employee_ID, @First_Name, @Surname, @Department, @StartDate, @Salary, @Manager_Indicator)";

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sqlCommand = new SqlCommand(commandStr, conn);
            sqlCommand.Parameters.AddWithValue("@Employee_ID", employee_IDTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@First_Name", first_NameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Surname", surnameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Department", departmentTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@StartDate", startDateTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Salary", salaryTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Manager_Indicator", manager_IndicatorTextBox.Text);

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                this.employeeTableAdapter.Fill(this.eTBdbDataSet.Employee);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String connStr = "Data Source=LAPTOP-khae;Initial Catalog=ETBdb;Integrated Security=True";
            String commandStr = "UPDATE Employee SET First_Name=@First_Name, Surname=@Surname, Department=@Department, StartDate=@StartDate, Salary=@Salary, Manager_Indicator=@Manager_Indicator WHERE Employee_ID = @Employee_ID";

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sqlCommand = new SqlCommand(commandStr, conn);
            sqlCommand.Parameters.AddWithValue("@Employee_ID", employee_IDTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@First_Name", first_NameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Surname", surnameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Department", departmentTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@StartDate", startDateTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Salary", salaryTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Manager_Indicator", manager_IndicatorTextBox.Text);

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String connStr = "Data Source=LAPTOP-khae;Initial Catalog=ETBdb;Integrated Security=True";
            String commandStr = "DELETE FROM Employee WHERE Employee_ID = @Employee_ID";

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sqlCommand = new SqlCommand(commandStr, conn);
            sqlCommand.Parameters.AddWithValue("@Employee_ID", employee_IDTextBox.Text);

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                this.employeeTableAdapter.Fill(this.eTBdbDataSet.Employee);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.eTBdbDataSet.Employee);
        }

        
    }
}
