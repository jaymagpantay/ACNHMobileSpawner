using System.Collections.Generic;
using static NHSE.Core.ItemKind;

namespace NHSE.Core
{
    /// <summary>
    /// Kinds of items
    /// </summary>
#pragma warning disable CA1027 // Mark enums with FlagsAttribute
    public enum ItemKind : byte
#pragma warning restore CA1027 // Mark enums with FlagsAttribute
    {
        Bottoms_Long,
        Bottoms_Middle,
        Bottoms_Short,
        Ftr_1x1_Chair,
        Ftr_1x1_Floor,
        Ftr_2x1_Bed,
        Ftr_2x1_Floor,
        Ftr_2x2_Floor,
        Kind_Accessory,
        Kind_AutumnLeaf,
        Kind_Axe,
        Kind_Bag,
        Kind_Balloon,
        Kind_BdayCupcake,
        Kind_BigbagPresent,
        Kind_BlowBubble,
        Kind_BridgeItem,
        Kind_Bromide,
        Kind_Bush,
        Kind_BushSeedling,
        Kind_Candy,
        Kind_Cap,
        Kind_ChangeStick,
        Kind_CliffMaker,
        Kind_CraftMaterial,
        Kind_CraftPhoneCase,
        Kind_CraftRemake,
        Kind_DiveFish,
        Kind_DIYRecipe,
        Kind_DoorDeco,
        Kind_DummyCardboard,
        Kind_DummyDIYRecipe,
        Kind_DummyFtr,
        Kind_DummyHowtoBook,
        Kind_DummyPresentbox,
        Kind_DummyRecipe,
        Kind_DummyWrapping,
        Kind_EasterEgg,
        Kind_EventObjFtr,
        Kind_Fence,
        Kind_FierworkHand,
        Kind_FireworkM,
        Kind_Fish,
        Kind_FishBait,
        Kind_FishingRod,
        Kind_FishToy,
        Kind_Flower,
        Kind_FlowerBud,
        Kind_FlowerSeed,
        Kind_Fossil,
        Kind_FossilUnknown,
        Kind_Fruit,
        Kind_Ftr,
        Kind_Giftbox,
        Kind_GroundMaker,
        Kind_HandheldPennant,
        Kind_HarvestDish,
        Kind_Helmet,
        Kind_Honeycomb,
        Kind_HousePost,
        Kind_HousingKit,
        Kind_HousingKitBirdge,
        Kind_HousingKitRcoQuest,
        Kind_Insect,
        Kind_InsectToy,
        Kind_JohnnyQuest,
        Kind_JohnnyQuestDust,
        Kind_JuiceFuzzyapple,
        Kind_Ladder,
        Kind_LicenseItem,
        Kind_LostQuest,
        Kind_LostQuestDust,
        Kind_LoveCrystal,
        Kind_Medicine,
        Kind_MessageBottle,
        Kind_MilePlaneTicket,
        Kind_Money,
        Kind_Mushroom,
        Kind_Music,
        Kind_MusicMiss,
        Kind_MyDesignObject,
        Kind_MyDesignTexture,
        Kind_Net,
        Kind_NnpcRoomMarker,
        Kind_NpcOutfit,
        Kind_Ocarina,
        Kind_Ore,
        Kind_Panflute,
        Kind_Partyhorn,
        Kind_PartyPopper,
        Kind_PhotoStudioList,
        Kind_Picture,
        Kind_PictureFake,
        Kind_PinataStick,
        Kind_PirateQuest,
        Kind_PitFallSeed,
        Kind_PlayerDemoOutfit,
        Kind_Poster,
        Kind_QuestChristmasPresentbox,
        Kind_QuestWrapping,
        Kind_RiverMaker,
        Kind_RollanTicket,
        Kind_RoomFloor,
        Kind_RoomWall,
        Kind_Rug,
        Kind_RugMyDesign,
        Kind_Sakurapetal,
        Kind_Sculpture,
        Kind_SculptureFake,
        Kind_SequenceOnly,
        Kind_ShellDrift,
        Kind_ShellFish,
        Kind_Shovel,
        Kind_Slingshot,
        Kind_SlopeItem,
        Kind_SmartPhone,
        Kind_SnowCrystal,
        Kind_Socks,
        Kind_StarPiece,
        Kind_StickLight,
        Kind_TailorTicket,
        Kind_Tambourine,
        Kind_Timer,
        Kind_Trash,
        Kind_TreasureQuest,
        Kind_TreasureQuestDust,
        Kind_Tree,
        Kind_TreeSeedling,
        Kind_Turnip,
        Kind_TurnipExpired,
        Kind_Uchiwa,
        Kind_Umbrella,
        Kind_VegeSeedling,
        Kind_Vegetable,
        Kind_VegeTree,
        Kind_Watering,
        Kind_Weed,
        Kind_Windmill,
        Kind_WoodenStickTool,
        Kind_WrappingPaper,
        Kind_YutaroWisp,
        Kind_XmasDeco,
        Onepiece_Dress,
        Onepiece_Long,
        Onepiece_Middle,
        Onepiece_Short,
        Shoes_Boots,
        Shoes_Pumps,
        Top_Long,
        Top_Middle,
        Top_Short,
        UnitIcon_FlwAnemone,
        UnitIcon_FlwCosmos,
        UnitIcon_FlwHyacinth,
        UnitIcon_FlwLily,
        UnitIcon_FlwMum,
        UnitIcon_FlwPansy,
        UnitIcon_FlwRose,
        UnitIcon_FlwTulip,

        Unknown = byte.MaxValue,
    }

    public static class ItemKindExtensions
    {
        private static readonly HashSet<ItemKind> Clothing = new HashSet<ItemKind>
        {
            Bottoms_Long,
            Bottoms_Middle,
            Bottoms_Short,
            Kind_Accessory,
            Kind_Bag,
            Kind_Cap,
            Kind_Helmet,
            Kind_NpcOutfit,
            Kind_PlayerDemoOutfit,
            Kind_Socks,
            Onepiece_Dress,
            Onepiece_Long,
            Onepiece_Middle,
            Onepiece_Short,
            Shoes_Boots,
            Shoes_Pumps,
            Top_Long,
            Top_Middle,
            Top_Short,
        };

        private static readonly HashSet<ItemKind> Furniture = new HashSet<ItemKind>
        {
            Ftr_1x1_Chair,
            Ftr_1x1_Floor,
            Ftr_2x1_Bed,
            Ftr_2x1_Floor,
            Ftr_2x2_Floor,
            Kind_DummyFtr,
            Kind_EventObjFtr,
            Kind_Ftr,
        };

        private static readonly HashSet<ItemKind> Fish = new HashSet<ItemKind>
        {
            Kind_DiveFish,
            Kind_Fish,
            Kind_ShellFish
        };

        public static bool IsFlower(this ItemKind k) => (Kind_Flower <= k && k <= Kind_FlowerBud) || (UnitIcon_FlwAnemone <= k && k <= UnitIcon_FlwTulip);
        public static bool IsClothing(this ItemKind k) => Clothing.Contains(k);
        public static bool IsCrafting(this ItemKind k) => k == Kind_Ore || k == Kind_CraftMaterial || k == Kind_CraftPhoneCase || k == Kind_CraftRemake;
        public static bool IsFurniture(this ItemKind k) => Furniture.Contains(k);
        public static bool IsFish(this ItemKind k) => Fish.Contains(k);
    }
}
