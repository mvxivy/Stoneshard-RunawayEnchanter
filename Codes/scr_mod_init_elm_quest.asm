.localvar 0 arguments

:[0]
b [4]

> gml_Script_scr_mod_init_elm_quest (locals=0, argc=0)
:[1]
push.s "mod_re_cure_elm"
conv.s.v
call.i gml_Script_scr_quest_get(argc=1)
conv.v.b
not.b
bf [3]

:[2]
push.s "mod_re_cure_elm"
conv.s.v
push.i gml_Script_QuestDefinition
conv.i.v
call.i @@NewGMLObject@@(argc=2)
push.s "mod_re_find_artifacts"
conv.s.v
dup.v 1 8
dup.v 0
push.v stacktop.Task
callv.v 1
push.s "mod_re_find_artifacts_desc"
conv.s.v
dup.v 1 8
dup.v 0
push.v stacktop.SetDescription
callv.v 1
dup.v 0 8
dup.v 0
push.v stacktop.Register
callv.v 0
popz.v

:[3]
exit.i

:[4]
push.i gml_Script_scr_mod_init_elm_quest
conv.i.v
pushi.e -1
conv.i.v
call.i method(argc=2)
dup.v 0
pushi.e -6
pop.v.v [stacktop]self.scr_mod_init_elm_quest
popz.v

:[end]
