namespace SistemaPrestamoUSP
{
    partial class RegistrarModulo
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatosModulos = new System.Windows.Forms.DataGridView();
            this.txtCodigoModulo = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombreModulo = new Guna.UI.WinForms.GunaTextBox();
            this.txtUltimoCodigoModuloRegistrado = new Guna.UI.WinForms.GunaTextBox();
            this.lblUltimoCodigoModuloRegistrado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevo = new Guna.UI.WinForms.GunaButton();
            this.btnAgregarModulo = new Guna.UI.WinForms.GunaButton();
            this.btnModificarModulo = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarModulo = new Guna.UI.WinForms.GunaButton();
            this.lblSeccion1 = new System.Windows.Forms.Label();
            this.lblMayorOmenor = new System.Windows.Forms.Label();
            this.lblSeccion2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosModulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(375, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "REGISTRAR MODULO";
            // 
            // dgvDatosModulos
            // 
            this.dgvDatosModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosModulos.Location = new System.Drawing.Point(435, 87);
            this.dgvDatosModulos.Name = "dgvDatosModulos";
            this.dgvDatosModulos.Size = new System.Drawing.Size(470, 196);
            this.dgvDatosModulos.TabIndex = 2;
            // 
            // txtCodigoModulo
            // 
            this.txtCodigoModulo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigoModulo.BaseColor = System.Drawing.Color.White;
            this.txtCodigoModulo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.txtCodigoModulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoModulo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCodigoModulo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtCodigoModulo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtCodigoModulo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtCodigoModulo.Location = new System.Drawing.Point(103, 112);
            this.txtCodigoModulo.Name = "txtCodigoModulo";
            this.txtCodigoModulo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtCodigoModulo.PasswordChar = '\0';
            this.txtCodigoModulo.Radius = 12;
            this.txtCodigoModulo.SelectedText = "";
            this.txtCodigoModulo.Size = new System.Drawing.Size(293, 26);
            this.txtCodigoModulo.TabIndex = 3;
            this.txtCodigoModulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoModulo.TextChanged += new System.EventHandler(this.txtCodigoModulo_TextChanged);
            // 
            // txtNombreModulo
            // 
            this.txtNombreModulo.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreModulo.BaseColor = System.Drawing.Color.White;
            this.txtNombreModulo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.txtNombreModulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreModulo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombreModulo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtNombreModulo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtNombreModulo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtNombreModulo.Location = new System.Drawing.Point(103, 187);
            this.txtNombreModulo.Name = "txtNombreModulo";
            this.txtNombreModulo.PasswordChar = '\0';
            this.txtNombreModulo.Radius = 12;
            this.txtNombreModulo.SelectedText = "";
            this.txtNombreModulo.Size = new System.Drawing.Size(293, 26);
            this.txtNombreModulo.TabIndex = 3;
            this.txtNombreModulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreModulo.TextChanged += new System.EventHandler(this.txtNombreModulo_TextChanged);
            // 
            // txtUltimoCodigoModuloRegistrado
            // 
            this.txtUltimoCodigoModuloRegistrado.BackColor = System.Drawing.Color.Transparent;
            this.txtUltimoCodigoModuloRegistrado.BaseColor = System.Drawing.Color.White;
            this.txtUltimoCodigoModuloRegistrado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.txtUltimoCodigoModuloRegistrado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUltimoCodigoModuloRegistrado.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUltimoCodigoModuloRegistrado.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtUltimoCodigoModuloRegistrado.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtUltimoCodigoModuloRegistrado.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoCodigoModuloRegistrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtUltimoCodigoModuloRegistrado.Location = new System.Drawing.Point(103, 257);
            this.txtUltimoCodigoModuloRegistrado.Name = "txtUltimoCodigoModuloRegistrado";
            this.txtUltimoCodigoModuloRegistrado.PasswordChar = '\0';
            this.txtUltimoCodigoModuloRegistrado.Radius = 12;
            this.txtUltimoCodigoModuloRegistrado.SelectedText = "";
            this.txtUltimoCodigoModuloRegistrado.Size = new System.Drawing.Size(193, 26);
            this.txtUltimoCodigoModuloRegistrado.TabIndex = 3;
            // 
            // lblUltimoCodigoModuloRegistrado
            // 
            this.lblUltimoCodigoModuloRegistrado.AutoSize = true;
            this.lblUltimoCodigoModuloRegistrado.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoCodigoModuloRegistrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.lblUltimoCodigoModuloRegistrado.Location = new System.Drawing.Point(336, 257);
            this.lblUltimoCodigoModuloRegistrado.Name = "lblUltimoCodigoModuloRegistrado";
            this.lblUltimoCodigoModuloRegistrado.Size = new System.Drawing.Size(60, 22);
            this.lblUltimoCodigoModuloRegistrado.TabIndex = 5;
            this.lblUltimoCodigoModuloRegistrado.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(108, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.label3.Location = new System.Drawing.Point(108, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.AnimationHoverSpeed = 0.07F;
            this.btnNuevo.AnimationSpeed = 0.03F;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnNuevo.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevo.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = null;
            this.btnNuevo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNuevo.Location = new System.Drawing.Point(432, 302);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OnHoverBaseColor = System.Drawing.Color.SkyBlue;
            this.btnNuevo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevo.OnHoverImage = null;
            this.btnNuevo.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevo.Radius = 15;
            this.btnNuevo.Size = new System.Drawing.Size(94, 34);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregarModulo
            // 
            this.btnAgregarModulo.AnimationHoverSpeed = 0.07F;
            this.btnAgregarModulo.AnimationSpeed = 0.03F;
            this.btnAgregarModulo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarModulo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnAgregarModulo.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarModulo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarModulo.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarModulo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarModulo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarModulo.Image = null;
            this.btnAgregarModulo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarModulo.Location = new System.Drawing.Point(559, 302);
            this.btnAgregarModulo.Name = "btnAgregarModulo";
            this.btnAgregarModulo.OnHoverBaseColor = System.Drawing.Color.SkyBlue;
            this.btnAgregarModulo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarModulo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarModulo.OnHoverImage = null;
            this.btnAgregarModulo.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarModulo.Radius = 15;
            this.btnAgregarModulo.Size = new System.Drawing.Size(94, 34);
            this.btnAgregarModulo.TabIndex = 6;
            this.btnAgregarModulo.Text = "Agregar";
            this.btnAgregarModulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnModificarModulo
            // 
            this.btnModificarModulo.AnimationHoverSpeed = 0.07F;
            this.btnModificarModulo.AnimationSpeed = 0.03F;
            this.btnModificarModulo.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarModulo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnModificarModulo.BorderColor = System.Drawing.Color.Black;
            this.btnModificarModulo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificarModulo.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificarModulo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarModulo.ForeColor = System.Drawing.Color.White;
            this.btnModificarModulo.Image = null;
            this.btnModificarModulo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificarModulo.Location = new System.Drawing.Point(684, 302);
            this.btnModificarModulo.Name = "btnModificarModulo";
            this.btnModificarModulo.OnHoverBaseColor = System.Drawing.Color.SkyBlue;
            this.btnModificarModulo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificarModulo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificarModulo.OnHoverImage = null;
            this.btnModificarModulo.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificarModulo.Radius = 15;
            this.btnModificarModulo.Size = new System.Drawing.Size(94, 34);
            this.btnModificarModulo.TabIndex = 6;
            this.btnModificarModulo.Text = "Modificar";
            this.btnModificarModulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEliminarModulo
            // 
            this.btnEliminarModulo.AnimationHoverSpeed = 0.07F;
            this.btnEliminarModulo.AnimationSpeed = 0.03F;
            this.btnEliminarModulo.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarModulo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnEliminarModulo.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarModulo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarModulo.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarModulo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarModulo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarModulo.Image = null;
            this.btnEliminarModulo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarModulo.Location = new System.Drawing.Point(813, 302);
            this.btnEliminarModulo.Name = "btnEliminarModulo";
            this.btnEliminarModulo.OnHoverBaseColor = System.Drawing.Color.SkyBlue;
            this.btnEliminarModulo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarModulo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarModulo.OnHoverImage = null;
            this.btnEliminarModulo.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarModulo.Radius = 15;
            this.btnEliminarModulo.Size = new System.Drawing.Size(94, 34);
            this.btnEliminarModulo.TabIndex = 6;
            this.btnEliminarModulo.Text = "Eliminar";
            this.btnEliminarModulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSeccion1
            // 
            this.lblSeccion1.AutoSize = true;
            this.lblSeccion1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.lblSeccion1.Location = new System.Drawing.Point(99, 403);
            this.lblSeccion1.Name = "lblSeccion1";
            this.lblSeccion1.Size = new System.Drawing.Size(60, 22);
            this.lblSeccion1.TabIndex = 5;
            this.lblSeccion1.Text = "label3";
            // 
            // lblMayorOmenor
            // 
            this.lblMayorOmenor.AutoSize = true;
            this.lblMayorOmenor.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayorOmenor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.lblMayorOmenor.Location = new System.Drawing.Point(181, 403);
            this.lblMayorOmenor.Name = "lblMayorOmenor";
            this.lblMayorOmenor.Size = new System.Drawing.Size(20, 22);
            this.lblMayorOmenor.TabIndex = 5;
            this.lblMayorOmenor.Text = ">";
            // 
            // lblSeccion2
            // 
            this.lblSeccion2.AutoSize = true;
            this.lblSeccion2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.lblSeccion2.Location = new System.Drawing.Point(216, 403);
            this.lblSeccion2.Name = "lblSeccion2";
            this.lblSeccion2.Size = new System.Drawing.Size(60, 22);
            this.lblSeccion2.TabIndex = 5;
            this.lblSeccion2.Text = "label3";
            // 
            // RegistrarModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1010, 458);
            this.Controls.Add(this.btnEliminarModulo);
            this.Controls.Add(this.btnModificarModulo);
            this.Controls.Add(this.btnAgregarModulo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeccion2);
            this.Controls.Add(this.lblMayorOmenor);
            this.Controls.Add(this.lblSeccion1);
            this.Controls.Add(this.lblUltimoCodigoModuloRegistrado);
            this.Controls.Add(this.txtUltimoCodigoModuloRegistrado);
            this.Controls.Add(this.txtNombreModulo);
            this.Controls.Add(this.txtCodigoModulo);
            this.Controls.Add(this.dgvDatosModulos);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarModulo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegistrarModulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosModulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatosModulos;
        private Guna.UI.WinForms.GunaTextBox txtCodigoModulo;
        private Guna.UI.WinForms.GunaTextBox txtNombreModulo;
        private Guna.UI.WinForms.GunaTextBox txtUltimoCodigoModuloRegistrado;
        private System.Windows.Forms.Label lblUltimoCodigoModuloRegistrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnNuevo;
        private Guna.UI.WinForms.GunaButton btnAgregarModulo;
        private Guna.UI.WinForms.GunaButton btnModificarModulo;
        private Guna.UI.WinForms.GunaButton btnEliminarModulo;
        private System.Windows.Forms.Label lblSeccion1;
        private System.Windows.Forms.Label lblMayorOmenor;
        private System.Windows.Forms.Label lblSeccion2;
    }
}