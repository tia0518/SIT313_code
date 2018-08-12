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
    [Activity(Label = "Activity_vocabulary")]
    public class Activity_vocabulary : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.vocabulary);

            var btn_vocabularyToVocabularyadd = FindViewById<Button>(Resource.Id.btn_vocabularyToVocabularyadd);

            btn_vocabularyToVocabularyadd.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Activity_vocabulary_add));
                StartActivity(intent);
            };
            var wordView = FindViewById<TextView>(Resource.Id.wordView);
            string thisRes = Intent.GetStringExtra("Res");
            wordView.Text = thisRes;
        }
    }
}