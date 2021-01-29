using DAP_Mobile.Models.Dashboard;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace DAP_Mobile.ViewModels.Dashboard
{
    /// <summary>
    /// ViewModel for Daily Timeline page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class DailyTimelineViewModel : BaseViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="DailyTimelineViewModel"/> class.
        /// </summary>
        public DailyTimelineViewModel()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a collction of value to be displayed in Daily timeline page.
        /// </summary>
        [DataMember(Name = "dailyTimeline")]
        public ObservableCollection<Event> DailyTimeline { get; set; }

        #endregion
    }
}
