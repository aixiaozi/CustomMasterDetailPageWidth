using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomMasterDetailPageWidth
{
    public class MyMasterDetailPage : MasterDetailPage
    {
        public static readonly BindableProperty WidthRatioProperty =
              BindableProperty.Create(
                  "WidthRatio",
                  typeof(float),
                  typeof(MyMasterDetailPage),
                  (float)0.2,
                  propertyChanged: (bindable, oldValue, newValue) =>
                  {
                  });

        public float WidthRatio
        {
            get { return (float)GetValue(WidthRatioProperty); }
            set { SetValue(WidthRatioProperty, value); }
        }
    }
}
