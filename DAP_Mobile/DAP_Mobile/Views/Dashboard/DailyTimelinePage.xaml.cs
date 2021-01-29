using DAP_Mobile.DataService;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace DAP_Mobile.Views.Dashboard
{
    /// <summary>
    /// Page to show Daily Timeline.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DailyTimelinePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyTimelinePage" /> class.
        /// </summary>
        public DailyTimelinePage()
        {
            InitializeComponent();
            this.BindingContext = DailyTimelineDataService.Instance.DailyTimelineViewModel;
        }
    }
}