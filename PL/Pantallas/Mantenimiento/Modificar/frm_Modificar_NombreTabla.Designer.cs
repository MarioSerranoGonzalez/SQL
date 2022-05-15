namespace PL.Pantallas.Mantenimiento.Modificar
{
    partial class frm_Modificar_NombreTabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Modificar_NombreTabla));
            this.tls_Principal = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tlc_btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tls_btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tls_Principal
            // 
            this.tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tlc_btn_Guardar,
            this.toolStripSeparator3,
            this.toolStripLabel6,
            this.tls_btn_Salir});
            this.tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.tls_Principal.Name = "tls_Principal";
            this.tls_Principal.Size = new System.Drawing.Size(976, 39);
            this.tls_Principal.TabIndex = 2;
            this.tls_Principal.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 36);
            this.toolStripLabel1.Text = "Guardar";
            // 
            // tlc_btn_Guardar
            // 
            this.tlc_btn_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlc_btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("tlc_btn_Guardar.Image")));
            this.tlc_btn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlc_btn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlc_btn_Guardar.Name = "tlc_btn_Guardar";
            this.tlc_btn_Guardar.Size = new System.Drawing.Size(36, 36);
            this.tlc_btn_Guardar.Text = "toolStripButton1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(29, 36);
            this.toolStripLabel6.Text = "Salir";
            // 
            // tls_btn_Salir
            // 
            this.tls_btn_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("tls_btn_Salir.Image")));
            this.tls_btn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_Salir.Name = "tls_btn_Salir";
            this.tls_btn_Salir.Size = new System.Drawing.Size(36, 36);
            this.tls_btn_Salir.Text = "toolStripButton1";
            this.tls_btn_Salir.Click += new System.EventHandler(this.tls_btn_Salir_Click);
            // 
            // frm_Modificar_NombreTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.tls_Principal);
            this.Name = "frm_Modificar_NombreTabla";
            this.Text = "frm_Modificar_NombreTabla";
            this.tls_Principal.ResumeLayout(false);
            this.tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tls_Principal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tlc_btn_Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton tls_btn_Salir;
    }
}