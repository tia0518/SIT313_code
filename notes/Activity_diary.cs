using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database;
using Android.Database.Sqlite;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace notes
{
    [Activity(Label = "Activity_diary")]
    public class Activity_diary : Activity
    {
        private object sender;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.diary);

            var btn_diaryToDiray1 = FindViewById<Button>(Resource.Id.btn_diaryToDiray1);

            btn_diaryToDiray1.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Activity_diary1));
                StartActivity(intent);
            };

            var btn_diaryToDirayadd = FindViewById<Button>(Resource.Id.btn_diaryToDirayadd);

            btn_diaryToDirayadd.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Activity_diary_add));
                StartActivity(intent);
            };

            var btn_diaryToDiray3 = FindViewById<Button>(Resource.Id.btn_diaryToDiray3);
            string thisdiary = Intent.GetStringExtra("Diary");

            btn_diaryToDiray3.Text = thisdiary;
        }
    }
}