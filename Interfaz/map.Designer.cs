namespace Interfaz
{
    partial class map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(map));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartCustomSettings = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboParticle = new System.Windows.Forms.ComboBox();
            this.comboDateStart = new System.Windows.Forms.ComboBox();
            this.comboDateFinish = new System.Windows.Forms.ComboBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartCustomSettings);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboParticle);
            this.groupBox1.Controls.Add(this.comboDateStart);
            this.groupBox1.Controls.Add(this.comboDateFinish);
            this.groupBox1.Controls.Add(this.buttonGo);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // StartCustomSettings
            // 
            this.StartCustomSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            this.StartCustomSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartCustomSettings.Location = new System.Drawing.Point(6, 251);
            this.StartCustomSettings.Name = "StartCustomSettings";
            this.StartCustomSettings.Size = new System.Drawing.Size(255, 23);
            this.StartCustomSettings.TabIndex = 6;
            this.StartCustomSettings.Text = "Start Custom Settings";
            this.StartCustomSettings.UseVisualStyleBackColor = false;
            this.StartCustomSettings.Click += new System.EventHandler(this.StartCustomSettingEvent);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 24);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Department";
            // 
            // comboParticle
            // 
            this.comboParticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.comboParticle.FormattingEnabled = true;
            this.comboParticle.Items.AddRange(new object[] {
            "PM10",
            "PM2.5"});
            this.comboParticle.Location = new System.Drawing.Point(6, 88);
            this.comboParticle.Name = "comboParticle";
            this.comboParticle.Size = new System.Drawing.Size(255, 25);
            this.comboParticle.TabIndex = 4;
            this.comboParticle.Text = "Kind of particle";
            // 
            // comboDateStart
            // 
            this.comboDateStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.comboDateStart.FormattingEnabled = true;
            this.comboDateStart.Location = new System.Drawing.Point(6, 139);
            this.comboDateStart.Name = "comboDateStart";
            this.comboDateStart.Size = new System.Drawing.Size(255, 25);
            this.comboDateStart.TabIndex = 3;
            this.comboDateStart.Text = "Date start";
            // 
            // comboDateFinish
            // 
            this.comboDateFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.comboDateFinish.FormattingEnabled = true;
            this.comboDateFinish.Location = new System.Drawing.Point(6, 192);
            this.comboDateFinish.Name = "comboDateFinish";
            this.comboDateFinish.Size = new System.Drawing.Size(255, 25);
            this.comboDateFinish.TabIndex = 2;
            this.comboDateFinish.Text = "Date finish";
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGo.Location = new System.Drawing.Point(6, 296);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(255, 23);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Start";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(308, 13);
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
            this.gmap.Size = new System.Drawing.Size(480, 425);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 0D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "map";
            this.Text = "map";
            this.Load += new System.EventHandler(this.map_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ComboBox comboParticle;
        private System.Windows.Forms.ComboBox comboDateStart;
        private System.Windows.Forms.ComboBox comboDateFinish;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StartCustomSettings;


    }
}