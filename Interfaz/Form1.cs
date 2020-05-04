using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Windows.Forms;
using modelo;
using SODA;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        DataTable dt;
        private String url;
        private String addLink;
        public static String FILTER1 = "?source=";
        public static String FILTER2 = "?$select";
        public static String FILTER3 = "?$order";
        public static String FILTER4 = "?$offset";
        public static String FILTER5 = "?$limit";
        public static String FILTER6 = "?$where";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addLink = "";
            filter.Hide();
            filters.Hide();
            comboBoxFilters.Hide();
            textBoxSearch.Hide();
            dataFilter.Hide();
            filterAdded.Hide();
            addButton.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> p = Soda(urlText.Text, codeData.Text);
                for (int i = 0; i < p.Count; i++)
                {
                    comboBoxFilters.Items.Add(p[i]);
                }
                label1.Hide();
                labelURL.Hide();
                urlText.Hide();
                codeData.Hide();
                Console.WriteLine("Succesfull");
                filter.Show();
                filters.Show();
                comboBoxFilters.Show();
                textBoxSearch.Show();
                dataFilter.Show();
                filterAdded.Show();
                addButton.Show();
                searchButton.Hide();

            }
            catch (ArgumentNullException ea) {
                Console.WriteLine("Something its wrong");
            }


        }



        private void searchData(object sender, EventArgs e)
        {
            dt = new DataTable();
            List<String> p = Soda(urlText.Text, codeData.Text);
            for (int i = 0; i < p.Count; i++)
            {
                dt.Columns.Add(new DataColumn(p[i], typeof(String)));
            }
            readInfo(urlText.Text);
            dataGridView.DataSource = dt;
            dataGridView.Columns[1].Visible = true;
            dataGridView.Columns[2].Visible = true;
            dataGridView.Columns[3].Visible = true;
            dataGridView.Columns[4].Visible = true;
            dataGridView.Columns[5].Visible = true;
            dataGridView.Columns[6].Visible = true;
            dataGridView.Columns[7].Visible = true;
            dataGridView.Columns[8].Visible = true;
            dataGridView.Columns[0].Visible = true;
            dataGridView.Columns[10].Visible = true;
            dataGridView.Columns[11].Visible = true;
            dataGridView.Columns[12].Visible = true;
            dataGridView.Columns[13].Visible = true;
            dataGridView.Columns[14].Visible = true;
            dataGridView.Columns[15].Visible = true;

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


        public void readInfo(String bdId)
        {
            string result = "";
            try
            {

                //var url = "https://www.datos.gov.co/resource/ysq6-ri4e.json?nombre_del_municipio=BARBOSA&variable=PM2.5&$limit=10&$offset=20";
                var url = "https://www.datos.gov.co/resource/" + bdId + ".json?" + addLink + "&$limit=10&$offset=20";
                var client = new WebClient();
                using (var stream = client.OpenRead(url))
                using (var reader = new StreamReader(stream))
                {
                    String line = reader.ReadLine();
                    int count = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine("entro");
                        String[] args = line.Split(',');
                        dt.Rows.Add("" + args[1], "" + args[2], "" + args[3], "" + args[4], "" + args[5], "" + args[6], "" + args[7], "" + args[8], "" + args[9], "" + args[10], "" + args[11], "" + args[12], "" + args[13], "" + args[14], "" + args[15], "" + args[16]);
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

        private void selectCase(object sender, DataGridViewCellMouseEventArgs e)
        {
            dt = new DataTable();
            List<String> p = Soda(urlText.Text, codeData.Text);
            for (int i = 0; i < p.Count; i++)
            {
                dt.Rows.Add(new DataColumn(p[i], typeof(String)));
                /*
                DataRow r = dt.NewRow();
                int filaSeleccionada = e.RowIndex;
                //dataGridView1.Rows[filaSeleccionada].Cells[i].Value.ToString();
                r[""+ p[i]]="j"+i  ;
                dt.Rows.Add(r);
                */
            }
            dataGridView1.DataSource = dt;
            dt.Rows.Add("a", "b");

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String comboBoxMinus = comboBoxFilters.Text.ToLower();
            String[] comboBoxSep = comboBoxMinus.Split(' ');
            comboBoxMinus = comboBoxSep.GetValue(0).ToString();
            String comboFixed;
            for (int i = 1; i < comboBoxSep.Length; i++)
            {
                comboBoxMinus = comboBoxMinus + "_" + comboBoxSep.GetValue(i);
            }
            comboFixed = comboBoxMinus;
            if (!addLink.Equals(""))
            {
                addLink = addLink + "&" + comboFixed + "=" + textBoxSearch.Text;
            }
            else
            {
                addLink = comboFixed + "=" + textBoxSearch.Text;
            }

            if (!filters.Text.Equals("Sin filtros"))
            {
                filters.Text = filters.Text + "\n" + comboBoxFilters.Text + ": " + textBoxSearch.Text;
            }
            else
            {
                filters.Text = comboBoxFilters.Text + ": " + textBoxSearch.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
              filters.Text = "Sin filtros";
              dataGridView.Rows.Clear();

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

      
    }
