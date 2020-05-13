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
        private List<Double> values;
        private List<String> departamentos;
        private List<String> fechas;
        private List<String> tipoVariable;
        public map()
        {
            InitializeComponent();
        }

        public void getData(List<string> f, List<string> t, List<Double> la, List<Double> lo, List<string> d, List<Double> v)
        {
            fechas = f;
            departamentos = d;
            tipoVariable = t;
            latitudes = la;
            longitudes = lo;
            values = v;

        }

        public void markers()
        {
            GMapOverlay markeroverley = new GMapOverlay("markers");
            for (int i = 0; i < values.Count; i++)
            {
                GMarkerGoogle marker;
                if (values[i] <= 50)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.green_big_go);
                }
                else if (values[i] >= 51 && values[i] <= 100)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.yellow_big_pause);
                }
                else if (values[i] >= 101 && values[i] <= 150)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.orange_dot);
                }
                else if (values[i] >= 151 && values[i] <= 200)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.red_big_stop);
                }
                else if (values[i] >= 201 && values[i] <= 250)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.purple);
                }
                else
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.brown_small);
                }
                markeroverley.Markers.Add(marker);
                gmap.Overlays.Add(markeroverley);
                gmap.Position = new GMap.NET.PointLatLng(latitudes[i], longitudes[i]);
                gmap.Zoom = gmap.Zoom + 1;
                gmap.Zoom = gmap.Zoom - 1;
            }

        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            markers();
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            gmap.DragButton = MouseButtons.Left;
            gmap.CanDragMap = true;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.Position = new GMap.NET.PointLatLng(4.6097100, -74.0817500);
            gmap.MinZoom = 0;
            gmap.MaxZoom = 18;
            gmap.Zoom = 9;
            gmap.AutoScroll = true;
        }
    }
}

