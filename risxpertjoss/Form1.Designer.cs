namespace risxpertjoss
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxbien = new System.Windows.Forms.TextBox();
            this.textBoxanalista = new System.Windows.Forms.TextBox();
            this.textBoxdaño = new System.Windows.Forms.TextBox();
            this.textBoxries = new System.Windows.Forms.TextBox();
            this.lbDaño = new System.Windows.Forms.Label();
            this.lbRiesgo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblAnalista = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCaseID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCaseID2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvValores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtgvevaluacion = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtgvclasificacion = new System.Windows.Forms.DataGridView();
            this.ActivoF4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiesgoF4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERF4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassF4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fase3Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fase3Riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fase3Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarDeRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PdeRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuanDeRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvValores)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvevaluacion)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvclasificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(849, 344);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Seleted);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LimeGreen;
            this.tabPage1.Controls.Add(this.textBoxbien);
            this.tabPage1.Controls.Add(this.textBoxanalista);
            this.tabPage1.Controls.Add(this.textBoxdaño);
            this.tabPage1.Controls.Add(this.textBoxries);
            this.tabPage1.Controls.Add(this.lbDaño);
            this.tabPage1.Controls.Add(this.lbRiesgo);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.lblActive);
            this.tabPage1.Controls.Add(this.lblAnalista);
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.lblCaseID);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.dtgv1);
            this.tabPage1.Controls.Add(this.btnSave1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(841, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fase 1";
            // 
            // textBoxbien
            // 
            this.textBoxbien.Location = new System.Drawing.Point(107, 53);
            this.textBoxbien.Name = "textBoxbien";
            this.textBoxbien.Size = new System.Drawing.Size(100, 21);
            this.textBoxbien.TabIndex = 27;
            // 
            // textBoxanalista
            // 
            this.textBoxanalista.Location = new System.Drawing.Point(107, 19);
            this.textBoxanalista.Name = "textBoxanalista";
            this.textBoxanalista.Size = new System.Drawing.Size(100, 21);
            this.textBoxanalista.TabIndex = 26;
            // 
            // textBoxdaño
            // 
            this.textBoxdaño.Location = new System.Drawing.Point(358, 53);
            this.textBoxdaño.Name = "textBoxdaño";
            this.textBoxdaño.Size = new System.Drawing.Size(100, 21);
            this.textBoxdaño.TabIndex = 25;
            this.textBoxdaño.TextChanged += new System.EventHandler(this.textBoxdaño_TextChanged);
            // 
            // textBoxries
            // 
            this.textBoxries.Location = new System.Drawing.Point(358, 19);
            this.textBoxries.Name = "textBoxries";
            this.textBoxries.Size = new System.Drawing.Size(100, 21);
            this.textBoxries.TabIndex = 24;
            // 
            // lbDaño
            // 
            this.lbDaño.AutoSize = true;
            this.lbDaño.Location = new System.Drawing.Point(289, 53);
            this.lbDaño.Name = "lbDaño";
            this.lbDaño.Size = new System.Drawing.Size(41, 15);
            this.lbDaño.TabIndex = 23;
            this.lbDaño.Text = "Daño";
            // 
            // lbRiesgo
            // 
            this.lbRiesgo.AutoSize = true;
            this.lbRiesgo.Location = new System.Drawing.Point(289, 19);
            this.lbRiesgo.Name = "lbRiesgo";
            this.lbRiesgo.Size = new System.Drawing.Size(52, 15);
            this.lbRiesgo.TabIndex = 22;
            this.lbRiesgo.Text = "Riesgo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(148, 117);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(67, 117);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(8, 53);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(93, 15);
            this.lblActive.TabIndex = 18;
            this.lblActive.Text = "Bien o Activo:";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnalista
            // 
            this.lblAnalista.AutoSize = true;
            this.lblAnalista.Location = new System.Drawing.Point(8, 19);
            this.lblAnalista.Name = "lblAnalista";
            this.lblAnalista.Size = new System.Drawing.Size(86, 15);
            this.lblAnalista.TabIndex = 16;
            this.lblAnalista.Text = "Analista       ";
            this.lblAnalista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDate.Location = new System.Drawing.Point(1095, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 15);
            this.lblDate.TabIndex = 15;
            // 
            // lblCaseID
            // 
            this.lblCaseID.AutoSize = true;
            this.lblCaseID.ForeColor = System.Drawing.Color.Red;
            this.lblCaseID.Location = new System.Drawing.Point(1095, 65);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(61, 15);
            this.lblCaseID.TabIndex = 14;
            this.lblCaseID.Text = "Case ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Red;
            this.txtID.Location = new System.Drawing.Point(1200, 65);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(96, 14);
            this.txtID.TabIndex = 11;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgv1
            // 
            this.dtgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Analista,
            this.BienActivo,
            this.Riesgo,
            this.Daño});
            this.dtgv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv1.Location = new System.Drawing.Point(3, 161);
            this.dtgv1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.RowHeadersWidth = 51;
            this.dtgv1.RowTemplate.Height = 24;
            this.dtgv1.Size = new System.Drawing.Size(835, 151);
            this.dtgv1.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.FillWeight = 48.12834F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Analista
            // 
            this.Analista.FillWeight = 112.9679F;
            this.Analista.HeaderText = "Analista";
            this.Analista.MinimumWidth = 6;
            this.Analista.Name = "Analista";
            this.Analista.ReadOnly = true;
            // 
            // BienActivo
            // 
            this.BienActivo.FillWeight = 112.9679F;
            this.BienActivo.HeaderText = "Bien o Activo";
            this.BienActivo.MinimumWidth = 6;
            this.BienActivo.Name = "BienActivo";
            this.BienActivo.ReadOnly = true;
            // 
            // Riesgo
            // 
            this.Riesgo.FillWeight = 112.9679F;
            this.Riesgo.HeaderText = "Riesgo";
            this.Riesgo.MinimumWidth = 6;
            this.Riesgo.Name = "Riesgo";
            // 
            // Daño
            // 
            this.Daño.FillWeight = 112.9679F;
            this.Daño.HeaderText = "Daño";
            this.Daño.MinimumWidth = 6;
            this.Daño.Name = "Daño";
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(11, 103);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(50, 50);
            this.btnSave1.TabIndex = 1;
            this.btnSave1.Text = "✔";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LimeGreen;
            this.tabPage2.Controls.Add(this.lblID);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblCaseID2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dtgvValores);
            this.tabPage2.Controls.Add(this.btnSave2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(841, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fase 2";
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.Red;
            this.lblID.Location = new System.Drawing.Point(1197, 65);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(112, 29);
            this.lblID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(1108, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 15;
            // 
            // lblCaseID2
            // 
            this.lblCaseID2.AutoSize = true;
            this.lblCaseID2.ForeColor = System.Drawing.Color.Red;
            this.lblCaseID2.Location = new System.Drawing.Point(1108, 65);
            this.lblCaseID2.Name = "lblCaseID2";
            this.lblCaseID2.Size = new System.Drawing.Size(61, 15);
            this.lblCaseID2.TabIndex = 14;
            this.lblCaseID2.Text = "Case ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Guardar Datos";
            // 
            // dtgvValores
            // 
            this.dtgvValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvValores.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dtgvValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ValorS,
            this.ValorF,
            this.ValorP,
            this.ValorA,
            this.ValorV,
            this.ValorE});
            this.dtgvValores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvValores.Location = new System.Drawing.Point(3, 125);
            this.dtgvValores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvValores.Name = "dtgvValores";
            this.dtgvValores.RowHeadersWidth = 51;
            this.dtgvValores.RowTemplate.Height = 24;
            this.dtgvValores.Size = new System.Drawing.Size(835, 187);
            this.dtgvValores.TabIndex = 4;
            this.dtgvValores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvValores_CellContentClick);
            this.dtgvValores.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvValores_CellEndEdit);
            this.dtgvValores.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gdtvValores_CellValidating);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 198.0747F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Bien o Activo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 198.0747F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Riesgo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 198.0747F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Daño";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ValorS
            // 
            this.ValorS.FillWeight = 74.37184F;
            this.ValorS.HeaderText = "S";
            this.ValorS.MaxInputLength = 1;
            this.ValorS.MinimumWidth = 6;
            this.ValorS.Name = "ValorS";
            // 
            // ValorF
            // 
            this.ValorF.FillWeight = 57.41415F;
            this.ValorF.HeaderText = "F";
            this.ValorF.MaxInputLength = 1;
            this.ValorF.MinimumWidth = 6;
            this.ValorF.Name = "ValorF";
            // 
            // ValorP
            // 
            this.ValorP.FillWeight = 57.98459F;
            this.ValorP.HeaderText = "P";
            this.ValorP.MaxInputLength = 1;
            this.ValorP.MinimumWidth = 6;
            this.ValorP.Name = "ValorP";
            // 
            // ValorA
            // 
            this.ValorA.FillWeight = 58.26947F;
            this.ValorA.HeaderText = "A";
            this.ValorA.MaxInputLength = 1;
            this.ValorA.MinimumWidth = 6;
            this.ValorA.Name = "ValorA";
            // 
            // ValorV
            // 
            this.ValorV.FillWeight = 51.45176F;
            this.ValorV.HeaderText = "V";
            this.ValorV.MaxInputLength = 1;
            this.ValorV.MinimumWidth = 6;
            this.ValorV.Name = "ValorV";
            // 
            // ValorE
            // 
            this.ValorE.FillWeight = 45.18789F;
            this.ValorE.HeaderText = "E";
            this.ValorE.MaxInputLength = 1;
            this.ValorE.MinimumWidth = 6;
            this.ValorE.Name = "ValorE";
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(18, 39);
            this.btnSave2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(50, 50);
            this.btnSave2.TabIndex = 1;
            this.btnSave2.Text = "✔";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LimeGreen;
            this.tabPage3.Controls.Add(this.dtgvevaluacion);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(841, 316);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fase 3";
            // 
            // dtgvevaluacion
            // 
            this.dtgvevaluacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvevaluacion.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dtgvevaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvevaluacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fase3Activo,
            this.Fase3Riesgo,
            this.Fase3Daño,
            this.CarDeRiesgo,
            this.PdeRiesgo,
            this.CuanDeRiesgo});
            this.dtgvevaluacion.Location = new System.Drawing.Point(8, 123);
            this.dtgvevaluacion.Name = "dtgvevaluacion";
            this.dtgvevaluacion.RowHeadersWidth = 51;
            this.dtgvevaluacion.RowTemplate.Height = 24;
            this.dtgvevaluacion.Size = new System.Drawing.Size(825, 187);
            this.dtgvevaluacion.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LimeGreen;
            this.tabPage4.Controls.Add(this.dtgvclasificacion);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(841, 316);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fase 4";
            // 
            // dtgvclasificacion
            // 
            this.dtgvclasificacion.AllowUserToDeleteRows = false;
            this.dtgvclasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvclasificacion.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dtgvclasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvclasificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivoF4,
            this.RiesgoF4,
            this.ERF4,
            this.ClassF4});
            this.dtgvclasificacion.Location = new System.Drawing.Point(8, 121);
            this.dtgvclasificacion.Name = "dtgvclasificacion";
            this.dtgvclasificacion.ReadOnly = true;
            this.dtgvclasificacion.RowHeadersWidth = 51;
            this.dtgvclasificacion.RowTemplate.Height = 24;
            this.dtgvclasificacion.Size = new System.Drawing.Size(825, 187);
            this.dtgvclasificacion.TabIndex = 0;
            // 
            // ActivoF4
            // 
            this.ActivoF4.HeaderText = "Bien o Activo";
            this.ActivoF4.MinimumWidth = 6;
            this.ActivoF4.Name = "ActivoF4";
            this.ActivoF4.ReadOnly = true;
            // 
            // RiesgoF4
            // 
            this.RiesgoF4.HeaderText = "Riesgo";
            this.RiesgoF4.MinimumWidth = 6;
            this.RiesgoF4.Name = "RiesgoF4";
            this.RiesgoF4.ReadOnly = true;
            // 
            // ERF4
            // 
            this.ERF4.HeaderText = "ER";
            this.ERF4.MinimumWidth = 6;
            this.ERF4.Name = "ERF4";
            this.ERF4.ReadOnly = true;
            // 
            // ClassF4
            // 
            this.ClassF4.HeaderText = "Clasificación de Riesgo";
            this.ClassF4.MinimumWidth = 6;
            this.ClassF4.Name = "ClassF4";
            this.ClassF4.ReadOnly = true;
            // 
            // Fase3Activo
            // 
            this.Fase3Activo.HeaderText = "Bien o Activo";
            this.Fase3Activo.MinimumWidth = 6;
            this.Fase3Activo.Name = "Fase3Activo";
            this.Fase3Activo.ReadOnly = true;
            // 
            // Fase3Riesgo
            // 
            this.Fase3Riesgo.HeaderText = "Riesgo";
            this.Fase3Riesgo.MinimumWidth = 6;
            this.Fase3Riesgo.Name = "Fase3Riesgo";
            this.Fase3Riesgo.ReadOnly = true;
            // 
            // Fase3Daño
            // 
            this.Fase3Daño.HeaderText = "Daño";
            this.Fase3Daño.MinimumWidth = 6;
            this.Fase3Daño.Name = "Fase3Daño";
            this.Fase3Daño.ReadOnly = true;
            // 
            // CarDeRiesgo
            // 
            this.CarDeRiesgo.HeaderText = "Carácter de Riesgo";
            this.CarDeRiesgo.MinimumWidth = 6;
            this.CarDeRiesgo.Name = "CarDeRiesgo";
            this.CarDeRiesgo.ReadOnly = true;
            // 
            // PdeRiesgo
            // 
            this.PdeRiesgo.HeaderText = "Prob. d Ries Pb";
            this.PdeRiesgo.MinimumWidth = 6;
            this.PdeRiesgo.Name = "PdeRiesgo";
            this.PdeRiesgo.ReadOnly = true;
            // 
            // CuanDeRiesgo
            // 
            this.CuanDeRiesgo.HeaderText = "Cuantifi de Ries ER";
            this.CuanDeRiesgo.MinimumWidth = 6;
            this.CuanDeRiesgo.Name = "CuanDeRiesgo";
            this.CuanDeRiesgo.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(849, 344);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "RisxperttJoss";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvValores)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvevaluacion)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvclasificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblAnalista;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Analista;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Riesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daño;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCaseID2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorE;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dtgvevaluacion;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dtgvclasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivoF4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiesgoF4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERF4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassF4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox textBoxdaño;
        private System.Windows.Forms.TextBox textBoxries;
        private System.Windows.Forms.Label lbDaño;
        private System.Windows.Forms.Label lbRiesgo;
        private System.Windows.Forms.TextBox textBoxbien;
        private System.Windows.Forms.TextBox textBoxanalista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase3Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase3Riesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase3Daño;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarDeRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PdeRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuanDeRiesgo;
    }
}

