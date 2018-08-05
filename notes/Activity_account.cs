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
    [Activity(Label = "Activity_account")]
    public class Activity_account : Activity
    {
        private object sender;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.account);

            var n1 = FindViewById<EditText>(Resource.Id.n1);
            var b1 = FindViewById<Button>(Resource.Id.b1);
            var r1 = FindViewById<TextView>(Resource.Id.r1);

            var n2 = FindViewById<EditText>(Resource.Id.n2);
            var b2= FindViewById<Button>(Resource.Id.b2);
            var r2 = FindViewById<TextView>(Resource.Id.r2);

            var n3 = FindViewById<EditText>(Resource.Id.n3);
            var b3 = FindViewById<Button>(Resource.Id.b3);
            var r3 = FindViewById<TextView>(Resource.Id.r3);

            var n4 = FindViewById<EditText>(Resource.Id.n4);
            var b4 = FindViewById<Button>(Resource.Id.b4);
            var r4 = FindViewById<TextView>(Resource.Id.r4);

            var n5 = FindViewById<EditText>(Resource.Id.n5);
            var b5 = FindViewById<Button>(Resource.Id.b5);
            var r5 = FindViewById<TextView>(Resource.Id.r5);

            var n6 = FindViewById<EditText>(Resource.Id.n6);
            var b6 = FindViewById<Button>(Resource.Id.b6);
            var r6 = FindViewById<TextView>(Resource.Id.r6);

            var n7 = FindViewById<EditText>(Resource.Id.n7);
            var b7 = FindViewById<Button>(Resource.Id.b7);
            var r7 = FindViewById<TextView>(Resource.Id.r7);

            var n8 = FindViewById<EditText>(Resource.Id.n8);
            var b8 = FindViewById<Button>(Resource.Id.b8);
            var r8 = FindViewById<TextView>(Resource.Id.r8);

            var n9 = FindViewById<EditText>(Resource.Id.n9);
            var b9 = FindViewById<Button>(Resource.Id.b9);
            var r9 = FindViewById<TextView>(Resource.Id.r9);

            b1.Click += (sender, e) =>
            {
                r1.Text = (int.Parse(n1.Text) + int.Parse(r1.Text)).ToString();
            };


            b2.Click += (sender, e) =>
            {
                r2.Text = (int.Parse(n2.Text) + int.Parse(r2.Text)).ToString();
            };


            b3.Click += (sender, e) =>
            {
                r3.Text = (int.Parse(n3.Text) + int.Parse(r3.Text)).ToString();
            };


            b4.Click += (sender, e) =>
            {
                r4.Text = (int.Parse(n4.Text) + int.Parse(r4.Text)).ToString();
            };


            b5.Click += (sender, e) =>
            {
                r5.Text = (int.Parse(n5.Text) + int.Parse(r5.Text)).ToString();
            };


            b6.Click += (sender, e) =>
            {
                r6.Text = (int.Parse(n6.Text) + int.Parse(r6.Text)).ToString();
            };


            b7.Click += (sender, e) =>
            {
                r7.Text = (int.Parse(n7.Text) + int.Parse(r7.Text)).ToString();
            };


            b8.Click += (sender, e) =>
            {
                r8.Text = (int.Parse(n8.Text) + int.Parse(r8.Text)).ToString();
            };


            b9.Click += (sender, e) =>
            {
                r9.Text = (int.Parse(n9.Text) + int.Parse(r9.Text)).ToString();
            };

        }
    }
}