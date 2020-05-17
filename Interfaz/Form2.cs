using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SODA;
using System.IO;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;

namespace Interfaz
{
    public partial class Form2 : Form
    {
        DataTable dt;
        List<double> xmembers;
        List<double> ymembers;

        public Form2()
        {
            InitializeComponent();
        }


        public void readInfo()
        {
            string result = "";
            try
            {

               
                var url = "https://www.datos.gov.co/resource/ysq6-ri4e.json?$select=variable,count(variable)&$group=variable";
                var client = new WebClient();
                using (var stream = client.OpenRead(url))
                using (var reader = new StreamReader(stream))
                {
                    String line = reader.ReadLine();
                    int count = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        String[] args = line.Split(',');
                        String[] args2 = args[1].Split(':');
                        String[] args3 = args2[1].Split('"');
                        String[] args4 = args[2].Split(':');
                        String[] args5 = args4[1].Split('"');
                        Console.WriteLine(args4[1]);
                        if (args3[1].Equals("PM2.5") || args3[1].Equals("PM10")) {
                            dt.Rows.Add(args3[1], args5[1]);
                        }
                        count++;
                    }
                    reader.Close();
                    stream.Close();
                }

            }
            catch (WebException e)
            {
                result = string.Format("F", e);
                Console.WriteLine(result);
            }

        }

        public List<String> Soda(String bdId, String code)
        {


            // Install the package from Nuget first:
            // PM> Install-Package CSM.SodaDotNet
            //"oipJOeStVp83pvoG20CMSGiXe"

            var client = new SodaClient("https://www.datos.gov.co", code);

            // Get a reference to the resource itself
            // The result (a Resouce object) is a generic type
            // The type parameter represents the underlying rows of the resource
            // and can be any JSON-serializable class
            //ysq6-ri4e
            var dataset = client.GetResource<Object>(bdId);

            // Resource objects read their own data
            /*var rows = dataset.GetRows(limit: 5000);         
            Console.WriteLine("Got {0} results. Dumping first results:", rows.Count());
            */
            var columns = dataset.Columns;
            List<String> l = new List<String>();
            foreach (var keyValue in columns)
            {
                l.Add(keyValue.Name);

            }
            return l;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("variable", typeof(String)));
            dt.Columns.Add(new DataColumn("Total", typeof(String)));
            readInfo();
            chart1.Titles.Clear();
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Palette = ChartColorPalette.Excel;
            ChartArea areagrafico = new ChartArea();
            chart1.ChartAreas.Add(areagrafico);
            Series serie = new Series("Variables Del Aire");
            serie.ChartType = SeriesChartType.Point;
            serie.XValueMember = "variable";
            serie.YValueMembers = "Total";
            serie.IsValueShownAsLabel = true;
            chart1.Series.Add(serie);
            chart1.DataSource = dt;
            
        }

        public void graficarPredicciones(List<double> valuesY, List<double> valuesX) {

            xmembers = valuesX;
            ymembers = valuesY;
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Prediccion", typeof(String)));
            dt.Columns.Add(new DataColumn("Tiempo", typeof(String)));
            for (int i = 0; i < valuesY.Count; i++)
            {
                dt.Rows.Add(valuesY[i], valuesX[i]);
            }
            chart1.Titles.Clear();
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Palette = ChartColorPalette.Excel;
            ChartArea areagrafico = new ChartArea();
            chart1.ChartAreas.Add(areagrafico);
            Series serie = new Series("Predicciones");
            serie.ChartType = SeriesChartType.Point;
            serie.YValueMembers = "Prediccion";
            serie.XValueMember = "Tiempo";
            serie.IsValueShownAsLabel = true;
            chart1.Series.Add(serie);
            chart1.DataSource = dt;

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graficarPredicciones(ymembers,xmembers);
        }
    }
}
