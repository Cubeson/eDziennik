namespace edziennik
{
    partial class AddStudentTaskUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.sepPanel = new System.Windows.Forms.Panel();
            this.comboBoxTaskType = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodawanie zadań";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(204)))), ((int)(((byte)(189)))));
            this.buttonAddTask.FlatAppearance.BorderSize = 0;
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTask.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddTask.Location = new System.Drawing.Point(346, 390);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(269, 68);
            this.buttonAddTask.TabIndex = 1;
            this.buttonAddTask.Text = "Dodaj zadanie";
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.Location = new System.Drawing.Point(346, 216);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(346, 73);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 25);
            this.comboBoxSubject.TabIndex = 3;
            this.comboBoxSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSubject_KeyPress);
            // 
            // sepPanel
            // 
            this.sepPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sepPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sepPanel.Location = new System.Drawing.Point(10, 40);
            this.sepPanel.Name = "sepPanel";
            this.sepPanel.Size = new System.Drawing.Size(940, 2);
            this.sepPanel.TabIndex = 4;
            // 
            // comboBoxTaskType
            // 
            this.comboBoxTaskType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTaskType.FormattingEnabled = true;
            this.comboBoxTaskType.Location = new System.Drawing.Point(473, 73);
            this.comboBoxTaskType.Name = "comboBoxTaskType";
            this.comboBoxTaskType.Size = new System.Drawing.Size(121, 25);
            this.comboBoxTaskType.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(346, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 50);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Przedmiot\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rodzaj zadania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nazwa zadania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data oddania";
            // 
            // AddStudentTaskUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxTaskType);
            this.Controls.Add(this.sepPanel);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentTaskUC";
            this.Size = new System.Drawing.Size(960, 475);
            this.Load += new System.EventHandler(this.AddStudentTaskUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonAddTask;
        private MonthCalendar monthCalendar1;
        private ComboBox comboBoxSubject;
        private Panel sepPanel;
        private ComboBox comboBoxTaskType;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
