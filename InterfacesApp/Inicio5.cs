using System;

using Xamarin.Forms;

namespace InterfacesApp
{
	public class Inicio5 : ContentPage
	{
		public Inicio5()
		{
			Content = new Label
			{
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				Text = 
					" \"Sera\u201C \n" +
					"Cuántas veces, amor, te amé sin verte y tal vez sin recuerdo, \n" +
					"sin reconocer tu mirada, sin mirarte, centaura, \n" +
					"en regiones contrarias, en un mediodía quemante: \n" +
					"eras sólo el aroma de los cereales que amo. \n\n" +
					"Tal vez te vi, te supuse al pasar levantando una copa \n" +
					"en Angola, a la luz de la luna de Junio, \no eras tú la cintura de aquella guitarra \n" +
					"que toqué en las tinieblas y sonó como el mar desmedido.\n\n"+
					"Te amé sin que yo lo supiera, y busqué tu memoria. \n" +
					"En las casas vacías entré con linterna a robar tu retrato. \n" +
					"Pero yo ya sabía cómo era. De pronto \n\n" +
					"mientras ibas conmigo te toqué y se detuvo mi vida: \n" +
					"frente a mis ojos estabas, reinándome, y reinas. \n" +
					"Como hoguera en los bosques el fuego es tu reino.",
				BackgroundColor = Color.Green,
				TextColor = new Color(.3,.8,.9)
			};

		}
	}
}

