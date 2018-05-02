using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonSlasher.Items
{
	public class CrimsonSlasher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimtane Slasher");
			Tooltip.SetDefault("A slashing sword made out of crimtane and tissue. Yuck...");
		}
		public override void SetDefaults()
		{
			item.damage = 28;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 4.5f;
			item.value = 5050;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 6);
            recipe.AddIngredient(ItemID.TissueSample, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
