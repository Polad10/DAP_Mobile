using DAP_Mobile.API;
using DAP_Mobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DAP_Mobile.ViewModels.Dashboard
{
    public class DailyTimelineViewModel : BaseViewModel
    {
        public ObservableCollection<Appointment> Appointments { get; set; }
        public DailyTimelineViewModel()
        {
            Appointments = new ObservableCollection<Appointment>();
            Populate(DateTime.Now);
        }

        public async void Populate(DateTime date)
        {
            RestService rest = new RestService();
            Dictionary<string, string> conditions = new Dictionary<string, string>();
            conditions["date"] = date.ToUniversalTime().ToString("o");
            List<Appointment> appointments = await rest.GetAppointments();

            foreach(Appointment appointment in appointments)
            {
                Appointments.Add(appointment);
            }
        }
    }
}
