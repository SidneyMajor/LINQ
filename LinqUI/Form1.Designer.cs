namespace LinqUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxTodosAlunos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericUpDownDisciplinasFeitas = new System.Windows.Forms.NumericUpDown();
            this.ButtonUpDate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ListBoxAlunosFiltrados = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDisciplinasFeitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Totos os Alunos";
            // 
            // ComboBoxTodosAlunos
            // 
            this.ComboBoxTodosAlunos.FormattingEnabled = true;
            this.ComboBoxTodosAlunos.Location = new System.Drawing.Point(55, 87);
            this.ComboBoxTodosAlunos.Name = "ComboBoxTodosAlunos";
            this.ComboBoxTodosAlunos.Size = new System.Drawing.Size(334, 24);
            this.ComboBoxTodosAlunos.TabIndex = 1;
            this.ComboBoxTodosAlunos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTodosAlunos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Disciplinas Feitas";
            // 
            // NumericUpDownDisciplinasFeitas
            // 
            this.NumericUpDownDisciplinasFeitas.Location = new System.Drawing.Point(176, 150);
            this.NumericUpDownDisciplinasFeitas.Name = "NumericUpDownDisciplinasFeitas";
            this.NumericUpDownDisciplinasFeitas.Size = new System.Drawing.Size(213, 22);
            this.NumericUpDownDisciplinasFeitas.TabIndex = 3;
            // 
            // ButtonUpDate
            // 
            this.ButtonUpDate.Location = new System.Drawing.Point(55, 261);
            this.ButtonUpDate.Name = "ButtonUpDate";
            this.ButtonUpDate.Size = new System.Drawing.Size(164, 48);
            this.ButtonUpDate.TabIndex = 4;
            this.ButtonUpDate.Text = "UPDATE";
            this.ButtonUpDate.UseVisualStyleBackColor = true;
            this.ButtonUpDate.Click += new System.EventHandler(this.ButtonUpDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alunos Filtrados";
            // 
            // ListBoxAlunosFiltrados
            // 
            this.ListBoxAlunosFiltrados.FormattingEnabled = true;
            this.ListBoxAlunosFiltrados.ItemHeight = 16;
            this.ListBoxAlunosFiltrados.Location = new System.Drawing.Point(449, 66);
            this.ListBoxAlunosFiltrados.Name = "ListBoxAlunosFiltrados";
            this.ListBoxAlunosFiltrados.Size = new System.Drawing.Size(275, 260);
            this.ListBoxAlunosFiltrados.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 356);
            this.Controls.Add(this.ListBoxAlunosFiltrados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonUpDate);
            this.Controls.Add(this.NumericUpDownDisciplinasFeitas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxTodosAlunos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDisciplinasFeitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxTodosAlunos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericUpDownDisciplinasFeitas;
        private System.Windows.Forms.Button ButtonUpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListBoxAlunosFiltrados;
    }
}

