using System;

using Xamarin.Forms;

namespace InterfacesApp
{
	public class Inicio6 : ContentPage
	{
		public Inicio6()
		{
			Content = new Label
			{

				Text = "“¿Qué es poesía? \ndices mientras clavas en mi pupila tu pupila azul. \n\n" +
					"¿Qué es poesía? \n\n¿Y tú me lo preguntas? \n\nPoesía… eres tú”.\n" +
					"\nGustavo Adolfo Bécquer",
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalTextAlignment = TextAlignment.Center,
				BackgroundColor = Color.Purple,
				TextColor = new Color(.9, .2, .3),
					
				FontAttributes = FontAttributes.Italic  | FontAttributes.Bold,
				FontFamily = Device.OnPlatform(
		"Lobster-Regular",
		"Lobster-Regular.ttf#Lobster-Regular",
		null
	), // set only for iOS
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
			};


		}
	}
}

