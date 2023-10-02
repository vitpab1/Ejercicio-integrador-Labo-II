namespace MiCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            gpbSistema = new GroupBox();
            lblPrimerOperador = new Label();
            lblOperador = new Label();
            lblSegundoOperador = new Label();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            cmbOperacion = new ComboBox();
            lblResultado = new Label();
            label1 = new Label();
            gpbSistema.SuspendLayout();
            SuspendLayout();
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(6, 33);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 1;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(100, 33);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 2;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // gpbSistema
            // 
            gpbSistema.Controls.Add(rdbBinario);
            gpbSistema.Controls.Add(rdbDecimal);
            gpbSistema.Location = new Point(226, 159);
            gpbSistema.Name = "gpbSistema";
            gpbSistema.Size = new Size(200, 68);
            gpbSistema.TabIndex = 3;
            gpbSistema.TabStop = false;
            gpbSistema.Text = "Representar el resultado en:";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(12, 275);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.RightToLeft = RightToLeft.No;
            lblPrimerOperador.Size = new Size(158, 25);
            lblPrimerOperador.TabIndex = 4;
            lblPrimerOperador.Text = "Primer Operador:";
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperador.Location = new Point(259, 275);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(104, 25);
            lblOperador.TabIndex = 5;
            lblOperador.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(432, 275);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(177, 25);
            lblSegundoOperador.TabIndex = 7;
            lblSegundoOperador.Text = "Segundo Operador:";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(12, 303);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(223, 23);
            txtPrimerOperador.TabIndex = 5;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(432, 303);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(202, 23);
            txtSegundoOperador.TabIndex = 8;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(12, 350);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(223, 43);
            btnOperar.TabIndex = 10;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = false;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(241, 350);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(185, 43);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(432, 350);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(202, 43);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cmbOperacion
            // 
            cmbOperacion.BackColor = Color.White;
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(259, 303);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(135, 23);
            cmbOperacion.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(226, 53);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(408, 57);
            lblResultado.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(210, 57);
            label1.TabIndex = 13;
            label1.Text = "Resultado:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 410);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperador);
            Controls.Add(lblPrimerOperador);
            Controls.Add(gpbSistema);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de: Pablo Vittar";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            gpbSistema.ResumeLayout(false);
            gpbSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private GroupBox gpbSistema;
        private Label lblPrimerOperador;
        private Label lblOperador;
        private Label lblSegundoOperador;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private ComboBox cmbOperacion;
        private Label lblResultado;
        private Label label1;
    }
}