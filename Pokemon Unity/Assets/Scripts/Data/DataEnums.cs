﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class eAbility{
	/// <summary>
	/// Ability ids are connected to XML file.
	/// </summary>
	/// <remarks>Can now code with strings or int and
	/// access the same value.</remarks>
	public enum Ability{
        NONE = 0,
		STENCH = 1,
		DRIZZLE = 2,
		SPEED_BOOST = 3,
		BATTLE_ARMOR = 4,
		STURDY = 5,
		DAMP = 6,
		LIMBER = 7,
		SAND_VEIL = 8,
		STATIC = 9,
		VOLT_ABSORB = 10,
		WATER_ABSORB = 11,
		OBLIVIOUS = 12,
		CLOUD_NINE = 13,
		COMPOUND_EYES = 14,
		INSOMNIA = 15,
		COLOR_CHANGE = 16,
		IMMUNITY = 17,
		FLASH_FIRE = 18,
		SHIELD_DUST = 19,
		OWN_TEMPO = 20,
		SUCTION_CUPS = 21,
		INTIMIDATE = 22,
		SHADOW_TAG = 23,
		ROUGH_SKIN = 24,
		WONDER_GUARD = 25,
		LEVITATE = 26,
		EFFECT_SPORE = 27,
		SYNCHRONIZE = 28,
		CLEAR_BODY = 29,
		NATURAL_CURE = 30,
		LIGHTNING_ROD = 31,
		SERENE_GRACE = 32,
		SWIFT_SWIM = 33,
		CHLOROPHYLL = 34,
		ILLUMINATE = 35,
		TRACE = 36,
		HUGE_POWER = 37,
		POISON_POINT = 38,
		INNER_FOCUS = 39,
		MAGMA_ARMOR = 40,
		WATER_VEIL = 41,
		MAGNET_PULL = 42,
		SOUNDPROOF = 43,
		RAIN_DISH = 44,
		SAND_STREAM = 45,
		PRESSURE = 46,
		THICK_FAT = 47,
		EARLY_BIRD = 48,
		FLAME_BODY = 49,
		RUN_AWAY = 50,
		KEEN_EYE = 51,
		HYPER_CUTTER = 52,
		PICKUP = 53,
		TRUANT = 54,
		HUSTLE = 55,
		CUTE_CHARM = 56,
		PLUS = 57,
		MINUS = 58,
		FORECAST = 59,
		STICKY_HOLD = 60,
		SHED_SKIN = 61,
		GUTS = 62,
		MARVEL_SCALE = 63,
		LIQUID_OOZE = 64,
		OVERGROW = 65,
		BLAZE = 66,
		TORRENT = 67,
		SWARM = 68,
		ROCK_HEAD = 69,
		DROUGHT = 70,
		ARENA_TRAP = 71,
		VITAL_SPIRIT = 72,
		WHITE_SMOKE = 73,
		PURE_POWER = 74,
		SHELL_ARMOR = 75,
		AIR_LOCK = 76,
		TANGLED_FEET = 77,
		MOTOR_DRIVE = 78,
		RIVALRY = 79,
		STEADFAST = 80,
		SNOW_CLOAK = 81,
		GLUTTONY = 82,
		ANGER_POINT = 83,
		UNBURDEN = 84,
		HEATPROOF = 85,
		SIMPLE = 86,
		DRY_SKIN = 87,
		DOWNLOAD = 88,
		IRON_FIST = 89,
		POISON_HEAL = 90,
		ADAPTABILITY = 91,
		SKILL_LINK = 92,
		HYDRATION = 93,
		SOLAR_POWER = 94,
		QUICK_FEET = 95,
		NORMALIZE = 96,
		SNIPER = 97,
		MAGIC_GUARD = 98,
		NO_GUARD = 99,
		STALL = 100,
		TECHNICIAN = 101,
		LEAF_GUARD = 102,
		KLUTZ = 103,
		MOLD_BREAKER = 104,
		SUPER_LUCK = 105,
		AFTERMATH = 106,
		ANTICIPATION = 107,
		FOREWARN = 108,
		UNAWARE = 109,
		TINTED_LENS = 110,
		FILTER = 111,
		SLOW_START = 112,
		SCRAPPY = 113,
		STORM_DRAIN = 114,
		ICE_BODY = 115,
		SOLID_ROCK = 116,
		SNOW_WARNING = 117,
		HONEY_GATHER = 118,
		FRISK = 119,
		RECKLESS = 120,
		MULTITYPE = 121,
		FLOWER_GIFT = 122,
		BAD_DREAMS = 123,
		PICKPOCKET = 124,
		SHEER_FORCE = 125,
		CONTRARY = 126,
		UNNERVE = 127,
		DEFIANT = 128,
		DEFEATIST = 129,
		CURSED_BODY = 130,
		HEALER = 131,
		FRIEND_GUARD = 132,
		WEAK_ARMOR = 133,
		HEAVY_METAL = 134,
		LIGHT_METAL = 135,
		MULTISCALE = 136,
		TOXIC_BOOST = 137,
		FLARE_BOOST = 138,
		HARVEST = 139,
		TELEPATHY = 140,
		MOODY = 141,
		OVERCOAT = 142,
		POISON_TOUCH = 143,
		REGENERATOR = 144,
		BIG_PECKS = 145,
		SAND_RUSH = 146,
		WONDER_SKIN = 147,
		ANALYTIC = 148,
		ILLUSION = 149,
		IMPOSTER = 150,
		INFILTRATOR = 151,
		MUMMY = 152,
		MOXIE = 153,
		JUSTIFIED = 154,
		RATTLED = 155,
		MAGIC_BOUNCE = 156,
		SAP_SIPPER = 157,
		PRANKSTER = 158,
		SAND_FORCE = 159,
		IRON_BARBS = 160,
		ZEN_MODE = 161,
		VICTORY_STAR = 162,
		TURBOBLAZE = 163,
		TERAVOLT = 164,
		AROMA_VEIL = 165,
		FLOWER_VEIL = 166,
		CHEEK_POUCH = 167,
		PROTEAN = 168,
		FUR_COAT = 169,
		MAGICIAN = 170,
		BULLETPROOF = 171,
		COMPETITIVE = 172,
		STRONG_JAW = 173,
		REFRIGERATE = 174,
		SWEET_VEIL = 175,
		STANCE_CHANGE = 176,
		GALE_WINGS = 177,
		MEGA_LAUNCHER = 178,
		GRASS_PELT = 179,
		SYMBIOSIS = 180,
		TOUGH_CLAWS = 181,
		PIXILATE = 182,
		GOOEY = 183,
		AERILATE = 184,
		PARENTAL_BOND = 185,
		DARK_AURA = 186,
		FAIRY_AURA = 187,
		AURA_BREAK = 188,
		PRIMORDIAL_SEA = 189,
		DESOLATE_LAND = 190,
		DELTA_STREAM = 191
	}
}

public class eItems{
    /// <summary>
    /// Item ids are connected to XML file. 
    /// </summary>
    /// <remarks>
    /// Running off of genVI. 
    /// Be sure to overwrite both if modifying.
    /// Replace "[HP]{mechanic:hp}" in summary-tags with
    /// "<see cref="PokemonOld.HP"/>" or "<see cref="PokemonOld.currentHP"/>"
    /// </remarks>
    public enum Item
    {
        /// <summary>Used in battle :   [Catches]{mechanic:catch} a wild Pokémon without fail.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon, using a catch rate of 2×.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon, using a catch rate of 1.5×.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon, using a catch rate of 1×.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon, using a catch rate of 1.5×.  This item can only be used in the []{location:great-marsh} or []{location:kanto-safari-zone}.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If the wild Pokémon is []{type:water}- or []{type:bug}-type, this ball has a catch rate of 3×.  Otherwise, it has a catch rate of 1×.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If the wild Pokémon was encountered by surfing or fishing, this ball has a catch rate of 3.5×.  Otherwise, it has a catch rate of 1×.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  Has a catch rate of given by `(40 - level) / 10`, where `level` is the wild Pokémon's level, to a maximum of 3.9× for level 1 Pokémon.  If the wild Pokémon's level is higher than 30, this ball has a catch rate of 1×.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If the wild Pokémon's species is marked as caught in the trainer's Pokédex, this ball has a catch rate of 3×.  Otherwise, it has a catch rate of 1×.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  Has a catch rate of 1.1× on the first turn of the battle and increases by 0.1× every turn, to a maximum of 4× on turn 30.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon, using a catch rate of 1×.  Whenever the caught Pokémon's [happiness]{mechanic:happiness} increases, it increases by one extra point.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon, using a catch rate of 1×.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If it's currently nighttime or the wild Pokémon was encountered while walking in a cave, this ball has a catch rate of 3.5×.  Otherwise, it has a catch rate of 1×.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon, using a catch rate of 1×.  The caught Pokémon's [HP]{mechanic:hp} is immediately restored, [PP]{mechanic:pp} for all its moves is restored, and any [status ailment]{mechanic:status-ailment} is cured.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon, using a catch rate of 4× on the first turn of a battle, but 1× any other time.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon, using a catch rate of 1×.      If used in a trainer battle, nothing happens and the ball is lost.</summary>
        /// <summary>Used on a friendly Pokémon :   Restores 20 [HP]{mechanic:hp}.</summary>
        /// <summary>Used on a party Pokémon :   Cures [poison]{mechanic:poison}.</summary>
        /// <summary>Used on a party Pokémon :   Cures a [burn]{mechanic:burn}.</summary>
        /// <summary>Used on a party Pokémon :   Cures [freezing]{mechanic:freezing}.</summary>
        /// <summary>Used on a party Pokémon :   Cures [sleep]{mechanic:sleep}.</summary>
        /// <summary>Used on a party Pokémon :   Cures [paralysis]{mechanic:paralysis}.</summary>
        /// <summary>Used on a party Pokémon :   Restores [HP]{mechanic:hp} to full and cures any [status ailment]{mechanic:status-ailment} and [confusion]{mechanic:confusion}.</summary>
        /// <summary>Used on a party Pokémon :   Restores [HP]{mechanic:hp} to full.</summary>
        /// <summary>Used on a party Pokémon :   Restores 200 [HP]{mechanic:hp}.</summary>
        /// <summary>Used on a party Pokémon :   Restores 50 [HP]{mechanic:hp}.</summary>
        /// <summary>Used on a party Pokémon :   Cures any [status ailment]{mechanic:status-ailment} and [confusion]{mechanic:confusion}.</summary>
        /// <summary>Used on a party Pokémon :   Revives the Pokémon and restores half its [HP]{mechanic:hp}.</summary>
        /// <summary>Used on a party Pokémon :   Revives the Pokémon and restores its [HP]{mechanic:hp} to full.</summary>
        /// <summary>Used on a party Pokémon :   Restores 50 [HP]{mechanic:hp}.</summary>
        /// <summary>Used on a party Pokémon :   Restores 60 [HP]{mechanic:hp}.</summary>
        /// <summary>Used on a party Pokémon :   Restores 80 [HP]{mechanic:hp}.</summary>
        /// <summary>Used on a party Pokémon :   Restores 100 [HP]{mechanic:hp}.</summary>
        /// <summary>Used on a party Pokémon :   Restores 50 [HP]{mechanic:hp}.  Decreases [happiness]{mechanic:happiness} by 5/5/10.</summary>
        /// <summary>Used on a party Pokémon :   Restores 200 [HP]{mechanic:hp}.  Decreases [happiness]{mechanic:happiness} by 10/10/15.</summary>
        /// <summary>Used on a party Pokémon :   Cures any [status ailment]{mechanic:status-ailment}.  Decreases [happiness]{mechanic:happiness} by 5/5/10.</summary>
        /// <summary>Used on a party Pokémon :   Revives a [fainted]{mechanic:faint} Pokémon and restores its [HP]{mechanic:hp} to full.  Decreases [happiness]{mechanic:happiness} by 10/10/15.</summary>
        /// <summary>Used on a party Pokémon :   Restores 10 [PP]{mechanic:pp} for a selected move.</summary>
        /// <summary>Used on a party Pokémon :   Restores [PP]{mechanic:pp} to full for a selected move.</summary>
        /// <summary>Used on a party Pokémon :   Restores 10 [PP]{mechanic:pp} for each move.</summary>
        /// <summary>Used on a party Pokémon :   Restores [PP]{mechanic:pp} to full for each move.</summary>
        /// <summary>Used on a party Pokémon :   Cures any [status ailment]{mechanic:status-ailment} and [confusion]{mechanic:confusion}.</summary>
        /// <summary>Used on a party Pokémon :   Restores 20 [HP]{mechanic:hp}.</summary>
        /// <summary>Used :   Revives all [fainted]{mechanic:faint} Pokémon in the party and restores their [HP]{mechanic:hp} to full.</summary>
        /// <summary>Used on a party Pokémon :   Increases [HP]{mechanic:hp} [effort]{mechanic:effort} by 10, but won't increase it beyond 100.  Increases [happiness]{mechanic:happiness} by 5/3/2.</summary>
        /// <summary>Used on a party Pokémon :   Increases [Attack]{mechanic:attack} [effort]{mechanic:effort} by 10, but won't increase it beyond 100.  Increases [happiness]{mechanic:happiness} by 5/3/2.</summary>
        /// <summary>Used on a party Pokémon :   Increases [Defense]{mechanic:defense} [effort]{mechanic:effort} by 10, but won't increase it beyond 100.  Increases [happiness]{mechanic:happiness} by 5/3/2.</summary>
        /// <summary>Used on a party Pokémon :   Increases [Speed]{mechanic:speed} [effort]{mechanic:effort} by 10, but won't increase it beyond 100.  Increases [happiness]{mechanic:happiness} by 5/3/2.</summary>
        /// <summary>Used on a party Pokémon :   Increases [Special Attack]{mechanic:special-attack} [effort]{mechanic:effort} by 10, but won't increase it beyond 100.  Increases [happiness]{mechanic:happiness} by 5/3/2.</summary>
        /// <summary>Used on a party Pokémon :   Increases level by 1.  Increases [happiness]{mechanic:happiness} by 5/3/2.</summary>
        /// <summary>Used on a party Pokémon :   Increases a selected move's max [PP]{mechanic:pp} by 20% its original max PP, to a maximum of 1.6×.  Increases [happiness]{mechanic:happiness} by 5/3/2.</summary>
        /// <summary>Used on a party Pokémon :   Increases [Special Defense]{mechanic:special-defense} [effort]{mechanic:effort} by 10, but won't increase it beyond 100.  Increases [happiness]{mechanic:happiness} by 5/3/2.</summary>
        /// <summary>Used on a party Pokémon :   Increases a selected move's max [PP]{mechanic:pp} to 1.6× its original max PP.  Increases [happiness]{mechanic:happiness} by 5/3/2.</summary>
        /// <summary>Used on a party Pokémon :   Cures any [status ailment]{mechanic:status-ailment} and [confusion]{mechanic:confusion}.</summary>
        /// <summary>Used on a party Pokémon in battle :   Protects the target's stats from being [lowered]{mechanic:lower} for the next five turns.  Increases happiness by 1/1/0.</summary>
        /// <summary>Used on a party Pokémon in battle :   Increases the target's [critical hit chance]{mechanic:critical-hit-chance} by one stage until it leaves the field.  Increases happiness by 1/1/0.</summary>
        /// <summary>Used on a party Pokémon in battle :   [Raises]{mechanic:raise} the target's [Attack]{mechanic:attack} by one stage.  Increases happiness by 1/1/0.</summary>
        /// <summary>Used on a party Pokémon in battle :   [Raises]{mechanic:raise} the target's [Defense]{mechanic:defense} by one stage.  Increases happiness by 1/1/0.</summary>
        /// <summary>Used on a party Pokémon in battle :   [Raises]{mechanic:raise} the target's [Speed]{mechanic:speed} by one stage.  Increases happiness by 1/1/0.</summary>
        /// <summary>Used on a party Pokémon in battle :   [Raises]{mechanic:raise} the target's [accuracy]{mechanic:accuracy} by one stage.  Increases happiness by 1/1/0.</summary>
        /// <summary>Used on a party Pokémon in battle :   [Raises]{mechanic:raise} the target's [Special Attack]{mechanic:special-attack} by one stage.  Increases happiness by 1/1/0.</summary>
        /// <summary>Used on a party Pokémon in battle :   [Raises]{mechanic:raise} the target's [Special Defense]{mechanic:special-defense} by one stage.  Increases happiness by 1/1/0.</summary>
        /// <summary>Used in battle :   Ends a wild battle.  Cannot be used in trainer battles.</summary>
        /// <summary>Used in battle :   Ends a wild battle.  Cannot be used in trainer battles.</summary>
        /// <summary>Used on a party Pokémon :   Cures [sleep]{mechanic:sleep}.</summary>
        /// <summary>Used on a party Pokémon in battle :   Cures [confusion]{mechanic:confusion}.</summary>
        /// <summary>Used on a party Pokémon in battle :   Cures [attraction]{mechanic:attraction}.</summary>
        /// <summary>Used outside of battle :   Decreases the wild Pokémon encounter rate by 50%.</summary>
        /// <summary>Used outside of battle :   Doubles the wild Pokémon encounter rate.</summary>
        /// <summary>No effect.</summary>
        /// <summary>No effect.</summary>
        /// <summary>No effect.  In Diamond and Pearl, trade ten for a []{move:sunny-day} [TM]{item:tm11} in the house midway along the southern section of []{location:sinnoh-route-212}.  In Platinum, trade to [move tutors]{mechanic:move-tutor} on []{location:sinnoh-route-212}, in []{location:snowpoint-city}, and in the []{location:survival-area}.  Eight shards total are required per tutelage, but the particular combination of colors varies by move.  In HeartGold and SoulSilver, trade one for a []{item:cheri-berry}, a []{item:leppa-berry}, and a []{item:pecha-berry} with the Juggler near the Pokémon Center in []{location:violet-city}.  In HeartGold and SoulSilver, trade one for a []{item:persim-berry}, a []{item:pomeg-berry}, and a []{item:razz-berry} with the Juggler near the []{location:pal-park} entrance in []{location:fuchsia-city}.</summary>
        /// <summary>No effect.  In Diamond and Pearl, trade ten for a []{move:rain-dance} [TM]{item:tm18} in the house midway along the southern section of []{location:sinnoh-route-212}.  In Platinum, trade to [move tutors]{mechanic:move-tutor} on []{location:sinnoh-route-212}, in []{location:snowpoint-city}, and in the []{location:survival-area}.  Eight shards total are required per tutelage, but the particular combination of colors varies by move.  In HeartGold and SoulSilver, trade one for a []{item:chesto-berry}, an []{item:oran-berry}, and a []{item:wiki-berry} with the Juggler near the Pokémon Center in []{location:violet-city}.  In HeartGold and SoulSilver, trade one for a []{item:bluk-berry}, a []{item:cornn-berry}, and a []{item:kelpsy-berry} with the Juggler near the []{location:pal-park} entrance in []{location:fuchsia-city}.</summary>
        /// <summary>No effect.  In Diamond and Pearl, trade ten for a []{move:sandstorm} [TM]{item:tm37} in the house midway along the southern section of []{location:sinnoh-route-212}.  In Platinum, trade to [move tutors]{mechanic:move-tutor} on []{location:sinnoh-route-212}, in []{location:snowpoint-city}, and in the []{location:survival-area}.  Eight shards total are required per tutelage, but the particular combination of colors varies by move.  In HeartGold and SoulSilver, trade one for an []{item:aspear-berry}, a []{item:iapapa-berry}, and a []{item:sitrus-berry} with the Juggler near the Pokémon Center in []{location:violet-city}.  In HeartGold and SoulSilver, trade one for a []{item:grepa-berry}, a []{item:nomel-berry}, and a []{item:pinap-berry} with the Juggler near the []{location:pal-park} entrance in []{location:fuchsia-city}.</summary>
        /// <summary>No effect.  In Diamond and Pearl, trade ten for a []{move:hail} [TM]{item:tm07} in the house midway along the southern section of []{location:sinnoh-route-212}.  In Platinum, trade to [move tutors]{mechanic:move-tutor} on []{location:sinnoh-route-212}, in []{location:snowpoint-city}, and in the []{location:survival-area}.  Eight shards total are required per tutelage, but the particular combination of colors varies by move.  In HeartGold and SoulSilver, trade one for an []{item:aguav-berry}, a []{item:lum-berry}, and a []{item:rawst-berry} with the Juggler near the Pokémon Center in []{location:violet-city}.  In HeartGold and SoulSilver, trade one for a []{item:durin-berry}, a []{item:hondew-berry}, and a []{item:wepear-berry} with the Juggler near the []{location:pal-park} entrance in []{location:fuchsia-city}.</summary>
        /// <summary>Used outside of battle :   Trainer will skip encounters with wild Pokémon of a lower level than the lead party Pokémon.  This effect wears off after the trainer takes 200 steps.</summary>
        /// <summary>Used outside of battle :   Trainer will skip encounters with wild Pokémon of a lower level than the lead party Pokémon.  This effect wears off after the trainer takes 250 steps.</summary>
        /// <summary>Used outside of battle :   Transports the trainer to the last-entered dungeon entrance.  Cannot be used outside, in buildings, or in []{location:distortion-world}, []{location:sinnoh-hall-of-origin-1}, []{location:spear-pillar}, or []{location:turnback-cave}.</summary>
        /// <summary>Used outside of battle :   Trainer will skip encounters with wild Pokémon of a lower level than the lead party Pokémon.  This effect wears off after the trainer takes 100 steps.</summary>
        /// <summary>Used on a party Pokémon :   Evolves a []{pokemon:cottonee} into []{pokemon:whimsicott}, a []{pokemon:gloom} into []{pokemon:bellossom}, a []{pokemon:petilil} into []{pokemon:lilligant}, or a []{pokemon:sunkern} into []{pokemon:sunflora}.</summary>
        /// <summary>Used on a party Pokémon :   Evolves a []{pokemon:clefairy} into []{pokemon:clefable}, a []{pokemon:jigglypuff} into []{pokemon:wigglytuff}, a []{pokemon:munna} into []{pokemon:musharna}, a []{pokemon:nidorina} into []{pokemon:nidoqueen}, a []{pokemon:nidorino} into []{pokemon:nidoking}, or a []{pokemon:skitty} into []{pokemon:delcatty}.</summary>
        /// <summary>Used on a party Pokémon :   Evolves an []{pokemon:eevee} into []{pokemon:flareon}, a []{pokemon:growlithe} into []{pokemon:arcanine}, a []{pokemon:pansear} into []{pokemon:simisear}, or a []{pokemon:vulpix} into []{pokemon:ninetales}.</summary>
        /// <summary>Used on a party Pokémon :   Evolves an []{pokemon:eelektrik} into []{pokemon:eelektross}, an []{pokemon:eevee} into []{pokemon:jolteon}, or a []{pokemon:pikachu} into []{pokemon:raichu}.</summary>
        /// <summary>Used on a party Pokémon :   Evolves an []{pokemon:eevee} into []{pokemon:vaporeon}, a []{pokemon:lombre} into []{pokemon:ludicolo}, a []{pokemon:panpour} into []{pokemon:simipour}, a []{pokemon:poliwhirl} into []{pokemon:poliwrath}, a []{pokemon:shellder} into []{pokemon:cloyster}, or a []{pokemon:staryu} into []{pokemon:starmie}.</summary>
        /// <summary>Used on a party Pokémon :   Evolves an []{pokemon:exeggcute} into []{pokemon:exeggutor}, a []{pokemon:gloom} into []{pokemon:vileplume}, a []{pokemon:nuzleaf} into []{pokemon:shiftry}, a []{pokemon:pansage} into []{pokemon:simisage}, or a []{pokemon:weepinbell} into []{pokemon:victreebel}.</summary>
        /// <summary>Vendor trash.</summary>
        /// <summary>Vendor trash.</summary>
        /// <summary>Vendor trash.</summary>
        /// <summary>Vendor trash.</summary>
        /// <summary>Vendor trash.</summary>
        /// <summary>Vendor trash.</summary>
        /// <summary>Vendor trash.</summary>
        /// <summary>Trade one to the Move Relearner near the shore in []{location:pastoria-city} or with the Move Deleter in []{location:blackthorn-city} to teach one party Pokémon a prior level-up move.</summary>
        /// <summary>Used outside of battle :   Immediately triggers a wild Pokémon battle, as long as the trainer is somewhere with wild Pokémon—i.e., in tall grass, in a cave, or surfing.  Can be smeared on sweet-smelling trees to attract tree-dwelling Pokémon after six hours.</summary>
        /// <summary>Used on a patch of soil :   Plant's growth stages will each last 25% less time.  Dries soil out more quickly.</summary>
        /// <summary>Used on a patch of soil :   Plant's growth stages will each last 25% more time.  Dries soil out more slowly.</summary>
        /// <summary>Used on a patch of soil :   Fully-grown plant will last 25% longer before dying and possibly regrowing.</summary>
        /// <summary>Used on a path of soil :   Plant will regrow after dying 25% more times.</summary>
        /// <summary>Give to a scientist in the []{location:mining-museum} in []{location:oreburgh-city} or the Museum of Science in []{location:pewter-city} to receive a []{pokemon:lileep}.</summary>
        /// <summary>Give to a scientist in the []{location:mining-museum} in []{location:oreburgh-city} or the Museum of Science in []{location:pewter-city} to receive a []{pokemon:anorith}.</summary>
        /// <summary>Give to a scientist in the []{location:mining-museum} in []{location:oreburgh-city} or the Museum of Science in []{location:pewter-city} to receive a []{pokemon:omanyte}.</summary>
        /// <summary>Give to a scientist in the []{location:mining-museum} in []{location:oreburgh-city} or the Museum of Science in []{location:pewter-city} to receive a []{pokemon:kabuto}.</summary>
        /// <summary>Give to a scientist in the []{location:mining-museum} in []{location:oreburgh-city} or the Museum of Science in []{location:pewter-city} to receive a []{pokemon:aerodactyl}.</summary>
        /// <summary>Give to a scientist in the []{location:mining-museum} in []{location:oreburgh-city} or the Museum of Science in []{location:pewter-city} to receive a []{pokemon:shieldon}.</summary>
        /// <summary>Give to a scientist in the []{location:mining-museum} in []{location:oreburgh-city} or the Museum of Science in []{location:pewter-city} to receive a []{pokemon:cranidos}.</summary>
        /// <summary>Vendor trash.</summary>
        /// <summary>Used on a party Pokémon :   Evolves a []{pokemon:minccino} into []{pokemon:cinccino}, a []{pokemon:roselia} into []{pokemon:roserade}, or a []{pokemon:togetic} into []{pokemon:togekiss}.</summary>
        /// <summary>Used on a party Pokémon :   Evolves a []{pokemon:lampent} into []{pokemon:chandelure}, a []{pokemon:misdreavus} into []{pokemon:mismagius}, or a []{pokemon:murkrow} into []{pokemon:honchkrow}.</summary>
        /// <summary>Used on a party Pokémon :   Evolves a male []{pokemon:kirlia} into []{pokemon:gallade} or a female []{pokemon:snorunt} into []{pokemon:froslass}.</summary>
        /// <summary>Held by []{pokemon:happiny} :   Holder evolves into []{pokemon:chansey} when it levels up during the daytime.</summary>
        /// <summary>Place in the tower on []{location:sinnoh-route-209}.  Check the stone to encounter a []{pokemon:spiritomb}, as long as the trainer's Underground status card counts at least 32 greetings.</summary>
        /// <summary>Held by []{pokemon:dialga} :   Holder's []{type:dragon}- and []{type:steel}-type moves have 1.2× their usual power.</summary>
        /// <summary>Held by []{pokemon:palkia} :   Holder's []{type:dragon}- and []{type:water}-type moves have 1.2× their usual power.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Held in battle :   When the holder is [paralyzed]{mechanic:paralysis}, it consumes this item to cure the paralysis.  Used on a party Pokémon :   Cures [paralysis]{mechanic:paralysis}.</summary>
        /// <summary>Held in battle :   When the holder is [asleep]{mechanic:sleep}, it consumes this item to wake up.  Used on a party Pokémon :   Cures [sleep]{mechanic:sleep}.</summary>
        /// <summary>Held in battle :   When the holder is [poisoned]{mechanic:poison}, it consumes this item to cure the poison.  Used on a party Pokémon :   Cures [poison]{mechanic:poison}.</summary>
        /// <summary>Held in battle :   When the holder is [burned]{mechanic:burn}, it consumes this item to cure the burn.  Used on a party Pokémon :   Cures a [burn]{mechanic:burn}.</summary>
        /// <summary>Held in battle :   When the holder is [frozen]{mechanic:freezing}, it consumes this item to thaw itself.  Used on a party Pokémon :   Cures [freezing]{mechanic:freezing}.</summary>
        /// <summary>Held in battle :   When the holder is out of [PP]{mechanic:pp} for one of its moves, it consumes this item to restore 10 of that move's PP.  Used on a party Pokémon :   Restores 10 [PP]{mechanic:pp} for a selected move.</summary>
        /// <summary>Held in battle :   When the holder has 1/2 its max [HP]{mechanic:hp} remaining or less, it consumes this item to restore 10 HP.  Used on a party Pokémon :   Restores 10 [HP]{mechanic:hp}.</summary>
        /// <summary>Held in battle :   When the holder is [confused]{mechanic:confusion}, it consumes this item to cure the confusion.  Used on a party Pokémon :   Cures [confusion]{mechanic:confusion}.</summary>
        /// <summary>Held in battle :   When the holder is afflicted with a [major status ailment]{mechanic:major-status-ailment}, it consumes this item to cure the ailment.  Used on a party Pokémon :   Cures any [major status ailment]{mechanic:major-status-ailment}.</summary>
        /// <summary>Held in battle :   When the holder has 1/2 its max [HP]{mechanic:hp} remaining or less, it consumes this item to restore 1/4 its max HP.  Used on a party Pokémon :   Restores 1/4 the Pokémon's max [HP]{mechanic:hp}.</summary>
        /// <summary>Held in battle :   When the holder has 1/2 its max [HP]{mechanic:hp} remaining or less, it consumes this item to restore 1/8 its max HP.  If the holder dislikes spicy flavors (i.e., has a nature that lowers [Attack]{mechanic:attack}), it will also become [confused]{mechanic:confusion}.</summary>
        /// <summary>Held in battle :   When the holder has 1/2 its max [HP]{mechanic:hp} remaining or less, it consumes this item to restore 1/8 its max HP.  If the holder dislikes dry flavors (i.e., has a nature that lowers [Special Attack]{mechanic:special-attack}), it will also become [confused]{mechanic:confusion}.</summary>
        /// <summary>Held in battle :   When the holder has 1/2 its max [HP]{mechanic:hp} remaining or less, it consumes this item to restore 1/8 its max HP.  If the holder dislikes sweet flavors (i.e., has a nature that lowers [Speed]{mechanic:speed}), it will also become [confused]{mechanic:confusion}.</summary>
        /// <summary>Held in battle :   When the holder has 1/2 its max [HP]{mechanic:hp} remaining or less, it consumes this item to restore 1/8 its max HP.  If the holder dislikes bitter flavors (i.e., has a nature that lowers [Special Defense]{mechanic:special-defense}), it will also become [confused]{mechanic:confusion}.</summary>
        /// <summary>Held in battle :   When the holder has 1/2 its max [HP]{mechanic:hp} remaining or less, it consumes this item to restore 1/8 its max HP.  If the holder dislikes sour flavors (i.e., has a nature that lowers [Defense]{mechanic:defense}), it will also become [confused]{mechanic:confusion}.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>Used on a party Pokémon :   Increases [happiness]{mechanic:happiness} by 10/5/2.  Lowers [HP]{mechanic:hp} [effort]{mechanic:effort} by 10.</summary>
        /// <summary>Used on a party Pokémon :   Increases [happiness]{mechanic:happiness} by 10/5/2.  Lowers [Attack]{mechanic:attack} [effort]{mechanic:effort} by 10.</summary>
        /// <summary>Used on a party Pokémon :   Increases [happiness]{mechanic:happiness} by 10/5/2.  Lowers [Defense]{mechanic:defense} [effort]{mechanic:effort} by 10.</summary>
        /// <summary>Used on a party Pokémon :   Increases [happiness]{mechanic:happiness} by 10/5/2.  Lowers [Special Attack]{mechanic:special-attack} [effort]{mechanic:effort} by 10.</summary>
        /// <summary>Used on a party Pokémon :   Increases [happiness]{mechanic:happiness} by 10/5/2.  Lowers [Special Defense]{mechanic:special-defense} [effort]{mechanic:effort} by 10.</summary>
        /// <summary>Used on a party Pokémon :   Increases [happiness]{mechanic:happiness} by 10/5/2.  Lowers [Speed]{mechanic:speed} [effort]{mechanic:effort} by 10.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>No effect; only useful for planting and cooking.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:fire}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:water}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:electric}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:grass}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:ice}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:fighting}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:poison}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:ground}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:flying}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:psychic}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:bug}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:rock}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:ghost}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:dragon}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:dark}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take [super-effective]{mechanic:super-effective} []{type:steel}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder would take []{type:normal}-type damage, it consumes this item to halve the amount of damage taken.</summary>
        /// <summary>Held in battle :   When the holder has 1/4 its max [HP]{mechanic:hp} remaining or less, it consumes this item to [raise]{mechanic:raise} its [Attack]{mechanic:attack} by one stage.</summary>
        /// <summary>Held in battle :   When the holder has 1/4 its max [HP]{mechanic:hp} remaining or less, it consumes this item to [raise]{mechanic:raise} its [Defense]{mechanic:defense} by one stage.</summary>
        /// <summary>Held in battle :   When the holder has 1/4 its max [HP]{mechanic:hp} remaining or less, it consumes this item to [raise]{mechanic:raise} its [Speed]{mechanic:speed} by one stage.</summary>
        /// <summary>Held in battle :   When the holder has 1/4 its max [HP]{mechanic:hp} remaining or less, it consumes this item to [raise]{mechanic:raise} its [Special Attack]{mechanic:special-attack} by one stage.</summary>
        /// <summary>Held in battle :   When the holder has 1/4 its max [HP]{mechanic:hp} remaining or less, it consumes this item to [raise]{mechanic:raise} its [Special Defense]{mechanic:special-defense} by one stage.</summary>
        /// <summary>Held in battle :   When the holder has 1/4 its max [HP]{mechanic:hp} remaining or less, it consumes this item to [raise]{mechanic:raise} its [critical hit chance]{mechanic:critical-hit-chance} by one stage.</summary>
        /// <summary>Held in battle :   When the holder has 1/4 its max [HP]{mechanic:hp} remaining or less, it consumes this item to [raise]{mechanic:raise} a random stat by two stages.</summary>
        /// <summary>Held in battle :   When the holder takes [super-effective]{mechanic:super-effective} damage, it consumes this item to restore 1/4 its max [HP]{mechanic:hp}.</summary>
        /// <summary>Held in battle :   When the holder has 1/4 its max [HP]{mechanic:hp} remaining or less, it consumes this item, and its next used move has 1.2× its normal accuracy.</summary>
        /// <summary>Held in battle :   When the holder has 1/4 its max [HP]{mechanic:hp} remaining or less, it consumes this item.  On the following turn, the holder will act first among moves with the same [priority]{mechanic:priority}, regardless of [Speed]{mechanic:speed}.</summary>
        /// <summary>Held in battle :   When the holder takes [physical]{mechanic:physical} damage, it consumes this item to damage the attacking Pokémon for 1/8 its max [HP]{mechanic:hp}.</summary>
        /// <summary>Held in battle :   When the holder takes [special]{mechanic:special} damage, it consumes this item to damage the attacking Pokémon for 1/8 its max [HP]{mechanic:hp}.</summary>
        /// <summary>Held in battle :   Moves targeting the holder have 0.9× [chance to hit]{mechanic:chance-to-hit}.</summary>
        /// <summary>Held in battle :   At the end of each turn, if any of the holder's stats have a negative [stat modifier]{mechanic:stat-modifier}, the holder consumes this item to remove the modifiers from those stats.</summary>
        /// <summary>Held :   When the holder would gain [effort]{mechanic:effort} due to battle, it gains double that effort instead.  Held in battle :   Holder has half its [Speed]{mechanic:speed}.</summary>
        /// <summary>Held :   [Experience]{mechanic:experience} is split across two groups: Pokémon who participated in battle, and Pokémon holding this item.  Each Pokémon earns experience as though it had battled alone, divided by the number of Pokémon in its group, then divided by the number of groups. Pokémon holding this item who also participated in battle effectively earn experience twice.      [Fainted]{mechanic:fainted} Pokémon never earn experience, and empty groups are ignored; thus, if a single Pokémon is holding this item and the only Pokémon who battled faints from []{move:explosion}, the holder will gain full experience.</summary>
        /// <summary>Held in battle :   Whenever the holder attempts to use a move, it has a 3/16 chance to act first among moves with the same [priority]{mechanic:priority}.  If multiple Pokémon have this effect at the same time, [Speed]{mechanic:speed} is the tie-breaker as normal, but the effect of []{move:trick-room} is ignored.</summary>
        /// <summary>Held :   When the holder would earn [happiness]{mechanic:happiness} for any reason, it earns twice that amount instead.</summary>
        /// <summary>Held in battle :   When the holder is [attracted]{move:attract}, it consumes this item to cure the attraction.</summary>
        /// <summary>Held in battle :   Holder has 1.5× its [Attack]{mechanic:attack}.  When the holder attempts to use a move, all its other moves are disabled until it leaves battle or loses this item.      The restriction ends even if this item is swapped for another Choice item via []{move:trick} or []{move:switcheroo}.</summary>
        /// <summary>Held in battle :   Holder's damaging moves have a 10% chance to make their target [flinch]{mechanic:flinch}.  This chance applies independently to each hit of a multi-hit move.      This item's chance is rolled independently of any other move effects; e.g., a move with a 30% chance to flinch normally will have a 37% total chance to flinch when used with this item, because 3% of the time, both effects activate.  Held by []{pokemon:poliwhirl} or []{pokemon:slowbro} :   Holder evolves into []{pokemon:politoed} or []{pokemon:slowking}, respectively, when traded.</summary>
        /// <summary>Held in battle :   Holder's []{type:bug}-type moves have 1.2× their power. </summary>
        /// <summary>Held :   If the holder participated in a trainer battle, the trainer earns twice the usual prize money.  This effect applies even if the holder [fainted]{mechanic:fainted}.      This effect does not stack with any other similar effect.</summary>
        /// <summary>Held by lead Pokémon: Prevents wild battles with Pokémon that are lower level than the holder.</summary>
        /// <summary>Held by Latias or Latios: Increases the holder's Special Attack and Special Defense by 50%.</summary>
        /// <summary>Held by Clamperl: Doubles the holder's Special Attack.  Evolves the holder into Huntail when traded.</summary>
        /// <summary>Held by Clamperl: Doubles the holder's Special Defense.  Evolves the holder into Gorebyss when traded.</summary>
        /// <summary>Held: In wild battles, attempts to run away on the holder's turn will always succeed.</summary>
        /// <summary>Held: Prevents the holder from evolving naturally.  Evolution initiated by the trainer (Stones, etc) will still work.</summary>
        /// <summary>Held: If the holder is attacked for regular damage that would faint it, this item has a 10% chance to prevent the holder's HP from lowering below 1.</summary>
        /// <summary>Held: Increases any Exp the holder gains by 50%.</summary>
        /// <summary>Held: Raises the holder's critical hit counter by 1.</summary>
        /// <summary>Held: Increases the power of the holder's Steel moves by 20%. Held by Onix or Scyther: Evolves the holder into Steelix or Scizor when traded, respectively.</summary>
        /// <summary>Held: Heals the holder by 1/16 its max HP at the end of each turn.</summary>
        /// <summary>Held by Seadra: Evolves the holder into Kingdra when traded.</summary>
        /// <summary>Held by Pikachu: Doubles the holder's initial Attack and Special Attack.</summary>
        /// <summary>Held: Increases the power of the holder's Ground moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Rock moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Grass moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Dark moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Fighting moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Electric moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Water moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Flying moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Poison moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Ice moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Ghost moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Psychic moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Fire moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Dragon moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Normal moves by 20%.</summary>
        /// <summary>Held by Porygon: Evolves the holder into Porygon2 when traded.</summary>
        /// <summary>Held: Heals the holder by 1/8 of any damage it inflicts.</summary>
        /// <summary>Held: Increases the power of the holder's Water moves by 20%.</summary>
        /// <summary>Held: Increases the holder's Evasion by 5%.</summary>
        /// <summary>Held by Chansey: Raises the holder's critical hit counter by 2.</summary>
        /// <summary>Held by Ditto: Increases the holder's initial Defense and Special Defense by 50%.</summary>
        /// <summary>Held by Cubone or Marowak: Doubles the holder's Attack.</summary>
        /// <summary>Held by Farfetch'd: Raises the holder's critical hit counter by 2.</summary>
        /// <summary>Held: Increases the holder's Coolness during a Super Contest's Visual Competition.</summary>
        /// <summary>Held: Increases the holder's Beauty during a Super Contest's Visual Competition.</summary>
        /// <summary>Held: Increases the holder's Cuteness during a Super Contest's Visual Competition.</summary>
        /// <summary>Held: Increases the holder's Smartness during a Super Contest's Visual Competition.</summary>
        /// <summary>Held: Increases the holder's Toughness during a Super Contest's Visual Competition.</summary>
        /// <summary>Held: Increases the accuracy of any move the holder uses by 10% (multiplied; i.e. 70% accuracy is increased to 77%).</summary>
        /// <summary>Held: Increases the power of the holder's physical moves by 10%.</summary>
        /// <summary>Held: Increases the power of the holder's special moves by 10%.</summary>
        /// <summary>Held: When the holder hits with a super-effective move, its power is raised by 20%.</summary>
        /// <summary>Held: The holder's Reflect and Light Screen will create effects lasting for eight turns rather than five.  As this item affects the move rather than the barrier itself, the effect is not lost if the holder leaves battle or drops this item.</summary>
        /// <summary>Held: Damage from the holder's moves is increased by 30%.  On each turn the holder uses a damage-inflicting move, it takes 10% its max HP in damage.</summary>
        /// <summary>Held: Whenever the holder uses a move that requires a turn to charge first (Bounce, Dig, Dive, Fly, Razor Wind, Skull Bash, Sky Attack, or Solarbeam), this item is consumed and the charge is skipped.  Skull Bash still provides a Defense boost.</summary>
        /// <summary>Held: Badly poisons the holder at the end of each turn.</summary>
        /// <summary>Held: Burns the holder at the end of each turn.</summary>
        /// <summary>Held by Ditto: Doubles the holder's initial Speed.</summary>
        /// <summary>Held: If the holder has full HP and is attacked for regular damage that would faint it, this item is consumed and prevents the holder's HP from lowering below 1.  This effect works against multi-hit attacks, but does not work against the effects of Doom Desire or Future Sight.</summary>
        /// <summary>Held: Raises the holder's Accuracy by 20% when it goes last. Ingame description is incorrect.</summary>
        /// <summary>Held: Each time the holder uses the same move consecutively, its power is increased by another 10% of its original, to a maximum of 100%.</summary>
        /// <summary>Held: Decreases the holder's Speed by 50%.  If the holder is Flying or has Levitate, it takes regular damage from Ground attacks and is suspectible to Spikes and Toxic Spikes.</summary>
        /// <summary>Held: The holder will go last within its move's priority bracket, regardless of Speed.  If multiple Pokémon within the same priority bracket are subject to this effect, the slower Pokémon will go first.  The holder will move after Pokémon with Stall.  If the holder has Stall, Stall is ignored.  This item ignores Trick Room.</summary>
        /// <summary>Held: When the holder becomes Attracted, the Pokémon it is Attracted to becomes Attracted back.</summary>
        /// <summary>Held: If the holder is Poison-type, restores 1/16 max HP at the end of each turn.  Otherwise, damages the holder by 1/16 its max HP at the end of each turn.</summary>
        /// <summary>Held: The holder's Hail will create a hailstorm lasting for eight turns rather than five.  As this item affects the move rather than the weather itself, the effect is not lost if the holder leaves battle or drops this item.</summary>
        /// <summary>Held: The holder's Sandstorm will create a sandstorm lasting for eight turns rather than five.  As this item affects the move rather than the weather itself, the effect is not lost if the holder leaves battle or drops this item.</summary>
        /// <summary>Held: The holder's Sunny Day will create sunshine lasting for eight turns rather than five.  As this item affects the move rather than the weather itself, the effect is not lost if the holder leaves battle or drops this item.</summary>
        /// <summary>Held: The holder's Rain Dance will create rain lasting for eight turns rather than five.  As this item affects the move rather than the weather itself, the effect is not lost if the holder leaves battle or drops this item.</summary>
        /// <summary>Held: Increases the duration of the holder's multiturn (2-5 turn) moves by three turns.</summary>
        /// <summary>Held: Increases the holder's Speed by 50%, but restricts it to the first move it uses until it leaves battle or loses this item.  If this item is swapped for another Choice item via Trick or Switcheroo, the holder's restriction is still lifted, but it will again be restricted to the next move it uses. (Quirk: If the holder is switched in by U-Turn and it also knows U-Turn, U-Turn becomes its restricted move.)</summary>
        /// <summary>Held: Damaged the holder for 1/8 its max HP.  When the holder is struck by a contact move, damages the attacker for 1/8 its max HP; if the attacker is not holding an item, it will take this item.</summary>
        /// <summary>Held: Decreases the holder's Speed by 50%.  Whenever the holder gains Attack effort from battle, increases that effort by 4; this applies before the PokéRUS doubling effect.</summary>
        /// <summary>Held: Decreases the holder's Speed by 50%.  Whenever the holder gains Defense effort from battle, increases that effort by 4; this applies before the PokéRUS doubling effect.</summary>
        /// <summary>Held: Decreases the holder's Speed by 50%.  Whenever the holder gains Special Attack effort from battle, increases that effort by 4; this applies before the PokéRUS doubling effect.</summary>
        /// <summary>Held: Decreases the holder's Speed by 50%.  Whenever the holder gains Special Defense effort from battle, increases that effort by 4; this applies before the PokéRUS doubling effect.</summary>
        /// <summary>Held: Decreases the holder's Speed by 50%.  Whenever the holder gains Speed effort from battle, increases that effort by 4; this applies before the PokéRUS doubling effect.</summary>
        /// <summary>Held: Decreases the holder's Speed by 50%.  Whenever the holder gains HP effort from battle, increases that effort by 4; this applies before the PokéRUS doubling effect.</summary>
        /// <summary>Held: The holder is unaffected by any moves or abilities that would prevent it from actively leaving battle.</summary>
        /// <summary>Held: HP restored from Absorb, Aqua Ring, Drain Punch, Dream Eater, Giga Drain, Ingrain, Leech Life, Leech Seed, and Mega Drain is increased by 30%.  Damage inflicted is not affected.</summary>
        /// <summary>Held: Increases the holder's Special Attack by 50%, but restricts it to the first move it uses until it leaves battle or loses this item.  If this item is swapped for another Choice item via Trick or Switcheroo, the holder's restriction is still lifted, but it will again be restricted to the next move it uses. (Quirk: If the holder is switched in by U-Turn and it also knows U-Turn, U-Turn becomes its restricted move.)</summary>
        /// <summary>Held: Increases the power of the holder's Fire moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Fire.</summary>
        /// <summary>Held: Increases the power of the holder's Water moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Water.</summary>
        /// <summary>Held: Increases the power of the holder's Electric moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Electric.</summary>
        /// <summary>Held: Increases the power of the holder's Grass moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Grass.</summary>
        /// <summary>Held: Increases the power of the holder's Ice moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Ice.</summary>
        /// <summary>Held: Increases the power of the holder's Fighting moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Fighting.</summary>
        /// <summary>Held: Increases the power of the holder's Poison moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Poison.</summary>
        /// <summary>Held: Increases the power of the holder's Ground moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Ground.</summary>
        /// <summary>Held: Increases the power of the holder's Flying moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Flying.</summary>
        /// <summary>Held: Increases the power of the holder's Psychic moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Psychic.</summary>
        /// <summary>Held: Increases the power of the holder's Bug moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Bug.</summary>
        /// <summary>Held: Increases the power of the holder's Rock moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Rock.</summary>
        /// <summary>Held: Increases the power of the holder's Ghost moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Ghost.</summary>
        /// <summary>Held: Increases the power of the holder's Dragon moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Dragon.</summary>
        /// <summary>Held: Increases the power of the holder's Dark moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Dark.</summary>
        /// <summary>Held: Increases the power of the holder's Steel moves by 20%. Held by a Multitype Pokémon: Holder's type becomes Steel.</summary>
        /// <summary>Held: Increases the power of the holder's Psychic moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Rock moves by 20%.</summary>
        /// <summary>Held: The holder will go last within its move's priority bracket, regardless of Speed.  If multiple Pokémon within the same priority bracket are subject to this effect, the slower Pokémon will go first.  The holder will move after Pokémon with Stall.  If the holder has Stall, Stall is ignored.  This item ignores Trick Room.</summary>
        /// <summary>Held: Increases the power of the holder's Water moves by 20%.</summary>
        /// <summary>Held: Increases the power of the holder's Grass moves by 20%.</summary>
        /// <summary>Held: Doubles the money the trainer receives after an in-game trainer battle.  This effect cannot apply more than once to the same battle.</summary>
        /// <summary>Held by lead Pokémon: Prevents wild battles with Pokémon that are lower level than the holder.</summary>
        /// <summary>Held by Rhydon: Evolves the holder into Rhyperior when traded.</summary>
        /// <summary>Held by Electabuzz: Evolves the holder into Electivire when traded.</summary>
        /// <summary>Held by Magmar: Evolves the holder into Magmortar when traded.</summary>
        /// <summary>Held by Porygon2: Evolves the holder into Porygon-Z when traded.</summary>
        /// <summary>Held by Dusclops: Evolves the holder into Dusknoir when traded.</summary>
        /// <summary>Held: Raises the holder's critical hit counter by 1. Held by Sneasel: Evolves the holder into Weavile when it levels up during the night.</summary>
        /// <summary>Held: When the holder attacks with most damaging moves, provides an extra 11.7% (30/256) chance for the target to flinch. Held by Gligar: Evolves the holder into Gliscor when it levels up.</summary>
        /// <summary>Teaches Focus Punch to a compatible Pokémon.</summary>
        /// <summary>Teaches Dragon Claw to a compatible Pokémon.</summary>
        /// <summary>Teaches Water Pulse to a compatible Pokémon.</summary>
        /// <summary>Teaches Calm Mind to a compatible Pokémon.</summary>
        /// <summary>Teaches Roar to a compatible Pokémon.</summary>
        /// <summary>Teaches Toxic to a compatible Pokémon.</summary>
        /// <summary>Teaches Hail to a compatible Pokémon.</summary>
        /// <summary>Teaches Bulk Up to a compatible Pokémon.</summary>
        /// <summary>Teaches Bullet Seed to a compatible Pokémon.</summary>
        /// <summary>Teaches Hidden Power to a compatible Pokémon.</summary>
        /// <summary>Teaches Sunny Day to a compatible Pokémon.</summary>
        /// <summary>Teaches Taunt to a compatible Pokémon.</summary>
        /// <summary>Teaches Ice Beam to a compatible Pokémon.</summary>
        /// <summary>Teaches Blizzard to a compatible Pokémon.</summary>
        /// <summary>Teaches Hyper Beam to a compatible Pokémon.</summary>
        /// <summary>Teaches Light Screen to a compatible Pokémon.</summary>
        /// <summary>Teaches Protect to a compatible Pokémon.</summary>
        /// <summary>Teaches Rain Dance to a compatible Pokémon.</summary>
        /// <summary>Teaches Giga Drain to a compatible Pokémon.</summary>
        /// <summary>Teaches Safeguard to a compatible Pokémon.</summary>
        /// <summary>Teaches Frustration to a compatible Pokémon.</summary>
        /// <summary>Teaches SolarBeam to a compatible Pokémon.</summary>
        /// <summary>Teaches Iron Tail to a compatible Pokémon.</summary>
        /// <summary>Teaches Thunderbolt to a compatible Pokémon.</summary>
        /// <summary>Teaches Thunder to a compatible Pokémon.</summary>
        /// <summary>Teaches Earthquake to a compatible Pokémon.</summary>
        /// <summary>Teaches Return to a compatible Pokémon.</summary>
        /// <summary>Teaches Dig to a compatible Pokémon.</summary>
        /// <summary>Teaches Psychic to a compatible Pokémon.</summary>
        /// <summary>Teaches Shadow Ball to a compatible Pokémon.</summary>
        /// <summary>Teaches Brick Break to a compatible Pokémon.</summary>
        /// <summary>Teaches Double Team to a compatible Pokémon.</summary>
        /// <summary>Teaches Reflect to a compatible Pokémon.</summary>
        /// <summary>Teaches Shock Wave to a compatible Pokémon.</summary>
        /// <summary>Teaches Flamethrower to a compatible Pokémon.</summary>
        /// <summary>Teaches Sludge Bomb to a compatible Pokémon.</summary>
        /// <summary>Teaches Sandstorm to a compatible Pokémon.</summary>
        /// <summary>Teaches Fire Blast to a compatible Pokémon.</summary>
        /// <summary>Teaches Rock Tomb to a compatible Pokémon.</summary>
        /// <summary>Teaches Aerial Ace to a compatible Pokémon.</summary>
        /// <summary>Teaches Torment to a compatible Pokémon.</summary>
        /// <summary>Teaches Facade to a compatible Pokémon.</summary>
        /// <summary>Teaches Secret Power to a compatible Pokémon.</summary>
        /// <summary>Teaches Rest to a compatible Pokémon.</summary>
        /// <summary>Teaches Attract to a compatible Pokémon.</summary>
        /// <summary>Teaches Thief to a compatible Pokémon.</summary>
        /// <summary>Teaches Steel Wing to a compatible Pokémon.</summary>
        /// <summary>Teaches Skill Swap to a compatible Pokémon.</summary>
        /// <summary>Teaches Snatch to a compatible Pokémon.</summary>
        /// <summary>Teaches Overheat to a compatible Pokémon.</summary>
        /// <summary>Teaches Roost to a compatible Pokémon.</summary>
        /// <summary>Teaches Focus Blast to a compatible Pokémon.</summary>
        /// <summary>Teaches Energy Ball to a compatible Pokémon.</summary>
        /// <summary>Teaches False Swipe to a compatible Pokémon.</summary>
        /// <summary>Teaches Brine to a compatible Pokémon.</summary>
        /// <summary>Teaches Fling to a compatible Pokémon.</summary>
        /// <summary>Teaches Charge Beam to a compatible Pokémon.</summary>
        /// <summary>Teaches Endure to a compatible Pokémon.</summary>
        /// <summary>Teaches Dragon Pulse to a compatible Pokémon.</summary>
        /// <summary>Teaches Drain Punch to a compatible Pokémon.</summary>
        /// <summary>Teaches Will-O-Wisp to a compatible Pokémon.</summary>
        /// <summary>Teaches Silver Wind to a compatible Pokémon.</summary>
        /// <summary>Teaches Embargo to a compatible Pokémon.</summary>
        /// <summary>Teaches Explosion to a compatible Pokémon.</summary>
        /// <summary>Teaches Shadow Claw to a compatible Pokémon.</summary>
        /// <summary>Teaches Payback to a compatible Pokémon.</summary>
        /// <summary>Teaches Recycle to a compatible Pokémon.</summary>
        /// <summary>Teaches Giga Impact to a compatible Pokémon.</summary>
        /// <summary>Teaches Rock Polish to a compatible Pokémon.</summary>
        /// <summary>Teaches Flash to a compatible Pokémon.</summary>
        /// <summary>Teaches Stone Edge to a compatible Pokémon.</summary>
        /// <summary>Teaches Avalanche to a compatible Pokémon.</summary>
        /// <summary>Teaches Thunder Wave to a compatible Pokémon.</summary>
        /// <summary>Teaches Gyro Ball to a compatible Pokémon.</summary>
        /// <summary>Teaches Swords Dance to a compatible Pokémon.</summary>
        /// <summary>Teaches Stealth Rock to a compatible Pokémon.</summary>
        /// <summary>Teaches Psych Up to a compatible Pokémon.</summary>
        /// <summary>Teaches Captivate to a compatible Pokémon.</summary>
        /// <summary>Teaches Dark Pulse to a compatible Pokémon.</summary>
        /// <summary>Teaches Rock Slide to a compatible Pokémon.</summary>
        /// <summary>Teaches X-Scissor to a compatible Pokémon.</summary>
        /// <summary>Teaches Sleep Talk to a compatible Pokémon.</summary>
        /// <summary>Teaches Natural Gift to a compatible Pokémon.</summary>
        /// <summary>Teaches Poison Jab to a compatible Pokémon.</summary>
        /// <summary>Teaches Dream Eater to a compatible Pokémon.</summary>
        /// <summary>Teaches Grass Knot to a compatible Pokémon.</summary>
        /// <summary>Teaches Swagger to a compatible Pokémon.</summary>
        /// <summary>Teaches Pluck to a compatible Pokémon.</summary>
        /// <summary>Teaches U-Turn to a compatible Pokémon.</summary>
        /// <summary>Teaches Substitute to a compatible Pokémon.</summary>
        /// <summary>Teaches Flash Cannon to a compatible Pokémon.</summary>
        /// <summary>Teaches Trick Room to a compatible Pokémon.</summary>
        /// <summary>Teaches Cut to a compatible Pokémon.</summary>
        /// <summary>Teaches Fly to a compatible Pokémon.</summary>
        /// <summary>Teaches Surf to a compatible Pokémon.</summary>
        /// <summary>Teaches Strength to a compatible Pokémon.</summary>
        /// <summary>Teaches Defog to a compatible Pokémon.</summary>
        /// <summary>Teaches Rock Smash to a compatible Pokémon.</summary>
        /// <summary>Teaches Waterfall to a compatible Pokémon.</summary>
        /// <summary>Teaches Rock Climb to a compatible Pokémon.</summary>
        /// <summary>Sends the trainer to the Underground.  Only usable outside.</summary>
        /// <summary>Unused.</summary>
        /// <summary>Unused.</summary>
        /// <summary>Designates several nearby patches of grass as containing Pokémon, some of which may be special radar-only Pokémon.  Successive uses in a certain way create chains of encounters with the same species; longer chains increase the chance that a shiny Pokémon of that species will appear.</summary>
        /// <summary>Tracks Battle Points.</summary>
        /// <summary>Records some of the trainer's activities for the day.</summary>
        /// <summary>Contains Seals used for decorating Pokéballs.</summary>
        /// <summary>Contains Pokémon Accessories.</summary>
        /// <summary>Unused.</summary>
        /// <summary>Contains friend codes for up to 32 other players, as well as their sprite, gender, and basic statistics for those that have been seen on WFC.</summary>
        /// <summary>Opens the front door of the Valley Windworks.  Reusable.</summary>
        /// <summary>Given to Cynthia's grandmother to get the Surf HM.</summary>
        /// <summary>Grants access to Galactic HQ in Veilstone City.</summary>
        /// <summary>Unused.</summary>
        /// <summary>Displays a map of the region including the trainer's position, location names, visited towns, gym locations, and where the trainer has been walking recently.</summary>
        /// <summary>Reveals trainers who want a rematch, by showing !! over their heads.  Each use drains the battery; requires 100 steps to charge.</summary>
        /// <summary>Contains the Coins used by the Game Corner, to a maximum of 50,000.</summary>
        /// <summary>Used to find Pokémon on the Old Rod list for an area, which are generally Magikarp or similar.</summary>
        /// <summary>Used to find Pokémon on the Good Rod list for an area, which are generally mediocre.</summary>
        /// <summary>Used to find Pokémon on the Super Rod list for an area, which are generally the best available there.</summary>
        /// <summary>Waters Berry plants.</summary>
        /// <summary>Contains up to 100 Poffins.</summary>
        /// <summary>Increases movement speed outside or in caves.  In high gear, allows the trainer to hop over some rocks and ascend muddy slopes.</summary>
        /// <summary>Opens the locked building in the lakeside resort.</summary>
        /// <summary>Grants access to Flower Paradise and Shaymin.</summary>
        /// <summary>Cures the sailor's son of his nightmares; no reward, only a side effect of seeing Cresselia.</summary>
        /// <summary>Provides access to Newmoon Island and Darkrai.</summary>
        /// <summary>Supposedly related to t</summary>
        /// <summary>Allows passage on a ferry.  The same item is used for different ferries between different games.</summary>
        /// <summary>Allows the trainer to enter Contests.</summary>
        /// <summary>Causes Heatran to appear at Reversal Mountain.  Unused prior to Black and White 2.</summary>
        /// <summary>Given to the trainer's rival in Jubilife City.  Contains two Town Maps, one of which is given to the trainer upon delivery.</summary>
        /// <summary>One of three coupons needed to receive a Pokétch.</summary>
        /// <summary>One of three coupons needed to receive a Pokétch.</summary>
        /// <summary>One of three coupons needed to receive a Pokétch.</summary>
        /// <summary>Grants access to the Team Galactic warehouse in Veilstone City.</summary>
        /// <summary>Required to cure the Psyducks blocking Route 210 of their chronic headaches.</summary>
        /// <summary>Held by []{pokemon:giratina} :   Holder's []{type:dragon} and []{type:ghost} moves have 1.2× their base power.      Holder is in Origin Forme.  This item cannot be held by any Pokémon but Giratina.  When you enter the Union Room or connect to Wi-Fi, this item returns to your bag.</summary>
        /// <summary>Optionally records wireless, Wi-Fi, and Battle Frontier battles.  Tracks Battle Points earned in the Battle Frontier, and stores commemorative prints.</summary>
        /// <summary>Used by trainer on a []{pokemon:shaymin} :   Changes the target Shaymin from Land Forme to Sky Forme.      This item cannot be used on a [frozen]{mechanic:freezing} Shaymin or at night.  Sky Forme Shaymin will revert to Land Forme overnight, when frozen, and upon entering a link battle.  This item must be used again to change it back.</summary>
        /// <summary>Used by trainer in the Galactic Eterna Building, on the ground floor, to the left of the TV :   Unlocks the secret []{pokemon:rotom} room, in which there are five appliances which can change Rotom's form.</summary>
        /// <summary>Stores Apricorns.</summary>
        /// <summary>Contains four portable pots of soil suitable for growing berries.</summary>
        /// <summary>Required to water berries within the []{item:berry-pots}.  Required to battle the []{pokemon:sudowoodo} on []{location:johto-route-36}.  This item cannot be directly used from the bag.</summary>
        /// <summary>Used by trainer in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If used in a trainer battle, nothing happens and the ball is lost.      If the wild Pokémon was encountered by fishing, the wild Pokémon's catch rate is 3× normal.</summary>
        /// <summary>Used by trainer in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If used in a trainer battle, nothing happens and the ball is lost.      If the trainer's Pokémon's level is higher than:      * four times the wild Pokémon's, the wild Pokémon's catch rate is 8× normal.     * than twice the wild Pokémon's, the wild Pokémon's catch rate is 4× normal.     * the wild Pokémon's, the wild Pokémon's catch rate is 2× normal.</summary>
        /// <summary>Used by trainer in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If used in a trainer battle, nothing happens and the ball is lost.      If the wild Pokémon is a []{pokemon:clefairy}, []{pokemon:nidoran-m}, []{pokemon:nidoran-f}, []{pokemon:jigglypuff}, []{pokemon:skitty}, or any evolution thereof, the wild Pokémon has 4× its catch rate.</summary>
        /// <summary>Used by a trainer in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If used in a trainer battle, nothing happens and the ball is lost.      If the wild Pokémon weighs:      * 409.6 kg (903.0 lb) or more, its catch rate is 40 more than normal.     * 307.2 kg (677.3 lb) or more, its catch rate is 30 more than normal.     * 204.8 kg (451.5 lb) or more, its catch rate is 20 more than normal.     * less than 204.8 kg (451.5 lb), its catch rate is 20 less than normal.</summary>
        /// <summary>Used by a trainer in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If used in a trainer battle, nothing happens and the ball is lost.  :   If the wild Pokémon's base [speed]{mechanic:speed} is 100 or more, its catch rate is 4× normal.</summary>
        /// <summary>Used by a trainer in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If used in a trainer battle, nothing happens and the ball is lost.      If caught, the wild Pokémon's [happiness]{mechanic:happiness} starts at 200.</summary>
        /// <summary>Used by a trainer in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.  If used in a trainer battle, nothing happens and the ball is lost.      If the trainer's Pokémon and wild Pokémon are of the same species but opposite genders, the wild Pokémon's catch rate is 8× normal.</summary>
        /// <summary>Used by a trainer in battle :   [Catches]{mechanic:catch} a wild Pokémon.  This item can only be used in []{location:pal-park}.</summary>
        /// <summary>Used by a trainer in battle :   Attempts to [catch]{mechanic:catch} a wild Pokémon.      The wild Pokémon's catch rate is 1.5× normal.</summary>
        /// <summary>May be given to Kurt in []{location:azalea-town} to produce a []{item:level-ball}.</summary>
        /// <summary>May be given to Kurt in []{location:azalea-town} to produce a []{item:lure-ball}.</summary>
        /// <summary>May be given to Kurt in []{location:azalea-town} to produce a []{item:moon-ball}.</summary>
        /// <summary>May be given to Kurt in []{location:azalea-town} to produce a []{item:friend-ball}.</summary>
        /// <summary>May be given to Kurt in []{location:azalea-town} to produce a []{item:love-ball}.</summary>
        /// <summary>May be given to Kurt in []{location:azalea-town} to produce a []{item:fast-ball}.</summary>
        /// <summary>May be given to Kurt in []{location:azalea-town} to produce a []{item:heavy-ball}.</summary>
        /// <summary>Used by trainer outside of battle :   Searches for hidden items.</summary>
        /// <summary>May be traded for a []{item:tm64} in the vertical Underground Path.</summary>
        /// <summary>Causes []{pokemon:groudon} to appear in the []{location:embedded-tower}.</summary>
        /// <summary>Causes []{pokemon:kyogre} to appear in the []{location:embedded-tower}.</summary>
        /// <summary>Causes []{pokemon:rayquaza} to appear in the []{location:embedded-tower}.</summary>
        /// <summary>When taken to the []{location:pewter-city} museum, causes []{pokemon:latias} or []{pokemon:latios} to attack the trainer.  The Pokémon to appear will be whicher can't be encountered roaming in the wild.</summary>
        /// <summary>Lists which []{pokemon:unown} forms the trainer has caught.</summary>
        /// <summary>Allows the trainer to answer the daily question on Buena's radio show.  Records the points earned for correct answers.</summary>
        /// <summary>Does nothing.</summary>
        /// <summary>May be given to the Kimono Girls to summon []{pokemon:ho-oh} to the top of the []{location:bell-tower}.</summary>
        /// <summary>Used by trainer outside of battle :   Opens doors in the []{location:goldenrod-city} Radio Tower.</summary>
        /// <summary>Used by trainer outside of battle :   Opens the door to the basement tunnel under []{location:goldenrod-city}.</summary>
        /// <summary>May be traded to Mr. Pokémon for an []{item:exp-share}.</summary>
        /// <summary>May be traded to the Copycat for a []{item:pass}.</summary>
        /// <summary>Allows the trainer to ride the Magnet Train between []{location:goldenrod-city} and []{location:saffron-city}.</summary>
        /// <summary>Must be replaced in the []{location:power-plant} to power the Magnet Train.</summary>
        /// <summary>Causes []{pokemon:lugia} to appear in the []{location:whirl-islands}.</summary>
        /// <summary>Causes []{pokemon:ho-oh} to appear at the top of []{location:bell-tower}.</summary>
        /// <summary>Must be obtained to trigger the break-in at Professor Elm's lab, the first rival battle, and access to []{location:johto-route-31}.</summary>
        /// <summary>Used by trainer outside of battle :   Changes the background music to the equivalent 8-bit music.</summary>
        /// <summary>May be given to the Kimono Girls to summon []{pokemon:lugia} to the top of the []{location:bell-tower}.</summary>
        /// <summary>Records the number of times the trainer has come in first place overall in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer has come in last place overall in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer's Pokémon have dashed in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer's Pokémon have jumped in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer has come in first in the Pokéathlon Hurdle Dash.</summary>
        /// <summary>Records the number of times the trainer has come in first in the Pokéathlon Relay Run.</summary>
        /// <summary>Records the number of times the trainer has come in first in the Pokéathlon Pennant Capture.</summary>
        /// <summary>Records the number of times the trainer has come in first in the Pokéathlon Block Smash.</summary>
        /// <summary>Records the number of times the trainer has come in first in the Pokéathlon Disc Catch.</summary>
        /// <summary>Records the number of times the trainer has come in first in the Pokéathlon Snow Throw.</summary>
        /// <summary>Records the number of points the trainer has earned in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer's Pokémon have messed up in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer's Pokémon have defeated themselves in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer's Pokémon have tackled in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer's Pokémon have fallen in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer has come in first in the Pokéathlon Ring Drop.</summary>
        /// <summary>Records the number of times the trainer has come in first in the Pokéathlon Lamp Jump.</summary>
        /// <summary>Records the number of times the trainer has come in first in the Pokéathlon Circle Push.</summary>
        /// <summary>Records the number of times the trainer has come in first place overall in the Pokéathlon over wirelss.</summary>
        /// <summary>Records the number of times the trainer has come in last place overall in the Pokéathlon over wireless.</summary>
        /// <summary>Records the number of times the trainer has come in first across all Pokéathlon events.</summary>
        /// <summary>Records the number of times the trainer has come in last across all Pokéathlon events.</summary>
        /// <summary>Records the number of times the trainer has switched Pokémon in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer has come in first in the Pokéathlon Goal Roll.</summary>
        /// <summary>Records the number of times the trainer's Pokémon received prizes in the Pokéathlon.</summary>
        /// <summary>Records the number of times the trainer has instructed Pokémon in the Pokéathlon.</summary>
        /// <summary>Records the total time spent in the Pokéathlon.</summary>
        /// <summary>Does nothing.</summary>
        /// <summary>Does nothing.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Increases movement speed outside or in caves.  Faster than the []{item:acro-bike}.  Allows the trainer to ascend muddy slopes.</summary>
        /// <summary>Increases movement speed outside or in caves.  Slower than the []{item:mach-bike}.  Can perform various tricks, allowing the trainer to reach certain special areas.</summary>
        /// <summary>Waters Berry plants.</summary>
        /// <summary>Contains a machine part to be delivered to Captain Stern.</summary>
        /// <summary>Collects soot when walking through tall grass on []{location:hoenn-route-113}.</summary>
        /// <summary>Stores Pokéblocks.</summary>
        /// <summary>Contains a letter to be delivered to Steven.</summary>
        /// <summary>Provides access to []{location:southern-island} and either []{pokemon:latias} or []{pokemon:latios}, whichever is not available roaming around Hoenn.</summary>
        /// <summary>May be traded to Captain Stern for a []{item:deep-sea-tooth} or a []{item:deep-sea-scale}.</summary>
        /// <summary>Allows the trainer to enter the desert on []{location:hoenn-route-111}.</summary>
        /// <summary>RSE: May be traded to Professor Cozmo for []{item:tm27}.  FRLG: A meteorite to be delivered to Lostelle's father.</summary>
        /// <summary>Unlocks room 1 on the []{location:abandoned-ship}.</summary>
        /// <summary>Unlocks room 2 on the []{location:abandoned-ship}.</summary>
        /// <summary>Unlocks room 4 on the []{location:abandoned-ship}.</summary>
        /// <summary>Unlocks room 6 on the []{location:abandoned-ship}.</summary>
        /// <summary>Reveals invisble []{pokemon:kecleon} on the overworld.</summary>
        /// <summary>A parcel to be delivered to Professor Oak for a Pokédex.</summary>
        /// <summary>Wakes up [sleeping]{mechanic:sleep} Pokémon.  Required to wake up sleeping []{pokemon:snorlax} on the overworld.</summary>
        /// <summary>May be traded for a []{item:bicycle}.</summary>
        /// <summary>The Safari Zone warden's teeth, to be returned to him for []{item:hm04}.</summary>
        /// <summary>Operates the elevator in the Celadon Rocket Hideout.</summary>
        /// <summary>Identifies ghosts in []{location:pokemon-tower}.</summary>
        /// <summary>Records information on various famous people.</summary>
        /// <summary>Stores TMs and HMs.</summary>
        /// <summary>Stores Berries.</summary>
        /// <summary>Teaches beginning trainers basic information.</summary>
        /// <summary>Provides access to the first three Sevii Islands.</summary>
        /// <summary>Provides access to the Sevii Islands.</summary>
        /// <summary>Used to bribe the []{location:saffron-city} guards for entry to the city.</summary>
        /// <summary>Provides access to Navel Rock, []{pokemon:ho-oh}, and []{pokemon:lugia}.</summary>
        /// <summary>Provides access to Birth Island and []{pokemon:deoxys}.</summary>
        /// <summary>Holds Berry Powder from Berry Crushing.</summary>
        /// <summary>Deliver to Celio for use in the Network Machine.</summary>
        /// <summary>Deliver to Celio for use in the Network Machine.</summary>
        /// <summary>Provides access to the []{location:magma-hideout} in the []{location:jagged-pass}.</summary>
        /// <summary>Provides access to Faraway Island and []{pokemon:mew}.</summary>
        /// <summary>Held by []{pokemon:genesect} :   Holder's buster is blue, and its []{move:techno-blast} is []{type:water}-type.</summary>
        /// <summary>Held by []{pokemon:genesect} :   Holder's buster is yellow, and its []{move:techno-blast} is []{type:electric}-type.</summary>
        /// <summary>Held by []{pokemon:genesect} :   Holder's buster is red, and its []{move:techno-blast} is []{type:fire}-type.</summary>
        /// <summary>Held by []{pokemon:genesect} :   Holder's buster is white, and its []{move:techno-blast} becomes []{type:ice}-type.</summary>
        /// <summary>Used on a friendly Pokémon :   Restores 20 [HP]{mechanic:hp}.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Used to send short messages to other players via Pokémon trading.  Trainer may compose a message from a finite list of words when giving this item to a Pokémon.  Once taken and read, a message may be erased and this item can be reused, or the message may be stored in the trainer's PC.  Held :   Holder cannot be placed in the PC.  Any move attempting to remove this item from the holder will fail.</summary>
        /// <summary>Held by []{pokemon:feebas} :   Holder evolves into []{pokemon:milotic} when traded.</summary>
        /// <summary>Held by a Pokémon that is not fully evolved :   Holder has 1.5× [Defense]{mechanic:defense} and [Special Defense]{mechanic:special-defense}.</summary>
        /// <summary>Held :   Holder has 0.5× weight.</summary>
        /// <summary>Held :   When the holder is hit by a [contact]{mechanic:contact} move, the attacking Pokémon takes 1/6 its max [HP]{mechanic:hp} in damage.</summary>
        /// <summary>Held :   Holder is immune to []{type:ground}-type moves, []{move:spikes}, []{move:toxic-spikes}, and []{ability:arena-trap}.      This effect does not apply during []{move:gravity} or []{move:ingrain}.      When the holder takes damage from a move, this item is consumed.</summary>
        /// <summary>Held :   When the holder takes damage directly from a move and does not faint, it [switches out]{mechanic:switching-out} for another random, non-fainted Pokémon in its party. This effect does not activate if another effect prevents the holder from switching out.</summary>
        /// <summary>Held :   When one of the user's types would render it immune to damage, that type is ignored for damage calculation.</summary>
        /// <summary>Held :   Moves used by the holder that trap and damage a target for multiple turns (e.g. []{move:bind}, []{move:fire-spin}) inflict twice their usual per-turn damage.</summary>
        /// <summary>Held :   When the holder takes []{type:water}-type damage from a move, its [Special Attack]{mechanic:special-attack} rises by one [stage]{mechanic:stage} and this item is consumed.</summary>
        /// <summary>Held :   When the holder takes []{type:electric}-type damage from a move, its [Attack]{mechanic:attack} rises by one [stage]{mechanic:stage} and this item is consumed.</summary>
        /// <summary>Held :   When the holder takes damage directly from a move and does not faint, it [switches out]{mechanic:switching-out} for another non-fainted Pokémon in its party, as chosen by the Trainer. This effect does not activate if another effect prevents the holder from switching out.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:fire}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:water}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:electric}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:grass}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:ice}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:fighting}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:poison}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:ground}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:flying}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:psychic}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:bug}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:rock}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:ghost}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:dark}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:steel}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Used on a party Pokémon :   Increases the target's [HP]{mechanic:hp} [effort]{mechanic:effort} by 1.</summary>
        /// <summary>Used on a party Pokémon :   Increases the target's [Attack]{mechanic:attack} [effort]{mechanic:effort} by 1.</summary>
        /// <summary>Used on a party Pokémon :   Increases the target's [Defense]{mechanic:defense} [effort]{mechanic:effort} by 1.</summary>
        /// <summary>Used on a party Pokémon :   Increases the target's [Special Attack]{mechanic:special-attack} [effort]{mechanic:effort} by 1.</summary>
        /// <summary>Used on a party Pokémon :   Increases the target's [Special Defense]{mechanic:special-defense} [effort]{mechanic:effort} by 1.</summary>
        /// <summary>Used on a party Pokémon :   Increases the target's [Speed]{mechanic:speed} [effort]{mechanic:effort} by 1.</summary>
        /// <summary>Vendor trash.</summary>
        /// <summary>Give to a scientist in a museum to receive a []{pokemon:tirtouga}.</summary>
        /// <summary>Give to a scientist in a museum to receive a []{pokemon:archen}.</summary>
        /// <summary>Allows passage on the []{location:castelia-city} ship, which leads to []{location:liberty-garden} and []{pokemon:victini}.</summary>
        /// <summary>Acts as currency to activate Pass Powers in the Entralink.</summary>
        /// <summary>Can only be used in Entree Forest, to catch Pokémon encountered in the Dream World.  Used in battle :   [Catches]{mechanic:catch} a wild Pokémon without fail.</summary>
        /// <summary>Used in battle :   Ends a wild battle.  Cannot be used in trainer battles.</summary>
        /// <summary>Stores props for the Pokémon Musical.</summary>
        /// <summary>Only used as a plot point; this item is given to the player and taken away in the same cutscene.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Cult vendor trash.</summary>
        /// <summary>Used on a party Pokémon :   Cures any [status ailment]{mechanic:status-ailment} and [confusion]{mechanic:confusion}.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [critical hit]{mechanic:critical-hit} rate by two [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Speed]{mechanic:speed} by two [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Special Attack]{mechanic:special-attack} by two [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Special Defense]{mechanic:special-defense} by two [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Defense]{mechanic:defense} by two [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Attack]{mechanic:attack} by two [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [accuracy]{mechanic:accuracy} by two [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Speed]{mechanic:speed} by three [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Special Attack]{mechanic:special-attack} by three [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Special Defense]{mechanic:special-defense} by three [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Defense]{mechanic:defense} by three [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Attack]{mechanic:attack} by three [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [accuracy]{mechanic:accuracy} by three [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Speed]{mechanic:speed} by six [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Special Attack]{mechanic:special-attack} by six [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Special Defense]{mechanic:special-defense} by six [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Defense]{mechanic:defense} by six [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [Attack]{mechanic:attack} by six [stages]{mechanic:stage}.  This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [accuracy]{mechanic:accuracy} by six [stages]{mechanic:stage}.  This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Selects another friendly Pokémon at random.  If that Pokémon's ability is normally activated by some condition—i.e., is not continuous and passive—its effect is forcibly activated.  This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Selects another friendly Pokémon at random.  If that Pokémon is holding an item, that item is removed for the duration of the battle.  This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Selects another friendly Pokémon at random.  If that Pokémon is holding an item normally activated by some condition—i.e., not continuous and passive—its effect is forcibly activated.  This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Selects another friendly Pokémon at random.  Removes all of that Pokémon's stat changes.  This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Used on a party Pokémon in battle :   Raises the target's [critical hit]{mechanic:critical-hit} rate by three [stages]{mechanic:stage}. This item can only be obtained or used via the Wonder Launcher.</summary>
        /// <summary>Summons []{pokemon:reshiram} for the final battle against N.</summary>
        /// <summary>Summons []{pokemon:zekrom} for the final battle against N.</summary>
        /// <summary>Teaches []{move:wild-charge} to a compatible Pokémon.</summary>
        /// <summary>Teaches []{move:rock-smash} to a compatible Pokémon.</summary>
        /// <summary>Teaches []{move:snarl} to a compatible Pokémon.</summary>
        /// <summary>Makes four-way video calls.  Used for plot advancement in-game, but also works with other players via the C-Gear.</summary>
        /// <summary>Unknown.  Currently unused.</summary>
        /// <summary>Give to the []{pokemon:wingull} on []{location:unova-route-13}, along with []{item:gram-2} and []{item:gram-3}, to receive []{item:tm89}.</summary>
        /// <summary>Give to the []{pokemon:wingull} on []{location:unova-route-13}, along with []{item:gram-1} and []{item:gram-3}, to receive []{item:tm89}.</summary>
        /// <summary>Give to the []{pokemon:wingull} on []{location:unova-route-13}, along with []{item:gram-1} and []{item:gram-2}, to receive []{item:tm89}.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:dragon}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Held :   When the holder uses a damaging []{type:normal}-type move, the move has 1.5× power and this item is consumed.</summary>
        /// <summary>Holds medals recieved in the medal rally.</summary>
        /// <summary>Fuses Kyurem with Reshiram or Zekrom, or splits them apart again.</summary>
        /// <summary>Grants access to the Nature Preserve.</summary>
        /// <summary>Doubles the chance of two Pokémon producing an egg at the daycare every 255 steps.</summary>
        /// <summary>Raises the chance of finding a shiny Pokémon.</summary>
        /// <summary>Required to progress in the Plasma Frigate.</summary>
        /// <summary>Appears in the Café Warehouse on Sunday; return to the customer with a Patrat on Thursday.</summary>
        /// <summary>Wakes up the Crustle blocking the way in Seaside Cave.</summary>
        /// <summary>Returned to Curtis or Yancy as part of a sidequest.</summary>
        /// <summary>Switches Tornadus, Thundurus, and Landorus between Incarnate and Therian Forme.</summary>
        /// <summary>An item to be held by a Pokémon. Attack and Sp. Atk sharply increase if the holder is hit with a move it’s weak to.</summary>
        /// <summary>An item to be held by a Pokémon. This offensive vest raises Sp. Def but prevents the use of status moves.</summary>
        /// <summary>An item to be held by a Pokémon. It is a stone tablet that boosts the power of Fairy-type moves.</summary>
        /// <summary>A capsule that allows a Pokémon with two Abilities to switch between these Abilities when it is used.</summary>
        /// <summary>A soft and sweet treat made of fluffy, puffy, whipped and whirled cream. It’s loved by a certain Pokémon.</summary>
        /// <summary>A sachet filled with fragrant perfumes that are just slightly too overwhelming. Yet it’s loved by a certain Pokémon.</summary>
        /// <summary>An item to be held by a Pokémon. It boosts Sp. Def if hit with a Water- type attack. It can only be used once.</summary>
        /// <summary>An item to be held by a Pokémon. It boosts Attack if hit with an Ice-type attack. It can only be used once.</summary>
        /// <summary>An item to be held by a Pokémon. These goggles protect the holder from both weather-related damage and powder.</summary>
        /// <summary>Mulch to be used in a Berry field. It increases the Berry harvest without the need for particularly diligent care.</summary>
        /// <summary>Mulch to be used in a Berry field. It causes strange, sudden mutations based on the combination of Berries.</summary>
        /// <summary>Mulch to be used in a Berry field. It increases the Berry harvest that can be grown by diligent watering.</summary>
        /// <summary>Mulch to be used in a Berry field. An amazing Mulch with the effects of Rich, Surprise, and Boost Mulch.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Gengar hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Gardevoir hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Ampharos hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Venusaur hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Charizard hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Blastoise hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Mewtwo hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Mewtwo hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Blaziken hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Medicham hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Houndoom hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Aggron hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Banette hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Tyranitar hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Scizor hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Pinsir hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Aerodactyl hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Lucario hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Abomasnow hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Kangaskhan hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Gyarados hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Absol hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Charizard hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Alakazam hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Heracross hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Mawile hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Manectric hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>One variety of the mysterious Mega Stones. Have Garchomp hold it, and this stone will enable it to Mega Evolve during battle.</summary>
        /// <summary>If held by a Pokémon, this Berry will lessen the damage taken from one supereffective Fairy-type attack.</summary>
        /// <summary>If held by a Pokémon, this Berry will increase the holder’s Defense if it’s hit with a physical move.</summary>
        /// <summary>If held by a Pokémon, this Berry will increase the holder’s Sp. Def if it’s hit with a special move.</summary>
        /// <summary>This special coupon allows you to buy items at a discount when you are shopping at a boutique.</summary>
        /// <summary>An ornament depicting a Pokémon that is venerated as a protector in some region far from Kalos.</summary>
        /// <summary>A popular treat in Lumiose City. It can be used once to heal all the status conditions of a Pokémon.</summary>
        /// <summary>A fossil from a prehistoric Pokémon that once lived on the land. It looks as if it could be a piece of a large jaw.</summary>
        /// <summary>A fossil from a prehistoric Pokémon that once lived on the land. It looks like the impression from a skin sail.</summary>
        /// <summary>A gem with an essence of the fey. When held, it strengthens the power of a Fairy-type move one time.</summary>
        /// <summary>This book contains all the points a new Trainer needs to know on a journey. It was handmade by a kind friend.</summary>
        /// <summary>A card key that activates the elevator in Lysandre Labs. It is emblazoned with Team Flare’s logo.</summary>
        /// <summary>A device that allows users to receive and view hologram clips at any time. It is also used to chat with others.</summary>
        /// <summary>A precious symbol that is awarded only to an individual who has done great things for the Kalos region.</summary>
        /// <summary>A rather curious stone that might appear to be valuable to some. It’s all in the eye of the beholder.</summary>
        /// <summary>A rather chic-looking case for carrying contact lenses.</summary>
        /// <summary>A ticket that was handmade by Looker. It’s decorated with a liberal amount of glittery paint.</summary>
        /// <summary>This ring contains an untold power that somehow enables Pokémon carrying Mega Stones to Mega Evolve in battle.</summary>
        /// <summary>This pass serves as an ID card for gaining access to the power plant that lies along Route 13.</summary>
        /// <summary>A letter that Professor Sycamore wrote to your mother. A faint but pleasant perfume seems to cling to the paper.</summary>
        /// <summary>Attaches roller skates to the bottom of your shoes, allowing you to glide quickly around and perform tricks.</summary>
        /// <summary>A watering can shaped like a Lotad. It helps promote the healthy growth of any Berries planted in good, soft soil.</summary>
        /// <summary>A commuter pass that allows the holder to ride the TMV between Lumiose City and Kiloude City at any time.</summary>
        /// <summary>An attack that makes use of nature’s power. Its effects vary depending on the user’s environment.</summary>
        /// <summary>The user releases a horrible aura imbued with dark thoughts. This may also make the target flinch.</summary>
        /// <summary>Striking opponents over and over makes the user’s fists harder. Hitting a target raises the Attack stat.</summary>
        /// <summary>The user damages opposing Pokémon by emitting a powerful flash.</summary>
        /// <summary>The user tells the target a secret, and the target loses its ability to concentrate. This lowers the target’s Sp. Atk stat.</summary>
    }
}

public class eMoves{
    /// <summary>
    /// Move ids are connected to XML file.
    /// </summary>
    /// <remarks>Can now code with strings or int and
    /// access the same value.</remarks>
    public enum Move {
        NONE = 0
    }
}

public class ePokemons{
    /// <summary>
    /// Pokemon ids are connected to XML file.
    /// </summary>
    /// <remarks>Can now code with strings or int and
    /// access the same value.</remarks>
    public enum Pokemon {

    }
}