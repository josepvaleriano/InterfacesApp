using System;

using Xamarin.Forms;

namespace InterfacesApp
{
	public class Inicio3 : ContentPage
	{
		public Inicio3()
		{
			Content = new Label
			{
				VerticalOptions = LayoutOptions.Center,
				Text = "Tratadistas y teóricos pueden hablar de poética, de métrica," +
							" de aforismos, de figuras, sinestesias y rimas; y efectivamente, eso es " +
					"poesía… Tanto como lo es el \"sentir\u201C que las sílabas rebotan,  una tras otra " +
							"en la consciencia, en el lugar de las quimeras donde no se sabe que tan " +
							"cerca del “demiurgo platónico” se crean y recrean para imaginar lo que para" +
							" uno significa lo poético."
				/*
				Children = {
					new Label {  }
				}*/
			};
			Padding = new Thickness(10, Device.OnPlatform(20,10,10),10, 10);



		}
	}
}

