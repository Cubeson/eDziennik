namespace edziennik
{
    partial class MainUC
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ToolbarPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.tmpUCButton = new System.Windows.Forms.Button();
            this.MarksUCButton = new System.Windows.Forms.Button();
            this.AddStudentTaskUCButton = new System.Windows.Forms.Button();
            this.ToolbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.Location = new System.Drawing.Point(20, 73);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(960, 475);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // ToolbarPanel
            // 
            this.ToolbarPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToolbarPanel.Controls.Add(this.LogoutButton);
            this.ToolbarPanel.Controls.Add(this.tmpUCButton);
            this.ToolbarPanel.Controls.Add(this.MarksUCButton);
            this.ToolbarPanel.Controls.Add(this.AddStudentTaskUCButton);
            this.ToolbarPanel.Location = new System.Drawing.Point(20, 0);
            this.ToolbarPanel.Margin = new System.Windows.Forms.Padding(20);
            this.ToolbarPanel.Name = "ToolbarPanel";
            this.ToolbarPanel.Size = new System.Drawing.Size(960, 65);
            this.ToolbarPanel.TabIndex = 2;
            this.ToolbarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ToolbarPanel_Paint);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Location = new System.Drawing.Point(860, 5);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(100, 60);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Wyloguj się";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // tmpUCButton
            // 
            this.tmpUCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(204)))), ((int)(((byte)(189)))));
            this.tmpUCButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tmpUCButton.FlatAppearance.BorderSize = 0;
            this.tmpUCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tmpUCButton.Location = new System.Drawing.Point(215, 5);
            this.tmpUCButton.Margin = new System.Windows.Forms.Padding(0);
            this.tmpUCButton.Name = "tmpUCButton";
            this.tmpUCButton.Size = new System.Drawing.Size(100, 60);
            this.tmpUCButton.TabIndex = 2;
            this.tmpUCButton.Text = "Obecności";
            this.tmpUCButton.UseVisualStyleBackColor = false;
            this.tmpUCButton.Click += new System.EventHandler(this.tmpUCButton_Click);
            // 
            // MarksUCButton
            // 
            this.MarksUCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(204)))), ((int)(((byte)(189)))));
            this.MarksUCButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MarksUCButton.FlatAppearance.BorderSize = 0;
            this.MarksUCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarksUCButton.Location = new System.Drawing.Point(110, 5);
            this.MarksUCButton.Margin = new System.Windows.Forms.Padding(0);
            this.MarksUCButton.Name = "MarksUCButton";
            this.MarksUCButton.Size = new System.Drawing.Size(100, 60);
            this.MarksUCButton.TabIndex = 1;
            this.MarksUCButton.Text = "Wstawianie Ocen";
            this.MarksUCButton.UseVisualStyleBackColor = false;
            this.MarksUCButton.Click += new System.EventHandler(this.MarksUCButton_Click);
            // 
            // AddStudentTaskUCButton
            // 
            this.AddStudentTaskUCButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddStudentTaskUCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(204)))), ((int)(((byte)(189)))));
            this.AddStudentTaskUCButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudentTaskUCButton.FlatAppearance.BorderSize = 0;
            this.AddStudentTaskUCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentTaskUCButton.Location = new System.Drawing.Point(5, 5);
            this.AddStudentTaskUCButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddStudentTaskUCButton.Name = "AddStudentTaskUCButton";
            this.AddStudentTaskUCButton.Size = new System.Drawing.Size(100, 60);
            this.AddStudentTaskUCButton.TabIndex = 0;
            this.AddStudentTaskUCButton.Text = "Dodawanie zadań";
            this.AddStudentTaskUCButton.UseVisualStyleBackColor = false;
            this.AddStudentTaskUCButton.Click += new System.EventHandler(this.AddStudentTaskUCButton_Click);
            // 
            // MainUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ToolbarPanel);
            this.Name = "MainUC";
            this.Size = new System.Drawing.Size(1000, 565);
            this.ToolbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Panel ToolbarPanel;
        private Button tmpUCButton;
        private Button MarksUCButton;
        private Button AddStudentTaskUCButton;
        private Button LogoutButton;
    }
}
