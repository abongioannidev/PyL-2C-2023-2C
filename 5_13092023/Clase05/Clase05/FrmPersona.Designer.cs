namespace Clase05
{
    partial class FrmPersona
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEdad = new Label();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(12, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(169, 43);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(205, 86);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(201, 43);
            txtApellido.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(424, 86);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Edad";
            txtEdad.Size = new Size(140, 43);
            txtEdad.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(121, 37);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(205, 46);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(123, 37);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdad.Location = new Point(424, 46);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(83, 37);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad:";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(12, 158);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(235, 104);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear Persona";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FrmPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 315);
            Controls.Add(btnCrear);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPersona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Button btnCrear;
    }
}