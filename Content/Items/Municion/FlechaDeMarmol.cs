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
    }
}