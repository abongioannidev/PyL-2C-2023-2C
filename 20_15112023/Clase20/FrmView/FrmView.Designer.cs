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
            btnIniciarPartido = new Button();
            lblPateando = new Label();
            pcbPateando = new PictureBox();
            pcbGanador = new PictureBox();
            pcbPerdedor = new PictureBox();
            lblEmpate = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbPateando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbGanador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPerdedor).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarPartido
            // 
            btnIniciarPartido.Location = new Point(47, 47);
            btnIniciarPartido.Name = "btnIniciarPartido";
            btnIniciarPartido.Size = new Size(153, 91);
            btnIniciarPartido.TabIndex = 0;
            btnIniciarPartido.Text = "Inciar Partido";
            btnIniciarPartido.UseVisualStyleBackColor = true;
            btnIniciarPartido.Click += btnApretar_Click;
            // 
            // lblPateando
            // 
            lblPateando.AutoSize = true;
            lblPateando.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblPateando.Location = new Point(47, 178);
            lblPateando.Name = "lblPateando";
            lblPateando.Size = new Size(137, 54);
            lblPateando.TabIndex = 1;
            lblPateando.Text = "label1";
            // 
            // pcbPateando
            // 
            pcbPateando.Location = new Point(492, 24);
            pcbPateando.Name = "pcbPateando";
            pcbPateando.Size = new Size(257, 199);
            pcbPateando.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPateando.TabIndex = 2;
            pcbPateando.TabStop = false;
            // 
            // pcbGanador
            // 
            pcbGanador.Location = new Point(22, 367);
            pcbGanador.Name = "pcbGanador";
            pcbGanador.Size = new Size(257, 199);
            pcbGanador.SizeMode = PictureBoxSizeMode.Zoom;
            pcbGanador.TabIndex = 3;
            pcbGanador.TabStop = false;
            // 
            // pcbPerdedor
            // 
            pcbPerdedor.Location = new Point(492, 367);
            pcbPerdedor.Name = "pcbPerdedor";
            pcbPerdedor.Size = new Size(257, 199);
            pcbPerdedor.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPerdedor.TabIndex = 4;
            pcbPerdedor.TabStop = false;
            // 
            // lblEmpate
            // 
            lblEmpate.AutoSize = true;
            lblEmpate.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpate.Location = new Point(47, 263);
            lblEmpate.Name = "lblEmpate";
            lblEmpate.Size = new Size(137, 54);
            lblEmpate.TabIndex = 5;
            lblEmpate.Text = "label1";
            lblEmpate.Visible = false;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 629);
            Controls.Add(lblEmpate);
            Controls.Add(pcbPerdedor);
            Controls.Add(pcbGanador);
            Controls.Add(pcbPateando);
            Controls.Add(lblPateando);
            Controls.Add(btnIniciarPartido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Final Libertadores";
            Load += FrmView_Load;
            ((System.ComponentModel.ISupportInitialize)pcbPateando).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbGanador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPerdedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarPartido;
        private Label lblPateando;
        private PictureBox pcbPateando;
        private PictureBox pcbGanador;
        private PictureBox pcbPerdedor;
        private Label lblEmpate;
    }
}