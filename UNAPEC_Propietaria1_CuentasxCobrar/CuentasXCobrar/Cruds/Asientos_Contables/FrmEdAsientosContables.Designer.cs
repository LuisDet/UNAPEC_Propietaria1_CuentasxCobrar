namespace CuentasXCobrar.Cruds.Asientos_Contables
{
    partial class FrmEdAsientosContables
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCuentasxCobrarDataSet = new CuentasXCobrar.DBCuentasxCobrarDataSet();
            this.cbxTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.tipoMovimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lable10 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new CuentasXCobrar.DBCuentasxCobrarDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new CuentasXCobrar.DBCuentasxCobrarDataSetTableAdapters.TableAdapterManager();
            this.asientos_ContablesTableAdapter = new CuentasXCobrar.DBCuentasxCobrarDataSetTableAdapters.Asientos_ContablesTableAdapter();
            this.tipoMovimientosTableAdapter = new CuentasXCobrar.DBCuentasxCobrarDataSetTableAdapters.TipoMovimientosTableAdapter();
            this.asientosContablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCuentasxCobrarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimientosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asientosContablesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.04852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.95148F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxClientes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxTipoMovimiento, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpFecha, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMonto, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lable10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbxEstado, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCuenta, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.39289F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72409F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 184);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de Movimiento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cuenta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 30);
            this.label9.TabIndex = 9;
            this.label9.Text = "Monto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxClientes
            // 
            this.cbxClientes.DataSource = this.clientesBindingSource;
            this.cbxClientes.DisplayMember = "Nombre";
            this.cbxClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(159, 3);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(209, 21);
            this.cbxClientes.TabIndex = 10;
            this.cbxClientes.ValueMember = "IdCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dBCuentasxCobrarDataSet;
            // 
            // dBCuentasxCobrarDataSet
            // 
            this.dBCuentasxCobrarDataSet.DataSetName = "DBCuentasxCobrarDataSet";
            this.dBCuentasxCobrarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxTipoMovimiento
            // 
            this.cbxTipoMovimiento.DataSource = this.tipoMovimientosBindingSource;
            this.cbxTipoMovimiento.DisplayMember = "Tipo";
            this.cbxTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxTipoMovimiento.FormattingEnabled = true;
            this.cbxTipoMovimiento.Location = new System.Drawing.Point(159, 33);
            this.cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            this.cbxTipoMovimiento.Size = new System.Drawing.Size(209, 21);
            this.cbxTipoMovimiento.TabIndex = 11;
            this.cbxTipoMovimiento.ValueMember = "IdMovimiento";
            // 
            // tipoMovimientosBindingSource
            // 
            this.tipoMovimientosBindingSource.DataMember = "TipoMovimientos";
            this.tipoMovimientosBindingSource.DataSource = this.dBCuentasxCobrarDataSet;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(159, 93);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(209, 20);
            this.dtpFecha.TabIndex = 14;
            this.dtpFecha.Value = new System.DateTime(2017, 6, 6, 0, 44, 33, 0);
            // 
            // txtMonto
            // 
            this.txtMonto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMonto.Location = new System.Drawing.Point(159, 123);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(209, 20);
            this.txtMonto.TabIndex = 15;
            // 
            // lable10
            // 
            this.lable10.AutoSize = true;
            this.lable10.Dock = System.Windows.Forms.DockStyle.Right;
            this.lable10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable10.Location = new System.Drawing.Point(98, 150);
            this.lable10.Name = "lable10";
            this.lable10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lable10.Size = new System.Drawing.Size(55, 34);
            this.lable10.TabIndex = 16;
            this.lable10.Text = "Estado";
            this.lable10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lable10.Click += new System.EventHandler(this.lable10_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbxEstado.Location = new System.Drawing.Point(159, 153);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(208, 21);
            this.cbxEstado.TabIndex = 17;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(159, 63);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(209, 20);
            this.txtCuenta.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(73, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 241);
            this.panel1.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::CuentasXCobrar.Properties.Resources.Guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(37, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(45, 45);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::CuentasXCobrar.Properties.Resources.Cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(129, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 45);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::CuentasXCobrar.Properties.Resources.Borrar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(226, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 45);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Location = new System.Drawing.Point(134, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 52);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Asientos Contables";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "- Agregar/Editar";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Asientos_ContablesTableAdapter = this.asientos_ContablesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalancesTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.TipoDocumentosTableAdapter = null;
            this.tableAdapterManager.TipoMovimientosTableAdapter = this.tipoMovimientosTableAdapter;
            this.tableAdapterManager.TransaccionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CuentasXCobrar.DBCuentasxCobrarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // asientos_ContablesTableAdapter
            // 
            this.asientos_ContablesTableAdapter.ClearBeforeFill = true;
            // 
            // tipoMovimientosTableAdapter
            // 
            this.tipoMovimientosTableAdapter.ClearBeforeFill = true;
            // 
            // asientosContablesBindingSource
            // 
            this.asientosContablesBindingSource.DataMember = "Asientos_Contables";
            this.asientosContablesBindingSource.DataSource = this.dBCuentasxCobrarDataSet;
            // 
            // FrmEdAsientosContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdAsientosContables";
            this.Text = "FrmEdAsientosContables";
            this.Load += new System.EventHandler(this.FrmEdAsientosContables_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCuentasxCobrarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimientosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.asientosContablesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.ComboBox cbxTipoMovimiento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DBCuentasxCobrarDataSet dBCuentasxCobrarDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DBCuentasxCobrarDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private DBCuentasxCobrarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DBCuentasxCobrarDataSetTableAdapters.TipoMovimientosTableAdapter tipoMovimientosTableAdapter;
        private System.Windows.Forms.BindingSource tipoMovimientosBindingSource;
        private System.Windows.Forms.Label lable10;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtCuenta;
        private DBCuentasxCobrarDataSetTableAdapters.Asientos_ContablesTableAdapter asientos_ContablesTableAdapter;
        private System.Windows.Forms.BindingSource asientosContablesBindingSource;
    }
}