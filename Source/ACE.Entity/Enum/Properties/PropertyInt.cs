﻿namespace ACE.Entity.Enum.Properties
{
    public enum PropertyInt : ushort
    {
        Undef,
        ItemType,
        CreatureType,
        PaletteTemplate,
        ClothingPriority,
        EncumbVal,
        ItemsCapacity,
        [PersistedProperty(true, typeof(Character), 20u)]
        ContainersCapacity,
        Mass,
        Locations,
        CurrentWieldedLocation,
        MaxStackSize,
        StackSize,
        StackUnitEncumb,
        StackUnitMass,
        StackUnitValue,
        ItemUseable,
        RareId,
        UiEffects,
        Value,
        CoinValue,
        TotalExperience,
        AvailableCharacter,
        [PersistedProperty(true, typeof(Character), 0u)]
        TotalSkillCredits,
        [PersistedProperty(true, typeof(Character), 0u)]
        AvailableSkillCredits,
        [PersistedProperty(true, typeof(Character), 1u)]
        Level,
        AccountRequirements, // ToD Flag
        ArmorType,
        ArmorLevel,
        AllegianceCpPool,
        AllegianceRank,
        ChannelsAllowed,
        ChannelsActive,
        Bonded,
        MonarchsRank,
        AllegianceFollowers,
        ResistMagic,
        ResistItemAppraisal,
        ResistLockpick,
        DeprecatedResistRepair,
        CombatMode,
        CurrentAttackHeight,
        CombatCollisions,
        [PersistedProperty(true, typeof(Character), 0u)]
        NumDeaths,
        [PersistedProperty(true, typeof(Character), 0u)]
        Damage,
        DamageType,
        DefaultCombatStyle,
        AttackType,
        WeaponSkill,
        WeaponTime,
        AmmoType,
        CombatUse,
        ParentLocation,
        PlacementPosition,
        WeaponEncumbrance,
        WeaponMass,
        ShieldValue,
        ShieldEncumbrance,
        MissileInventoryLocation,
        FullDamageType,
        WeaponRange,
        AttackersSkill,
        DefendersSkill,
        AttackersSkillValue,
        AttackersClass,
        Placement,
        CheckpointStatus,
        Tolerance,
        TargetingTactic,
        CombatTactic,
        HomesickTargetingTactic,
        NumFollowFailures,
        FriendType,
        FoeType,
        MerchandiseItemTypes,
        MerchandiseMinValue,
        MerchandiseMaxValue,
        NumItemsSold,
        NumItemsBought,
        MoneyIncome,
        MoneyOutflow,
        MaxGeneratedObjects,
        InitGeneratedObjects,
        ActivationResponse,
        OriginalValue,
        NumMoveFailures,
        MinLevel,
        MaxLevel,
        LockpickMod,
        BoosterEnum,
        BoostValue,
        MaxStructure,
        Structure,
        PhysicsState,
        TargetType,
        RadarblipColor,
        EncumbCapacity,
        LoginTimestamp,
        CreationTimestamp,
        PkLevelModifier,
        GeneratorType,
        AiAllowedCombatStyle,
        LogoffTimestamp,
        GeneratorDestructionType,
        ActivationCreateClass,
        ItemWorkmanship,
        ItemSpellcraft,
        ItemCurMana,
        ItemMaxMana,
        ItemDifficulty,
        ItemAllegianceRankLimit,
        PortalBitmask,
        AdvocateLevel,
        Gender,
        Attuned,
        ItemSkillLevelLimit,
        GateLogic,
        ItemManaCost,
        Logoff,
        Active,
        AttackHeight,
        NumAttackFailures,
        AiCpThreshold,
        AiAdvancementStrategy,
        Version,
        [PersistedProperty(true, typeof(Character), 1u)]
        Age,
        VendorHappyMean,
        VendorHappyVariance,
        CloakStatus,
        VitaeCpPool,
        NumServicesSold,
        MaterialType,
        NumAllegianceBreaks,
        ShowableOnRadar,
        [PersistedProperty(true, typeof(Character), 2u)]
        PlayerKillerStatus,
        VendorHappyMaxItems,
        ScorePageNum,
        ScoreConfigNum,
        ScoreNumScores,
        [PersistedProperty(true, typeof(Character), 0u)]
        DeathLevel,
        AiOptions,
        OpenToEveryone,
        GeneratorTimeType,
        GeneratorStartTime,
        GeneratorEndTime,
        GeneratorEndDestructionType,
        XpOverride,
        NumCrashAndTurns,
        ComponentWarningThreshold,
        HouseStatus,
        HookPlacement,
        HookType,
        HookItemType,
        AiPpThreshold,
        GeneratorVersion,
        HouseType,
        PickupEmoteOffset,
        WeenieIteration,
        WieldRequirements,
        WieldSkilltype,
        WieldDifficulty,
        HouseMaxHooksUsable,
        HouseCurrentHooksUsable,
        AllegianceMinLevel,
        AllegianceMaxLevel,
        HouseRelinkHookCount,
        SlayerCreatureType,
        ConfirmationInProgress,
        ConfirmationTypeInProgress,
        TsysMutationData,
        NumItemsInMaterial,
        NumTimesTinkered,
        AppraisalLongDescDecoration,
        AppraisalLockpickSuccessPercent,
        AppraisalPages,
        AppraisalMaxPages,
        AppraisalItemSkill,
        GemCount,
        GemType,
        ImbuedEffect,
        AttackersRawSkillValue,
        ChessRank,
        ChessTotalgames,
        ChessGameswon,
        ChessGameslost,
        TypeOfAlteration,
        SkillToBeAltered,
        SkillAlterationCount,
        HeritageGroup,
        TransferFromAttribute,
        TransferToAttribute,
        AttributeTransferCount,
        FakeFishingSkill,
        NumKeys,
        DeathTimestamp,
        PkTimestamp,
        VictimTimestamp,
        HookGroup,
        AllegianceSwearTimestamp,
        HousePurchaseTimestamp,
        RedirectableEquippedArmorCount,
        MeleedefenseImbuedeffecttypeCache,
        MissiledefenseImbuedeffecttypeCache,
        MagicdefenseImbuedeffecttypeCache,
        ElementalDamageBonus,
        ImbueAttempts,
        ImbueSuccesses,
        CreatureKills,
        PlayerKillsPk,
        PlayerKillsPkl,
        RaresTierOne,
        RaresTierTwo,
        RaresTierThree,
        RaresTierFour,
        RaresTierFive,
        AugmentationStat,
        AugmentationFamilyStat,
        AugmentationInnateFamily,
        AugmentationInnateStrength,
        AugmentationInnateEndurance,
        AugmentationInnateCoordination,
        AugmentationInnateQuickness,
        AugmentationInnateFocus,
        AugmentationInnateSelf,
        AugmentationSpecializeSalvaging,
        AugmentationSpecializeItemTinkering,
        AugmentationSpecializeArmorTinkering,
        AugmentationSpecializeMagicItemTinkering,
        AugmentationSpecializeWeaponTinkering,
        AugmentationExtraPackSlot,
        AugmentationIncreasedCarryingCapacity,
        AugmentationLessDeathItemLoss,
        AugmentationSpellsRemainPastDeath,
        AugmentationCriticalDefense,
        AugmentationBonusXp,
        AugmentationBonusSalvage,
        AugmentationBonusImbueChance,
        AugmentationFasterRegen,
        AugmentationIncreasedSpellDuration,
        AugmentationResistanceFamily,
        AugmentationResistanceSlash,
        AugmentationResistancePierce,
        AugmentationResistanceBlunt,
        AugmentationResistanceAcid,
        AugmentationResistanceFire,
        AugmentationResistanceFrost,
        AugmentationResistanceLightning,
        RaresTierOneLogin,
        RaresTierTwoLogin,
        RaresTierThreeLogin,
        RaresTierFourLogin,
        RaresTierFiveLogin,
        RaresLoginTimestamp,
        RaresTierSix,
        RaresTierSeven,
        RaresTierSixLogin,
        RaresTierSevenLogin,
        ItemAttributeLimit,
        ItemAttributeLevelLimit,
        ItemAttribute2ndLimit,
        ItemAttribute2ndLevelLimit,
        CharacterTitleId,
        NumCharacterTitles,
        ResistanceModifierType,
        FreeTinkersBitfield,
        EquipmentSetId,
        PetClass,
        Lifespan,
        RemainingLifespan,
        UseCreateQuantity,
        WieldRequirements2,
        WieldSkilltype2,
        WieldDifficulty2,
        WieldRequirements3,
        WieldSkilltype3,
        WieldDifficulty3,
        WieldRequirements4,
        WieldSkilltype4,
        WieldDifficulty4,
        Unique,
        SharedCooldown,
        Faction1Bits,
        Faction2Bits,
        Faction3Bits,
        Hatred1Bits,
        Hatred2Bits,
        Hatred3Bits,
        SocietyRankCelhan,
        SocietyRankEldweb,
        SocietyRankRadblo,
        HearLocalSignals,
        HearLocalSignalsRadius,
        Cleaving,
        AugmentationSpecializeGearcraft,
        AugmentationInfusedCreatureMagic,
        AugmentationInfusedItemMagic,
        AugmentationInfusedLifeMagic,
        AugmentationInfusedWarMagic,
        AugmentationCriticalExpertise,
        AugmentationCriticalPower,
        AugmentationSkilledMelee,
        AugmentationSkilledMissile,
        AugmentationSkilledMagic,
        ImbuedEffect2,
        ImbuedEffect3,
        ImbuedEffect4,
        ImbuedEffect5,
        DamageRating,
        DamageResistRating,
        AugmentationDamageBonus,
        AugmentationDamageReduction,
        ImbueStackingBits,
        HealOverTime,
        CritRating,
        CritDamageRating,
        CritResistRating,
        CritDamageResistRating,
        HealingResistRating,
        DamageOverTime,
        ItemMaxLevel,
        ItemXpStyle,
        EquipmentSetExtra,
        AetheriaBitfield,
        HealingBoostRating,
        HeritageSpecificArmor,
        AlternateRacialSkills,
        [PersistedProperty(true, typeof(Character), 1u)] // because who doesn't like free buffs?
        AugmentationJackOfAllTrades,
        AugmentationResistanceNether,
        AugmentationInfusedVoidMagic,
        WeaknessRating,
        NetherOverTime,
        NetherResistRating,
        LuminanceAward,
        LumAugDamageRating,
        LumAugDamageReductionRating,
        LumAugCritDamageRating,
        LumAugCritReductionRating,
        LumAugSurgeEffectRating,
        LumAugSurgeChanceRating,
        LumAugItemManaUsage,
        LumAugItemManaGain,
        LumAugVitality,
        LumAugHealingRating,
        LumAugSkilledCraft,
        LumAugSkilledSpec,
        LumAugNoDestroyCraft,
        RestrictInteraction,
        OlthoiLootTimestamp,
        OlthoiLootStep,
        UseCreatesContractId,
        DotResistRating,
        LifeResistRating,
        CloakWeaveProc,
        WeaponType,
        [PersistedProperty(true, typeof(Character), 1u)]
        MeleeMastery,
        RangedMastery,
        SneakAttackRating,
        RecklessnessRating,
        DeceptionRating,
        CombatPetRange,
        WeaponAuraDamage,
        WeaponAuraSpeed,
        SummoningMastery,
        HeartbeatLifespan,
        UseLevelRequirement,
        LumAugAllSkills,
        UseRequiresSkill,
        UseRequiresSkillLevel,
        UseRequiresSkillSpec,
        UseRequiresLevel,
        GearDamage,
        GearDamageResist,
        GearCrit,
        GearCritResist,
        GearCritDamage,
        GearCritDamageResist,
        GearHealingBoost,
        GearNetherResist,
        GearLifeResist,
        GearMaxHealth,
        Unknown380,
        Unknown381,
        Unknown382,
        Unknown383,
        Unknown384,
        Unknown385,
        Unknown386,
        Unknown387,
        Unknown388,
        Unknown389,
        Unknown390,
        Count
    }

    public static class PropertyIntExtensions
    {
        public static PersistedPropertyAttribute GetPersistedPropertyAttribute(this PropertyInt val)
        {
            return Enum.EnumHelper.GetAttributeOfType<PersistedPropertyAttribute>(val);
        }
    }
}
