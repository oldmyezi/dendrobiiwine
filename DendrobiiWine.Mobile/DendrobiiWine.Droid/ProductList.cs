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

namespace DendrobiiWine.Droid
{
    [Activity(Label = "ProductList")]
    public class ProductList : NavigationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ProductList);
        }

        protected override ActionBarModel InitActionBarModel()
        {
            return null;
        }
    }
}