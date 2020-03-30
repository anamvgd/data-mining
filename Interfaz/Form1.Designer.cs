namespace Interfaz
{
    partial class Form1
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
            this.labelURL = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.urlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codeData = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.Label();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.filterAdded = new System.Windows.Forms.Label();
            this.dataFilter = new System.Windows.Forms.Label();
            this.filters = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(37, 70);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(86, 13);
            this.labelURL.TabIndex = 1;
            this.labelURL.Text = "Id base de datos";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(24, 403);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(140, 23);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "Buscar Base de Datos";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(129, 67);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(200, 20);
            this.urlText.TabIndex = 36;
            this.urlText.Text = "ysq6-ri4e";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Codigo Unico Datos";
            // 
            // codeData
            // 
            this.codeData.Location = new System.Drawing.Point(129, 116);
            this.codeData.Name = "codeData";
            this.codeData.Size = new System.Drawing.Size(200, 20);
            this.codeData.TabIndex = 38;
            this.codeData.Text = "oipJOeStVp83pvoG20CMSGiXe";
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Location = new System.Drawing.Point(61, 19);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(34, 13);
            this.filter.TabIndex = 39;
            this.filter.Text = "Filtros";
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(111, 19);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFilters.TabIndex = 40;
            // 
            // filterAdded
            // 
            this.filterAdded.AutoSize = true;
            this.filterAdded.Location = new System.Drawing.Point(24, 102);
            this.filterAdded.Name = "filterAdded";
            this.filterAdded.Size = new System.Drawing.Size(81, 13);
            this.filterAdded.TabIndex = 41;
            this.filterAdded.Text = "Filtros Añadidos";
            // 
            // dataFilter
            // 
            this.dataFilter.AutoSize = true;
            this.dataFilter.Location = new System.Drawing.Point(15, 62);
            this.dataFilter.Name = "dataFilter";
            this.dataFilter.Size = new System.Drawing.Size(80, 13);
            this.dataFilter.TabIndex = 42;
            this.dataFilter.Text = "Dato Para Filtro";
            // 
            // filters
            // 
            this.filters.AutoSize = true;
            this.filters.Location = new System.Drawing.Point(122, 101);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(49, 13);
            this.filters.TabIndex = 44;
            this.filters.Text = "Sin filtros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Buscar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchData);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(20, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(458, 169);
            this.dataGridView.TabIndex = 46;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selectCase);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 100);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base de datos ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Controls.Add(this.filters);
            this.groupBox3.Controls.Add(this.dataFilter);
            this.groupBox3.Controls.Add(this.filterAdded);
            this.groupBox3.Controls.Add(this.comboBoxFilters);
            this.groupBox3.Controls.Add(this.filter);
            this.groupBox3.Location = new System.Drawing.Point(12, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 240);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(317, 60);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(111, 62);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(200, 20);
            this.textBoxSearch.TabIndex = 45;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView);
            this.groupBox4.Location = new System.Drawing.Point(424, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(484, 204);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(424, 261);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 262);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informacion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(229, 447);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 23);
            this.deleteButton.TabIndex = 51;
            this.deleteButton.Text = "Eliminar filtros";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 575);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codeData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeData;
        private System.Windows.Forms.Label filter;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.Label filterAdded;
        private System.Windows.Forms.Label dataFilter;
        private System.Windows.Forms.Label filters;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

