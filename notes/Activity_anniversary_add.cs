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
    [Activity(Label = "Activity_anniversary_add")]
    public class Activity_anniversary_add : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.anniversary_add);


            var btn_save = FindViewById<Button>(Resource.Id.btn_save);
            var date1 = Convert.ToDateTime(FindViewById<EditText>(Resource.Id.theDate));   
            var date2 = DateTime.Now;
            var Event=FindViewById<EditText>(Resource.Id.theEvent);


            var Result = calculateDate(date1, date2);

            btn_save.Click += (sender, e) =>
            {
                string event1 = Event.Text+"\n";
                string result = Result + "days";
                Intent intent = new Intent(this, typeof(Activity_anniversary));
                intent.PutExtra("Event",event1);
                intent.PutExtra("days",result);
                StartActivity(intent);
            };

            string calculateDate(DateTime DateTime1, DateTime DateTime2)
            {
                string dateDiff = null;
                TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
                TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                dateDiff = ts.Days.ToString();
                return dateDiff;
            }
        }
    }
}