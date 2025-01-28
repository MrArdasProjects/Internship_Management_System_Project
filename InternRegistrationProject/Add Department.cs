using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternRegistrationProject
{
    public partial class Add_Department : Form
    {
        InternEvaluationDatabaseEntities1 db = new InternEvaluationDatabaseEntities1 ();



        public Add_Department()
        {
            InitializeComponent();
        }

        private void Department_Add_Click(object sender, EventArgs e)
        {
            Department dept= new Department ();
            dept.Name=txtDept.Text;
            db.Department.Add(dept);
            db.SaveChanges();
            MessageBox.Show("Department added.");
            deptData();
            txtDept.Text = string.Empty;
            

        }

        private void Department_Back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1 ();
            this.Close();
            form.Show();
        }
        private void deptData()
        {
            deptDataGrid.DataSource = db.Department.ToList();
        }

        private void Add_Department_Load(object sender, EventArgs e)
        {
            deptData();
        }

        private void deptDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
