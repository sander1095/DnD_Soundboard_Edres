using System;
using DnDSoundboard.Models;

namespace DnDSoundboard.DependencyServices.Interfaces
{
	public interface ISoundPlayer
	{
	  void PlaySound(SoundboardItem item);
	}
}

