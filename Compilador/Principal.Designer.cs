namespace Compilador
{
    partial class Principal
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnALexico = new System.Windows.Forms.Button();
            this.rText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rcodGen = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTsimb = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ColLexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coltoken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTOKEN_LEXEMA = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtSintactico = new System.Windows.Forms.RichTextBox();
            this.rtSemantico = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTsimb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTOKEN_LEXEMA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código a Analizar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(500, -1);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 30);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(607, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(54, 30);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnALexico
            // 
            this.btnALexico.BackColor = System.Drawing.Color.DarkBlue;
            this.btnALexico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALexico.ForeColor = System.Drawing.SystemColors.Control;
            this.btnALexico.Location = new System.Drawing.Point(431, -1);
            this.btnALexico.Name = "btnALexico";
            this.btnALexico.Size = new System.Drawing.Size(68, 30);
            this.btnALexico.TabIndex = 8;
            this.btnALexico.Text = "Generar";
            this.btnALexico.UseVisualStyleBackColor = false;
            this.btnALexico.Click += new System.EventHandler(this.btnALexico_Click);
            // 
            // rText
            // 
            this.rText.Location = new System.Drawing.Point(17, 36);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(367, 363);
            this.rText.TabIndex = 6;
            this.rText.Text = "";
            this.rText.TextChanged += new System.EventHandler(this.rTexto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(88, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Analisis Lexico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rcodGen
            // 
            this.rcodGen.Location = new System.Drawing.Point(681, 36);
            this.rcodGen.Name = "rcodGen";
            this.rcodGen.Size = new System.Drawing.Size(367, 363);
            this.rcodGen.TabIndex = 12;
            this.rcodGen.Text = "";
            this.rcodGen.TextChanged += new System.EventHandler(this.rcodGen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(795, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Código Generado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvTsimb
            // 
            this.dgvTsimb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTsimb.Location = new System.Drawing.Point(416, 107);
            this.dgvTsimb.Name = "dgvTsimb";
            this.dgvTsimb.Size = new System.Drawing.Size(243, 248);
            this.dgvTsimb.TabIndex = 14;
            this.dgvTsimb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(466, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tabla de Simbolos";
            // 
            // ColLexema
            // 
            this.ColLexema.HeaderText = "LEXEMA";
            this.ColLexema.Name = "ColLexema";
            // 
            // Coltoken
            // 
            this.Coltoken.HeaderText = "TOKEN";
            this.Coltoken.Name = "Coltoken";
            // 
            // dgvTOKEN_LEXEMA
            // 
            this.dgvTOKEN_LEXEMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTOKEN_LEXEMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coltoken,
            this.ColLexema});
            this.dgvTOKEN_LEXEMA.Location = new System.Drawing.Point(16, 445);
            this.dgvTOKEN_LEXEMA.Name = "dgvTOKEN_LEXEMA";
            this.dgvTOKEN_LEXEMA.Size = new System.Drawing.Size(243, 248);
            this.dgvTOKEN_LEXEMA.TabIndex = 7;
            this.dgvTOKEN_LEXEMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTOKEN_LEXEMA_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(819, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Analisis Semantico";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(413, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Analisis Sintactico";
            // 
            // rtSintactico
            // 
            this.rtSintactico.Location = new System.Drawing.Point(276, 445);
            this.rtSintactico.Name = "rtSintactico";
            this.rtSintactico.Size = new System.Drawing.Size(437, 248);
            this.rtSintactico.TabIndex = 20;
            this.rtSintactico.Text = "";
            // 
            // rtSemantico
            // 
            this.rtSemantico.Location = new System.Drawing.Point(731, 445);
            this.rtSemantico.Name = "rtSemantico";
            this.rtSemantico.Size = new System.Drawing.Size(317, 248);
            this.rtSemantico.TabIndex = 21;
            this.rtSemantico.Text = "";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1061, 736);
            this.Controls.Add(this.rtSemantico);
            this.Controls.Add(this.rtSintactico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTsimb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rcodGen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnALexico);
            this.Controls.Add(this.dgvTOKEN_LEXEMA);
            this.Controls.Add(this.rText);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MINI COMPILADOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTsimb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTOKEN_LEXEMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnALexico;
        private System.Windows.Forms.RichTextBox rText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rcodGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTsimb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coltoken;
        private System.Windows.Forms.DataGridView dgvTOKEN_LEXEMA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtSintactico;
        private System.Windows.Forms.RichTextBox rtSemantico;
    }
}

