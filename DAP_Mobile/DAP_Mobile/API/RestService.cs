using DAP_Mobile.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace DAP_Mobile.API
{
    public class RestService
    {
        HttpClient client;
        public RestService()
        {
            client = new HttpClient();
        }

        public async Task<List<Appointment>> GetAppointments(Lookup<string, string> conditions = null)
        {
            List<Appointment> appointments = new List<Appointment>();
            string uri = ApiUri.Appointments(conditions);

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);

                if(response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(content);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return appointments;
        }
    }
}
