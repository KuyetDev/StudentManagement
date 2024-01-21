using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class SearchByMark : Form
    {
        public SearchByMark()
        {
            InitializeComponent();
            cbStudentCode.DataSource = new StudentDAO().GetAllStudents();
            cbStudentCode.DisplayMember = "StudentCode";
            
        }

        private void cbStudentCode_TextChanged(object sender, EventArgs e)
        {
            string id = cbStudentCode.Text;
            if (id == "StudentManagement.Models.Student")
            {
                id = "1";
            }
            txtStudentName.Text = new StudentDAO().GetStudentByID(Convert.ToInt32(id)).StudentName;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int StudentCode = Convert.ToInt32(cbStudentCode.Text);
            dgvSearch.DataSource = new ResultDAO().GetMarkByStudentCode(StudentCode);
        }
    }
}
