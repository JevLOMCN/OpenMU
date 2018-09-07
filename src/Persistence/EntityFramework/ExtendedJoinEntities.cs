﻿// <copyright file="ExtendedJoinEntities.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a T4 template.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MUnique.OpenMU.Persistence.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Table("SkillPowerUpDefinition", Schema = "config")]
    internal partial class SkillPowerUpDefinition : IDictionaryEntity<Int32, PowerUpDefinition>
    {
        public Int32 Key { get; set; }

        public Guid ValueId { get; set; }

        [ForeignKey("ValueId")]
        public PowerUpDefinition Value { get; set; }
    }

    [Table("AccountCharacterClass", Schema = "data")]
    internal partial class AccountCharacterClass 
    {
        public Guid AccountId { get; set; }
        public Account Account { get; set; }

        public Guid CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
    }

    internal partial class Account
    {
        public ICollection<AccountCharacterClass> JoinedUnlockedCharacterClasses { get; } = new List<AccountCharacterClass>();
    }

    [Table("CharacterDropItemGroup", Schema = "data")]
    internal partial class CharacterDropItemGroup 
    {
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }

        public Guid DropItemGroupId { get; set; }
        public DropItemGroup DropItemGroup { get; set; }
    }

    internal partial class Character
    {
        public ICollection<CharacterDropItemGroup> JoinedDropItemGroups { get; } = new List<CharacterDropItemGroup>();
    }

    [Table("ItemItemSetGroup", Schema = "data")]
    internal partial class ItemItemSetGroup 
    {
        public Guid ItemId { get; set; }
        public Item Item { get; set; }

        public Guid ItemSetGroupId { get; set; }
        public ItemSetGroup ItemSetGroup { get; set; }
    }

    internal partial class Item
    {
        public ICollection<ItemItemSetGroup> JoinedItemSetGroups { get; } = new List<ItemItemSetGroup>();
    }

    [Table("ItemAppearanceItemOptionType", Schema = "data")]
    internal partial class ItemAppearanceItemOptionType 
    {
        public Guid ItemAppearanceId { get; set; }
        public ItemAppearance ItemAppearance { get; set; }

        public Guid ItemOptionTypeId { get; set; }
        public ItemOptionType ItemOptionType { get; set; }
    }

    internal partial class ItemAppearance
    {
        public ICollection<ItemAppearanceItemOptionType> JoinedVisibleOptions { get; } = new List<ItemAppearanceItemOptionType>();
    }

    [Table("DropItemGroupItemDefinition", Schema = "config")]
    internal partial class DropItemGroupItemDefinition 
    {
        public Guid DropItemGroupId { get; set; }
        public DropItemGroup DropItemGroup { get; set; }

        public Guid ItemDefinitionId { get; set; }
        public ItemDefinition ItemDefinition { get; set; }
    }

    internal partial class DropItemGroup
    {
        public ICollection<DropItemGroupItemDefinition> JoinedPossibleItems { get; } = new List<DropItemGroupItemDefinition>();
    }

    [Table("GameMapDefinitionDropItemGroup", Schema = "config")]
    internal partial class GameMapDefinitionDropItemGroup 
    {
        public Guid GameMapDefinitionId { get; set; }
        public GameMapDefinition GameMapDefinition { get; set; }

        public Guid DropItemGroupId { get; set; }
        public DropItemGroup DropItemGroup { get; set; }
    }

    internal partial class GameMapDefinition
    {
        public ICollection<GameMapDefinitionDropItemGroup> JoinedDropItemGroups { get; } = new List<GameMapDefinitionDropItemGroup>();
    }

    [Table("GameServerConfigurationGameMapDefinition", Schema = "config")]
    internal partial class GameServerConfigurationGameMapDefinition 
    {
        public Guid GameServerConfigurationId { get; set; }
        public GameServerConfiguration GameServerConfiguration { get; set; }

        public Guid GameMapDefinitionId { get; set; }
        public GameMapDefinition GameMapDefinition { get; set; }
    }

    internal partial class GameServerConfiguration
    {
        public ICollection<GameServerConfigurationGameMapDefinition> JoinedMaps { get; } = new List<GameServerConfigurationGameMapDefinition>();
    }

    [Table("MasterSkillDefinitionSkill", Schema = "config")]
    internal partial class MasterSkillDefinitionSkill 
    {
        public Guid MasterSkillDefinitionId { get; set; }
        public MasterSkillDefinition MasterSkillDefinition { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
    }

    internal partial class MasterSkillDefinition
    {
        public ICollection<MasterSkillDefinitionSkill> JoinedRequiredMasterSkills { get; } = new List<MasterSkillDefinitionSkill>();
    }

    [Table("MonsterDefinitionDropItemGroup", Schema = "config")]
    internal partial class MonsterDefinitionDropItemGroup 
    {
        public Guid MonsterDefinitionId { get; set; }
        public MonsterDefinition MonsterDefinition { get; set; }

        public Guid DropItemGroupId { get; set; }
        public DropItemGroup DropItemGroup { get; set; }
    }

    internal partial class MonsterDefinition
    {
        public ICollection<MonsterDefinitionDropItemGroup> JoinedDropItemGroups { get; } = new List<MonsterDefinitionDropItemGroup>();
    }

    [Table("SkillCharacterClass", Schema = "config")]
    internal partial class SkillCharacterClass 
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }

        public Guid CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
    }

    internal partial class Skill
    {
        public ICollection<SkillCharacterClass> JoinedQualifiedCharacters { get; } = new List<SkillCharacterClass>();
    }

    [Table("SkillMasterSkillDefinition", Schema = "config")]
    internal partial class SkillMasterSkillDefinition 
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }

        public Guid MasterSkillDefinitionId { get; set; }
        public MasterSkillDefinition MasterSkillDefinition { get; set; }
    }

    internal partial class Skill
    {
        public ICollection<SkillMasterSkillDefinition> JoinedMasterDefinitions { get; } = new List<SkillMasterSkillDefinition>();
    }

    [Table("ItemDefinitionCharacterClass", Schema = "config")]
    internal partial class ItemDefinitionCharacterClass 
    {
        public Guid ItemDefinitionId { get; set; }
        public ItemDefinition ItemDefinition { get; set; }

        public Guid CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
    }

    internal partial class ItemDefinition
    {
        public ICollection<ItemDefinitionCharacterClass> JoinedQualifiedCharacters { get; } = new List<ItemDefinitionCharacterClass>();
    }

    [Table("ItemDefinitionItemSetGroup", Schema = "config")]
    internal partial class ItemDefinitionItemSetGroup 
    {
        public Guid ItemDefinitionId { get; set; }
        public ItemDefinition ItemDefinition { get; set; }

        public Guid ItemSetGroupId { get; set; }
        public ItemSetGroup ItemSetGroup { get; set; }
    }

    internal partial class ItemDefinition
    {
        public ICollection<ItemDefinitionItemSetGroup> JoinedPossibleItemSetGroups { get; } = new List<ItemDefinitionItemSetGroup>();
    }

    [Table("ItemDefinitionItemOptionDefinition", Schema = "config")]
    internal partial class ItemDefinitionItemOptionDefinition 
    {
        public Guid ItemDefinitionId { get; set; }
        public ItemDefinition ItemDefinition { get; set; }

        public Guid ItemOptionDefinitionId { get; set; }
        public ItemOptionDefinition ItemOptionDefinition { get; set; }
    }

    internal partial class ItemDefinition
    {
        public ICollection<ItemDefinitionItemOptionDefinition> JoinedPossibleItemOptions { get; } = new List<ItemDefinitionItemOptionDefinition>();
    }

    [Table("ItemCraftingRequiredItemItemOptionType", Schema = "config")]
    internal partial class ItemCraftingRequiredItemItemOptionType 
    {
        public Guid ItemCraftingRequiredItemId { get; set; }
        public ItemCraftingRequiredItem ItemCraftingRequiredItem { get; set; }

        public Guid ItemOptionTypeId { get; set; }
        public ItemOptionType ItemOptionType { get; set; }
    }

    internal partial class ItemCraftingRequiredItem
    {
        public ICollection<ItemCraftingRequiredItemItemOptionType> JoinedRequiredItemOptions { get; } = new List<ItemCraftingRequiredItemItemOptionType>();
    }

}