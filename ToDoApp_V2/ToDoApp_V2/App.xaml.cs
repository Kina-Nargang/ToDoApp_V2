using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoApp_V2
{
    public partial class App : Application
    {
        public static string FolderPath { get; set; }
        public App()
        {
            InitializeComponent();
            FolderPath = Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData);
            MainPage = new NavigationPage(new NotesPage());
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
