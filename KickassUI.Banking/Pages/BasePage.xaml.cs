using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace KickassUI.Banking.Pages
{
    public partial class BasePage : ContentPage
    {
        public IList<View> BasePageTitleBarLeftContent => TitleBarLeftContent.Children;
        public IList<View> BasePageTitleBarRightContent => TitleBarRightContent.Children;
        public IList<View> BasePageContent => BaseContentGrid.Children;

        public static readonly BindableProperty ShowLogoProperty =
            BindableProperty.Create(nameof(ShowLogo), typeof(bool), typeof(BasePage), false,
                defaultBindingMode: BindingMode.OneWay, propertyChanged: OnShowLogoChanged);

        public bool ShowLogo
        {
            get => (bool)GetValue(ShowLogoProperty);
            set => SetValue(ShowLogoProperty, value);
        }

        private static void OnShowLogoChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable != null && bindable is BasePage basePage)
            {
                basePage.Logo.IsVisible = (bool)newValue;
                basePage.TitleLabel.IsVisible = !(bool)newValue;
            }
        }

        public BasePage()
        {
            InitializeComponent();
        }
    }
}
