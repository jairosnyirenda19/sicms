using System;
using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.App;
using Android.OS;


namespace SIMS_BARS
{
    [Activity(Label = "SPCMS Image View", Icon = "@drawable/icon")]
    public class ImageViewer_View : Activity
    {
        private ScaleImageView ImageView_view;
        private Bitmap image;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ImageViewer);

            ImageView_view = FindViewById<ScaleImageView>(Resource.Id.ImageView_view);
            image = Sowing_Report_Page.Image;
            ShowImage();
        }

        private void ShowImage() 
        {
            if (image != null)
                ImageView_view.SetImageBitmap(image);
            else
                Toast.MakeText(this, "Ooops! The image cannot be rendered!", ToastLength.Short).Show();           
        }
    }
}