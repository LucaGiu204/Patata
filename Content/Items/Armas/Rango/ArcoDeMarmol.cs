using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using Patata.Content.Items.Materials; 

namespace Patata.Content.Items.Armas.Rango
{
    public class ArcoDeMarmol : ModItem
    {
        public override void SetStaticDefaults()
        {
            // Esto es lo ÚNICO que debe ir aquí (configuración del Journey Mode)
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; 
        }

        public override void SetDefaults()
        {
            // === PROPIEDADES VISUALES ===
            Item.width = 40; 
            Item.height = 40; 
            Item.scale = 2f; // Tu arco es gigante, ¡ojo con el tamaño!
            Item.rare = ItemRarityID.Blue; 

            // === PROPIEDADES DE COMBATE ===
            Item.damage = 1400; // ¿1400 de daño? ¡Es nuclear! (Cuidado con el balanceo jaja)
            Item.DamageType = DamageClass.Ranged; // Importante: Ranged para arcos
            Item.useTime = 15; 
            Item.useAnimation = 15; 
            Item.knockBack = 19f; 
            Item.autoReuse = true; 

            // === LO QUE TE FALTABA PARA QUE DISPARE ===
            Item.useStyle = ItemUseStyleID.Shoot; // Animación de disparo
            Item.noMelee = true; // Importante: Para que el arco en sí no golpee, solo la flecha
            
            Item.shoot = ProjectileID.PurificationPowder; // Valor obligatorio (10) para que sepa que dispara
            Item.shootSpeed = 16f; // La velocidad de la flecha
            Item.useAmmo = AmmoID.Arrow; // Usa flechas del inventario

            // === OTRAS PROPIEDADES ===
            Item.value = 10000000; 
            Item.UseSound = SoundID.Item5; // Cambié a Item5 que es sonido de flecha (Item1 es espada)
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Marmol>(7); 
            recipe.AddIngredient(ItemID.Wood, 3); 
            recipe.AddTile(TileID.Anvils); 
            recipe.Register();
        }
    }
}