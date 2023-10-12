namespace FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            lblPrimerOperador = new Label();
            lblSegundoOperador = new Label();
            lblOperacion = new Label();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            cmbOperacion = new ComboBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            lblResultado = new Label();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lstHistorial = new ListBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(14, 201);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(158, 25);
            lblPrimerOperador.TabIndex = 0;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(340, 201);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(176, 25);
            lblSegundoOperador.TabIndex = 1;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(204, 201);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(105, 25);
            lblOperacion.TabIndex = 2;
            lblOperacion.Text = "Operacion:";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(14, 226);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(158, 35);
            txtPrimerOperando.TabIndex = 0;
            txtPrimerOperando.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(342, 226);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(158, 35);
            txtSegundoOperando.TabIndex = 2;
            txtSegundoOperando.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(196, 226);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 38);
            cmbOperacion.TabIndex = 1;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(14, 279);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(158, 38);
            btnOperar.TabIndex = 3;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(178, 279);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(158, 38);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(342, 279);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(158, 38);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 32);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(181, 47);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado:";
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(155, 123);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(181, 66);
            grpSistema.TabIndex = 6;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(98, 32);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 8;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(6, 32);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 7;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(544, 88);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(395, 229);
            lstHistorial.TabIndex = 10;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 330);
            Controls.Add(lstHistorial);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblOperacion);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblPrimerOperador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Nombre y Apellido";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrimerOperador;
        private Label lblSegundoOperador;
        private Label lblOperacion;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private ComboBox cmbOperacion;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label lblResultado;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private ListBox lstHistorial;
    }
}