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
    [Activity(Label = "Activity_anniversary")]
    public class Activity_anniversary : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.anniversary);

            var btn_anniversaryToanniversaryadd = FindViewById<Button>(Resource.Id.btn_anniversaryToanniversaryadd);

            btn_anniversaryToanniversaryadd.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Activity_anniversary_add));
                StartActivity(intent);
            };

            var textView4 = FindViewById<TextView>(Resource.Id.textView4);
            string thisevent = Intent.GetStringExtra("Event");
            string thisdays = Intent.GetStringExtra("days");
            textView4.Text = thisevent+thisdays;

        }
    }
}