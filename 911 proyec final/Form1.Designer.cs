namespace _911
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
            this.cmbAnswer = new System.Windows.Forms.ComboBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAnswer
            // 
            this.cmbAnswer.BackColor = System.Drawing.Color.PaleGreen;
            this.cmbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnswer.FormattingEnabled = true;
            this.cmbAnswer.Location = new System.Drawing.Point(439, 60);
            this.cmbAnswer.Name = "cmbAnswer";
            this.cmbAnswer.Size = new System.Drawing.Size(173, 24);
            this.cmbAnswer.TabIndex = 5;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblQuestion.Location = new System.Drawing.Point(184, 64);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(249, 28);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Question1";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightGreen;
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(12, 49);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(166, 43);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(637, 171);
            this.Controls.Add(this.cmbAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
    }
}

