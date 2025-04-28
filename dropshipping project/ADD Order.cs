using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dropshipping_project
{
    public partial class order_entry : Form
    {
        public order_entry()
        {
            InitializeComponent();
        }

        private void LoadEmployees()
        {
            using (var context = new BusinessDBEntities2()) // Replace YourDbContext with your real context class
            {
                var employees = context.Employees.ToList();

                employees.Insert(0, new Employee { employee_id = -1, name = "+ Add new employee..." });

                comboBoxEmployee.DataSource = null; // Clear any previous data
                comboBoxEmployee.Items.Clear();

                comboBoxEmployee.DataSource = employees;
                comboBoxEmployee.DisplayMember = "name";     // The property you want to show (maybe EmployeeName?)
                comboBoxEmployee.ValueMember = "employee_id"; // The ID of employee

                comboBoxEmployee.Items.Add("➕ Add new employee...");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void order_entry_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
               if (comboBoxEmployee.SelectedItem != null && 
                    comboBoxEmployee.SelectedItem.ToString() == "➕ Add new employee...")
               {
                   DialogResult result = MessageBox.Show(
                       "Do you want to add a new employee?", 
                       "Add Employee", 
                       MessageBoxButtons.YesNo, 
                       MessageBoxIcon.Question);
               
                   if (result == DialogResult.Yes)
                   {
                       Add_New_Employee addEmployeeForm = new Add_New_Employee();
                       addEmployeeForm.ShowDialog();
               
                       LoadEmployees();
                   }
               }
        }
    }
}
