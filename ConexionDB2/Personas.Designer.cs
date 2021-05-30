
namespace ConexionDB2
{
    partial class frmPersonas
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.txtbCorreo = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dtgPersonas = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(29, 92);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 21);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(29, 226);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 21);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(29, 193);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 21);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(29, 158);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(76, 21);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Location = new System.Drawing.Point(128, 226);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtbDireccion.TabIndex = 14;
            // 
            // txtbCorreo
            // 
            this.txtbCorreo.Location = new System.Drawing.Point(128, 193);
            this.txtbCorreo.Name = "txtbCorreo";
            this.txtbCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtbCorreo.TabIndex = 13;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(128, 158);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(100, 20);
            this.txtbApellido.TabIndex = 12;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(128, 123);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 11;
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(128, 92);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(100, 20);
            this.txtbID.TabIndex = 10;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(642, 366);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 34);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(408, 366);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 34);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(525, 366);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 34);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(291, 366);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(111, 34);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // dtgPersonas
            // 
            this.dtgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombre,
            this.clmApellido,
            this.clmCorreo,
            this.clmDireccion});
            this.dtgPersonas.Location = new System.Drawing.Point(234, 92);
            this.dtgPersonas.Name = "dtgPersonas";
            this.dtgPersonas.Size = new System.Drawing.Size(554, 268);
            this.dtgPersonas.TabIndex = 19;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmApellido
            // 
            this.clmApellido.HeaderText = "Apellido";
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.ReadOnly = true;
            // 
            // clmCorreo
            // 
            this.clmCorreo.HeaderText = "Correo";
            this.clmCorreo.Name = "clmCorreo";
            this.clmCorreo.ReadOnly = true;
            // 
            // clmDireccion
            // 
            this.clmDireccion.HeaderText = "Direccion";
            this.clmDireccion.Name = "clmDireccion";
            this.clmDireccion.ReadOnly = true;
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgPersonas);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.txtbCorreo);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Name = "frmPersonas";
            this.Text = "Personas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.TextBox txtbCorreo;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dtgPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
    }
}