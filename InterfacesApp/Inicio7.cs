using System;

using Xamarin.Forms;

namespace InterfacesApp
{
	public class Inicio7 : ContentPage
	{
		FormattedString cadena = new FormattedString();

		public Inicio7()
		{


			cadena.Spans.Add(new Span { Text = "Soy ..\n"});
			Content = new Label
			{
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,

				FormattedText = cadena +
				 "Para mi corazón basta tu pecho, \npara tu libertad bastan mis alas. \n" +
					"Desde mi boca llegará hasta el cielo \nlo que estaba dormido sobre tu alma. \n\n" +
					"Es en ti la ilusión de cada día. \nLlegas como el rocío a las corolas. \n" +
					"Socavas el horizonte con tu ausencia. \nEternamente en fuga como la ola. \n\n" +
					"He dicho que cantabas en el viento \ncomo los pinos y como los mástiles. \n" +
					"Como ellos eres alta y taciturna. \nY entristeces de pronto, como un viaje. \n\n" +
					"Acogedora como un viejo camino. \nTe pueblan ecos y voces nostálgicas. \n" +
					"Yo desperté y a veces emigran y huyen \npájaros que dormían en tu alma.",


				VerticalTextAlignment = TextAlignment.Center,
				BackgroundColor = Color.Blue,
				TextColor = new Color(.1, .2, .3),

				FontAttributes = FontAttributes.Italic | FontAttributes.Bold,
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

