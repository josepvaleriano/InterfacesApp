using System;

using Xamarin.Forms;

namespace InterfacesApp
{
	public class Inicio4 : ContentPage
	{
		public Inicio4()
		{
			Content = new Label
			{
				VerticalOptions = LayoutOptions.Center,
				Text = "Ahora bien,\nsi poco a poco dejas de quererme\ndejaré de quererte poco a poco.\n\nSi de pronto\nme olvidas\nno me busques,\nque ya te habré olvidado." +
					"l \"aamor\u201C ."+
					"Pero\nsi cada día,\ncada hora\nsientes que a mí estás destinada\n" +
					"con dulzura implacable.\nSi cada día sube\nuna flor a tus labios a buscarme,\n" +
					"ay amor mío, ay mía,\nen mí todo ese fuego se repite,\n" +
					"en mí nada se apaga ni se olvida,\nmi amor se nutre de tu amor, amada,\n" +
					"y mientras vivas estará en tus brazos\nsin salir de los míos.",
				BackgroundColor = Color.Aqua,
				TextColor = Color.Red
			};
			Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10);

		}
	}
}

