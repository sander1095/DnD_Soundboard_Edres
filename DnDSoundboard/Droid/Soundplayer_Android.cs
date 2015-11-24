using System;
using Xamarin.Forms;
using DnDSoundboard.DependencyServices.Interfaces;
using Android.Media;
using Xamarin.Forms;
using DnDSoundboard.Models;


[assembly: Dependency(typeof(DnDSoundboard.Droid.Soundplayer_Android))]
namespace DnDSoundboard.Droid
{
	/// <summary>
	/// The class that plays SoundboardItem's on Android
	/// </summary>
	public class Soundplayer_Android : ISoundPlayer
	{

		MediaPlayer player;
		/// <summary>
		/// Empty constructor for DependencyService
		/// </summary>
		public Soundplayer_Android (){}


		/// <summary>
		/// Method that plays the sound on Android.
		/// </summary>
		public void PlaySound(SoundboardItem item)
		{
			player = new MediaPlayer ();
			var fd = Xamarin.Forms.Forms.Context.Assets.OpenFd (item.FileName + ".mp3");
			player.SetDataSource (fd.FileDescriptor);
			player.Prepare ();
			player.Start ();
			

		}
	}

}

