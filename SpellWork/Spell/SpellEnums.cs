using System;

#pragma warning disable CA1712 // Do not prefix enum values with type name

namespace SpellWork.Spell
{
    // ReSharper disable InconsistentNaming
    /// <summary>
    ///
    /// </summary>
    public enum Difficulty
    {
        DIFFICULTY_NONE                 = 0,
        DIFFICULTY_NORMAL               = 1,
        DIFFICULTY_HEROIC               = 2,
        DIFFICULTY_10_N                 = 3,
        DIFFICULTY_25_N                 = 4,
        DIFFICULTY_10_HC                = 5,
        DIFFICULTY_25_HC                = 6,
        DIFFICULTY_LFR                  = 7,
        DIFFICULTY_MYTHIC_KEYSTONE      = 8,
        DIFFICULTY_40                   = 9,
        DIFFICULTY_3_MAN_SCENARIO_HC    = 11,
        DIFFICULTY_3_MAN_SCENARIO_N     = 12,
        DIFFICULTY_NORMAL_RAID          = 14,
        DIFFICULTY_HEROIC_RAID          = 15,
        DIFFICULTY_MYTHIC_RAID          = 16,
        DIFFICULTY_LFR_NEW              = 17,
        DIFFICULTY_EVENT_RAID           = 18,
        DIFFICULTY_EVENT_DUNGEON        = 19,
        DIFFICULTY_EVENT_SCENARIO       = 20,
        DIFFICULTY_MYTHIC               = 23,
        DIFFICULTY_TIMEWALKING          = 24,
        DIFFICULTY_WORLD_PVP_SCENARIO   = 25,
        DIFFICULTY_5_MAN_SCENARIO_N     = 26,
        DIFFICULTY_20_MAN_SCENARIO_N    = 27,
        DIFFICULTY_PVEVP_SCENARIO       = 29,
        DIFFICULTY_EVENT_SCENARIO_6     = 30,
        DIFFICULTY_WORLD_PVP_SCENARIO_2 = 32,
        DIFFICULTY_TIMEWALKING_RAID     = 33,
        DIFFICULTY_PVP                  = 34,
        DIFFICULTY_NORMAL_ISLAND        = 38,
        DIFFICULTY_HEROIC_ISLAND        = 39,
        DIFFICULTY_MYTHIC_ISLAND        = 40,
        DIFFICULTY_PVP_ISLAND           = 45,
        DIFFICULTY_NORMAL_WARFRONT      = 147,
        DIFFICULTY_HEROIC_WARFRONT      = 149,
        DIFFICULTY_LFR_15TH_ANNIVERSARY = 151,
        DIFFICULTY_VISIONS_OF_NZOTH     = 152,
        DIFFICULTY_TEEMING_ISLAND       = 153
    };

    /// <summary>
    ///
    /// </summary>
    public enum SpellFamilyNames
    {
        SPELLFAMILY_GENERIC = 0,
        SPELLFAMILY_EVENTS = 1, // events, holidays
        // unused               = 2,
        SPELLFAMILY_MAGE = 3,
        SPELLFAMILY_WARRIOR = 4,
        SPELLFAMILY_WARLOCK = 5,
        SPELLFAMILY_PRIEST = 6,
        SPELLFAMILY_DRUID = 7,
        SPELLFAMILY_ROGUE = 8,
        SPELLFAMILY_HUNTER = 9,
        SPELLFAMILY_PALADIN = 10,
        SPELLFAMILY_SHAMAN = 11,
        SPELLFAMILY_UNK2 = 12, // 2 spells (silence resistance)
        SPELLFAMILY_POTION = 13,
        // unused               = 14,
        SPELLFAMILY_DEATHKNIGHT = 15,
        // unused               = 16,
        SPELLFAMILY_PET = 17,
        SPELLFAMILY_TOTEMS = 50,     // new totem spells?
        SPELLFAMILY_UNK52 = 52,     //
        SPELLFAMILY_MONK = 53,     //
        SPELLFAMILY_UNK54 = 54,     // no spells
        SPELLFAMILY_WARLOCK_PET = 57,     // only warlock pet spells
        SPELLFAMILY_UNK66 = 66,     // 2 spells
        SPELLFAMILY_UNK71 = 71,     // 2 spells
        SPELLFAMILY_UNK78 = 78,     // only  Zhao-Jin's spear spell
        SPELLFAMILY_UNK91 = 91,     // only Gara'jal the Spiritbinder spells
        SPELLFAMILY_UNK100 = 100,   // smoke bomb
        SPELLFAMILY_DEMON_HUNTER = 107,
        SPELLFAMILY_EVOKER = 224
    };

    /// <summary>
    ///
    /// </summary>
    public enum SpellEffects
    {
        SPELL_EFFECT_NONE                               = 0,
        SPELL_EFFECT_INSTAKILL                          = 1,
        SPELL_EFFECT_SCHOOL_DAMAGE                      = 2,
        SPELL_EFFECT_DUMMY                              = 3,
        SPELL_EFFECT_PORTAL_TELEPORT                    = 4, // Unused (4.3.4)
        SPELL_EFFECT_5                                  = 5,
        SPELL_EFFECT_APPLY_AURA                         = 6,
        SPELL_EFFECT_ENVIRONMENTAL_DAMAGE               = 7,
        SPELL_EFFECT_POWER_DRAIN                        = 8,
        SPELL_EFFECT_HEALTH_LEECH                       = 9,
        SPELL_EFFECT_HEAL                               = 10,
        SPELL_EFFECT_BIND                               = 11,
        SPELL_EFFECT_PORTAL                             = 12,
        SPELL_EFFECT_TELEPORT_TO_RETURN_POINT           = 13, // MiscValueA = spellid of the aura holding destination
        SPELL_EFFECT_INCREASE_CURRENCY_CAP              = 14,
        SPELL_EFFECT_TELEPORT_WITH_SPELL_VISUAL_KIT_LOADING_SCREEN = 15, // MiscValueA = delay, MiscValueB = SpellVisualKitId
        SPELL_EFFECT_QUEST_COMPLETE                     = 16,
        SPELL_EFFECT_WEAPON_DAMAGE_NOSCHOOL             = 17,
        SPELL_EFFECT_RESURRECT                          = 18,
        SPELL_EFFECT_ADD_EXTRA_ATTACKS                  = 19,
        SPELL_EFFECT_DODGE                              = 20,
        SPELL_EFFECT_EVADE                              = 21,
        SPELL_EFFECT_PARRY                              = 22,
        SPELL_EFFECT_BLOCK                              = 23,
        SPELL_EFFECT_CREATE_ITEM                        = 24,
        SPELL_EFFECT_WEAPON                             = 25,
        SPELL_EFFECT_DEFENSE                            = 26,
        SPELL_EFFECT_PERSISTENT_AREA_AURA               = 27,
        SPELL_EFFECT_SUMMON                             = 28,
        SPELL_EFFECT_LEAP                               = 29,
        SPELL_EFFECT_ENERGIZE                           = 30,
        SPELL_EFFECT_WEAPON_PERCENT_DAMAGE              = 31,
        SPELL_EFFECT_TRIGGER_MISSILE                    = 32,
        SPELL_EFFECT_OPEN_LOCK                          = 33,
        SPELL_EFFECT_SUMMON_CHANGE_ITEM                 = 34,
        SPELL_EFFECT_APPLY_AREA_AURA_PARTY              = 35,
        SPELL_EFFECT_LEARN_SPELL                        = 36,
        SPELL_EFFECT_SPELL_DEFENSE                      = 37,
        SPELL_EFFECT_DISPEL                             = 38,
        SPELL_EFFECT_LANGUAGE                           = 39,
        SPELL_EFFECT_DUAL_WIELD                         = 40,
        SPELL_EFFECT_JUMP                               = 41,
        SPELL_EFFECT_JUMP_DEST                          = 42,
        SPELL_EFFECT_TELEPORT_UNITS_FACE_CASTER         = 43,
        SPELL_EFFECT_SKILL_STEP                         = 44,
        SPELL_EFFECT_PLAY_MOVIE                         = 45,
        SPELL_EFFECT_SPAWN                              = 46,
        SPELL_EFFECT_TRADE_SKILL                        = 47,
        SPELL_EFFECT_STEALTH                            = 48,
        SPELL_EFFECT_DETECT                             = 49,
        SPELL_EFFECT_TRANS_DOOR                         = 50,
        SPELL_EFFECT_FORCE_CRITICAL_HIT                 = 51, // Unused (4.3.4)
        SPELL_EFFECT_SET_MAX_BATTLE_PET_COUNT           = 52,
        SPELL_EFFECT_ENCHANT_ITEM                       = 53,
        SPELL_EFFECT_ENCHANT_ITEM_TEMPORARY             = 54,
        SPELL_EFFECT_TAMECREATURE                       = 55,
        SPELL_EFFECT_SUMMON_PET                         = 56,
        SPELL_EFFECT_LEARN_PET_SPELL                    = 57,
        SPELL_EFFECT_WEAPON_DAMAGE                      = 58,
        SPELL_EFFECT_CREATE_RANDOM_ITEM                 = 59,
        SPELL_EFFECT_PROFICIENCY                        = 60,
        SPELL_EFFECT_SEND_EVENT                         = 61,
        SPELL_EFFECT_POWER_BURN                         = 62,
        SPELL_EFFECT_THREAT                             = 63,
        SPELL_EFFECT_TRIGGER_SPELL                      = 64,
        SPELL_EFFECT_APPLY_AREA_AURA_RAID               = 65,
        SPELL_EFFECT_RECHARGE_ITEM                      = 66,
        SPELL_EFFECT_HEAL_MAX_HEALTH                    = 67,
        SPELL_EFFECT_INTERRUPT_CAST                     = 68,
        SPELL_EFFECT_DISTRACT                           = 69,
        SPELL_EFFECT_COMPLETE_AND_REWARD_WORLD_QUEST    = 70,
        SPELL_EFFECT_PICKPOCKET                         = 71,
        SPELL_EFFECT_ADD_FARSIGHT                       = 72,
        SPELL_EFFECT_UNTRAIN_TALENTS                    = 73,
        SPELL_EFFECT_APPLY_GLYPH                        = 74,
        SPELL_EFFECT_HEAL_MECHANICAL                    = 75,
        SPELL_EFFECT_SUMMON_OBJECT_WILD                 = 76,
        SPELL_EFFECT_SCRIPT_EFFECT                      = 77,
        SPELL_EFFECT_ATTACK                             = 78,
        SPELL_EFFECT_SANCTUARY                          = 79,
        SPELL_EFFECT_MODIFY_FOLLOWER_ITEM_LEVEL         = 80,
        SPELL_EFFECT_PUSH_ABILITY_TO_ACTION_BAR         = 81,
        SPELL_EFFECT_BIND_SIGHT                         = 82,
        SPELL_EFFECT_DUEL                               = 83,
        SPELL_EFFECT_STUCK                              = 84,
        SPELL_EFFECT_SUMMON_PLAYER                      = 85,
        SPELL_EFFECT_ACTIVATE_OBJECT                    = 86,
        SPELL_EFFECT_GAMEOBJECT_DAMAGE                  = 87,
        SPELL_EFFECT_GAMEOBJECT_REPAIR                  = 88,
        SPELL_EFFECT_GAMEOBJECT_SET_DESTRUCTION_STATE   = 89,
        SPELL_EFFECT_KILL_CREDIT                        = 90,
        SPELL_EFFECT_THREAT_ALL                         = 91,
        SPELL_EFFECT_ENCHANT_HELD_ITEM                  = 92,
        SPELL_EFFECT_FORCE_DESELECT                     = 93,
        SPELL_EFFECT_SELF_RESURRECT                     = 94,
        SPELL_EFFECT_SKINNING                           = 95,
        SPELL_EFFECT_CHARGE                             = 96,
        SPELL_EFFECT_CAST_BUTTON                        = 97,
        SPELL_EFFECT_KNOCK_BACK                         = 98,
        SPELL_EFFECT_DISENCHANT                         = 99,
        SPELL_EFFECT_INEBRIATE                          = 100,
        SPELL_EFFECT_FEED_PET                           = 101,
        SPELL_EFFECT_DISMISS_PET                        = 102,
        SPELL_EFFECT_REPUTATION                         = 103,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT1                = 104,
        SPELL_EFFECT_SURVEY                             = 105,
        SPELL_EFFECT_CHANGE_RAID_MARKER                 = 106,
        SPELL_EFFECT_SHOW_CORPSE_LOOT                   = 107,
        SPELL_EFFECT_DISPEL_MECHANIC                    = 108,
        SPELL_EFFECT_RESURRECT_PET                      = 109,
        SPELL_EFFECT_DESTROY_ALL_TOTEMS                 = 110,
        SPELL_EFFECT_DURABILITY_DAMAGE                  = 111,
        SPELL_EFFECT_112                                = 112,
        SPELL_EFFECT_CANCEL_CONVERSATION                = 113,
        SPELL_EFFECT_ATTACK_ME                          = 114,
        SPELL_EFFECT_DURABILITY_DAMAGE_PCT              = 115,
        SPELL_EFFECT_SKIN_PLAYER_CORPSE                 = 116,
        SPELL_EFFECT_SPIRIT_HEAL                        = 117,
        SPELL_EFFECT_SKILL                              = 118,
        SPELL_EFFECT_APPLY_AREA_AURA_PET                = 119,
        SPELL_EFFECT_TELEPORT_GRAVEYARD                 = 120,
        SPELL_EFFECT_NORMALIZED_WEAPON_DMG              = 121,
        SPELL_EFFECT_122                                = 122,
        SPELL_EFFECT_SEND_TAXI                          = 123,
        SPELL_EFFECT_PULL_TOWARDS                       = 124,
        SPELL_EFFECT_MODIFY_THREAT_PERCENT              = 125,
        SPELL_EFFECT_STEAL_BENEFICIAL_BUFF              = 126,
        SPELL_EFFECT_PROSPECTING                        = 127,
        SPELL_EFFECT_APPLY_AREA_AURA_FRIEND             = 128,
        SPELL_EFFECT_APPLY_AREA_AURA_ENEMY              = 129,
        SPELL_EFFECT_REDIRECT_THREAT                    = 130,
        SPELL_EFFECT_PLAY_SOUND                         = 131,
        SPELL_EFFECT_PLAY_MUSIC                         = 132,
        SPELL_EFFECT_UNLEARN_SPECIALIZATION             = 133,
        SPELL_EFFECT_KILL_CREDIT2                       = 134,
        SPELL_EFFECT_CALL_PET                           = 135,
        SPELL_EFFECT_HEAL_PCT                           = 136,
        SPELL_EFFECT_ENERGIZE_PCT                       = 137,
        SPELL_EFFECT_LEAP_BACK                          = 138,
        SPELL_EFFECT_CLEAR_QUEST                        = 139,
        SPELL_EFFECT_FORCE_CAST                         = 140,
        SPELL_EFFECT_FORCE_CAST_WITH_VALUE              = 141,
        SPELL_EFFECT_TRIGGER_SPELL_WITH_VALUE           = 142,
        SPELL_EFFECT_APPLY_AREA_AURA_OWNER              = 143,
        SPELL_EFFECT_KNOCK_BACK_DEST                    = 144,
        SPELL_EFFECT_PULL_TOWARDS_DEST                  = 145,
        SPELL_EFFECT_RESTORE_GARRISON_TROOP_VITALITY    = 146,
        SPELL_EFFECT_QUEST_FAIL                         = 147,
        SPELL_EFFECT_TRIGGER_MISSILE_SPELL_WITH_VALUE   = 148,
        SPELL_EFFECT_CHARGE_DEST                        = 149,
        SPELL_EFFECT_QUEST_START                        = 150,
        SPELL_EFFECT_TRIGGER_SPELL_2                    = 151,
        SPELL_EFFECT_SUMMON_RAF_FRIEND                  = 152,
        SPELL_EFFECT_CREATE_TAMED_PET                   = 153,
        SPELL_EFFECT_DISCOVER_TAXI                      = 154,
        SPELL_EFFECT_TITAN_GRIP                         = 155,
        SPELL_EFFECT_ENCHANT_ITEM_PRISMATIC             = 156,
        SPELL_EFFECT_CREATE_LOOT                        = 157, // crafting loot
        SPELL_EFFECT_MILLING                            = 158,
        SPELL_EFFECT_ALLOW_RENAME_PET                   = 159,
        SPELL_EFFECT_FORCE_CAST_2                       = 160,
        SPELL_EFFECT_TALENT_SPEC_COUNT                  = 161,
        SPELL_EFFECT_TALENT_SPEC_SELECT                 = 162,
        SPELL_EFFECT_OBLITERATE_ITEM                    = 163,
        SPELL_EFFECT_REMOVE_AURA                        = 164,
        SPELL_EFFECT_DAMAGE_FROM_MAX_HEALTH_PCT         = 165,
        SPELL_EFFECT_GIVE_CURRENCY                      = 166,
        SPELL_EFFECT_UPDATE_PLAYER_PHASE                = 167,
        SPELL_EFFECT_ALLOW_CONTROL_PET                  = 168, // NYI
        SPELL_EFFECT_DESTROY_ITEM                       = 169,
        SPELL_EFFECT_UPDATE_ZONE_AURAS_AND_PHASES       = 170, // NYI
        SPELL_EFFECT_SUMMON_PERSONAL_GAMEOBJECT         = 171, // Summons gamebject
        SPELL_EFFECT_RESURRECT_WITH_AURA                = 172,
        SPELL_EFFECT_UNLOCK_GUILD_VAULT_TAB             = 173, // Guild tab unlocked (guild perk)
        SPELL_EFFECT_APPLY_AURA_ON_PET                  = 174, // NYI
        SPELL_EFFECT_175                                = 175,
        SPELL_EFFECT_SANCTUARY_2                        = 176, // NYI
        SPELL_EFFECT_DESPAWN_PERSISTENT_AREA_AURA       = 177,
        SPELL_EFFECT_178                                = 178,
        SPELL_EFFECT_CREATE_AREATRIGGER                 = 179,
        SPELL_EFFECT_UPDATE_AREATRIGGER                 = 180, // NYI
        SPELL_EFFECT_REMOVE_TALENT                      = 181,
        SPELL_EFFECT_DESPAWN_AREATRIGGER                = 182,
        SPELL_EFFECT_183                                = 183,
        SPELL_EFFECT_REPUTATION_2                       = 184,
        SPELL_EFFECT_185                                = 185,
        SPELL_EFFECT_186                                = 186,
        SPELL_EFFECT_RANDOMIZE_ARCHAEOLOGY_DIGSITES     = 187, // NYI
        SPELL_EFFECT_SUMMON_STABLED_PET_AS_GUARDIAN     = 188,
        SPELL_EFFECT_LOOT                               = 189, // NYI, lootid in MiscValue ?
        SPELL_EFFECT_CHANGE_PARTY_MEMBERS               = 190, // MiscValueA = 1 is join, MiscValueA = 0 is leave - used by NPCs
        SPELL_EFFECT_TELEPORT_TO_DIGSITE                = 191, // NYI
        SPELL_EFFECT_UNCAGE_BATTLEPET                   = 192,
        SPELL_EFFECT_START_PET_BATTLE                   = 193,
        SPELL_EFFECT_194                                = 194,
        SPELL_EFFECT_PLAY_SCENE_SCRIPT_PACKAGE          = 195,
        SPELL_EFFECT_CREATE_SCENE_OBJECT                = 196, // MiscValueA = SceneId, goes into guid as entry, SceneScriptPackageId goes into ObjectData::Entry
        SPELL_EFFECT_CREATE_PERSONAL_SCENE_OBJECT       = 197, // MiscValueA = SceneId, goes into guid as entry, SceneScriptPackageId goes into ObjectData::Entry
        SPELL_EFFECT_PLAY_SCENE                         = 198,
        SPELL_EFFECT_DESPAWN_SUMMON                     = 199, // MiscValueA is some kind of unknown internal id
        SPELL_EFFECT_HEAL_BATTLEPET_PCT                 = 200, // NYI
        SPELL_EFFECT_ENABLE_BATTLE_PETS                 = 201, // NYI
        SPELL_EFFECT_APPLY_AREA_AURA_SUMMONS            = 202,
        SPELL_EFFECT_REMOVE_AURA_2                      = 203,
        SPELL_EFFECT_CHANGE_BATTLEPET_QUALITY           = 204,
        SPELL_EFFECT_LAUNCH_QUEST_CHOICE                = 205,
        SPELL_EFFECT_ALTER_ITEM                         = 206, // NYI
        SPELL_EFFECT_LAUNCH_QUEST_TASK                  = 207, // Starts one of the "progress bar" quests
        SPELL_EFFECT_SET_REPUTATION                     = 208,
        SPELL_EFFECT_209                                = 209,
        SPELL_EFFECT_LEARN_GARRISON_BUILDING            = 210,
        SPELL_EFFECT_LEARN_GARRISON_SPECIALIZATION      = 211,
        SPELL_EFFECT_REMOVE_AURA_BY_SPELL_LABEL         = 212,
        SPELL_EFFECT_JUMP_DEST_2                        = 213,
        SPELL_EFFECT_CREATE_GARRISON                    = 214,
        SPELL_EFFECT_UPGRADE_CHARACTER_SPELLS           = 215, // Unlocks boosted players' spells (ChrUpgrade*.db2)
        SPELL_EFFECT_CREATE_SHIPMENT                    = 216,
        SPELL_EFFECT_UPGRADE_GARRISON                   = 217,
        SPELL_EFFECT_218                                = 218,
        SPELL_EFFECT_CREATE_CONVERSATION                = 219,
        SPELL_EFFECT_ADD_GARRISON_FOLLOWER              = 220,
        SPELL_EFFECT_ADD_GARRISON_MISSION               = 221,
        SPELL_EFFECT_CREATE_HEIRLOOM_ITEM               = 222,
        SPELL_EFFECT_CHANGE_ITEM_BONUSES                = 223,
        SPELL_EFFECT_ACTIVATE_GARRISON_BUILDING         = 224,
        SPELL_EFFECT_GRANT_BATTLEPET_LEVEL              = 225,
        SPELL_EFFECT_TRIGGER_ACTION_SET                 = 226,
        SPELL_EFFECT_TELEPORT_TO_LFG_DUNGEON            = 227,
        SPELL_EFFECT_228                                = 228,
        SPELL_EFFECT_SET_FOLLOWER_QUALITY               = 229,
        SPELL_EFFECT_230                                = 230,
        SPELL_EFFECT_INCREASE_FOLLOWER_EXPERIENCE       = 231,
        SPELL_EFFECT_REMOVE_PHASE                       = 232,
        SPELL_EFFECT_RANDOMIZE_FOLLOWER_ABILITIES       = 233,
        SPELL_EFFECT_234                                = 234,
        SPELL_EFFECT_235                                = 235,
        SPELL_EFFECT_GIVE_EXPERIENCE                    = 236, // Increases players XP
        SPELL_EFFECT_GIVE_RESTED_EXPERIENCE_BONUS       = 237,
        SPELL_EFFECT_INCREASE_SKILL                     = 238,
        SPELL_EFFECT_END_GARRISON_BUILDING_CONSTRUCTION = 239, // Instantly finishes building construction
        SPELL_EFFECT_GIVE_ARTIFACT_POWER                = 240,
        SPELL_EFFECT_241                                = 241,
        SPELL_EFFECT_GIVE_ARTIFACT_POWER_NO_BONUS       = 242, // Unaffected by Artifact Knowledge
        SPELL_EFFECT_APPLY_ENCHANT_ILLUSION             = 243,
        SPELL_EFFECT_LEARN_FOLLOWER_ABILITY             = 244,
        SPELL_EFFECT_UPGRADE_HEIRLOOM                   = 245,
        SPELL_EFFECT_FINISH_GARRISON_MISSION            = 246,
        SPELL_EFFECT_ADD_GARRISON_MISSION_SET           = 247,
        SPELL_EFFECT_FINISH_SHIPMENT                    = 248,
        SPELL_EFFECT_FORCE_EQUIP_ITEM                   = 249,
        SPELL_EFFECT_TAKE_SCREENSHOT                    = 250, // Serverside marker for selfie screenshot - achievement check
        SPELL_EFFECT_SET_GARRISON_CACHE_SIZE            = 251,
        SPELL_EFFECT_TELEPORT_UNITS                     = 252,
        SPELL_EFFECT_GIVE_HONOR                         = 253,
        SPELL_EFFECT_JUMP_CHARGE                        = 254,
        SPELL_EFFECT_LEARN_TRANSMOG_SET                 = 255,
        SPELL_EFFECT_256                                = 256,
        SPELL_EFFECT_257                                = 257,
        SPELL_EFFECT_MODIFY_KEYSTONE                    = 258,
        SPELL_EFFECT_RESPEC_AZERITE_EMPOWERED_ITEM      = 259,
        SPELL_EFFECT_SUMMON_STABLED_PET                 = 260,
        SPELL_EFFECT_SCRAP_ITEM                         = 261,
        SPELL_EFFECT_262                                = 262,
        SPELL_EFFECT_REPAIR_ITEM                        = 263,
        SPELL_EFFECT_REMOVE_GEM                         = 264,
        SPELL_EFFECT_LEARN_AZERITE_ESSENCE_POWER        = 265,
        SPELL_EFFECT_SET_ITEM_BONUS_LIST_GROUP_ENTRY    = 266, // Sets item bonuses to specific ItemBonusListGroupEntry id
        SPELL_EFFECT_CREATE_PRIVATE_CONVERSATION        = 267,
        SPELL_EFFECT_APPLY_MOUNT_EQUIPMENT              = 268,
        SPELL_EFFECT_INCREASE_ITEM_BONUS_LIST_GROUP_STEP= 269, // Advances ItemBonusListGroup bonuses to next rank
        SPELL_EFFECT_270                                = 270,
        SPELL_EFFECT_APPLY_AREA_AURA_PARTY_NONRANDOM    = 271,
        SPELL_EFFECT_SET_COVENANT                       = 272,
        SPELL_EFFECT_CRAFT_RUNEFORGE_LEGENDARY          = 273,
        SPELL_EFFECT_274                                = 274,
        SPELL_EFFECT_275                                = 275,
        SPELL_EFFECT_LEARN_TRANSMOG_ILLUSION            = 276,
        SPELL_EFFECT_SET_CHROMIE_TIME                   = 277,
        SPELL_EFFECT_278                                = 278,
        SPELL_EFFECT_LEARN_GARR_TALENT                  = 279,
        SPELL_EFFECT_280                                = 280,
        SPELL_EFFECT_LEARN_SOULBIND_CONDUIT             = 281,
        SPELL_EFFECT_CONVERT_ITEMS_TO_CURRENCY          = 282,
        SPELL_EFFECT_COMPLETE_CAMPAIGN                  = 283, // Flags all quests as completed that are assigned to campaign (MiscValueA)
        SPELL_EFFECT_SEND_CHAT_MESSAGE                  = 284, // MiscValue[0] = BroadcastTextID, MiscValue[1] = ChatType
        SPELL_EFFECT_MODIFY_KEYSTONE_2                  = 285,
        SPELL_EFFECT_GRANT_BATTLEPET_EXPERIENCE         = 286,
        SPELL_EFFECT_SET_GARRISON_FOLLOWER_LEVEL        = 287,
        SPELL_EFFECT_CRAFT_ITEM                         = 288, // MiscValue[0] = CraftingDataID
        SPELL_EFFECT_MODIFY_AURA_STACKS                 = 289, // MiscValue[0] = 0 means add, = 1 means set
        SPELL_EFFECT_MODIFY_COOLDOWN                    = 290,
        SPELL_EFFECT_MODIFY_COOLDOWNS                   = 291, // MiscValue[0] = SpellFamily, MiscValue[1] = maybe bit index for family flags? off by 1 for the only spell using this effect
        SPELL_EFFECT_MODIFY_COOLDOWNS_BY_CATEGORY       = 292, // MiscValue[0] = category
        SPELL_EFFECT_MODIFY_CHARGES                     = 293, // MiscValue[0] = charge category
        SPELL_EFFECT_CRAFT_LOOT                         = 294, // MiscValue[0] = CraftingDataID
        SPELL_EFFECT_SALVAGE_ITEM                       = 295, // MiscValue[0] = ItemSalvageID
        SPELL_EFFECT_CRAFT_SALVAGE_ITEM                 = 296, // MiscValue[0] = ItemSalvageID, MiscValue[1] = CraftingDataID
        SPELL_EFFECT_RECRAFT_ITEM                       = 297,
        SPELL_EFFECT_CANCEL_ALL_PRIVATE_CONVERSATIONS   = 298,
        SPELL_EFFECT_299                                = 299, // something with items, as of 10.0.2 all spells are named "Downgrading"
        SPELL_EFFECT_300                                = 300,
        SPELL_EFFECT_CRAFT_ENCHANT                      = 301, // MiscValue[0] = CraftingDataID, MiscValue[1] = ?
        SPELL_EFFECT_GATHERING                          = 302,
        SPELL_EFFECT_CREATE_TRAIT_TREE_CONFIG           = 303, // MiscValue[0] = TraitTreeID
        SPELL_EFFECT_CHANGE_ACTIVE_COMBAT_TRAIT_CONFIG  = 304,
        SPELL_EFFECT_305                                = 305,
        SPELL_EFFECT_UPDATE_INTERACTIONS                = 306,
        SPELL_EFFECT_307                                = 307,
        SPELL_EFFECT_CANCEL_PRELOAD_WORLD               = 308,
        SPELL_EFFECT_PRELOAD_WORLD                      = 309,
        SPELL_EFFECT_310                                = 310,
        SPELL_EFFECT_ENSURE_WORLD_LOADED                = 311,
        SPELL_EFFECT_312                                = 312,
        SPELL_EFFECT_CHANGE_ITEM_BONUSES_2              = 313, // MiscValue[0] = ItemBonusTreeID to preserve
        SPELL_EFFECT_ADD_SOCKET_BONUS                   = 314, // MiscValue[0] = required ItemBonusTreeID
        SPELL_EFFECT_LEARN_TRANSMOG_APPEARANCE_FROM_ITEM_MOD_APPEARANCE_GROUP = 315, // MiscValue[0] = ItemModAppearanceGroupID (not in db2)
        SPELL_EFFECT_316                                = 316,
        SPELL_EFFECT_317                                = 317,
        SPELL_EFFECT_318                                = 318,
        SPELL_EFFECT_319                                = 319,
        SPELL_EFFECT_320                                = 320,
        SPELL_EFFECT_321                                = 321,
        SPELL_EFFECT_322                                = 322,
        SPELL_EFFECT_323                                = 323,
        SPELL_EFFECT_324                                = 324,
        SPELL_EFFECT_325                                = 325,
        SPELL_EFFECT_326                                = 326,
        SPELL_EFFECT_PULL                               = 327,
        SPELL_EFFECT_ADD_COMBO_POINTS                   = 328,
        SPELL_EFFECT_RESURRECT_NEW                      = 329,
        SPELL_EFFECT_ACTIVATE_RUNE                      = 330,
        TOTAL_SPELL_EFFECTS
    };

    /// <summary>
    ///
    /// </summary>
    public enum AuraType
    {
        SPELL_AURA_NONE                                         = 0,
        SPELL_AURA_BIND_SIGHT                                   = 1,
        SPELL_AURA_MOD_POSSESS                                  = 2,
        SPELL_AURA_PERIODIC_DAMAGE                              = 3,
        SPELL_AURA_DUMMY                                        = 4,
        SPELL_AURA_MOD_CONFUSE                                  = 5,
        SPELL_AURA_MOD_CHARM                                    = 6,
        SPELL_AURA_MOD_FEAR                                     = 7,
        SPELL_AURA_PERIODIC_HEAL                                = 8,
        SPELL_AURA_MOD_ATTACKSPEED                              = 9,
        SPELL_AURA_MOD_THREAT                                   = 10,
        SPELL_AURA_MOD_TAUNT                                    = 11,
        SPELL_AURA_MOD_STUN                                     = 12,
        SPELL_AURA_MOD_DAMAGE_DONE                              = 13,
        SPELL_AURA_MOD_DAMAGE_TAKEN                             = 14,
        SPELL_AURA_DAMAGE_SHIELD                                = 15,
        SPELL_AURA_MOD_STEALTH                                  = 16,
        SPELL_AURA_MOD_STEALTH_DETECT                           = 17,
        SPELL_AURA_MOD_INVISIBILITY                             = 18,
        SPELL_AURA_MOD_INVISIBILITY_DETECT                      = 19,
        SPELL_AURA_OBS_MOD_HEALTH                               = 20,   // 20, 21 unofficial
        SPELL_AURA_OBS_MOD_POWER                                = 21,
        SPELL_AURA_MOD_RESISTANCE                               = 22,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL                       = 23,
        SPELL_AURA_PERIODIC_ENERGIZE                            = 24,
        SPELL_AURA_MOD_PACIFY                                   = 25,
        SPELL_AURA_MOD_ROOT                                     = 26,
        SPELL_AURA_MOD_SILENCE                                  = 27,
        SPELL_AURA_REFLECT_SPELLS                               = 28,
        SPELL_AURA_MOD_STAT                                     = 29,
        SPELL_AURA_MOD_SKILL                                    = 30,
        SPELL_AURA_MOD_INCREASE_SPEED                           = 31,
        SPELL_AURA_MOD_INCREASE_MOUNTED_SPEED                   = 32,
        SPELL_AURA_MOD_DECREASE_SPEED                           = 33,
        SPELL_AURA_MOD_INCREASE_HEALTH                          = 34,
        SPELL_AURA_MOD_INCREASE_ENERGY                          = 35,
        SPELL_AURA_MOD_SHAPESHIFT                               = 36,
        SPELL_AURA_EFFECT_IMMUNITY                              = 37,
        SPELL_AURA_STATE_IMMUNITY                               = 38,
        SPELL_AURA_SCHOOL_IMMUNITY                              = 39,
        SPELL_AURA_DAMAGE_IMMUNITY                              = 40,
        SPELL_AURA_DISPEL_IMMUNITY                              = 41,
        SPELL_AURA_PROC_TRIGGER_SPELL                           = 42,
        SPELL_AURA_PROC_TRIGGER_DAMAGE                          = 43,
        SPELL_AURA_TRACK_CREATURES                              = 44,
        SPELL_AURA_TRACK_RESOURCES                              = 45,
        SPELL_AURA_46                                           = 46,   // Ignore all Gear test spells
        SPELL_AURA_MOD_PARRY_PERCENT                            = 47,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL_FROM_CLIENT           = 48,   // One periodic spell
        SPELL_AURA_MOD_DODGE_PERCENT                            = 49,
        SPELL_AURA_MOD_CRITICAL_HEALING_AMOUNT                  = 50,
        SPELL_AURA_MOD_BLOCK_PERCENT                            = 51,
        SPELL_AURA_MOD_WEAPON_CRIT_PERCENT                      = 52,
        SPELL_AURA_PERIODIC_LEECH                               = 53,
        SPELL_AURA_MOD_HIT_CHANCE                               = 54,
        SPELL_AURA_MOD_SPELL_HIT_CHANCE                         = 55,
        SPELL_AURA_TRANSFORM                                    = 56,
        SPELL_AURA_MOD_SPELL_CRIT_CHANCE                        = 57,
        SPELL_AURA_MOD_INCREASE_SWIM_SPEED                      = 58,
        SPELL_AURA_MOD_DAMAGE_DONE_CREATURE                     = 59,
        SPELL_AURA_MOD_PACIFY_SILENCE                           = 60,
        SPELL_AURA_MOD_SCALE                                    = 61,
        SPELL_AURA_PERIODIC_HEALTH_FUNNEL                       = 62,
        SPELL_AURA_MOD_ADDITIONAL_POWER_COST                    = 63,
        SPELL_AURA_PERIODIC_MANA_LEECH                          = 64,
        SPELL_AURA_MOD_CASTING_SPEED_NOT_STACK                  = 65,
        SPELL_AURA_FEIGN_DEATH                                  = 66,
        SPELL_AURA_MOD_DISARM                                   = 67,
        SPELL_AURA_MOD_STALKED                                  = 68,
        SPELL_AURA_SCHOOL_ABSORB                                = 69,
        SPELL_AURA_PERIODIC_WEAPON_PERCENT_DAMAGE               = 70,
        SPELL_AURA_STORE_TELEPORT_RETURN_POINT                  = 71,
        SPELL_AURA_MOD_POWER_COST_SCHOOL_PCT                    = 72,
        SPELL_AURA_MOD_BASE_POWER_COST_SCHOOL                   = 73,
        SPELL_AURA_REFLECT_SPELLS_SCHOOL                        = 74,
        SPELL_AURA_MOD_LANGUAGE                                 = 75,
        SPELL_AURA_FAR_SIGHT                                    = 76,
        SPELL_AURA_MECHANIC_IMMUNITY                            = 77,
        SPELL_AURA_MOUNTED                                      = 78,
        SPELL_AURA_MOD_DAMAGE_PERCENT_DONE                      = 79,
        SPELL_AURA_MOD_PERCENT_STAT                             = 80,
        SPELL_AURA_SPLIT_DAMAGE_PCT                             = 81,
        SPELL_AURA_WATER_BREATHING                              = 82,
        SPELL_AURA_MOD_BASE_RESISTANCE                          = 83,
        SPELL_AURA_MOD_REGEN                                    = 84,
        SPELL_AURA_MOD_POWER_REGEN                              = 85,
        SPELL_AURA_CHANNEL_DEATH_ITEM                           = 86,
        SPELL_AURA_MOD_DAMAGE_PERCENT_TAKEN                     = 87,
        SPELL_AURA_MOD_HEALTH_REGEN_PERCENT                     = 88,
        SPELL_AURA_PERIODIC_DAMAGE_PERCENT                      = 89,
        SPELL_AURA_90                                           = 90,   // old SPELL_AURA_MOD_RESIST_CHANCE
        SPELL_AURA_MOD_DETECT_RANGE                             = 91,
        SPELL_AURA_PREVENTS_FLEEING                             = 92,
        SPELL_AURA_MOD_UNATTACKABLE                             = 93,
        SPELL_AURA_INTERRUPT_REGEN                              = 94,
        SPELL_AURA_GHOST                                        = 95,
        SPELL_AURA_SPELL_MAGNET                                 = 96,
        SPELL_AURA_MANA_SHIELD                                  = 97,
        SPELL_AURA_MOD_SKILL_TALENT                             = 98,
        SPELL_AURA_MOD_ATTACK_POWER                             = 99,
        SPELL_AURA_AURAS_VISIBLE                                = 100,
        SPELL_AURA_MOD_RESISTANCE_PCT                           = 101,
        SPELL_AURA_MOD_MELEE_ATTACK_POWER_VERSUS                = 102,
        SPELL_AURA_MOD_TOTAL_THREAT                             = 103,
        SPELL_AURA_WATER_WALK                                   = 104,
        SPELL_AURA_FEATHER_FALL                                 = 105,
        SPELL_AURA_HOVER                                        = 106,
        SPELL_AURA_ADD_FLAT_MODIFIER                            = 107,
        SPELL_AURA_ADD_PCT_MODIFIER                             = 108,
        SPELL_AURA_ADD_TARGET_TRIGGER                           = 109,
        SPELL_AURA_MOD_POWER_REGEN_PERCENT                      = 110,
        SPELL_AURA_INTERCEPT_MELEE_RANGED_ATTACKS               = 111,
        SPELL_AURA_OVERRIDE_CLASS_SCRIPTS                       = 112,
        SPELL_AURA_MOD_RANGED_DAMAGE_TAKEN                      = 113,
        SPELL_AURA_MOD_RANGED_DAMAGE_TAKEN_PCT                  = 114,
        SPELL_AURA_MOD_HEALING                                  = 115,
        SPELL_AURA_MOD_REGEN_DURING_COMBAT                      = 116,
        SPELL_AURA_MOD_MECHANIC_RESISTANCE                      = 117,
        SPELL_AURA_MOD_HEALING_PCT                              = 118,
        SPELL_AURA_PVP_TALENTS                                  = 119,
        SPELL_AURA_UNTRACKABLE                                  = 120,
        SPELL_AURA_EMPATHY                                      = 121,
        SPELL_AURA_MOD_OFFHAND_DAMAGE_PCT                       = 122,
        SPELL_AURA_MOD_TARGET_RESISTANCE                        = 123,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER                      = 124,
        SPELL_AURA_125                                          = 125,
        SPELL_AURA_MOD_MELEE_DAMAGE_TAKEN_PCT                   = 126,
        SPELL_AURA_RANGED_ATTACK_POWER_ATTACKER_BONUS           = 127,
        SPELL_AURA_MOD_FIXATE                                   = 128,
        SPELL_AURA_MOD_SPEED_ALWAYS                             = 129,
        SPELL_AURA_MOD_MOUNTED_SPEED_ALWAYS                     = 130,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_VERSUS               = 131,
        SPELL_AURA_MOD_INCREASE_ENERGY_PERCENT                  = 132,
        SPELL_AURA_MOD_INCREASE_HEALTH_PERCENT                  = 133,
        SPELL_AURA_MOD_MANA_REGEN_INTERRUPT                     = 134,
        SPELL_AURA_MOD_HEALING_DONE                             = 135,
        SPELL_AURA_MOD_HEALING_DONE_PERCENT                     = 136,
        SPELL_AURA_MOD_TOTAL_STAT_PERCENTAGE                    = 137,
        SPELL_AURA_MOD_MELEE_HASTE                              = 138,
        SPELL_AURA_FORCE_REACTION                               = 139,
        SPELL_AURA_MOD_RANGED_HASTE                             = 140,
        SPELL_AURA_141                                          = 141,  // old SPELL_AURA_MOD_RANGED_AMMO_HASTE, unused now
        SPELL_AURA_MOD_BASE_RESISTANCE_PCT                      = 142,
        SPELL_AURA_MOD_RECOVERY_RATE_BY_SPELL_LABEL             = 143,  // NYI
        SPELL_AURA_SAFE_FALL                                    = 144,
        SPELL_AURA_MOD_INCREASE_HEALTH_PERCENT2                 = 145,
        SPELL_AURA_ALLOW_TAME_PET_TYPE                          = 146,
        SPELL_AURA_MECHANIC_IMMUNITY_MASK                       = 147,
        SPELL_AURA_MOD_CHARGE_RECOVERY_RATE                     = 148,  // NYI
        SPELL_AURA_REDUCE_PUSHBACK                              = 149,  //    Reduce Pushback
        SPELL_AURA_MOD_BLOCKVALUE_PCT                           = 150,  // NYI
        SPELL_AURA_TRACK_STEALTHED                              = 151,  //    Track Stealthed
        SPELL_AURA_MOD_DETECTED_RANGE                           = 152,  //    Mod Detected Range
        SPELL_AURA_MOD_AUTOATTACK_RANGE                         = 153,
        SPELL_AURA_MOD_STEALTH_LEVEL                            = 154,  //    Stealth Level Modifier
        SPELL_AURA_MOD_WATER_BREATHING                          = 155,  //    Mod Water Breathing
        SPELL_AURA_MOD_REPUTATION_GAIN                          = 156,  //    Mod Reputation Gain
        SPELL_AURA_MOD_PET_DAMAGE_TAKEN_PCT                     = 157,  // NYI
        SPELL_AURA_ALLOW_TALENT_SWAPPING                        = 158,
        SPELL_AURA_NO_PVP_CREDIT                                = 159,
        SPELL_AURA_160                                          = 160,  // old SPELL_AURA_MOD_AOE_AVOIDANCE. Unused 4.3.4
        SPELL_AURA_MOD_HEALTH_REGEN_IN_COMBAT                   = 161,
        SPELL_AURA_POWER_BURN                                   = 162,
        SPELL_AURA_MOD_CRIT_DAMAGE_BONUS                        = 163,
        SPELL_AURA_FORCE_BREATH_BAR                             = 164,
        SPELL_AURA_165                                          = 165,
        SPELL_AURA_MOD_ATTACK_POWER_PCT                         = 166,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_PCT                  = 167,
        SPELL_AURA_MOD_DAMAGE_DONE_VERSUS                       = 168,
        SPELL_AURA_SET_FFA_PVP                                  = 169,
        SPELL_AURA_DETECT_AMORE                                 = 170,
        SPELL_AURA_MOD_SPEED_NOT_STACK                          = 171,
        SPELL_AURA_MOD_MOUNTED_SPEED_NOT_STACK                  = 172,
        SPELL_AURA_MOD_RECOVERY_RATE_2                          = 173,  // NYI
        SPELL_AURA_MOD_SPELL_DAMAGE_OF_STAT_PERCENT             = 174,  // by defeult intelect, dependent from SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT
        SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT            = 175,
        SPELL_AURA_SPIRIT_OF_REDEMPTION                         = 176,
        SPELL_AURA_AOE_CHARM                                    = 177,
        SPELL_AURA_MOD_MAX_POWER_PCT                            = 178,
        SPELL_AURA_MOD_POWER_DISPLAY                            = 179,
        SPELL_AURA_MOD_FLAT_SPELL_DAMAGE_VERSUS                 = 180,
        SPELL_AURA_MOD_SPELL_CURRENCY_REAGENTS_COUNT_PCT        = 181,  // NYI
        SPELL_AURA_SUPPRESS_ITEM_PASSIVE_EFFECT_BY_SPELL_LABEL  = 182,
        SPELL_AURA_MOD_CRIT_CHANCE_VERSUS_TARGET_HEALTH         = 183,
        SPELL_AURA_MOD_ATTACKER_MELEE_HIT_CHANCE                = 184,
        SPELL_AURA_MOD_ATTACKER_RANGED_HIT_CHANCE               = 185,
        SPELL_AURA_MOD_ATTACKER_SPELL_HIT_CHANCE                = 186,
        SPELL_AURA_MOD_ATTACKER_MELEE_CRIT_CHANCE               = 187,
        SPELL_AURA_MOD_UI_HEALING_RANGE                         = 188,
        SPELL_AURA_MOD_RATING                                   = 189,
        SPELL_AURA_MOD_FACTION_REPUTATION_GAIN                  = 190,
        SPELL_AURA_USE_NORMAL_MOVEMENT_SPEED                    = 191,
        SPELL_AURA_MOD_MELEE_RANGED_HASTE                       = 192,
        SPELL_AURA_MELEE_SLOW                                   = 193,
        SPELL_AURA_MOD_TARGET_ABSORB_SCHOOL                     = 194,
        SPELL_AURA_LEARN_SPELL                                  = 195,
        SPELL_AURA_MOD_COOLDOWN                                 = 196,  // only 24818 Noxious Breath
        SPELL_AURA_MOD_ATTACKER_SPELL_AND_WEAPON_CRIT_CHANCE    = 197,
        SPELL_AURA_MOD_COMBAT_RATING_FROM_COMBAT_RATING         = 198,
        SPELL_AURA_199                                          = 199,  // old SPELL_AURA_MOD_INCREASES_SPELL_PCT_TO_HIT. unused 4.3.4
        SPELL_AURA_MOD_XP_PCT                                   = 200,
        SPELL_AURA_FLY                                          = 201,
        SPELL_AURA_IGNORE_COMBAT_RESULT                         = 202,
        SPELL_AURA_PREVENT_INTERRUPT                            = 203,  // NYI
        SPELL_AURA_PREVENT_CORPSE_RELEASE                       = 204,  // NYI
        SPELL_AURA_MOD_CHARGE_COOLDOWN                          = 205,  // NYI
        SPELL_AURA_MOD_INCREASE_VEHICLE_FLIGHT_SPEED            = 206,
        SPELL_AURA_MOD_INCREASE_MOUNTED_FLIGHT_SPEED            = 207,
        SPELL_AURA_MOD_INCREASE_FLIGHT_SPEED                    = 208,
        SPELL_AURA_MOD_MOUNTED_FLIGHT_SPEED_ALWAYS              = 209,
        SPELL_AURA_MOD_VEHICLE_SPEED_ALWAYS                     = 210,
        SPELL_AURA_MOD_FLIGHT_SPEED_NOT_STACK                   = 211,
        SPELL_AURA_MOD_SOURCE_HONOR_GAIN_PCT                    = 212, // MiscvalueA is a bitmask that defines which source of honor is affected
        SPELL_AURA_MOD_RAGE_FROM_DAMAGE_DEALT                   = 213,
        SPELL_AURA_214                                          = 214,
        SPELL_AURA_ARENA_PREPARATION                            = 215,
        SPELL_AURA_HASTE_SPELLS                                 = 216,
        SPELL_AURA_MOD_MELEE_HASTE_2                            = 217,
        SPELL_AURA_ADD_PCT_MODIFIER_BY_SPELL_LABEL              = 218,
        SPELL_AURA_ADD_FLAT_MODIFIER_BY_SPELL_LABEL             = 219,
        SPELL_AURA_MOD_ABILITY_SCHOOL_MASK                      = 220,  // NYI
        SPELL_AURA_MOD_DETAUNT                                  = 221,
        SPELL_AURA_REMOVE_TRANSMOG_COST                         = 222,
        SPELL_AURA_REMOVE_BARBER_SHOP_COST                      = 223,
        SPELL_AURA_LEARN_TALENT                                 = 224,  // NYI
        SPELL_AURA_MOD_VISIBILITY_RANGE                         = 225,
        SPELL_AURA_PERIODIC_DUMMY                               = 226,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL_WITH_VALUE            = 227,
        SPELL_AURA_DETECT_STEALTH                               = 228,
        SPELL_AURA_MOD_AOE_DAMAGE_AVOIDANCE                     = 229,
        SPELL_AURA_MOD_MAX_HEALTH                               = 230,
        SPELL_AURA_PROC_TRIGGER_SPELL_WITH_VALUE                = 231,
        SPELL_AURA_MECHANIC_DURATION_MOD                        = 232,
        SPELL_AURA_CHANGE_MODEL_FOR_ALL_HUMANOIDS               = 233,  // client-side only
        SPELL_AURA_MECHANIC_DURATION_MOD_NOT_STACK              = 234,
        SPELL_AURA_MOD_HOVER_NO_HEIGHT_OFFSET                   = 235,
        SPELL_AURA_CONTROL_VEHICLE                              = 236,
        SPELL_AURA_237                                          = 237,
        SPELL_AURA_238                                          = 238,
        SPELL_AURA_239                                          = 239, // old SPELL_AURA_MOD_SCALE_2
        SPELL_AURA_MOD_EXPERTISE                                = 240,
        SPELL_AURA_FORCE_MOVE_FORWARD                           = 241,
        SPELL_AURA_MOD_SPELL_DAMAGE_FROM_HEALING                = 242,
        SPELL_AURA_MOD_FACTION                                  = 243,
        SPELL_AURA_COMPREHEND_LANGUAGE                          = 244,
        SPELL_AURA_MOD_AURA_DURATION_BY_DISPEL                  = 245,
        SPELL_AURA_MOD_AURA_DURATION_BY_DISPEL_NOT_STACK        = 246,
        SPELL_AURA_CLONE_CASTER                                 = 247,
        SPELL_AURA_248                                          = 248,
        SPELL_AURA_MOD_DAMAGE_PERCENT_DONE_BY_TARGET_AURA_MECHANIC = 249,
        SPELL_AURA_MOD_INCREASE_HEALTH_2                        = 250,
        SPELL_AURA_MOD_ENEMY_DODGE                              = 251,
        SPELL_AURA_MOD_SPEED_SLOW_ALL                           = 252,
        SPELL_AURA_MOD_BLOCK_CRIT_CHANCE                        = 253,
        SPELL_AURA_MOD_DISARM_OFFHAND                           = 254,
        SPELL_AURA_MOD_MECHANIC_DAMAGE_TAKEN_PERCENT            = 255,
        SPELL_AURA_NO_REAGENT_USE                               = 256,
        SPELL_AURA_257                                          = 257,
        SPELL_AURA_OVERRIDE_SUMMONED_OBJECT                     = 258,
        SPELL_AURA_MOD_HOT_PCT                                  = 259,
        SPELL_AURA_SCREEN_EFFECT                                = 260,
        SPELL_AURA_PHASE                                        = 261,
        SPELL_AURA_ABILITY_IGNORE_AURASTATE                     = 262,
        SPELL_AURA_DISABLE_CASTING_EXCEPT_ABILITIES             = 263,
        SPELL_AURA_DISABLE_ATTACKING_EXCEPT_ABILITIES           = 264,
        SPELL_AURA_265                                          = 265,
        SPELL_AURA_SET_VIGNETTE                                 = 266,  // NYI
        SPELL_AURA_MOD_IMMUNE_AURA_APPLY_SCHOOL                 = 267,
        SPELL_AURA_MOD_ARMOR_PCT_FROM_STAT                      = 268,
        SPELL_AURA_269                                          = 269,
        SPELL_AURA_MOD_SCHOOL_MASK_DAMAGE_FROM_CASTER           = 270,
        SPELL_AURA_MOD_SPELL_DAMAGE_FROM_CASTER                 = 271,
        SPELL_AURA_MOD_BLOCK_VALUE_PCT                          = 272,  // NYI
        SPELL_AURA_X_RAY                                        = 273,
        SPELL_AURA_MOD_BLOCK_VALUE_FLAT                         = 274,  // NYI
        SPELL_AURA_MOD_IGNORE_SHAPESHIFT                        = 275,
        SPELL_AURA_MOD_DAMAGE_DONE_FOR_MECHANIC                 = 276,
        SPELL_AURA_277                                          = 277,  // old SPELL_AURA_MOD_MAX_AFFECTED_TARGETS. unused 4.3.4
        SPELL_AURA_MOD_DISARM_RANGED                            = 278,
        SPELL_AURA_INITIALIZE_IMAGES                            = 279,
        SPELL_AURA_280                                          = 280,  // old SPELL_AURA_MOD_ARMOR_PENETRATION_PCT unused 4.3.4
        SPELL_AURA_PROVIDE_SPELL_FOCUS                          = 281,
        SPELL_AURA_282                                          = 282,
        SPELL_AURA_MOD_HEALING_RECEIVED                         = 283,  // Possibly only for some spell family class spells
        SPELL_AURA_LINKED                                       = 284,
        SPELL_AURA_LINKED_2                                     = 285,
        SPELL_AURA_MOD_RECOVERY_RATE                            = 286,
        SPELL_AURA_DEFLECT_SPELLS                               = 287,
        SPELL_AURA_IGNORE_HIT_DIRECTION                         = 288,
        SPELL_AURA_PREVENT_DURABILITY_LOSS                      = 289,
        SPELL_AURA_MOD_CRIT_PCT                                 = 290,
        SPELL_AURA_MOD_XP_QUEST_PCT                             = 291,
        SPELL_AURA_OPEN_STABLE                                  = 292,
        SPELL_AURA_OVERRIDE_SPELLS                              = 293,
        SPELL_AURA_PREVENT_REGENERATE_POWER                     = 294,
        SPELL_AURA_MOD_PERIODIC_DAMAGE_TAKEN                    = 295,
        SPELL_AURA_SET_VEHICLE_ID                               = 296,
        SPELL_AURA_MOD_ROOT_DISABLE_GRAVITY                     = 297,  // NYI
        SPELL_AURA_MOD_STUN_DISABLE_GRAVITY                     = 298,  // NYI
        SPELL_AURA_299                                          = 299,
        SPELL_AURA_SHARE_DAMAGE_PCT                             = 300,
        SPELL_AURA_SCHOOL_HEAL_ABSORB                           = 301,
        SPELL_AURA_302                                          = 302,
        SPELL_AURA_MOD_DAMAGE_DONE_VERSUS_AURASTATE             = 303,
        SPELL_AURA_MOD_FAKE_INEBRIATE                           = 304,
        SPELL_AURA_MOD_MINIMUM_SPEED                            = 305,
        SPELL_AURA_MOD_CRIT_CHANCE_FOR_CASTER                   = 306,
        SPELL_AURA_CAST_WHILE_WALKING_BY_SPELL_LABEL            = 307,
        SPELL_AURA_MOD_CRIT_CHANCE_FOR_CASTER_WITH_ABILITIES    = 308,
        SPELL_AURA_MOD_RESILIENCE                               = 309,  // NYI
        SPELL_AURA_MOD_CREATURE_AOE_DAMAGE_AVOIDANCE            = 310,
        SPELL_AURA_IGNORE_COMBAT                                = 311,  // NYI
        SPELL_AURA_ANIM_REPLACEMENT_SET                         = 312,
        SPELL_AURA_MOUNT_ANIM_REPLACEMENT_SET                   = 313,
        SPELL_AURA_PREVENT_RESURRECTION                         = 314,
        SPELL_AURA_UNDERWATER_WALKING                           = 315,
        SPELL_AURA_SCHOOL_ABSORB_OVERKILL                       = 316,  // NYI - absorbs overkill damage
        SPELL_AURA_MOD_SPELL_POWER_PCT                          = 317,
        SPELL_AURA_MASTERY                                      = 318,
        SPELL_AURA_MOD_MELEE_HASTE_3                            = 319,
        SPELL_AURA_320                                          = 320,
        SPELL_AURA_MOD_NO_ACTIONS                               = 321,
        SPELL_AURA_INTERFERE_TARGETTING                         = 322,
        SPELL_AURA_323                                          = 323,  // Not used in 4.3.4
        SPELL_AURA_OVERRIDE_UNLOCKED_AZERITE_ESSENCE_RANK       = 324,  // testing aura
        SPELL_AURA_LEARN_PVP_TALENT                             = 325,  // NYI
        SPELL_AURA_PHASE_GROUP                                  = 326,  // Puts the player in all the phases that are in the group with id = miscB
        SPELL_AURA_PHASE_ALWAYS_VISIBLE                         = 327,  // Sets PhaseShiftFlags::AlwaysVisible
        SPELL_AURA_TRIGGER_SPELL_ON_POWER_PCT                   = 328,  // Triggers spell when power goes above (MiscB = 0) or falls below (MiscB = 1) specified percent value (once, not every time condition has meet)
        SPELL_AURA_MOD_POWER_GAIN_PCT                           = 329,
        SPELL_AURA_CAST_WHILE_WALKING                           = 330,
        SPELL_AURA_FORCE_WEATHER                                = 331,
        SPELL_AURA_OVERRIDE_ACTIONBAR_SPELLS                    = 332,
        SPELL_AURA_OVERRIDE_ACTIONBAR_SPELLS_TRIGGERED          = 333,  // Spells cast with this override have no cast time or power cost
        SPELL_AURA_MOD_AUTOATTACK_CRIT_CHANCE                   = 334,
        SPELL_AURA_335                                          = 335,
        SPELL_AURA_MOUNT_RESTRICTIONS                           = 336,
        SPELL_AURA_337                                          = 337,
        SPELL_AURA_MOD_DURABILITY_LOSS                          = 338,
        SPELL_AURA_MOD_CRIT_CHANCE_FOR_CASTER_PET               = 339,
        SPELL_AURA_MOD_RESURRECTED_HEALTH_BY_GUILD_MEMBER       = 340,  // Increases health gained when resurrected by a guild member by X
        SPELL_AURA_MOD_SPELL_CATEGORY_COOLDOWN                  = 341,  // Modifies cooldown of all spells using affected category
        SPELL_AURA_MOD_MELEE_RANGED_HASTE_2                     = 342,
        SPELL_AURA_MOD_MELEE_DAMAGE_FROM_CASTER                 = 343,
        SPELL_AURA_MOD_AUTOATTACK_DAMAGE                        = 344,
        SPELL_AURA_BYPASS_ARMOR_FOR_CASTER                      = 345,
        SPELL_AURA_ENABLE_ALT_POWER                             = 346,
        SPELL_AURA_MOD_SPELL_COOLDOWN_BY_HASTE                  = 347,
        SPELL_AURA_MOD_MONEY_GAIN                               = 348,  // Modifies gold gains from source: [Misc = 0, Quests][Misc = 1, Loot]
        SPELL_AURA_MOD_CURRENCY_GAIN                            = 349,
        SPELL_AURA_350                                          = 350,
        SPELL_AURA_MOD_CURRENCY_CATEGORY_GAIN_PCT               = 351,
        SPELL_AURA_352                                          = 352,
        SPELL_AURA_MOD_CAMOUFLAGE                               = 353,  // NYI
        SPELL_AURA_MOD_HEALING_DONE_PCT_VERSUS_TARGET_HEALTH    = 354,  // Restoration Shaman mastery - mod healing based on target's health (less = more healing)
        SPELL_AURA_MOD_CASTING_SPEED                            = 355,  // NYI
        SPELL_AURA_PROVIDE_TOTEM_CATEGORY                       = 356,
        SPELL_AURA_ENABLE_BOSS1_UNIT_FRAME                      = 357,
        SPELL_AURA_WORGEN_ALTERED_FORM                          = 358,
        SPELL_AURA_MOD_HEALING_DONE_VERSUS_AURASTATE            = 359,
        SPELL_AURA_PROC_TRIGGER_SPELL_COPY                      = 360,  // Procs the same spell that caused this proc (Dragonwrath, Tarecgosa's Rest)
        SPELL_AURA_OVERRIDE_AUTOATTACK_WITH_MELEE_SPELL         = 361,
        SPELL_AURA_362                                          = 362,  // Not used in 4.3.4
        SPELL_AURA_MOD_NEXT_SPELL                               = 363,  // Used by 101601 Throw Totem - causes the client to initialize spell cast with specified spell
        SPELL_AURA_364                                          = 364,  // Not used in 4.3.4
        SPELL_AURA_MAX_FAR_CLIP_PLANE                           = 365,  // Overrides client's View Distance setting to max("Fair", current_setting) and turns off terrain display
        SPELL_AURA_OVERRIDE_SPELL_POWER_BY_AP_PCT               = 366,  // NYI - Sets spellpower equal to % of attack power, discarding all other bonuses (from gear and buffs)
        SPELL_AURA_OVERRIDE_AUTOATTACK_WITH_RANGED_SPELL        = 367,  // NYI
        SPELL_AURA_368                                          = 368,  // Not used in 4.3.4
        SPELL_AURA_ENABLE_POWER_BAR_TIMER                       = 369,
        SPELL_AURA_SPELL_OVERRIDE_NAME_GROUP                    = 370,  // picks a random SpellOverrideName id from a group (group id in miscValue)
        SPELL_AURA_371                                          = 371,
        SPELL_AURA_OVERRIDE_MOUNT_FROM_SET                      = 372,  // NYI
        SPELL_AURA_MOD_SPEED_NO_CONTROL                         = 373,  // NYI
        SPELL_AURA_MODIFY_FALL_DAMAGE_PCT                       = 374,
        SPELL_AURA_HIDE_MODEL_AND_EQUIPEMENT_SLOTS              = 375,
        SPELL_AURA_MOD_CURRENCY_GAIN_FROM_SOURCE                = 376,  // NYI
        SPELL_AURA_CAST_WHILE_WALKING_ALL                       = 377,  // Enables casting all spells while moving
        SPELL_AURA_MOD_POSSESS_PET                              = 378,
        SPELL_AURA_MOD_MANA_REGEN_PCT                           = 379,
        SPELL_AURA_380                                          = 380,
        SPELL_AURA_MOD_DAMAGE_TAKEN_FROM_CASTER_PET             = 381,  // NYI
        SPELL_AURA_MOD_PET_STAT_PCT                             = 382,  // NYI
        SPELL_AURA_IGNORE_SPELL_COOLDOWN                        = 383,
        SPELL_AURA_384                                          = 384,
        SPELL_AURA_385                                          = 385,
        SPELL_AURA_386                                          = 386,
        SPELL_AURA_387                                          = 387,
        SPELL_AURA_MOD_TAXI_FLIGHT_SPEED                        = 388,  // NYI
        SPELL_AURA_389                                          = 389,
        SPELL_AURA_390                                          = 390,
        SPELL_AURA_391                                          = 391,
        SPELL_AURA_392                                          = 392,
        SPELL_AURA_BLOCK_SPELLS_IN_FRONT                        = 393,  // NYI
        SPELL_AURA_SHOW_CONFIRMATION_PROMPT                     = 394,
        SPELL_AURA_AREA_TRIGGER                                 = 395,  // NYI
        SPELL_AURA_TRIGGER_SPELL_ON_POWER_AMOUNT                = 396,  // Triggers spell when power goes above (MiscA = 0) or falls below (MiscA = 1) specified percent value (once, not every time condition has meet)
        SPELL_AURA_BATTLEGROUND_PLAYER_POSITION_FACTIONAL       = 397,
        SPELL_AURA_BATTLEGROUND_PLAYER_POSITION                 = 398,
        SPELL_AURA_MOD_TIME_RATE                                = 399,
        SPELL_AURA_MOD_SKILL_2                                  = 400,
        SPELL_AURA_401                                          = 401,
        SPELL_AURA_MOD_OVERRIDE_POWER_DISPLAY                   = 402,
        SPELL_AURA_OVERRIDE_SPELL_VISUAL                        = 403,
        SPELL_AURA_OVERRIDE_ATTACK_POWER_BY_SP_PCT              = 404,
        SPELL_AURA_MOD_RATING_PCT                               = 405,
        SPELL_AURA_KEYBOUND_OVERRIDE                            = 406,
        SPELL_AURA_MOD_FEAR_2                                   = 407,  // NYI
        SPELL_AURA_SET_ACTION_BUTTON_SPELL_COUNT                = 408,
        SPELL_AURA_CAN_TURN_WHILE_FALLING                       = 409,
        SPELL_AURA_410                                          = 410,
        SPELL_AURA_MOD_MAX_CHARGES                              = 411,
        SPELL_AURA_412                                          = 412,
        SPELL_AURA_MOD_RANGED_ATTACK_DEFLECT_CHANCE             = 413,  // NYI
        SPELL_AURA_MOD_RANGED_ATTACK_BLOCK_CHANCE_IN_FRONT      = 414,  // NYI
        SPELL_AURA_415                                          = 415,
        SPELL_AURA_MOD_COOLDOWN_BY_HASTE_REGEN                  = 416,
        SPELL_AURA_MOD_GLOBAL_COOLDOWN_BY_HASTE_REGEN           = 417,
        SPELL_AURA_MOD_MAX_POWER                                = 418,  // NYI
        SPELL_AURA_MOD_BASE_MANA_PCT                            = 419,
        SPELL_AURA_MOD_BATTLE_PET_XP_PCT                        = 420,
        SPELL_AURA_MOD_ABSORB_EFFECTS_DONE_PCT                  = 421,  // NYI
        SPELL_AURA_MOD_ABSORB_EFFECTS_TAKEN_PCT                 = 422,  // NYI
        SPELL_AURA_MOD_MANA_COST_PCT                            = 423,
        SPELL_AURA_CASTER_IGNORE_LOS                            = 424,  // NYI
        SPELL_AURA_425                                          = 425,
        SPELL_AURA_426                                          = 426,
        SPELL_AURA_SCALE_PLAYER_LEVEL                           = 427,  // NYI
        SPELL_AURA_LINKED_SUMMON                                = 428,
        SPELL_AURA_MOD_SUMMON_DAMAGE                            = 429,  // NYI - increases damage done by all summons, not just controlled pets
        SPELL_AURA_PLAY_SCENE                                   = 430,
        SPELL_AURA_MOD_OVERRIDE_ZONE_PVP_TYPE                   = 431,  // NYI
        SPELL_AURA_432                                          = 432,
        SPELL_AURA_433                                          = 433,
        SPELL_AURA_434                                          = 434,
        SPELL_AURA_435                                          = 435,
        SPELL_AURA_MOD_ENVIRONMENTAL_DAMAGE_TAKEN               = 436,
        SPELL_AURA_MOD_MINIMUM_SPEED_RATE                       = 437,
        SPELL_AURA_PRELOAD_PHASE                                = 438,  // NYI
        SPELL_AURA_439                                          = 439,
        SPELL_AURA_MOD_MULTISTRIKE_DAMAGE                       = 440,  // NYI
        SPELL_AURA_MOD_MULTISTRIKE_CHANCE                       = 441,  // NYI
        SPELL_AURA_MOD_READINESS                                = 442,  // NYI
        SPELL_AURA_MOD_LEECH                                    = 443,  // NYI
        SPELL_AURA_444                                          = 444,
        SPELL_AURA_445                                          = 445,
        SPELL_AURA_446                                          = 446,
        SPELL_AURA_MOD_XP_FROM_CREATURE_TYPE                    = 447,
        SPELL_AURA_448                                          = 448,
        SPELL_AURA_449                                          = 449,
        SPELL_AURA_450                                          = 450,
        SPELL_AURA_OVERRIDE_PET_SPECS                           = 451,
        SPELL_AURA_452                                          = 452,
        SPELL_AURA_CHARGE_RECOVERY_MOD                          = 453,
        SPELL_AURA_CHARGE_RECOVERY_MULTIPLIER                   = 454,
        SPELL_AURA_MOD_ROOT_2                                   = 455,
        SPELL_AURA_CHARGE_RECOVERY_AFFECTED_BY_HASTE            = 456,
        SPELL_AURA_CHARGE_RECOVERY_AFFECTED_BY_HASTE_REGEN      = 457,
        SPELL_AURA_IGNORE_DUAL_WIELD_HIT_PENALTY                = 458,
        SPELL_AURA_IGNORE_MOVEMENT_FORCES                       = 459,
        SPELL_AURA_RESET_COOLDOWNS_ON_DUEL_START                = 460,  // NYI
        SPELL_AURA_461                                          = 461,
        SPELL_AURA_MOD_HEALING_AND_ABSORB_FROM_CASTER           = 462,  // NYI
        SPELL_AURA_CONVERT_CRIT_RATING_PCT_TO_PARRY_RATING      = 463,  // NYI
        SPELL_AURA_MOD_ATTACK_POWER_OF_BONUS_ARMOR              = 464,  // NYI
        SPELL_AURA_MOD_BONUS_ARMOR                              = 465,
        SPELL_AURA_MOD_BONUS_ARMOR_PCT                          = 466,  // Affects bonus armor gain from all sources except base stats
        SPELL_AURA_MOD_STAT_BONUS_PCT                           = 467,  // Affects stat gain from all sources except base stats
        SPELL_AURA_TRIGGER_SPELL_ON_HEALTH_PCT                  = 468,  // Triggers spell when health goes above (MiscA = 0) or falls below (MiscA = 1) specified percent value (once, not every time condition has meet)
        SPELL_AURA_SHOW_CONFIRMATION_PROMPT_WITH_DIFFICULTY     = 469,
        SPELL_AURA_MOD_AURA_TIME_RATE_BY_SPELL_LABEL            = 470,  // NYI
        SPELL_AURA_MOD_VERSATILITY                              = 471,
        SPELL_AURA_472                                          = 472,
        SPELL_AURA_PREVENT_DURABILITY_LOSS_FROM_COMBAT          = 473,  // Prevents durability loss from dealing/taking damage
        SPELL_AURA_REPLACE_ITEM_BONUS_TREE                      = 474,  // NYI
        SPELL_AURA_ALLOW_USING_GAMEOBJECTS_WHILE_MOUNTED        = 475,
        SPELL_AURA_MOD_CURRENCY_GAIN_LOOTED                     = 476,
        SPELL_AURA_477                                          = 477,
        SPELL_AURA_478                                          = 478,
        SPELL_AURA_479                                          = 479,
        SPELL_AURA_MOD_ARTIFACT_ITEM_LEVEL                      = 480,
        SPELL_AURA_CONVERT_CONSUMED_RUNE                        = 481,
        SPELL_AURA_482                                          = 482,
        SPELL_AURA_SUPPRESS_TRANSFORMS                          = 483,  // NYI
        SPELL_AURA_ALLOW_INTERRUPT_SPELL                        = 484,  // NYI
        SPELL_AURA_MOD_MOVEMENT_FORCE_MAGNITUDE                 = 485,
        SPELL_AURA_486                                          = 486,
        SPELL_AURA_COSMETIC_MOUNTED                             = 487,
        SPELL_AURA_488                                          = 488,
        SPELL_AURA_MOD_ALTERNATIVE_DEFAULT_LANGUAGE             = 489,
        SPELL_AURA_490                                          = 490,
        SPELL_AURA_491                                          = 491,
        SPELL_AURA_492                                          = 492,
        SPELL_AURA_493                                          = 493, // 1 spell, 267116 - Animal Companion (modifies Call Pet)
        SPELL_AURA_SET_POWER_POINT_CHARGE                       = 494, // NYI
        SPELL_AURA_TRIGGER_SPELL_ON_EXPIRE                      = 495,
        SPELL_AURA_ALLOW_CHANGING_EQUIPMENT_IN_TORGHAST         = 496, // NYI
        SPELL_AURA_MOD_ANIMA_GAIN                               = 497, // NYI
        SPELL_AURA_CURRENCY_LOSS_PCT_ON_DEATH                   = 498, // NYI
        SPELL_AURA_MOD_RESTED_XP_CONSUMPTION                    = 499,
        SPELL_AURA_IGNORE_SPELL_CHARGE_COOLDOWN                 = 500, // NYI
        SPELL_AURA_MOD_CRITICAL_DAMAGE_TAKEN_FROM_CASTER        = 501,
        SPELL_AURA_MOD_VERSATILITY_DAMAGE_DONE_BENEFIT          = 502, // NYI
        SPELL_AURA_MOD_VERSATILITY_HEALING_DONE_BENEFIT         = 503, // NYI
        SPELL_AURA_MOD_HEALING_TAKEN_FROM_CASTER                = 504,
        SPELL_AURA_MOD_PLAYER_CHOICE_REROLLS                    = 505, // NYI
        SPELL_AURA_DISABLE_INERTIA                              = 506,
        SPELL_AURA_MOD_DAMAGE_TAKEN_FROM_CASTER_BY_LABEL        = 507,
        SPELL_AURA_508                                          = 508,
        SPELL_AURA_509                                          = 509,
        SPELL_AURA_MODIFIED_RAID_INSTANCE                       = 510, // NYI; Related to "Fated" raid affixes
        SPELL_AURA_APPLY_PROFESSION_EFFECT                      = 511, // NYI; MiscValue[0] = ProfessionEffectID
        SPELL_AURA_CONVERT_RUNE                                 = 512,
        SPELL_AURA_513                                          = 513,
        SPELL_AURA_514                                          = 514,
        SPELL_AURA_515                                          = 515,
        SPELL_AURA_516                                          = 516,
        SPELL_AURA_517                                          = 517,
        SPELL_AURA_518                                          = 518,
        SPELL_AURA_MOD_COOLDOWN_RECOVERY_RATE_ALL               = 519, // NYI; applies to all spells, not filtered by familyflags or label
        SPELL_AURA_520                                          = 520,
        SPELL_AURA_521                                          = 521,
        SPELL_AURA_522                                          = 522,
        SPELL_AURA_523                                          = 523,
        SPELL_AURA_524                                          = 524,
        SPELL_AURA_DISPLAY_PROFESSION_EQUIPMENT                 = 525, // NYI; MiscValue[0] = Profession (enum, not id)
        SPELL_AURA_526                                          = 526,
        SPELL_AURA_527                                          = 527,
        SPELL_AURA_ALLOW_BLOCKING_SPELLS                        = 528, // NYI
        SPELL_AURA_MOD_SPELL_BLOCK_CHANCE                       = 529, // NYI
        SPELL_AURA_530                                          = 530,
        SPELL_AURA_531                                          = 531,
        SPELL_AURA_532                                          = 532,
        SPELL_AURA_DISABLE_NAVIGATION                           = 533, // disables map pins
        SPELL_AURA_534                                          = 534,
        SPELL_AURA_535                                          = 535, // related to profession equipment; NYI; MiscValue[0] = Profession (enum, not id)
        SPELL_AURA_IGNORE_SPELL_CREATURE_TYPE_REQUIREMENTS      = 536,
        SPELL_AURA_537                                          = 537,
        SPELL_AURA_MOD_FAKE_INEBRIATION_MOVEMENT_ONLY           = 538,
        SPELL_AURA_ALLOW_MOUNT_IN_COMBAT                        = 539,
        SPELL_AURA_MOD_SUPPORT_STAT                             = 540, // NYI
        SPELL_AURA_MOD_REQUIRED_MOUNT_CAPABILITY_FLAGS          = 541,
        SPELL_AURA_542                                          = 542,
        SPELL_AURA_543                                          = 543,
        SPELL_AURA_544                                          = 544,
        SPELL_AURA_545                                          = 545,
        SPELL_AURA_546                                          = 546,
        SPELL_AURA_547                                          = 547,
        SPELL_AURA_MOD_RUNE_REGEN_SPEED                         = 548,
        SPELL_AURA_549                                          = 549, // formerly SPELL_AURA_46 - Ignore all gear test spells
        SPELL_AURA_550                                          = 550,
        SPELL_AURA_EXTRA_ATTACKS                                = 551, // NYI
        SPELL_AURA_MOD_SPELL_CRIT_CHANCE_SCHOOL                 = 552,
        SPELL_AURA_MOD_POWER_COST_SCHOOL                        = 553,
        SPELL_AURA_554                                          = 554,
        SPELL_AURA_555                                          = 555,
        SPELL_AURA_MOD_MELEE_DAMAGE_TAKEN                       = 556,
        SPELL_AURA_557                                          = 557,
        SPELL_AURA_MOD_RESISTANCE_EXCLUSIVE                     = 558, // NYI
        SPELL_AURA_MOD_PET_TALENT_POINTS                        = 559, // NYI
        SPELL_AURA_RETAIN_COMBO_POINTS                          = 560, // NYI
        SPELL_AURA_MOD_SHIELD_BLOCKVALUE_PCT                    = 561,
        SPELL_AURA_562                                          = 562,
        SPELL_AURA_PET_DAMAGE_MULTI                             = 563, // NYI
        SPELL_AURA_MOD_SHIELD_BLOCKVALUE                        = 564,
        SPELL_AURA_565                                          = 565,
        SPELL_AURA_MELEE_ATTACK_POWER_ATTACKER_BONUS            = 566, // old SPELL_AURA_165 in 4.3.4.15595
        SPELL_AURA_567                                          = 567,
        SPELL_AURA_568                                          = 568,
        SPELL_AURA_MOD_ATTACKER_SPELL_CRIT_CHANCE               = 569, // NYI
        SPELL_AURA_570                                          = 570,
        SPELL_AURA_MOD_RESISTANCE_OF_STAT_PERCENT               = 571, // NYI
        SPELL_AURA_MOD_CRITICAL_THREAT                          = 572, // NYI
        SPELL_AURA_MOD_ATTACKER_RANGED_CRIT_CHANCE              = 573, // NYI
        SPELL_AURA_MOD_TARGET_ABILITY_ABSORB_SCHOOL             = 574, // NYI
        SPELL_AURA_575                                          = 575,
        SPELL_AURA_576                                          = 576,
        SPELL_AURA_MOD_ATTACKER_MELEE_CRIT_DAMAGE               = 577, // NYI
        SPELL_AURA_MOD_ATTACKER_RANGED_CRIT_DAMAGE              = 578, // NYI
        SPELL_AURA_MOD_SCHOOL_CRIT_DMG_TAKEN                    = 579, // NYI
        SPELL_AURA_580                                          = 580,
        SPELL_AURA_581                                          = 581,
        SPELL_AURA_582                                          = 582,
        SPELL_AURA_MOD_RATING_FROM_STAT                         = 583, // NYI
        SPELL_AURA_584                                          = 584, // old SPELL_AURA_222 in 4.3.4.15595
        SPELL_AURA_RAID_PROC_FROM_CHARGE                        = 585, // NYI
        SPELL_AURA_586                                          = 586,
        SPELL_AURA_587                                          = 587,
        SPELL_AURA_MOD_DISPEL_RESIST                            = 588, // NYI
        SPELL_AURA_MOD_SPELL_DAMAGE_OF_ATTACK_POWER             = 589, // NYI
        SPELL_AURA_MOD_SPELL_HEALING_OF_ATTACK_POWER            = 590, // NYI
        SPELL_AURA_MOD_SCALE_2                                  = 591,
        SPELL_AURA_592                                          = 592,
        SPELL_AURA_MOD_COMBAT_RESULT_CHANCE                     = 593,
        SPELL_AURA_MOD_TARGET_RESIST_BY_SPELL_CLASS             = 594,
        SPELL_AURA_595                                          = 595, // old SPELL_AURA_258 in 4.3.4.15595
        SPELL_AURA_596                                          = 596,
        SPELL_AURA_597                                          = 597,
        SPELL_AURA_598                                          = 598,
        SPELL_AURA_MOD_IGNORE_TARGET_RESIST                     = 599,
        SPELL_AURA_600                                          = 600,
        SPELL_AURA_IGNORE_MELEE_RESET                           = 601, // NYI
        SPELL_AURA_602                                          = 602,
        SPELL_AURA_603                                          = 603,
        SPELL_AURA_MOD_HONOR_GAIN_PCT                           = 604,
        SPELL_AURA_605                                          = 605,
        SPELL_AURA_MOD_BASE_HEALTH_PCT                          = 606,
        SPELL_AURA_MOD_ATTACK_POWER_OF_ARMOR                    = 607, // NYI
        SPELL_AURA_ABILITY_PERIODIC_CRIT                        = 608, // NYI
        SPELL_AURA_609                                          = 609,
        SPELL_AURA_610                                          = 610,
        SPELL_AURA_611                                          = 611,
        SPELL_AURA_612                                          = 612,
        SPELL_AURA_613                                          = 613,
        SPELL_AURA_614                                          = 614,
        SPELL_AURA_MOD_RANGED_HASTE_2                           = 615, // NYI
        SPELL_AURA_616                                          = 616,
        SPELL_AURA_617                                          = 617, // old SPELL_AURA_324 in 4.3.4.15595 - crit chance related
        SPELL_AURA_618                                          = 618,
        SPELL_AURA_MOD_BLIND                                    = 619, // NYI
        SPELL_AURA_MOD_VENDOR_ITEMS_PRICES                      = 620,
        SPELL_AURA_INCREASE_SKILL_GAIN_CHANCE                   = 621, // NYI
        SPELL_AURA_622                                          = 622,
        SPELL_AURA_MOD_GATHERING_ITEMS_GAINED_PERCENT           = 623, // NYI
        SPELL_AURA_MOD_DAMAGE_FROM_MANA                         = 624, // NYI
        TOTAL_AURAS
    }

    /// <summary>
    /// Target
    /// </summary>
    public enum Targets
    {
        NO_TARGET                                   = 0,
        TARGET_UNIT_CASTER                          = 1,
        TARGET_UNIT_NEARBY_ENEMY                    = 2,
        TARGET_UNIT_NEARBY_ALLY                     = 3,
        TARGET_UNIT_NEARBY_PARTY                    = 4,
        TARGET_UNIT_PET                             = 5,
        TARGET_UNIT_TARGET_ENEMY                    = 6,
        TARGET_UNIT_SRC_AREA_ENTRY                  = 7,
        TARGET_UNIT_DEST_AREA_ENTRY                 = 8,
        TARGET_DEST_HOME                            = 9,
        TARGET_UNK_10                               = 10,
        TARGET_UNIT_SRC_AREA_UNK_11                 = 11,
        TARGET_UNK_12                               = 12,
        TARGET_UNK_13                               = 13,
        TARGET_UNK_14                               = 14,
        TARGET_UNIT_SRC_AREA_ENEMY                  = 15,
        TARGET_UNIT_DEST_AREA_ENEMY                 = 16,
        TARGET_DEST_DB                              = 17,
        TARGET_DEST_CASTER                          = 18,
        TARGET_UNK_19                               = 19,
        TARGET_UNIT_CASTER_AREA_PARTY               = 20,
        TARGET_UNIT_TARGET_ALLY                     = 21,
        TARGET_SRC_CASTER                           = 22,
        TARGET_GAMEOBJECT_TARGET                    = 23,
        TARGET_UNIT_CONE_ENEMY_24                   = 24,
        TARGET_UNIT_TARGET_ANY                      = 25,
        TARGET_GAMEOBJECT_ITEM_TARGET               = 26,
        TARGET_UNIT_MASTER                          = 27,
        TARGET_DEST_DYNOBJ_ENEMY                    = 28,
        TARGET_DEST_DYNOBJ_ALLY                     = 29,
        TARGET_UNIT_SRC_AREA_ALLY                   = 30,
        TARGET_UNIT_DEST_AREA_ALLY                  = 31,
        TARGET_DEST_CASTER_SUMMON                   = 32, // front left, doesn't use radius
        TARGET_UNIT_SRC_AREA_PARTY                  = 33,
        TARGET_UNIT_DEST_AREA_PARTY                 = 34,
        TARGET_UNIT_TARGET_PARTY                    = 35,
        TARGET_DEST_CASTER_UNK_36                   = 36,
        TARGET_UNIT_LASTTARGET_AREA_PARTY           = 37,
        TARGET_UNIT_NEARBY_ENTRY                    = 38,
        TARGET_DEST_CASTER_FISHING                  = 39,
        TARGET_GAMEOBJECT_NEARBY_ENTRY              = 40,
        TARGET_DEST_CASTER_FRONT_RIGHT              = 41,
        TARGET_DEST_CASTER_BACK_RIGHT               = 42,
        TARGET_DEST_CASTER_BACK_LEFT                = 43,
        TARGET_DEST_CASTER_FRONT_LEFT               = 44,
        TARGET_UNIT_TARGET_CHAINHEAL_ALLY           = 45,
        TARGET_DEST_NEARBY_ENTRY                    = 46,
        TARGET_DEST_CASTER_FRONT                    = 47,
        TARGET_DEST_CASTER_BACK                     = 48,
        TARGET_DEST_CASTER_RIGHT                    = 49,
        TARGET_DEST_CASTER_LEFT                     = 50,
        TARGET_GAMEOBJECT_SRC_AREA                  = 51,
        TARGET_GAMEOBJECT_DEST_AREA                 = 52,
        TARGET_DEST_TARGET_ENEMY                    = 53,
        TARGET_UNIT_CONE_180_DEG_ENEMY              = 54, // Defaults to 180 if ConeDegrees is not set
        TARGET_DEST_CASTER_FRONT_LEAP               = 55, // for a leap spell
        TARGET_UNIT_CASTER_AREA_RAID                = 56,
        TARGET_UNIT_TARGET_RAID                     = 57,
        TARGET_UNIT_NEARBY_RAID                     = 58,
        TARGET_UNIT_CONE_ALLY                       = 59,
        TARGET_UNIT_CONE_ENTRY                      = 60,
        TARGET_UNIT_TARGET_AREA_RAID_CLASS          = 61,
        TARGET_DEST_CASTER_GROUND                   = 62,
        TARGET_DEST_TARGET_ANY                      = 63,
        TARGET_DEST_TARGET_FRONT                    = 64,
        TARGET_DEST_TARGET_BACK                     = 65,
        TARGET_DEST_TARGET_RIGHT                    = 66,
        TARGET_DEST_TARGET_LEFT                     = 67,
        TARGET_DEST_TARGET_FRONT_RIGHT              = 68,
        TARGET_DEST_TARGET_BACK_RIGHT               = 69,
        TARGET_DEST_TARGET_BACK_LEFT                = 70,
        TARGET_DEST_TARGET_FRONT_LEFT               = 71,
        TARGET_DEST_CASTER_RANDOM                   = 72,
        TARGET_DEST_CASTER_RADIUS                   = 73,
        TARGET_DEST_TARGET_RANDOM                   = 74,
        TARGET_DEST_TARGET_RADIUS                   = 75,
        TARGET_DEST_CHANNEL_TARGET                  = 76,
        TARGET_UNIT_CHANNEL_TARGET                  = 77,
        TARGET_DEST_DEST_FRONT                      = 78,
        TARGET_DEST_DEST_BACK                       = 79,
        TARGET_DEST_DEST_RIGHT                      = 80,
        TARGET_DEST_DEST_LEFT                       = 81,
        TARGET_DEST_DEST_FRONT_RIGHT                = 82,
        TARGET_DEST_DEST_BACK_RIGHT                 = 83,
        TARGET_DEST_DEST_BACK_LEFT                  = 84,
        TARGET_DEST_DEST_FRONT_LEFT                 = 85,
        TARGET_DEST_DEST_RANDOM                     = 86,
        TARGET_DEST_DEST                            = 87,
        TARGET_DEST_DYNOBJ_NONE                     = 88,
        TARGET_DEST_TRAJ                            = 89,
        TARGET_UNIT_TARGET_MINIPET                  = 90,
        TARGET_DEST_DEST_RADIUS                     = 91,
        TARGET_UNIT_SUMMONER                        = 92,
        TARGET_CORPSE_SRC_AREA_ENEMY                = 93, // NYI
        TARGET_UNIT_VEHICLE                         = 94,
        TARGET_UNIT_TARGET_PASSENGER                = 95,
        TARGET_UNIT_PASSENGER_0                     = 96,
        TARGET_UNIT_PASSENGER_1                     = 97,
        TARGET_UNIT_PASSENGER_2                     = 98,
        TARGET_UNIT_PASSENGER_3                     = 99,
        TARGET_UNIT_PASSENGER_4                     = 100,
        TARGET_UNIT_PASSENGER_5                     = 101,
        TARGET_UNIT_PASSENGER_6                     = 102,
        TARGET_UNIT_PASSENGER_7                     = 103,
        TARGET_UNIT_CONE_CASTER_TO_DEST_ENEMY       = 104,
        TARGET_UNIT_CASTER_AND_PASSENGERS           = 105,
        TARGET_DEST_CHANNEL_CASTER                  = 106,
        TARGET_DEST_NEARBY_ENTRY_2                  = 107,
        TARGET_GAMEOBJECT_CONE_CASTER_TO_DEST_ENEMY = 108,
        TARGET_GAMEOBJECT_CONE_CASTER_TO_DEST_ALLY  = 109,
        TARGET_UNIT_CONE_CASTER_TO_DEST_ENTRY       = 110,
        TARGET_UNK_111                              = 111, // NYI
        TARGET_UNK_112                              = 112, // NYI
        TARGET_UNK_113                              = 113, // NYI
        TARGET_UNK_114                              = 114, // NYI
        TARGET_UNIT_SRC_AREA_FURTHEST_ENEMY         = 115,
        TARGET_UNIT_AND_DEST_LAST_ENEMY             = 116,
        TARGET_UNK_117                              = 117,
        TARGET_UNIT_TARGET_ALLY_OR_RAID             = 118, // If target is in your party or raid, all party and raid members will be affected
        TARGET_CORPSE_SRC_AREA_RAID                 = 119,
        TARGET_UNIT_CASTER_AND_SUMMONS              = 120,
        TARGET_CORPSE_TARGET_ALLY                   = 121,
        TARGET_UNIT_AREA_THREAT_LIST                = 122, // any unit on threat list
        TARGET_UNIT_AREA_TAP_LIST                   = 123,
        TARGET_UNIT_TARGET_TAP_LIST                 = 124,
        TARGET_DEST_CASTER_GROUND_2                 = 125,
        TARGET_UNIT_CASTER_AREA_ENEMY_CLUMP         = 126, // NYI
        TARGET_DEST_CASTER_ENEMY_CLUMP_CENTROID     = 127, // NYI
        TARGET_UNIT_RECT_CASTER_ALLY                = 128,
        TARGET_UNIT_RECT_CASTER_ENEMY               = 129,
        TARGET_UNIT_RECT_CASTER                     = 130,
        TARGET_DEST_SUMMONER                        = 131,
        TARGET_DEST_TARGET_ALLY                     = 132,
        TARGET_UNIT_LINE_CASTER_TO_DEST_ALLY        = 133,
        TARGET_UNIT_LINE_CASTER_TO_DEST_ENEMY       = 134,
        TARGET_UNIT_LINE_CASTER_TO_DEST             = 135,
        TARGET_UNIT_CONE_CASTER_TO_DEST_ALLY        = 136,
        TARGET_DEST_CASTER_MOVEMENT_DIRECTION       = 137,
        TARGET_DEST_DEST_GROUND                     = 138,
        TARGET_UNK_139                              = 139,
        TARGET_DEST_CASTER_CLUMP_CENTROID           = 140, // NYI
        TARGET_UNK_141                              = 141,
        TARGET_UNK_142                              = 142,
        TARGET_UNK_143                              = 143,
        TARGET_UNK_144                              = 144,
        TARGET_UNK_145                              = 145,
        TARGET_UNK_146                              = 146,
        TARGET_UNK_147                              = 147,
        TARGET_UNK_148                              = 148,
        TARGET_UNK_149                              = 149,
        TARGET_UNIT_OWN_CRITTER                     = 150, // own battle pet from UNIT_FIELD_CRITTER
        TARGET_UNK_151                              = 151,
        TARGET_UNK_152                              = 152,
        TOTAL_SPELL_TARGETS
    };

    ///<summary>
    ///Spell proc event related declarations (accessed using SpellMgr functions)
    ///</summary>
    [Flags]
    public enum ProcFlags : uint
    {
        PROC_FLAG_HEARTBEAT                       = 0x00000001,    // 00 Heartbeat
        PROC_FLAG_KILL                            = 0x00000002,    // 01 Kill target (in most cases need XP/Honor reward)

        PROC_FLAG_DEAL_MELEE_SWING                = 0x00000004,    // 02 Deal Melee Swing
        PROC_FLAG_TAKE_MELEE_SWING                = 0x00000008,    // 03 Take Melee Swing

        PROC_FLAG_DEAL_MELEE_ABILITY              = 0x00000010,    // 04 Deal Melee Ability
        PROC_FLAG_TAKE_MELEE_ABILITY              = 0x00000020,    // 05 Take Melee Ability

        PROC_FLAG_DEAL_RANGED_ATTACK              = 0x00000040,    // 06 Deal Ranged Attack
        PROC_FLAG_TAKE_RANGED_ATTACK              = 0x00000080,    // 07 Take Ranged Attack

        PROC_FLAG_DEAL_RANGED_ABILITY             = 0x00000100,    // 08 Deal Ranged Ability
        PROC_FLAG_TAKE_RANGED_ABILITY             = 0x00000200,    // 09 Take Ranged Ability

        PROC_FLAG_DEAL_HELPFUL_ABILITY            = 0x00000400,    // 10 Deal Helpful Ability
        PROC_FLAG_TAKE_HELPFUL_ABILITY            = 0x00000800,    // 11 Take Helpful Ability

        PROC_FLAG_DEAL_HARMFUL_ABILITY            = 0x00001000,    // 12 Deal Harmful Ability
        PROC_FLAG_TAKE_HARMFUL_ABILITY            = 0x00002000,    // 13 Take Harmful Ability

        PROC_FLAG_DEAL_HELPFUL_SPELL              = 0x00004000,    // 14 Deal Helpful Spell
        PROC_FLAG_TAKE_HELPFUL_SPELL              = 0x00008000,    // 15 Take Helpful Spell

        PROC_FLAG_DEAL_HARMFUL_SPELL              = 0x00010000,    // 16 Deal Harmful Spell
        PROC_FLAG_TAKE_HARMFUL_SPELL              = 0x00020000,    // 17 Take Harmful Spell

        PROC_FLAG_DEAL_HARMFUL_PERIODIC           = 0x00040000,    // 18 Deal Harmful Periodic
        PROC_FLAG_TAKE_HARMFUL_PERIODIC           = 0x00080000,    // 19 Take Harmful Periodic

        PROC_FLAG_TAKE_ANY_DAMAGE                 = 0x00100000,    // 20 Take Any Damage

        PROC_FLAG_DEAL_HELPFUL_PERIODIC           = 0x00200000,    // 21 Deal Helpful Periodic

        PROC_FLAG_MAIN_HAND_WEAPON_SWING          = 0x00400000,    // 22 Main Hand Weapon Swing
        PROC_FLAG_OFF_HAND_WEAPON_SWING           = 0x00800000,    // 23 Off Hand Weapon Swing

        PROC_FLAG_DEATH                           = 0x01000000,    // 24 Died in any way

        PROC_FLAG_JUMP                            = 0x02000000,    // 25 Jumped

        PROC_FLAG_PROC_CLONE_SPELL                = 0x04000000,    // 26 Proc Clone Spell

        PROC_FLAG_ENTER_COMBAT                    = 0x08000000,    // 27 Entered combat

        PROC_FLAG_ENCOUNTER_START                 = 0x10000000,    // 28 Encounter started

        PROC_FLAG_CAST_ENDED                      = 0x20000000,    // 29 Cast Ended

        PROC_FLAG_LOOTED                          = 0x40000000,    // 30 Looted (took from loot, not opened loot window)

        PROC_FLAG_TAKE_HELPFUL_PERIODIC           = 0x80000000,    // 31 Take Helpful Periodic
    };

    [Flags]
    public enum ProcFlags2 : uint
    {
        PROC_FLAG_2_TARGET_DIES                   = 0x00000001,    // 00 Target Dies
        PROC_FLAG_2_KNOCKBACK                     = 0x00000002,    // 01 Target Dies
        PROC_FLAG_2_CAST_SUCCESSFUL               = 0x00000004,    // 02 Cast Successful
    }

    [Flags]
    public enum ProcFlagsSpellType : uint
    {
        PROC_SPELL_TYPE_NONE              = 0x0000000,
        PROC_SPELL_TYPE_DAMAGE            = 0x0000001, // damage type of spell
        PROC_SPELL_TYPE_HEAL              = 0x0000002, // heal type of spell
        PROC_SPELL_TYPE_NO_DMG_HEAL       = 0x0000004, // other spells
    };

    [Flags]
    public enum ProcFlagsSpellPhase : uint
    {
        PROC_SPELL_PHASE_NONE             = 0x0000000,
        PROC_SPELL_PHASE_CAST             = 0x0000001,
        PROC_SPELL_PHASE_HIT              = 0x0000002,
        PROC_SPELL_PHASE_FINISH           = 0x0000004,
    };

    [Flags]
    public enum ProcFlagsHit : uint
    {
        //PROC_HIT_NONE                = 0x0000000, // no value - PROC_HIT_NORMAL | PROC_HIT_CRITICAL for TAKEN proc type, PROC_HIT_NORMAL | PROC_HIT_CRITICAL | PROC_HIT_ABSORB for DONE
        PROC_HIT_NORMAL              = 0x0000001, // non-critical hits
        PROC_HIT_CRITICAL            = 0x0000002,
        PROC_HIT_MISS                = 0x0000004,
        PROC_HIT_FULL_RESIST         = 0x0000008,
        PROC_HIT_DODGE               = 0x0000010,
        PROC_HIT_PARRY               = 0x0000020,
        PROC_HIT_BLOCK               = 0x0000040, // partial or full block
        PROC_HIT_EVADE               = 0x0000080,
        PROC_HIT_IMMUNE              = 0x0000100,
        PROC_HIT_DEFLECT             = 0x0000200,
        PROC_HIT_ABSORB              = 0x0000400, // partial or full absorb
        PROC_HIT_REFLECT             = 0x0000800,
        PROC_HIT_INTERRUPT           = 0x0001000,
        PROC_HIT_FULL_BLOCK          = 0x0002000,
        PROC_HIT_DISPEL              = 0x0004000,
    };

    [Flags]
    public enum ProcAttributes : uint
    {
        PROC_ATTR_REQ_EXP_OR_HONOR          = 0x0000001, // requires proc target to give exp or honor for aura proc
        PROC_ATTR_TRIGGERED_CAN_PROC        = 0x0000002, // aura can proc even with triggered spells
        PROC_ATTR_REQ_POWER_COST            = 0x0000004, // requires triggering spell to have a power cost for aura proc
        PROC_ATTR_REQ_SPELLMOD              = 0x0000008, // requires triggering spell to be affected by proccing aura to drop charges
        PROC_ATTR_USE_STACKS_FOR_CHARGES    = 0x0000010, // consuming proc drops a stack from proccing aura instead of charge


        PROC_ATTR_REDUCE_PROC_60            = 0x0000080  // aura should have a reduced chance to proc if level of proc Actor > 60
    };

    public enum SpellSchools
    {
        NORMAL = 0,
        HOLY   = 1,
        FIRE   = 2,
        NATURE = 3,
        FROST  = 4,
        SHADOW = 5,
        ARCANE = 6
    };

    [Flags]
    public enum SpellSchoolMask : byte
    {
        SPELL_SCHOOL_MASK_NONE    = 0x00,                       // not exist
        SPELL_SCHOOL_MASK_NORMAL  = (1 << SpellSchools.NORMAL), // PHYSICAL (Armor)
        SPELL_SCHOOL_MASK_HOLY    = (1 << SpellSchools.HOLY),
        SPELL_SCHOOL_MASK_FIRE    = (1 << SpellSchools.FIRE),
        SPELL_SCHOOL_MASK_NATURE  = (1 << SpellSchools.NATURE),
        SPELL_SCHOOL_MASK_FROST   = (1 << SpellSchools.FROST),
        SPELL_SCHOOL_MASK_SHADOW  = (1 << SpellSchools.SHADOW),
        SPELL_SCHOOL_MASK_ARCANE  = (1 << SpellSchools.ARCANE),

        // unions

        // 124, not include normal and holy damage
        SPELL_SCHOOL_MASK_SPELL = (SPELL_SCHOOL_MASK_FIRE |
                                   SPELL_SCHOOL_MASK_NATURE | SPELL_SCHOOL_MASK_FROST |
                                   SPELL_SCHOOL_MASK_SHADOW | SPELL_SCHOOL_MASK_ARCANE),
        // 126
        SPELL_SCHOOL_MASK_MAGIC = (SPELL_SCHOOL_MASK_HOLY | SPELL_SCHOOL_MASK_SPELL),
        // 127
        SPELL_SCHOOL_MASK_ALL   = (SPELL_SCHOOL_MASK_NORMAL | SPELL_SCHOOL_MASK_MAGIC)
    };

    public enum Mechanics
    {
        MECHANIC_NONE             = 0,
        MECHANIC_CHARM            = 1,
        MECHANIC_DISORIENTED      = 2,
        MECHANIC_DISARM           = 3,
        MECHANIC_DISTRACT         = 4,
        MECHANIC_FEAR             = 5,
        MECHANIC_GRIP             = 6,
        MECHANIC_ROOT             = 7,
        MECHANIC_SLOW_ATTACK      = 8,
        MECHANIC_SILENCE          = 9,
        MECHANIC_SLEEP            = 10,
        MECHANIC_SNARE            = 11,
        MECHANIC_STUN             = 12,
        MECHANIC_FREEZE           = 13,
        MECHANIC_KNOCKOUT         = 14,
        MECHANIC_BLEED            = 15,
        MECHANIC_BANDAGE          = 16,
        MECHANIC_POLYMORPH        = 17,
        MECHANIC_BANISH           = 18,
        MECHANIC_SHIELD           = 19,
        MECHANIC_SHACKLE          = 20,
        MECHANIC_MOUNT            = 21,
        MECHANIC_INFECTED         = 22,
        MECHANIC_TURN             = 23,
        MECHANIC_HORROR           = 24,
        MECHANIC_INVULNERABILITY  = 25,
        MECHANIC_INTERRUPT        = 26,
        MECHANIC_DAZE             = 27,
        MECHANIC_DISCOVERY        = 28,
        MECHANIC_IMMUNE_SHIELD    = 29, // Divine (Blessing) Shield/Protection and Ice Block
        MECHANIC_SAPPED           = 30,
        MECHANIC_ENRAGED          = 31,
        MECHANIC_WOUNDED          = 32,
        MECHANIC_INFECTED_2       = 33,
        MECHANIC_INFECTED_3       = 34,
        MECHANIC_INFECTED_4       = 35,
        MECHANIC_TAUNTED          = 36,
    };

    public enum SpellDmgClass
    {
        SPELL_DAMAGE_CLASS_NONE   = 0,
        SPELL_DAMAGE_CLASS_MAGIC  = 1,
        SPELL_DAMAGE_CLASS_MELEE  = 2,
        SPELL_DAMAGE_CLASS_RANGED = 3
    };

    [Flags]
    public enum SpellPreventionType
    {
        SPELL_PREVENTION_TYPE_NONE          = 0,
        SPELL_PREVENTION_TYPE_SILENCE       = 1,
        SPELL_PREVENTION_TYPE_PACIFY        = 2,
        SPELL_PREVENTION_TYPE_NO_ACTIONS    = 4
    };

    [Flags]
    public enum ShapeshiftFormMask : ulong
    {
        FORM_ALL                        = 0xFFFFFFFFFFFFFFFF,
        FORM_NONE                       = 0,
        FORM_CAT_FORM                   = 1ul << 0,
        FORM_TREE_OF_LIFE               = 1ul << 1,
        FORM_TRAVEL_FORM                = 1ul << 2,
        FORM_AQUATIC_FORM               = 1ul << 3,
        FORM_BEAR_FORM                  = 1ul << 4,
        FORM_AMBIENT                    = 1ul << 5,
        FORM_GHOUL                      = 1ul << 6,
        FORM_DIRE_BEAR_FORM             = 1ul << 7,
        FORM_CRANE_STANCE               = 1ul << 8,
        FORM_THARONJA_SKELETON          = 1ul << 9,
        FORM_DARKMOON_TEST_OF_STRENGTH  = 1ul << 10,
        FORM_BLB_PLAYER                 = 1ul << 11,
        FORM_SHADOW_DANCE               = 1ul << 12,
        FORM_CREATURE_BEAR              = 1ul << 13,
        FORM_CREATURE_CAT               = 1ul << 14,
        FORM_GHOST_WOLF                 = 1ul << 15,
        FORM_BATTLE_STANCE              = 1ul << 16,
        FORM_DEFENSIVE_STANCE           = 1ul << 17,
        FORM_BERSERKER_STANCE           = 1ul << 18,
        FORM_SERPENT_STANCE             = 1ul << 19,
        FORM_ZOMBIE                     = 1ul << 20,
        FORM_METAMORPHOSIS              = 1ul << 21,
        FORM_OX_STANCE                  = 1ul << 22,
        FORM_TIGER_STANCE               = 1ul << 23,
        FORM_UNDEAD                     = 1ul << 24,
        FORM_FRENZY                     = 1ul << 25,
        FORM_FLIGHT_FORM_EPIC           = 1ul << 26,
        FORM_SHADOWFORM                 = 1ul << 27,
        FORM_FLIGHT_FORM                = 1ul << 28,
        FORM_STEALTH                    = 1ul << 29,
        FORM_MOONKIN_FORM               = 1ul << 30,
        FORM_SPIRIT_OF_REDEMPTION       = 1ul << 31,
        FORM_GLADIATOR_STANCE           = 1ul << 32,
        FORM_METAMORPHOSIS_2            = 1ul << 33,
        FORM_MOONKIN_FORM_RESTORATION   = 1ul << 34,
        FORM_TREANT_FORM                = 1ul << 35,
        FORM_SPIRIT_OWL_FORM            = 1ul << 36,
        FORM_SPIRIT_OWL_FORM_2          = 1ul << 37,
        FORM_WISP_FORM                  = 1ul << 38,
        FORM_WISP_FORM_2                = 1ul << 39,
        FORM_SOULSHAPE                  = 1ul << 40,
        FORM_FORGEBORNE_REVERIES        = 1ul << 41,
    };

    public enum DispelType
    {
        DISPEL_NONE         = 0,
        DISPEL_MAGIC        = 1,
        DISPEL_CURSE        = 2,
        DISPEL_DISEASE      = 3,
        DISPEL_POISON       = 4,
        DISPEL_STEALTH      = 5,
        DISPEL_INVISIBILITY = 6,
        DISPEL_ALL          = 7,
        DISPEL_SPE_NPC_ONLY = 8,
        DISPEL_ENRAGE       = 9,
        DISPEL_ZG_TICKET    = 10,
        DESPEL_OLD_UNUSED   = 11
    };

    public enum SpellModOp
    {
        HealingAndDamage            = 0,
        Duration                    = 1,
        Hate                        = 2,
        PointsIndex0                = 3,
        ProcCharges                 = 4,
        Range                       = 5,
        Radius                      = 6,
        CritChance                  = 7,
        Points                      = 8,
        ResistPushback              = 9,
        ChangeCastTime              = 10,
        Cooldown                    = 11,
        PointsIndex1                = 12,
        TargetResistance            = 13,
        PowerCost0                  = 14, // Used when SpellPowerEntry::PowerIndex == 0
        CritDamageAndHealing        = 15,
        HitChance                   = 16,
        ChainTargets                = 17,
        ProcChance                  = 18,
        Period                      = 19,
        ChainAmplitude              = 20,
        StartCooldown               = 21,
        PeriodicHealingAndDamage    = 22,
        PointsIndex2                = 23,
        BonusCoefficient            = 24,
        TriggerDamage               = 25, // NYI
        ProcFrequency               = 26,
        Amplitude                   = 27,
        DispelResistance            = 28,
        CrowdDamage                 = 29, // NYI
        PowerCostOnMiss             = 30,
        Doses                       = 31,
        PointsIndex3                = 32,
        PointsIndex4                = 33,
        PowerCost1                  = 34, // Used when SpellPowerEntry::PowerIndex == 1
        ChainJumpDistance           = 35,
        AreaTriggerMaxSummons       = 36, // NYI
        MaxAuraStacks               = 37,
        ProcCooldown                = 38,
        PowerCost2                  = 39, // Used when SpellPowerEntry::PowerIndex == 2
    };

    [Flags]
    public enum SpellCastTargetFlags
    {
        TARGET_FLAG_NONE            = 0x00000000,
        TARGET_FLAG_UNUSED_1        = 0x00000001,               // not used
        TARGET_FLAG_UNIT            = 0x00000002,               // pguid
        TARGET_FLAG_UNIT_RAID       = 0x00000004,               // not sent, used to validate target (if raid member)
        TARGET_FLAG_UNIT_PARTY      = 0x00000008,               // not sent, used to validate target (if party member)
        TARGET_FLAG_ITEM            = 0x00000010,               // pguid
        TARGET_FLAG_SOURCE_LOCATION = 0x00000020,               // pguid, 3 float
        TARGET_FLAG_DEST_LOCATION   = 0x00000040,               // pguid, 3 float
        TARGET_FLAG_UNIT_ENEMY      = 0x00000080,               // not sent, used to validate target (if enemy)
        TARGET_FLAG_UNIT_ALLY       = 0x00000100,               // not sent, used to validate target (if ally)
        TARGET_FLAG_CORPSE_ENEMY    = 0x00000200,               // pguid
        TARGET_FLAG_UNIT_DEAD       = 0x00000400,               // not sent, used to validate target (if dead creature)
        TARGET_FLAG_GAMEOBJECT      = 0x00000800,               // pguid, used with TARGET_GAMEOBJECT_TARGET
        TARGET_FLAG_TRADE_ITEM      = 0x00001000,               // pguid
        TARGET_FLAG_STRING          = 0x00002000,               // string
        TARGET_FLAG_GAMEOBJECT_ITEM = 0x00004000,               // not sent, used with TARGET_GAMEOBJECT_ITEM_TARGET
        TARGET_FLAG_CORPSE_ALLY     = 0x00008000,               // pguid
        TARGET_FLAG_UNIT_MINIPET    = 0x00010000,               // pguid, used to validate target (if non combat pet)
        TARGET_FLAG_GLYPH_SLOT      = 0x00020000,               // used in glyph spells
        TARGET_FLAG_DEST_TARGET     = 0x00040000,               // sometimes appears with DEST_TARGET spells (may appear or not for a given spell)
        TARGET_FLAG_EXTRA_TARGETS   = 0x00080000,               // uint32 counter, loop { vec3 - screen position (?), guid }, not used so far
        TARGET_FLAG_UNIT_PASSENGER  = 0x00100000,               // guessed, used to validate target (if vehicle passenger)
        TARGET_FLAG_UNK400000       = 0x00400000,
        TARGET_FLAG_UNK1000000      = 0x01000000,
        TARGET_FLAG_UNK4000000      = 0x04000000,
        TARGET_FLAG_UNK10000000     = 0x10000000,
        TARGET_FLAG_UNK40000000     = 0x40000000,
    };

    public enum Powers : sbyte
    {
        POWER_MANA                          = 0,
        POWER_RAGE                          = 1,
        POWER_FOCUS                         = 2,
        POWER_ENERGY                        = 3,
        POWER_COMBO_POINTS                  = 4,
        POWER_RUNES                         = 5,
        POWER_RUNIC_POWER                   = 6,
        POWER_SOUL_SHARDS                   = 7,
        POWER_LUNAR_POWER                   = 8,
        POWER_HOLY_POWER                    = 9,
        POWER_ALTERNATE_POWER               = 10,           // Used in some quests
        POWER_MAELSTROM                     = 11,
        POWER_CHI                           = 12,
        POWER_INSANITY                      = 13,
        POWER_BURNING_EMBERS                = 14,
        POWER_DEMONIC_FURY                  = 15,
        POWER_ARCANE_CHARGES                = 16,
        POWER_FURY                          = 17,
        POWER_PAIN                          = 18,
        POWER_ESSENCE                       = 19,
        MAX_POWERS                          = 20,
        POWER_ALL                           = 127,          // default for class?
        POWER_HEALTH                        = -2            // (-2 as signed value)
    };

    public enum AuraState
    {   // (C) used in caster aura state     (T) used in target aura state
        // (c) used in caster aura state-not (t) used in target aura state-not
        AURA_STATE_NONE                         = 0,            // C   |
        AURA_STATE_DEFENSIVE                    = 1,            // CcTt|
        AURA_STATE_WOUNDED_20_PERCENT           = 2,            // CcT |
        AURA_STATE_UNBALANCED                   = 3,            // CcT | NYI
        AURA_STATE_FROZEN                       = 4,            //  c t|
        AURA_STATE_MARKED                       = 5,            // C  t| NYI
        AURA_STATE_WOUNDED_25_PERCENT           = 6,            //   T |
        AURA_STATE_DEFENSIVE_2                  = 7,            // Cc  | NYI
        AURA_STATE_BANISHED                     = 8,            //  c  | NYI
        AURA_STATE_DAZED                        = 9,            //    t|
        AURA_STATE_VICTORIOUS                   = 10,           // C   |
        AURA_STATE_RAMPAGE                      = 11,           //     | NYI
        AURA_STATE_FAERIE_FIRE                  = 12,           //  c t|
        AURA_STATE_WOUNDED_35_PERCENT           = 13,           // CcT |
        AURA_STATE_RAID_ENCOUNTER_2             = 14,           //  cT |
        AURA_STATE_DRUID_PERIODIC_HEAL          = 15,           //   T |
        AURA_STATE_ROGUE_POISONED               = 16,           //     |
        AURA_STATE_ENRAGED                      = 17,           // C   |
        AURA_STATE_BLEED                        = 18,           //   T |
        AURA_STATE_VULNERABLE                   = 19,           //     | NYI
        AURA_STATE_ARENA_PREPARATION            = 20,           //  c  |
        AURA_STATE_WOUND_HEALTH_20_80           = 21,           //   T |
        AURA_STATE_RAID_ENCOUNTER               = 22,           // CcTt|
        AURA_STATE_HEALTHY_75_PERCENT           = 23,           // C   |
        AURA_STATE_WOUND_HEALTH_35_80           = 24            //   T |
    };

    [Flags]
    enum InventoryTypeMask : long
    {
        ALL             = -1,
        NON_EQUIP       = 1 << 0,
        HEAD            = 1 << 1,
        NECK            = 1 << 2,
        SHOULDERS       = 1 << 3,
        BODY            = 1 << 4,
        CHEST           = 1 << 5,
        WAIST           = 1 << 6,
        LEGS            = 1 << 7,
        FEET            = 1 << 8,
        WRISTS          = 1 << 9,
        HANDS           = 1 << 10,
        FINGER          = 1 << 11,
        TRINKET         = 1 << 12,
        WEAPON          = 1 << 13,
        SHIELD          = 1 << 14,
        RANGED          = 1 << 15,
        CLOAK           = 1 << 16,
        WEAPON_2H       = 1 << 17,
        BAG             = 1 << 18,
        TABARD          = 1 << 19,
        ROBE            = 1 << 20,
        WEAPONMAINHAND  = 1 << 21,
        WEAPONOFFHAND   = 1 << 22,
        HOLDABLE        = 1 << 23,
        AMMO            = 1 << 24,
        THROWN          = 1 << 25,
        RANGEDRIGHT     = 1 << 26,
        QUIVER          = 1 << 27,
        RELIC           = 1 << 28,
        PROFESSION_TOOL = 1 << 29,
        PROFESSION_GEAR = 1 << 30,
        EQUIPABLE_SPELL_OFFENSIVE = 1 << 31,
        EQUIPABLE_SPELL_UTILITY = 1L << 32,
        EQUIPABLE_SPELL_DEFENSIVE = 1L << 33,
        EQUIPABLE_SPELL_MOBILITY = 1L << 34
    };

    public enum ItemClass
    {
        CONSUMABLE                       = 0,
        CONTAINER                        = 1,
        WEAPON                           = 2,
        GEM                              = 3,
        ARMOR                            = 4,
        REAGENT                          = 5,
        PROJECTILE                       = 6,
        TRADE_GOODS                      = 7,
        ITEM_ENHANCEMENT                 = 8,
        RECIPE                           = 9,
        MONEY                            = 10, // OBSOLETE
        QUIVER                           = 11,
        QUEST                            = 12,
        KEY                              = 13,
        PERMANENT                        = 14, // OBSOLETE
        MISCELLANEOUS                    = 15,
        GLYPH                            = 16,
        BATTLE_PETS                      = 17,
        WOW_TOKEN                        = 18,
        PROFESSION                       = 19,
        MAX
    };

    [Flags]
    public enum ItemSubClassWeaponMask
    {
        ALL             = -1,
        AXE             = 1 << 0,  // One-Handed Axes
        AXE2            = 1 << 1,  // Two-Handed Axes
        BOW             = 1 << 2,
        GUN             = 1 << 3,
        MACE            = 1 << 4,  // One-Handed Maces
        MACE2           = 1 << 5,  // Two-Handed Maces
        POLEARM         = 1 << 6,
        SWORD           = 1 << 7,  // One-Handed Swords
        SWORD2          = 1 << 8,  // Two-Handed Swords
        WARGLAIVES      = 1 << 9,
        STAFF           = 1 << 10,
        EXOTIC          = 1 << 11, // One-Handed Exotics
        EXOTIC2         = 1 << 12, // Two-Handed Exotics
        FIST_WEAPON     = 1 << 13,
        MISCELLANEOUS   = 1 << 14,
        DAGGER          = 1 << 15,
        THROWN          = 1 << 16,
        SPEAR           = 1 << 17,
        CROSSBOW        = 1 << 18,
        WAND            = 1 << 19,
        FISHING_POLE    = 1 << 20
    };

    [Flags]
    public enum ItemSubClassArmorMask
    {
        ALL             = -1,
        MISCELLANEOUS   = 1 << 0,
        CLOTH           = 1 << 1,
        LEATHER         = 1 << 2,
        MAIL            = 1 << 3,
        PLATE           = 1 << 4,
        COSMETIC        = 1 << 5,
        SHIELD          = 1 << 6,
        LIBRAM          = 1 << 7,
        IDOL            = 1 << 8,
        TOTEM           = 1 << 9,
        SIGIL           = 1 << 10,
        RELIC           = 1 << 11,
    };

    [Flags]
    public enum ItemSubClassMiscMask
    {
        ALL             = -1,
        JUNK            = 1 << 0,
        REAGENT         = 1 << 1,
        COMPANION_PET   = 1 << 2,
        HOLIDAY         = 1 << 3,
        OTHER           = 1 << 4,
        MOUNT           = 1 << 5,
        MOUNT_EQUIPMENT = 1 << 6
    }

    [Flags]
    public enum CreatureTypeMask
    {
        ALL             = -1,
        NONE            = 0,
        BEAST           = 1 << 0,
        DRAGONKIN       = 1 << 1,
        DEMON           = 1 << 2,
        ELEMENTAL       = 1 << 3,
        GIANT           = 1 << 4,
        UNDEAD          = 1 << 5,
        HUMANOID        = 1 << 6,
        CRITTER         = 1 << 7,
        MECHANICAL      = 1 << 8,
        NOT_SPECIFIED   = 1 << 9,
        TOTEM           = 1 << 10,
        NON_COMBAT_PET  = 1 << 11,
        GAS_CLOUD       = 1 << 12,
        WILD_PET        = 1 << 13,
        ABERRATION      = 1 << 14
    };

    [Flags]
    public enum SpellAtribute : uint
    {
        SPELL_ATTR0_PROC_FAILURE_BURNS_CHARGE                           = 0x00000001, // TITLE Proc Failure Burns Charge
        SPELL_ATTR0_USES_RANGED_SLOT                                    = 0x00000002, // TITLE Uses Ranged Slot DESCRIPTION Use ammo, ranged attack range modifiers, ranged haste, etc.
        SPELL_ATTR0_ON_NEXT_SWING_NO_DAMAGE                             = 0x00000004, // TITLE On Next Swing (No Damage) DESCRIPTION Both "on next swing" attributes have identical handling in server & client
        SPELL_ATTR0_DO_NOT_LOG_IMMUNE_MISSES                            = 0x00000008, // TITLE Do Not Log Immune Misses (client only)
        SPELL_ATTR0_IS_ABILITY                                          = 0x00000010, // TITLE Is Ability DESCRIPTION Cannot be reflected, not affected by cast speed modifiers, etc.
        SPELL_ATTR0_IS_TRADESKILL                                       = 0x00000020, // TITLE Is Tradeskill DESCRIPTION Displayed in recipe list, not affected by cast speed modifiers
        SPELL_ATTR0_PASSIVE                                             = 0x00000040, // TITLE Passive DESCRIPTION Spell is automatically cast on self by core
        SPELL_ATTR0_DO_NOT_DISPLAY_SPELLBOOK_AURA_ICON_COMBAT_LOG       = 0x00000080, // TITLE Do Not Display (Spellbook, Aura Icon, Combat Log) (client only) DESCRIPTION Not visible in spellbook or aura bar
        SPELL_ATTR0_DO_NOT_LOG                                          = 0x00000100, // TITLE Do Not Log (client only) DESCRIPTION Spell will not appear in combat logs
        SPELL_ATTR0_HELD_ITEM_ONLY                                      = 0x00000200, // TITLE Held Item Only (client only) DESCRIPTION Client will automatically select main-hand item as cast target
        SPELL_ATTR0_ON_NEXT_SWING                                       = 0x00000400, // TITLE On Next Swing DESCRIPTION Both "on next swing" attributes have identical handling in server & client
        SPELL_ATTR0_WEARER_CASTS_PROC_TRIGGER                           = 0x00000800, // TITLE Wearer Casts Proc Trigger DESCRIPTION Just a marker attribute to show auras that trigger another spell (either directly or with a script)
        SPELL_ATTR0_SERVER_ONLY                                         = 0x00001000, // TITLE Server Only
        SPELL_ATTR0_ALLOW_ITEM_SPELL_IN_PVP                             = 0x00002000, // TITLE Allow Item Spell In PvP
        SPELL_ATTR0_ONLY_INDOORS                                        = 0x00004000, // TITLE Only Indoors
        SPELL_ATTR0_ONLY_OUTDOORS                                       = 0x00008000, // TITLE Only Outdoors
        SPELL_ATTR0_NOT_SHAPESHIFTED                                    = 0x00010000, // TITLE Not Shapeshifted
        SPELL_ATTR0_ONLY_STEALTHED                                      = 0x00020000, // TITLE Only Stealthed
        SPELL_ATTR0_DO_NOT_SHEATH                                       = 0x00040000, // TITLE Do Not Sheath (client only)
        SPELL_ATTR0_SCALES_WITH_CREATURE_LEVEL                          = 0x00080000, // TITLE Scales w/ Creature Level DESCRIPTION For non-player casts, scale impact and power cost with caster's level
        SPELL_ATTR0_CANCELS_AUTO_ATTACK_COMBAT                          = 0x00100000, // TITLE Cancels Auto Attack Combat DESCRIPTION After casting this, the current auto-attack will be interrupted
        SPELL_ATTR0_NO_ACTIVE_DEFENSE                                   = 0x00200000, // TITLE No Active Defense DESCRIPTION Spell cannot be dodged, parried or blocked
        SPELL_ATTR0_TRACK_TARGET_IN_CAST_PLAYER_ONLY                    = 0x00400000, // TITLE Track Target in Cast (Player Only) (client only)
        SPELL_ATTR0_ALLOW_CAST_WHILE_DEAD                               = 0x00800000, // TITLE Allow Cast While Dead DESCRIPTION Spells without this flag cannot be cast by dead units in non-triggered contexts
        SPELL_ATTR0_ALLOW_WHILE_MOUNTED                                 = 0x01000000, // TITLE Allow While Mounted
        SPELL_ATTR0_COOLDOWN_ON_EVENT                                   = 0x02000000, // TITLE Cooldown On Event DESCRIPTION Spell is unusable while already active, and cooldown does not begin until the effects have worn off
        SPELL_ATTR0_AURA_IS_DEBUFF                                      = 0x04000000, // TITLE Aura Is Debuff DESCRIPTION Forces the spell to be treated as a negative spell
        SPELL_ATTR0_ALLOW_WHILE_SITTING                                 = 0x08000000, // TITLE Allow While Sitting
        SPELL_ATTR0_NOT_IN_COMBAT_ONLY_PEACEFUL                         = 0x10000000, // TITLE Not In Combat (Only Peaceful)
        SPELL_ATTR0_NO_IMMUNITIES                                       = 0x20000000, // TITLE No Immunities DESCRIPTION Allows spell to pierce invulnerability, unless the invulnerability spell also has this attribute
        SPELL_ATTR0_HEARTBEAT_RESIST                                    = 0x40000000, // TITLE Heartbeat Resist DESCRIPTION Periodically re-rolls against resistance to potentially expire aura early
        SPELL_ATTR0_NO_AURA_CANCEL                                      = 0x80000000  // TITLE No Aura Cancel DESCRIPTION Prevents the player from voluntarily canceling a positive aura
    };

    [Flags]
    public enum SpellAtributeEx : uint
    {
        SPELL_ATTR1_DISMISS_PET_FIRST                                   = 0x00000001, // TITLE Dismiss Pet First DESCRIPTION Without this attribute, summoning spells will fail if caster already has a pet
        SPELL_ATTR1_USE_ALL_MANA                                        = 0x00000002, // TITLE Use All Mana DESCRIPTION Ignores listed power cost and drains entire pool instead
        SPELL_ATTR1_IS_CHANNELLED                                       = 0x00000004, // TITLE Is Channelled DESCRIPTION Both "channeled" attributes have identical handling in server & client
        SPELL_ATTR1_NO_REDIRECTION                                      = 0x00000008, // TITLE No Redirection DESCRIPTION Spell will not be attracted by SPELL_MAGNET auras (Grounding Totem)
        SPELL_ATTR1_NO_SKILL_INCREASE                                   = 0x00000010, // TITLE No Skill Increase
        SPELL_ATTR1_ALLOW_WHILE_STEALTHED                               = 0x00000020, // TITLE Allow While Stealthed
        SPELL_ATTR1_IS_SELF_CHANNELLED                                  = 0x00000040, // TITLE Is Self Channelled DESCRIPTION Both "channeled" attributes have identical handling in server & client
        SPELL_ATTR1_NO_REFLECTION                                       = 0x00000080, // TITLE No Reflection DESCRIPTION Spell will pierce through Spell Reflection and similar
        SPELL_ATTR1_ONLY_PEACEFUL_TARGETS                               = 0x00000100, // TITLE Only Peaceful Targets DESCRIPTION Target cannot be in combat
        SPELL_ATTR1_INITIATES_COMBAT_ENABLES_AUTO_ATTACK                = 0x00000200, // TITLE Initiates Combat (Enables Auto-Attack) (client only) DESCRIPTION Caster will begin auto-attacking the target on cast
        SPELL_ATTR1_NO_THREAT                                           = 0x00000400, // TITLE No Threat DESCRIPTION Also does not cause target to engage
        SPELL_ATTR1_AURA_UNIQUE                                         = 0x00000800, // TITLE Aura Unique DESCRIPTION Aura will not refresh its duration when recast
        SPELL_ATTR1_FAILURE_BREAKS_STEALTH                              = 0x00001000, // TITLE Failure Breaks Stealth
        SPELL_ATTR1_TOGGLE_FAR_SIGHT                                    = 0x00002000, // TITLE Toggle Far Sight (client only)
        SPELL_ATTR1_TRACK_TARGET_IN_CHANNEL                             = 0x00004000, // TITLE Track Target in Channel DESCRIPTION While channeling, adjust facing to face target
        SPELL_ATTR1_IMMUNITY_PURGES_EFFECT                              = 0x00008000, // TITLE Immunity Purges Effect DESCRIPTION For immunity spells, cancel all auras that this spell would make you immune to when the spell is applied
        SPELL_ATTR1_IMMUNITY_TO_HOSTILE_AND_FRIENDLY_EFFECTS            = 0x00010000, /*WRONG IMPL*/ // TITLE Immunity to Hostile & Friendly Effects DESCRIPTION Will not pierce Divine Shield, Ice Block and other full invulnerabilities
        SPELL_ATTR1_NO_AUTOCAST_AI                                      = 0x00020000, // TITLE No AutoCast (AI)
        SPELL_ATTR1_PREVENTS_ANIM                                       = 0x00040000, /*NYI*/ // TITLE Prevents Anim DESCRIPTION Auras apply UNIT_FLAG_PREVENT_EMOTES_FROM_CHAT_TEXT
        SPELL_ATTR1_EXCLUDE_CASTER                                      = 0x00080000, // TITLE Exclude Caster
        SPELL_ATTR1_FINISHING_MOVE_DAMAGE                               = 0x00100000, // TITLE Finishing Move - Damage
        SPELL_ATTR1_THREAT_ONLY_ON_MISS                                 = 0x00200000, /*NYI*/ // TITLE Threat only on Miss
        SPELL_ATTR1_FINISHING_MOVE_DURATION                             = 0x00400000, // TITLE Finishing Move - Duration
        SPELL_ATTR1_IGNORE_OWNERS_DEATH                                 = 0x00800000, /*NYI*/ // TITLE Ignore Owner's Death
        SPELL_ATTR1_SPECIAL_SKILLUP                                     = 0x01000000, // TITLE Special Skillup
        SPELL_ATTR1_AURA_STAYS_AFTER_COMBAT                             = 0x02000000, // TITLE Aura Stays After Combat
        SPELL_ATTR1_REQUIRE_ALL_TARGETS                                 = 0x04000000, // TITLE Require All Targets
        SPELL_ATTR1_DISCOUNT_POWER_ON_MISS                              = 0x08000000, // TITLE Discount Power On Miss
        SPELL_ATTR1_NO_AURA_ICON                                        = 0x10000000, // TITLE No Aura Icon (client only)
        SPELL_ATTR1_NAME_IN_CHANNEL_BAR                                 = 0x20000000, // TITLE Name in Channel Bar (client only)
        SPELL_ATTR1_DISPEL_ALL_STACKS                                   = 0x40000000, // TITLE Dispel All Stacks
        SPELL_ATTR1_CAST_WHEN_LEARNED                                   = 0x80000000  // TITLE Cast When Learned
    };

    [Flags]
    public enum SpellAtributeEx2 : uint
    {
        SPELL_ATTR2_ALLOW_DEAD_TARGET                                   = 0x00000001, // TITLE Allow Dead Target
        SPELL_ATTR2_NO_SHAPESHIFT_UI                                    = 0x00000002, // TITLE No shapeshift UI (client only) DESCRIPTION Does not replace action bar when shapeshifted
        SPELL_ATTR2_IGNORE_LINE_OF_SIGHT                                = 0x00000004, // TITLE Ignore Line of Sight
        SPELL_ATTR2_ALLOW_LOW_LEVEL_BUFF                                = 0x00000008, // TITLE Allow Low Level Buff
        SPELL_ATTR2_USE_SHAPESHIFT_BAR                                  = 0x00000010, // TITLE Use Shapeshift Bar (client only)
        SPELL_ATTR2_AUTO_REPEAT                                         = 0x00000020, // TITLE Auto Repeat
        SPELL_ATTR2_CANNOT_CAST_ON_TAPPED                               = 0x00000040, // TITLE Cannot cast on tapped DESCRIPTION Can only target untapped units, or those tapped by caster
        SPELL_ATTR2_DO_NOT_REPORT_SPELL_FAILURE                         = 0x00000080, // TITLE Do Not Report Spell Failure
        SPELL_ATTR2_INCLUDE_IN_ADVANCED_COMBAT_LOG                      = 0x00000100, // TITLE Include In Advanced Combat Log (client only) DESCRIPTION Determines whether to include this aura in list of auras in SMSG_ENCOUNTER_START
        SPELL_ATTR2_ALWAYS_CAST_AS_UNIT                                 = 0x00000200, /*NYI, UNK*/ // TITLE Always Cast As Unit
        SPELL_ATTR2_SPECIAL_TAMING_FLAG                                 = 0x00000400, // TITLE Special Taming Flag DESCRIPTION Related to taming?
        SPELL_ATTR2_NO_TARGET_PER_SECOND_COSTS                          = 0x00000800, // TITLE No Target Per-Second Costs
        SPELL_ATTR2_CHAIN_FROM_CASTER                                   = 0x00001000, // TITLE Chain From Caster
        SPELL_ATTR2_ENCHANT_OWN_ITEM_ONLY                               = 0x00002000, // TITLE Enchant own item only
        SPELL_ATTR2_ALLOW_WHILE_INVISIBLE                               = 0x00004000, // TITLE Allow While Invisible
        SPELL_ATTR2_DO_NOT_CONSUME_IF_GAINED_DURING_CAST                = 0x00008000, // TITLE Do Not Consume if Gained During Cast
        SPELL_ATTR2_NO_ACTIVE_PETS                                      = 0x00010000, // TITLE No Active Pets
        SPELL_ATTR2_DO_NOT_RESET_COMBAT_TIMERS                          = 0x00020000, // TITLE Do Not Reset Combat Timers DESCRIPTION Does not reset melee/ranged autoattack timer on cast
        SPELL_ATTR2_NO_JUMP_WHILE_CAST_PENDING                          = 0x00040000, // TITLE No Jump While Cast Pending (client only)
        SPELL_ATTR2_ALLOW_WHILE_NOT_SHAPESHIFTED_CASTER_FORM            = 0x00080000, // TITLE Allow While Not Shapeshifted (caster form) DESCRIPTION Even if Stances are nonzero, allow spell to be cast outside of shapeshift (though not in a different shapeshift)
        SPELL_ATTR2_INITIATE_COMBAT_POST_CAST_ENABLES_AUTO_ATTACK       = 0x00100000, // TITLE Initiate Combat Post-Cast (Enables Auto-Attack)
        SPELL_ATTR2_FAIL_ON_ALL_TARGETS_IMMUNE                          = 0x00200000, // TITLE Fail on all targets immune DESCRIPTION Causes BG flags to be dropped if combined with ATTR1_DISPEL_AURAS_ON_IMMUNITY
        SPELL_ATTR2_NO_INITIAL_THREAT                                   = 0x00400000, // TITLE No Initial Threat
        SPELL_ATTR2_PROC_COOLDOWN_ON_FAILURE                            = 0x00800000, // TITLE Proc Cooldown On Failure
        SPELL_ATTR2_ITEM_CAST_WITH_OWNER_SKILL                          = 0x01000000, // TITLE Item Cast With Owner Skill
        SPELL_ATTR2_DONT_BLOCK_MANA_REGEN                               = 0x02000000, // TITLE Don't Block Mana Regen
        SPELL_ATTR2_NO_SCHOOL_IMMUNITIES                                = 0x04000000, // TITLE No School Immunities DESCRIPTION Allow aura to be applied despite target being immune to new aura applications
        SPELL_ATTR2_IGNORE_WEAPONSKILL                                  = 0x08000000, // TITLE Ignore Weaponskill
        SPELL_ATTR2_NOT_AN_ACTION                                       = 0x10000000, // TITLE Not an Action
        SPELL_ATTR2_CANT_CRIT                                           = 0x20000000, // TITLE Can't Crit
        SPELL_ATTR2_ACTIVE_THREAT                                       = 0x40000000, // TITLE Active Threat
        SPELL_ATTR2_RETAIN_ITEM_CAST                                    = 0x80000000  // TITLE Retain Item Cast DESCRIPTION passes m_CastItem to triggered spells
    };

    [Flags]
    public enum SpellAtributeEx3 : uint
    {
        SPELL_ATTR3_PVP_ENABLING                                        = 0x00000001, // TITLE PvP Enabling
        SPELL_ATTR3_NO_PROC_EQUIP_REQUIREMENT                           = 0x00000002, // TITLE No Proc Equip Requirement DESCRIPTION Ignores subclass mask check when checking proc
        SPELL_ATTR3_NO_CASTING_BAR_TEXT                                 = 0x00000004, // TITLE No Casting Bar Text
        SPELL_ATTR3_COMPLETELY_BLOCKED                                  = 0x00000008, // TITLE Completely Blocked
        SPELL_ATTR3_NO_RES_TIMER                                        = 0x00000010, // TITLE No Res Timer
        SPELL_ATTR3_NO_DURABILITY_LOSS                                  = 0x00000020, // TITLE No Durability Loss
        SPELL_ATTR3_NO_AVOIDANCE                                        = 0x00000040, // TITLE No Avoidance
        SPELL_ATTR3_DOT_STACKING_RULE                                   = 0x00000080, // TITLE DoT Stacking Rule DESCRIPTION Stack separately for each caster
        SPELL_ATTR3_ONLY_ON_PLAYER                                      = 0x00000100, // TITLE Only On Player
        SPELL_ATTR3_NOT_A_PROC                                          = 0x00000200, // TITLE Not a Proc DESCRIPTION Without this attribute, any triggered spell will be unable to trigger other auras' procs
        SPELL_ATTR3_REQUIRES_MAIN_HAND_WEAPON                           = 0x00000400, // TITLE Requires Main-Hand Weapon
        SPELL_ATTR3_ONLY_BATTLEGROUNDS                                  = 0x00000800, // TITLE Only Battlegrounds
        SPELL_ATTR3_ONLY_ON_GHOSTS                                      = 0x00001000, // TITLE Only On Ghosts
        SPELL_ATTR3_HIDE_CHANNEL_BAR                                    = 0x00002000, // TITLE Hide Channel Bar (client only)
        SPELL_ATTR3_HIDE_IN_RAID_FILTER                                 = 0x00004000, // TITLE Hide In Raid Filter (client only)
        SPELL_ATTR3_NORMAL_RANGED_ATTACK                                = 0x00008000, // TITLE Normal Ranged Attack DESCRIPTION Auto Shoot, Shoot, Throw - ranged normal attack attribute?
        SPELL_ATTR3_SUPPRESS_CASTER_PROCS                               = 0x00010000, // TITLE Suppress Caster Procs
        SPELL_ATTR3_SUPPRESS_TARGET_PROCS                               = 0x00020000, // TITLE Suppress Target Procs
        SPELL_ATTR3_ALWAYS_HIT                                          = 0x00040000, // TITLE Always Hit DESCRIPTION Spell cannot miss, or be dodged/parried/blocked
        SPELL_ATTR3_INSTANT_TARGET_PROCS                                = 0x00080000, // TITLE Instant Target Procs DESCRIPTION Proc events are triggered before spell batching processes the spell hit on target
        SPELL_ATTR3_ALLOW_AURA_WHILE_DEAD                               = 0x00100000, // TITLE Allow Aura While Dead
        SPELL_ATTR3_ONLY_PROC_OUTDOORS                                  = 0x00200000, // TITLE Only Proc Outdoors
        SPELL_ATTR3_DO_NOT_TRIGGER_TARGET_STAND                         = 0x00400000, // TITLE Do Not Trigger Target Stand
        SPELL_ATTR3_NO_DAMAGE_HISTORY                                   = 0x00800000, /*NYI, no damage history implementation*/ // TITLE No Damage History
        SPELL_ATTR3_REQUIRES_OFF_HAND_WEAPON                            = 0x01000000, // TITLE Requires Off-Hand Weapon
        SPELL_ATTR3_TREAT_AS_PERIODIC                                   = 0x02000000, // TITLE Treat As Periodic
        SPELL_ATTR3_CAN_PROC_FROM_PROCS                                 = 0x04000000, // TITLE Can Proc From Procs
        SPELL_ATTR3_ONLY_PROC_ON_CASTER                                 = 0x08000000, // TITLE Only Proc on Caster
        SPELL_ATTR3_IGNORE_CASTER_AND_TARGET_RESTRICTIONS               = 0x10000000, /*NYI*/ // TITLE Ignore Caster & Target Restrictions
        SPELL_ATTR3_IGNORE_CASTER_MODIFIERS                             = 0x20000000, // TITLE Ignore Caster Modifiers
        SPELL_ATTR3_DO_NOT_DISPLAY_RANGE                                = 0x40000000, // TITLE Do Not Display Range (client only)
        SPELL_ATTR3_NOT_ON_AOE_IMMUNE                                   = 0x80000000  /*NYI, no aoe immunity implementation*/ // TITLE Not On AOE Immune
    };

    [Flags]
    public enum SpellAtributeEx4 : uint
    {
        SPELL_ATTR4_NO_CAST_LOG                                         = 0x00000001, // TITLE No Cast Log
        SPELL_ATTR4_CLASS_TRIGGER_ONLY_ON_TARGET                        = 0x00000002, // TITLE Class Trigger Only On Target
        SPELL_ATTR4_AURA_EXPIRES_OFFLINE                                = 0x00000004, // TITLE Aura Expires Offline DESCRIPTION Debuffs (except Resurrection Sickness) will automatically do this
        SPELL_ATTR4_NO_HELPFUL_THREAT                                   = 0x00000008, // TITLE No Helpful Threat
        SPELL_ATTR4_NO_HARMFUL_THREAT                                   = 0x00000010, // TITLE No Harmful Threat
        SPELL_ATTR4_ALLOW_CLIENT_TARGETING                              = 0x00000020, // TITLE Allow Client Targeting DESCRIPTION Allows client to send spell targets for this spell. Applies only to pet spells, without this attribute CMSG_PET_ACTION is sent instead of CMSG_PET_CAST_SPELL
        SPELL_ATTR4_CANNOT_BE_STOLEN                                    = 0x00000040, // TITLE Cannot Be Stolen
        SPELL_ATTR4_ALLOW_CAST_WHILE_CASTING                            = 0x00000080, // TITLE Allow Cast While Casting DESCRIPTION Ignores already in-progress cast and still casts
        SPELL_ATTR4_IGNORE_DAMAGE_TAKEN_MODIFIERS                       = 0x00000100, // TITLE Ignore Damage Taken Modifiers
        SPELL_ATTR4_COMBAT_FEEDBACK_WHEN_USABLE                         = 0x00000200, // TITLE Combat Feedback When Usable (client only)
        SPELL_ATTR4_WEAPON_SPEED_COST_SCALING                           = 0x00000400, // TITLE Weapon Speed Cost Scaling DESCRIPTION Adds 10 to power cost for each 1s of weapon speed
        SPELL_ATTR4_NO_PARTIAL_IMMUNITY                                 = 0x00000800, // TITLE No Partial Immunity
        SPELL_ATTR4_AURA_IS_BUFF                                        = 0x00001000, // TITLE Aura Is Buff
        SPELL_ATTR4_DO_NOT_LOG_CASTER                                   = 0x00002000, // TITLE Do Not Log Caster
        SPELL_ATTR4_REACTIVE_DAMAGE_PROC                                = 0x00004000, // TITLE Reactive Damage Proc DESCRIPTION Damage from spells with this attribute doesn't break auras that normally break on damage taken
        SPELL_ATTR4_NOT_IN_SPELLBOOK                                    = 0x00008000, // TITLE Not In Spellbook
        SPELL_ATTR4_NOT_IN_ARENA_OR_RATED_BATTLEGROUND                  = 0x00010000, // TITLE Not In Arena or Rated Battleground DESCRIPTION Makes spell unusable despite CD <= 10min
        SPELL_ATTR4_IGNORE_DEFAULT_ARENA_RESTRICTIONS                   = 0x00020000, // TITLE Ignore Default Arena Restrictions DESCRIPTION Makes spell usable despite CD > 10min
        SPELL_ATTR4_BOUNCY_CHAIN_MISSILES                               = 0x00040000, // TITLE Bouncy Chain Missiles DESCRIPTION Hits area targets over time instead of all at once
        SPELL_ATTR4_ALLOW_PROC_WHILE_SITTING                            = 0x00080000, // TITLE Allow Proc While Sitting
        SPELL_ATTR4_AURA_NEVER_BOUNCES                                  = 0x00100000, // TITLE Aura Never Bounces
        SPELL_ATTR4_ALLOW_ENTERING_ARENA                                = 0x00200000, // TITLE Allow Entering Arena
        SPELL_ATTR4_PROC_SUPPRESS_SWING_ANIM                            = 0x00400000, // TITLE Proc Suppress Swing Anim
        SPELL_ATTR4_SUPPRESS_WEAPON_PROCS                               = 0x00800000, // TITLE Suppress Weapon Procs
        SPELL_ATTR4_AUTO_RANGED_COMBAT                                  = 0x01000000, // TITLE Auto Ranged Combat
        SPELL_ATTR4_OWNER_POWER_SCALING                                 = 0x02000000, // TITLE Owner Power Scaling
        SPELL_ATTR4_ONLY_FLYING_AREAS                                   = 0x04000000, // TITLE Only Flying Areas
        SPELL_ATTR4_FORCE_DISPLAY_CASTBAR                               = 0x08000000, // TITLE Force Display Castbar
        SPELL_ATTR4_IGNORE_COMBAT_TIMER                                 = 0x10000000, // TITLE Ignore Combat Timer
        SPELL_ATTR4_AURA_BOUNCE_FAILS_SPELL                             = 0x20000000, // TITLE Aura Bounce Fails Spell
        SPELL_ATTR4_OBSOLETE                                            = 0x40000000, // TITLE Obsolete
        SPELL_ATTR4_USE_FACING_FROM_SPELL                               = 0x80000000  // TITLE Use Facing From Spell
    };

    [Flags]
    public enum SpellAtributeEx5 : uint
    {
        SPELL_ATTR5_ALLOW_ACTIONS_DURING_CHANNEL                        = 0x00000001, // TITLE Allow Actions During Channel
        SPELL_ATTR5_NO_REAGENT_COST_WITH_AURA                           = 0x00000002, // TITLE No Reagent Cost With Aura
        SPELL_ATTR5_REMOVE_ENTERING_ARENA                               = 0x00000004, // TITLE Remove Entering Arena DESCRIPTION Force this aura to be removed on entering arena, regardless of other properties
        SPELL_ATTR5_ALLOW_WHILE_STUNNED                                 = 0x00000008, // TITLE Allow While Stunned
        SPELL_ATTR5_TRIGGERS_CHANNELING                                 = 0x00000010, // TITLE Triggers Channeling
        SPELL_ATTR5_LIMIT_N                                             = 0x00000020, // TITLE Limit N DESCRIPTION Remove previous application to another unit if applied
        SPELL_ATTR5_IGNORE_AREA_EFFECT_PVP_CHECK                        = 0x00000040, // TITLE Ignore Area Effect PvP Check
        SPELL_ATTR5_NOT_ON_PLAYER                                       = 0x00000080, // TITLE Not On Player
        SPELL_ATTR5_NOT_ON_PLAYER_CONTROLLED_NPC                        = 0x00000100, // TITLE Not On Player Controlled NPC
        SPELL_ATTR5_EXTRA_INITIAL_PERIOD                                = 0x00000200, // TITLE Extra Initial Period DESCRIPTION Immediately do periodic tick on apply
        SPELL_ATTR5_DO_NOT_DISPLAY_DURATION                             = 0x00000400, // TITLE Do Not Display Duration
        SPELL_ATTR5_IMPLIED_TARGETING                                   = 0x00000800, // TITLE Implied Targeting (client only)
        SPELL_ATTR5_MELEE_CHAIN_TARGETING                               = 0x00001000, // TITLE Melee Chain Targeting
        SPELL_ATTR5_SPELL_HASTE_AFFECTS_PERIODIC                        = 0x00002000, // TITLE Spell Haste Affects Periodic
        SPELL_ATTR5_NOT_AVAILABLE_WHILE_CHARMED                         = 0x00004000, // TITLE Not Available While Charmed
        SPELL_ATTR5_TREAT_AS_AREA_EFFECT                                = 0x00008000, // TITLE Treat as Area Effect
        SPELL_ATTR5_AURA_AFFECTS_NOT_JUST_REQ_EQUIPPED_ITEM             = 0x00010000, // TITLE Aura Affects Not Just Req. Equipped Item
        SPELL_ATTR5_ALLOW_WHILE_FLEEING                                 = 0x00020000, // TITLE Allow While Fleeing
        SPELL_ATTR5_ALLOW_WHILE_CONFUSED                                = 0x00040000, // TITLE Allow While Confused
        SPELL_ATTR5_AI_DOESNT_FACE_TARGET                               = 0x00080000, // TITLE AI Doesn't Face Target
        SPELL_ATTR5_DO_NOT_ATTEMPT_A_PET_RESUMMON_WHEN_DISMOUNTING      = 0x00100000, // TITLE Do Not Attempt a Pet Resummon When Dismounting DESCRIPTION No generic handling possible, used by scripted dismount spells
        SPELL_ATTR5_IGNORE_TARGET_REQUIREMENTS                          = 0x00200000, /*NYI*/ // TITLE Ignore Target Requirements
        SPELL_ATTR5_NOT_ON_TRIVIAL                                      = 0x00400000, /*NYI*/ // TITLE Not On Trivial
        SPELL_ATTR5_NO_PARTIAL_RESISTS                                  = 0x00800000, /*NYI, resisting only some spell effects not implemented*/ // TITLE No Partial Resists
        SPELL_ATTR5_IGNORE_CASTER_REQUIREMENTS                          = 0x01000000, /*NYI*/ // TITLE Ignore Caster Requirements
        SPELL_ATTR5_ALWAYS_LINE_OF_SIGHT                                = 0x02000000, // TITLE Always Line of Sight
        SPELL_ATTR5_ALWAYS_AOE_LINE_OF_SIGHT                            = 0x04000000, // TITLE Always AOE Line of Sight DESCRIPTION Requires line of sight between caster and target in addition to between dest and target
        SPELL_ATTR5_NO_CASTER_AURA_ICON                                 = 0x08000000, // TITLE No Caster Aura Icon (client only)
        SPELL_ATTR5_NO_TARGET_AURA_ICON                                 = 0x10000000, // TITLE No Target Aura Icon (client only)
        SPELL_ATTR5_AURA_UNIQUE_PER_CASTER                              = 0x20000000, // TITLE Aura Unique Per Caster
        SPELL_ATTR5_ALWAYS_SHOW_GROUND_TEXTURE                          = 0x40000000, // TITLE Always Show Ground Texture
        SPELL_ATTR5_ADD_MELEE_HIT_RATING                                = 0x80000000  // TITLE Add Melee Hit Rating
    };

    [Flags]
    public enum SpellAtributeEx6 : uint
    {
        SPELL_ATTR6_NO_COOLDOWN_ON_TOOLTIP                              = 0x00000001, // TITLE No Cooldown On Tooltip (client only)
        SPELL_ATTR6_DO_NOT_RESET_COOLDOWN_IN_ARENA                      = 0x00000002, // TITLE Do Not Reset Cooldown In Arena
        SPELL_ATTR6_NOT_AN_ATTACK                                       = 0x00000004, /*NYI*/ // TITLE Not an Attack
        SPELL_ATTR6_CAN_ASSIST_IMMUNE_PC                                = 0x00000008, // TITLE Can Assist Immune PC
        SPELL_ATTR6_IGNORE_FOR_MOD_TIME_RATE                            = 0x00000010, /*NYI, time rate not implemented*/ // TITLE Ignore For Mod Time Rate
        SPELL_ATTR6_DO_NOT_CONSUME_RESOURCES                            = 0x00000020, // TITLE Do Not Consume Resources
        SPELL_ATTR6_FLOATING_COMBAT_TEXT_ON_CAST                        = 0x00000040, // TITLE Floating Combat Text On Cast (client only)
        SPELL_ATTR6_AURA_IS_WEAPON_PROC                                 = 0x00000080, // TITLE Aura Is Weapon Proc
        SPELL_ATTR6_DO_NOT_CHAIN_TO_CROWD_CONTROLLED_TARGETS            = 0x00000100, // TITLE Do Not Chain To Crowd-Controlled Targets DESCRIPTION Implicit targeting (chaining and area targeting) will not impact crowd controlled targets
        SPELL_ATTR6_ALLOW_ON_CHARMED_TARGETS                            = 0x00000200, /*NYI*/ // TITLE Allow On Charmed Targets
        SPELL_ATTR6_NO_AURA_LOG                                         = 0x00000400, // TITLE No Aura Log
        SPELL_ATTR6_NOT_IN_RAID_INSTANCES                               = 0x00000800, // TITLE Not In Raid Instances
        SPELL_ATTR6_ALLOW_WHILE_RIDING_VEHICLE                          = 0x00001000, // TITLE Allow While Riding Vehicle
        SPELL_ATTR6_IGNORE_PHASE_SHIFT                                  = 0x00002000, // TITLE Ignore Phase Shift
        SPELL_ATTR6_AI_PRIMARY_RANGED_ATTACK                            = 0x00004000, /*NYI*/ // TITLE AI Primary Ranged Attack
        SPELL_ATTR6_NO_PUSHBACK                                         = 0x00008000, // TITLE No Pushback
        SPELL_ATTR6_NO_JUMP_PATHING                                     = 0x00010000, /*NYI, currently jumps dont path at all*/ // TITLE No Jump Pathing
        SPELL_ATTR6_ALLOW_EQUIP_WHILE_CASTING                           = 0x00020000, // TITLE Allow Equip While Casting
        SPELL_ATTR6_ORIGINATE_FROM_CONTROLLER                           = 0x00040000, // TITLE Originate From Controller DESCRIPTION Client will prevent casting if not possessed, charmer will be caster for all intents and purposes
        SPELL_ATTR6_DELAY_COMBAT_TIMER_DURING_CAST                      = 0x00080000, // TITLE Delay Combat Timer During Cast
        SPELL_ATTR6_AURA_ICON_ONLY_FOR_CASTER_LIMIT_10                  = 0x00100000, // TITLE Aura Icon Only For Caster (Limit 10) (client only)
        SPELL_ATTR6_SHOW_MECHANIC_AS_COMBAT_TEXT                        = 0x00200000, // TITLE Show Mechanic as Combat Text (client only)
        SPELL_ATTR6_ABSORB_CANNOT_BE_IGNORE                             = 0x00400000, // TITLE Absorb Cannot Be Ignore
        SPELL_ATTR6_TAPS_IMMEDIATELY                                    = 0x00800000, // TITLE Taps immediately
        SPELL_ATTR6_CAN_TARGET_UNTARGETABLE                             = 0x01000000, // TITLE Can Target Untargetable
        SPELL_ATTR6_DOESNT_RESET_SWING_TIMER_IF_INSTANT                 = 0x02000000, // TITLE Doesn't Reset Swing Timer if Instant
        SPELL_ATTR6_VEHICLE_IMMUNITY_CATEGORY                           = 0x04000000, /*NYI, immunity to some buffs for some vehicles*/ // TITLE Vehicle Immunity Category
        SPELL_ATTR6_IGNORE_HEALING_MODIFIERS                            = 0x08000000, // TITLE Ignore Healing Modifiers DESCRIPTION This prevents certain healing modifiers from applying - see implementation if you really care about details
        SPELL_ATTR6_DO_NOT_AUTO_SELECT_TARGET_WITH_INITIATES_COMBAT     = 0x10000000, // TITLE Do Not Auto Select Target with Initiates Combat (client only)
        SPELL_ATTR6_IGNORE_CASTER_DAMAGE_MODIFIERS                      = 0x20000000, // TITLE Ignore Caster Damage Modifiers DESCRIPTION This prevents certain damage modifiers from applying - see implementation if you really care about details
        SPELL_ATTR6_DISABLE_TIED_EFFECT_POINTS                          = 0x40000000, /*NYI*/ // TITLE Disable Tied Effect Points
        SPELL_ATTR6_NO_CATEGORY_COOLDOWN_MODS                           = 0x80000000  // TITLE No Category Cooldown Mods
    };

    [Flags]
    public enum SpellAtributeEx7 : uint
    {
        SPELL_ATTR7_ALLOW_SPELL_REFLECTION                              = 0x00000001, // TITLE Allow Spell Reflection
        SPELL_ATTR7_NO_TARGET_DURATION_MOD                              = 0x00000002, // TITLE No Target Duration Mod
        SPELL_ATTR7_DISABLE_AURA_WHILE_DEAD                             = 0x00000004, // TITLE Disable Aura While Dead
        SPELL_ATTR7_DEBUG_SPELL                                         = 0x00000008, // TITLE Debug Spell DESCRIPTION Cannot cast if caster doesn't have UnitFlag2 & UNIT_FLAG2_ALLOW_CHEAT_SPELLS
        SPELL_ATTR7_TREAT_AS_RAID_BUFF                                  = 0x00000010, /*NYI*/ // TITLE Treat as Raid Buff
        SPELL_ATTR7_CAN_BE_MULTI_CAST                                   = 0x00000020, // TITLE Can Be Multi Cast
        SPELL_ATTR7_DONT_CAUSE_SPELL_PUSHBACK                           = 0x00000040, // TITLE Don't Cause Spell Pushback DESCRIPTION Damage dealt by this does not cause spell pushback
        SPELL_ATTR7_PREPARE_FOR_VEHICLE_CONTROL_END                     = 0x00000080, /*NYI*/ // TITLE Prepare for Vehicle Control End
        SPELL_ATTR7_HORDE_SPECIFIC_SPELL                                = 0x00000100, /*NYI*/ // TITLE Horde Specific Spell
        SPELL_ATTR7_ALLIANCE_SPECIFIC_SPELL                             = 0x00000200, /*NYI*/ // TITLE Alliance Specific Spell
        SPELL_ATTR7_DISPEL_REMOVES_CHARGES                              = 0x00000400, // TITLE Dispel Removes Charges DESCRIPTION Dispel/Spellsteal remove individual charges
        SPELL_ATTR7_CAN_CAUSE_INTERRUPT                                 = 0x00000800, // TITLE Can Cause Interrupt DESCRIPTION Only interrupt non-player casting
        SPELL_ATTR7_CAN_CAUSE_SILENCE                                   = 0x00001000, /*NYI*/ // TITLE Can Cause Silence
        SPELL_ATTR7_NO_UI_NOT_INTERRUPTIBLE                             = 0x00002000, // TITLE No UI Not Interruptible DESCRIPTION Can always be interrupted, even if caster is immune
        SPELL_ATTR7_RECAST_ON_RESUMMON                                  = 0x00004000, /*NYI - deprecated attribute, there is no SPELL_GO sent anymore on pet resummon*/ // TITLE Recast On Resummon
        SPELL_ATTR7_RESET_SWING_TIMER_AT_SPELL_START                    = 0x00008000, // TITLE Reset Swing Timer at spell start
        SPELL_ATTR7_ONLY_IN_SPELLBOOK_UNTIL_LEARNED                     = 0x00010000, // TITLE Only In Spellbook Until Learned DESCRIPTION After learning these spells become hidden in spellbook (but are visible when not learned for low level characters)
        SPELL_ATTR7_DO_NOT_LOG_PVP_KILL                                 = 0x00020000, /*NYI, only used by 1 spell that is already filtered out in pvp credits because its self targeting*/ // TITLE Do Not Log PvP Kill
        SPELL_ATTR7_ATTACK_ON_CHARGE_TO_UNIT                            = 0x00040000, // TITLE Attack on Charge to Unit
        SPELL_ATTR7_REPORT_SPELL_FAILURE_TO_UNIT_TARGET                 = 0x00080000, // TITLE Report Spell failure to unit target
        SPELL_ATTR7_NO_CLIENT_FAIL_WHILE_STUNNED_FLEEING_CONFUSED       = 0x00100000, // TITLE No Client Fail While Stunned, Fleeing, Confused DESCRIPTION Clientside - skips stunned/fleeing/confused checks
        SPELL_ATTR7_RETAIN_COOLDOWN_THROUGH_LOAD                        = 0x00200000, /*NYI*/ // TITLE Retain Cooldown Through Load
        SPELL_ATTR7_IGNORES_COLD_WEATHER_FLYING_REQUIREMENT             = 0x00400000, /*NYI - deprecated attribute*/ // TITLE Ignores Cold Weather Flying Requirement
        SPELL_ATTR7_NO_ATTACK_DODGE                                     = 0x00800000, // TITLE No Attack Dodge
        SPELL_ATTR7_NO_ATTACK_PARRY                                     = 0x01000000, // TITLE No Attack Parry
        SPELL_ATTR7_NO_ATTACK_MISS                                      = 0x02000000, // TITLE No Attack Miss
        SPELL_ATTR7_TREAT_AS_NPC_AOE                                    = 0x04000000, // TITLE Treat as NPC AoE
        SPELL_ATTR7_BYPASS_NO_RESURRECT_AURA                            = 0x08000000, // TITLE Bypass No Resurrect Aura
        SPELL_ATTR7_DO_NOT_COUNT_FOR_PVP_SCOREBOARD                     = 0x10000000, // TITLE Do Not Count For PvP Scoreboard
        SPELL_ATTR7_REFLECTION_ONLY_DEFENDS                             = 0x20000000, // TITLE Reflection Only Defends
        SPELL_ATTR7_CAN_PROC_FROM_SUPPRESSED_TARGET_PROCS               = 0x40000000, // TITLE Can Proc From Suppressed Target Procs
        SPELL_ATTR7_ALWAYS_CAST_LOG                                     = 0x80000000  // TITLE Always Cast Log
    };

    [Flags]
    public enum SpellAtributeEx8 : uint
    {
        SPELL_ATTR8_NO_ATTACK_BLOCK                                     = 0x00000001, //  0
        SPELL_ATTR8_IGNORE_DYNAMIC_OBJECT_CASTER                        = 0x00000002, //  1
        SPELL_ATTR8_REMOVE_OUTSIDE_DUNGEONS_AND_RAIDS                   = 0x00000004, //  2
        SPELL_ATTR8_ONLY_TARGET_IF_SAME_CREATOR                         = 0x00000008, //  3
        SPELL_ATTR8_CAN_HIT_AOE_UNTARGETABLE                            = 0x00000010, //  4
        SPELL_ATTR8_ALLOW_WHILE_CHARMED                                 = 0x00000020, //  5
        SPELL_ATTR8_AURA_REQUIRED_BY_CLIENT                             = 0x00000040, //  6
        SPELL_ATTR8_IGNORE_SANCTUARY                                    = 0x00000080, //  7
        SPELL_ATTR8_USE_TARGETS_LEVEL_FOR_SPELL_SCALING                 = 0x00000100, //  8 Nearly all spells have "all party and raid" in description
        SPELL_ATTR8_PERIODIC_CAN_CRIT                                   = 0x00000200, //  9 Periodic auras with this flag keep old periodic timer when refreshing at close to one tick remaining (kind of anti DoT clipping)
        SPELL_ATTR8_MIRROR_CREATURE_NAME                                = 0x00000400, // 10 according to wowhead comments, name changes, title remains
        SPELL_ATTR8_ONLY_PLAYERS_CAN_CAST_THIS_SPELL                    = 0x00000800, // 11
        SPELL_ATTR8_AURA_POINTS_ON_CLIENT                               = 0x00001000, // 12 Aura must have flag AFLAG_ANY_EFFECT_AMOUNT_SENT to send amount
        SPELL_ATTR8_NOT_IN_SPELLBOOK_UNTIL_LEARNED                      = 0x00002000, // 13
        SPELL_ATTR8_TARGET_PROCS_ON_CASTER                              = 0x00004000, // 14
        SPELL_ATTR8_REQUIRES_LOCATION_TO_BE_ON_LIQUID_SURFACE           = 0x00008000, // 15 only one River Boat used in Thousand Needles
        SPELL_ATTR8_ONLY_TARGET_OWN_SUMMONS                             = 0x00010000, // 16
        SPELL_ATTR8_HASTE_AFFECTS_DURATION                              = 0x00020000, // 17
        SPELL_ATTR8_IGNORE_SPELLCAST_OVERRIDE_COST                      = 0x00040000, // 18 at some point in time, these auras remember spells and allow to cast them later
        SPELL_ATTR8_ALLOW_TARGETS_HIDDEN_BY_SPAWN_TRACKING              = 0x00080000, // 19 allows to consume combo points from dead targets
        SPELL_ATTR8_REQUIRES_EQUIPPED_INV_TYPES                         = 0x00100000, // 20
        SPELL_ATTR8_NO__SUMMON_DEST_FROM_CLIENT__TARGETING_PATHING_REQUIREMENT = 0x00200000, // 21
        SPELL_ATTR8_MELEE_HASTE_AFFECTS_PERIODIC                        = 0x00400000, // 22
        SPELL_ATTR8_ENFORCE_IN_COMBAT_RESSURECTION_LIMIT                = 0x00800000, // 23 Used to limit the Amount of Resurrections in Boss Encounters
        SPELL_ATTR8_HEAL_PREDICTION                                     = 0x01000000, // 24
        SPELL_ATTR8_NO_LEVEL_UP_TOAST                                   = 0x02000000, // 25
        SPELL_ATTR8_SKIP_IS_KNOWN_CHECK                                 = 0x04000000, // 26 probably spell no need learn to cast
        SPELL_ATTR8_AI_FACE_TARGET                                      = 0x08000000, // 27
        SPELL_ATTR8_NOT_IN_BATTLEGROUND                                 = 0x10000000, // 28 not allow to cast or deactivate currently active effect, not sure about Fast Track
        SPELL_ATTR8_MASTERY_AFFECTS_POINTS                              = 0x20000000, // 29
        SPELL_ATTR8_DISPLAY_LARGE_AURA_ICON_ON_UNIT_FRAMES_BOSS_AURA    = 0x40000000, // 30
        SPELL_ATTR8_CAN_ATTACK_IMMUNE_PC                                = 0x80000000  // 31 Do not check UNIT_FLAG_IMMUNE_TO_PC in IsValidAttackTarget
    };

    [Flags]
    public enum SpellAtributeEx9 : uint
    {
        SPELL_ATTR9_UNK0                             = 0x00000001, //  0
        SPELL_ATTR9_UNK1                             = 0x00000002, //  1
        SPELL_ATTR9_RESTRICTED_FLIGHT_AREA           = 0x00000004, //  2 Dalaran and Wintergrasp flight area auras have it
        SPELL_ATTR9_UNK3                             = 0x00000008, //  3
        SPELL_ATTR9_SPECIAL_DELAY_CALCULATION        = 0x00000010, //  4
        SPELL_ATTR9_SUMMON_PLAYER_TOTEM              = 0x00000020, //  5
        SPELL_ATTR9_UNK6                             = 0x00000040, //  6
        SPELL_ATTR9_UNK7                             = 0x00000080, //  7
        SPELL_ATTR9_AIMED_SHOT                       = 0x00000100, //  8
        SPELL_ATTR9_NOT_USABLE_IN_ARENA              = 0x00000200, //  9 Cannot be used in arenas
        SPELL_ATTR9_UNK10                            = 0x00000400, // 10
        SPELL_ATTR9_UNK11                            = 0x00000800, // 11
        SPELL_ATTR9_UNK12                            = 0x00001000, // 12
        SPELL_ATTR9_SLAM                             = 0x00002000, // 13
        SPELL_ATTR9_USABLE_IN_RATED_BATTLEGROUNDS    = 0x00004000, // 14 Can be used in Rated Battlegrounds
        SPELL_ATTR9_UNK15                            = 0x00008000, // 15
        SPELL_ATTR9_UNK16                            = 0x00010000, // 16
        SPELL_ATTR9_UNK17                            = 0x00020000, // 17
        SPELL_ATTR9_UNK18                            = 0x00040000, // 18
        SPELL_ATTR9_UNK19                            = 0x00080000, // 19
        SPELL_ATTR9_UNK20                            = 0x00100000, // 20
        SPELL_ATTR9_UNK21                            = 0x00200000, // 21
        SPELL_ATTR9_UNK22                            = 0x00400000, // 22
        SPELL_ATTR9_UNK23                            = 0x00800000, // 23
        SPELL_ATTR9_UNK24                            = 0x01000000, // 24
        SPELL_ATTR9_UNK25                            = 0x02000000, // 25
        SPELL_ATTR9_UNK26                            = 0x04000000, // 26
        SPELL_ATTR9_UNK27                            = 0x08000000, // 27
        SPELL_ATTR9_UNK28                            = 0x10000000, // 28
        SPELL_ATTR9_UNK29                            = 0x20000000, // 29
        SPELL_ATTR9_UNK30                            = 0x40000000, // 30
        SPELL_ATTR9_UNK31                            = 0x80000000  // 31
    };

    [Flags]
    public enum SpellAtributeEx10 : uint
    {
        SPELL_ATTR10_UNK0                            = 0x00000001, //  0
        SPELL_ATTR10_UNK1                            = 0x00000002, //  1
        SPELL_ATTR10_UNK2                            = 0x00000004, //  2
        SPELL_ATTR10_UNK3                            = 0x00000008, //  3
        SPELL_ATTR10_WATER_SPOUT                     = 0x00000010, //  4
        SPELL_ATTR10_UNK5                            = 0x00000020, //  5
        SPELL_ATTR10_UNK6                            = 0x00000040, //  6
        SPELL_ATTR10_TELEPORT_PLAYER                 = 0x00000080, //  7 4 Teleport Player spells
        SPELL_ATTR10_UNK8                            = 0x00000100, //  8
        SPELL_ATTR10_UNK9                            = 0x00000200, //  9
        SPELL_ATTR10_UNK10                           = 0x00000400, // 10
        SPELL_ATTR10_HERB_GATHERING_MINING           = 0x00000800, // 11 Only Herb Gathering and Mining
        SPELL_ATTR10_USE_SPELL_BASE_LEVEL_FOR_SCALING= 0x00001000, // 12
        SPELL_ATTR10_RESET_COOLDOWN_ON_ENCOUNTER_END = 0x00002000, // 13
        SPELL_ATTR10_UNK14                           = 0x00004000, // 14
        SPELL_ATTR10_UNK15                           = 0x00008000, // 15
        SPELL_ATTR10_UNK16                           = 0x00010000, // 16
        SPELL_ATTR10_CAN_DODGE_PARRY_WHILE_CASTING   = 0x00020000, // 17
        SPELL_ATTR10_UNK18                           = 0x00040000, // 18
        SPELL_ATTR10_UNK19                           = 0x00080000, // 19
        SPELL_ATTR10_UNK20                           = 0x00100000, // 20
        SPELL_ATTR10_UNK21                           = 0x00200000, // 21
        SPELL_ATTR10_UNK22                           = 0x00400000, // 22
        SPELL_ATTR10_UNK23                           = 0x00800000, // 23
        SPELL_ATTR10_UNK24                           = 0x01000000, // 24
        SPELL_ATTR10_UNK25                           = 0x02000000, // 25
        SPELL_ATTR10_UNK26                           = 0x04000000, // 26
        SPELL_ATTR10_UNK27                           = 0x08000000, // 27
        SPELL_ATTR10_UNK28                           = 0x10000000, // 28
        SPELL_ATTR10_MOUNT_IS_NOT_ACCOUNT_WIDE       = 0x20000000, // 29 This mount is stored per-character
        SPELL_ATTR10_UNK30                           = 0x40000000, // 30
        SPELL_ATTR10_UNK31                           = 0x80000000  // 31
    };

    [Flags]
    enum SpellAtributeEx11 : uint
    {
        SPELL_ATTR11_UNK0                            = 0x00000001, //  0
        SPELL_ATTR11_UNK1                            = 0x00000002, //  1
        SPELL_ATTR11_SCALES_WITH_ITEM_LEVEL          = 0x00000004, //  2
        SPELL_ATTR11_UNK3                            = 0x00000008, //  3
        SPELL_ATTR11_UNK4                            = 0x00000010, //  4
        SPELL_ATTR11_ABSORB_ENVIRONMENTAL_DAMAGE     = 0x00000020, //  5
        SPELL_ATTR11_UNK6                            = 0x00000040, //  6
        SPELL_ATTR11_RANK_IGNORES_CASTER_LEVEL       = 0x00000080, //  7 Spell_C_GetSpellRank returns SpellLevels->MaxLevel * 5 instead of std::min(SpellLevels->MaxLevel, caster->Level) * 5
        SPELL_ATTR11_UNK8                            = 0x00000100, //  8
        SPELL_ATTR11_UNK9                            = 0x00000200, //  9
        SPELL_ATTR11_UNK10                           = 0x00000400, // 10
        SPELL_ATTR11_NOT_USABLE_IN_INSTANCES         = 0x00000800, // 11
        SPELL_ATTR11_UNK12                           = 0x00001000, // 12
        SPELL_ATTR11_UNK13                           = 0x00002000, // 13
        SPELL_ATTR11_UNK14                           = 0x00004000, // 14
        SPELL_ATTR11_UNK15                           = 0x00008000, // 15
        SPELL_ATTR11_NOT_USABLE_IN_CHALLENGE_MODE    = 0x00010000, // 16
        SPELL_ATTR11_UNK17                           = 0x00020000, // 17
        SPELL_ATTR11_UNK18                           = 0x00040000, // 18
        SPELL_ATTR11_UNK19                           = 0x00080000, // 19
        SPELL_ATTR11_UNK20                           = 0x00100000, // 20
        SPELL_ATTR11_UNK21                           = 0x00200000, // 21
        SPELL_ATTR11_UNK22                           = 0x00400000, // 22
        SPELL_ATTR11_UNK23                           = 0x00800000, // 23
        SPELL_ATTR11_UNK24                           = 0x01000000, // 24
        SPELL_ATTR11_UNK25                           = 0x02000000, // 25
        SPELL_ATTR11_UNK26                           = 0x04000000, // 26
        SPELL_ATTR11_UNK27                           = 0x08000000, // 27
        SPELL_ATTR11_UNK28                           = 0x10000000, // 28
        SPELL_ATTR11_UNK29                           = 0x20000000, // 29
        SPELL_ATTR11_UNK30                           = 0x40000000, // 30
        SPELL_ATTR11_UNK31                           = 0x80000000  // 31
    };

    [Flags]
    enum SpellAtributeEx12 : uint
    {
        SPELL_ATTR12_UNK0                            = 0x00000001, //  0
        SPELL_ATTR12_UNK1                            = 0x00000002, //  1
        SPELL_ATTR12_UNK2                            = 0x00000004, //  2
        SPELL_ATTR12_UNK3                            = 0x00000008, //  3
        SPELL_ATTR12_UNK4                            = 0x00000010, //  4
        SPELL_ATTR12_UNK5                            = 0x00000020, //  5
        SPELL_ATTR12_UNK6                            = 0x00000040, //  6
        SPELL_ATTR12_UNK7                            = 0x00000080, //  7
        SPELL_ATTR12_UNK8                            = 0x00000100, //  8
        SPELL_ATTR12_IGNORE_CASTING_DISABLED         = 0x00000200, //  9 Ignores aura 263 SPELL_AURA_DISABLE_CASTING_EXCEPT_ABILITIES
        SPELL_ATTR12_UNK10                           = 0x00000400, // 10
        SPELL_ATTR12_UNK11                           = 0x00000800, // 11
        SPELL_ATTR12_UNK12                           = 0x00001000, // 12
        SPELL_ATTR12_UNK13                           = 0x00002000, // 13
        SPELL_ATTR12_UNK14                           = 0x00004000, // 14
        SPELL_ATTR12_UNK15                           = 0x00008000, // 15
        SPELL_ATTR12_UNK16                           = 0x00010000, // 16
        SPELL_ATTR12_UNK17                           = 0x00020000, // 17
        SPELL_ATTR12_UNK18                           = 0x00040000, // 18
        SPELL_ATTR12_UNK19                           = 0x00080000, // 19
        SPELL_ATTR12_UNK20                           = 0x00100000, // 20
        SPELL_ATTR12_UNK21                           = 0x00200000, // 21
        SPELL_ATTR12_UNK22                           = 0x00400000, // 22
        SPELL_ATTR12_START_COOLDOWN_ON_CAST_START    = 0x00800000, // 23
        SPELL_ATTR12_IS_GARRISON_BUFF                = 0x01000000, // 24
        SPELL_ATTR12_UNK25                           = 0x02000000, // 25
        SPELL_ATTR12_UNK26                           = 0x04000000, // 26
        SPELL_ATTR12_IS_READINESS_SPELL              = 0x08000000, // 27
        SPELL_ATTR12_UNK28                           = 0x10000000, // 28
        SPELL_ATTR12_UNK29                           = 0x20000000, // 29
        SPELL_ATTR12_UNK30                           = 0x40000000, // 30
        SPELL_ATTR12_UNK31                           = 0x80000000  // 31
    };

    [Flags]
    enum SpellAtributeEx13 : uint
    {
        SPELL_ATTR13_UNK0                            = 0x00000001, //  0
        SPELL_ATTR13_UNK1                            = 0x00000002, //  1
        SPELL_ATTR13_UNK2                            = 0x00000004, //  2
        SPELL_ATTR13_UNK3                            = 0x00000008, //  3
        SPELL_ATTR13_UNK4                            = 0x00000010, //  4
        SPELL_ATTR13_UNK5                            = 0x00000020, //  5
        SPELL_ATTR13_UNK6                            = 0x00000040, //  6
        SPELL_ATTR13_UNK7                            = 0x00000080, //  7
        SPELL_ATTR13_UNK8                            = 0x00000100, //  8
        SPELL_ATTR13_UNK9                            = 0x00000200, //  9
        SPELL_ATTR13_UNK10                           = 0x00000400, // 10
        SPELL_ATTR13_UNK11                           = 0x00000800, // 11
        SPELL_ATTR13_UNK12                           = 0x00001000, // 12
        SPELL_ATTR13_UNK13                           = 0x00002000, // 13
        SPELL_ATTR13_UNK14                           = 0x00004000, // 14
        SPELL_ATTR13_UNK15                           = 0x00008000, // 15
        SPELL_ATTR13_UNK16                           = 0x00010000, // 16
        SPELL_ATTR13_UNK17                           = 0x00020000, // 17
        SPELL_ATTR13_ACTIVATES_REQUIRED_SHAPESHIFT   = 0x00040000, // 18
        SPELL_ATTR13_UNK19                           = 0x00080000, // 19
        SPELL_ATTR13_UNK20                           = 0x00100000, // 20
        SPELL_ATTR13_UNK21                           = 0x00200000, // 21
        SPELL_ATTR13_UNK22                           = 0x00400000, // 22
        SPELL_ATTR13_UNK23                           = 0x00800000, // 23
        SPELL_ATTR13_UNK24                           = 0x01000000, // 24
        SPELL_ATTR13_UNK25                           = 0x02000000, // 25
        SPELL_ATTR13_UNK26                           = 0x04000000, // 26
        SPELL_ATTR13_UNK27                           = 0x08000000, // 27
        SPELL_ATTR13_UNK28                           = 0x10000000, // 28
        SPELL_ATTR13_UNK29                           = 0x20000000, // 29
        SPELL_ATTR13_UNK30                           = 0x40000000, // 30
        SPELL_ATTR13_UNK31                           = 0x80000000  // 31
    };

    [Flags]
    enum SpellAtributeEx14 : uint
    {
        SPELL_ATTR14_UNK0 = 0x00000001, //  0
        SPELL_ATTR14_UNK1 = 0x00000002, //  1
        SPELL_ATTR14_UNK2 = 0x00000004, //  2
        SPELL_ATTR14_UNK3 = 0x00000008, //  3
        SPELL_ATTR14_UNK4 = 0x00000010, //  4
        SPELL_ATTR14_UNK5 = 0x00000020, //  5
        SPELL_ATTR14_UNK6 = 0x00000040, //  6
        SPELL_ATTR14_UNK7 = 0x00000080, //  7
        SPELL_ATTR14_UNK8 = 0x00000100, //  8
        SPELL_ATTR14_UNK9 = 0x00000200, //  9
        SPELL_ATTR14_UNK10 = 0x00000400, // 10
        SPELL_ATTR14_UNK11 = 0x00000800, // 11
        SPELL_ATTR14_UNK12 = 0x00001000, // 12
        SPELL_ATTR14_UNK13 = 0x00002000, // 13
        SPELL_ATTR14_UNK14 = 0x00004000, // 14
        SPELL_ATTR14_UNK15 = 0x00008000, // 15
        SPELL_ATTR14_UNK16 = 0x00010000, // 16
        SPELL_ATTR14_UNK17 = 0x00020000, // 17
        SPELL_ATTR14_UNK18 = 0x00040000, // 18
        SPELL_ATTR14_UNK19 = 0x00080000, // 19
        SPELL_ATTR14_UNK20 = 0x00100000, // 20
        SPELL_ATTR14_UNK21 = 0x00200000, // 21
        SPELL_ATTR14_UNK22 = 0x00400000, // 22
        SPELL_ATTR14_UNK23 = 0x00800000, // 23
        SPELL_ATTR14_UNK24 = 0x01000000, // 24
        SPELL_ATTR14_UNK25 = 0x02000000, // 25
        SPELL_ATTR14_UNK26 = 0x04000000, // 26
        SPELL_ATTR14_UNK27 = 0x08000000, // 27
        SPELL_ATTR14_UNK28 = 0x10000000, // 28
        SPELL_ATTR14_UNK29 = 0x20000000, // 29
        SPELL_ATTR14_UNK30 = 0x40000000, // 30
        SPELL_ATTR14_UNK31 = 0x80000000  // 31
    };

    [Flags]
    public enum SpellEffectAttributes : uint
    {
        None                                    = 0,
        NoImmunity                              = 0x000001,
        PositionIsFacingRelative                = 0x000002,
        JumpChargeUnitMeleeRange                = 0x000004,
        JumpChargeUnitStrictPathCheck           = 0x000008,
        ExcludeOwnParty                         = 0x000010,
        AlwaysAoeLineOfSight                    = 0x000020,
        SuppressPointsStacking                  = 0x000040,
        ChainFromInitialTarget                  = 0x000080,
        UncontrolledNoBackwards                 = 0x000100,
        AuraPointsStack                         = 0x000200,
        NoCopyDamageInterruptsOrProcs           = 0x000400,
        AddTargetCombatReachToAOE               = 0x000800,
        IsHarmful                               = 0x001000,
        ForceScaleToOverrideCameraMinHeight     = 0x002000,
        PlayersOnly                             = 0x004000,
        ComputePointsOnlyAtCastTime             = 0x008000,
        EnforceLineOfSightToChainTargets        = 0x010000,
        AreaEffectsUseTargetRadius              = 0x020000,
        TeleportWithVehicle                     = 0x040000,
        ScalePointsByChallengeModeDamageScaler  = 0x080000,
        DontFailSpellOnTargetingFailure         = 0x100000,
        IgnoreDuringCooldownTimeRateCalculation = 0x800000
    };

    [Flags]
    public enum CombatRating
    {
        CR_AMPLIFY                  = 1 << 0,
        CR_DEFENSE_SKILL            = 1 << 1,
        CR_DODGE                    = 1 << 2,
        CR_PARRY                    = 1 << 3,
        CR_BLOCK                    = 1 << 4,
        CR_HIT_MELEE                = 1 << 5,
        CR_HIT_RANGED               = 1 << 6,
        CR_HIT_SPELL                = 1 << 7,
        CR_CRIT_MELEE               = 1 << 8,
        CR_CRIT_RANGED              = 1 << 9,
        CR_CRIT_SPELL               = 1 << 10,
        CR_MULTISTRIKE              = 1 << 11,
        CR_READINESS                = 1 << 12,
        CR_SPEED                    = 1 << 13,
        CR_RESILIENCE_CRIT_TAKEN    = 1 << 14,
        CR_RESILIENCE_PLAYER_DAMAGE = 1 << 15,
        CR_LIFESTEAL                = 1 << 16,
        CR_HASTE_MELEE              = 1 << 17,
        CR_HASTE_RANGED             = 1 << 18,
        CR_HASTE_SPELL              = 1 << 19,
        CR_AVOIDANCE                = 1 << 20,
        CR_STURDINESS               = 1 << 21,
        CR_UNUSED_7                 = 1 << 22,
        CR_EXPERTISE                = 1 << 23,
        CR_ARMOR_PENETRATION        = 1 << 24,
        CR_MASTERY                  = 1 << 25,
        CR_PVP_POWER                = 1 << 26,
        CR_CLEAVE                   = 1 << 27,
        CR_VERSATILITY_DAMAGE_DONE  = 1 << 28,
        CR_VERSATILITY_HEALING_DONE = 1 << 29,
        CR_VERSATILITY_DAMAGE_TAKEN = 1 << 30,
        CR_UNUSED_12                = 1 << 31
    };

    public enum UnitMods
    {
        UNIT_MOD_STAT_STRENGTH,                                 // UNIT_MOD_STAT_STRENGTH..UNIT_MOD_STAT_INTELLECT must be in existed order, it's accessed by index values of Stats enum.
        UNIT_MOD_STAT_AGILITY,
        UNIT_MOD_STAT_STAMINA,
        UNIT_MOD_STAT_INTELLECT
    };

    [Flags]
    enum SpellInterruptFlags
    {
        None                        = 0,
        Movement                    = 0x00000001,
        DamagePushbackPlayerOnly    = 0x00000002,
        Stun                        = 0x00000004, // useless, even spells without it get interrupted
        Combat                      = 0x00000008,
        DamageCancelsPlayerOnly     = 0x00000010,
        MeleeCombat                 = 0x00000020, // NYI
        Immunity                    = 0x00000040, // NYI
        DamageAbsorb                = 0x00000080,
        ZeroDamageCancels           = 0x00000100,
        DamagePushback              = 0x00000200,
        DamageCancels               = 0x00000400
    };

    [Flags]
    enum SpellAuraInterruptFlags : uint
    {
        None                        = 0,
        HostileActionReceived       = 0x00000001,
        Damage                      = 0x00000002,
        Action                      = 0x00000004,
        Moving                      = 0x00000008,
        Turning                     = 0x00000010,
        Anim                        = 0x00000020,
        Dismount                    = 0x00000040,
        UnderWater                  = 0x00000080,
        AboveWater                  = 0x00000100,
        Sheathing                   = 0x00000200,
        Interacting                 = 0x00000400,
        Looting                     = 0x00000800,
        Attacking                   = 0x00001000,
        ItemUse                     = 0x00002000,
        DamageChannelDuration       = 0x00004000,
        Shapeshifting               = 0x00008000,
        ActionDelayed               = 0x00010000,
        Mount                       = 0x00020000,
        Standing                    = 0x00040000,
        LeaveWorld                  = 0x00080000,
        StealthOrInvis              = 0x00100000,
        InvulnerabilityBuff         = 0x00200000,
        EnterWorld                  = 0x00400000,
        PvPActive                   = 0x00800000,
        NonPeriodicDamage           = 0x01000000,
        LandingOrFlight             = 0x02000000,
        Release                     = 0x04000000,
        DamageScript                = 0x08000000,
        EnteringCombat              = 0x10000000,
        Login                       = 0x20000000,
        Summon                      = 0x40000000,
        LeavingCombat               = 0x80000000,
    };

    [Flags]
    enum SpellAuraInterruptFlags2 : uint
    {
        None                        = 0,
        Falling                     = 0x00000001,
        Swimming                    = 0x00000002,
        NotMoving                   = 0x00000004,
        Ground                      = 0x00000008,
        Transform                   = 0x00000010,
        Jump                        = 0x00000020,
        ChangeSpec                  = 0x00000040,
        AbandonVehicle              = 0x00000080,
        StartOfEncounter            = 0x00000100,
        EndOfEncounter              = 0x00000200,
        Disconnect                  = 0x00000400,
        EnteringInstance            = 0x00000800,
        DuelEnd                     = 0x00001000,
        LeaveArenaOrBattleground    = 0x00002000,
        ChangeTalent                = 0x00004000,
        ChangeGlyph                 = 0x00008000,
        SeamlessTransfer            = 0x00010000,
        WarModeLeave                = 0x00020000,
        TouchingGround              = 0x00040000,
        ChromieTime                 = 0x00080000,
        SplineFlightOrFreeFlight    = 0x00100000,
        ProcOrPeriodicAttacking     = 0x00200000
    };

    public enum Classes
    {
        CLASS_NONE          = 0,
        CLASS_WARRIOR       = 1,
        CLASS_PALADIN       = 2,
        CLASS_HUNTER        = 3,
        CLASS_ROGUE         = 4,
        CLASS_PRIEST        = 5,
        CLASS_DEATH_KNIGHT  = 6,
        CLASS_SHAMAN        = 7,
        CLASS_MAGE          = 8,
        CLASS_WARLOCK       = 9,
        CLASS_MONK          = 10,
        CLASS_DRUID         = 11,
        CLASS_DEMON_HUNTER  = 12,
        CLASS_EVOKER        = 13,
        CLASS_ADVENTURER    = 14,
    }

    public enum ExpectedStatType
    {
        CreatureHealth          = 0,
        PlayerHealth            = 1,
        CreatureAutoAttackDps   = 2,
        CreatureArmor           = 3,
        PlayerMana              = 4,
        PlayerPrimaryStat       = 5,
        PlayerSecondaryStat     = 6,
        ArmorConstant           = 7,
        None                    = 8,
        CreatureSpellDamage     = 9
    }

// ReSharper restore InconsistentNaming

    public class SpellEnums
    {
        #region ProcFlagDesc

        public static readonly string[] ProcFlagDesc =
        {
            //00 0x00000001 000000000000000000000001 -
            "00 Heartbeat",
            //01 0x00000002 000000000000000000000010 -
            "01 Kill that yields experience or honor",

            //02 0x00000004 000000000000000000000100 -
            "02 Successful melee attack",
            //03 0x00000008 000000000000000000001000 -
            "03 Taken damage from melee strike hit",

            //04 0x00000010 000000000000000000010000 -
            "04 Successful attack by Spell that use melee weapon",
            //05 0x00000020 000000000000000000100000 -
            "05 Taken damage by Spell that use melee weapon",

            //06 0x00000040 000000000000000001000000 -
            "06 Successful Ranged attack(and wand spell cast)",
            //07 0x00000080 000000000000000010000000 -
            "07 Taken damage from ranged attack",

            //08 0x00000100 000000000000000100000000 -
            "08 Successful Ranged attack by Spell that use ranged weapon",
            //09 0x00000200 000000000000001000000000 -
            "09 Taken damage by Spell that use ranged weapon",

            //10 0x00000400 000000000000010000000000 -
            "10 Successful positive spell hit",
            //11 0x00000800 000000000000100000000000 -
            "11 Taken positive spell hit",

            //12 0x00001000 000000000001000000000000 -
            "12 Successful negative spell cast",
            //13 0x00002000 000000000010000000000000 -
            "13 Taken negative spell hit",

            //14 0x00004000 000000000100000000000000 -
            "14 Successful cast positive magic spell",
            //15 0x00008000 000000001000000000000000 -
            "15 Taken positive magic spell hit",

            //16 0x00010000 000000010000000000000000 -
            "16 Successful damage from harmful magic spell cast",
            //17 0x00020000 000000100000000000000000 -
            "17 Taken magic spell damage",

            //18 0x00040000 000001000000000000000000 -
            "18 Deal periodic damage",
            //19 0x00080000 000010000000000000000000 -
            "19 Taken periodic damage",

            //20 0x00100000 000100000000000000000000 -
            "20 Taken any damage",
            //21 0x00200000 001000000000000000000000 -
            "21 Deal helpful periodic",

            //22 0x00800000 010000000000000000000000 -
            "22 Successful main-hand melee attacks",
            //23 0x00800000 100000000000000000000000 -
            "23 Successful off-hand melee attacks",

            //24 0x01000000
            "24 On death",
            //25 0x02000000
            "25 Jumped",
            "26 Proc Clone Spell",
            //27 0x08000000
            "27 Entered combat",
            //28 0x10000000
            "28 Encounter started",
            "29 On end of spell cast",
            "30 Looted something",
            "31 Taken helpful periodic",
            "32 Kill or assist in killing target (not restricted to killing blow)",
            "33 Knockback",
            "34 Cast Successful",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63"
        };
        #endregion
    }
}
