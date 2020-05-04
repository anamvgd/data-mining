namespace map
{
    partial class mapSimulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mapSimulation));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.kindParticle = new System.Windows.Forms.ComboBox();
            this.dStart = new System.Windows.Forms.ComboBox();
            this.dEnd = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(275, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(613, 473);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 0D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dEnd);
            this.groupBox1.Controls.Add(this.dStart);
            this.groupBox1.Controls.Add(this.kindParticle);
            this.groupBox1.Controls.Add(this.department);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 473);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(6, 35);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(228, 21);
            this.department.TabIndex = 0;
            this.department.Text = "Department";
            // 
            // kindParticle
            // 
            this.kindParticle.FormattingEnabled = true;
            this.kindParticle.Location = new System.Drawing.Point(6, 92);
            this.kindParticle.Name = "kindParticle";
            this.kindParticle.Size = new System.Drawing.Size(228, 21);
            this.kindParticle.TabIndex = 1;
            this.kindParticle.Text = "Kind of particle";
            // 
            // dStart
            // 
            this.dStart.FormattingEnabled = true;
            this.dStart.Location = new System.Drawing.Point(6, 142);
            this.dStart.Name = "dStart";
            this.dStart.Size = new System.Drawing.Size(228, 21);
            this.dStart.TabIndex = 2;
            this.dStart.Text = "Date start";
            this.dStart.MouseCaptureChanged += new System.EventHandler(this.dateStartChoice);
            // 
            // dEnd
            // 
            this.dEnd.FormattingEnabled = true;
            this.dEnd.Location = new System.Drawing.Point(6, 192);
            this.dEnd.Name = "dEnd";
            this.dEnd.Size = new System.Drawing.Size(227, 21);
            this.dEnd.TabIndex = 3;
            this.dEnd.Text = "Date finish";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(889, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gmap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Map simulation";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dEnd;
        private System.Windows.Forms.ComboBox dStart;
        private System.Windows.Forms.ComboBox kindParticle;
        private System.Windows.Forms.ComboBox department;
    }
}

