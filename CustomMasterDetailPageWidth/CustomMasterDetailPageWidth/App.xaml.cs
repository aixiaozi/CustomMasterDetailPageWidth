using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CustomMasterDetailPageWidth
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var mdp = new MyMasterDetailPage
            {
                Master = new ContentPage
                {
                    BackgroundColor = Color.Azure,
                    Title = "Master",
                    Content = new Label
                    {
                        Text = "MasterPage",
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                    },
                },
                Detail = new ContentPage
                {
                    BackgroundColor = Color.White,
                    Title = "DetailPage",
                    Content = new Label
                    {
                        Text = "DetailPage",
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        BackgroundColor = Color.Pink
                    },
                },
                WidthRatio = 0.5f,
            };

            MainPage = mdp;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
