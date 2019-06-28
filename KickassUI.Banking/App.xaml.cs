using System;
using FreshMvvm;
using KickassUI.Banking.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KickassUI.Banking
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var loginPage = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
            MainPage = new FreshNavigationContainer(loginPage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        internal void SwitchTo<T>(bool hasNavigation = true, object initData = null) where T : BasePageModel
        {
            if (hasNavigation)
            {
                var navigation = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<T>(initData), typeof(T).ToString());
                Current.MainPage = navigation;
            }
            else
            {
                Current.MainPage = FreshPageModelResolver.ResolvePageModel<T>(initData);
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
