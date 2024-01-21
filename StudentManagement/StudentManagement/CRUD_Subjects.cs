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
    public partial class CRUD_Subjects : Form
    {
        public CRUD_Subjects()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            dgvSubject.DataSource = new SubjectDAO().GetListSubject();
            dgvSubject.Columns["Results"].Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Code = txtSubjectCode.Text.Trim();
            string Name = txtSubjectName.Text.Trim();
            int Slot = Convert.ToInt32(nmSlot.Value);
            SubjectDAO subjectDAO = new SubjectDAO();
            var existSubject = subjectDAO.CheckSubjectExists(Code);
            if (existSubject != null)
            {
                MessageBox.Show("Môn học đã tồn tại");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("Thêm môn học với\n Mã môn: {0}\n Tên môn: {1}\n Số tiết: {2}", Code, Name, Slot), "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    subjectDAO.AddSubject(Code, Name, Slot);
                    loadData();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Code = txtSubjectCode.Text.Trim();
            string Name = txtSubjectName.Text.Trim();
            int Slot = Convert.ToInt32(nmSlot.Value);
            SubjectDAO subjectDAO = new SubjectDAO();
            ResultDAO resultDAO = new ResultDAO();
            DialogResult dialogResult = MessageBox.Show(string.Format("Xóa môn học với\n Mã môn: {0}\n Tên môn: {1}\n Số tiết: {2}", Code, Name, Slot), "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               // resultDAO.DeleteResultBySubjectCode(Code);
                subjectDAO.DeleteSubject(Code);
                loadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Code = txtSubjectCode.Text.Trim();
            string Name = txtSubjectName.Text.Trim();
            int Slot = Convert.ToInt32(nmSlot.Value);
            SubjectDAO subjectDAO = new SubjectDAO();
            ResultDAO resultDAO = new ResultDAO();
            var existSubject = subjectDAO.CheckSubjectExists(Code);
            if (existSubject != null)
            {
                MessageBox.Show("Môn học đã tồn tại");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("Sửa môn học thành\n Mã môn: {0}\n Tên môn: {1}\n Số tiết: {2}", Code, Name, Slot), "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                 //   resultDAO.UpdateResultBySubjectCode(Code);
                    subjectDAO.AddSubject(Code, Name, Slot);
                    loadData();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSubjectCode.Text = dgvSubject.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtSubjectName.Text = dgvSubject.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            nmSlot.Value = Convert.ToInt32(dgvSubject.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
        }


    }
}
