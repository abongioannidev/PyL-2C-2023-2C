namespace Clase10
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
            txtDni = new TextBox();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(101, 94);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Dni";
            txtDni.Size = new Size(211, 48);
            txtDni.TabIndex = 0;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(101, 170);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(202, 69);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear Alumno";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 415);
            Controls.Add(btnCrear);
            Controls.Add(txtDni);
            Name = "FrmView";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDni;
        private Button btnCrear;
    }
}