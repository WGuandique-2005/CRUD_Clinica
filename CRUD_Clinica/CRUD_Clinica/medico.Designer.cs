namespace CRUD_Clinica
{
    partial class medico
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDmedico = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtNumTelefonoM = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.dgvMedico = new System.Windows.Forms.DataGridView();
            this.btnNuevom = new System.Windows.Forms.Button();
            this.txtEliminarm = new System.Windows.Forms.Button();
            this.btnGuardarm = new System.Windows.Forms.Button();
            this.txtBuscarm = new System.Windows.Forms.Button();
            this.btnModificarm = new System.Windows.Forms.Button();
            this.txtCerrarm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(249, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DEL MEDICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(79, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Medico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(91, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(84, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(45, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Num. Telefonico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(61, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Especialidad:";
            // 
            // txtIDmedico
            // 
            this.txtIDmedico.Location = new System.Drawing.Point(166, 62);
            this.txtIDmedico.Name = "txtIDmedico";
            this.txtIDmedico.Size = new System.Drawing.Size(237, 20);
            this.txtIDmedico.TabIndex = 6;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(166, 103);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(237, 20);
            this.txtNombreM.TabIndex = 7;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(166, 149);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(237, 20);
            this.txtApellidoM.TabIndex = 8;
            // 
            // txtNumTelefonoM
            // 
            this.txtNumTelefonoM.Location = new System.Drawing.Point(166, 199);
            this.txtNumTelefonoM.Name = "txtNumTelefonoM";
            this.txtNumTelefonoM.Size = new System.Drawing.Size(237, 20);
            this.txtNumTelefonoM.TabIndex = 9;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(166, 243);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(237, 20);
            this.txtEspecialidad.TabIndex = 10;
            // 
            // dgvMedico
            // 
            this.dgvMedico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedico.Location = new System.Drawing.Point(30, 290);
            this.dgvMedico.Name = "dgvMedico";
            this.dgvMedico.Size = new System.Drawing.Size(671, 150);
            this.dgvMedico.TabIndex = 11;
            this.dgvMedico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedico_CellDoubleClick);
            // 
            // btnNuevom
            // 
            this.btnNuevom.Location = new System.Drawing.Point(485, 62);
            this.btnNuevom.Name = "btnNuevom";
            this.btnNuevom.Size = new System.Drawing.Size(75, 41);
            this.btnNuevom.TabIndex = 12;
            this.btnNuevom.Text = "NUEVO";
            this.btnNuevom.UseVisualStyleBackColor = true;
            this.btnNuevom.Click += new System.EventHandler(this.btnNuevom_Click);
            // 
            // txtEliminarm
            // 
            this.txtEliminarm.Location = new System.Drawing.Point(607, 62);
            this.txtEliminarm.Name = "txtEliminarm";
            this.txtEliminarm.Size = new System.Drawing.Size(75, 41);
            this.txtEliminarm.TabIndex = 13;
            this.txtEliminarm.Text = "ELIMINAR";
            this.txtEliminarm.UseVisualStyleBackColor = true;
            this.txtEliminarm.Click += new System.EventHandler(this.txtEliminarm_Click);
            // 
            // btnGuardarm
            // 
            this.btnGuardarm.Location = new System.Drawing.Point(485, 122);
            this.btnGuardarm.Name = "btnGuardarm";
            this.btnGuardarm.Size = new System.Drawing.Size(75, 41);
            this.btnGuardarm.TabIndex = 14;
            this.btnGuardarm.Text = "GUARDAR";
            this.btnGuardarm.UseVisualStyleBackColor = true;
            this.btnGuardarm.Click += new System.EventHandler(this.btnGuardarm_Click);
            // 
            // txtBuscarm
            // 
            this.txtBuscarm.Location = new System.Drawing.Point(607, 122);
            this.txtBuscarm.Name = "txtBuscarm";
            this.txtBuscarm.Size = new System.Drawing.Size(75, 41);
            this.txtBuscarm.TabIndex = 15;
            this.txtBuscarm.Text = "BUSCAR";
            this.txtBuscarm.UseVisualStyleBackColor = true;
            this.txtBuscarm.Click += new System.EventHandler(this.txtBuscarm_Click);
            // 
            // btnModificarm
            // 
            this.btnModificarm.Location = new System.Drawing.Point(485, 183);
            this.btnModificarm.Name = "btnModificarm";
            this.btnModificarm.Size = new System.Drawing.Size(75, 41);
            this.btnModificarm.TabIndex = 16;
            this.btnModificarm.Text = "MODIFICAR";
            this.btnModificarm.UseVisualStyleBackColor = true;
            this.btnModificarm.Click += new System.EventHandler(this.btnModificarm_Click);
            // 
            // txtCerrarm
            // 
            this.txtCerrarm.Location = new System.Drawing.Point(607, 183);
            this.txtCerrarm.Name = "txtCerrarm";
            this.txtCerrarm.Size = new System.Drawing.Size(75, 41);
            this.txtCerrarm.TabIndex = 17;
            this.txtCerrarm.Text = "CERRAR";
            this.txtCerrarm.UseVisualStyleBackColor = true;
            this.txtCerrarm.Click += new System.EventHandler(this.txtCerrarm_Click);
            // 
            // medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(733, 459);
            this.Controls.Add(this.txtCerrarm);
            this.Controls.Add(this.btnModificarm);
            this.Controls.Add(this.txtBuscarm);
            this.Controls.Add(this.btnGuardarm);
            this.Controls.Add(this.txtEliminarm);
            this.Controls.Add(this.btnNuevom);
            this.Controls.Add(this.dgvMedico);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtNumTelefonoM);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.txtIDmedico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "medico";
            this.Text = "medico";
            this.Load += new System.EventHandler(this.medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDmedico;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtNumTelefonoM;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.DataGridView dgvMedico;
        private System.Windows.Forms.Button btnNuevom;
        private System.Windows.Forms.Button txtEliminarm;
        private System.Windows.Forms.Button btnGuardarm;
        private System.Windows.Forms.Button txtBuscarm;
        private System.Windows.Forms.Button btnModificarm;
        private System.Windows.Forms.Button txtCerrarm;
    }
}