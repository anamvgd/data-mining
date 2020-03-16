using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using SODA;

namespace modelo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static List<String> Soda(String bdId, String code)
        {


            // Install the package from Nuget first:
            // PM> Install-Package CSM.SodaDotNet


            var client = new SodaClient("https://www.datos.gov.co", "oipJOeStVp83pvoG20CMSGiXe");

            // Get a reference to the resource itself
            // The result (a Resouce object) is a generic type
            // The type parameter represents the underlying rows of the resource
            // and can be any JSON-serializable class
            var dataset = client.GetResource<Object>("ysq6-ri4e");

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


        public static void readInfo(String bdId)
        {
            string result = "";
            try
            {
                var url = "https://www.datos.gov.co/resource/ysq6-ri4e.json?nombre_del_municipio=BARBOSA&variable=PM2.5&$limit=10&$offset=20";
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
    }
}
