﻿namespace CuentasXCobrar.Cruds.Transacciones
{
    partial class FrmEditar_Transacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditar_Transacciones));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nupID = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.tipoMovimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCuentasxCobrarDataSet = new CuentasXCobrar.DBCuentasxCobrarDataSet();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tipoDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipoMovimientosTableAdapter = new CuentasXCobrar.DBCuentasxCobrarDataSetTableAdapters.TipoMovimientosTableAdapter();
            this.tipoDocumentosTableAdapter = new CuentasXCobrar.DBCuentasxCobrarDataSetTableAdapters.TipoDocumentosTableAdapter();
            this.clientesTableAdapter = new CuentasXCobrar.DBCuentasxCobrarDataSetTableAdapters.ClientesTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCuentasxCobrarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "- Agregar/Editar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Asimov Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transacciones";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.04852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.95148F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nupID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbxTipoMovimiento, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxTipoDocumento, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxCliente, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNumDoc, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpFecha, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtMonto, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.56583F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0056F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "IdMovimiento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de Movimiento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nupID
            // 
            this.nupID.Dock = System.Windows.Forms.DockStyle.Left;
            this.nupID.Location = new System.Drawing.Point(159, 3);
            this.nupID.Name = "nupID";
            this.nupID.Size = new System.Drawing.Size(178, 20);
            this.nupID.TabIndex = 4;
            this.nupID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupID.Validating += new System.ComponentModel.CancelEventHandler(this.nupID_Validating);
            this.nupID.Validated += new System.EventHandler(this.nupID_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de Documento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cliente";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Numero Documento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Monto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxTipoMovimiento
            // 
            this.cbxTipoMovimiento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoMovimientosBindingSource, "IdMovimiento", true));
            this.cbxTipoMovimiento.DataSource = this.tipoMovimientosBindingSource;
            this.cbxTipoMovimiento.DisplayMember = "Tipo";
            this.cbxTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxTipoMovimiento.FormattingEnabled = true;
            this.cbxTipoMovimiento.Location = new System.Drawing.Point(159, 30);
            this.cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            this.cbxTipoMovimiento.Size = new System.Drawing.Size(178, 21);
            this.cbxTipoMovimiento.TabIndex = 10;
            this.cbxTipoMovimiento.ValueMember = "IdMovimiento";
            this.cbxTipoMovimiento.Validating += new System.ComponentModel.CancelEventHandler(this.cbxTipoMovimiento_Validating);
            this.cbxTipoMovimiento.Validated += new System.EventHandler(this.cbxTipoMovimiento_Validated);
            // 
            // tipoMovimientosBindingSource
            // 
            this.tipoMovimientosBindingSource.DataMember = "TipoMovimientos";
            this.tipoMovimientosBindingSource.DataSource = this.dBCuentasxCobrarDataSet;
            // 
            // dBCuentasxCobrarDataSet
            // 
            this.dBCuentasxCobrarDataSet.DataSetName = "DBCuentasxCobrarDataSet";
            this.dBCuentasxCobrarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoDocumentosBindingSource, "IdDoc", true));
            this.cbxTipoDocumento.DataSource = this.tipoDocumentosBindingSource;
            this.cbxTipoDocumento.DisplayMember = "Descripcion";
            this.cbxTipoDocumento.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Location = new System.Drawing.Point(159, 56);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(178, 21);
            this.cbxTipoDocumento.TabIndex = 11;
            this.cbxTipoDocumento.ValueMember = "IdDoc";
            this.cbxTipoDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.cbxTipoDocumento_Validating);
            this.cbxTipoDocumento.Validated += new System.EventHandler(this.cbxTipoDocumento_Validated);
            // 
            // tipoDocumentosBindingSource
            // 
            this.tipoDocumentosBindingSource.DataMember = "TipoDocumentos";
            this.tipoDocumentosBindingSource.DataSource = this.dBCuentasxCobrarDataSet;
            // 
            // cbxCliente
            // 
            this.cbxCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientesBindingSource, "IdCliente", true));
            this.cbxCliente.DataSource = this.clientesBindingSource;
            this.cbxCliente.DisplayMember = "Nombre";
            this.cbxCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(159, 82);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(178, 21);
            this.cbxCliente.TabIndex = 12;
            this.cbxCliente.ValueMember = "IdCliente";
            this.cbxCliente.Validating += new System.ComponentModel.CancelEventHandler(this.cbxCliente_Validating);
            this.cbxCliente.Validated += new System.EventHandler(this.cbxCliente_Validated);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dBCuentasxCobrarDataSet;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNumDoc.Location = new System.Drawing.Point(159, 108);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(178, 20);
            this.txtNumDoc.TabIndex = 13;
            this.txtNumDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDoc_KeyPress);
            this.txtNumDoc.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumDoc_Validating);
            this.txtNumDoc.Validated += new System.EventHandler(this.txtNumDoc_Validated);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(159, 134);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(178, 20);
            this.dtpFecha.TabIndex = 14;
            this.dtpFecha.Value = new System.DateTime(2017, 6, 6, 0, 44, 33, 0);
            // 
            // txtMonto
            // 
            this.txtMonto.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMonto.Location = new System.Drawing.Point(159, 160);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(178, 20);
            this.txtMonto.TabIndex = 15;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.txtMonto.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonto_Validating);
            this.txtMonto.Validated += new System.EventHandler(this.txtMonto_Validated);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Location = new System.Drawing.Point(73, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 52);
            this.panel2.TabIndex = 12;
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
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::CuentasXCobrar.Properties.Resources.Cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(129, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 45);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 241);
            this.panel1.TabIndex = 11;
            // 
            // tipoMovimientosTableAdapter
            // 
            this.tipoMovimientosTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDocumentosTableAdapter
            // 
            this.tipoDocumentosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEditar_Transacciones
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(444, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditar_Transacciones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Editar";
            this.Load += new System.EventHandler(this.FrmEditar_Transacciones_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCuentasxCobrarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxTipoMovimiento;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private DBCuentasxCobrarDataSet dBCuentasxCobrarDataSet;
        private System.Windows.Forms.BindingSource tipoMovimientosBindingSource;
        private DBCuentasxCobrarDataSetTableAdapters.TipoMovimientosTableAdapter tipoMovimientosTableAdapter;
        private System.Windows.Forms.BindingSource tipoDocumentosBindingSource;
        private DBCuentasxCobrarDataSetTableAdapters.TipoDocumentosTableAdapter tipoDocumentosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DBCuentasxCobrarDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}