using System;
using System.Collections.Generic;
using System.Text;

namespace DAP_Mobile.API
{
    public static class ApiUri
    {
        private static string baseUri;
        private static string appointments;
        private static string treatments;
        private static string patients;
        private static string products;
        private static string payments;

        static ApiUri()
        {
            baseUri = "https://dapapi.herokuapp.com/api/";
            appointments = $"{baseUri}appointments";
            treatments = $"{baseUri}treatments";
            patients = $"{baseUri}patients";
            products = $"{baseUri}products";
            payments = $"{baseUri}payments";
        }

        public static string Appointments(Dictionary<string, string> conditions = null)
        {
            if(conditions == null)
            {
                return appointments;
            }

            string uri = $"{appointments}?{GetQuery(conditions)}";

            return uri;
        }

        public static string Treatments(Dictionary<string, string> conditions = null)
        {
            if (conditions == null)
            {
                return treatments;
            }

            string uri = $"{treatments}?{GetQuery(conditions)}";

            return uri;
        }

        public static string Patients(Dictionary<string, string> conditions = null)
        {
            if (conditions == null)
            {
                return patients;
            }

            string uri = $"{patients}?{GetQuery(conditions)}";

            return uri;
        }

        public static string Payments(Dictionary<string, string> conditions = null)
        {
            if (conditions == null)
            {
                return payments;
            }

            string uri = $"{payments}?{GetQuery(conditions)}";

            return uri;
        }

        public static string Products(Dictionary<string, string> conditions = null)
        {
            if (conditions == null)
            {
                return products;
            }

            string uri = $"{products}?{GetQuery(conditions)}";

            return uri;
        }

        private static string GetQuery(Dictionary<string, string> conditions)
        {
            string query = "";

            foreach(KeyValuePair<string, string> pair in conditions)
            {
                query += $"{pair.Key}={pair.Value}&";
            }

            query.TrimEnd('&');

            return query;
        }
    }
}
