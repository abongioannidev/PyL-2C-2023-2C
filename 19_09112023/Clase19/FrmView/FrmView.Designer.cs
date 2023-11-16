namespace FrmView
{
    partial class FrmView
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
            btnEmpezar = new Button();
            lstUsuarios = new ListBox();
            btnTerminar = new Button();
            lblReloj = new Label();
            SuspendLayout();
            // 
            // btnEmpezar
            // 
            btnEmpezar.Location = new Point(12, 440);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(158, 58);
            btnEmpezar.TabIndex = 0;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = true;
            btnEmpezar.Click += btnEmpezar_Click;
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(545, 63);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(289, 394);
            lstUsuarios.TabIndex = 1;
            // 
            // btnTerminar
            // 
            btnTerminar.Location = new Point(187, 440);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(158, 58);
            btnTerminar.TabIndex = 2;
            btnTerminar.Text = "Terminar";
            btnTerminar.UseVisualStyleBackColor = true;
            btnTerminar.Click += btnTerminar_Click;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            lblReloj.Location = new Point(55, 320);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(99, 42);
            lblReloj.TabIndex = 3;
            lblReloj.Text = "Reloj:";
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 510);
            Controls.Add(lblReloj);
            Controls.Add(btnTerminar);
            Controls.Add(lstUsuarios);
            Controls.Add(btnEmpezar);
            Name = "FrmView";
            Text = "Mi Formulario";
            FormClosing += FrmView_FormClosing;
            Load += FrmView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmpezar;
        private ListBox lstUsuarios;
        private Button btnTerminar;
        private Label lblReloj;
    }
}