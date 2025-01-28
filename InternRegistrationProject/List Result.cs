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
    public partial class List_Result : Form
    {

        InternEvaluationDatabaseEntities1 db = new InternEvaluationDatabaseEntities1 ();
        public List_Result()
        {
            InitializeComponent();
            
        }

        private void ListResult_Back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }

        private void List_Result_Load(object sender, EventArgs e)
        {
        resultData();
            allRowButtons();
        }
        private void resultData()
        {
            var result = db.Note.Select(x => new
            {
                Id = x.ID,
                FirstName = x.InternInformation.FirstName,
                LastName = x.InternInformation.LastName,
                DepartmentName = x.Department.Name,
                PhoneNumber = x.InternInformation.PhoneNumber,
                Email = x.InternInformation.Email,
                Exam1 = x.OralExam,
                Exam2 = x.WrittenInterview,
                Average = x.Average,
                State = x.Status
            });
            resultGrid.DataSource = result.ToList();

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
            resultGrid.Columns.Add(deleteButtonColumn);
        }
        private void deleteNote(int id)
        {
            Note note= db.Note.Find(id);
            db.Note.Remove(note);
            db.SaveChanges();
            MessageBox.Show("Note Deleted.");

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (passedRadio.Checked)
            {
                if (!txtSearch.Text.Equals(""))
                {
                    var result = db.Note.Where(x => x.Status == "Pass" & (x.InternInformation.FirstName == txtSearch.Text || x.InternInformation.LastName == txtSearch.Text)).Select(x => new
                    {
                        ID = x.ID,
                        FirstName = x.InternInformation.FirstName,
                        LastName = x.InternInformation.LastName,
                        DepartmentName = x.Department.Name,
                        PhoneNumber = x.InternInformation.PhoneNumber,
                        Email = x.InternInformation.Email,
                        Exam1 = x.OralExam,
                        Exam2 = x.WrittenInterview,
                        Average = x.Average,
                        State = x.Status


                    });
                    resultGrid.DataSource = result.ToList();


                }
                else
                {
                    var result = db.Note.Where(x => x.Status == "Pass").Select(x => new
                    {
                        ID = x.ID,
                        FirstName = x.InternInformation.FirstName,
                        LastName = x.InternInformation.LastName,
                        DepartmentName = x.Department.Name,
                        PhoneNumber = x.InternInformation.PhoneNumber,
                        Email = x.InternInformation.Email,
                        Exam1 = x.OralExam,
                        Exam2 = x.WrittenInterview,
                        Average = x.Average,
                        State = x.Status


                    });
                    resultGrid.DataSource = result.ToList();

                }
                passedRadio.Checked = false;


            }

            else if (failedRadio.Checked)
            {
                if (!txtSearch.Text.Equals(""))
                {
                    var result = db.Note.Where(x => x.Status == "Fail" & (x.InternInformation.FirstName == txtSearch.Text || x.InternInformation.LastName == txtSearch.Text)).Select(x => new
                    {
                        ID = x.ID,
                        FirstName = x.InternInformation.FirstName,
                        LastName = x.InternInformation.LastName,
                        DepartmentName = x.Department.Name,
                        PhoneNumber = x.InternInformation.PhoneNumber,
                        Email = x.InternInformation.Email,
                        Exam1 = x.OralExam,
                        Exam2 = x.WrittenInterview,
                        Average = x.Average,
                        State = x.Status


                    });
                    resultGrid.DataSource = result.ToList();


                }
                else
                {
                    var result = db.Note.Where(x => x.Status == "Fail").Select(x => new
                    {
                        ID = x.ID,
                        FirstName = x.InternInformation.FirstName,
                        LastName = x.InternInformation.LastName,
                        DepartmentName = x.Department.Name,
                        PhoneNumber = x.InternInformation.PhoneNumber,
                        Email = x.InternInformation.Email,
                        Exam1 = x.OralExam,
                        Exam2 = x.WrittenInterview,
                        Average = x.Average,
                        State = x.Status


                    });
                    resultGrid.DataSource = result.ToList();

                }
                failedRadio.Checked = false;
            }
            else
            {
                var result = db.Note.Where(x => x.InternInformation.FirstName == txtSearch.Text || x.InternInformation.LastName == txtSearch.Text).Select(x => new
                {
                    ID = x.ID,
                    FirstName = x.InternInformation.FirstName,
                    LastName = x.InternInformation.LastName,
                    DepartmentName = x.Department.Name,
                    PhoneNumber = x.InternInformation.PhoneNumber,
                    Email = x.InternInformation.Email,
                    Exam1 = x.OralExam,
                    Exam2 = x.WrittenInterview,
                    Average = x.Average,
                    State = x.Status


                });
                resultGrid.DataSource = result.ToList();

            }
        }

        private void resultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == resultGrid.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                // Silme işlemi
                if (MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(resultGrid.Rows[e.RowIndex].Cells["ID"].Value);

                    deleteNote(id);

                    resultData();
                }
            }

        }
    }
    }

