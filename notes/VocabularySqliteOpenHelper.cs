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
    class VocabularySqliteOpenHelper : SQLiteOpenHelper
    {
        public VocabularySqliteOpenHelper(Context context) : base(context, "Lib", null, 1) { }

        public override void OnCreate(SQLiteDatabase db)
        {
            db.ExecSQL("CREATE TABLE Vocabulary(Id INTEGER PRIMARY KEY,Word TEXT NOT NULL,Translation TEXT NOT NULL)");
        }

        public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
        {
            db.ExecSQL("DROP TABLE IF EXISTS Vocabulary");
            OnCreate(db);
        }
    }
}