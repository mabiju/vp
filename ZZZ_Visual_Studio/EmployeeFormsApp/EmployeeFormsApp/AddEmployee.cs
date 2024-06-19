using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EmployeeFormsApp
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=vjmalla;Initial Catalog=employee_db;Integrated Security=True;Pooling=False;");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into employee(empname) values ('"+txtEmpName.Text+"')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_dbDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employee_dbDataSet.employee);

        }
    }
}
