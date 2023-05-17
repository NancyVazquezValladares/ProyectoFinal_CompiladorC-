namespace Compilador_C
{
    partial class Log
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
            this.DGWLog = new System.Windows.Forms.DataGridView();
            this.UsuarioCheck = new System.Windows.Forms.CheckBox();
            this.LenguajeCheck = new System.Windows.Forms.CheckBox();
            this.FechaCheck = new System.Windows.Forms.CheckBox();
            this.UsuarioText = new System.Windows.Forms.TextBox();
            this.LenguajeText = new System.Windows.Forms.TextBox();
            this.FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.FechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Excel = new System.Windows.Forms.PictureBox();
            this.Csv = new System.Windows.Forms.PictureBox();
            this.Txt = new System.Windows.Forms.PictureBox();
            this.Filtrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGWLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt)).BeginInit();
            this.SuspendLayout();
            // 
            // DGWLog
            // 
            this.DGWLog.AllowUserToAddRows = false;
            this.DGWLog.AllowUserToDeleteRows = false;
            this.DGWLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWLog.Location = new System.Drawing.Point(33, 171);
            this.DGWLog.Margin = new System.Windows.Forms.Padding(4);
            this.DGWLog.Name = "DGWLog";
            this.DGWLog.ReadOnly = true;
            this.DGWLog.Size = new System.Drawing.Size(629, 368);
            this.DGWLog.TabIndex = 0;
            this.DGWLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWLog_CellContentClick);
            // 
            // UsuarioCheck
            // 
            this.UsuarioCheck.AutoSize = true;
            this.UsuarioCheck.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioCheck.Location = new System.Drawing.Point(33, 90);
            this.UsuarioCheck.Margin = new System.Windows.Forms.Padding(4);
            this.UsuarioCheck.Name = "UsuarioCheck";
            this.UsuarioCheck.Size = new System.Drawing.Size(80, 27);
            this.UsuarioCheck.TabIndex = 2;
            this.UsuarioCheck.Text = "Usuario";
            this.UsuarioCheck.UseVisualStyleBackColor = true;
            // 
            // LenguajeCheck
            // 
            this.LenguajeCheck.AutoSize = true;
            this.LenguajeCheck.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LenguajeCheck.Location = new System.Drawing.Point(199, 90);
            this.LenguajeCheck.Margin = new System.Windows.Forms.Padding(4);
            this.LenguajeCheck.Name = "LenguajeCheck";
            this.LenguajeCheck.Size = new System.Drawing.Size(89, 27);
            this.LenguajeCheck.TabIndex = 3;
            this.LenguajeCheck.Text = "Lenguaje";
            this.LenguajeCheck.UseVisualStyleBackColor = true;
            // 
            // FechaCheck
            // 
            this.FechaCheck.AutoSize = true;
            this.FechaCheck.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCheck.Location = new System.Drawing.Point(352, 90);
            this.FechaCheck.Margin = new System.Windows.Forms.Padding(4);
            this.FechaCheck.Name = "FechaCheck";
            this.FechaCheck.Size = new System.Drawing.Size(69, 27);
            this.FechaCheck.TabIndex = 4;
            this.FechaCheck.Text = "Fecha";
            this.FechaCheck.UseVisualStyleBackColor = true;
            // 
            // UsuarioText
            // 
            this.UsuarioText.Location = new System.Drawing.Point(33, 118);
            this.UsuarioText.Margin = new System.Windows.Forms.Padding(4);
            this.UsuarioText.Name = "UsuarioText";
            this.UsuarioText.Size = new System.Drawing.Size(132, 22);
            this.UsuarioText.TabIndex = 5;
            // 
            // LenguajeText
            // 
            this.LenguajeText.Location = new System.Drawing.Point(199, 118);
            this.LenguajeText.Margin = new System.Windows.Forms.Padding(4);
            this.LenguajeText.Name = "LenguajeText";
            this.LenguajeText.Size = new System.Drawing.Size(132, 22);
            this.LenguajeText.TabIndex = 6;
            // 
            // FechaInicio
            // 
            this.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicio.Location = new System.Drawing.Point(352, 119);
            this.FechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(107, 22);
            this.FechaInicio.TabIndex = 7;
            // 
            // FechaFin
            // 
            this.FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFin.Location = new System.Drawing.Point(468, 119);
            this.FechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Size = new System.Drawing.Size(107, 22);
            this.FechaFin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "TXT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "CSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(565, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Excel";
            // 
            // Excel
            // 
            this.Excel.BackColor = System.Drawing.Color.Lime;
            this.Excel.Location = new System.Drawing.Point(483, 15);
            this.Excel.Margin = new System.Windows.Forms.Padding(4);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(73, 62);
            this.Excel.TabIndex = 11;
            this.Excel.TabStop = false;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // Csv
            // 
            this.Csv.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Csv.Location = new System.Drawing.Point(308, 15);
            this.Csv.Margin = new System.Windows.Forms.Padding(4);
            this.Csv.Name = "Csv";
            this.Csv.Size = new System.Drawing.Size(73, 62);
            this.Csv.TabIndex = 10;
            this.Csv.TabStop = false;
            this.Csv.Click += new System.EventHandler(this.Csv_Click);
            // 
            // Txt
            // 
            this.Txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txt.Location = new System.Drawing.Point(80, 16);
            this.Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(73, 62);
            this.Txt.TabIndex = 9;
            this.Txt.TabStop = false;
            this.Txt.Click += new System.EventHandler(this.Txt_Click);
            // 
            // Filtrar
            // 
            this.Filtrar.BackColor = System.Drawing.Color.Transparent;
            this.Filtrar.BackgroundImage = global::Compilador_C.Properties.Resources.aplicar;
            this.Filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filtrar.Location = new System.Drawing.Point(584, 90);
            this.Filtrar.Margin = new System.Windows.Forms.Padding(4);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(78, 60);
            this.Filtrar.TabIndex = 1;
            this.Filtrar.UseVisualStyleBackColor = false;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.Csv);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.FechaFin);
            this.Controls.Add(this.FechaInicio);
            this.Controls.Add(this.LenguajeText);
            this.Controls.Add(this.UsuarioText);
            this.Controls.Add(this.FechaCheck);
            this.Controls.Add(this.LenguajeCheck);
            this.Controls.Add(this.UsuarioCheck);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.DGWLog);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Log";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGWLog;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.CheckBox UsuarioCheck;
        private System.Windows.Forms.CheckBox LenguajeCheck;
        private System.Windows.Forms.CheckBox FechaCheck;
        private System.Windows.Forms.TextBox UsuarioText;
        private System.Windows.Forms.TextBox LenguajeText;
        private System.Windows.Forms.DateTimePicker FechaInicio;
        private System.Windows.Forms.DateTimePicker FechaFin;
        private System.Windows.Forms.PictureBox Txt;
        private System.Windows.Forms.PictureBox Csv;
        private System.Windows.Forms.PictureBox Excel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}