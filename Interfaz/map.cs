using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Interfaz
{
    public partial class map : Form
    {
        private List<Double> latitudes;
        private List<Double> longitudes;
        private List<String> departamentos;
        private List<String> fechas;
        private List<String> tipoVariable;
        public map()
        {
            InitializeComponent();
        }

        public void getData(List<string> f, List<string> t, List<Double> la, List<Double> lo, List<string> d)
        {
            fechas = f;
            departamentos = d;
            tipoVariable = t;
            latitudes = la;
            longitudes = lo;
            if (fechas[0]==null)
            {
                Console.WriteLine("no sirvio");
            }
            else
            {
                Console.WriteLine("Nice");
            }
        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gmap_Load(object sender, EventArgs e)
        {
            gmap.DragButton = MouseButtons.Left;
            gmap.CanDragMap = true;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.Position = new GMap.NET.PointLatLng(4.6097100, -74.0817500);
            gmap.MinZoom = 0;
            gmap.MaxZoom = 18;
            gmap.Zoom = 9;
            gmap.AutoScroll = true;
        }
    }
}
