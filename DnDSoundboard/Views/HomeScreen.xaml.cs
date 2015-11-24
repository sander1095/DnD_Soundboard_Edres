using System;
using System.Collections.Generic;

using Xamarin.Forms;
using DnDSoundboard.ViewModels;

namespace DnDSoundboard.Views
{
	public partial class HomeScreen : ContentPage
	{
		public HomeScreen ()
		{
			InitializeComponent ();
			BindingContext = new SoundboardItemViewModel (SoundboardListView);
		}
	}
}

