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
    [Activity(Label = "Activity_diary_add")]
    public class Activity_diary_add : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.diary_add);

            var btn_define = FindViewById<Button>(Resource.Id.btn_define);
            var Newdiary = FindViewById<EditText>(Resource.Id.newdiary);

            btn_define.Click += (sender, e) => {
                string newdiary = Newdiary.Text;
                DiarySqliteOpenHelper dbHelper = new DiarySqliteOpenHelper(this);
                SQLiteDatabase db = dbHelper.WritableDatabase;
                db.ExecSQL("insert into Diary values(null,?)", new Java.Lang.Object[] {newdiary});
                db.Close();
                Intent intent1 = new Intent(this, typeof(Activity_diary));
                intent1.PutExtra("Diary",newdiary);
                StartActivity(intent1);
            };
        }
    }
}