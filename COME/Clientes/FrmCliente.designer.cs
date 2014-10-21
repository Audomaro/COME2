namespace COME.Clientes
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.TxtClave = new DevExpress.XtraEditors.TextEdit();
            this.LbClave = new DevExpress.XtraEditors.LabelControl();
            this.LbDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.TxtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.BtnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtClave
            // 
            this.TxtClave.EnterMoveNextControl = true;
            this.TxtClave.Location = new System.Drawing.Point(77, 16);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Properties.MaxLength = 50;
            this.TxtClave.Size = new System.Drawing.Size(179, 20);
            this.TxtClave.TabIndex = 1;
            // 
            // LbClave
            // 
            this.LbClave.Location = new System.Drawing.Point(40, 19);
            this.LbClave.Name = "LbClave";
            this.LbClave.Size = new System.Drawing.Size(31, 13);
            this.LbClave.TabIndex = 0;
            this.LbClave.Text = "Clave:";
            // 
            // LbDescripcion
            // 
            this.LbDescripcion.Location = new System.Drawing.Point(13, 45);
            this.LbDescripcion.Name = "LbDescripcion";
            this.LbDescripcion.Size = new System.Drawing.Size(58, 13);
            this.LbDescripcion.TabIndex = 0;
            this.LbDescripcion.Text = "Descripción:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.EnterMoveNextControl = true;
            this.TxtDescripcion.Location = new System.Drawing.Point(77, 42);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Properties.MaxLength = 50;
            this.TxtDescripcion.Size = new System.Drawing.Size(179, 20);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(76, 68);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(87, 23);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(169, 68);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(87, 23);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 100);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LbDescripcion);
            this.Controls.Add(this.LbClave);
            this.Controls.Add(this.TxtClave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtClave;
        private DevExpress.XtraEditors.LabelControl LbClave;
        private DevExpress.XtraEditors.LabelControl LbDescripcion;
        private DevExpress.XtraEditors.TextEdit TxtDescripcion;
        private DevExpress.XtraEditors.SimpleButton BtnCancelar;
        private DevExpress.XtraEditors.SimpleButton BtnGuardar;
    }
}