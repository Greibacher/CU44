
namespace CU44
{
    partial class PantallaConsultarEncuesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaConsultarEncuesta));
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgLlamadas = new System.Windows.Forms.DataGridView();
            this.btnIngresarPeriodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLlamadas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(143, 61);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.PlaceholderText = "DD/MM/YYYY";
            this.txtFechaInicio.Size = new System.Drawing.Size(100, 23);
            this.txtFechaInicio.TabIndex = 0;
            this.txtFechaInicio.TextChanged += new System.EventHandler(this.validarFecha);
            this.txtFechaInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDatosFecha);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(401, 61);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.PlaceholderText = "DD/MM/YYYY";
            this.txtFechaFin.Size = new System.Drawing.Size(100, 23);
            this.txtFechaFin.TabIndex = 1;
            this.txtFechaFin.TextChanged += new System.EventHandler(this.validarFecha);
            this.txtFechaFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDatosFecha);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Fin: ";
            // 
            // dgLlamadas
            // 
            this.dgLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLlamadas.Location = new System.Drawing.Point(64, 105);
            this.dgLlamadas.Name = "dgLlamadas";
            this.dgLlamadas.RowTemplate.Height = 25;
            this.dgLlamadas.Size = new System.Drawing.Size(918, 427);
            this.dgLlamadas.TabIndex = 4;
            // 
            // btnIngresarPeriodo
            // 
            this.btnIngresarPeriodo.Location = new System.Drawing.Point(584, 61);
            this.btnIngresarPeriodo.Name = "btnIngresarPeriodo";
            this.btnIngresarPeriodo.Size = new System.Drawing.Size(195, 23);
            this.btnIngresarPeriodo.TabIndex = 6;
            this.btnIngresarPeriodo.Text = "Filtrar Por Periodo";
            this.btnIngresarPeriodo.UseVisualStyleBackColor = true;
            this.btnIngresarPeriodo.Click += new System.EventHandler(this.btnIngresarPeriodo_Click);
            // 
            // PantallaConsultarEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1086, 544);
            this.Controls.Add(this.btnIngresarPeriodo);
            this.Controls.Add(this.dgLlamadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaConsultarEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar   Encuesta";
            ((System.ComponentModel.ISupportInitialize)(this.dgLlamadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgLlamadas;
        private System.Windows.Forms.Button btnIngresarPeriodo;
    }
}