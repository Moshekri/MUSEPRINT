using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUSEPRINT;

namespace Test
{
    class Program
    {
        

        static void Main(string[] args)
        {
            MuseTestsFetcher c1 = new MuseTestsFetcher();
            var t = c1.GetNewestTestsForPatient("1313777203", 2);

            MuseUrlBuilder ub = new MuseUrlBuilder();
            if (t!= null)
            {
                var urls = ub.GetUrls(t.ToList(),true);
                foreach (var item in urls)
                {
                    Process.Start(item);
                }

            }


            
        }
    }
}
