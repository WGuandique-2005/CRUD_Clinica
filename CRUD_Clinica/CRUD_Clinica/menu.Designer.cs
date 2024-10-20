namespace CRUD_Clinica
{
    partial class menu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PACIENTES = new System.Windows.Forms.Button();
            this.MEDICOS = new System.Windows.Forms.Button();
            this.REGISTROS = new System.Windows.Forms.Button();
            this.CERRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(155, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡BIENVENIDO!\r\nCLINICA PATRAS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar datos de un PACIENTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar datos de un MEDICO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SlateBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(86, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresar datos de un \r\nREGISTRO u INGRESO:";
            // 
            // PACIENTES
            // 
            this.PACIENTES.Location = new System.Drawing.Point(370, 110);
            this.PACIENTES.Name = "PACIENTES";
            this.PACIENTES.Size = new System.Drawing.Size(140, 60);
            this.PACIENTES.TabIndex = 4;
            this.PACIENTES.Text = "AGREGAR DATOS";
            this.PACIENTES.UseVisualStyleBackColor = true;
            this.PACIENTES.Click += new System.EventHandler(this.PACIENTES_Click);
            // 
            // MEDICOS
            // 
            this.MEDICOS.Location = new System.Drawing.Point(370, 174);
            this.MEDICOS.Name = "MEDICOS";
            this.MEDICOS.Size = new System.Drawing.Size(140, 60);
            this.MEDICOS.TabIndex = 5;
            this.MEDICOS.Text = "AGREGAR DATOS";
            this.MEDICOS.UseVisualStyleBackColor = true;
            this.MEDICOS.Click += new System.EventHandler(this.MEDICOS_Click);
            // 
            // REGISTROS
            // 
            this.REGISTROS.Location = new System.Drawing.Point(370, 240);
            this.REGISTROS.Name = "REGISTROS";
            this.REGISTROS.Size = new System.Drawing.Size(140, 60);
            this.REGISTROS.TabIndex = 6;
            this.REGISTROS.Text = "AGREGAR UN REGISTRO";
            this.REGISTROS.UseVisualStyleBackColor = true;
            this.REGISTROS.Click += new System.EventHandler(this.REGISTROS_Click);
            // 
            // CERRAR
            // 
            this.CERRAR.ForeColor = System.Drawing.Color.Red;
            this.CERRAR.Location = new System.Drawing.Point(272, 341);
            this.CERRAR.Name = "CERRAR";
            this.CERRAR.Size = new System.Drawing.Size(238, 39);
            this.CERRAR.TabIndex = 7;
            this.CERRAR.Text = "CERRAR";
            this.CERRAR.UseVisualStyleBackColor = true;
            this.CERRAR.Click += new System.EventHandler(this.CERRAR_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(605, 392);
            this.Controls.Add(this.CERRAR);
            this.Controls.Add(this.REGISTROS);
            this.Controls.Add(this.MEDICOS);
            this.Controls.Add(this.PACIENTES);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PACIENTES;
        private System.Windows.Forms.Button MEDICOS;
        private System.Windows.Forms.Button REGISTROS;
        private System.Windows.Forms.Button CERRAR;
    }
}