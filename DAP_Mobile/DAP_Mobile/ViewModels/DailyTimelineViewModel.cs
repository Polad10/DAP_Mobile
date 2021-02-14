using DAP_Mobile.API;
using DAP_Mobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace DAP_Mobile.ViewModels
{
    public class DailyTimelineViewModel : INotifyPropertyChanged
    {
        private bool isRefreshing;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsRefreshing
        {
            get
            {
                return isRefreshing;
            }
            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }
        public ICommand RefreshCommand { get; }
        public ObservableCollection<Appointment> Appointments { get; set; }
        public DailyTimelineViewModel()
        {
            RefreshCommand = new Command(RefreshHandler);
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

        private void RefreshHandler()
        {
            Appointments.Clear();
            Populate(DateTime.Now);
            IsRefreshing = false;
        }

        private void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
