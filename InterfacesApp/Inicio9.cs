using System;

using Xamarin.Forms;

namespace InterfacesApp
{
	public class Inicio9 : ContentPage
	{
		Label label;
		public Inicio9()
		{
			label = new Label
			{
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center

			};
			Content = label;
			SizeChanged += CambioDeTamanio;

		}

		void CambioDeTamanio(object sender, EventArgs args)
		{
			label.Text = String.Format("{0} \u00D7 {1}", Width, Height);
		}

	}
}

