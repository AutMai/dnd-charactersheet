INSERT INTO `backgrounds`
VALUES (1, 'Noble', 'History, Persuasion');
INSERT INTO `backgrounds`
VALUES (2, 'Soldier', 'Athletics, Intimidation');
INSERT INTO `classes`
VALUES (1, 'Wizard',
        'Clad in the silver robes that denote her station, an elf closes her eyes to shut out the distractions of the battlefield and begins her quiet chant. Fingers weaving in front of her, she completes her spell and launches a tiny bead of fire toward the enemy ranks, where it erupts into a conflagration that engulfs the soldiers.\n\nChecking and rechecking his work, a human scribes an intricate magic circle in chalk on the bare stone floor, then sprinkles powdered iron along every line and graceful curve. When the circle is complete, he drones a long incantation. A hole opens in space inside the circle, bringing a whiff of brimstone from the otherworldly plane beyond.\n\nCrouching on the floor in a dungeon intersection, a gnome tosses a handful of small bones inscribed with mystic symbols, muttering a few words of power over them. Closing his eyes to see the visions more clearly, he nods slowly, then opens his eyes and points down the passage to his left.\n\nWizards are supreme magic-users, defined and united as a class by the spells they cast. Drawing on the subtle weave of magic that permeates the cosmos, wizards cast spells of explosive fire, arcing lightning, subtle deception, and brute-force mind control. Their magic conjures monsters from other planes of existence, glimpses the future, or turns slain foes into zombies. Their mightiest spells change one substance into another, call meteors down from the sky, or open portals to other worlds.',
        6);
INSERT INTO `classes`
VALUES (2, 'Rogue',
        'Signaling for her companions to wait, a halfling creeps forward through the dungeon hall. She presses an ear to the door, then pulls out a set of tools and picks the lock in the blink of an eye. Then she disappears into the shadows as her fighter friend moves forward to kick the door open.\n\nA human lurks in the shadows of an alley while his accomplice prepares for her part in the ambush. When their target — a notorious slaver — passes the alleyway, the accomplice cries out, the slaver comes to investigate, and the assassin’s blade cuts his throat before he can make a sound.\n\nSuppressing a giggle, a gnome waggles her fingers and magically lifts the key ring from the guard’s belt. In a moment, the keys are in her hand, the cell door is open, and she and her companions are free to make their escape.\n\nRogues rely on skill, stealth, and their foes’ vulnerabilities to get the upper hand in any situation. They have a knack for finding the solution to just about any problem, demonstrating a resourcefulness and versatility that is the cornerstone of any successful adventuring party.',
        8);
INSERT INTO `e_ability_names`
VALUES ('STRENGTH');
INSERT INTO `e_ability_names`
VALUES ('DEXTERITY');
INSERT INTO `e_ability_names`
VALUES ('CONSTITUTION');
INSERT INTO `e_ability_names`
VALUES ('INTELLIGENCE');
INSERT INTO `e_ability_names`
VALUES ('WISDOM');
INSERT INTO `e_ability_names`
VALUES ('CHARISMA');
INSERT INTO `e_armor_type`
VALUES ('HEAVY');
INSERT INTO `e_armor_type`
VALUES ('LIGHT');
INSERT INTO `e_armor_type`
VALUES ('MEDIUM');
INSERT INTO `e_damage_types`
VALUES ('ACID');
INSERT INTO `e_damage_types`
VALUES ('BLUDGEONING');
INSERT INTO `e_damage_types`
VALUES ('COLD');
INSERT INTO `e_damage_types`
VALUES ('FIRE');
INSERT INTO `e_damage_types`
VALUES ('FORCE');
INSERT INTO `e_damage_types`
VALUES ('LIGHTNING');
INSERT INTO `e_damage_types`
VALUES ('NECROTIC');
INSERT INTO `e_damage_types`
VALUES ('NONE');
INSERT INTO `e_damage_types`
VALUES ('PIERCING');
INSERT INTO `e_damage_types`
VALUES ('POISON');
INSERT INTO `e_damage_types`
VALUES ('PSYCHIC');
INSERT INTO `e_damage_types`
VALUES ('RADIANT');
INSERT INTO `e_damage_types`
VALUES ('SLASHING');
INSERT INTO `e_damage_types`
VALUES ('THUNDER');
INSERT INTO `e_languages`
VALUES ('COMMON');
INSERT INTO `e_languages`
VALUES ('DRACONIC');
INSERT INTO `e_languages`
VALUES ('DWARVISH');
INSERT INTO `e_languages`
VALUES ('ELVISH');
INSERT INTO `e_languages`
VALUES ('GIANT');
INSERT INTO `e_languages`
VALUES ('GOBLIN');
INSERT INTO `e_languages`
VALUES ('INFERNAL');
INSERT INTO `e_size`
VALUES ('GARGANTUAN');
INSERT INTO `e_size`
VALUES ('HUGE');
INSERT INTO `e_size`
VALUES ('LARGE');
INSERT INTO `e_size`
VALUES ('MEDIUM');
INSERT INTO `e_size`
VALUES ('SMALL');
INSERT INTO `e_size`
VALUES ('TINY');
INSERT INTO `e_skill_names`
VALUES ('ACROBATICS');
INSERT INTO `e_skill_names`
VALUES ('ANIMAL_HANDLING');
INSERT INTO `e_skill_names`
VALUES ('ARCANA');
INSERT INTO `e_skill_names`
VALUES ('ATHLETICS');
INSERT INTO `e_skill_names`
VALUES ('DECEPTION');
INSERT INTO `e_skill_names`
VALUES ('HISTORY');
INSERT INTO `e_skill_names`
VALUES ('INSIGHT');
INSERT INTO `e_skill_names`
VALUES ('INTIMIDATION');
INSERT INTO `e_skill_names`
VALUES ('INVESTIGATION');
INSERT INTO `e_skill_names`
VALUES ('MEDICINE');
INSERT INTO `e_skill_names`
VALUES ('NATURE');
INSERT INTO `e_skill_names`
VALUES ('PERCEPTION');
INSERT INTO `e_skill_names`
VALUES ('PERFORMANCE');
INSERT INTO `e_skill_names`
VALUES ('PERSUASION');
INSERT INTO `e_skill_names`
VALUES ('RELIGION');
INSERT INTO `e_skill_names`
VALUES ('SLEIGHT_OF_HAND');
INSERT INTO `e_skill_names`
VALUES ('STEALTH');
INSERT INTO `e_skill_names`
VALUES ('SURVIVAL');
INSERT INTO `e_weapon_types`
VALUES ('DAGGER');
INSERT INTO `e_weapon_types`
VALUES ('DART');
INSERT INTO `e_weapon_types`
VALUES ('HAND CROSSBOW');
INSERT INTO `e_weapon_types`
VALUES ('LIGHT CROSSBOW');
INSERT INTO `e_weapon_types`
VALUES ('LONGSWORD');
INSERT INTO `e_weapon_types`
VALUES ('QUARTERSTAFF');
INSERT INTO `e_weapon_types`
VALUES ('RAPIER');
INSERT INTO `e_weapon_types`
VALUES ('SHORTSWORD');
INSERT INTO `e_weapon_types`
VALUES ('SIMPLE WEAPON');
INSERT INTO `e_weapon_types`
VALUES ('SLING');
INSERT INTO `features`
VALUES (1, 'Expertise',
        'At 1st level, choose two of your skill proficiencies, or one of your skill proficiencies and your proficiency with thieves’ tools. Your proficiency bonus is doubled for any ability check you make that uses either of the chosen proficiencies.\n\nAt 6th level, you can choose two more of your proficiencies (in skills or with thieves’ tools) to gain this benefit.',
        1);
INSERT INTO `features`
VALUES (2, 'Sneak Attack',
        'Beginning at 1st level, you know how to strike subtly and exploit a foe’s distraction. Once per turn, you can deal an extra 1d6 damage to one creature you hit with an attack if you have advantage on the attack roll. The attack must use a finesse or a ranged weapon.\n\nYou don’t need advantage on the attack roll if another enemy of the target is within 5 feet of it, that enemy isn’t incapacitated, and you don’t have disadvantage on the attack roll.\n\nThe amount of the extra damage increases as you gain levels in this class, as shown in the Sneak Attack column of the Rogue table.',
        1);
INSERT INTO `features`
VALUES (3, 'Thieves’ Cant',
        'During your rogue training you learned thieves’ cant, a secret mix of dialect, jargon, and code that allows you to hide messages in seemingly normal conversation. Only another creature that knows thieves’ cant understands such messages. It takes four times longer to convey such a message than it does to speak the same idea plainly.\n\nIn addition, you understand a set of secret signs and symbols used to convey short, simple messages, such as whether an area is dangerous or the territory of a thieves’ guild, whether loot is nearby, or whether the people in an area are easy marks or will provide a safe house for thieves on the run.',
        1);
INSERT INTO `features`
VALUES (4, 'Cunning Action',
        'Starting at 2nd level, your quick thinking and agility allow you to move and act quickly. You can take a bonus action on each of your turns in combat. This action can be used only to take the Dash, Disengage, or Hide action.',
        2);
INSERT INTO `features`
VALUES (5, 'Roguish Archetype',
        'At 3rd level, you choose an archetype that you emulate in the exercise of your rogue abilities: Thief, detailed at the end of the class description, or one from another source. Your archetype choice grants you features at 3rd level and then again at 9th, 13th, and 17th level.',
        3);
INSERT INTO `features`
VALUES (6, 'Ability Score Improvement',
        'When you reach 4th level, and again at 8th, 10th, 12th, 16th, and 19th level, you can increase one ability score of your choice by 2, or you can increase two ability scores of your choice by 1. As normal, you can’t increase an ability score above 20 using this feature.\n\nUsing the optional feats rule, you can forgo taking this feature to take a feat of your choice instead.',
        4);
INSERT INTO `features`
VALUES (7, 'Uncanny Dodge',
        'Starting at 5th level, when an attacker that you can see hits you with an attack, you can use your reaction to halve the attack’s damage against you.',
        5);
INSERT INTO `features`
VALUES (8, 'Expertise',
        'At 6th level, choose two more of your skill proficiencies, or one more of your skill proficiencies and your proficiency with thieves’ tools. Your proficiency bonus is doubled for any ability check you make that uses either of the chosen proficiencies.',
        6);
INSERT INTO `features`
VALUES (9, 'Evasion',
        'Beginning at 7th level, you can nimbly dodge out of the way of certain area effects, such as an ancient red dragon’s fiery breath or an ice storm spell. When you are subjected to an effect that allows you to make a Dexterity saving throw to take only half damage, you instead take no damage if you succeed on the saving throw, and only half damage if you fail.',
        7);
INSERT INTO `features`
VALUES (10, 'Reliable Talent',
        'By 11th level, you have refined your chosen skills until they approach perfection. Whenever you make an ability check that lets you add your proficiency bonus, you can treat a d20 roll of 9 or lower as a 10.',
        11);
INSERT INTO `features`
VALUES (11, 'Blindsense',
        'Starting at 14th level, if you are able to hear, you are aware of the location of any hidden or invisible creature within 10 feet of you.',
        14);
INSERT INTO `features`
VALUES (12, 'Slippery Mind',
        'By 15th level, you have acquired greater mental strength. You gain proficiency in Wisdom saving throws.', 15);
INSERT INTO `features`
VALUES (13, 'Elusive',
        'Beginning at 18th level, you are so evasive that attackers rarely gain the upper hand against you. No attack roll has advantage against you while you aren’t incapacitated.',
        18);
INSERT INTO `features`
VALUES (14, 'Stroke of Luck',
        'At 20th level, you have an uncanny knack for succeeding when you need to. If your attack misses a target within range, you can turn the miss into a hit. Alternatively, if you fail an ability check, you can treat the d20 roll as a 20.\n\nOnce you use this feature, you can’t use it again until you finish a short or long rest.',
        20);
INSERT INTO `features`
VALUES (15, 'Spellcasting',
        'As a student of arcane magic, you have a spellbook containing spells that show the first glimmerings of your true power. See Spells Rules for the general rules of spellcasting and the Spells Listing for the wizard spell list.',
        1);
INSERT INTO `features`
VALUES (16, 'Cantrips',
        'At 1st level, you know three cantrips of your choice from the wizard spell list. You learn additional wizard cantrips of your choice at higher levels, as shown in the Cantrips Known column of the Wizard table.',
        1);
INSERT INTO `features`
VALUES (17, 'Spellbook',
        'At 1st level, you have a spellbook containing six 1st-level wizard spells of your choice. Your spellbook is the repository of the wizard spells you know, except your cantrips, which are fixed in your mind.',
        1);
INSERT INTO `features`
VALUES (18, 'Spellcasting Ability',
        'Intelligence is your spellcasting ability for your wizard spells, since you learn your spells through dedicated study and memorization. You use your Intelligence whenever a spell refers to your spellcasting ability. In addition, you use your Intelligence modifier when setting the saving throw DC for a wizard spell you cast and when making an attack roll with one.',
        1);
INSERT INTO `features`
VALUES (19, 'Learning Spells of 1st Level and Higher',
        'Each time you gain a wizard level, you can add two wizard spells of your choice to your spellbook for free. Each of these spells must be of a level for which you have spell slots, as shown on the Wizard table. On your adventures, you might find other spells that you can add to your spellbook (see the “Your Spellbook” sidebar).',
        1);
INSERT INTO `features`
VALUES (20, 'Arcane Recovery',
        'You have learned to regain some of your magical energy by studying your spellbook. Once per day when you finish a short rest, you can choose expended spell slots to recover. The spell slots can have a combined level that is equal to or less than half your wizard level (rounded up), and none of the slots can be 6th level or higher.\n\nFor example, if you’re a 4th-level wizard, you can recover up to two levels worth of spell slots. You can recover either a 2nd-level spell slot or two 1st-level spell slots.',
        1);
INSERT INTO `features`
VALUES (21, 'Arcane Tradition',
        'When you reach 2nd level, you choose an arcane tradition, shaping your practice of magic through one of eight schools: Abjuration, Conjuration, Divination, Enchantment, Evocation, Illusion, Necromancy, or Transmutation. The School of Evocation is detailed at the end of the class description, and more choices are available in other sources.\n\nYour choice grants you features at 2nd level and again at 6th, 10th, and 14th level.\n\n',
        2);
INSERT INTO `features`
VALUES (22, 'Ability Score Improvement',
        'When you reach 4th level, and again at 8th, 12th, 16th, and 19th level, you can increase one ability score of your choice by 2, or you can increase two ability scores of your choice by 1. As normal, you can’t increase an ability score above 20 using this feature.\n\nUsing the optional feats rule, you can forgo taking this feature to take a feat of your choice instead.',
        4);
INSERT INTO `features`
VALUES (23, 'Spell Mastery',
        'At 18th level, you have achieved such mastery over certain spells that you can cast them at will. Choose a 1st-level wizard spell and a 2nd-level wizard spell that are in your spellbook. You can cast those spells at their lowest level without expending a spell slot when you have them prepared. If you want to cast either spell at a higher level, you must expend a spell slot as normal.\n\nBy spending 8 hours in study, you can exchange one or both of the spells you chose for different spells of the same levels.',
        18);
INSERT INTO `features`
VALUES (24, 'Signature Spells',
        'When you reach 20th level, you gain mastery over two powerful spells and can cast them with little effort. Choose two 3rd-level wizard spells in your spellbook as your signature spells. You always have these spells prepared, they don’t count against the number of spells you have prepared, and you can cast each of them once at 3rd level without expending a spell slot. When you do so, you can’t do so again until you finish a short or long rest.\n\nIf you want to cast either spell at a higher level, you must expend a spell slot as normal.',
        20);
INSERT INTO `races`
VALUES (1, 'Elf',
        'Elves are a magical people of otherworldly grace, living in the world but not entirely part of it. They live in places of ethereal beauty, in the midst of ancient forests or in silvery spires glittering with faerie light, where soft music drifts through the air and gentle fragrances waft on the breeze. Elves love nature and magic, art and artistry, music and poetry, and the good things of the world.',
        'MEDIUM', 30, NULL);
INSERT INTO `races`
VALUES (2, 'Wood Elf',
        'As a wood elf, you have keen senses and intuition, and your fleet feet carry you quickly and stealthily through your native forests. This category includes the wild elves (grugach) of Greyhawk and the Kagonesti of Dragonlance, as well as the races called wood elves in Greyhawk and the Forgotten Realms. In Faerûn, wood elves (also called wild elves, green elves, or forest elves) are reclusive and distrusting of non-elves.',
        'MEDIUM', 35, 1);
INSERT INTO `races`
VALUES (3, 'High Elf',
        'As a high elf, you have a keen mind and a mastery of at least the basics of magic. In many of the worlds of D&D, there are two kinds of high elves. One type (which includes the gray elves and valley elves of Greyhawk, the Silvanesti of Dragonlance, and the sun elves of the Forgotten Realms) is haughty and reclusive, believing themselves to be superior to non-elves and even other elves. The other type (including the high elves of Greyhawk, the Qualinesti of Dragonlance, and the moon elves of the Forgotten Realms) are more common and more friendly, and often encountered among humans and other races.',
        'MEDIUM', 30, 1);
INSERT INTO `races`
VALUES (4, 'Dragonborn',
        'Born of dragons, as their name proclaims, the dragonborn walk proudly through a world that greets them with fearful incomprehension. Shaped by draconic gods or the dragons themselves, dragonborn originally hatched from dragon eggs as a unique race, combining the best attributes of dragons and humanoids. Some dragonborn are faithful servants to true dragons, others form the ranks of soldiers in great wars, and still others find themselves adrift, with no clear calling in life.',
        'MEDIUM', 30, NULL);
INSERT INTO `races_has_e_languages`
VALUES (1, 'COMMON');
INSERT INTO `races_has_e_languages`
VALUES (1, 'ELVISH');
INSERT INTO `races_has_e_languages`
VALUES (4, 'COMMON');
INSERT INTO `races_has_e_languages`
VALUES (4, 'DRACONIC');
INSERT INTO `spells`
VALUES (1, 'Acid Splash',
        'You hurl a bubble of acid. Choose one or two creatures you can see within range. If you choose two, they must be within 5 feet of each other. A target must succeed on a Dexterity saving throw or take 1d6 acid damage.\n\nThis spell’s damage increases by 1d6 when you reach 5th level (2d6), 11th level (3d6), and 17th level (4d6).',
        0, '60 ft', 'Instantaneous', 'V, S', 'ACID', 1, 6);
INSERT INTO `spells`
VALUES (2, 'Minor Illusion',
        'You create a sound or an image of an object within range that lasts for the duration. The illusion also ends if you dismiss it as an action or cast this spell again.\n\nIf you create a sound, its volume can range from a whisper to a scream. It can be your voice, someone else\'s voice,
        a lion\'s roar, a beating of drums, or any other sound you choose. The sound continues unabated throughout the duration, or you can make discrete sounds at different times before the spell ends.\n\nIf you create an image of an object--such as a chair, muddy footprints, or a small chest--it must be no larger than a 5-foot cube. The image can\'t create sound,
        light, smell, or any other sensory effect.Physical interaction with the image reveals it to be an illusion,
        because things can pass through it.\n\nIf a creature uses its action to examine the sound or image,
        the creature can determine that it is an illusion with a successful Intelligence (Investigation) check against your spell save DC. If a creature discerns the illusion for what it is,
        the illusion becomes faint to the creature.',0,'30 ft','1 Minute','S, M(a bit of fleece)','NONE',0,0);
INSERT INTO `spells` VALUES (3,'Burning Hands','As you hold your hands with thumbs touching and fingers spread,
        a thin sheet of flames shoots forth from your outstretched fingertips. Each creature in a 15-foot cone must make a Dexterity saving throw. A creature takes 3d6 fire damage on a failed save, or
        half as much damage on a successful one.\n\nThe fire ignites any flammable objects in the area that aren\'t being worn or carried.\n\nAt Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.',
        1, 'Self (15 ft cone)', 'Instantaneous', 'V, S', 'FIRE', 3, 6);
INSERT INTO `spells`
VALUES (4, 'Detect Magic',
        'For the duration, you sense the presence of magic within 30 feet of you. If you sense magic in this way, you can use your action to see a faint aura around any visible creature or object in the area that bears magic, and you learn its school of magic, if any.\n\nThe spell can penetrate most barriers, but it is blocked by 1 foot of stone, 1 inch of common metal, a thin sheet of lead, or 3 feet of wood or dirt.',
        1, 'Self (30 ft sphere)', '10 Minutes', 'V, S', 'NONE', 0, 0);
INSERT INTO `spells`
VALUES (5, 'Hold Person',
        'Choose a humanoid that you can see within range. The target must succeed on a Wisdom saving throw or be paralyzed for the duration. At the end of each of its turns, the target can make another Wisdom saving throw. On a success, the spell ends on the target.\n\nAt Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, you can target one additional humanoid for each slot level above 2nd. The humanoids must be within 30 feet of each other when you target them.',
        2, '60 ft', '1 Minute', 'V, S, M (a small, straight piece of iron)', 'NONE', 0, 0);
INSERT INTO `spells`
VALUES (6, 'Darkness',
        'Magical darkness spreads from a point you choose within range to fill a 15-foot-radius sphere for the duration. The darkness spreads around corners. A creature with darkvision can\'t see through this darkness, and
        nonmagical light can\'t illuminate it.\n\nIf the point you choose is on an object you are holding or one that isn\'
        t being worn or carried,
        the darkness emanates from the object and moves with it. Completely covering the source of the darkness with an opaque object,
        such as a bowl or a helm,
        blocks the darkness.\n\nIf any of this spell\'s area overlaps with an area of light created by a spell of 2nd level or lower, the spell that created the light is dispelled.',
        2, '60 ft', '10 Minutes', 'V, M (bat fur and a drop of pitch or piece of coal)', 'NONE', 0, 0);
INSERT INTO `spells`
VALUES (7, 'Fireball',
        'A bright streak flashes from your pointing finger to a point you choose within range and then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot-radius sphere centered on that point must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed save, or half as much damage on a successful one.\n\nThe fire spreads around corners. It ignites flammable objects in the area that aren\'t being worn or carried.\n\nAt Higher Levels. When you cast this spell using a spell slot of 4th level or higher,
        the damage increases by 1d6 for each slot level above 3rd.',3,'150 ft (20 ft spehere)','Instantaneous','V, S,
        M(a tiny ball of bat guano and sulfur)','FIRE',8,6);
INSERT INTO `spells` VALUES (8,'Dispel Magic','Choose one creature, object, or magical effect within range.Any spell of
        3rd level or lower on the target ends.For each spell of 4th level or higher on the target,
        make an ability check using your spellcasting ability. The DC equals 10 + the spell\'s level. On a successful check, the spell ends.\n\nAt Higher Levels. When you cast this spell using a spell slot of 4th level or higher, you automatically end the effects of a spell on the target if the spell\'s level is equal to or less than the level of the spell slot you used.',3,'120 ft','Instantaneous','V,
        S','NONE',0,0);
INSERT INTO `traits` VALUES (1,'Darkvision','Accustomed to twilit forests and the night sky,
        you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and
        in darkness as if it were dim light.You can’t discern color in darkness, only shades of gray.');
INSERT INTO `traits` VALUES (2,' Keen Senses ',' You have proficiency in the Perception skill.');
INSERT INTO `traits` VALUES (3,' Fey Ancestry ',' You have advantage on saving throws against being charmed, and magic
        can’t put you to sleep.');
INSERT INTO `traits` VALUES (4,' Trance ',' Elves don’t need to sleep.Instead, they meditate deeply,
        remaining semiconscious, for 4 hours a day.(The Common word for such meditation is “trance.”) While meditating,
        you can dream after a fashion;
such
dreams are actually mental exercises that have become reflexive through years of practice. After resting in this way, you gain the same benefit that a human does from 8 hours of sleep.');
INSERT INTO `traits` VALUES (5,'Ability Score Increase','Your Dexterity score increases by 2.
');
INSERT INTO `traits` VALUES (6,'Ability Score Increase','Your Intelligence score increases by 1.
');
INSERT INTO `traits` VALUES (7,'Elf Weapon Training','You have proficiency with the longsword, shortsword, shortbow, and longbow.');
INSERT INTO `traits` VALUES (8,'Cantrip','You know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it.');
INSERT INTO `traits` VALUES (9,'Extra Language','You can speak, read, and write one extra language of your choice.');
INSERT INTO `traits` VALUES (10,'Ability Score Increase','Your Wisdom score increases by 1.
');
INSERT INTO `traits` VALUES (11,'Fleet of Foot','Your base walking speed increases to 35 feet.');
INSERT INTO `traits` VALUES (12,'Mask of the Wild','You can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena.');
INSERT INTO `traits` VALUES (13,'Breath Weapon','You can use your action to exhale destructive energy. Your draconic ancestry determines the size, shape, and damage type of the exhalation. When you use your breath weapon, each creature in the area of the exhalation must make a saving throw, the type of which is determined by your draconic ancestry. The DC for this saving throw equals 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level. After you use your breath weapon, you can
’t use it again until you complete a short or long rest.');
INSERT INTO `traits` VALUES (14,'Damage Resistance','You have resistance to the damage type associated with your draconic ancestry.');
INSERT INTO `traits` VALUES (15,'Draconic Ancestry','<p>You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table. Your breath weapon and damage resistance are determined by the dragon type, as shown in the table.</p>
\n<div class=
\"table-overflow-wrapper\">\n<table class=\"table-compendium table--generic-dice\">\n<thead>\n<tr>\n<th>Dragon</th>\n<th>Damage Type</th>\n<th>Breath Weapon</th>\n</tr>\n</thead>\n<tbody>\n<tr>\n<td>Black</td>\n<td>Acid</td>\n<td>5 by 30 ft. line (Dex. save)</td>\n</tr>\n<tr>\n<td>Blue</td>\n<td>Lightning</td>\n<td>5 by 30 ft. line (Dex. save)</td>\n</tr>\n<tr>\n<td>Brass</td>\n<td>Fire</td>\n<td>5 by 30 ft. line (Dex. save)</td>\n</tr>\n<tr>\n<td>Bronze</td>\n<td>Lightning</td>\n<td>5 by 30 ft. line (Dex. save)</td>\n</tr>\n<tr>\n<td>Copper</td>\n<td>Acid</td>\n<td>5 by 30 ft. line (Dex. save)</td>\n</tr>\n<tr>\n<td>Gold</td>\n<td>Fire</td>\n<td>15 ft. cone (Dex. save)</td>\n</tr>\n<tr>\n<td>Green</td>\n<td>Poison</td>\n<td>15 ft. cone (Con. save)</td>\n</tr>\n<tr>\n<td>Red</td>\n<td>Fire</td>\n<td>15 ft. cone (Dex. save)</td>\n</tr>\n<tr>\n<td>Silver</td>\n<td>Cold</td>\n<td>15 ft. cone (Con. save)</td>\n</tr>\n<tr>\n<td>White</td>\n<td>Cold</td>\n<td>15 ft. cone (Con. save)</td>\n</tr>\n</tbody>\n</table>\n</div>');
INSERT INTO `traits` VALUES (16,'Ability Score Increase','Your Strength score increases by 2, and your Charisma score increases by 1.');
INSERT INTO `race_has_traits`
VALUES (1, 1);
INSERT INTO `race_has_traits`
VALUES (2, 1);
INSERT INTO `race_has_traits`
VALUES (3, 1);
INSERT INTO `race_has_traits`
VALUES (4, 1);
INSERT INTO `race_has_traits`
VALUES (5, 1);
INSERT INTO `race_has_traits`
VALUES (7, 2);
INSERT INTO `race_has_traits`
VALUES (10, 2);
INSERT INTO `race_has_traits`
VALUES (11, 2);
INSERT INTO `race_has_traits`
VALUES (12, 2);
INSERT INTO `race_has_traits`
VALUES (6, 3);
INSERT INTO `race_has_traits`
VALUES (7, 3);
INSERT INTO `race_has_traits`
VALUES (8, 3);
INSERT INTO `race_has_traits`
VALUES (9, 3);
INSERT INTO `race_has_traits`
VALUES (13, 4);
INSERT INTO `race_has_traits`
VALUES (14, 4);
INSERT INTO `race_has_traits`
VALUES (15, 4);
INSERT INTO `race_has_traits`
VALUES (16, 4);
INSERT INTO `class_has_ability_proficiencies`
VALUES (1, 'INTELLIGENCE');
INSERT INTO `class_has_ability_proficiencies`
VALUES (1, 'WISDOM');
INSERT INTO `class_has_ability_proficiencies`
VALUES (2, 'DEXTERITY');
INSERT INTO `class_has_ability_proficiencies`
VALUES (2, 'INTELLIGENCE');
INSERT INTO `class_has_armor_proficiencies`
VALUES (2, 'LIGHT');
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (1, 'ARCANA', 2);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (1, 'HISTORY', 2);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (1, 'INSIGHT', 2);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (1, 'INVESTIGATION', 2);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (1, 'MEDICINE', 2);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (1, 'RELIGION', 2);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'ACROBATICS', 4);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'ATHLETICS', 4);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'DECEPTION', 4);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'INSIGHT', 4);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'INTIMIDATION', 4);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'INVESTIGATION', 4);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'PERCEPTION', 4);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'PERFORMANCE', 4);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'PERSUASION', 4);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'SLEIGHT_OF_HAND', 4);
INSERT INTO `class_has_skill_proficiencies_choices`
VALUES (2, 'STEALTH', 4);
INSERT INTO `class_has_spells`
VALUES (1, 1);
INSERT INTO `class_has_spells`
VALUES (1, 2);
INSERT INTO `class_has_spells`
VALUES (1, 3);
INSERT INTO `class_has_spells`
VALUES (1, 4);
INSERT INTO `class_has_spells`
VALUES (1, 5);
INSERT INTO `class_has_spells`
VALUES (1, 6);
INSERT INTO `class_has_spells`
VALUES (1, 7);
INSERT INTO `class_has_spells`
VALUES (1, 8);
INSERT INTO `class_has_weapon_proficiencies`
VALUES (1, 'DAGGER');
INSERT INTO `class_has_weapon_proficiencies`
VALUES (1, 'DART');
INSERT INTO `class_has_weapon_proficiencies`
VALUES (1, 'LIGHT CROSSBOW');
INSERT INTO `class_has_weapon_proficiencies`
VALUES (1, 'QUARTERSTAFF');
INSERT INTO `class_has_weapon_proficiencies`
VALUES (1, 'SLING');
INSERT INTO `class_has_weapon_proficiencies`
VALUES (2, 'HAND CROSSBOW');
INSERT INTO `class_has_weapon_proficiencies`
VALUES (2, 'LONGSWORD');
INSERT INTO `class_has_weapon_proficiencies`
VALUES (2, 'RAPIER');
INSERT INTO `class_has_weapon_proficiencies`
VALUES (2, 'SHORTSWORD');
INSERT INTO `class_has_weapon_proficiencies`
VALUES (2, 'SIMPLE WEAPON');
INSERT INTO `class_has_features`
VALUES (1, 15);
INSERT INTO `class_has_features`
VALUES (1, 16);
INSERT INTO `class_has_features`
VALUES (1, 17);
INSERT INTO `class_has_features`
VALUES (1, 18);
INSERT INTO `class_has_features`
VALUES (1, 19);
INSERT INTO `class_has_features`
VALUES (1, 20);
INSERT INTO `class_has_features`
VALUES (1, 21);
INSERT INTO `class_has_features`
VALUES (1, 22);
INSERT INTO `class_has_features`
VALUES (1, 23);
INSERT INTO `class_has_features`
VALUES (1, 24);
INSERT INTO `class_has_features`
VALUES (2, 1);
INSERT INTO `class_has_features`
VALUES (2, 2);
INSERT INTO `class_has_features`
VALUES (2, 3);
INSERT INTO `class_has_features`
VALUES (2, 4);
INSERT INTO `class_has_features`
VALUES (2, 5);
INSERT INTO `class_has_features`
VALUES (2, 6);
INSERT INTO `class_has_features`
VALUES (2, 7);
INSERT INTO `class_has_features`
VALUES (2, 8);
INSERT INTO `class_has_features`
VALUES (2, 9);
INSERT INTO `class_has_features`
VALUES (2, 10);
INSERT INTO `class_has_features`
VALUES (2, 11);
INSERT INTO `class_has_features`
VALUES (2, 12);
INSERT INTO `class_has_features`
VALUES (2, 13);
INSERT INTO `class_has_features`
VALUES (2, 14);
INSERT INTO `race_has_ability_score_increases`
VALUES (1, 'DEXTERITY', 2);
INSERT INTO `race_has_ability_score_increases`
VALUES (2, 'WISDOM', 1);
INSERT INTO `race_has_ability_score_increases`
VALUES (3, 'INTELLIGENCE', 1);
INSERT INTO `race_has_ability_score_increases`
VALUES (4, 'CHARISMA', 1);
INSERT INTO `race_has_ability_score_increases`
VALUES (4, 'STRENGTH', 2);
INSERT INTO `ability_has_skills`
VALUES ('CHARISMA', 'DECEPTION');
INSERT INTO `ability_has_skills`
VALUES ('CHARISMA', 'INTIMIDATION');
INSERT INTO `ability_has_skills`
VALUES ('CHARISMA', 'PERFORMANCE');
INSERT INTO `ability_has_skills`
VALUES ('CHARISMA', 'PERSUASION');
INSERT INTO `ability_has_skills`
VALUES ('DEXTERITY', 'ACROBATICS');
INSERT INTO `ability_has_skills`
VALUES ('DEXTERITY', 'SLEIGHT_OF_HAND');
INSERT INTO `ability_has_skills`
VALUES ('DEXTERITY', 'STEALTH');
INSERT INTO `ability_has_skills`
VALUES ('INTELLIGENCE', 'ARCANA');
INSERT INTO `ability_has_skills`
VALUES ('INTELLIGENCE', 'HISTORY');
INSERT INTO `ability_has_skills`
VALUES ('INTELLIGENCE', 'INVESTIGATION');
INSERT INTO `ability_has_skills`
VALUES ('INTELLIGENCE', 'NATURE');
INSERT INTO `ability_has_skills`
VALUES ('INTELLIGENCE', 'RELIGION');
INSERT INTO `ability_has_skills`
VALUES ('STRENGTH', 'ATHLETICS');
INSERT INTO `ability_has_skills`
VALUES ('WISDOM', 'ANIMAL_HANDLING');
INSERT INTO `ability_has_skills`
VALUES ('WISDOM', 'INSIGHT');
INSERT INTO `ability_has_skills`
VALUES ('WISDOM', 'MEDICINE');
INSERT INTO `ability_has_skills`
VALUES ('WISDOM', 'PERCEPTION');
INSERT INTO `ability_has_skills`
VALUES ('WISDOM', 'SURVIVAL');
INSERT INTO `experience_proficency_bonus`
VALUES (1, 0, 2);
INSERT INTO `experience_proficency_bonus`
VALUES (2, 300, 2);
INSERT INTO `experience_proficency_bonus`
VALUES (3, 900, 2);
INSERT INTO `experience_proficency_bonus`
VALUES (4, 2700, 2);
INSERT INTO `experience_proficency_bonus`
VALUES (5, 6500, 3);
INSERT INTO `experience_proficency_bonus`
VALUES (6, 14000, 3);
INSERT INTO `experience_proficency_bonus`
VALUES (7, 23000, 3);
INSERT INTO `experience_proficency_bonus`
VALUES (8, 34000, 3);
INSERT INTO `experience_proficency_bonus`
VALUES (9, 48000, 4);
INSERT INTO `experience_proficency_bonus`
VALUES (10, 64000, 4);
INSERT INTO `experience_proficency_bonus`
VALUES (11, 85000, 4);
INSERT INTO `experience_proficency_bonus`
VALUES (12, 100000, 4);
INSERT INTO `experience_proficency_bonus`
VALUES (13, 120000, 5);
INSERT INTO `experience_proficency_bonus`
VALUES (14, 140000, 5);
INSERT INTO `experience_proficency_bonus`
VALUES (15, 165000, 5);
INSERT INTO `experience_proficency_bonus`
VALUES (16, 195000, 5);
INSERT INTO `experience_proficency_bonus`
VALUES (17, 225000, 6);
INSERT INTO `experience_proficency_bonus`
VALUES (18, 265000, 6);
INSERT INTO `experience_proficency_bonus`
VALUES (19, 305000, 6);
INSERT INTO `experience_proficency_bonus`
VALUES (20, 355000, 6);