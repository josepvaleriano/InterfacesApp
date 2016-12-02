using System;

using Xamarin.Forms;

namespace InterfacesApp
{
	public class Inicio10 : ContentPage
	{
		Label label;
		public Inicio10()
		{
			
			label = new Label
			{
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center


			};
			Content = label;
			Device.StartTimer(TimeSpan.FromSeconds(1), () => {
				label.Text =DateTime.Now.ToString("T");
				return true;
			});
			SizeChanged += CambioDeTamanio;

		}

		void CambioDeTamanio(object sender, EventArgs args)
		{

			label.FontSize = Width / 6;
		}


	}
}

