using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Employee> employees = new List<Employee>();
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();

        }

        private void UpdateBinding()
        {
            EmployeeFoundList.DataSource = employees;
            EmployeeFoundList.DisplayMember = "FullInfo";

        }
        
        private void SearchButton_Click(object sender, EventArgs e)
        {
           DataAccess db = new DataAccess();
           employees = db.GetEmployees(NameText.Text);

            UpdateBinding();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InsertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(IdInsText.Text, NameInsText.Text, GenderInsText.Text, 
                SalaryInsText.Text, CityInsText.Text );
        }
    }
}
