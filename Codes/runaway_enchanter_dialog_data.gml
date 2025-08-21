global.__dialogue_flow_data.runaway_enchanter =
{
    RootFragment: "runaway_enchanter",
    Monologue: false,

    Fragments:
    {
        // Leaving rotten willow
        runaway_enchanter: "condition_CND_toLeave",
        condition_CND_toLeave: ["Cnd_ToLeave_positive", "Cnd_ToLeave_negative"],
        Cnd_ToLeave_positive: "mod_re_runaway_enchanter_leave_gretting",
        mod_re_runaway_enchanter_leave_gretting: "@dialogue_end",

        // Introduction of first meet
        Cnd_ToLeave_negative: "condition_CND_firstMeet",
        condition_CND_firstMeet: ["Cnd_firstMeet_positive", "Cnd_firstMeet_negative"],
        Cnd_firstMeet_positive: "mod_re_runaway_enchanter_intro",
        mod_re_runaway_enchanter_intro: "mod_re_runaway_enchanter_pc_who",
        mod_re_runaway_enchanter_pc_who: "mod_re_runaway_enchanter_intro_2",
        mod_re_runaway_enchanter_intro_2: "mod_re_runaway_enchanter_pc_whatmagic",
        mod_re_runaway_enchanter_pc_whatmagic: "mod_re_runaway_enchanter_intro_3",
        mod_re_runaway_enchanter_intro_3: "mod_re_runaway_enchanter_pc_welldone",
        mod_re_runaway_enchanter_pc_welldone: "mod_re_runaway_enchanter_gretting",

        // Curse scroll
        Cnd_firstMeet_negative: "condition_CND_curseScroll",
        condition_CND_curseScroll: ["Cnd_curseScroll_positive", "Cnd_curseScroll_negative"],
        Cnd_curseScroll_positive: "mod_re_enchant_cursed_item_intro",
        mod_re_enchant_cursed_item_intro: "mod_re_enchant_cursed_item_intro_2",
        mod_re_enchant_cursed_item_intro_2: "mod_re_runaway_enchanter_gretting",

        // Random greeting
        Cnd_curseScroll_negative: ["mod_re_runaway_enchanter_gretting1", "mod_re_runaway_enchanter_gretting2", "mod_re_runaway_enchanter_gretting3"],
        mod_re_runaway_enchanter_gretting1: "mod_re_runaway_enchanter_gretting",
        mod_re_runaway_enchanter_gretting2: "mod_re_runaway_enchanter_gretting",
        mod_re_runaway_enchanter_gretting3: "mod_re_runaway_enchanter_gretting",

        // Miniquest
        miniquest_inquiry: "mod_re_intro_miniquest",
        mod_re_intro_miniquest: "mod_re_miniquest_pc_aqua_vitae",
        mod_re_miniquest_pc_aqua_vitae: "mod_re_intro_miniquest_aqua_vitae",
        mod_re_intro_miniquest_aqua_vitae: "mod_re_intro_miniquest_pc_whattodo",
        mod_re_intro_miniquest_pc_whattodo: "mod_re_intro_miniquest_artifacts",
        mod_re_intro_miniquest_artifacts: "mod_re_intro_miniquest_pc_what_rewards",
        mod_re_intro_miniquest_pc_what_rewards: "mod_re_intro_miniquest_extra_enchantment",
        mod_re_intro_miniquest_extra_enchantment: ["miniquest_accept", "miniquest_reject"],
        miniquest_reject: "@dialogue_end",
        miniquest_accept: "instruction_INS_startMiniquest",
        instruction_INS_startMiniquest: "@dialogue_end",
        miniquest_complete: "mod_re_check_miniquest",
        mod_re_check_miniquest: [
            "mod_re_miniquest_pc_found_gwynnel_elixir",
            "mod_re_miniquest_pc_found_cleansing_goblet",
            "mod_re_miniquest_pc_found_blessed_aquamanile",
            "mod_re_miniquest_pc_found_snake_mother"],
        mod_re_miniquest_pc_found_gwynnel_elixir: "instruction_INS_takeGwynnelElixir",
        instruction_INS_takeGwynnelElixir: "mod_re_check_miniquest_gwynnel_elixir",
        mod_re_check_miniquest_gwynnel_elixir: "instruction_INS_GwynnelElixirEffect",
        instruction_INS_GwynnelElixirEffect: "mod_re_intro_extra_enchantment",
        mod_re_intro_extra_enchantment: ["mod_re_nice_deal", "leave"],
        custom_agree: "@dialogue_end",
        mod_re_miniquest_pc_found_cleansing_goblet: "instruction_INS_takeCleansingGoblet",
        instruction_INS_takeCleansingGoblet: "mod_re_check_miniquest_cleansing_goblet",
        mod_re_check_miniquest_cleansing_goblet: "instruction_INS_questFinish",
        instruction_INS_questFinish: "mod_re_intro_extra_enchantment",
        mod_re_miniquest_pc_found_blessed_aquamanile: "instruction_INS_takeBlessedAquamanile",
        instruction_INS_takeBlessedAquamanile: "mod_re_check_miniquest_blessed_aquamanile",
        mod_re_check_miniquest_blessed_aquamanile: "instruction_INS_questFinish",
        mod_re_miniquest_pc_found_snake_mother: "instruction_INS_takeSnakeMother",
        instruction_INS_takeSnakeMother: "mod_re_check_miniquest_snake_mother",
        mod_re_check_miniquest_snake_mother: "instruction_INS_questFinish",

        // Elm's secret
        mod_re_runaway_enchanter_secret_agreement_1_pc: "mod_re_runaway_enchanter_secret_agreement_1",
        mod_re_runaway_enchanter_secret_agreement_1: "mod_re_runaway_enchanter_secret_agreement_2_pc",
        mod_re_runaway_enchanter_secret_agreement_2_pc: "mod_re_runaway_enchanter_secret_agreement_2",
        mod_re_runaway_enchanter_secret_agreement_2: "mod_re_runaway_enchanter_secret_agreement_3_pc",
        mod_re_runaway_enchanter_secret_agreement_3_pc: "mod_re_runaway_enchanter_secret_agreement_3",
        mod_re_runaway_enchanter_secret_agreement_3: "mod_re_runaway_enchanter_secret_agreement_4_pc",
        mod_re_runaway_enchanter_secret_agreement_4_pc: "mod_re_runaway_enchanter_secret_agreement_4",
        mod_re_runaway_enchanter_secret_agreement_4: "mod_re_runaway_enchanter_secret_agreement_5_pc",
        mod_re_runaway_enchanter_secret_agreement_5_pc: "mod_re_runaway_enchanter_secret_agreement_5",
        mod_re_runaway_enchanter_secret_agreement_5: "mod_re_runaway_enchanter_secret_agreement_6_pc",
        mod_re_runaway_enchanter_secret_agreement_6_pc: "instruction_INS_secretAgreement",
        instruction_INS_secretAgreement: "@dialogue_end",

        // Hub
        mod_re_runaway_enchanter_gretting: "hub",
        hub: ["instruction_INS_checkMoney", "Hub_extraEnchant", "miniquest_inquiry", "miniquest_complete", "mod_re_runaway_enchanter_secret_agreement_1_pc", "leave"],
        leave: "@dialogue_end",

        // Enchant service
        instruction_INS_checkMoney: "condition_CND_discount",
        condition_CND_discount: ["mod_re_want_to_enchant_pc_discount", "mod_re_want_to_enchant_pc"],
        mod_re_want_to_enchant_pc_discount: "instruction_INS_baseEnchant",
        mod_re_want_to_enchant_pc: "instruction_INS_baseEnchant",
        instruction_INS_baseEnchant: "mod_re_runaway_enchanter_ask_which_metatype",
        mod_re_runaway_enchanter_ask_which_metatype: ["mod_re_runaway_enchanter_pc_weapon", "mod_re_runaway_enchanter_pc_armor_or_jewelry", "mod_re_pc_cancel"],
        mod_re_pc_cancel: "mod_re_runaway_enchanter_gretting",
        mod_re_runaway_enchanter_pc_weapon: "mod_re_runaway_enchanter_ask_which_enchantment_weapon",
        mod_re_runaway_enchanter_pc_armor_or_jewelry: "mod_re_runaway_enchanter_ask_which_enchantment_armor",
        mod_re_runaway_enchanter_ask_which_enchantment_weapon: [],
        mod_re_runaway_enchanter_ask_which_enchantment_armor: [],

        // Extra enchant service
        Hub_extraEnchant: "instruction_INS_checkMoneyExtra",
        instruction_INS_checkMoneyExtra: "condition_CND_discountExtra",
        condition_CND_discountExtra: ["mod_re_want_extra_enchantment_discount", "mod_re_want_extra_enchantment"],
        mod_re_want_extra_enchantment_discount: "instruction_INS_extraEnchant",
        mod_re_want_extra_enchantment: "instruction_INS_extraEnchant",
        instruction_INS_extraEnchant: "mod_re_want_extra_enchantment_check_ruby",
        mod_re_want_extra_enchantment_check_ruby: ["mod_re_want_extra_enchantment_check_ruby_pc_1", "mod_re_want_extra_enchantment_check_ruby_pc_2"],
        mod_re_want_extra_enchantment_check_ruby_pc_2: "mod_re_runaway_enchanter_gretting",
        mod_re_want_extra_enchantment_check_ruby_pc_1: "mod_re_runaway_enchanter_ask_which_metatype"
    },

    Specs:
    {
        Cnd_ToLeave_positive: { hub: true },
        Cnd_ToLeave_negative: { hub: true },
        Cnd_firstMeet_positive: { hub: true },
        Cnd_firstMeet_negative: { hub: true },
        Cnd_curseScroll_positive: { hub: true },
        Cnd_curseScroll_negative: { hub: true, randomizer: true },
        hub: { hub: true },
        leave: { generic: true },
        custom_agree: { generic: true },
        miniquest_inquiry: { generic: true },
        miniquest_accept: { generic: true },
        miniquest_reject: { generic: true },
        miniquest_complete: { generic: true },
        instruction_INS_startMiniquest: { action: true },
        mod_re_miniquest_pc_aqua_vitae: { technical: true },
        mod_re_intro_miniquest_pc_whattodo: { technical: true },
        mod_re_intro_miniquest_pc_what_rewards: { technical: true },
        Hub_extraEnchant: { hub: true }
    },

    Scripts:
    {
        condition_CND_toLeave: function()
        {
            with (owner)
                return (time_period == 2 || time_period == 3)
        },

        condition_CND_firstMeet: function()
        {
            return scr_dialogue_uncomplete("mod_re_runaway_enchanter_intro")
        },

        condition_CND_curseScroll: function()
        {
            with (owner)
            {
                var _reputation = scr_globaltile_get("reputation", village_xy[0], village_xy[1])
                return _reputation >= 3000 && scr_quest_get_complete("mod_re_cure_elm")
                            && scr_dialogue_complete("cursescroll_ready_to_sell")
                            && scr_dialogue_uncomplete("mod_re_enchant_cursed_item_intro")
            }
        },

        embedded_miniquest_inquiry: function()
        {
            return !scr_quest_get_started("mod_re_cure_elm")
        },

        embedded_miniquest_complete: function()
        {
            return scr_quest_get_started("mod_re_cure_elm") && !scr_quest_get_complete("mod_re_cure_elm")
        },

        embedded_mod_re_runaway_enchanter_secret_agreement_1_pc: function()
        {
            return scr_mod_can_talk_secret()
        },

        instruction_INS_startMiniquest: function()
        {
            scr_mod_init_elm_quest()
            scr_mod_elm_miniquest()
        },

        instruction_INS_checkMoney: function()
        {
            scr_dialogue_set_option_lock("mod_re_want_to_enchant_pc_discount", !scr_npc_check_gold(200))
            scr_dialogue_set_option_lock("mod_re_want_to_enchant_pc", !scr_npc_check_gold(400))
        },

        instruction_INS_checkMoneyExtra: function()
        {
            scr_dialogue_set_option_lock("mod_re_want_extra_enchantment_discount", !scr_npc_check_gold(350))
            scr_dialogue_set_option_lock("mod_re_want_extra_enchantment", !scr_npc_check_gold(700))
        },

        condition_CND_discount: function()
        {
            return scr_dialogue_complete("mod_re_runaway_enchanter_secret_agreement")
        },

        condition_CND_discountExtra: function()
        {
            return scr_dialogue_complete("mod_re_runaway_enchanter_secret_agreement")
        },

        instruction_INS_baseEnchant: function()
        {
            scr_mod_elm_do_extra_enchantment(false)
        },

        embedded_Hub_extraEnchant: function()
        {
            with (owner)
            {
                var _timestamp = scr_npc_get_global_info("gwynnel_elixir_effect_timestamp")
                var _daysPassed = scr_timeGetPassed(_timestamp, 3)
            }

            if scr_quest_get_complete("mod_re_cure_elm")
                return true
            else if (_timestamp != 0 && _daysPassed < 7)
                return true
            else
                return false
        },

        instruction_INS_extraEnchant: function()
        {
            scr_mod_elm_do_extra_enchantment(true)
        },

        embedded_mod_re_want_extra_enchantment_check_ruby_pc_1: function()
        {
            return scr_instance_exists_item(o_inv_ruby)
        },

        embedded_mod_re_miniquest_pc_found_gwynnel_elixir: function()
        {
            return scr_instance_exists_item(o_inv_aqua_vitae)
        },

        instruction_INS_takeGwynnelElixir: function()
        {
            scr_delete_item(o_inv_aqua_vitae)
        },

        instruction_INS_GwynnelElixirEffect: function()
        {
            scr_mod_re_gwynnel_elixir_effect()
        },

        embedded_mod_re_miniquest_pc_found_cleansing_goblet: function()
        {
            return scr_instance_exists_item(o_inv_cleansing_goblet) || scr_instance_exists_item(o_inv_cleansing_goblet_water)
        },

        instruction_INS_takeCleansingGoblet: function()
        {
            if scr_instance_exists_item(o_inv_cleansing_goblet)
                scr_delete_item(o_inv_cleansing_goblet)
            else if scr_instance_exists_item(o_inv_cleansing_goblet_water)
                scr_delete_item(o_inv_cleansing_goblet_water)
        },

        instruction_INS_questFinish: function()
        {
            scr_quest_set_progress("mod_re_cure_elm", "mod_re_find_artifacts", 1)
            scr_quest_set_complete("mod_re_cure_elm")
        },

        embedded_mod_re_miniquest_pc_found_blessed_aquamanile: function()
        {
            return scr_instance_exists_item(o_inv_blessed_aquamanile)
        },

        instruction_INS_takeBlessedAquamanile: function()
        {
            scr_delete_item(o_inv_blessed_aquamanile)
        },

        embedded_mod_re_miniquest_pc_found_snake_mother: function()
        {
            return scr_instance_exists_item(o_inv_snake_mother)
        },

        instruction_INS_takeSnakeMother: function()
        {
            scr_delete_item(o_inv_snake_mother)
        },

        instruction_INS_secretAgreement: function()
        {
            scr_mod_secret_agreement()
        }
    },

    Speakers: 
    {
        Elm:
        [
            "mod_re_runaway_enchanter_intro",
            "mod_re_runaway_enchanter_intro_2",
            "mod_re_runaway_enchanter_intro_3",
            "mod_re_runaway_enchanter_gretting1",
            "mod_re_runaway_enchanter_gretting2",
            "mod_re_runaway_enchanter_gretting3",
            "mod_re_enchant_cursed_item_intro",
            "mod_re_enchant_cursed_item_intro_2",
            "mod_re_runaway_enchanter_gretting",
            "mod_re_intro_miniquest",
            "mod_re_intro_miniquest_aqua_vitae",
            "mod_re_intro_miniquest_artifacts",
            "mod_re_intro_miniquest_extra_enchantment",
            "mod_re_runaway_enchanter_secret_agreement_1",
            "mod_re_runaway_enchanter_secret_agreement_2",
            "mod_re_runaway_enchanter_secret_agreement_3",
            "mod_re_runaway_enchanter_secret_agreement_4",
            "mod_re_runaway_enchanter_secret_agreement_5"
        ],
        Player:
        [
            "mod_re_runaway_enchanter_pc_who",
            "mod_re_runaway_enchanter_pc_whatmagic",
            "mod_re_runaway_enchanter_pc_welldone",
            "mod_re_miniquest_pc_aqua_vitae",
            "mod_re_intro_miniquest_pc_whattodo",
            "mod_re_intro_miniquest_pc_what_rewards",
            "mod_re_runaway_enchanter_secret_agreement_1_pc",
            "mod_re_runaway_enchanter_secret_agreement_2_pc",
            "mod_re_runaway_enchanter_secret_agreement_3_pc",
            "mod_re_runaway_enchanter_secret_agreement_4_pc",
            "mod_re_runaway_enchanter_secret_agreement_5_pc",
            "mod_re_runaway_enchanter_secret_agreement_6_pc"
        ]
    }
}

var _weapon_effs = [
    "Lifesteal", "Manasteal", "Bleeding_Chance", "Daze_Chance", "Stun_Chance", "Knockback_Chance",
    "Fire_Damage", "Frost_Damage", "Poison_Damage", "Shock_Damage", "Caustic_Damage", "Weapon_Damage",
    "Armor_Damage", "Bodypart_Damage", "Magic_Power", "Skills_Energy_Cost", "Spells_Energy_Cost",
    "Cooldown_Reduction", "PRR", "Block_Power", "CTA", "Hit_Chance", "CRT", "CRTD", "FMB", "Armor_Piercing"
]

var _Fragments = variable_struct_get(global.__dialogue_flow_data.runaway_enchanter, "Fragments")
var _Scripts = variable_struct_get(global.__dialogue_flow_data.runaway_enchanter, "Scripts")
var _Specs = variable_struct_get(global.__dialogue_flow_data.runaway_enchanter, "Specs")
