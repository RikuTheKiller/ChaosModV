﻿using System.Collections.Generic;

namespace ConfigApp
{
    public static class Effects
    {
        public struct EffectInfo
        {
            public EffectInfo(string name, EffectCategory effectCategory, int id)
            {
                Name = name;
                EffectCategory = effectCategory;
                Id = id;
            }

            public readonly string Name;
            public readonly EffectCategory EffectCategory;
            public readonly int Id;
        }

        public enum EffectCategory
        {
            PLAYER,
            VEHICLE,
            PEDS,
            TIME,
            WEATHER,
            MISC
        }

        public enum EffectType
        {
            EFFECT_KILL,
            EFFECT_PLUS_2_STARS,
            EFFECT_5_STARS,
            EFFECT_CLEAR_STARS,
            EFFECT_NEVER_WANTED,
            EFFECT_STRIP_WEAPONS,
            EFFECT_GIVE_RPG,
            EFFECT_GIVE_MINIGUN,
            EFFECT_GIVE_PARACHUTE,
            EFFECT_GIVE_PISTOL,
            EFFECT_GIVE_TAZER,
            EFFECT_GIVE_RAILGUN,
            EFFECT_GIVE_KNIFE,
            EFFECT_GIVE_BATTLEAXE,
            EFFECT_HEAL,
            EFFECT_ARMOR,
            EFFECT_IGNITE,
            EFFECT_ANGRY_JESUS,
            EFFECT_IGNITE_PEDS,
            EFFECT_EXPLODE_VEHS,
            EFFECT_PLAYER_LAUNCH,
            EFFECT_PLAYER_VEH_LAUNCH,
            EFFECT_VEHS_LAUNCH,
            EFFECT_PLAYER_VEH_LOCK,
            EFFECT_NOTHING,
            EFFECT_KILL_ENGINE,
            EFFECT_TIME_MORNING,
            EFFECT_TIME_DAY,
            EFFECT_TIME_EVENING,
            EFFECT_TIME_NIGHT,
            EFFECT_WEATHER_SUNNY,
            EFFECT_WEATHER_EXTRASUNNY,
            EFFECT_WEATHER_RAINY,
            EFFECT_WEATHER_THUNDER,
            EFFECT_WEATHER_FOGGY,
            EFFECT_WEATHER_NEUTRAL,
            EFFECT_WEATHER_XMAS,
            EFFECT_TP_LSAIRPORT,
            EFFECT_TP_MAZETOWER,
            EFFECT_TP_FORTZANCUDO,
            EFFECT_TP_MOUNTCHILLIAD,
            EFFECT_NO_PHONE,
            EFFECT_SET_INTO_CLOSEST_VEH,
            EFFECT_EXIT_CURRENT_VEH,
            EFFECT_GAMESPEED_X05,
            EFFECT_GAMESPEED_X02,
            EFFECT_GAMESPEED_LAG,
            EFFECT_PEDS_RIOT,
            EFFECT_RED_VEHS,
            EFFECT_BLUE_VEHS,
            EFFECT_GREEN_VEHS,
            EFFECT_BLACK_VEHS,
            EFFECT_CHROME_VEHS,
            EFFECT_RAINBOW_VEHS,
            EFFECT_FORCED_FP,
            EFFECT_SLIPPERY_VEHS,
            EFFECT_NO_GRAV_VEHS,
            EFFECT_PLAYER_INVINCIBLE,
            EFFECT_2XENGINE_VEHS,
            EFFECT_10XENGINE_VEHS,
            EFFECT_05XENGINE_VEHS,
            EFFECT_SPAWN_TANK,
            EFFECT_SPAWN_ADDER,
            EFFECT_SPAWN_DUMP,
            EFFECT_SPAWN_MONSTER,
            EFFECT_SPAWN_BMX,
            EFFECT_SPAWN_TUG,
            EFFECT_SPAWN_CARGO,
            EFFECT_SPAWN_BUS,
            EFFECT_SPAWN_BLIMP,
            EFFECT_SPAWN_BUZZARD,
            EFFECT_NO_VEHS,
            EFFECT_NO_PEDS,
            EFFECT_EXPLODE_CUR_VEH,
            EFFECT_PEDS_INVISIBLE,
            EFFECT_VEHS_INVISIBLE,
            EFFECT_NO_RADAR,
            EFFECT_NO_HUD,
            EFFECT_SUPER_RUN,
            EFFECT_SUPER_JUMP,
            EFFECT_PLAYER_RAGDOLL,
            EFFECT_PEDS_RAGDOLL_ON_TOUCH,
            EFFECT_PLUS_100K,
            EFFECT_MINUS_100K,
            EFFECT_PEDS_FOLLOW_PLAYER,
            EFFECT_PLAYER_DRUNK,
            EFFECT_PEDS_OHKO,
            EFFECT_PEDS_NO_FEAR,
            EFFECT_SCREEN_BLOOM,
            EFFECT_SCREEN_LSD,
            EFFECT_PEDS_IGNORE_PLAYER,
            EFFECT_HONK_BOOSTING,
            EFFECT_MIN_DAMAGE,
            EFFECT_NO_HEADSHOTS,
            EFFECT_PEDS_FROZEN,
            EFFECT_LOW_GRAV,
            EFFECT_VERY_LOW_GRAV,
            EFFECT_INSANE_GRAV,
            EFFECT_VEH_REPAIR,
            EFFECT_VEH_POP_TIRES,
            EFFECT_ALL_VEH_POP_TIRES,
            EFFECT_NO_SPECIAL_ABILITY,
            EFFECT_IN_THE_HOOD,
            EFFECT_FORCED_CINEMATIC,
            EFFECT_PEDS_FLEE,
            EFFECT_BREAK_VEH_DOORS,
            EFFECT_ZOMBIES,
            EFFECT_METEOR_RAIN,
            EFFECT_BLIND,
            EFFECT_BLACKOUT,
            EFFECT_QUICK_TIME,
            EFFECT_PAUSE_TIME,
            EFFECT_MOV_NO_UD,
            EFFECT_MOV_NO_LR,
            EFFECT_BREAK,
            EFFECT_EVERYONE_RPG,
            EFFECT_EVERYONE_TAZER,
            EFFECT_EVERYONE_MINIGUN,
            EFFECT_PEDS_FAST_FIRING,
            EFFECT_NO_SPRINT,
            EFFECT_NO_JUMP,
            EFFECT_EVERYONE_INVINCIBLE,
            EFFECT_VEHS_INVINCIBLE,
            EFFECT_PLAYER_SHOT_RAGDOLL,
            EFFECT_JUMPY_VEHS,
            EFFECT_LOCK_VEHS,
            EFFECT_TOTAL_CHAOS,
            EFFECT_NO_RAGDOLL,
            EFFECT_VEHS_HORN,
            _EFFECT_ENUM_MAX
        }

        public static readonly Dictionary<EffectType, EffectInfo> EffectsMap = new Dictionary<EffectType, EffectInfo>()
        {
            {EffectType.EFFECT_KILL, new EffectInfo("Suicide", EffectCategory.PLAYER, 0)},
	        {EffectType.EFFECT_PLUS_2_STARS, new EffectInfo("+2 Wanted Stars", EffectCategory.PLAYER, 1)},
	        {EffectType.EFFECT_5_STARS, new EffectInfo("5 Wanted Stars", EffectCategory.PLAYER, 2)},
	        {EffectType.EFFECT_CLEAR_STARS, new EffectInfo("Clear Wanted Level", EffectCategory.PLAYER, 3)},
            {EffectType.EFFECT_NEVER_WANTED, new EffectInfo("Never Wanted", EffectCategory.PLAYER, 62)},
            {EffectType.EFFECT_STRIP_WEAPONS, new EffectInfo("Remove Weapons From Everyone", EffectCategory.PEDS, 4)},
	        {EffectType.EFFECT_GIVE_RPG, new EffectInfo("Give RPG", EffectCategory.PLAYER, 5)},
	        {EffectType.EFFECT_GIVE_MINIGUN, new EffectInfo("Give Minigun", EffectCategory.PLAYER, 6)},
	        {EffectType.EFFECT_GIVE_PARACHUTE, new EffectInfo("Give Parachute", EffectCategory.PLAYER, 7)},
	        {EffectType.EFFECT_GIVE_PISTOL, new EffectInfo("Give Pistol", EffectCategory.PLAYER, 8)},
	        {EffectType.EFFECT_GIVE_TAZER, new EffectInfo("Give Stungun", EffectCategory.PLAYER, 9)},
	        {EffectType.EFFECT_GIVE_RAILGUN, new EffectInfo("Give Railgun", EffectCategory.PLAYER, 10)},
            {EffectType.EFFECT_GIVE_KNIFE, new EffectInfo("Give Knife", EffectCategory.PLAYER, 122)},
            {EffectType.EFFECT_GIVE_BATTLEAXE, new EffectInfo("Give Battleaxe", EffectCategory.PLAYER, 123)},
            {EffectType.EFFECT_HEAL, new EffectInfo("Heal Player", EffectCategory.PLAYER, 11)},
	        {EffectType.EFFECT_ARMOR, new EffectInfo("Give Armor", EffectCategory.PLAYER, 12)},
	        {EffectType.EFFECT_IGNITE, new EffectInfo("Ignite Player", EffectCategory.PLAYER, 13)},
	        {EffectType.EFFECT_ANGRY_JESUS, new EffectInfo("Spawn Griefer Jesus", EffectCategory.MISC, 14)},
	        {EffectType.EFFECT_IGNITE_PEDS, new EffectInfo("Ignite All Nearby Peds", EffectCategory.PEDS, 15)},
	        {EffectType.EFFECT_EXPLODE_VEHS, new EffectInfo("Explode All Nearby Vehicles", EffectCategory.VEHICLE, 16)},
	        {EffectType.EFFECT_PLAYER_LAUNCH, new EffectInfo("Launch Player Up", EffectCategory.PLAYER, 17)},
	        {EffectType.EFFECT_PLAYER_VEH_LAUNCH, new EffectInfo("Launch Current Vehicle Up", EffectCategory.VEHICLE, 18)},
            {EffectType.EFFECT_VEHS_LAUNCH, new EffectInfo("Launch All Vehicles Up", EffectCategory.VEHICLE, 100)},
            {EffectType.EFFECT_PLAYER_VEH_LOCK, new EffectInfo("Lock Vehicle Player Is In", EffectCategory.VEHICLE, 19)},
	        {EffectType.EFFECT_NOTHING, new EffectInfo("Nothing", EffectCategory.MISC, 20)},
	        {EffectType.EFFECT_KILL_ENGINE, new EffectInfo("Kill Engine Of Current Vehicle", EffectCategory.VEHICLE, 21)},
	        {EffectType.EFFECT_TIME_MORNING, new EffectInfo("Set Time To Morning", EffectCategory.TIME, 22)},
	        {EffectType.EFFECT_TIME_DAY, new EffectInfo("Set Time To Daytime", EffectCategory.TIME, 23)},
	        {EffectType.EFFECT_TIME_EVENING, new EffectInfo("Set Time To Evening", EffectCategory.TIME, 24)},
	        {EffectType.EFFECT_TIME_NIGHT, new EffectInfo("Set Time To Night", EffectCategory.TIME, 25)},
	        {EffectType.EFFECT_WEATHER_SUNNY, new EffectInfo("Sunny Weather", EffectCategory.WEATHER, 26)},
	        {EffectType.EFFECT_WEATHER_EXTRASUNNY, new EffectInfo("Extra Sunny Weather", EffectCategory.WEATHER, 27)},
	        {EffectType.EFFECT_WEATHER_RAINY, new EffectInfo("Rainy Weather", EffectCategory.WEATHER, 28)},
	        {EffectType.EFFECT_WEATHER_THUNDER, new EffectInfo("Stormy Weather", EffectCategory.WEATHER, 29)},
	        {EffectType.EFFECT_WEATHER_FOGGY, new EffectInfo("Foggy Weather", EffectCategory.WEATHER, 30)},
            {EffectType.EFFECT_WEATHER_NEUTRAL, new EffectInfo("Neutral Weather", EffectCategory.WEATHER, 97)},
            {EffectType.EFFECT_WEATHER_XMAS, new EffectInfo("Snowy Weather", EffectCategory.WEATHER, 31)},
	        {EffectType.EFFECT_TP_LSAIRPORT, new EffectInfo("Teleport To LS Airport", EffectCategory.PLAYER, 32)},
	        {EffectType.EFFECT_TP_MAZETOWER, new EffectInfo("Teleport To Maze Bank Tower", EffectCategory.PLAYER, 33)},
	        {EffectType.EFFECT_TP_FORTZANCUDO, new EffectInfo("Teleport To Fort Zancudo", EffectCategory.PLAYER, 34)},
	        {EffectType.EFFECT_TP_MOUNTCHILLIAD, new EffectInfo("Teleport To Mount Chilliad", EffectCategory.PLAYER, 35)},
	        {EffectType.EFFECT_NO_PHONE, new EffectInfo("No Phone", EffectCategory.MISC, 36)},
	        {EffectType.EFFECT_SET_INTO_CLOSEST_VEH, new EffectInfo("Set Player Into Closest Vehicle", EffectCategory.PLAYER, 37)},
	        {EffectType.EFFECT_EXIT_CURRENT_VEH, new EffectInfo("Exit Current Vehicle", EffectCategory.PLAYER, 38)},
	        {EffectType.EFFECT_GAMESPEED_X02, new EffectInfo("x0.2 Gamespeed", EffectCategory.TIME, 39)},
	        {EffectType.EFFECT_GAMESPEED_X05, new EffectInfo("x0.5 Gamespeed", EffectCategory.TIME, 40)},
            {EffectType.EFFECT_GAMESPEED_LAG, new EffectInfo("Lag", EffectCategory.TIME, 102)},
            {EffectType.EFFECT_PEDS_RIOT, new EffectInfo("Peds Riot", EffectCategory.PEDS, 41)},
	        {EffectType.EFFECT_RED_VEHS, new EffectInfo("Red Traffic", EffectCategory.VEHICLE, 42)},
	        {EffectType.EFFECT_BLUE_VEHS, new EffectInfo("Blue Traffic", EffectCategory.VEHICLE, 43)},
	        {EffectType.EFFECT_GREEN_VEHS, new EffectInfo("Green Traffic", EffectCategory.VEHICLE, 44)},
            {EffectType.EFFECT_BLACK_VEHS, new EffectInfo("Black Traffic", EffectCategory.VEHICLE, 119)},
            {EffectType.EFFECT_CHROME_VEHS, new EffectInfo("Chrome Traffic", EffectCategory.VEHICLE, 128)},
            {EffectType.EFFECT_RAINBOW_VEHS, new EffectInfo("Rainbow Traffic", EffectCategory.VEHICLE, 45)},
	        {EffectType.EFFECT_FORCED_FP, new EffectInfo("First Person", EffectCategory.MISC, 46)},
	        {EffectType.EFFECT_SLIPPERY_VEHS, new EffectInfo("Slippery Vehicles", EffectCategory.VEHICLE, 47)},
	        {EffectType.EFFECT_NO_GRAV_VEHS, new EffectInfo("Vehicles Have No Gravity", EffectCategory.VEHICLE, 48)},
	        {EffectType.EFFECT_PLAYER_INVINCIBLE, new EffectInfo("Invincibility", EffectCategory.PLAYER, 49)},
	        {EffectType.EFFECT_2XENGINE_VEHS, new EffectInfo("2x Vehicle Engine Speed", EffectCategory.VEHICLE, 50)},
	        {EffectType.EFFECT_10XENGINE_VEHS, new EffectInfo("10x Vehicle Engine Speed", EffectCategory.VEHICLE, 51)},
	        {EffectType.EFFECT_05XENGINE_VEHS, new EffectInfo("0.5x Vehicle Engine Speed", EffectCategory.VEHICLE, 52)},
	        {EffectType.EFFECT_SPAWN_TANK, new EffectInfo("Spawn Rhino", EffectCategory.VEHICLE, 53)},
	        {EffectType.EFFECT_SPAWN_ADDER, new EffectInfo("Spawn Adder", EffectCategory.VEHICLE, 54)},
	        {EffectType.EFFECT_SPAWN_DUMP, new EffectInfo("Spawn Dump", EffectCategory.VEHICLE, 55)},
	        {EffectType.EFFECT_SPAWN_MONSTER, new EffectInfo("Spawn Monster", EffectCategory.VEHICLE, 56)},
	        {EffectType.EFFECT_SPAWN_BMX, new EffectInfo("Spawn BMX", EffectCategory.VEHICLE, 57)},
	        {EffectType.EFFECT_SPAWN_TUG, new EffectInfo("Spawn Tug", EffectCategory.VEHICLE, 58)},
	        {EffectType.EFFECT_SPAWN_CARGO, new EffectInfo("Spawn Cargo Plane", EffectCategory.VEHICLE, 59)},
	        {EffectType.EFFECT_SPAWN_BUS, new EffectInfo("Spawn Bus", EffectCategory.VEHICLE, 60)},
	        {EffectType.EFFECT_SPAWN_BLIMP, new EffectInfo("Spawn Blimp", EffectCategory.VEHICLE, 61)},
            {EffectType.EFFECT_SPAWN_BUZZARD, new EffectInfo("Spawn Buzzard", EffectCategory.VEHICLE, 105)},
            {EffectType.EFFECT_NO_VEHS, new EffectInfo("No Traffic", EffectCategory.VEHICLE, 63)},
	        {EffectType.EFFECT_NO_PEDS, new EffectInfo("No Pedestrians", EffectCategory.PEDS, 64)},
	        {EffectType.EFFECT_EXPLODE_CUR_VEH, new EffectInfo("Explode Current Vehicle", EffectCategory.VEHICLE, 65)},
	        {EffectType.EFFECT_PEDS_INVISIBLE, new EffectInfo("Everyone Is A Ghost", EffectCategory.PEDS, 66)},
	        {EffectType.EFFECT_VEHS_INVISIBLE, new EffectInfo("Invisible Vehicles", EffectCategory.VEHICLE, 67)},
	        {EffectType.EFFECT_NO_RADAR, new EffectInfo("No Radar", EffectCategory.MISC, 68)},
	        {EffectType.EFFECT_NO_HUD, new EffectInfo("No HUD", EffectCategory.MISC, 69)},
	        {EffectType.EFFECT_SUPER_RUN, new EffectInfo("Super Run", EffectCategory.PLAYER, 70)},
	        {EffectType.EFFECT_SUPER_JUMP, new EffectInfo("Super Jump", EffectCategory.PLAYER, 71)},
	        {EffectType.EFFECT_PLAYER_RAGDOLL, new EffectInfo("Ragdoll", EffectCategory.PLAYER, 72)},
	        {EffectType.EFFECT_PEDS_RAGDOLL_ON_TOUCH, new EffectInfo("Sensitive Touch", EffectCategory.PEDS, 73)},
	        {EffectType.EFFECT_PLUS_100K, new EffectInfo("+$100.000", EffectCategory.PLAYER, 74)},
	        {EffectType.EFFECT_MINUS_100K, new EffectInfo("-$100.000", EffectCategory.PLAYER, 75)},
	        {EffectType.EFFECT_PEDS_FOLLOW_PLAYER, new EffectInfo("You Are Famous", EffectCategory.PEDS, 76)},
	        {EffectType.EFFECT_PLAYER_DRUNK, new EffectInfo("Drunk", EffectCategory.PLAYER, 77)},
	        {EffectType.EFFECT_PEDS_OHKO, new EffectInfo("One Hit KO", EffectCategory.PEDS, 78)},
	        {EffectType.EFFECT_PEDS_NO_FEAR, new EffectInfo("Peds Have No Fear", EffectCategory.PEDS, 79)},
	        {EffectType.EFFECT_SCREEN_BLOOM, new EffectInfo("Bloom", EffectCategory.MISC, 80)},
	        {EffectType.EFFECT_SCREEN_LSD, new EffectInfo("LSD", EffectCategory.PLAYER, 81)},
	        {EffectType.EFFECT_PEDS_IGNORE_PLAYER, new EffectInfo("Peds Ignore Player", EffectCategory.PEDS, 82)},
	        {EffectType.EFFECT_HONK_BOOSTING, new EffectInfo("Honk Boosting", EffectCategory.VEHICLE, 83)},
	        {EffectType.EFFECT_MIN_DAMAGE, new EffectInfo("Minimal Damage", EffectCategory.PEDS, 84)},
	        {EffectType.EFFECT_NO_HEADSHOTS, new EffectInfo("No Headshots", EffectCategory.PEDS, 85)},
	        {EffectType.EFFECT_PEDS_FROZEN, new EffectInfo("Peds Are Brainless", EffectCategory.PEDS, 86)},
	        {EffectType.EFFECT_LOW_GRAV, new EffectInfo("Low Gravity", EffectCategory.MISC, 87)},
	        {EffectType.EFFECT_VERY_LOW_GRAV, new EffectInfo("Very Low Gravity", EffectCategory.MISC, 88)},
            {EffectType.EFFECT_INSANE_GRAV, new EffectInfo("Insane Gravity", EffectCategory.MISC, 101)},
            {EffectType.EFFECT_VEH_REPAIR, new EffectInfo("Repair Current Vehicle", EffectCategory.VEHICLE, 89)},
	        {EffectType.EFFECT_VEH_POP_TIRES, new EffectInfo("Pop Tires Of Current Vehicle", EffectCategory.VEHICLE, 90)},
	        {EffectType.EFFECT_ALL_VEH_POP_TIRES, new EffectInfo("Now This Is Some Tire Poppin'", EffectCategory.VEHICLE, 91)},
	        {EffectType.EFFECT_NO_SPECIAL_ABILITY, new EffectInfo("No Special Ability", EffectCategory.PLAYER, 92)},
	        {EffectType.EFFECT_IN_THE_HOOD, new EffectInfo("In The Hood", EffectCategory.PEDS, 93)},
	        {EffectType.EFFECT_FORCED_CINEMATIC, new EffectInfo("Cinematic Vehicle Cam", EffectCategory.VEHICLE, 94)},
	        {EffectType.EFFECT_PEDS_FLEE, new EffectInfo("All Peds Are Fleeing", EffectCategory.PEDS, 95)},
	        {EffectType.EFFECT_BREAK_VEH_DOORS, new EffectInfo("Break All Doors Of Current Vehicle", EffectCategory.VEHICLE, 96)},
            {EffectType.EFFECT_ZOMBIES, new EffectInfo("Zombies", EffectCategory.PEDS, 98)},
            {EffectType.EFFECT_METEOR_RAIN, new EffectInfo("Meteor Shower", EffectCategory.MISC, 99)},
            {EffectType.EFFECT_BLIND, new EffectInfo("Blind", EffectCategory.PLAYER, 103)},
            {EffectType.EFFECT_BLACKOUT, new EffectInfo("Blackout", EffectCategory.MISC, 104)},
            {EffectType.EFFECT_QUICK_TIME, new EffectInfo("Speedy Time", EffectCategory.TIME, 106)},
            {EffectType.EFFECT_PAUSE_TIME, new EffectInfo("Pause Time", EffectCategory.TIME, 107)},
            {EffectType.EFFECT_MOV_NO_UD, new EffectInfo("Disable Forwards / Backwards Movement", EffectCategory.PLAYER, 108)},
            {EffectType.EFFECT_MOV_NO_LR, new EffectInfo("Disable Left / Right Movement", EffectCategory.PLAYER, 109)},
            {EffectType.EFFECT_BREAK, new EffectInfo("It's Time For A Break", EffectCategory.PLAYER, 110)},
            {EffectType.EFFECT_EVERYONE_RPG, new EffectInfo("Give Everyone A RPG", EffectCategory.PEDS, 111)},
            {EffectType.EFFECT_EVERYONE_TAZER, new EffectInfo("Give Everyone A Stungun", EffectCategory.PEDS, 112)},
            {EffectType.EFFECT_EVERYONE_MINIGUN, new EffectInfo("Give Everyone A Minigun", EffectCategory.PEDS, 113)},
            {EffectType.EFFECT_PEDS_FAST_FIRING, new EffectInfo("Peds Shoot Fast", EffectCategory.PEDS, 114)},
            {EffectType.EFFECT_NO_SPRINT, new EffectInfo("No Sprint", EffectCategory.PLAYER, 115)},
            {EffectType.EFFECT_NO_JUMP, new EffectInfo("No Jump", EffectCategory.PLAYER, 116)},
            {EffectType.EFFECT_EVERYONE_INVINCIBLE, new EffectInfo("Everyone Is Invincible", EffectCategory.PEDS, 117)},
            {EffectType.EFFECT_VEHS_INVINCIBLE, new EffectInfo("All Vehicles Are Invulnerable", EffectCategory.VEHICLE, 118)},
            {EffectType.EFFECT_PLAYER_SHOT_RAGDOLL, new EffectInfo("Player Ragdolls When Shot", EffectCategory.PLAYER, 120)},
            {EffectType.EFFECT_JUMPY_VEHS, new EffectInfo("Jumpy Vehicles", EffectCategory.VEHICLE, 121)},
            {EffectType.EFFECT_LOCK_VEHS, new EffectInfo("Lock All Vehicles", EffectCategory.VEHICLE, 124)},
            {EffectType.EFFECT_TOTAL_CHAOS, new EffectInfo("Doomsday", EffectCategory.MISC, 125)},
            {EffectType.EFFECT_NO_RAGDOLL, new EffectInfo("No Ragdoll", EffectCategory.PLAYER, 126)},
            {EffectType.EFFECT_VEHS_HORN, new EffectInfo("All Vehicles Honk", EffectCategory.VEHICLE, 127)},
        };
    }
}
