using ModShardLauncher;
using ModShardLauncher.Mods;

namespace RunawayEnchanter;
public static class Localization
{
    public static void PatchDialogs()
    {
        Msl.InjectTableDialogLocalization(
            new LocalizationSentence(
                id: "mod_re_pc_cancel",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Forget it, I've changed my mind."},
                    {ModLanguage.Chinese, "算了，我改主意了。"},
                    {ModLanguage.Russian, "Забудь об этом, я передумал."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_intro",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "*Looking visibly anxious* ...... A bastard of the Order?#... No, that... hic... never mind, don't interrupt me while I'm drinking."},
                    {ModLanguage.Chinese, "*神情明显慌张起来*......三手会的杂种？#...不是，那...嗝...没事别打扰我喝酒。"},
                    {ModLanguage.Russian, "*Выглядит очень встревоженно* ...... Выродок Ордена?#... Нет, это... *икает*... никогда, не отвлекай меня во время питья."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_who",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What do you do?"},
                    {ModLanguage.Chinese, "你是做什么的？"},
                    {ModLanguage.Russian, "Чем ты занимаешься?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_intro_2",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What do I do? hic... A magician, um, just like that..."},
                    {ModLanguage.Chinese, "做什么的？嗝...魔法师，嗯，就这样..."},
                    {ModLanguage.Russian, "Чем я занимаюсь? *икает*... Магией, хм, просто магией..."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_whatmagic",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What kind of magic do you know?"},
                    {ModLanguage.Chinese, "你会什么魔法？"},
                    {ModLanguage.Russian, "Какую магию ты знаешь?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_intro_3",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "*Glances at you*#You look like a mercenary. I know some magic that can strengthen equipment.#If you can pay some crowns, I can give you a more precise and stronger enchantment."},
                    {ModLanguage.Chinese, "*瞟了你一眼*#你看着像个雇佣兵，我会些能加强装备的魔法。#你如果能掏点钱，我可以给你更准更强的附魔。"},
                    {ModLanguage.Russian, "*Смотрит на тебя*#Ты похож на наёмника. Я знаю магию, которая усиливает снаряжение.#Если ты заплатишь чеканной кроной, я сделаю для тебя точное и сильное зачарование."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_welldone",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "That's great."},
                    {ModLanguage.Chinese, "那可真不错。"},
                    {ModLanguage.Russian, "Это просто великолепно."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_who",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Who are you?"},
                    {ModLanguage.Chinese, "你是谁？"},
                    {ModLanguage.Russian, "Кто ты?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_gretting1",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Ding ding-ding, two kinds of magic colliding... Oh-it's you."},
                    {ModLanguage.Chinese, "铛铛-铛，两种魔法碰在一起...噢-是你啊。"},
                    {ModLanguage.Russian, "Динь динь-динь, два вида магии сталкиваются... О-это ты."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_gretting2",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Hiding here... hic... isn't exactly great-heh..."},
                    {ModLanguage.Chinese, "在这躲着...嗝...也不是个事-呵......"},
                    {ModLanguage.Russian, "Прячусь здесь... икс... Это не хоро.. хорошо-хе..."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_gretting3",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What Fires of Providence... skeletons-oh... hic... a bottle of brandy would be much better!"},
                    {ModLanguage.Chinese, "什么天火...骸骨-哦...嗝...不如一瓶白兰地来的实在！"},
                    {ModLanguage.Russian, "Какие Адские Огни... скелеты - оу... *икает* бутылка коньяка была бы намного лучше!"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_leave_gretting",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I... I have to go... let's talk next time, okay? hic..."},
                    {ModLanguage.Chinese, "我...我得走了...下、下次再聊啊...嗝..."},
                    {ModLanguage.Russian, "Я... я должен уходить... поговорим в следующий раз, хорошо? *икает*"}
                }
            ),

            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_1_pc",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Guess what I found?"},
                    {ModLanguage.Chinese, "你猜我找到了什么？"},
                    {ModLanguage.Russian, "Угадай, что я нашёл?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_1",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Hey, hey, don't... hic... tease me, just... just say it!"},
                    {ModLanguage.Chinese, "哎哎，别、别卖...嗝...关子了，你就...你就直说吧！"},
                    {ModLanguage.Russian, "Эй, эй, не... *икает*... не дразни меня, просто... просто скажи!"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_2_pc",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I happened to go to the abandoned Order's Prison and found some letters. You remember Commander Lei... Mff..."},
                    {ModLanguage.Chinese, "我偶然去到了废弃的教会监狱，找到了一些信件。你还记得指挥官列伊...唔..."},
                    {ModLanguage.Russian, "Я заглянул было в заброшенную Тюрьму Ордена и нашёл письма. Ты помнишь Командира Лея... Мм..."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_2",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "*Looking terrified, quickly covers my mouth*#Don't say that, my ancestor! I beg you!"},
                    {ModLanguage.Chinese, "*神情惊恐，连忙捂住我的嘴*#别说了，我的老祖宗！算我求求你了！"},
                    {ModLanguage.Russian, "*Выглядит испуганно, быстро закрывает рот*#Не говори этого, старина! Умоляю тебя!"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_3_pc",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Well... I won't talk about it. But how did you get caught in... that place?"},
                    {ModLanguage.Chinese, "好...我不说了。可是，你怎么会被抓进...那个地方？"},
                    {ModLanguage.Russian, "Ладно... я не буду об этом говорить. Но как ты попал в... то место?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_3",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "It's not something I can explain right now. They want... forbidden knowledge... we can talk when there's a chance. Can you help me keep this secret? I barely escaped from that hell..."},
                    {ModLanguage.Chinese, "这一时半会儿说不清楚，他们想要...禁忌之识...有机会再聊吧。你能帮我保守这个秘密吗？我好不容易逃出了那个地狱..."},
                    {ModLanguage.Russian, "Я не могу говорить об этом сейчас. Они хотели... запретные знания... мы поговорим, когда будет возможность. Ты можешь помочь мне хранить это в секрете? Я едва вырвался из того ада..."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_4_pc",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Yes, I can. What's in it for me?"},
                    {ModLanguage.Chinese, "可以，那我有什么好处呢？"},
                    {ModLanguage.Russian, "Да, могу. Что я получу взамен?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_4",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "When you come to me for enchantments, how about I give you a 50% discount?"},
                    {ModLanguage.Chinese, "以后你来我这附魔，我给你打五折怎么样？"},
                    {ModLanguage.Russian, "Когда ты приходишь ко мне за заклинаниями, что если я дам тебе скидку 50%?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_5_pc",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "And that's the end? Then I'll have to yell a few times."},
                    {ModLanguage.Chinese, "这就把我打发了？那我可得嚷嚷几句了。"},
                    {ModLanguage.Russian, "И это всё? Тогда мне нужно будет немного покричать."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_5",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Stop! I'll give you ~/~1000 crowns~/~, just don't tell anyone!"},
                    {ModLanguage.Chinese, "别！我再给你~y~1000冠~/~，你千万别往外说！"},
                    {ModLanguage.Russian, "Стоп! Я дам тебе ~/~1000 монет~/~, просто не говори никому!"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_secret_agreement_6_pc",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Okay, I'll keep it a secret."},
                    {ModLanguage.Chinese, "行，我会保守这个秘密。"},
                    {ModLanguage.Russian, "Хорошо, я буду хранить это в тайне."}
                }
            ),

            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_gretting",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "hic... Is there something?"},
                    {ModLanguage.Chinese, "嗝...有事吗？"},
                    {ModLanguage.Russian, "*икает*... Что-то нужно?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_want_to_enchant_pc",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I want to enchant an item. ~y~[400 crowns]~/~"},
                    {ModLanguage.Chinese, "我想要为物品附魔。~y~[400冠]~/~"},
                    {ModLanguage.Russian, "Я хочу наложить заклинание на предмет. ~y~[400 монет]~/~"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_want_to_enchant_pc_discount",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I want to enchant an item. ~y~[200 crowns]~/~"},
                    {ModLanguage.Chinese, "我想要为物品附魔。~y~[200冠]~/~"},
                    {ModLanguage.Russian, "Я хочу наложить заклинание на предмет. ~y~[200 монет]~/~"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_want_extra_enchantment",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I want to add an extra enchantment to enchanted items. ~y~[700 crowns]~/~"},
                    {ModLanguage.Chinese, "我想要为附魔物品追加额外附魔。~y~[700冠]~/~"},
                    {ModLanguage.Russian, "Я хочу добавить дополнительное заклинание к уже заколдованному предмету. ~y~[700 монет]~/~"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_want_extra_enchantment_discount",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I want to add an extra enchantment to enchanted items. ~y~[350 crowns]~/~"},
                    {ModLanguage.Chinese, "我想要为附魔物品追加额外附魔。~y~[350冠]~/~"},
                    {ModLanguage.Russian, "Я хочу добавить дополнительное заклинание к уже заколдованному предмету. ~y~[350 монет]~/~"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_want_extra_enchantment_check_ruby",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Do you have the ruby? It's needed for the secondary enchantment."},
                    {ModLanguage.Chinese, "红宝石带了吗？二次附魔需要用到它。"},
                    {ModLanguage.Russian, "У тебя есть рубин? Он нужен для вторичного заклинания."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_want_extra_enchantment_check_ruby_pc_1",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I brought a ruby."},
                    {ModLanguage.Chinese, "我带了红宝石。"},
                    {ModLanguage.Russian, "Я принёс рубин."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_want_extra_enchantment_check_ruby_pc_2",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I forgot, so next time."},
                    {ModLanguage.Chinese, "我忘了，那下次再说吧。"},
                    {ModLanguage.Russian, "Я забыл, в следующий раз."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_ask_which_metatype",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What type of item do you want to enchant?"},
                    {ModLanguage.Chinese, "什么类型的东西需要附魔？"},
                    {ModLanguage.Russian, "Какой тип предмета ты хочешь заколдовать?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_weapon",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Weapon."},
                    {ModLanguage.Chinese, "兵器。"},
                    {ModLanguage.Russian, "Оружие."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_armor_or_jewelry",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Armor or jewelry."},
                    {ModLanguage.Chinese, "防具或首饰。"},
                    {ModLanguage.Russian, "Броня или украшения."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_ask_which_enchantment_weapon",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Weapon? Heh... Which attribute would you like to add to the item?"},
                    {ModLanguage.Chinese, "兵器？呵...想要什么样的附魔？"},
                    {ModLanguage.Russian, "Оружие? Хе... Какой атрибут ты хочешь добавить к предмету?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_ask_which_enchantment_armor",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Armor? jewelry? Heh... Which attribute would you like to add to the item?"},
                    {ModLanguage.Chinese, "防具？首饰？呵...想要什么样的附魔？"},
                    {ModLanguage.Russian, "Броня? Украшения? Хе... Какой атрибут ты хочешь добавить к предмету?"}
                }
            ),

            // Enchantments
            new LocalizationSentence(
                id: "mod_re_enchantment_weapon_Block_Power",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Block Power."},
                    {ModLanguage.Chinese, "格挡力量。"},
                    {ModLanguage.Russian, "Сила блока."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_armor_Block_Power",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Block Power."},
                    {ModLanguage.Chinese, "格挡力量。"},
                    {ModLanguage.Russian, "Сила блока."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Caustic_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Caustic Damage."},
                    {ModLanguage.Chinese, "腐蚀伤害。"},
                    {ModLanguage.Russian, "Разъедающий урон."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Fire_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Fire Damage."},
                    {ModLanguage.Chinese, "灼烧伤害。"},
                    {ModLanguage.Russian, "Урон огнём."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Frost_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Frost Damage."},
                    {ModLanguage.Chinese, "霜冻伤害。"},
                    {ModLanguage.Russian, "Урон холодом."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Poison_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Poison Damage."},
                    {ModLanguage.Chinese, "中毒伤害。"},
                    {ModLanguage.Russian, "Урон ядом."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Shock_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Shock Damage."},
                    {ModLanguage.Chinese, "电击伤害。"},
                    {ModLanguage.Russian, "Урон электричеством."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Hit_Chance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Accuracy."},
                    {ModLanguage.Chinese, "准度。"},
                    {ModLanguage.Russian, "Точность."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Armor_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Armor Damage."},
                    {ModLanguage.Chinese, "护甲破坏。"},
                    {ModLanguage.Russian, "Урон по броне."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Armor_Piercing",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Armor Penetration."},
                    {ModLanguage.Chinese, "护甲穿透。"},
                    {ModLanguage.Russian, "Пробитие брони."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Bleeding_Chance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Bleed Chance."},
                    {ModLanguage.Chinese, "出血几率。"},
                    {ModLanguage.Russian, "Шанс кровотечения."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_PRR",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Block Chance."},
                    {ModLanguage.Chinese, "格挡几率。"},
                    {ModLanguage.Russian, "Шанс блока."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Bodypart_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Bodypart Damage."},
                    {ModLanguage.Chinese, "肢体伤害。"},
                    {ModLanguage.Russian, "Травмирующий урон."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Cooldown_Reduction",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Cooldowns Duration."},
                    {ModLanguage.Chinese, "冷却时间。"},
                    {ModLanguage.Russian, "Длительность перезарядки."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_CTA",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Counter Chance."},
                    {ModLanguage.Chinese, "反击几率。"},
                    {ModLanguage.Russian, "Шанс контрудара."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_CRT",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Crit Chance."},
                    {ModLanguage.Chinese, "暴击几率。"},
                    {ModLanguage.Russian, "Шанс крита."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_CRTD",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Crit Efficiency."},
                    {ModLanguage.Chinese, "暴击效果。"},
                    {ModLanguage.Russian, "Эффективность критов."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Daze_Chance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Daze Chance."},
                    {ModLanguage.Chinese, "击晕几率。"},
                    {ModLanguage.Russian, "Шанс ошеломления."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Manasteal",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Energy Drain."},
                    {ModLanguage.Chinese, "精力吸取。"},
                    {ModLanguage.Russian, "Похищение энергии."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_FMB",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Fumble Chance."},
                    {ModLanguage.Chinese, "失手几率。"},
                    {ModLanguage.Russian, "Шанс неудачи."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Knockback_Chance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Knockback Chance."},
                    {ModLanguage.Chinese, "击退几率。"},
                    {ModLanguage.Russian, "Шанс отбрасывания."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Lifesteal",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Life Drain."},
                    {ModLanguage.Chinese, "生命吸取。"},
                    {ModLanguage.Russian, "Похищение жизни."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Magic_Power",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Magic Power."},
                    {ModLanguage.Chinese, "法力。"},
                    {ModLanguage.Russian, "Сила магии."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Skills_Energy_Cost",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Skills Energy Cost."},
                    {ModLanguage.Chinese, "技能精力消耗。"},
                    {ModLanguage.Russian, "Затраты на умения."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Spells_Energy_Cost",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Spells Energy Cost."},
                    {ModLanguage.Chinese, "咒法精力消耗。"},
                    {ModLanguage.Russian, "Стоимость энергии заклинаний."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Stun_Chance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Stun Chance."},
                    {ModLanguage.Chinese, "硬直几率。"},
                    {ModLanguage.Russian, "Шанс оглушения."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Weapon_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Weapon Damage."},
                    {ModLanguage.Chinese, "兵器伤害。"},
                    {ModLanguage.Russian, "Урон оружия."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_HP",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Health."},
                    {ModLanguage.Chinese, "生命。"},
                    {ModLanguage.Russian, "Здоровье."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_MP",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Energy."},
                    {ModLanguage.Chinese, "精力。"},
                    {ModLanguage.Russian, "Энергия."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Health_Restoration",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Health Restoration."},
                    {ModLanguage.Chinese, "生命自动恢复。"},
                    {ModLanguage.Russian, "Регенерация здоровья."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_MP_Restoration",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Energy Restoration."},
                    {ModLanguage.Chinese, "精力自动恢复。"},
                    {ModLanguage.Russian, "Регенерация энергии."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_EVS",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Dodge Chance."},
                    {ModLanguage.Chinese, "闪躲几率。"},
                    {ModLanguage.Russian, "Шанс уклонения."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Knockback_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Move Resistance."},
                    {ModLanguage.Chinese, "位移抗性。"},
                    {ModLanguage.Russian, "Сопротивление перемещению."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Stun_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Control Resistance."},
                    {ModLanguage.Chinese, "控制抗性。"},
                    {ModLanguage.Russian, "Сопротивление контролю."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Magic_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Magic Resistance."},
                    {ModLanguage.Chinese, "魔法抗性。"},
                    {ModLanguage.Russian, "Сопротивление магии."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Nature_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Nature Resistance."},
                    {ModLanguage.Chinese, "自然抗性。"},
                    {ModLanguage.Russian, "Сопротивление силам природы."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Pain_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Pain Resistance."},
                    {ModLanguage.Chinese, "疼痛抗性。"},
                    {ModLanguage.Russian, "Сопротивление боли."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Physical_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Physical Resistance."},
                    {ModLanguage.Chinese, "物理抗性。"},
                    {ModLanguage.Russian, "Сопротивление физ. урону."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Piercing_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Piercing Resistance."},
                    {ModLanguage.Chinese, "穿刺抗性。"},
                    {ModLanguage.Russian, "Сопротивление колющему урону."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Slashing_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Slashing Resistance."},
                    {ModLanguage.Chinese, "劈砍抗性。"},
                    {ModLanguage.Russian, "Сопротивление рубящему урону."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Rending_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Rending Resistance."},
                    {ModLanguage.Chinese, "撕裂抗性。"},
                    {ModLanguage.Russian, "Сопротивление разрыву."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Blunt_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Crushing Resistance."},
                    {ModLanguage.Chinese, "钝击抗性。"},
                    {ModLanguage.Russian, "Сопротивление дробящему урону."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Unholy_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Unholy Resistance."},
                    {ModLanguage.Chinese, "邪术抗性。"},
                    {ModLanguage.Russian, "Сопротивление нечистивому урону."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Fortitude",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Fortitude."},
                    {ModLanguage.Chinese, "坚忍。"},
                    {ModLanguage.Russian, "Стойкость."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Healing_Received",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Healing Efficiency."},
                    {ModLanguage.Chinese, "治疗效果。"},
                    {ModLanguage.Russian, "Эффективность лечения."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Bleeding_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Bleed Resistance."},
                    {ModLanguage.Chinese, "出血抗性。"},
                    {ModLanguage.Russian, "Сопротивление кровотечению."}
                }
            ),

            // Miniquest
            new LocalizationSentence(
                id: "mod_re_intro_miniquest",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Is there something you need to do? hic... My limbs are in excruciating pain for a while every day... I can't handle many delicate enchantment tasks.#At night, I'm tormented by nightmares... It's like my body has been cursed."},
                    {ModLanguage.Chinese, "有什么要你噶-干的？嗝...我的四肢每天有段时间会剧痛无比...很多精细的附魔活计都干不了。#我晚上还会受到...收-受梦魇折磨...就像我全身被诅咒了一样。"},
                    {ModLanguage.Russian, "Тебе нужна помощь? *икает*... Мои конечности испытывают мучительную боль каждый день... Я не могу справиться со многими деликатными задачами заклинания. По ночам меня мучают кошмары... Будто мое тело проклято."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_miniquest_pc_aqua_vitae",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Have you tried Gwynnel's Elixir?"},
                    {ModLanguage.Chinese, "你有试过葛文涅尔的灵药吗？"},
                    {ModLanguage.Russian, "Пробовал ли ты эликсир Гвиннела?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_intro_miniquest_aqua_vitae",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "The Gavenli-Ner Elixir? Of-af course, I've tried it... heh-it's quite effective... hic... but it only lets me feel good for a week, and then... the problem returns. Although this elixir tastes quite good."},
                    {ModLanguage.Chinese, "葛文离-涅尔的灵药？当-然-当然试过...呵-很有效果...嗝...但它只能让我轻松一周，之后-后-毛病又会找上我...但这灵药味道倒是不错。"},
                    {ModLanguage.Russian, "Эликсир Гаванди-Нера? К-конечно, я пробовал... хе-это весьма эффективно... *икает*... но эффект временный, хорошее самочувствие примерно неделю, а потом... проклятье возвращается. Хотя этот эликсир довольно вкусненький."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_intro_miniquest_pc_whattodo",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What then?"},
                    {ModLanguage.Chinese, "那怎么办？"},
                    {ModLanguage.Russian, "Что тогда?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_intro_miniquest_artifacts",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Oh, I've heard that the ~y~Cleansing Chalice~/~... hic... the ~y~Blessed Aquamanile~/~... or the ~y~Foremother of Snakes Statuette~/~ can cure my illness. If I could use one of these artifacts every day... my suffering would finally end."},
                    {ModLanguage.Chinese, "喔-我听说~y~涤罪圣杯~/~...嗝...~y~庇佑水器~/~...嚯-或者~y~蛇母雕像~/~能治疗我的病。要是能每天用一用这些文物...盛-呵-这一切就完了。"},
                    {ModLanguage.Russian, "О, я слышал, что ~y~Чаша очищения~/~... икс... ~y~Благословлённый сосуд для воды~/~... или ~y~Статуэтка матери змей~/~ может вылечить мою болезнь. Если бы я мог использовать один из этих артефактов каждый день... мои страдания наконец бы закончились."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_intro_miniquest_pc_what_rewards",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What do I get if I do you this big favour?"},
                    {ModLanguage.Chinese, "要是帮了你这大忙，我能得到什么？"},
                    {ModLanguage.Russian, "Что я получу, если помогу тебе с такой большой услугой?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_intro_miniquest_extra_enchantment",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Haha... do you want to add another enchantment to an enchanted item, hmm? Hehe, my body has been tormented by pain... uh, my brain isn't working, I can't focus on complex spellwork. But if you help me find one of these artifacts, I'll teach you the art of secondary enchantment."},
                    {ModLanguage.Chinese, "哈哈...你..你想不想为附魔物品再附个魔，嗯？嘿嘿，我、我这身体啊，被病痛折腾得...唔，脑子都不管用了，没法专注于复杂的咒术。但你要是能帮我找到这些文物中的一件，我就传授你二次附魔的秘诀。"},
                    {ModLanguage.Russian, "Ха-ха... хочешь ли ты добавить ещё одно зачарование к уже зачарованному предмету? Хе-хе, моё тело измучено болью... угх, голова не работает, я не могу сосредоточиться на сложных заклинаниях. Но если ты поможешь мне найти один из этих артефактов, я научу тебя искусству вторичного зачарования."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_check_miniquest",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Oh? What did yoo-you find?"},
                    {ModLanguage.Chinese, "哦？你...你找着啥了？"},
                    {ModLanguage.Russian, "О? Чч-что ты нашёл?"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_miniquest_pc_found_gwynnel_elixir",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Gwynnel's Elixir."},
                    {ModLanguage.Chinese, "葛文涅尔的灵药。"},
                    {ModLanguage.Russian, "Эликсир Гвиннела."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_miniquest_pc_found_cleansing_goblet",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Cleansing Chalice."},
                    {ModLanguage.Chinese, "涤罪圣杯。"},
                    {ModLanguage.Russian, "Чаша очищения."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_miniquest_pc_found_blessed_aquamanile",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Blessed Aquamanile."},
                    {ModLanguage.Chinese, "庇佑水器。"},
                    {ModLanguage.Russian, "Благословлённый сосуд для воды."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_miniquest_pc_found_snake_mother",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Foremother of Snakes Statuette."},
                    {ModLanguage.Chinese, "蛇母雕像。"},
                    {ModLanguage.Russian, "Статуэтка матери змей."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_miniquest_pc_regret",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Never mind, I haven't found anything yet."},
                    {ModLanguage.Chinese, "算了，我什么都还没找到。"},
                    {ModLanguage.Russian, "Забудь об этом, я ничего не нашёл."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_check_miniquest_gwynnel_elixir",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Haha... you actually found... a elixir? Quick... quick, bring it to me!#*Drinks the elixir in one gulp, instantly relaxing*#Looks like I'll be at ease for a while. Thank you, my friend!"},
                    {ModLanguage.Chinese, "哈哈...你、你居然找着了...一瓶灵药？快...快给我拿过来！#*一口把灵药喝下肚，神色马上轻松下来*#看来我能轻松一阵子了。谢谢你，我的朋友！"},
                    {ModLanguage.Russian, "Ха-ха... ты действительно нашёл... эликсир? Быстро... быстро отдай его мне!#*Выпивает эликсир залпом, сразу же расслабляясь*#Похоже, я смогу отдохнуть некоторое время. Спасибо тебе, мой друг!"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_intro_extra_enchantment",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Alright, you've really helped me a lot! As agreed, I will provide you with secondary enchantment services. But remember to bring a ruby every time you come. That gem is crucial for the secondary enchantment process."},
                    {ModLanguage.Chinese, "好了，你真是帮了我大忙！按照约定，我将为你提供二次附魔服务。但每次来的时候记得带一颗红宝石，这玩意儿是二次附魔的关键。"},
                    {ModLanguage.Russian, "Хорошо, ты действительно мне помог! Как и договаривались, я буду помогу тебе с вторичным зачарованием. Но запомни: нужен рубин. Этот самоцвет ключ для процесса вторичного зачарования."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_check_miniquest_cleansing_goblet",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Oh, Fires of Providence! Is that... the ~y~Cleansing Chalice~/~? Where did you find it? I heard it was... stolen long ago from... that place, the High Hierarchy."},
                    {ModLanguage.Chinese, "天、天火啊！竟、竟然是那什么...涤、~y~涤罪圣杯~/~？你...你哪儿找来的？我听说..早、早就让人从...那个啥，至、至高等级偷走了。"},
                    {ModLanguage.Russian, "О, Адские огни! Это... ~y~Чаша очищения~/~? Где ты её нашёл? Я слышал, что... её украли давно из... того места, Высшей иерархии."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_check_miniquest_blessed_aquamanile",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Oh, Skeleton! Isn't this... the ~y~Blessed Aquamanile~/~? You actually found this thing! Quick... quick, give it to me... let me try... the water in the vessel might hold the power to cure me."},
                    {ModLanguage.Chinese, "骸、骸骨啊！这、这不是...~y~庇佑水器~/~吗？你、你居然能...找到这玩意儿！快...快拿给我...让我试试...水壶里的水可能就能治好我。"},
                    {ModLanguage.Russian, "О, скелет! Это... ~y~Благословлённый сосуд для воды~/~? Ты действительно нашёл эту штуку! Быстро... быстро отдай её мне... дай мне попробовать... вода в сосуде может обладать силой исцелить меня."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_check_miniquest_snake_mother",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "You found... the ~y~Foremother of Snakes Statuette~/~? This is... an ancient treasure!#Quick... quick, bring it to me so I can... pray to the goddess, hehe!#*Gazes at the statuette with reverence*#Perhaps... perhaps this will finally free me from my curse."},
                    {ModLanguage.Chinese, "你、你居然找到...蛇、~y~蛇母雕像~/~？这可是个...远古的宝贝啊！#快...快拿来，让我...向女神祈祷一下，嘿嘿！#*故作虔诚地凝视着雕像*#也许...也许这样我终于能摆脱诅咒了。"},
                    {ModLanguage.Russian, "Ты нашёл... ~y~Статуэтку матери змей~/~? Это... древний артефакт! Быстро... быстро отдай его мне, чтобы я мог... помолиться богине, хе-хе!#*С благоговением смотрит на статуэтку*#Может быть... может быть, это наконец освободит меня от проклятия."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchant_cursed_item_intro",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "You're here? Thanks to you, l'Owcrey have recently created some cursed scrolls. I also got inspired and figured out how to handle the chaotic magical powers within cursed items. I can now enchant cursed equipment with custom spells!"},
                    {ModLanguage.Chinese, "你来了？多亏了你的福，最近埃欧科里搞出了什么诅咒卷轴。我也得到了灵感，搞清楚了如何处理诅咒物品中混乱的魔法力量。我现在可以用定制的咒法来附魔诅咒装备了！"},
                    {ModLanguage.Russian, "Ты пришёл? Благодаря тебе, Л'Оукри недавно создал проклятые свитки. Я тоже вдохновился и разобрался, как совладать с магией хаоса внутри проклятых предметов. Теперь я могу зачаровать проклятое снаряжение особыми свойствами!"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchant_cursed_item_intro_2",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "If you have any needs for custom enchantments on cursed equipment in the future, feel free to come to me."},
                    {ModLanguage.Chinese, "你以后要是对诅咒装备有什么定制附魔的需求，也可以来找我。"},
                    {ModLanguage.Russian, "Если в будущем тебе понадобятся специальные зачарования для проклятого оборудования, приходи ко мне."}
                }
            ),
            
            new LocalizationSentence(
                id: "mod_re_nice_deal",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Deal."},
                    {ModLanguage.Chinese, "行。"},
                    {ModLanguage.Russian, "По рукам."}
                }
            )
        );
    }

    public static void PatchQeusts()
    {
        List<string> stringList = new List<string>();

        string id = "mod_re_cure_elm";
        string text_en = @"Cure Elm";
        string text_zh = @"治疗埃尔姆";
        string text_ru = @"Вылечить Эльма";
        stringList.Add($"{id};{text_en};{text_en};{text_zh};{text_ru};" + string.Concat(Enumerable.Repeat($"{text_en};", 8)));

        id = "mod_re_find_artifacts";
        text_en = @"Find elixirs or artifacts";
        text_zh = @"寻找灵药或文物";
        text_ru = @"Найти эликсиры или артефакты";
        stringList.Add($"{id};{text_en};{text_en};{text_zh};{text_ru};" + string.Concat(Enumerable.Repeat($"{text_en};", 8)));

        id = "mod_re_find_artifacts_desc";
        text_en = @"Master Enchanter Elm experiences severe pains in his limbs for a period of time each day and is affected by nightmares at night, causing him to have less energy to perform his more sophisticated enchantment work. Help him find one of the artifacts or elixirs he needs.";
        text_zh = @"附魔大师埃尔姆每天都有段时间会感到四肢剧痛，并且夜间会受到梦魇影响，导致他精力不济，无法施展更加精湛的附魔手艺。如果你能帮助他找到需要的文物或灵药之一，他会很感激。";
        text_ru = @"Мастер-чародей Эльм испытывает сильную боль в своих конечностях в течение определённого времени каждый день и страдает от кошмаров по ночам, что мешает ему полноценно заниматься своим весьма сложным магическим ремеслом. Помогите ему найти один из необходимых артефактов или эликсиров.";
        stringList.Add($"{id};{text_en};{text_en};{text_zh};{text_ru};" + string.Concat(Enumerable.Repeat($"{text_en};", 8)));

        string questend = ";" + string.Concat(Enumerable.Repeat("text_end;", 12));

        List<string> quest_table = ModLoader.GetTable("gml_GlobalScript_table_quests");
        quest_table.InsertRange(quest_table.IndexOf(questend), stringList);
        ModLoader.SetTable(quest_table, "gml_GlobalScript_table_quests");
    }

    public static void PatchNames()
    {
        // Msl.InjectTableOccupationNamesLocalization(
        //     new LocalizationOccupationName(
        //         id: "npc_runaway_enchanter",
        //         name: new Dictionary<ModLanguage, string>{
        //             {ModLanguage.English, "Elm"},
        //             {ModLanguage.Chinese, "埃尔姆"}
        //         }
        //     )
        // );

        List<string> stringList = new List<string>();

        string id = "npc_runaway_enchanter";
        string text_en = "Elm";
        string text_zh = "埃尔姆";
        string text_ru = "Эльм";
        stringList.Add($"{id};{text_en};{text_en};{text_zh};{text_ru};" + string.Concat(Enumerable.Repeat($"{text_en};", 8)));

        string npc_info_end = string.Concat(Enumerable.Repeat("NPC_info_end;", 13));

        List<string> npcnames_table = ModLoader.GetTable("gml_GlobalScript_table_names");
        npcnames_table.InsertRange(npcnames_table.IndexOf(npc_info_end), stringList);
        ModLoader.SetTable(npcnames_table, "gml_GlobalScript_table_names");
    }
}
