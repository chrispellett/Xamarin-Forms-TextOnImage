using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TextOnImage
{
	public partial class TextOnImage : AbsoluteLayout
	{
		public static readonly BindableProperty TextProperty = BindableProperty.Create<TextOnImage, string> (p => p.Text, "");
		public static readonly BindableProperty ColorProperty = BindableProperty.Create<TextOnImage, Color> (p => p.Color, Color.Black);
		public static readonly BindableProperty SourceProperty = BindableProperty.Create<TextOnImage, ImageSource> (p => p.Source, null);

		public string Text {
			get{ return (string)GetValue (TextProperty); }
			set{ SetValue (TextProperty, value); }
		}

		public Color Color {
			get{ return (Color)GetValue (ColorProperty); }
			set{ SetValue (ColorProperty, value); }
		}

		public ImageSource Source {
			get{ return (ImageSource)GetValue (SourceProperty); }
			set{ SetValue (SourceProperty, value); }
		}

		public TextOnImage ()
		{
			InitializeComponent ();
			BindingContext = this;
		}
	}
}