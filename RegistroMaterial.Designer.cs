namespace SistemaPrestamoUSP
{
    partial class RegistroMaterial
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
            this.components = new System.ComponentModel.Container();
            this.cbxTipo = new Guna.UI.WinForms.GunaComboBox();
            this.cbxEstado = new Guna.UI.WinForms.GunaComboBox();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnModificar = new Guna.UI.WinForms.GunaButton();
            this.btnAgregar = new Guna.UI.WinForms.GunaButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeccion2 = new System.Windows.Forms.Label();
            this.lblMayorOmenor = new System.Windows.Forms.Label();
            this.lblSeccion1 = new System.Windows.Forms.Label();
            this.lblUltimoCodigoModuloRegistrado = new System.Windows.Forms.Label();
            this.txtUltimoCodigoMaterialRegistrado = new Guna.UI.WinForms.GunaTextBox();
            this.txtDescripcionMaterial = new Guna.UI.WinForms.GunaTextBox();
            this.txtCodigoMaterial = new Guna.UI.WinForms.GunaTextBox();
            this.dgvDatosMateriales = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblVerificacionCodigoMaterial = new System.Windows.Forms.Label();
            this.cbxSoloCodigo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTipo
            // 
            this.cbxTipo.BackColor = System.Drawing.Color.Transparent;
            this.cbxTipo.BaseColor = System.Drawing.Color.White;
            this.cbxTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.cbxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FocusedColor = System.Drawing.Color.Empty;
            this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(99, 301);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxTipo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxTipo.Radius = 10;
            this.cbxTipo.Size = new System.Drawing.Size(293, 26);
            this.cbxTipo.TabIndex = 41;
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.Color.Transparent;
            this.cbxEstado.BaseColor = System.Drawing.Color.White;
            this.cbxEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.cbxEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FocusedColor = System.Drawing.Color.Empty;
            this.cbxEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Selecciona Estado",
            "Nuevo",
            "bueno",
            "regular",
            "por reparar"});
            this.cbxEstado.Location = new System.Drawing.Point(99, 234);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxEstado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxEstado.Radius = 10;
            this.cbxEstado.Size = new System.Drawing.Size(293, 26);
            this.cbxEstado.TabIndex = 40;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(814, 389);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.SkyBlue;
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 15;
            this.btnEliminar.Size = new System.Drawing.Size(94, 34);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AnimationHoverSpeed = 0.07F;
            this.btnModificar.AnimationSpeed = 0.03F;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnModificar.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificar.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = null;
            this.btnModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificar.Location = new System.Drawing.Point(685, 389);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.SkyBlue;
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Radius = 15;
            this.btnModificar.Size = new System.Drawing.Size(94, 34);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AnimationHoverSpeed = 0.07F;
            this.btnAgregar.AnimationSpeed = 0.03F;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = null;
            this.btnAgregar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregar.Location = new System.Drawing.Point(560, 389);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnHoverBaseColor = System.Drawing.Color.SkyBlue;
            this.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnHoverImage = null;
            this.btnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregar.Radius = 15;
            this.btnAgregar.Size = new System.Drawing.Size(94, 34);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(433, 389);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OnHoverBaseColor = System.Drawing.Color.SkyBlue;
            this.btnNuevo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevo.OnHoverImage = null;
            this.btnNuevo.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevo.Radius = 15;
            this.btnNuevo.Size = new System.Drawing.Size(94, 34);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.label5.Location = new System.Drawing.Point(104, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.label4.Location = new System.Drawing.Point(104, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.label3.Location = new System.Drawing.Point(104, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(104, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Codigo:";
            // 
            // lblSeccion2
            // 
            this.lblSeccion2.AutoSize = true;
            this.lblSeccion2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.lblSeccion2.Location = new System.Drawing.Point(227, 427);
            this.lblSeccion2.Name = "lblSeccion2";
            this.lblSeccion2.Size = new System.Drawing.Size(60, 22);
            this.lblSeccion2.TabIndex = 32;
            this.lblSeccion2.Text = "label3";
            // 
            // lblMayorOmenor
            // 
            this.lblMayorOmenor.AutoSize = true;
            this.lblMayorOmenor.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayorOmenor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.lblMayorOmenor.Location = new System.Drawing.Point(161, 427);
            this.lblMayorOmenor.Name = "lblMayorOmenor";
            this.lblMayorOmenor.Size = new System.Drawing.Size(60, 22);
            this.lblMayorOmenor.TabIndex = 33;
            this.lblMayorOmenor.Text = "label3";
            // 
            // lblSeccion1
            // 
            this.lblSeccion1.AutoSize = true;
            this.lblSeccion1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.lblSeccion1.Location = new System.Drawing.Point(95, 427);
            this.lblSeccion1.Name = "lblSeccion1";
            this.lblSeccion1.Size = new System.Drawing.Size(60, 22);
            this.lblSeccion1.TabIndex = 34;
            this.lblSeccion1.Text = "label3";
            // 
            // lblUltimoCodigoModuloRegistrado
            // 
            this.lblUltimoCodigoModuloRegistrado.AutoSize = true;
            this.lblUltimoCodigoModuloRegistrado.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoCodigoModuloRegistrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.lblUltimoCodigoModuloRegistrado.Location = new System.Drawing.Point(332, 356);
            this.lblUltimoCodigoModuloRegistrado.Name = "lblUltimoCodigoModuloRegistrado";
            this.lblUltimoCodigoModuloRegistrado.Size = new System.Drawing.Size(60, 22);
            this.lblUltimoCodigoModuloRegistrado.TabIndex = 35;
            this.lblUltimoCodigoModuloRegistrado.Text = "label3";
            // 
            // txtUltimoCodigoMaterialRegistrado
            // 
            this.txtUltimoCodigoMaterialRegistrado.BackColor = System.Drawing.Color.Transparent;
            this.txtUltimoCodigoMaterialRegistrado.BaseColor = System.Drawing.Color.White;
            this.txtUltimoCodigoMaterialRegistrado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.txtUltimoCodigoMaterialRegistrado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUltimoCodigoMaterialRegistrado.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUltimoCodigoMaterialRegistrado.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtUltimoCodigoMaterialRegistrado.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtUltimoCodigoMaterialRegistrado.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoCodigoMaterialRegistrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtUltimoCodigoMaterialRegistrado.Location = new System.Drawing.Point(99, 356);
            this.txtUltimoCodigoMaterialRegistrado.Name = "txtUltimoCodigoMaterialRegistrado";
            this.txtUltimoCodigoMaterialRegistrado.PasswordChar = '\0';
            this.txtUltimoCodigoMaterialRegistrado.Radius = 12;
            this.txtUltimoCodigoMaterialRegistrado.SelectedText = "";
            this.txtUltimoCodigoMaterialRegistrado.Size = new System.Drawing.Size(193, 26);
            this.txtUltimoCodigoMaterialRegistrado.TabIndex = 25;
            // 
            // txtDescripcionMaterial
            // 
            this.txtDescripcionMaterial.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcionMaterial.BaseColor = System.Drawing.Color.White;
            this.txtDescripcionMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.txtDescripcionMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionMaterial.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescripcionMaterial.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtDescripcionMaterial.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtDescripcionMaterial.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtDescripcionMaterial.Location = new System.Drawing.Point(99, 166);
            this.txtDescripcionMaterial.Name = "txtDescripcionMaterial";
            this.txtDescripcionMaterial.PasswordChar = '\0';
            this.txtDescripcionMaterial.Radius = 12;
            this.txtDescripcionMaterial.SelectedText = "";
            this.txtDescripcionMaterial.Size = new System.Drawing.Size(293, 26);
            this.txtDescripcionMaterial.TabIndex = 26;
            this.txtDescripcionMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescripcionMaterial.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcionMaterial_Validating);
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigoMaterial.BaseColor = System.Drawing.Color.White;
            this.txtCodigoMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.txtCodigoMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoMaterial.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCodigoMaterial.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtCodigoMaterial.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtCodigoMaterial.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.txtCodigoMaterial.Location = new System.Drawing.Point(99, 100);
            this.txtCodigoMaterial.MaxLength = 9;
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtCodigoMaterial.PasswordChar = '\0';
            this.txtCodigoMaterial.Radius = 12;
            this.txtCodigoMaterial.SelectedText = "";
            this.txtCodigoMaterial.Size = new System.Drawing.Size(293, 26);
            this.txtCodigoMaterial.TabIndex = 27;
            this.txtCodigoMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoMaterial.Enter += new System.EventHandler(this.txtCodigoMaterial_Enter);
            this.txtCodigoMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoMaterial_KeyPress);
            this.txtCodigoMaterial.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoMaterial_Validating);
            // 
            // dgvDatosMateriales
            // 
            this.dgvDatosMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosMateriales.Location = new System.Drawing.Point(427, 75);
            this.dgvDatosMateriales.Name = "dgvDatosMateriales";
            this.dgvDatosMateriales.Size = new System.Drawing.Size(487, 303);
            this.dgvDatosMateriales.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(312, -7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 42);
            this.label2.TabIndex = 23;
            this.label2.Text = "REGISTRAR MATERIAL";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblVerificacionCodigoMaterial
            // 
            this.lblVerificacionCodigoMaterial.AutoSize = true;
            this.lblVerificacionCodigoMaterial.Location = new System.Drawing.Point(105, 128);
            this.lblVerificacionCodigoMaterial.Name = "lblVerificacionCodigoMaterial";
            this.lblVerificacionCodigoMaterial.Size = new System.Drawing.Size(35, 13);
            this.lblVerificacionCodigoMaterial.TabIndex = 42;
            this.lblVerificacionCodigoMaterial.Text = "label6";
            // 
            // cbxSoloCodigo
            // 
            this.cbxSoloCodigo.FormattingEnabled = true;
            this.cbxSoloCodigo.Location = new System.Drawing.Point(444, 267);
            this.cbxSoloCodigo.Name = "cbxSoloCodigo";
            this.cbxSoloCodigo.Size = new System.Drawing.Size(121, 21);
            this.cbxSoloCodigo.TabIndex = 43;
            // 
            // RegistroMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 458);
            this.Controls.Add(this.lblVerificacionCodigoMaterial);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeccion2);
            this.Controls.Add(this.lblMayorOmenor);
            this.Controls.Add(this.lblSeccion1);
            this.Controls.Add(this.lblUltimoCodigoModuloRegistrado);
            this.Controls.Add(this.txtUltimoCodigoMaterialRegistrado);
            this.Controls.Add(this.txtDescripcionMaterial);
            this.Controls.Add(this.txtCodigoMaterial);
            this.Controls.Add(this.dgvDatosMateriales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSoloCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroMaterial";
            this.Text = "RegistroMaterial";
            this.Load += new System.EventHandler(this.RegistroMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cbxTipo;
        private Guna.UI.WinForms.GunaComboBox cbxEstado;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnModificar;
        private Guna.UI.WinForms.GunaButton btnAgregar;
        private Guna.UI.WinForms.GunaButton btnNuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeccion2;
        private System.Windows.Forms.Label lblMayorOmenor;
        private System.Windows.Forms.Label lblSeccion1;
        private System.Windows.Forms.Label lblUltimoCodigoModuloRegistrado;
        private Guna.UI.WinForms.GunaTextBox txtUltimoCodigoMaterialRegistrado;
        private Guna.UI.WinForms.GunaTextBox txtDescripcionMaterial;
        private Guna.UI.WinForms.GunaTextBox txtCodigoMaterial;
        private System.Windows.Forms.DataGridView dgvDatosMateriales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblVerificacionCodigoMaterial;
        private System.Windows.Forms.ComboBox cbxSoloCodigo;
    }
}