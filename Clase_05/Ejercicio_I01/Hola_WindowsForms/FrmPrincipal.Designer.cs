
namespace Hola_WindowsForms
{
    partial class FrmPrincipal
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMateriaFav = new System.Windows.Forms.Label();
            this.cmbMateriaFav = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(22, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 23);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(202, 42);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(134, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(202, 139);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(134, 23);
            this.btnSaludar.TabIndex = 4;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(202, 24);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 15);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // lblMateriaFav
            // 
            this.lblMateriaFav.AutoSize = true;
            this.lblMateriaFav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMateriaFav.Location = new System.Drawing.Point(22, 81);
            this.lblMateriaFav.Name = "lblMateriaFav";
            this.lblMateriaFav.Size = new System.Drawing.Size(98, 15);
            this.lblMateriaFav.TabIndex = 6;
            this.lblMateriaFav.Text = "Materia Favorita";
            this.lblMateriaFav.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbMateriaFav
            // 
            this.cmbMateriaFav.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cmbMateriaFav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaFav.FormattingEnabled = true;
            this.cmbMateriaFav.Items.AddRange(new object[] {
            "Matemática",
            "Programación I",
            "Inglés I",
            "Laboratorio I",
            "Sistema de Prosecamiento de Datos",
            "Programación II",
            "Laboratorio II",
            "Arquitectura y Sistemas Operativos",
            "Estadística",
            "Inglés II",
            "Metodología de la investigación"});
            this.cmbMateriaFav.Location = new System.Drawing.Point(22, 99);
            this.cmbMateriaFav.Name = "cmbMateriaFav";
            this.cmbMateriaFav.Size = new System.Drawing.Size(314, 23);
            this.cmbMateriaFav.TabIndex = 7;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 181);
            this.Controls.Add(this.cmbMateriaFav);
            this.Controls.Add(this.lblMateriaFav);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMateriaFav;
        private System.Windows.Forms.ComboBox cmbMateriaFav;
    }
}

