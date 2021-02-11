using DAP_Mobile.API;
using DAP_Mobile.Models;
using DAP_Mobile.ViewModels.Dashboard;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace DAP_Mobile.DataService
{
    [Preserve(AllMembers = true)]
    public class DailyTimelineDataService
    {
        #region Fields

        private static DailyTimelineDataService instance;
        private DailyTimelineViewModel dailyTimelineViewModel;
        #endregion

        #region Constructor

        public DailyTimelineDataService()
        {
        }
        #endregion

        #region properties

        public static DailyTimelineDataService Instance => instance ?? (instance = new DailyTimelineDataService());

        public DailyTimelineViewModel DailyTimelineViewModel()
        {
            return this.dailyTimelineViewModel = GetViewModel().Result;
        }
        #endregion

        #region Methods

        private async static Task<DailyTimelineViewModel> GetViewModel()
        {
            DailyTimelineViewModel viewModel = new DailyTimelineViewModel();

            /*RestService rest = new RestService();
            Dictionary<string, string> conditions = new Dictionary<string, string>();
            conditions["date"] = new DateTime().ToUniversalTime().ToString("o");
            viewModel.appointments = new ObservableCollection<Appointment>(await rest.GetAppointments());
*/
            return viewModel;
        }
        #endregion
    }
}
