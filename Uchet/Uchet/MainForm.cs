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
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.CourseConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        public MainForm()
        {
            InitializeComponent();
        }

        private void instituteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instituteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();

            this.cursStudTableAdapter.Fill(this.courseDataSet.CursStud);
            this.instituteTableAdapter.Fill(this.courseDataSet.Institute);
        }
        public void update()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Файл";
            btn.Name = "1";
            btn.Text = "Скачать pdf";
            btn.UseColumnTextForButtonValue = true;
            cursStudDataGridView.Columns.Add(btn);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Redact temp = new Redact(this);
            cursStudDataGridView.CurrentRow.Selected = true;
            temp.textBox1.Text = this.cursStudDataGridView.CurrentRow.Cells[7].Value.ToString();
            temp.textBox2.Text = this.cursStudDataGridView.CurrentRow.Cells[3].Value.ToString();
            temp.dateTimePicker1.Value = (DateTime)this.cursStudDataGridView.CurrentRow.Cells[10].Value;
            temp.textBox4.Text = this.cursStudDataGridView.CurrentRow.Cells[2].Value.ToString();
            temp.textBox5.Text = this.cursStudDataGridView.CurrentRow.Cells[11].Value.ToString();
            temp.textBox6.Text = this.cursStudDataGridView.CurrentRow.Cells[9].Value.ToString();
            temp.textBox7.Text = this.cursStudDataGridView.CurrentRow.Cells[8].Value.ToString();
            temp.textBox8.Text = this.cursStudDataGridView.CurrentRow.Cells[1].Value.ToString();
            temp.textBox9.Text = this.cursStudDataGridView.CurrentRow.Cells[6].Value.ToString();
            temp.textBox10.Text = this.cursStudDataGridView.CurrentRow.Cells[4].Value.ToString();
            temp.textBox11.Text = this.opisanieLabel3.Text.ToString();
            temp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertForm yemp = new InsertForm(this);
            yemp.ShowDialog();
        }

        private void cursStudDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cursStudDataGridView.Columns[e.ColumnIndex].Name == "1")
            {
                if (this.cursStudDataGridView.CurrentRow.Cells[12].Value.ToString() == "")
                {
                    MessageBox.Show("Файл отсуствует");
                }
                else
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            string filename = sfd.FileName;
                            DownloadFile(filename);
                        }
                        else
                        {
                            return;
                        }

                    }

                }
            }
        }
        public void DownloadFile(string file)
        {
            con.Open();
            bool em = false;
            using (cmd = new SqlCommand("Select Filee From CursStud where ID = '" + cursStudDataGridView.CurrentRow.Cells[0].Value + "'", con))
            {
                    using (reader = cmd.ExecuteReader(CommandBehavior.Default))
                    {
                        {
                            if (reader.Read())
                            {
                                em = true;
                                byte[] filedata = (byte[])reader.GetValue(0);
                                using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.ReadWrite))
                                {
                                    using (BinaryWriter bw = new BinaryWriter(fs))
                                    {
                                        bw.Write(filedata);
                                        bw.Close();
                                    }
                                }
                                MessageBox.Show("Файл сохранён");
                            }
                            reader.Close();
                            con.Close();
                        }
                    }
                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select*from CursStud where Tema like '" + textBox1.Text+"%' and Rucovod like '" 
                + textBox1.Text+"%' and NameStud like '" + textBox1.Text+"%'", con);
  
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cursStudDataGridView.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить данные?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("delete from CursStud where id = '" + cursStudDataGridView.CurrentRow.Cells[0].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            cursStudTableAdapter.Fill(courseDataSet.CursStud);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddInstitute tmp = new AddInstitute(this);
            tmp.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Вы действительно хотите удалить данные?",
               "Сообщение",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.None,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("delete from CursStud where Institute_id = '" + this.instituteListBox.SelectedValue + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            con.Open();
            cmd = new SqlCommand("delete from Institute where id = '" + this.instituteListBox.SelectedValue + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            cursStudTableAdapter.Fill(courseDataSet.CursStud);
            instituteTableAdapter.Fill(courseDataSet.Institute);
        }
    }
}
 



