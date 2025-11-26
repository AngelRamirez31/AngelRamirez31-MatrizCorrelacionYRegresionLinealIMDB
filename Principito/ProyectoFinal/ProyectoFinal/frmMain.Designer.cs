namespace ProyectoFinal
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.btnCorrelacion = new System.Windows.Forms.Button();
            this.btnReg1 = new System.Windows.Forms.Button();
            this.btnReg2 = new System.Windows.Forms.Button();
            this.btnReg3 = new System.Windows.Forms.Button();
            this.btnReg4 = new System.Windows.Forms.Button();
            this.btnExplicarProyecto = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMain.Location = new System.Drawing.Point(106, 178);
            this.picMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(1126, 565);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // btnCorrelacion
            // 
            this.btnCorrelacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrelacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCorrelacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrelacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCorrelacion.ForeColor = System.Drawing.Color.White;
            this.btnCorrelacion.Location = new System.Drawing.Point(190, 40);
            this.btnCorrelacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnCorrelacion.Name = "btnCorrelacion";
            this.btnCorrelacion.Size = new System.Drawing.Size(180, 50);
            this.btnCorrelacion.TabIndex = 1;
            this.btnCorrelacion.Text = "Mapa de Calor (Correlación)";
            this.btnCorrelacion.UseVisualStyleBackColor = true;
            this.btnCorrelacion.Click += new System.EventHandler(this.btnCorrelacion_Click);
            // 
            // btnReg1
            // 
            this.btnReg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReg1.ForeColor = System.Drawing.Color.White;
            this.btnReg1.Location = new System.Drawing.Point(380, 40);
            this.btnReg1.Margin = new System.Windows.Forms.Padding(5);
            this.btnReg1.Name = "btnReg1";
            this.btnReg1.Size = new System.Drawing.Size(180, 50);
            this.btnReg1.TabIndex = 2;
            this.btnReg1.Text = "Ingresos vs Presupuesto";
            this.btnReg1.UseVisualStyleBackColor = true;
            this.btnReg1.Click += new System.EventHandler(this.btnReg1_Click);
            // 
            // btnReg2
            // 
            this.btnReg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReg2.ForeColor = System.Drawing.Color.White;
            this.btnReg2.Location = new System.Drawing.Point(570, 40);
            this.btnReg2.Margin = new System.Windows.Forms.Padding(5);
            this.btnReg2.Name = "btnReg2";
            this.btnReg2.Size = new System.Drawing.Size(180, 50);
            this.btnReg2.TabIndex = 3;
            this.btnReg2.Text = "Ingresos vs Calificación";
            this.btnReg2.UseVisualStyleBackColor = true;
            this.btnReg2.Click += new System.EventHandler(this.btnReg2_Click);
            // 
            // btnReg3
            // 
            this.btnReg3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReg3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReg3.ForeColor = System.Drawing.Color.White;
            this.btnReg3.Location = new System.Drawing.Point(760, 40);
            this.btnReg3.Margin = new System.Windows.Forms.Padding(5);
            this.btnReg3.Name = "btnReg3";
            this.btnReg3.Size = new System.Drawing.Size(180, 50);
            this.btnReg3.TabIndex = 4;
            this.btnReg3.Text = "Calificación vs Presupuesto";
            this.btnReg3.UseVisualStyleBackColor = true;
            this.btnReg3.Click += new System.EventHandler(this.btnReg3_Click);
            // 
            // btnReg4
            // 
            this.btnReg4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReg4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReg4.ForeColor = System.Drawing.Color.White;
            this.btnReg4.Location = new System.Drawing.Point(950, 40);
            this.btnReg4.Margin = new System.Windows.Forms.Padding(5);
            this.btnReg4.Name = "btnReg4";
            this.btnReg4.Size = new System.Drawing.Size(180, 50);
            this.btnReg4.TabIndex = 5;
            this.btnReg4.Text = "Ingresos vs Año de Estreno";
            this.btnReg4.UseVisualStyleBackColor = true;
            this.btnReg4.Click += new System.EventHandler(this.btnReg4_Click);
            // 
            // btnExplicarProyecto
            // 
            this.btnExplicarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExplicarProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExplicarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplicarProyecto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplicarProyecto.ForeColor = System.Drawing.Color.White;
            this.btnExplicarProyecto.Location = new System.Drawing.Point(25, 40);
            this.btnExplicarProyecto.Margin = new System.Windows.Forms.Padding(5);
            this.btnExplicarProyecto.Name = "btnExplicarProyecto";
            this.btnExplicarProyecto.Size = new System.Drawing.Size(160, 50);
            this.btnExplicarProyecto.TabIndex = 6;
            this.btnExplicarProyecto.Text = "ℹ️ Sobre el Proyecto";
            this.btnExplicarProyecto.UseVisualStyleBackColor = true;
            this.btnExplicarProyecto.Click += new System.EventHandler(this.btnExplicarProyecto_Click);
            // 
            // dgvDatos
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.Location = new System.Drawing.Point(106, 178);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1126, 565);
            this.dgvDatos.TabIndex = 7;
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDatos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVerDatos.ForeColor = System.Drawing.Color.White;
            this.btnVerDatos.Location = new System.Drawing.Point(1100, 40);
            this.btnVerDatos.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(160, 50);
            this.btnVerDatos.TabIndex = 8;
            this.btnVerDatos.Text = "📊 Ver Tabla de Datos";
            this.btnVerDatos.UseVisualStyleBackColor = true;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnVerDatos);
            this.panel1.Controls.Add(this.btnExplicarProyecto);
            this.panel1.Controls.Add(this.btnReg4);
            this.panel1.Controls.Add(this.btnCorrelacion);
            this.panel1.Controls.Add(this.btnReg3);
            this.panel1.Controls.Add(this.btnReg1);
            this.panel1.Controls.Add(this.btnReg2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 125);
            this.panel1.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1329, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDB Analytics Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Button btnCorrelacion;
        private System.Windows.Forms.Button btnReg1;
        private System.Windows.Forms.Button btnReg2;
        private System.Windows.Forms.Button btnReg3;
        private System.Windows.Forms.Button btnReg4;
        private System.Windows.Forms.Button btnExplicarProyecto;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnVerDatos;
        private System.Windows.Forms.Panel panel1;
    }
}

