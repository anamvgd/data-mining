using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Contamination
{
    class Program
    {
        static void Main(string[] argss)
        {
            readInfo();
        }

        public static void readInfo()
        {
            string result = "";
            try
            {
                var url = "https://www.datos.gov.co/api/views/ysq6-ri4e/rows.csv?accessType=DOWNLOAD";
                var client = new WebClient();
                using (var stream = client.OpenRead(url))
                using (var reader = new StreamReader(stream))
                {
                    String line = reader.ReadLine();
                    int count = 0;
                    while ((line = reader.ReadLine()) != null && count <= 10)
                    {
                        count++;
                        String[] args = line.Split(',');
                        Console.WriteLine(args[0]);
                    }
                    reader.Close();
                    stream.Close();
                }

            }
            catch (WebException e)
            {
                result = string.Format("fuck", e);
                Console.WriteLine(result);
            }

        }
    }
}
