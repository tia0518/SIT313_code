using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace notes
{
    [Activity(Label = "Activity_voice")]
    public class Activity_voice : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.voice);

            var btn_v1 = FindViewById<Button>(Resource.Id.btn_v1);
            btn_v1.Click += (sender, e) => {
                playVoice1();
            };




            void playVoice1(){
                Android.Net.Uri uri = Android.Net.Uri.Parse("http://fjdx.sc.chinaz.com/files/download/sound1/201311/3795.wav");

                MediaPlayer fileplayer = new MediaPlayer();
                if (fileplayer != null)
                {
                    fileplayer.SetDataSource(this, uri);
                    fileplayer.Prepare();
                    fileplayer.Start();
                }
            }

            }
        }
   }
