
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dgLlamadas = new System.Windows.Forms.DataGridView();
            btnIngresarPeriodo = new System.Windows.Forms.Button();
            dgEncuesta = new System.Windows.Forms.DataGridView();
            fechaInicioPer = new System.Windows.Forms.DateTimePicker();
            fechaFinPer = new System.Windows.Forms.DateTimePicker();
            btnImprimirCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgLlamadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgEncuesta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(338, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha Fin: ";
            // 
            // dgLlamadas
            // 
            dgLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLlamadas.Enabled = false;
            dgLlamadas.Location = new System.Drawing.Point(64, 118);
            dgLlamadas.Name = "dgLlamadas";
            dgLlamadas.RowTemplate.Height = 25;
            dgLlamadas.Size = new System.Drawing.Size(512, 352);
            dgLlamadas.TabIndex = 4;
            dgLlamadas.CellContentClick += dgLlamadas_CellContentClick;
            dgLlamadas.CellDoubleClick += seleccionarLlamada;
            // 
            // btnIngresarPeriodo
            // 
            btnIngresarPeriodo.Location = new System.Drawing.Point(654, 69);
            btnIngresarPeriodo.Name = "btnIngresarPeriodo";
            btnIngresarPeriodo.Size = new System.Drawing.Size(195, 23);
            btnIngresarPeriodo.TabIndex = 6;
            btnIngresarPeriodo.Text = "Filtrar Por Periodo";
            btnIngresarPeriodo.UseVisualStyleBackColor = true;
            btnIngresarPeriodo.Click += btnIngresarPeriodo_Click;
            // 
            // dgEncuesta
            // 
            dgEncuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEncuesta.Location = new System.Drawing.Point(606, 118);
            dgEncuesta.Name = "dgEncuesta";
            dgEncuesta.RowTemplate.Height = 25;
            dgEncuesta.Size = new System.Drawing.Size(431, 352);
            dgEncuesta.TabIndex = 7;
            dgEncuesta.CellContentClick += dataGridView1_CellContentClick;
            // 
            // fechaInicioPer
            // 
            fechaInicioPer.Location = new System.Drawing.Point(104, 69);
            fechaInicioPer.Name = "fechaInicioPer";
            fechaInicioPer.Size = new System.Drawing.Size(210, 23);
            fechaInicioPer.TabIndex = 8;
            fechaInicioPer.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // fechaFinPer
            // 
            fechaFinPer.Location = new System.Drawing.Point(407, 69);
            fechaFinPer.Name = "fechaFinPer";
            fechaFinPer.Size = new System.Drawing.Size(211, 23);
            fechaFinPer.TabIndex = 9;
            // 
            // btnImprimirCSV
            // 
            btnImprimirCSV.Location = new System.Drawing.Point(925, 509);
            btnImprimirCSV.Name = "btnImprimirCSV";
            btnImprimirCSV.Size = new System.Drawing.Size(112, 23);
            btnImprimirCSV.TabIndex = 10;
            btnImprimirCSV.Text = "Imprimir Encuesta";
            btnImprimirCSV.UseVisualStyleBackColor = true;
            btnImprimirCSV.Click += btnImprimirCSV_Click;
            // 
            // PantallaConsultarEncuesta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1086, 544);
            Controls.Add(btnImprimirCSV);
            Controls.Add(fechaFinPer);
            Controls.Add(fechaInicioPer);
            Controls.Add(dgEncuesta);
            Controls.Add(btnIngresarPeriodo);
            Controls.Add(dgLlamadas);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PantallaConsultarEncuesta";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Consultar   Encuesta";
            Load += PantallaConsultarEncuesta_Load;
            ((System.ComponentModel.ISupportInitialize)dgLlamadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgEncuesta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgLlamadas;
        private System.Windows.Forms.Button btnIngresarPeriodo;
        private System.Windows.Forms.DataGridView dgEncuesta;
        private System.Windows.Forms.DateTimePicker fechaInicioPer;
        private System.Windows.Forms.DateTimePicker fechaFinPer;
        private System.Windows.Forms.Button btnImprimirCSV;
    }
}