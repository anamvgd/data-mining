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

namespace map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            GeoCoderStatusCode statusCode;
            var pointLatLng1 = OpenStreetMapProvider.Instance.GetPoint("Atlantico", out statusCode);
            String lat1 = pointLatLng1?.Lat.ToString();
            String lon1 = pointLatLng1?.Lng.ToString();
            double latitude = Convert.ToDouble(lat1);
            double longitud = Convert.ToDouble(lon1);
            gmap.Position = new GMap.NET.PointLatLng(latitude, longitud);           
            GMapOverlay marketoverlay = new GMapOverlay("Marcador");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitud),GMarkerGoogleType.purple_dot);
            marketoverlay.Markers.Add(marker);
            gmap.Overlays.Add(marketoverlay);

        }

        private void dateStartChoice(object sender, EventArgs e)
        {

        }

        public Color HeatMapColor(decimal value, decimal min, decimal max)
        {
            decimal val = (value - min) / (max - min);
            int r = Convert.ToByte(255 * val);
            int g = Convert.ToByte(255 * (1 - val));
            int b = 0;

            return Color.FromArgb(255, r, g, b);

        }
    }
}
