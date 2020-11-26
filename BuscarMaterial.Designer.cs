namespace SistemaPrestamoUSP
{
    partial class BuscarMaterial
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
            this.dgvDatosBusquedaMaterial = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new Guna.UI.WinForms.GunaButton();
            this.btnMinimizar = new Guna.UI.WinForms.GunaButton();
            this.cbxTipoMaterial = new Guna.UI.WinForms.GunaComboBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBusquedaMaterial)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosBusquedaMaterial
            // 
            this.dgvDatosBusquedaMaterial.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDatosBusquedaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosBusquedaMaterial.Location = new System.Drawing.Point(56, 219);
            this.dgvDatosBusquedaMaterial.Name = "dgvDatosBusquedaMaterial";
            this.dgvDatosBusquedaMaterial.RowHeadersVisible = false;
            this.dgvDatosBusquedaMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosBusquedaMaterial.Size = new System.Drawing.Size(434, 281);
            this.dgvDatosBusquedaMaterial.TabIndex = 70;
            this.dgvDatosBusquedaMaterial.DoubleClick += new System.EventHandler(this.dgvDatosBusquedaMaterial_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.label9.Location = new System.Drawing.Point(148, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.label8.Location = new System.Drawing.Point(130, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 40);
            this.label8.TabIndex = 64;
            this.label8.Text = "BUSCAR MATERIAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 38);
            this.panel1.TabIndex = 75;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AnimationHoverSpeed = 0.07F;
            this.btnCerrar.AnimationSpeed = 0.03F;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(214)))), ((int)(((byte)(32)))));
            this.btnCerrar.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerrar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnCerrar.Image = null;
            this.btnCerrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCerrar.Location = new System.Drawing.Point(522, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCerrar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Radius = 11;
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AnimationHoverSpeed = 0.07F;
            this.btnMinimizar.AnimationSpeed = 0.03F;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(214)))), ((int)(((byte)(32)))));
            this.btnMinimizar.BorderColor = System.Drawing.Color.Black;
            this.btnMinimizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimizar.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnMinimizar.Image = null;
            this.btnMinimizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMinimizar.Location = new System.Drawing.Point(491, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMinimizar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(91)))), ((int)(((byte)(164)))));
            this.btnMinimizar.OnHoverImage = null;
            this.btnMinimizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimizar.Radius = 11;
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxTipoMaterial
            // 
            this.cbxTipoMaterial.BackColor = System.Drawing.Color.Transparent;
            this.cbxTipoMaterial.BaseColor = System.Drawing.Color.White;
            this.cbxTipoMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.cbxTipoMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoMaterial.FocusedColor = System.Drawing.Color.Empty;
            this.cbxTipoMaterial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTipoMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.cbxTipoMaterial.FormattingEnabled = true;
            this.cbxTipoMaterial.Location = new System.Drawing.Point(210, 152);
            this.cbxTipoMaterial.Name = "cbxTipoMaterial";
            this.cbxTipoMaterial.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxTipoMaterial.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxTipoMaterial.Radius = 10;
            this.cbxTipoMaterial.Size = new System.Drawing.Size(188, 26);
            this.cbxTipoMaterial.TabIndex = 84;
            this.cbxTipoMaterial.SelectedIndexChanged += new System.EventHandler(this.cbxTipoMaterial_SelectedIndexChanged);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // BuscarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 554);
            this.Controls.Add(this.cbxTipoMaterial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosBusquedaMaterial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarMaterial";
            this.Text = "BuscarMaterial";
            this.Load += new System.EventHandler(this.BuscarMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBusquedaMaterial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatosBusquedaMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnCerrar;
        private Guna.UI.WinForms.GunaButton btnMinimizar;
        private Guna.UI.WinForms.GunaComboBox cbxTipoMaterial;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}