using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Uchet
{
    public partial class AddInstitute : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.CourseConnectionString);
        SqlCommand cmd;
        MainForm mainForm;
        public AddInstitute(MainForm mn)
        {
            InitializeComponent();
            this.mainForm = mn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Institute (Name) VALUES ('" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            mainForm.instituteTableAdapter.Fill(mainForm.courseDataSet.Institute);
            MessageBox.Show("Данные добавлены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
