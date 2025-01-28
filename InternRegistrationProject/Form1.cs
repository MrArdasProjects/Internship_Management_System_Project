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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void AddInternPageButton_Click(object sender, EventArgs e)
        {
            Intern_Adding_Page intern = new Intern_Adding_Page();
            this.Hide();
            intern.Show();
            
        }

        private void addDepartmentPageButton_Click(object sender, EventArgs e)
        {
            Add_Department department = new Add_Department();
            this.Hide();
            department.Show();
        }

        private void NoteAddingPageButton_Click(object sender, EventArgs e)
        {
            Note_Adding note = new Note_Adding();
            this.Hide();
            note.Show();

        }

        private void listResultPageButton_Click(object sender, EventArgs e)
        {
            List_Result result = new List_Result();
            this.Hide();
            result.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
