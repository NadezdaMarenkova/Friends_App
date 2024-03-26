using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Friends_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DBFriendPage : ContentPage
    {
        public DBFriendPage()
        {
            InitializeComponent();
        }
        private void SaveFriend(object sender, EventArgs e)
        {
            var friend = (Friend)BindingContext;
            if (!String.IsNullOrEmpty(friend.Name))
            {
                App.DataBase.SaveItem(friend);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteFriend(object sender, EventArgs e)
        {
            var friend = (Friend)BindingContext;
            App.DataBase.DeleteItem(friend.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}