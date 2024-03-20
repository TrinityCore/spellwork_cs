using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class ItemSparseEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public long AllowableRace; // AllowableRace<64>
        public string Display_lang; // Display_lang
        public string Display1_lang; // Display1_lang
        public string Display2_lang; // Display2_lang
        public string Display3_lang; // Display3_lang
        public string Description_lang; // Description_lang
        [Cardinality(4)]
        public int[] Flags = new int[4]; // Flags<32>[4]
        public float PriceRandomValue; // PriceRandomValue
        public float PriceVariance; // PriceVariance
        public uint VendorStackCount; // VendorStackCount<u32>
        public uint BuyPrice; // BuyPrice<u32>
        public uint SellPrice; // SellPrice<u32>
        public uint RequiredAbility; // RequiredAbility<u32>
        public int MaxCount; // MaxCount<32>
        public int Stackable; // Stackable<32>
        [Cardinality(10)]
        public int[] StatPercentEditor = new int[10]; // StatPercentEditor<32>[10]
        [Cardinality(10)]
        public float[] StatPercentageOfSocket = new float[10]; // StatPercentageOfSocket[10]
        public int ItemRange; // ItemRange
        public uint BagFamily; // BagFamily<u32>
        public int QualityModifier; // QualityModifier
        public uint DurationInInventory; // DurationInInventory<u32>
        public float DmgVariance; // DmgVariance
        public short AllowableClass; // AllowableClass<16>
        public ushort ItemLevel; // ItemLevel<u16>
        public ushort RequiredSkill; // RequiredSkill<u16>
        public ushort RequiredSkillRank; // RequiredSkillRank<u16>
        public ushort MinFactionID; // MinFactionID<u16>
        [Cardinality(10)]
        public short[] StatModifier_bonusAmount = new short[10]; // StatModifier_bonusAmount<16>[10]
        public ushort ScalingStatDistributionID; // ScalingStatDistributionID<u16>
        public ushort ItemDelay; // ItemDelay<u16>
        public ushort PageID; // PageID<u16>
        public ushort StartQuestID; // StartQuestID<u16>
        public ushort LockID; // LockID<u16>
        public ushort RandomSelect; // RandomSelect<u16>
        public ushort ItemRandomSuffixGroupID; // ItemRandomSuffixGroupID<u16>
        public ushort ItemSet; // ItemSet<u16>
        public ushort ZoneBound; // ZoneBound<u16>
        public ushort InstanceBound; // InstanceBound<u16>
        public ushort TotemCategoryID; // TotemCategoryID<u16>
        public ushort Socket_match_enchantment_ID; // Socket_match_enchantment_ID<u16>
        public ushort Gem_properties; // Gem_properties<u16>
        public ushort LimitCategory; // LimitCategory<u16>
        public ushort RequiredHoliday; // RequiredHoliday<u16>
        public ushort RequiredTransmogHoliday; // RequiredTransmogHoliday<u16>
        public ushort ItemNameDescriptionID; // ItemNameDescriptionID<u16>
        public byte OverallQualityID; // OverallQualityID<u8>
        public byte InventoryType; // InventoryType<u8>
        public sbyte RequiredLevel; // RequiredLevel<8>
        public byte RequiredPVPRank; // RequiredPVPRank<u8>
        public byte RequiredPVPMedal; // RequiredPVPMedal<u8>
        public byte MinReputation; // MinReputation<u8>
        public byte ContainerSlots; // ContainerSlots<u8>
        [Cardinality(10)]
        public sbyte[] StatModifier_bonusStat = new sbyte[10]; // StatModifier_bonusStat<8>[10]
        public byte Damage_damageType; // Damage_damageType<u8>
        public byte Bonding; // Bonding<u8>
        public byte LanguageID; // LanguageID<u8>
        public byte PageMaterialID; // PageMaterialID<u8>
        public byte Material; // Material<u8>
        public byte SheatheType; // SheatheType<u8>
        [Cardinality(3)]
        public byte[] SocketType = new byte[3]; // SocketType<u8>[3]
        public byte SpellWeightCategory; // SpellWeightCategory<u8>
        public byte SpellWeight; // SpellWeight<u8>
        public byte ArtifactID; // ArtifactID<u8>
        public byte ExpansionID; // ExpansionID<u8>
    }
}
