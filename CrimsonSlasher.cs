using Terraria.ModLoader;

namespace CrimsonSlasher
{
	class CrimsonSlasher : Mod
	{
		public CrimsonSlasher()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
