using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using FreshMvvm;
using FreshMvvmDemo.PageModels;
using FreshMvvmDemo.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshMvvmDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {
            ConfigureIOC();

            var contactList = FreshPageModelResolver.ResolvePageModel<ParticipantListPageModel>();
            var navContainer = new FreshNavigationContainer(contactList);
            MainPage = navContainer;
        }

        private void ConfigureIOC()
        {
            FreshIOC.Container.Register<IParticipantsService, ParticipantsService>();
            FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
