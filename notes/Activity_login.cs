using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace notes
{
    [Activity(Label = "Notes",MainLauncher = true,Icon ="@drawable/icon")]
    public class Activity_login : Activity
    {
        private object sender;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.login);

            var btn_start_loginToMenu = FindViewById<Button>(Resource.Id.btn_start_loginToMenu);
            var password = FindViewById<EditText>(Resource.Id.password);

            btn_start_loginToMenu.Click += (sender, e) =>
            {
                if (password.Text == "970518")
                {

                    Intent intent1 = new Intent(this, typeof(Activity_menu));
                    StartActivity(intent1);
                }
                else
                {
                    Toast.MakeText(this,"Wrong password!",ToastLength.Long).Show();
                }
            };
        }
    }
}