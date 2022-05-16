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
    public partial class InsertForm : Form
    {
        public static byte[] content;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.CourseConnectionString);
        SqlCommand cmd;
        MainForm mainForm;
        public InsertForm(MainForm mn)
        {
            InitializeComponent();
            this.mainForm = mn;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            if (textBox10.Text == String.Empty)
            {
                cmd = new SqlCommand("insert into CursStud(Tema,Opisanie,Rucovod, NameStud, Data, Predmet, Curs, ocenki, Grup, Spec,institute_id)" +
                 " VALUES('" + textBox1.Text + "','" + textBox11.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Value + "'," +
                 "'" + textBox8.Text + "','" + textBox5.Text + "','" + textBox9.Text + "','" + textBox4.Text + "','" + textBox2.Text + "'," +
                 "'" + mainForm.instituteListBox.SelectedValue + "')", con);
            }
            else
            {
                cmd = new SqlCommand("insert into CursStud(Tema,Opisanie,Rucovod, NameStud, Data, Predmet, Curs, ocenki, Grup, Spec,institute_id,Filee,Name_filee)" +
                    " VALUES('" + textBox1.Text + "','" + textBox11.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Value + "'," +
                    "'" + textBox8.Text + "','" + textBox5.Text + "','" + textBox9.Text + "','" + textBox4.Text + "','" + textBox2.Text + "'," +
                    "'" + mainForm.instituteListBox.SelectedValue + "', @pdf, '" + textBox10.Text + "')", con);
                cmd.Parameters.AddWithValue("@pdf", content);
            }
            cmd.ExecuteNonQuery();
            con.Close();
            mainForm.cursStudTableAdapter.Fill(mainForm.courseDataSet.CursStud);
            MessageBox.Show("Данные добавлены");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf",ValidateNames = true})
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string filename = dlg.FileName;
                    UploadFile(filename);
                    textBox10.Text = dlg.FileName;
                }

            }
        }
        private void UploadFile (string file)
        {
            FileStream fstearm = File.OpenRead(file);
            content = new byte[fstearm.Length]; 
            fstearm.Read(content, 0, (int)fstearm.Length);
            fstearm.Close();

        }
    }
}
