using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using DnDSoundboard.Models;
using DnDSoundboard.DependencyServices.Interfaces;


namespace DnDSoundboard.ViewModels
{
	public class SoundboardItemViewModel : INotifyPropertyChanged
	{

		private ListView listview { get; set; }
		public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<SoundboardItem> SoundboardItems { get; set; }


		SoundboardItem _selectedSoundboardItem;
		public SoundboardItem selectedSoundboardItem {
			get {
				return _selectedSoundboardItem;
			}
			set{
				if (_selectedSoundboardItem != value && value != null) {
					_selectedSoundboardItem = value;
					PlaySound (value);
				}

			}
		}
		public SoundboardItemViewModel (ListView lv)
		{
			this.listview = lv;
			FillList ();

		}
		/// <summary>
		/// Fills the list with SoundboardItems
		/// </summary>
		public void FillList()
		{
			SoundboardItems = new ObservableCollection<SoundboardItem> ();
			SoundboardItems.Add(new SoundboardItem("test","test"));
		}

		public void PlaySound(SoundboardItem item)
		{
			this.listview.SelectedItem = null;
			_selectedSoundboardItem = null;
			DependencyService.Get<ISoundPlayer> ().PlaySound (item);
		}
	}
}

