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
            this.tecnologia = new System.Windows.Forms.ComboBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.labelAutoridad = new System.Windows.Forms.Label();
            this.labelEstacion = new System.Windows.Forms.Label();
            this.labelTecnologia = new System.Windows.Forms.Label();
            this.labelLatitud = new System.Windows.Forms.Label();
            this.autoridadAmbiental = new System.Windows.Forms.TextBox();
            this.nombreEstacion = new System.Windows.Forms.TextBox();
            this.latitud = new System.Windows.Forms.TextBox();
            this.labelLongitud = new System.Windows.Forms.Label();
            this.longitud = new System.Windows.Forms.TextBox();
            this.labelCodigoDepartamento = new System.Windows.Forms.Label();
            this.codigoDepartamento = new System.Windows.Forms.TextBox();
            this.labelDepartamento = new System.Windows.Forms.Label();
            this.departamento = new System.Windows.Forms.TextBox();
            this.labelCodigoMunicipio = new System.Windows.Forms.Label();
            this.codigoMunicipio = new System.Windows.Forms.TextBox();
            this.labelMunicipio = new System.Windows.Forms.Label();
            this.municipio = new System.Windows.Forms.TextBox();
            this.labelTipoEstacion = new System.Windows.Forms.Label();
            this.tipoEstacion = new System.Windows.Forms.ComboBox();
            this.labelTiempoExposicion = new System.Windows.Forms.Label();
            this.concentracion = new System.Windows.Forms.TextBox();
            this.labelVariable = new System.Windows.Forms.Label();
            this.labelUnidades = new System.Windows.Forms.Label();
            this.labelConcentracion = new System.Windows.Forms.Label();
            this.tiempoExposicion = new System.Windows.Forms.ComboBox();
            this.variable = new System.Windows.Forms.TextBox();
            this.unidades = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tecnologia
            // 
            this.tecnologia.FormattingEnabled = true;
            this.tecnologia.Location = new System.Drawing.Point(97, 157);
            this.tecnologia.Name = "tecnologia";
            this.tecnologia.Size = new System.Drawing.Size(121, 21);
            this.tecnologia.TabIndex = 0;
            this.tecnologia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(25, 39);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(43, 13);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha: ";
            this.labelFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(74, 33);
            this.Fecha.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.Fecha.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(200, 20);
            this.Fecha.TabIndex = 7;
            this.Fecha.Value = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            // 
            // labelAutoridad
            // 
            this.labelAutoridad.AutoSize = true;
            this.labelAutoridad.Location = new System.Drawing.Point(25, 77);
            this.labelAutoridad.Name = "labelAutoridad";
            this.labelAutoridad.Size = new System.Drawing.Size(104, 13);
            this.labelAutoridad.TabIndex = 8;
            this.labelAutoridad.Text = "Autoridad Ambiental:";
            // 
            // labelEstacion
            // 
            this.labelEstacion.AutoSize = true;
            this.labelEstacion.Location = new System.Drawing.Point(25, 123);
            this.labelEstacion.Name = "labelEstacion";
            this.labelEstacion.Size = new System.Drawing.Size(106, 13);
            this.labelEstacion.TabIndex = 9;
            this.labelEstacion.Text = "Nombre de Estación:";
            // 
            // labelTecnologia
            // 
            this.labelTecnologia.AutoSize = true;
            this.labelTecnologia.Location = new System.Drawing.Point(25, 160);
            this.labelTecnologia.Name = "labelTecnologia";
            this.labelTecnologia.Size = new System.Drawing.Size(66, 13);
            this.labelTecnologia.TabIndex = 10;
            this.labelTecnologia.Text = "Tecnologia: ";
            // 
            // labelLatitud
            // 
            this.labelLatitud.AutoSize = true;
            this.labelLatitud.Location = new System.Drawing.Point(25, 200);
            this.labelLatitud.Name = "labelLatitud";
            this.labelLatitud.Size = new System.Drawing.Size(42, 13);
            this.labelLatitud.TabIndex = 11;
            this.labelLatitud.Text = "Latitud:";
            // 
            // autoridadAmbiental
            // 
            this.autoridadAmbiental.Location = new System.Drawing.Point(135, 74);
            this.autoridadAmbiental.Name = "autoridadAmbiental";
            this.autoridadAmbiental.Size = new System.Drawing.Size(100, 20);
            this.autoridadAmbiental.TabIndex = 12;
            // 
            // nombreEstacion
            // 
            this.nombreEstacion.Location = new System.Drawing.Point(137, 120);
            this.nombreEstacion.Name = "nombreEstacion";
            this.nombreEstacion.Size = new System.Drawing.Size(100, 20);
            this.nombreEstacion.TabIndex = 13;
            // 
            // latitud
            // 
            this.latitud.Location = new System.Drawing.Point(73, 197);
            this.latitud.Name = "latitud";
            this.latitud.Size = new System.Drawing.Size(100, 20);
            this.latitud.TabIndex = 14;
            // 
            // labelLongitud
            // 
            this.labelLongitud.AutoSize = true;
            this.labelLongitud.Location = new System.Drawing.Point(25, 235);
            this.labelLongitud.Name = "labelLongitud";
            this.labelLongitud.Size = new System.Drawing.Size(51, 13);
            this.labelLongitud.TabIndex = 15;
            this.labelLongitud.Text = "Longitud:";
            // 
            // longitud
            // 
            this.longitud.Location = new System.Drawing.Point(82, 232);
            this.longitud.Name = "longitud";
            this.longitud.Size = new System.Drawing.Size(100, 20);
            this.longitud.TabIndex = 16;
            // 
            // labelCodigoDepartamento
            // 
            this.labelCodigoDepartamento.AutoSize = true;
            this.labelCodigoDepartamento.Location = new System.Drawing.Point(25, 268);
            this.labelCodigoDepartamento.Name = "labelCodigoDepartamento";
            this.labelCodigoDepartamento.Size = new System.Drawing.Size(113, 13);
            this.labelCodigoDepartamento.TabIndex = 17;
            this.labelCodigoDepartamento.Text = "Codigo Departamento:";
            // 
            // codigoDepartamento
            // 
            this.codigoDepartamento.Location = new System.Drawing.Point(144, 265);
            this.codigoDepartamento.Name = "codigoDepartamento";
            this.codigoDepartamento.Size = new System.Drawing.Size(100, 20);
            this.codigoDepartamento.TabIndex = 18;
            // 
            // labelDepartamento
            // 
            this.labelDepartamento.AutoSize = true;
            this.labelDepartamento.Location = new System.Drawing.Point(25, 299);
            this.labelDepartamento.Name = "labelDepartamento";
            this.labelDepartamento.Size = new System.Drawing.Size(77, 13);
            this.labelDepartamento.TabIndex = 19;
            this.labelDepartamento.Text = "Departamento:";
            // 
            // departamento
            // 
            this.departamento.Location = new System.Drawing.Point(108, 296);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(100, 20);
            this.departamento.TabIndex = 20;
            // 
            // labelCodigoMunicipio
            // 
            this.labelCodigoMunicipio.AutoSize = true;
            this.labelCodigoMunicipio.Location = new System.Drawing.Point(25, 336);
            this.labelCodigoMunicipio.Name = "labelCodigoMunicipio";
            this.labelCodigoMunicipio.Size = new System.Drawing.Size(91, 13);
            this.labelCodigoMunicipio.TabIndex = 21;
            this.labelCodigoMunicipio.Text = "Codigo Municipio:";
            // 
            // codigoMunicipio
            // 
            this.codigoMunicipio.Location = new System.Drawing.Point(122, 333);
            this.codigoMunicipio.Name = "codigoMunicipio";
            this.codigoMunicipio.Size = new System.Drawing.Size(100, 20);
            this.codigoMunicipio.TabIndex = 22;
            // 
            // labelMunicipio
            // 
            this.labelMunicipio.AutoSize = true;
            this.labelMunicipio.Location = new System.Drawing.Point(25, 370);
            this.labelMunicipio.Name = "labelMunicipio";
            this.labelMunicipio.Size = new System.Drawing.Size(55, 13);
            this.labelMunicipio.TabIndex = 23;
            this.labelMunicipio.Text = "Municipio:";
            // 
            // municipio
            // 
            this.municipio.Location = new System.Drawing.Point(86, 367);
            this.municipio.Name = "municipio";
            this.municipio.Size = new System.Drawing.Size(100, 20);
            this.municipio.TabIndex = 24;
            // 
            // labelTipoEstacion
            // 
            this.labelTipoEstacion.AutoSize = true;
            this.labelTipoEstacion.Location = new System.Drawing.Point(381, 39);
            this.labelTipoEstacion.Name = "labelTipoEstacion";
            this.labelTipoEstacion.Size = new System.Drawing.Size(75, 13);
            this.labelTipoEstacion.TabIndex = 25;
            this.labelTipoEstacion.Text = "Tipo Estación:";
            // 
            // tipoEstacion
            // 
            this.tipoEstacion.FormattingEnabled = true;
            this.tipoEstacion.Location = new System.Drawing.Point(462, 36);
            this.tipoEstacion.Name = "tipoEstacion";
            this.tipoEstacion.Size = new System.Drawing.Size(121, 21);
            this.tipoEstacion.TabIndex = 26;
            // 
            // labelTiempoExposicion
            // 
            this.labelTiempoExposicion.AutoSize = true;
            this.labelTiempoExposicion.Location = new System.Drawing.Point(381, 77);
            this.labelTiempoExposicion.Name = "labelTiempoExposicion";
            this.labelTiempoExposicion.Size = new System.Drawing.Size(114, 13);
            this.labelTiempoExposicion.TabIndex = 27;
            this.labelTiempoExposicion.Text = "Tiempo de Exposición:";
            // 
            // concentracion
            // 
            this.concentracion.Location = new System.Drawing.Point(466, 197);
            this.concentracion.Name = "concentracion";
            this.concentracion.Size = new System.Drawing.Size(100, 20);
            this.concentracion.TabIndex = 28;
            // 
            // labelVariable
            // 
            this.labelVariable.AutoSize = true;
            this.labelVariable.Location = new System.Drawing.Point(381, 123);
            this.labelVariable.Name = "labelVariable";
            this.labelVariable.Size = new System.Drawing.Size(48, 13);
            this.labelVariable.TabIndex = 29;
            this.labelVariable.Text = "Variable:";
            // 
            // labelUnidades
            // 
            this.labelUnidades.AutoSize = true;
            this.labelUnidades.Location = new System.Drawing.Point(381, 160);
            this.labelUnidades.Name = "labelUnidades";
            this.labelUnidades.Size = new System.Drawing.Size(55, 13);
            this.labelUnidades.TabIndex = 30;
            this.labelUnidades.Text = "Unidades:";
            // 
            // labelConcentracion
            // 
            this.labelConcentracion.AutoSize = true;
            this.labelConcentracion.Location = new System.Drawing.Point(381, 200);
            this.labelConcentracion.Name = "labelConcentracion";
            this.labelConcentracion.Size = new System.Drawing.Size(79, 13);
            this.labelConcentracion.TabIndex = 31;
            this.labelConcentracion.Text = "Concentración:";
            // 
            // tiempoExposicion
            // 
            this.tiempoExposicion.FormattingEnabled = true;
            this.tiempoExposicion.Location = new System.Drawing.Point(501, 74);
            this.tiempoExposicion.Name = "tiempoExposicion";
            this.tiempoExposicion.Size = new System.Drawing.Size(121, 21);
            this.tiempoExposicion.TabIndex = 32;
            // 
            // variable
            // 
            this.variable.Location = new System.Drawing.Point(435, 120);
            this.variable.Name = "variable";
            this.variable.Size = new System.Drawing.Size(100, 20);
            this.variable.TabIndex = 33;
            // 
            // unidades
            // 
            this.unidades.FormattingEnabled = true;
            this.unidades.Location = new System.Drawing.Point(442, 157);
            this.unidades.Name = "unidades";
            this.unidades.Size = new System.Drawing.Size(121, 21);
            this.unidades.TabIndex = 34;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(446, 293);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 23);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "Iniciar Busqueda";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.unidades);
            this.Controls.Add(this.variable);
            this.Controls.Add(this.tiempoExposicion);
            this.Controls.Add(this.labelConcentracion);
            this.Controls.Add(this.labelUnidades);
            this.Controls.Add(this.labelVariable);
            this.Controls.Add(this.concentracion);
            this.Controls.Add(this.labelTiempoExposicion);
            this.Controls.Add(this.tipoEstacion);
            this.Controls.Add(this.labelTipoEstacion);
            this.Controls.Add(this.municipio);
            this.Controls.Add(this.labelMunicipio);
            this.Controls.Add(this.codigoMunicipio);
            this.Controls.Add(this.labelCodigoMunicipio);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.labelDepartamento);
            this.Controls.Add(this.codigoDepartamento);
            this.Controls.Add(this.labelCodigoDepartamento);
            this.Controls.Add(this.longitud);
            this.Controls.Add(this.labelLongitud);
            this.Controls.Add(this.latitud);
            this.Controls.Add(this.nombreEstacion);
            this.Controls.Add(this.autoridadAmbiental);
            this.Controls.Add(this.labelLatitud);
            this.Controls.Add(this.labelTecnologia);
            this.Controls.Add(this.labelEstacion);
            this.Controls.Add(this.labelAutoridad);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.tecnologia);
            this.Name = "Form1";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tecnologia;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label labelAutoridad;
        private System.Windows.Forms.Label labelEstacion;
        private System.Windows.Forms.Label labelTecnologia;
        private System.Windows.Forms.Label labelLatitud;
        private System.Windows.Forms.TextBox autoridadAmbiental;
        private System.Windows.Forms.TextBox nombreEstacion;
        private System.Windows.Forms.TextBox latitud;
        private System.Windows.Forms.Label labelLongitud;
        private System.Windows.Forms.TextBox longitud;
        private System.Windows.Forms.Label labelCodigoDepartamento;
        private System.Windows.Forms.TextBox codigoDepartamento;
        private System.Windows.Forms.Label labelDepartamento;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.Label labelCodigoMunicipio;
        private System.Windows.Forms.TextBox codigoMunicipio;
        private System.Windows.Forms.Label labelMunicipio;
        private System.Windows.Forms.TextBox municipio;
        private System.Windows.Forms.Label labelTipoEstacion;
        private System.Windows.Forms.ComboBox tipoEstacion;
        private System.Windows.Forms.Label labelTiempoExposicion;
        private System.Windows.Forms.TextBox concentracion;
        private System.Windows.Forms.Label labelVariable;
        private System.Windows.Forms.Label labelUnidades;
        private System.Windows.Forms.Label labelConcentracion;
        private System.Windows.Forms.ComboBox tiempoExposicion;
        private System.Windows.Forms.TextBox variable;
        private System.Windows.Forms.ComboBox unidades;
        private System.Windows.Forms.Button searchButton;
    }
}

