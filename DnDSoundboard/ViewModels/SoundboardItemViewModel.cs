using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using DnDSoundboard.Models;
using DnDSoundboard.DependencyServices.Interfaces;
using System.Windows.Input;


namespace DnDSoundboard.ViewModels
{
	public class SoundboardItemViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<SoundboardItem> SoundboardItems { get; set; }


		SoundboardItem _selectedSoundboardItem;
		public SoundboardItem selectedSoundboardItem {
			get {
				return _selectedSoundboardItem;
			}
			set{
				if (_selectedSoundboardItem != value) {
					_selectedSoundboardItem = value;
					PlaySound (value);


				}

			}
		}
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

		public void PlaySound(SoundboardItem item)
		{
			DependencyService.Get<ISoundPlayer> ().PlaySound ();
		}
	}
}

