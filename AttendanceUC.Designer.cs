namespace edziennik
{
    partial class AttendanceUC
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.sepPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.checkBoxSpecificDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxWasPresent = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.present = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSubjectGrid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sepPanel
            // 
            this.sepPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sepPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sepPanel.Location = new System.Drawing.Point(10, 40);
            this.sepPanel.Name = "sepPanel";
            this.sepPanel.Size = new System.Drawing.Size(940, 2);
            this.sepPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Obecności";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(10, 113);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(252, 25);
            this.comboBoxSubject.TabIndex = 8;
            this.comboBoxSubject.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSubject_SelectionChangeCommitted);
            this.comboBoxSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSubject_KeyPress);
            // 
            // checkBoxSpecificDate
            // 
            this.checkBoxSpecificDate.AutoSize = true;
            this.checkBoxSpecificDate.Location = new System.Drawing.Point(10, 209);
            this.checkBoxSpecificDate.Name = "checkBoxSpecificDate";
            this.checkBoxSpecificDate.Size = new System.Drawing.Size(168, 21);
            this.checkBoxSpecificDate.TabIndex = 9;
            this.checkBoxSpecificDate.Text = "Wybrać konkretną datę?";
            this.checkBoxSpecificDate.UseVisualStyleBackColor = true;
            this.checkBoxSpecificDate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(10, 236);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 29);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.Value = new System.DateTime(2022, 6, 18, 0, 0, 0, 0);
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.DropDownWidth = 300;
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(10, 177);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(252, 25);
            this.comboBoxStudent.TabIndex = 12;
            this.comboBoxStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxStudent_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Przemiot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Student";
            // 
            // checkBoxWasPresent
            // 
            this.checkBoxWasPresent.AutoSize = true;
            this.checkBoxWasPresent.Location = new System.Drawing.Point(10, 271);
            this.checkBoxWasPresent.Name = "checkBoxWasPresent";
            this.checkBoxWasPresent.Size = new System.Drawing.Size(122, 21);
            this.checkBoxWasPresent.TabIndex = 15;
            this.checkBoxWasPresent.Text = "Jest/Był obecny?";
            this.checkBoxWasPresent.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(204)))), ((int)(((byte)(189)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(57, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 16;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(277, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 425);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dodawanie";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(285, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Przegląd";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.studentId,
            this.studentName,
            this.studentSurname,
            this.present});
            this.dataGridView.Location = new System.Drawing.Point(285, 144);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(665, 328);
            this.dataGridView.TabIndex = 22;
            // 
            // id
            // 
            this.id.HeaderText = "Id obecności";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // date
            // 
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // studentId
            // 
            this.studentId.HeaderText = "Id studenta";
            this.studentId.Name = "studentId";
            this.studentId.ReadOnly = true;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Imię studenta";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // studentSurname
            // 
            this.studentSurname.HeaderText = "Nazwisko studenta";
            this.studentSurname.Name = "studentSurname";
            this.studentSurname.ReadOnly = true;
            // 
            // present
            // 
            this.present.HeaderText = "Obecność";
            this.present.Name = "present";
            this.present.ReadOnly = true;
            // 
            // comboBoxSubjectGrid
            // 
            this.comboBoxSubjectGrid.FormattingEnabled = true;
            this.comboBoxSubjectGrid.Location = new System.Drawing.Point(285, 113);
            this.comboBoxSubjectGrid.Name = "comboBoxSubjectGrid";
            this.comboBoxSubjectGrid.Size = new System.Drawing.Size(252, 25);
            this.comboBoxSubjectGrid.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Przemiot";
            // 
            // AttendanceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSubjectGrid);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxWasPresent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.checkBoxSpecificDate);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.sepPanel);
            this.Controls.Add(this.label1);
            this.Name = "AttendanceUC";
            this.Size = new System.Drawing.Size(960, 475);
            this.Load += new System.EventHandler(this.AttendanceUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel sepPanel;
        private Label label1;
        private ComboBox comboBoxSubject;
        private CheckBox checkBoxSpecificDate;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxStudent;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxWasPresent;
        private Button button1;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView;
        private ComboBox comboBoxSubjectGrid;
        private Label label6;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn studentId;
        private DataGridViewTextBoxColumn studentName;
        private DataGridViewTextBoxColumn studentSurname;
        private DataGridViewTextBoxColumn present;
    }
}
