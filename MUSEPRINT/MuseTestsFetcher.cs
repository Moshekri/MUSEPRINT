using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEPRINT
{
    public class MuseTestsFetcher
    {
        private IEnumerable<tstTestDemographic> GetPatientsTests(string patientId)
        {
            List<tstTestDemographic> patientTests = new List<tstTestDemographic>();

            using (MuseModel model = new MuseModel())
            {
                var patientDemographics = model.tstPatientDemographics.Where(p => p.PatientID == patientId).ToList();
                foreach (var item in patientDemographics)
                {
                    var testDemographics = model.tstTestDemographics.Where(t => t.TestID == item.TestID);
                    patientTests.AddRange(testDemographics);
                }
            }

            return patientTests;
        }
        /// <summary>
        /// Return the N latest tests for a specific patient id
        /// </summary>
        /// <param name="patientID">String  - patient id</param>
        /// <param name="numberOfTestsToGet">number of most recent tests to get (N) </param>
        /// <returns></returns>
        public IEnumerable<tstTestDemographic> GetNewestTestsForPatient(string patientID, int numberOfTestsToGet)
        {
            var tests = (List<tstTestDemographic>) GetPatientsTests(patientID);
            tests.Sort();
            if (tests.Count >0 )
            {
                return tests.GetRange(0, numberOfTestsToGet);

            }
            return null;
        }

        public tstPatientDemographic GetPatientIByTestID(string testId)
        {
            using (MuseModel model = new MuseModel())
            {
                var patientsDemographics =   model.tstPatientDemographics.Where(p => p.TestID.ToString() == testId).ToList().FirstOrDefault();
                return patientsDemographics;
            }
        }





    }
}
