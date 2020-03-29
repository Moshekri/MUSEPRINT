using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// &LastName=&FirstName=&AcqDateTime=Mon+May+8+11%3A37%3A07+CDT+1995&CSE=6&Ext=.PDF&Server1=on




namespace MUSEPRINT
{
    public class MuseUrlBuilder
    {
        public string[] GetUrls(List<tstTestDemographic> tests, bool useMuseWebFrame)
        {
            string  target = "getreport";

            if (useMuseWebFrame)
            {
                target = "ViewerPage";
            }

            List<string> urls = new List<string>();
            string serverName = ConfigurationManager.AppSettings.Get("ServerName");
            StringBuilder sb = new StringBuilder();
            foreach (var t in tests)
            {
                MuseTestsFetcher tf = new MuseTestsFetcher();
                var p = tf.GetPatientIByTestID(t.TestID.ToString());
                sb.Append($"http://{serverName}/{target}.asp?PID={p.PatientID}");
                sb.Append($"&LastName={p.PatientFullName_Last}&FirstName={p.PatientFullName_First}");
                sb.Append($"&AcqDateTime={GetFormattedDAteTime(t.AcquisitionDateTime_DT)}");
                sb.Append($"&CSE={t.TestType}&Ext=.PDF&Server1=on");
                urls.Add(sb.ToString());
                sb.Clear();
            }
            return urls.ToArray();


        }
        private string GetFormattedDAteTime(DateTime? dt)
        {
            //(DAY +)MMM + DD + hh %3amm %3ass + (< TimeZone > +)YYYY.No maximum length.
            //           NOTE:
            //DAY is optional.
            //< TimeZone > = 3–digit value such as CDT is optional
            StringBuilder sb = new StringBuilder();
            sb.Append($"{dt.Value.ToString("MMM")}+" +
                $"{dt.Value.Day}+{dt.Value.Hour}%3A{dt.Value.Minute}%3A{dt.Value.Second}+{dt.Value.Year}");
            return sb.ToString();


        }
    }
}
