using System;

using Xamarin.Forms;

namespace InterfacesApp
{
	public class Inicio11 : ContentPage
	{
		StackLayout listaLayout = new StackLayout();
		public Inicio11()
		{
			Button botonAdd = new Button
			{
				Text = "Add...",
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand

			};
			Button botonLess = new Button
			{
				Text = "Less...",
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand

			};
			Button botonClear = new Button
			{
				Text = "Clear...",
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand

			};


			var layout = new StackLayout();
			layout.Children.Add(botonAdd);
			layout.Children.Add(botonLess);
			layout.Children.Add(botonClear);
			layout.Spacing = 10;
			Content = layout;


			botonAdd.Clicked += ProcesarClickAdd;
			botonLess.Clicked += ProcesarClickLess;
			botonClear.Clicked += ProcesarClickClear;

		}
		void ProcesarClickAdd(object sender, EventArgs args)
		{
			listaLayout.Children.Add(new Label { 
				Text =" Add to time " + DateTime.Now.ToString("T") 
			});
		}

		void ProcesarClickLess(object sender, EventArgs args)
		{
			if (listaLayout.Children.Count != 0)
			listaLayout.Children.RemoveAt(0);
		}

		void ProcesarClickClear(object sender, EventArgs args)
		{
			listaLayout.Children.Clear();
		}
	}

}


