
namespace Registrate
{
    partial class Form1
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
            this.grpDetallesUsuario = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdoNoBinario = new System.Windows.Forms.RadioButton();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.chkJavaScript = new System.Windows.Forms.CheckBox();
            this.chkCPlusPlus = new System.Windows.Forms.CheckBox();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lstPais = new System.Windows.Forms.ListBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grpDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.grpGenero.SuspendLayout();
            this.grpCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetallesUsuario
            // 
            this.grpDetallesUsuario.Controls.Add(this.lblEdad);
            this.grpDetallesUsuario.Controls.Add(this.lblDireccion);
            this.grpDetallesUsuario.Controls.Add(this.lblNombre);
            this.grpDetallesUsuario.Controls.Add(this.nudEdad);
            this.grpDetallesUsuario.Controls.Add(this.txtDireccion);
            this.grpDetallesUsuario.Controls.Add(this.txtNombre);
            this.grpDetallesUsuario.Location = new System.Drawing.Point(22, 24);
            this.grpDetallesUsuario.Name = "grpDetallesUsuario";
            this.grpDetallesUsuario.Size = new System.Drawing.Size(246, 183);
            this.grpDetallesUsuario.TabIndex = 0;
            this.grpDetallesUsuario.TabStop = false;
            this.grpDetallesUsuario.Text = "Detalles del usuario";
            this.grpDetallesUsuario.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 145);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 90);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(78, 143);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(162, 23);
            this.nudEdad.TabIndex = 2;
            this.nudEdad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(78, 87);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(162, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdoNoBinario);
            this.grpGenero.Controls.Add(this.rdoFemenino);
            this.grpGenero.Controls.Add(this.rdoMasculino);
            this.grpGenero.Location = new System.Drawing.Point(310, 24);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(120, 126);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdoNoBinario
            // 
            this.rdoNoBinario.AutoSize = true;
            this.rdoNoBinario.Location = new System.Drawing.Point(19, 82);
            this.rdoNoBinario.Name = "rdoNoBinario";
            this.rdoNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rdoNoBinario.TabIndex = 8;
            this.rdoNoBinario.TabStop = true;
            this.rdoNoBinario.Text = "No binario";
            this.rdoNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.Location = new System.Drawing.Point(19, 57);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdoFemenino.TabIndex = 7;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(19, 32);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdoMasculino.TabIndex = 6;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.chkJavaScript);
            this.grpCursos.Controls.Add(this.chkCPlusPlus);
            this.grpCursos.Controls.Add(this.chkCSharp);
            this.grpCursos.Location = new System.Drawing.Point(310, 180);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(120, 129);
            this.grpCursos.TabIndex = 2;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // chkJavaScript
            // 
            this.chkJavaScript.AutoSize = true;
            this.chkJavaScript.Location = new System.Drawing.Point(19, 85);
            this.chkJavaScript.Name = "chkJavaScript";
            this.chkJavaScript.Size = new System.Drawing.Size(78, 19);
            this.chkJavaScript.TabIndex = 6;
            this.chkJavaScript.Text = "JavaScript";
            this.chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkCPlusPlus
            // 
            this.chkCPlusPlus.AutoSize = true;
            this.chkCPlusPlus.Location = new System.Drawing.Point(19, 58);
            this.chkCPlusPlus.Name = "chkCPlusPlus";
            this.chkCPlusPlus.Size = new System.Drawing.Size(50, 19);
            this.chkCPlusPlus.TabIndex = 5;
            this.chkCPlusPlus.Text = "C++";
            this.chkCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(19, 31);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(41, 19);
            this.chkCSharp.TabIndex = 4;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(22, 254);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "País";
            // 
            // lstPais
            // 
            this.lstPais.FormattingEnabled = true;
            this.lstPais.ItemHeight = 15;
            this.lstPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lstPais.Location = new System.Drawing.Point(22, 272);
            this.lstPais.Name = "lstPais";
            this.lstPais.Size = new System.Drawing.Size(246, 94);
            this.lstPais.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(329, 340);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(101, 26);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 406);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lstPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDetallesUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDetallesUsuario.ResumeLayout(false);
            this.grpDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetallesUsuario;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdoNoBinario;
        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.GroupBox grpCursos;
        private System.Windows.Forms.CheckBox chkJavaScript;
        private System.Windows.Forms.CheckBox chkCPlusPlus;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ListBox lstPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}

