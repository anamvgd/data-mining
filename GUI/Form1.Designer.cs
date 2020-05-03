using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
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
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.filters = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = false;
            this.labelURL.Location = new System.Drawing.Point(84, 74);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(29, 13);
            this.labelURL.TabIndex = 1;
            this.labelURL.Text = "URL";
            this.labelURL.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(87, 393);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 23);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "Cargar Datos";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(129, 67);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(200, 20);
            this.urlText.TabIndex = 36;
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
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Location = new System.Drawing.Point(78, 167);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(34, 13);
            this.filter.TabIndex = 39;
            this.filter.Text = "Filtros";
            this.filter.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(129, 167);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFilters.TabIndex = 40;
            // 
            // filterAdded
            // 
            this.filterAdded.AutoSize = true;
            this.filterAdded.Location = new System.Drawing.Point(42, 259);
            this.filterAdded.Name = "filterAdded";
            this.filterAdded.Size = new System.Drawing.Size(81, 13);
            this.filterAdded.TabIndex = 41;
            this.filterAdded.Text = "Filtros Añadidos";
            this.filterAdded.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataFilter
            // 
            this.dataFilter.AutoSize = true;
            this.dataFilter.Location = new System.Drawing.Point(33, 219);
            this.dataFilter.Name = "dataFilter";
            this.dataFilter.Size = new System.Drawing.Size(80, 13);
            this.dataFilter.TabIndex = 42;
            this.dataFilter.Text = "Dato Para Filtro";
            this.dataFilter.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxData
            // 
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Location = new System.Drawing.Point(129, 210);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(200, 21);
            this.comboBoxData.TabIndex = 43;
            // 
            // filters
            // 
            this.filters.AutoSize = true;
            this.filters.Location = new System.Drawing.Point(140, 258);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(49, 13);
            this.filters.TabIndex = 44;
            this.filters.Text = "Sin filtros";
            this.filters.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Buscar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filters);
            this.Controls.Add(this.comboBoxData);
            this.Controls.Add(this.dataFilter);
            this.Controls.Add(this.filterAdded);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.codeData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.labelURL);
            this.Name = "Form1";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.Label filters;
        private System.Windows.Forms.Button button1;
    }
}

