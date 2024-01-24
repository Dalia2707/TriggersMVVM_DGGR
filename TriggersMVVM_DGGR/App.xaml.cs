using System;
using TriggersMVVM_DGGR.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersMVVM_DGGR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaCategoria();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
