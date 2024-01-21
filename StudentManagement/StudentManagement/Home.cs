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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Home_Load(object sender, EventArgs e)
        {
      
        }

        private void stripStudent_Click(object sender, EventArgs e)
        {
            ViewStudentInfo v = new ViewStudentInfo();
            v.ShowDialog();
        }

        private void stripViewMark_Click(object sender, EventArgs e)
        {
            SearchByMark s = new SearchByMark();
            s.ShowDialog();
        }

        private void stripInsertMark_Click(object sender, EventArgs e)
        {
            InserMark i = new InserMark();
            i.ShowDialog();
        }
    }
}
