using System;

namespace DnDSoundboard.Models
{
	public class SoundboardItem
	{
		public string Name {
			get;
			set;
		}

		public string FileName { 
			get;
			set;
		}


		public SoundboardItem (string Name, string FileName)
		{
			this.Name = Name;
			this.FileName = FileName;
		}

	}
}

