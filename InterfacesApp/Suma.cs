using System;

using Xamarin.Forms;

namespace InterfacesApp
{
	public class Suma : ContentPage
	{
		StackLayout layout = new StackLayout();
		Label total;
		Entry op1;
		Entry op2;
		public Suma()
		{
			op1 = new Entry
			{
				Placeholder = "operator 1",
				TextColor = Color.Green,
				BackgroundColor = Color.FromHex("#2c3e50"),
				Keyboard = Keyboard.Numeric
				                       
			};
			op2 = new Entry {
				Placeholder = "operator 2",
				TextColor = Color.Green,
				BackgroundColor = Color.FromHex("#2c3e50"),
				Keyboard = Keyboard.Numeric
			};


			Button botonAdd = new Button
			{
				Text = "Add...",
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand

			};
			total = new Label
			{
				TextColor = Color.Blue,
				BackgroundColor = Color.FromHex("#2c3e50")
			};

		 layout = new StackLayout();
			layout.Children.Add(op1);
			layout.Children.Add(op2);
			layout.Children.Add(botonAdd);
			layout.Children.Add(total);
			layout.Spacing = 10;
			Content = layout;

			Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10);

			botonAdd.Clicked += ProcesarClickAdd;


		}
		void ProcesarClickAdd(object sender, EventArgs args)
		{

			layout.Children.Add(new Label
			{
				Text = "Resulado: " + (Double.Parse( op1.Text) + Double.Parse( op2.Text))
			});
		}




	}
}

