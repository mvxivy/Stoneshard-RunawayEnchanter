// Copyright (C) 2024 Altair Wei
// See LICENSE file for extended copyright information.
// This file is part of the repository from .

using ModShardLauncher;
using ModShardLauncher.Mods;
using UndertaleModLib;
using UndertaleModLib.Models;

namespace RunawayEnchanter;
public class RunawayEnchanter : Mod
{
    public override string Author => "Altair";
    public override string Name => "Runaway Enchanter";
    public override string Description => "An Enchanter who escaped from the Order's Prison and now lives in seclusion at the Rotten Willow Inn. He can enchant your equipment with specified attributes.";
    public override string Version => "1.1.2";
    public override string TargetVersion => "0.8.2.10";

    public override void PatchMod()
    {
        // Create a new NPC

        UndertaleSprite s_npc_runaway_enchanter = Msl.GetSprite("s_npc_runaway_enchanter");
        s_npc_runaway_enchanter.CollisionMasks.RemoveAt(0);
        s_npc_runaway_enchanter.IsSpecialType = true;
        s_npc_runaway_enchanter.SVersion = 3;
        s_npc_runaway_enchanter.Width = 44;
        s_npc_runaway_enchanter.Height = 49;
        s_npc_runaway_enchanter.MarginLeft = 12;
        s_npc_runaway_enchanter.MarginRight = 31;
        s_npc_runaway_enchanter.MarginBottom = 39;
        s_npc_runaway_enchanter.MarginTop = 7;
        s_npc_runaway_enchanter.OriginX = 21;
        s_npc_runaway_enchanter.OriginY = 35;
        s_npc_runaway_enchanter.GMS2PlaybackSpeed = 1;
        s_npc_runaway_enchanter.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerGameFrame;

        // FIXME: 貌似 z-axis 太高了？导致身体遮住 player 的武器。
        UndertaleSprite s_npc_runaway_enchanter_sitting_idle = Msl.GetSprite("s_npc_runaway_enchanter_sitting_idle");
        s_npc_runaway_enchanter_sitting_idle.CollisionMasks.RemoveAt(0);
        s_npc_runaway_enchanter_sitting_idle.IsSpecialType = true;
        s_npc_runaway_enchanter_sitting_idle.SVersion = 3;
        s_npc_runaway_enchanter_sitting_idle.Width = 21;
        s_npc_runaway_enchanter_sitting_idle.Height = 33;
        s_npc_runaway_enchanter_sitting_idle.MarginLeft = 0;
        s_npc_runaway_enchanter_sitting_idle.MarginRight = 20;
        s_npc_runaway_enchanter_sitting_idle.MarginBottom = 32;
        s_npc_runaway_enchanter_sitting_idle.MarginTop = 0;
        s_npc_runaway_enchanter_sitting_idle.OriginX = 5;
        s_npc_runaway_enchanter_sitting_idle.OriginY = 38;
        s_npc_runaway_enchanter_sitting_idle.GMS2PlaybackSpeed = 0.3F;
        s_npc_runaway_enchanter_sitting_idle.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerGameFrame;

        UndertaleGameObject o_npc_runaway_enchanter = Msl.AddObject(
            name: "o_npc_runaway_enchanter",
            spriteName: "s_npc_runaway_enchanter",
            parentName: "o_village_standing",
            isVisible: true,
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        o_npc_runaway_enchanter.ApplyEvent(ModFiles,
            new MslEvent("npc_runaway_enchanter_create_0.gml", EventType.Create, 0),
            new MslEvent("npc_runaway_enchanter_precreate_0.gml", EventType.PreCreate, 0),
            new MslEvent("npc_runaway_enchanter_other_25.gml", EventType.Other, 25)
        );

        // Add the NPC to the room

        UndertaleRoom room = Msl.GetRoom("r_tavernWillow1floor");
        UndertaleRoom.Layer LayerTarget = Msl.GetLayer(room, UndertaleRoom.LayerType.Instances, "Targets");
        UndertaleRoom.Layer LayerNPC = Msl.GetLayer(room, UndertaleRoom.LayerType.Instances, "NPC");

        UndertaleRoom.GameObject o_NPC_target_runaway_enchanter = room.AddGameObject(
            LayerTarget,
            "o_NPC_target",
            Msl.AddCode(ModFiles.GetCode("taverninside_100_create.gml"), "gml_RoomCC_r_tavernWillow1floor_100_Create"),
            x: 598, y: 442
        );

        UndertaleRoom.GameObject entrance = Msl.ThrowIfNull(
            LayerTarget.InstancesData.Instances.First(
                t => t.ObjectDefinition.Name.Content == "o_NPC_target" && t.X == 728 && t.Y == 520));
        uint tagertID = o_NPC_target_runaway_enchanter.InstanceID;
        string codeRunawayEnchanter = string.Format(@ModFiles.GetCode("taverninside_101_create.gml"), tagertID, entrance.InstanceID);

        room.AddGameObject(
            LayerNPC, 
            "o_npc_runaway_enchanter", 
            Msl.AddCode(codeRunawayEnchanter, "gml_RoomCC_r_tavernWillow1floor_101_Create"),
            x: 610, y: 455
        );

        // Add a beer cup

        UndertaleRoom.Layer LayerForegroundInstances = Msl.GetLayer(room, UndertaleRoom.LayerType.Instances, "ForegroundInstances");
        UndertaleRoom.GameObject o_loot_marker = room.AddGameObject(
            LayerForegroundInstances,
            "o_loot_marker",
            Msl.AddCode("chance = 100\nloot = choose(o_loot_mug)\nhasOwner = false", "gml_RoomCC_r_tavernWillow1floor_102_Create"),
            x: 608, y: 426
        );
        o_loot_marker.ImageSpeed = 1;

        // Add enchant skill
        UndertaleGameObject o_skill_enchant_specify = Msl.AddObject(
            name: "o_skill_enchant_specify",
            spriteName: "sprite1",
            parentName: "o_weapon_skills",
            isVisible: true,
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        // Add functions

        Msl.AddFunction(ModFiles.GetCode("scr_mod_enchant_specify.gml"), "scr_mod_enchant_specify");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_enchant_generation.gml"), "scr_mod_enchant_generation");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_can_enchant_item.gml"), "scr_mod_can_enchant_item");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_prison_note_opened.gml"), "scr_mod_prison_note_opened");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_elm_do_extra_enchantment.gml"), "scr_mod_elm_do_extra_enchantment");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_can_extra_enchant_item.gml"), "scr_mod_can_extra_enchant_item");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_elm_miniquest.gml"), "scr_mod_elm_miniquest");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_re_gwynnel_elixir_effect.gml"), "scr_mod_re_gwynnel_elixir_effect");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_elm_take_artifact.gml"), "scr_mod_elm_take_artifact");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_secret_agreement.gml"), "scr_mod_secret_agreement");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_can_talk_secret.gml"), "scr_mod_can_talk_secret");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_init_elm_quest.gml"), "scr_mod_init_elm_quest");

        o_skill_enchant_specify.ApplyEvent(ModFiles,
            new MslEvent("gml_Object_o_skill_enchant_specify_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_enchant_specify_Other_11.gml", EventType.Other, 11),
            new MslEvent("gml_Object_o_skill_enchant_specify_Other_20.gml", EventType.Other, 20)
        );

        // About the story of Elm

        Msl.LoadGML("gml_Object_o_inv_prison_note_Create_0")
            .MatchAll()
            .InsertBelow("script_after_close = gml_Script_scr_mod_prison_note_opened")
            .Save();

        // Init the mini quest
        Msl.LoadAssemblyAsString("gml_GlobalScript_scr_init_quests")
            .MatchFromUntil("push.s \"fetchOrmond\"", "popz.v")
            .InsertBelow(@"push.s ""mod_re_cure_elm""
conv.s.v
push.i gml_Script_QuestDefinition
conv.i.v
call.i @@NewGMLObject@@(argc=2)
push.s ""mod_re_find_artifacts""
conv.s.v
dup.v 1 8
dup.v 0
push.v stacktop.Task
callv.v 1
push.s ""mod_re_find_artifacts_desc""
conv.s.v
dup.v 1 8
dup.v 0
push.v stacktop.SetDescription
callv.v 1
popz.v")
            .Save();

        // Msl.AddMenu(
        //     "Runaway Enchanter",
        //     new UIComponent(
        //         name: "Press F1 to fix Elm's quest", associatedGlobal: "add_runaway_enchanter_miniquest",
        //         UIComponentType.CheckBox, 0)
        // );

        // Msl.LoadAssemblyAsString("gml_Object_o_player_KeyPress_112") // F1
        //     .MatchFrom(":[end]")
        //     .InsertAbove(ModFiles, "gml_Object_o_player_KeyPress_112.asm")
        //     .Save();

        Msl.LoadAssemblyAsString("scr_mod_init_elm_quest")
            .MatchAll()
            .ReplaceBy(ModFiles, "scr_mod_init_elm_quest.asm")
            .Save();

        PatchDialogueData();

        // Add localization text

        Localization.PatchNames();
        Localization.PatchDialogs();
        Localization.PatchQeusts();
    }

    private void PatchDialogueData()
    {
        // Add dialog data
        UndertaleGameObject ob = Msl.AddObject("runaway_enchanter_initializer", isPersistent: true);
        Msl.AddNewEvent(ob, "", EventType.Other, 10);
        UndertaleRoom start = Msl.GetRoom("START");
        start.AddGameObject("Instances", ob);

        string insertCodes = ModFiles.GetCode("runaway_enchanter_dialog_data.gml");

        string[] _weapon_effs = {
            "Lifesteal", "Manasteal", "Bleeding_Chance", "Daze_Chance", "Stun_Chance", "Knockback_Chance",
            "Fire_Damage", "Frost_Damage", "Poison_Damage", "Shock_Damage", "Caustic_Damage", "Weapon_Damage",
            "Armor_Damage", "Bodypart_Damage", "Magic_Power", "Skills_Energy_Cost", "Spells_Energy_Cost",
            "Cooldown_Reduction", "PRR", "CTA", "Hit_Chance", "CRT", "CRTD", "FMB", "Armor_Piercing"
        };

        insertCodes += @$"
array_push(_Fragments.mod_re_runaway_enchanter_ask_which_enchantment_weapon, ""mod_re_enchantment_weapon_Block_Power"")
variable_struct_set(_Fragments, ""mod_re_enchantment_weapon_Block_Power"", ""instruction_INS_weapon_Block_Power"")
variable_struct_set(_Fragments, ""instruction_INS_weapon_Block_Power"", ""@dialogue_end"")
variable_struct_set(_Scripts, ""instruction_INS_weapon_Block_Power"", function() {{ scr_mod_enchant_specify(""Weapon"", ""Block_Power"") }})
variable_struct_set(_Specs, ""instruction_INS_weapon_Block_Power"", {{ action: true }})";

        foreach (string eff in _weapon_effs)
        {
            insertCodes += @$"
array_push(_Fragments.mod_re_runaway_enchanter_ask_which_enchantment_weapon, ""mod_re_enchantment_{eff}"")
variable_struct_set(_Fragments, ""mod_re_enchantment_{eff}"", ""instruction_INS_{eff}"")
variable_struct_set(_Fragments, ""instruction_INS_{eff}"", ""@dialogue_end"")
variable_struct_set(_Scripts, ""instruction_INS_{eff}"", function() {{ scr_mod_enchant_specify(""Weapon"", ""{eff}"") }})
variable_struct_set(_Specs, ""instruction_INS_{eff}"", {{ action: true }})";
        }

        string[] _armor_effs = {
            "HP", "MP", "Health_Restoration", "MP_Restoration", "EVS", "Fortitude", "Healing_Received",
            "Slashing_Resistance", "Piercing_Resistance", "Blunt_Resistance", "Rending_Resistance", "Unholy_Resistance",
            "Stun_Resistance", "Knockback_Resistance", "Bleeding_Resistance", "Physical_Resistance", "Nature_Resistance",
            "Magic_Resistance", "Pain_Resistance"
        };

        insertCodes += @$"
array_push(_Fragments.mod_re_runaway_enchanter_ask_which_enchantment_armor, ""mod_re_enchantment_armor_Block_Power"")
variable_struct_set(_Fragments, ""mod_re_enchantment_armor_Block_Power"", ""instruction_INS_armor_Block_Power"")
variable_struct_set(_Fragments, ""instruction_INS_armor_Block_Power"", ""@dialogue_end"")
variable_struct_set(_Scripts, ""instruction_INS_armor_Block_Power"", function() {{ scr_mod_enchant_specify(""Armor"", ""Block_Power"") }})
variable_struct_set(_Specs, ""instruction_INS_armor_Block_Power"", {{ action: true }})";

        foreach (string eff in _armor_effs)
        {
            insertCodes += @$"
array_push(_Fragments.mod_re_runaway_enchanter_ask_which_enchantment_armor, ""mod_re_enchantment_{eff}"")
variable_struct_set(_Fragments, ""mod_re_enchantment_{eff}"", ""instruction_INS_{eff}"")
variable_struct_set(_Fragments, ""instruction_INS_{eff}"", ""@dialogue_end"")
variable_struct_set(_Scripts, ""instruction_INS_{eff}"", function() {{ scr_mod_enchant_specify(""Armor"", ""{eff}"") }})
variable_struct_set(_Specs, ""instruction_INS_{eff}"", {{ action: true }})";
        }

        insertCodes += @"
array_push(_Fragments.mod_re_runaway_enchanter_ask_which_enchantment_weapon, ""mod_re_pc_cancel"")
array_push(_Fragments.mod_re_runaway_enchanter_ask_which_enchantment_armor, ""mod_re_pc_cancel"")";

        // This allow GML struct syntax.
        Msl.LoadGML(Msl.EventName("runaway_enchanter_initializer", EventType.Other, 10))
            .MatchAll()
            .InsertBelow(insertCodes)
            .Save();

        Msl.LoadGML("gml_Object_o_dataLoader_Other_10")
            .MatchFrom("scr_dialogue_loader_init")
            .InsertBelow("with (runaway_enchanter_initializer) { event_user(0) }")
            .Save();
    }
}
