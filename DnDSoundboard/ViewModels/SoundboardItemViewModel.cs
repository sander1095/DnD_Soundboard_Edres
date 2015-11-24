using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using DnDSoundboard.Models;

namespace DnDSoundboard.ViewModels
{
	public class SoundboardItemViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<SoundboardItem> SoundboardItems { get; set; }

		public SoundboardItemViewModel ()
		{
			FillList ();
		
		}
		/// <summary>
		/// Fills the list with SoundboardItems
		/// </summary>
		public void FillList()
		{
			SoundboardItems = new ObservableCollection<SoundboardItem> ();
			SoundboardItems.Add(new SoundboardItem("Test","Test"));
		}
	}
}

