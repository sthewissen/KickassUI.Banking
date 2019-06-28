using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace KickassUI.Banking.PageModels
{
    public class LoginPageModel : BasePageModel
    {
        public ICommand GoToOverviewCommand { get; set; }

        public LoginPageModel()
        {
            GoToOverviewCommand = new Command(GoToOverview);
        }

        private void GoToOverview()
        {
            (Application.Current as App).SwitchTo<OverviewPageModel>();
        }
    }
}
