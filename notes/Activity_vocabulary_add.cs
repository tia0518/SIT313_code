using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database.Sqlite;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace notes
{
    [Activity(Label = "Activity_vocabulary_add")]
    public class Activity_vocabulary_add : Activity
    {
        private object sender;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.vocabulary_add);

            var btn_vocabulary_add = FindViewById<Button>(Resource.Id.btn_vocabulary_add);
            var Newword = FindViewById<EditText>(Resource.Id.Word);
            var NewTranslation = FindViewById<EditText>(Resource.Id.Translation);

            btn_vocabulary_add.Click += (sender, e) => {
                string newword = Newword.Text;
                string newtranslation = NewTranslation.Text;
                VocabularySqliteOpenHelper dbHelper = new VocabularySqliteOpenHelper(this);
                SQLiteDatabase db = dbHelper.WritableDatabase;
                Intent intent = new Intent(this, typeof(Activity_vocabulary));
                intent.PutExtra("Res", newword+"   "+newtranslation);
                StartActivity(intent);
            };
        }
    }
}