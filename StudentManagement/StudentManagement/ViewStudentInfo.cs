using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.DAO;
using StudentManagement.Models;

namespace StudentManagement
{
    public partial class ViewStudentInfo : Form
    {
        BindingSource studentList = new BindingSource();
        public ViewStudentInfo()
        {
            InitializeComponent();
            loadMajorCode();
        }
        void loadMajorCode()
        {
            cbMajorCode.DataSource = new MajorDAO().GetListMajor();
            cbMajorCode.DisplayMember = "MajorCode";
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            string majorCode = cbMajorCode.Text;
            if (majorCode == "StudentManagement.Models.Major")
            {
                majorCode = "MA1";
            }
            dgvInfo.DataSource = new StudentDAO().GetListStudentByMajorCode(majorCode);
        }
        private void cbMajorCode_TextChanged(object sender, EventArgs e)
        {
            string majorCode = cbMajorCode.Text;
            if(majorCode == "StudentManagement.Models.Major")
            {
                majorCode = "MA1";
            }
            txtMajorName.Text = new MajorDAO().GetMajorNameByCode(majorCode).MajorName;
        }
    }
}
