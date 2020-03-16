using System;
using System.IO;
using System.Net;
using System.Windows.Forms;


namespace Interfaz
{
    public partial class Form1 : Form
    {
        private String url;
        public static String FILTER1="?source=";
        public static String FILTER2="?$select";
        public static String FILTER3= "?$order";
        public static String FILTER4= "?$offset";
        public static String FILTER5 = "?$limit";
        public static String FILTER6 = "?$where";

        public static void readInfo(String url1)
        {
            string result = "";
            try
            {
                var url = url1;
                var client = new WebClient();
                using (var stream = client.OpenRead(url))
                using (var reader = new StreamReader(stream))
                {
                    String line = reader.ReadLine();
                    int count = 0;
                    while ((line = reader.ReadLine()) != null && count <= 10)
                    {
                        String[] args = line.Split(',');
                        Console.WriteLine(args[count]);
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


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFilters.Items.Add("Columna");
            comboBoxFilters.Items.Add("Help me");
            comboBoxFilters.Items.Add("Nose que colocar cambian esto");
            comboBoxFilters.Items.Add("Se supone que es para los filtros");
            comboBoxFilters.Items.Add("las constantes");
            filter.Hide();
            filters.Hide();
            comboBoxFilters.Hide();
            comboBoxData.Hide();
            dataFilter.Hide();
            filterAdded.Hide();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                url = urlText.Text+"/"+codeData;
                readInfo(url);
                label1.Hide();
                labelURL.Hide();
                urlText.Hide();
                codeData.Hide();
                Console.WriteLine("Succesfull");
                filter.Show();
                filters.Show();
                comboBoxFilters.Show();
                comboBoxData.Show();
                dataFilter.Show();
                filterAdded.Show();


            }
            catch (ArgumentNullException ea) {
                Console.WriteLine("Something its wrong");
            }

           
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
       

        private void searchData(object sender, EventArgs e)
        {
            /*
             Aqui debes llamar al metodo createURL para poder buscar los datos
             no se si deseas crear una nueva ventana o ocultar todo y trabajar
             en la misma pero solamente cuando le unda aqui ya muestre los datos
             */
       }
    }
}
