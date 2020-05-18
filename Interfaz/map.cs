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

        private string filtroDepartamento;
        private string filtroParticula;
        private string filtroFechaInicio;
        private string filtroFechaTermino;

        private List<int> positionsFilter;
        public map()
        {
            InitializeComponent();
        }

        public void getData(List<string> f, List<string> t, List<Double> la, List<Double> lo, List<string> d,List<Double> v)
        {
            fechas = f;
            departamentos = d;
            tipoVariable = t;
            latitudes = la;
            longitudes = lo;
            values = v;
            positionsFilter = new List<int>();

        }
        
        public void markers()
        {
            GMapOverlay markeroverley = new GMapOverlay("markers");
            for (int i=0; i<values.Count;i++)
            {
                GMarkerGoogle marker;
                if (values[i]<=50)
                {
                   marker = new GMarkerGoogle(new PointLatLng(latitudes[i],longitudes[i]),GMarkerGoogleType.green_big_go) ;
                }else if (values[i] >= 51 && values[i] <= 100)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.yellow_big_pause);
                }else if (values[i] >= 101 && values[i] <= 150)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.orange_dot);
                }else if (values[i] >= 151 && values[i] <= 200)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.red_big_stop);
                }else if (values[i] >= 201 && values[i] <= 250)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.purple);
                }
                else
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.brown_small);
                }

                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("tipoVariable:{0} \n concentracion: {1}", tipoVariable[i], values[i]);
                markeroverley.Markers.Add(marker);
                gmap.Overlays.Add(markeroverley);
                gmap.Position = new GMap.NET.PointLatLng(latitudes[i], longitudes[i]);
                gmap.Zoom = gmap.Zoom + 1;
                gmap.Zoom = gmap.Zoom - 1;
            }

        }

        public void customMarkers()
        {
            GMapOverlay markeroverley = new GMapOverlay("markers");
            for (int i = 0; i < positionsFilter.Count; i++)
            {
                GMarkerGoogle marker;
                if (values[positionsFilter[i]] <= 50)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.green_big_go);
                }
                else if (values[positionsFilter[i]] >= 51 && values[positionsFilter[i]] <= 100)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.yellow_big_pause);
                }
                else if (values[positionsFilter[i]] >= 101 && values[positionsFilter[i]] <= 150)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.orange_dot);
                }
                else if (values[positionsFilter[i]] >= 151 && values[positionsFilter[i]] <= 200)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.red_big_stop);
                }
                else if (values[positionsFilter[i]] >= 201 && values[positionsFilter[i]] <= 250)
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.purple);
                }
                else
                {
                    marker = new GMarkerGoogle(new PointLatLng(latitudes[i], longitudes[i]), GMarkerGoogleType.brown_small);
                }

                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("tipoVariable:{0} \n concentracion: {1}", tipoVariable[positionsFilter[i]], values[positionsFilter[i]]);
                markeroverley.Markers.Add(marker);
                gmap.Overlays.Add(markeroverley);
                gmap.Position = new GMap.NET.PointLatLng(latitudes[i], longitudes[i]);
                gmap.Zoom = gmap.Zoom + 1;
                gmap.Zoom = gmap.Zoom - 1;
            }
        }

        public void dataFilters()
        {
            string[] fechaInicio = filtroFechaInicio.Split('/');
            string[] fechaTermino = filtroFechaTermino.Split('/');
            int diaInicio = int.Parse(fechaInicio[0]);
            int mesInico = int.Parse(fechaInicio[1]);
            int añoinicio = int.Parse(fechaInicio[2]);
            int diaTermino = int.Parse(fechaTermino[0]);
            int mesTermino = int.Parse(fechaTermino[1]);
            int añoTermino = int.Parse(fechaTermino[2]);
            Boolean flag = true;
            List<int> positions = new List<int>();
            for (int i= 0; i < fechas.Count && flag; i++)
            {
                string[] temp = fechas[i].Split('/');
                string temp2 = temp[2];
                temp2 = temp2.Replace(" ","/");
                string[] temp3 = temp2.Split('/');
                temp[2] = temp3[0];
                int tempdia = int.Parse(temp[0]);
                int tempMes = int.Parse(temp[1]);
                int tempAño = int.Parse(temp[2]);
                if (tempAño>añoTermino&& tempMes>mesTermino&& diaTermino>tempdia)
                {
                    flag = false;
                }
                if (tempAño >= añoinicio && tempAño <= añoTermino && tempMes >= mesInico && tempMes <= mesTermino && tempdia >= diaInicio && tempdia <= diaTermino && filtroParticula == tipoVariable[i])
                {
                    positions.Add(i);
                }
                positionsFilter = positions;
                Console.WriteLine(filtroDepartamento);
                Console.WriteLine(departamentos[i]);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StartCustomSettingEvent(object sender, EventArgs e)
        {
            filtroDepartamento = textBox1.Text;
            filtroParticula = comboParticle.Text;
            filtroFechaInicio = comboDateStart.Text;
            filtroFechaTermino = comboDateFinish.Text;
            dataFilters();
            customMarkers();

        }
    }
}
