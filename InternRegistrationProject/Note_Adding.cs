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
    public partial class Note_Adding : Form
    {
        InternEvaluationDatabaseEntities1 db = new InternEvaluationDatabaseEntities1 ();
        public Note_Adding()
        {
            InitializeComponent();
            fillComboBox();
        }

        private void Note_Add_Button_Click(object sender, EventArgs e)
        {
            int exam1 = Convert.ToInt32(txtExam1.Text);
            int exam2 = Convert.ToInt32(txtExam2.Text);
            string selectedDept = deptComboBox.SelectedItem.ToString();
            double average = (exam1 * 0.40) + (exam2 * 0.60);
            long selectedInternId = (from x in db.InternInformation
                                    where x.PhoneNumber == txtPhone.Text
                                    select x.ID).FirstOrDefault();
            long selectedDeptID = (from x in db.Department
                                   where x.Name == selectedDept
                                   select x.ID).FirstOrDefault();
            Note newNote = new Note();
            newNote.DepartmentID = selectedDeptID;
            newNote.InternID = selectedInternId;
            newNote.OralExam = exam1;
            newNote.WrittenInterview = exam2;
            newNote.Average = Convert.ToInt32(average);
            newNote.Status = average > 60 ? "Pass" : "Fail";

            // Notu veritabanına ekle
            db.Note.Add(newNote);
            db.SaveChanges();
            MessageBox.Show($"Note added! Student {newNote.Status} from interview.");
            txtPhone.Text = String.Empty;
            txtExam1.Text = string.Empty;
            txtExam2.Text = string.Empty;
            deptComboBox.ResetText();
        }

        private void NotePage_Back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }
        private void fillComboBox()
        {


            var deptNames = (from x in db.Department
                             select x.Name).ToList();


            deptComboBox.DataSource = deptNames;
        }

    }
}
