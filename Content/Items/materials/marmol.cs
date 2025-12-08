using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace Patata.Content.Items.Materials
{
    public class Marmol : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Marmol");
            // Tooltip.SetDefault("A beautiful marble block.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.maxStack = 999;
            Item.value = 100;
            Item.rare = ItemRarityID.White;
        }
    }
}