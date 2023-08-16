namespace Emergencia_2._00
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxmatricula = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxcarrera = new System.Windows.Forms.TextBox();
            this.lblCarrea = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAnswer = new System.Windows.Forms.ComboBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage1.Controls.Add(this.textBoxmatricula);
            this.tabPage1.Controls.Add(this.textBoxnombre);
            this.tabPage1.Controls.Add(this.textBoxcarrera);
            this.tabPage1.Controls.Add(this.lblCarrea);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.lblMatricula);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.dtgv1);
            this.tabPage1.Controls.Add(this.btnSave1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Formulario";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tabPage2.Controls.Add(this.cmbAnswer);
            this.tabPage2.Controls.Add(this.lblQuestion);
            this.tabPage2.Controls.Add(this.btnNext);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preguntas";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBoxmatricula
            // 
            this.textBoxmatricula.Location = new System.Drawing.Point(107, 45);
            this.textBoxmatricula.Name = "textBoxmatricula";
            this.textBoxmatricula.Size = new System.Drawing.Size(100, 20);
            this.textBoxmatricula.TabIndex = 40;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(107, 11);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxnombre.TabIndex = 39;
            // 
            // textBoxcarrera
            // 
            this.textBoxcarrera.Location = new System.Drawing.Point(358, 11);
            this.textBoxcarrera.Name = "textBoxcarrera";
            this.textBoxcarrera.Size = new System.Drawing.Size(100, 20);
            this.textBoxcarrera.TabIndex = 37;
            // 
            // lblCarrea
            // 
            this.lblCarrea.AutoSize = true;
            this.lblCarrea.Location = new System.Drawing.Point(289, 11);
            this.lblCarrea.Name = "lblCarrea";
            this.lblCarrea.Size = new System.Drawing.Size(41, 13);
            this.lblCarrea.TabIndex = 35;
            this.lblCarrea.Text = "Carrera";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(148, 109);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(67, 109);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(8, 45);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 31;
            this.lblMatricula.Text = "Matricula";
            this.lblMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgv1
            // 
            this.dtgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Matricula,
            this.Carrera});
            this.dtgv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv1.Location = new System.Drawing.Point(3, 173);
            this.dtgv1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.RowHeadersWidth = 51;
            this.dtgv1.RowTemplate.Height = 24;
            this.dtgv1.Size = new System.Drawing.Size(786, 151);
            this.dtgv1.TabIndex = 29;
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(11, 109);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(50, 23);
            this.btnSave1.TabIndex = 28;
            this.btnSave1.Text = "✔";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // ID
            // 
            this.ID.FillWeight = 48.12834F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 112.9679F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.FillWeight = 112.9679F;
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 6;
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.FillWeight = 112.9679F;
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 6;
            this.Carrera.Name = "Carrera";
            // 
            // cmbAnswer
            // 
            this.cmbAnswer.BackColor = System.Drawing.Color.PaleGreen;
            this.cmbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnswer.FormattingEnabled = true;
            this.cmbAnswer.Location = new System.Drawing.Point(523, 153);
            this.cmbAnswer.Name = "cmbAnswer";
            this.cmbAnswer.Size = new System.Drawing.Size(173, 24);
            this.cmbAnswer.TabIndex = 8;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblQuestion.Location = new System.Drawing.Point(268, 157);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(249, 28);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Question1";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightGreen;
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(96, 142);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(166, 43);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Emergencia";
            this.Load += new System.EventHandler(this.Emergencia);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxmatricula;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxcarrera;
        private System.Windows.Forms.Label lblCarrea;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.ComboBox cmbAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
    }
}

