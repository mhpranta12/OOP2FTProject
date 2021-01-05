using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_user
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_dataDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_dataDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.course_dataDataSet1.Table);
            // TODO: This line of code loads data into the 'course_dataDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.course_dataDataSet.Course);

        }

        private void courseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
