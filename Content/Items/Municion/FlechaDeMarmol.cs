using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.Creative;
using Patata.Content.Items.Materials;

namespace Patata.Content.Items.Municion
{
    public class FlechaDeMarmol : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Flecha de Mármol");
            // Tooltip.SetDefault("Una flecha hecha de mármol sólido.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
        }

        public override void SetDefaults()
        {
            Item.damage = 15; // Daño que causa la flecha
            Item.DamageType = DamageClass.Ranged; // Tipo de daño: Rango
            Item.width = 14; // Ancho del sprite de la flecha
            Item.height = 32; // Alto del sprite de la flecha
            Item.maxStack = 9999; // Máximo apilamiento
            Item.consumable = true; // Se consume al disparar
            Item.knockBack = 8f; // Retroceso al impactar
            Item.value = 80; // Valor en cobre
            Item.rare = ItemRarityID.White; // Rareza común
            Item.shoot = ProjectileID.WoodenArrowFriendly; // Tipo de proyectil que dispara
            Item.shootSpeed = 6f; // Velocidad del proyectil
            Item.ammo = AmmoID.Arrow; // Se usa como munición de flechas
        }
        // Creating item craft
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Marmol>(5); // We are using custom material for the craft, 7 Steel Shards
            recipe.AddIngredient(ItemID.Wood, 3); // Also, we are using vanilla material to craft, 3 Wood
            recipe.AddTile(TileID.Anvils); // Crafting station we need for craft, WorkBenches, Anvils etc. You can find them here - https://terraria.wiki.gg/wiki/Tile_ID
            recipe.Register();
        }
    }
}