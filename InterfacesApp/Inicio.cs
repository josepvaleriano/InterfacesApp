using System;

using Xamarin.Forms;

namespace InterfacesApp
{
	public class Inicio : ContentPage
	{
		public Inicio()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
			Label label = new Label();
			label.Text = "Jose Luis";
			this.Content = label;

			//Esta funciona cuando se habilita otro tipo de librerias
			/*
#if __IOS__
			Padding = new Thickness(0, 20, 0, 0);
			// left top rigth, bottom
#endif
*/
			Padding = Device.OnPlatform<Thickness>(
				new Thickness(0,40,0,0),new Thickness(0), new Thickness(0)
			);



			Device.OnPlatform(iOS: () =>
			{
				Padding = new Thickness(0, 30, 0, 0);

			}
							 );

			//if (Device.OS == TargetPlatform.iOS)



		}
	}
}

