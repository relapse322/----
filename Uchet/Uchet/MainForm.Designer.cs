namespace Uchet
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label opisanieLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.courseDataSet = new Uchet.CourseDataSet();
            this.instituteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instituteTableAdapter = new Uchet.CourseDataSetTableAdapters.InstituteTableAdapter();
            this.tableAdapterManager = new Uchet.CourseDataSetTableAdapters.TableAdapterManager();
            this.cursStudTableAdapter = new Uchet.CourseDataSetTableAdapters.CursStudTableAdapter();
            this.instituteListBox = new System.Windows.Forms.ListBox();
            this.cursStudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursStudDataGridView = new System.Windows.Forms.DataGridView();
            this.fKCursStudInstituteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opisanieLabel3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_filee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Institute_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            opisanieLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursStudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursStudDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCursStudInstituteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // opisanieLabel2
            // 
            opisanieLabel2.AutoSize = true;
            opisanieLabel2.Location = new System.Drawing.Point(281, 318);
            opisanieLabel2.Name = "opisanieLabel2";
            opisanieLabel2.Size = new System.Drawing.Size(51, 13);
            opisanieLabel2.TabIndex = 4;
            opisanieLabel2.Text = "Opisanie:";
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "CourseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instituteBindingSource
            // 
            this.instituteBindingSource.DataMember = "Institute";
            this.instituteBindingSource.DataSource = this.courseDataSet;
            // 
            // instituteTableAdapter
            // 
            this.instituteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursStudTableAdapter = this.cursStudTableAdapter;
            this.tableAdapterManager.InstituteTableAdapter = this.instituteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Uchet.CourseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cursStudTableAdapter
            // 
            this.cursStudTableAdapter.ClearBeforeFill = true;
            // 
            // instituteListBox
            // 
            this.instituteListBox.DataSource = this.instituteBindingSource;
            this.instituteListBox.DisplayMember = "Name";
            this.instituteListBox.FormattingEnabled = true;
            this.instituteListBox.Location = new System.Drawing.Point(24, 65);
            this.instituteListBox.Name = "instituteListBox";
            this.instituteListBox.Size = new System.Drawing.Size(205, 277);
            this.instituteListBox.TabIndex = 1;
            this.instituteListBox.ValueMember = "id";
            // 
            // cursStudBindingSource
            // 
            this.cursStudBindingSource.DataMember = "FK_CursStud_Institute";
            this.cursStudBindingSource.DataSource = this.instituteBindingSource;
            // 
            // cursStudDataGridView
            // 
            this.cursStudDataGridView.AllowUserToAddRows = false;
            this.cursStudDataGridView.AutoGenerateColumns = false;
            this.cursStudDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursStudDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Predmet,
            this.Grup,
            this.Spec,
            this.Name_filee,
            this.Institute_id,
            this.ocenki,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.Filee});
            this.cursStudDataGridView.DataSource = this.fKCursStudInstituteBindingSource;
            this.cursStudDataGridView.Location = new System.Drawing.Point(235, 65);
            this.cursStudDataGridView.Name = "cursStudDataGridView";
            this.cursStudDataGridView.ReadOnly = true;
            this.cursStudDataGridView.Size = new System.Drawing.Size(645, 236);
            this.cursStudDataGridView.TabIndex = 1;
            this.cursStudDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cursStudDataGridView_CellContentClick);
            // 
            // fKCursStudInstituteBindingSource
            // 
            this.fKCursStudInstituteBindingSource.DataMember = "FK_CursStud_Institute";
            this.fKCursStudInstituteBindingSource.DataSource = this.instituteBindingSource;
            // 
            // opisanieLabel3
            // 
            this.opisanieLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKCursStudInstituteBindingSource, "Opisanie", true));
            this.opisanieLabel3.Location = new System.Drawing.Point(338, 318);
            this.opisanieLabel3.Name = "opisanieLabel3";
            this.opisanieLabel3.Size = new System.Drawing.Size(100, 23);
            this.opisanieLabel3.TabIndex = 5;
            this.opisanieLabel3.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Просмотр/\r\nРедактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(799, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(105, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fKCursStudInstituteBindingSource;
            this.comboBox1.DisplayMember = "Data";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(606, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(520, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(158, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Visible = false;
            // 
            // Grup
            // 
            this.Grup.DataPropertyName = "Grup";
            this.Grup.HeaderText = "Grup";
            this.Grup.Name = "Grup";
            this.Grup.ReadOnly = true;
            this.Grup.Visible = false;
            // 
            // Spec
            // 
            this.Spec.DataPropertyName = "Spec";
            this.Spec.HeaderText = "Spec";
            this.Spec.Name = "Spec";
            this.Spec.ReadOnly = true;
            this.Spec.Visible = false;
            // 
            // Name_filee
            // 
            this.Name_filee.DataPropertyName = "Name_filee";
            this.Name_filee.HeaderText = "Name_filee";
            this.Name_filee.Name = "Name_filee";
            this.Name_filee.ReadOnly = true;
            this.Name_filee.Visible = false;
            // 
            // Institute_id
            // 
            this.Institute_id.DataPropertyName = "Institute_id";
            this.Institute_id.HeaderText = "Institute_id";
            this.Institute_id.Name = "Institute_id";
            this.Institute_id.ReadOnly = true;
            this.Institute_id.Visible = false;
            // 
            // ocenki
            // 
            this.ocenki.DataPropertyName = "ocenki";
            this.ocenki.HeaderText = "ocenki";
            this.ocenki.Name = "ocenki";
            this.ocenki.ReadOnly = true;
            this.ocenki.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tema";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тема работы";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rucovod";
            this.dataGridViewTextBoxColumn4.HeaderText = "Руководитель";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NameStud";
            this.dataGridViewTextBoxColumn5.HeaderText = "Студент";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата сдачи";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Curs";
            this.dataGridViewTextBoxColumn8.HeaderText = "Курс";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Filee
            // 
            this.Filee.DataPropertyName = "Filee";
            this.Filee.HeaderText = "Filee";
            this.Filee.Name = "Filee";
            this.Filee.ReadOnly = true;
            this.Filee.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 427);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(opisanieLabel2);
            this.Controls.Add(this.opisanieLabel3);
            this.Controls.Add(this.cursStudDataGridView);
            this.Controls.Add(this.instituteListBox);
            this.Name = "MainForm";
            this.Text = "Учёт курсовых работ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursStudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursStudDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCursStudInstituteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource instituteBindingSource;
        private CourseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cursStudBindingSource;
        private System.Windows.Forms.BindingSource fKCursStudInstituteBindingSource;
        private System.Windows.Forms.Label opisanieLabel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView cursStudDataGridView;
        public CourseDataSetTableAdapters.CursStudTableAdapter cursStudTableAdapter;
        public CourseDataSet courseDataSet;
        public System.Windows.Forms.ListBox instituteListBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public CourseDataSetTableAdapters.InstituteTableAdapter instituteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_filee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Institute_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenki;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filee;
    }
}

