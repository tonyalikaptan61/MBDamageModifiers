using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.MountAndBlade;

namespace DamageModifiers
{
	public class MCMSettings : AttributeGlobalSettings<MCMSettings>
	{
		public override string Id => "DamageModifiers";
		public override string DisplayName => "Damage Modifiers";
		public override string FolderName => "DamageModifiers";
		public override string FormatType => "json";

		#region GENERAL
		const string GroupNameGeneral = "{=8byRf9zO}General";

		[SettingPropertyFloatingInteger(
			"{=DMG_MO_001}Melee Damage",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = "{=DMG_MO_001H}Melee damage modifier, multiplicative with other modifiers. [Native: 1.00]",
			Order = 0)]
		[SettingPropertyGroup(
			GroupNameGeneral,
			GroupOrder = 0)]
		public float Melee { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_002}Ranged Damage",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = "{=DMG_MO_002H}Ranged damage modifier, multiplicative with other modifiers. [Native: 1.00]",
			Order = 1)]
		[SettingPropertyGroup(
			GroupNameGeneral,
			GroupOrder = 0)]
		public float Ranged { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_003}Horse Charge Damage",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = "{=DMG_MO_003H}Horse charge damage modifier, multiplicative with other modifiers. [Native: 1.00]",
			Order = 2)]
		[SettingPropertyGroup(
			GroupNameGeneral,
			GroupOrder = 0)]
		public float HorseCharge { get; set; } = 1f;


		[SettingPropertyFloatingInteger(
            "{=DMG_MO_004}Damage to Shields",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = "{=DMG_MO_004H}Damage modifier against shields, multiplicative with other modifiers. [Native: 1.00]",
			Order = 3)]
		[SettingPropertyGroup(
			GroupNameGeneral,
			GroupOrder = 0)]
		public float Shields { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_005}Damage to Objects",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = "{=DMG_MO_005H}Damage modifier against objects, multiplicative with other modifiers. [Native: 1.00]",
			Order = 4)]
		[SettingPropertyGroup(
			GroupNameGeneral,
			GroupOrder = 0)]
		public float Objects { get; set; } = 1f;


		[SettingPropertyFloatingInteger(
            "{=DMG_MO_006}Fall Damage",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = "{=DMG_MO_006H}Damage modifier for fall damage, equal for everyone. [Native: 1.00]",
			Order = 5)]
		[SettingPropertyGroup(
			GroupNameGeneral,
			GroupOrder = 0)]
		public float Fall { get; set; } = 1f;
		#endregion

		#region BATTLE MODIFIERS
		const string GroupNameBattle = "{=DMG_MO_007}Battles etc.";
		const string HintTextBattle = "{=DMG_MO_007H}Attacker vs Victim in non-arena/tournament fights. Will be further modified by difficulty setting. [Native: 1.00]";

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_009}Player vs Player",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextBattle,
			Order = 0)]
		[SettingPropertyGroup(
			GroupNameBattle,
			GroupOrder = 1)]
		public float BattlePlayerPlayer { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_010}Hero vs Player",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextBattle,
			Order = 1)]
		[SettingPropertyGroup(
			GroupNameBattle,
			GroupOrder = 1)]
		public float BattleHeroPlayer { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_011}Other vs Player",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextBattle,
			Order = 2)]
		[SettingPropertyGroup(
			GroupNameBattle,
			GroupOrder = 1)]
		public float BattleOtherPlayer { get; set; } = 1f;


		[SettingPropertyFloatingInteger(
            "{=DMG_MO_012}Player vs Hero",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextBattle,
			Order = 3)]
		[SettingPropertyGroup(
			GroupNameBattle,
			GroupOrder = 1)]
		public float BattlePlayerHero { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_013}Hero vs Hero",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextBattle,
			Order = 4)]
		[SettingPropertyGroup(
			GroupNameBattle,
			GroupOrder = 1)]
		public float BattleHeroHero { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_014}Other vs Hero",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextBattle,
			Order = 5)]
		[SettingPropertyGroup(
			GroupNameBattle,
			GroupOrder = 1)]
		public float BattleOtherHero { get; set; } = 1f;


		[SettingPropertyFloatingInteger(
            "{=DMG_MO_015}Player vs Other",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextBattle,
			Order = 6)]
		[SettingPropertyGroup(
			GroupNameBattle,
			GroupOrder = 1)]
		public float BattlePlayerOther { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_016}Hero vs Other",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextBattle,
			Order = 7)]
		[SettingPropertyGroup(
			GroupNameBattle,
			GroupOrder = 1)]
		public float BattleHeroOther { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_017}Other vs Other",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextBattle,
			Order = 8)]
		[SettingPropertyGroup(
			GroupNameBattle,
			GroupOrder = 1)]
		public float BattleOtherOther { get; set; } = 1f;
		#endregion

		#region ARENA MODIFIERS
		const string GroupNameArena = "{=DMG_MO_008}Arena & Tournament";
		const string HintTextArena = "{=DMG_MO_008H}Attacker vs Victim, in Arena and tournament fights. Will be further modified by difficulty setting. [Native: 1.00]";

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_009}Player vs Player",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextArena,
			Order = 0)]
		[SettingPropertyGroup(
			GroupNameArena,
			GroupOrder = 2)]
		public float ArenaPlayerPlayer { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_0010}Hero vs Player",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextArena,
			Order = 1)]
		[SettingPropertyGroup(
			GroupNameArena,
			GroupOrder = 2)]
		public float ArenaHeroPlayer { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_011}Other vs Player",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextArena,
			Order = 2)]
		[SettingPropertyGroup(
			GroupNameArena,
			GroupOrder = 2)]
		public float ArenaOtherPlayer { get; set; } = 1f;


		[SettingPropertyFloatingInteger(
            "{=DMG_MO_012}Player vs Hero",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextArena,
			Order = 3)]
		[SettingPropertyGroup(
			GroupNameArena,
			GroupOrder = 2)]
		public float ArenaPlayerHero { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_013}Hero vs Hero",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextArena,
			Order = 4)]
		[SettingPropertyGroup(
			GroupNameArena,
			GroupOrder = 2)]
		public float ArenaHeroHero { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_014}Other vs Hero",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextArena,
			Order = 5)]
		[SettingPropertyGroup(
			GroupNameArena,
			GroupOrder = 2)]
		public float ArenaOtherHero { get; set; } = 1f;


		[SettingPropertyFloatingInteger(
            "{=DMG_MO_015}Player vs Other",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextArena,
			Order = 6)]
		[SettingPropertyGroup(
			GroupNameArena,
			GroupOrder = 2)]
		public float ArenaPlayerOther { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_016}Hero vs Other",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextArena,
			Order = 7)]
		[SettingPropertyGroup(
			GroupNameArena,
			GroupOrder = 2)]
		public float ArenaHeroOther { get; set; } = 1f;

		[SettingPropertyFloatingInteger(
            "{=DMG_MO_017}Other vs Other",
			0f,
			10f,
			"0.00",
			RequireRestart = false,
			HintText = HintTextArena,
			Order = 8)]
		[SettingPropertyGroup(
			GroupNameArena,
			GroupOrder = 2)]
		public float ArenaOtherOther { get; set; } = 1f;
		#endregion
	}
}