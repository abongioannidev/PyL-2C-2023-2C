namespace Clase05
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
            btnAbrirPersona = new Button();
            btnCerrar = new Button();
            btnVerPersona = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            grpCheck = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            lstName = new ListBox();
            comboBox1 = new ComboBox();
            grpCheck.SuspendLayout();
            SuspendLayout();
            // 
            // btnAbrirPersona
            // 
            btnAbrirPersona.Location = new Point(12, 12);
            btnAbrirPersona.Name = "btnAbrirPersona";
            btnAbrirPersona.Size = new Size(115, 36);
            btnAbrirPersona.TabIndex = 0;
            btnAbrirPersona.Text = "Alta Persona";
            btnAbrirPersona.UseVisualStyleBackColor = true;
            btnAbrirPersona.Click += btnAceptar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(133, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(98, 39);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnVerPersona
            // 
            btnVerPersona.Location = new Point(237, 20);
            btnVerPersona.Name = "btnVerPersona";
            btnVerPersona.Size = new Size(125, 23);
            btnVerPersona.TabIndex = 2;
            btnVerPersona.Text = "Ver";
            btnVerPersona.UseVisualStyleBackColor = true;
            btnVerPersona.Click += btnVerPersona_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 39);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(16, 64);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(16, 93);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // grpCheck
            // 
            grpCheck.Controls.Add(radioButton3);
            grpCheck.Controls.Add(radioButton2);
            grpCheck.Controls.Add(radioButton1);
            grpCheck.Controls.Add(checkBox1);
            grpCheck.Controls.Add(checkBox3);
            grpCheck.Controls.Add(checkBox2);
            grpCheck.Location = new Point(61, 112);
            grpCheck.Name = "grpCheck";
            grpCheck.Size = new Size(255, 157);
            grpCheck.TabIndex = 6;
            grpCheck.TabStop = false;
            grpCheck.Text = "groupBox1";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(142, 93);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(142, 64);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(142, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(512, 74);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(512, 99);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(512, 124);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 9;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // lstName
            // 
            lstName.FormattingEnabled = true;
            lstName.ItemHeight = 15;
            lstName.Location = new Point(448, 232);
            lstName.Name = "lstName";
            lstName.Size = new Size(120, 94);
            lstName.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(91, 364);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 11;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 508);
            Controls.Add(comboBox1);
            Controls.Add(lstName);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(grpCheck);
            Controls.Add(btnVerPersona);
            Controls.Add(btnCerrar);
            Controls.Add(btnAbrirPersona);
            Name = "FrmView";
            Text = "Formulario de Alejandro";
            FormClosing += FrmView_FormClosing;
            Load += FrmView_Load;
            grpCheck.ResumeLayout(false);
            grpCheck.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirPersona;
        private Button btnCerrar;
        private Button btnVerPersona;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private GroupBox grpCheck;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private ListBox lstName;
        private ComboBox comboBox1;
    }
}