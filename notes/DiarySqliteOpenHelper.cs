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
using Android.Database.Sqlite;
using Android.Content;

namespace notes
{
    class DiarySqliteOpenHelper : SQLiteOpenHelper
    {
        public DiarySqliteOpenHelper(Context context) : base(context, "Lib", null, 1) { }

        public override void OnCreate(SQLiteDatabase db)
        {
            db.ExecSQL("CREATE TABLE Diary(Id INTEGER PRIMARY KEY,DiaryContent TEXT NOT NULL)");
        }

        public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
        {
            db.ExecSQL("DROP TABLE IF EXISTS Diary");
            OnCreate(db);
        }
    }
}