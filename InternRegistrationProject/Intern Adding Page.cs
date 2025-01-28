using System;
using System.Collections.Generic;
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
    public partial class Intern_Adding_Page : Form
    {
        InternEvaluationDatabaseEntities1 db = new InternEvaluationDatabaseEntities1();

        public Intern_Adding_Page()
        {
            InitializeComponent();
        }

        private void Intern_Back_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            this.Close();
            back.Show();


        }
        private void allRowButtons()
        {
            //Notes Update column

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Name = "DeleteButtonColumn";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Silme butonu sütununu DataGridView'e ekle
            internDataGrid.Columns.Add(deleteButtonColumn);
        }
        private void deleteIntern(int id)
        {
            InternInformation intern = db.InternInformation.Find(id);
            db.InternInformation.Remove(intern);
            db.SaveChanges();
            MessageBox.Show("Intern Deleted.");

        }

        private void Intern_Add_Button_Click(object sender, EventArgs e)
        {
            string selectedDept = departmentComboBox.SelectedItem.ToString();

            long selectedDeptID = (from x in db.Department
                                    where x.Name == selectedDept
                                    select x.ID).FirstOrDefault();

            InternInformation intern = new InternInformation();
            intern.FirstName = txtFirstName.Text;
            intern.LastName = txtLastName.Text;
            intern.Email = txtEmail.Text;
            intern.PhoneNumber = txtPhone.Text;
            intern.DepartmentID = selectedDeptID;
            db.InternInformation.Add(intern);
            db.SaveChanges();
            MessageBox.Show("Intern Added");

            txtFirstName.Text = string.Empty;
            txtLastName.Text=string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            departmentComboBox.ResetText();
            internData();

        }

        private void fillComboBox()
        {
            

            var deptNames = (from x in db.Department
                             select x.Name).ToList();


            departmentComboBox.DataSource = deptNames;
        }
        private void internData()
        {
            var query = from x in db.InternInformation
                        select new
                        {
                            x.ID,
                            x.FirstName,
                            x.LastName,
                            x.PhoneNumber,
                            x.Email,
                            x.Department.Name
                        };
            internDataGrid.DataSource = query.ToList();
        }

        private void Intern_Adding_Page_Load(object sender, EventArgs e)
        {
            fillComboBox();
            internData();
            allRowButtons();
        }

        private void internDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == internDataGrid.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                // Silme işlemi
                if (MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(internDataGrid.Rows[e.RowIndex].Cells["ID"].Value);

                    deleteIntern(id);

                    internData();
                }
            }
        }
    }
}
