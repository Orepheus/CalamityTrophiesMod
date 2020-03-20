using CalamityTrophies.Tiles;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace CalamityTrophies.Items.Placeable
{
	class RockTrophy : ModItem
	{
		Mod calamity = ModLoader.GetMod("CalamityMod");

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 1;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 0;
			item.rare = 1;
			item.createTile = TileType<BossTrophy>();
			item.placeStyle = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ItemFrame);
			recipe.AddIngredient(calamity, "Rock");
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe uncraftRecipe = new ModRecipe(mod);
			uncraftRecipe.AddIngredient(mod.ItemType("RockTrophy"));
			uncraftRecipe.SetResult(calamity.ItemType("Rock"));
			uncraftRecipe.AddRecipe();
			

		}

	}
}
