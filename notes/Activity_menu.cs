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
    [Activity(Label = "Menu")]
    public class Activity_menu : Activity
    {
        private object sender;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.menu);

            var btn_menuToAccount = FindViewById<Button>(Resource.Id.btn_menuToAccount);

            btn_menuToAccount.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Activity_account));
                StartActivity(intent);
            };

            var btn_menuToDiary = FindViewById<Button>(Resource.Id.btn_menuToDiary);

            btn_menuToDiary.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Activity_diary));
                StartActivity(intent);
            };

            var btn_menuToVoice = FindViewById<Button>(Resource.Id.btn_menuToVoice);

            btn_menuToVoice.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Activity_voice));
                StartActivity(intent);
            };

            var btn_menuToVocabulary = FindViewById<Button>(Resource.Id.btn_menuToVocabulary);

            btn_menuToVocabulary.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Activity_vocabulary));
                StartActivity(intent);
            };

            var btn_menuToAnniversary = FindViewById<Button>(Resource.Id.btn_menuToAnniversary);

            btn_menuToAnniversary.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Activity_anniversary));
                StartActivity(intent);
            };
        }
    }
}