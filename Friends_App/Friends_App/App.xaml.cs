using Friends_App.Services;
using Friends_App.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Friends_App
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friend.db";
        public static FriendRepository database;
        public static FriendRepository DataBase
        {
            get
            {
                if (database == null)
                {
                    database = new FriendRepository
                        (Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));

                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new DBListPage());
            //MainPage = new AppShell();
            //MainPage = new NavigationPage(new FriendsListPage());

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
