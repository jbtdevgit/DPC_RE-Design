﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPageView : TabbedPage
    {
        public MainTabbedPageView()
        {
            InitializeComponent();
        }
    }
}