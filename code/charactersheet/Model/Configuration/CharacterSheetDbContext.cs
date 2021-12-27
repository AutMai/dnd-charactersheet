﻿using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configuration{
    public partial class CharacterSheetDbContext : DbContext{
        public CharacterSheetDbContext(){
        }

        public CharacterSheetDbContext(DbContextOptions<CharacterSheetDbContext> options)
            : base(options){
        }

        public virtual DbSet<Ability> Abilities{ get; set; } = null!;
        public virtual DbSet<Armor> Armors{ get; set; } = null!;
        public virtual DbSet<Background> Backgrounds{ get; set; } = null!;
        public virtual DbSet<Character> Characters{ get; set; } = null!;
        public virtual DbSet<CharactersHasItem> CharactersHasItems{ get; set; } = null!;
        public virtual DbSet<Class> Classes{ get; set; } = null!;
        public virtual DbSet<DeathSafe> DeathSaves{ get; set; } = null!;
        public virtual DbSet<Dicethrow> Dicethrows{ get; set; } = null!;
        public virtual DbSet<EAbilityName> EAbilityNames{ get; set; } = null!;
        public virtual DbSet<EArmorType> EArmorTypes{ get; set; } = null!;
        public virtual DbSet<EDamageType> EDamageTypes{ get; set; } = null!;
        public virtual DbSet<ELanguage> ELanguages{ get; set; } = null!;
        public virtual DbSet<ESize> ESizes{ get; set; } = null!;
        public virtual DbSet<ESkillName> ESkillNames{ get; set; } = null!;
        public virtual DbSet<EWeaponType> EWeaponTypes{ get; set; } = null!;
        public virtual DbSet<Feature> Features{ get; set; } = null!;
        public virtual DbSet<Item> Items{ get; set; } = null!;
        public virtual DbSet<Personality> Personalities{ get; set; } = null!;
        public virtual DbSet<Race> Races{ get; set; } = null!;
        public virtual DbSet<Skill> Skills{ get; set; } = null!;
        public virtual DbSet<Spell> Spells{ get; set; } = null!;
        public virtual DbSet<Trait> Traits{ get; set; } = null!;
        public virtual DbSet<Weapon> Weapons{ get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.UseCollation("utf8_unicode_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Ability>(entity => {
                entity.ToTable("abilities");

                entity.HasIndex(e => e.CharacterId, "fk_ABILITIES_CHARACTERS1_idx");

                entity.HasIndex(e => e.Name, "fk_E_ABILITIES_E_ABILITY_NAMES1_idx");

                entity.Property(e => e.AbilityId).HasColumnName("ABILITY_ID");

                entity.Property(e => e.AbilityScore).HasColumnName("ABILITY_SCORE");

                entity.Property(e => e.CharacterId).HasColumnName("CHARACTER_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");

                entity.Property(e => e.Proficient).HasColumnName("PROFICIENT");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Abilities)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ABILITIES_CHARACTERS1");

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.Abilities)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_E_ABILITIES_E_ABILITY_NAMES1");
            });

            modelBuilder.Entity<Armor>(entity => {
                entity.ToTable("armors");

                entity.HasIndex(e => e.ArmorType, "fk_ARMORS_E_ARMOR_TYPE1_idx");

                entity.Property(e => e.ArmorId)
                    .ValueGeneratedNever()
                    .HasColumnName("ARMOR_ID");

                entity.Property(e => e.ArmorClass).HasColumnName("ARMOR_CLASS");

                entity.Property(e => e.ArmorType)
                    .HasMaxLength(45)
                    .HasColumnName("ARMOR_TYPE");

                entity.HasOne(d => d.ArmorNavigation)
                    .WithOne(p => p.Armor)
                    .HasForeignKey<Armor>(d => d.ArmorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ARMORS_ITEMS1");

                entity.HasOne(d => d.ArmorTypeNavigation)
                    .WithMany(p => p.Armors)
                    .HasForeignKey(d => d.ArmorType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ARMORS_E_ARMOR_TYPE1");
            });

            modelBuilder.Entity<Background>(entity => {
                entity.ToTable("backgrounds");

                entity.Property(e => e.BackgroundId).HasColumnName("BACKGROUND_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");

                entity.Property(e => e.SkillProficiencies)
                    .HasColumnType("text")
                    .HasColumnName("SKILL_PROFICIENCIES");
            });

            modelBuilder.Entity<Character>(entity => {
                entity.ToTable("characters");

                entity.HasIndex(e => e.BackgroundId, "fk_CHARACTERS_BACKGROUNDS1_idx");

                entity.HasIndex(e => e.ClassId, "fk_CHARACTERS_CLASSES1_idx");

                entity.HasIndex(e => e.RaceId, "fk_CHARACTERS_RACES1_idx");

                entity.Property(e => e.CharacterId).HasColumnName("CHARACTER_ID");

                entity.Property(e => e.Alignment)
                    .HasMaxLength(45)
                    .HasColumnName("ALIGNMENT");

                entity.Property(e => e.ArmorClass).HasColumnName("ARMOR_CLASS");

                entity.Property(e => e.BackgroundId).HasColumnName("BACKGROUND_ID");

                entity.Property(e => e.BronzeCoins).HasColumnName("BRONZE_COINS");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.CurrentHp).HasColumnName("CURRENT_HP");

                entity.Property(e => e.HitDice).HasColumnName("HIT_DICE");

                entity.Property(e => e.Inspiration).HasColumnName("INSPIRATION");

                entity.Property(e => e.MaxHp).HasColumnName("MAX_HP");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");

                entity.Property(e => e.RaceId).HasColumnName("RACE_ID");

                entity.Property(e => e.Speed).HasColumnName("SPEED");

                entity.Property(e => e.TemporaryHp).HasColumnName("TEMPORARY_HP");

                entity.Property(e => e.Xp).HasColumnName("XP");

                entity.HasOne(d => d.Background)
                    .WithMany(p => p.Characters)
                    .HasForeignKey(d => d.BackgroundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CHARACTERS_BACKGROUNDS1");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Characters)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CHARACTERS_CLASSES1");

                entity.HasOne(d => d.Race)
                    .WithMany(p => p.Characters)
                    .HasForeignKey(d => d.RaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CHARACTERS_RACES1");

                entity.HasMany(d => d.Names)
                    .WithMany(p => p.Characters)
                    .UsingEntity<Dictionary<string, object>>(
                        "CharacterHasLanguage",
                        l => l.HasOne<ELanguage>().WithMany().HasForeignKey("Name")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_CHARACTERS_has_E_LANGUAGES_E_LANGUAGES1"),
                        r => r.HasOne<Character>().WithMany().HasForeignKey("CharacterId")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_CHARACTERS_has_E_LANGUAGES_CHARACTERS1"),
                        j => {
                            j.HasKey("CharacterId", "Name").HasName("PRIMARY")
                                .HasAnnotation("MySql:IndexPrefixLength", new[]{ 0, 0 });

                            j.ToTable("character_has_languages");

                            j.HasIndex(new[]{ "CharacterId" }, "fk_CHARACTERS_has_E_LANGUAGES_CHARACTERS1_idx");

                            j.HasIndex(new[]{ "Name" }, "fk_CHARACTERS_has_E_LANGUAGES_E_LANGUAGES1_idx");

                            j.IndexerProperty<int>("CharacterId").HasColumnName("CHARACTER_ID");

                            j.IndexerProperty<string>("Name").HasMaxLength(45).HasColumnName("NAME");
                        });

                entity.HasMany(d => d.Personalities)
                    .WithMany(p => p.Characters)
                    .UsingEntity<Dictionary<string, object>>(
                        "CharactersHasPersonality",
                        l => l.HasOne<Personality>().WithMany().HasForeignKey("PersonalitiesId")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_CHARACTERS_has_PERSONALITIES_PERSONALITIES1"),
                        r => r.HasOne<Character>().WithMany().HasForeignKey("CharacterId")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_CHARACTERS_has_PERSONALITIES_CHARACTERS1"),
                        j => {
                            j.HasKey("CharacterId", "PersonalitiesId").HasName("PRIMARY")
                                .HasAnnotation("MySql:IndexPrefixLength", new[]{ 0, 0 });

                            j.ToTable("characters_has_personalities");

                            j.HasIndex(new[]{ "CharacterId" }, "fk_CHARACTERS_has_PERSONALITIES_CHARACTERS1_idx");

                            j.HasIndex(new[]{ "PersonalitiesId" },
                                "fk_CHARACTERS_has_PERSONALITIES_PERSONALITIES1_idx");

                            j.IndexerProperty<int>("CharacterId").HasColumnName("CHARACTER_ID");

                            j.IndexerProperty<int>("PersonalitiesId").HasColumnName("PERSONALITIES_ID");
                        });

                entity.HasMany(d => d.Spells)
                    .WithMany(p => p.Characters)
                    .UsingEntity<Dictionary<string, object>>(
                        "CharacterHasSpell",
                        l => l.HasOne<Spell>().WithMany().HasForeignKey("SpellId")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_CHARACTERS_has_SPELLS_SPELLS1"),
                        r => r.HasOne<Character>().WithMany().HasForeignKey("CharacterId")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_CHARACTERS_has_SPELLS_CHARACTERS1"),
                        j => {
                            j.HasKey("CharacterId", "SpellId").HasName("PRIMARY")
                                .HasAnnotation("MySql:IndexPrefixLength", new[]{ 0, 0 });

                            j.ToTable("character_has_spells");

                            j.HasIndex(new[]{ "CharacterId" }, "fk_CHARACTERS_has_SPELLS_CHARACTERS1_idx");

                            j.HasIndex(new[]{ "SpellId" }, "fk_CHARACTERS_has_SPELLS_SPELLS1_idx");

                            j.IndexerProperty<int>("CharacterId").HasColumnName("CHARACTER_ID");

                            j.IndexerProperty<int>("SpellId").HasColumnName("SPELL_ID");
                        });
            });

            modelBuilder.Entity<CharactersHasItem>(entity => {
                entity.HasKey(e => new{ e.CharacterId, e.ItemId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[]{ 0, 0 });

                entity.ToTable("characters_has_items");

                entity.HasIndex(e => e.CharacterId, "fk_CHARACTERS_has_ITEMS_CHARACTERS1_idx");

                entity.HasIndex(e => e.ItemId, "fk_CHARACTERS_has_ITEMS_ITEMS1_idx");

                entity.Property(e => e.CharacterId).HasColumnName("CHARACTER_ID");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.CharactersHasItems)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CHARACTERS_has_ITEMS_CHARACTERS1");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.CharactersHasItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CHARACTERS_has_ITEMS_ITEMS1");
            });

            modelBuilder.Entity<Class>(entity => {
                entity.ToTable("classes");

                entity.HasIndex(e => e.HitDieId, "fk_CLASSES_DICETHROWS1_idx");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.HitDieId).HasColumnName("HIT_DIE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.HitDie)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.HitDieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CLASSES_DICETHROWS1");

                entity.HasMany(d => d.Spells)
                    .WithMany(p => p.Classes)
                    .UsingEntity<Dictionary<string, object>>(
                        "ClassHasSpell",
                        l => l.HasOne<Spell>().WithMany().HasForeignKey("SpellId")
                            .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_CLASSES_has_SPELLS_SPELLS1"),
                        r => r.HasOne<Class>().WithMany().HasForeignKey("ClassId")
                            .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_CLASSES_has_SPELLS_CLASSES1"),
                        j => {
                            j.HasKey("ClassId", "SpellId").HasName("PRIMARY")
                                .HasAnnotation("MySql:IndexPrefixLength", new[]{ 0, 0 });

                            j.ToTable("class_has_spells");

                            j.HasIndex(new[]{ "ClassId" }, "fk_CLASSES_has_SPELLS_CLASSES1_idx");

                            j.HasIndex(new[]{ "SpellId" }, "fk_CLASSES_has_SPELLS_SPELLS1_idx");

                            j.IndexerProperty<int>("ClassId").HasColumnName("CLASS_ID");

                            j.IndexerProperty<int>("SpellId").HasColumnName("SPELL_ID");
                        });
            });

            modelBuilder.Entity<DeathSafe>(entity => {
                entity.HasKey(e => e.CharacterId)
                    .HasName("PRIMARY");

                entity.ToTable("death_saves");

                entity.Property(e => e.CharacterId)
                    .ValueGeneratedNever()
                    .HasColumnName("CHARACTER_ID");

                entity.Property(e => e.Count).HasColumnName("COUNT");

                entity.Property(e => e.Success).HasColumnName("SUCCESS");

                entity.HasOne(d => d.Character)
                    .WithOne(p => p.DeathSafe)
                    .HasForeignKey<DeathSafe>(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DEATH_SAVES_CHARACTERS1");
            });

            modelBuilder.Entity<Dicethrow>(entity => {
                entity.ToTable("dicethrows");

                entity.Property(e => e.DicethrowId).HasColumnName("DICETHROW_ID");

                entity.Property(e => e.DiceCount).HasColumnName("DICE_COUNT");

                entity.Property(e => e.DiceType).HasColumnName("DICE_TYPE");
            });

            modelBuilder.Entity<EAbilityName>(entity => {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("e_ability_names");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<EArmorType>(entity => {
                entity.HasKey(e => e.Label)
                    .HasName("PRIMARY");

                entity.ToTable("e_armor_type");

                entity.Property(e => e.Label)
                    .HasMaxLength(45)
                    .HasColumnName("LABEL");
            });

            modelBuilder.Entity<EDamageType>(entity => {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("e_damage_types");

                entity.Property(e => e.Name)
                    .ValueGeneratedNever()
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<ELanguage>(entity => {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("e_languages");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<ESize>(entity => {
                entity.HasKey(e => e.Label)
                    .HasName("PRIMARY");

                entity.ToTable("e_size");

                entity.Property(e => e.Label)
                    .HasMaxLength(45)
                    .HasColumnName("LABEL");
            });

            modelBuilder.Entity<ESkillName>(entity => {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("e_skill_names");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<EWeaponType>(entity => {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("e_weapon_types");

                entity.Property(e => e.Name)
                    .ValueGeneratedNever()
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Feature>(entity => {
                entity.ToTable("features");

                entity.Property(e => e.FeatureId).HasColumnName("FEATURE_ID");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Label)
                    .HasMaxLength(45)
                    .HasColumnName("LABEL");

                entity.Property(e => e.Level).HasColumnName("LEVEL");

                entity.HasMany(d => d.Classes)
                    .WithMany(p => p.Features)
                    .UsingEntity<Dictionary<string, object>>(
                        "FeaturesHasClass",
                        l => l.HasOne<Class>().WithMany().HasForeignKey("ClassId")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_FEATURES_has_CLASSES_CLASSES1"),
                        r => r.HasOne<Feature>().WithMany().HasForeignKey("FeatureId")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_FEATURES_has_CLASSES_FEATURES1"),
                        j => {
                            j.HasKey("FeatureId", "ClassId").HasName("PRIMARY")
                                .HasAnnotation("MySql:IndexPrefixLength", new[]{ 0, 0 });

                            j.ToTable("features_has_classes");

                            j.HasIndex(new[]{ "ClassId" }, "fk_FEATURES_has_CLASSES_CLASSES1_idx");

                            j.HasIndex(new[]{ "FeatureId" }, "fk_FEATURES_has_CLASSES_FEATURES1_idx");

                            j.IndexerProperty<int>("FeatureId").HasColumnName("FEATURE_ID");

                            j.IndexerProperty<int>("ClassId").HasColumnName("CLASS_ID");
                        });
            });

            modelBuilder.Entity<Item>(entity => {
                entity.ToTable("items");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");

                entity.HasMany(d => d.Classes)
                    .WithMany(p => p.Items)
                    .UsingEntity<Dictionary<string, object>>(
                        "ClassHasProficiency",
                        l => l.HasOne<Class>().WithMany().HasForeignKey("ClassId")
                            .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_ITEMS_has_CLASSES_CLASSES1"),
                        r => r.HasOne<Item>().WithMany().HasForeignKey("ItemId").OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_ITEMS_has_CLASSES_ITEMS1"),
                        j => {
                            j.HasKey("ItemId", "ClassId").HasName("PRIMARY")
                                .HasAnnotation("MySql:IndexPrefixLength", new[]{ 0, 0 });

                            j.ToTable("class_has_proficiencies");

                            j.HasIndex(new[]{ "ClassId" }, "fk_ITEMS_has_CLASSES_CLASSES1_idx");

                            j.HasIndex(new[]{ "ItemId" }, "fk_ITEMS_has_CLASSES_ITEMS1_idx");

                            j.IndexerProperty<int>("ItemId").HasColumnName("ITEM_ID");

                            j.IndexerProperty<int>("ClassId").HasColumnName("CLASS_ID");
                        });
            });

            modelBuilder.Entity<Personality>(entity => {
                entity.HasKey(e => e.PersonalitiesId)
                    .HasName("PRIMARY");

                entity.ToTable("personalities");

                entity.Property(e => e.PersonalitiesId).HasColumnName("PERSONALITIES_ID");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Race>(entity => {
                entity.ToTable("races");

                entity.HasIndex(e => e.Size, "fk_RACES_E_SIZE_idx");

                entity.HasIndex(e => e.ParentRaceId, "fk_RACES_RACES1_idx");

                entity.Property(e => e.RaceId).HasColumnName("RACE_ID");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");

                entity.Property(e => e.ParentRaceId).HasColumnName("PARENT_RACE_ID");

                entity.Property(e => e.Size)
                    .HasMaxLength(45)
                    .HasColumnName("SIZE");

                entity.Property(e => e.Speed).HasColumnName("SPEED");

                entity.HasOne(d => d.ParentRace)
                    .WithMany(p => p.InverseParentRace)
                    .HasForeignKey(d => d.ParentRaceId)
                    .HasConstraintName("fk_RACES_RACES1");

                entity.HasOne(d => d.SizeNavigation)
                    .WithMany(p => p.Races)
                    .HasForeignKey(d => d.Size)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_RACES_E_SIZE");

                entity.HasMany(d => d.LanguageNames)
                    .WithMany(p => p.Races)
                    .UsingEntity<Dictionary<string, object>>(
                        "RacesHasELanguage",
                        l => l.HasOne<ELanguage>().WithMany().HasForeignKey("LanguageName")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_RACES_has_E_LANGUAGES_E_LANGUAGES1"),
                        r => r.HasOne<Race>().WithMany().HasForeignKey("RaceId").OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_RACES_has_E_LANGUAGES_RACES1"),
                        j => {
                            j.HasKey("RaceId", "LanguageName").HasName("PRIMARY")
                                .HasAnnotation("MySql:IndexPrefixLength", new[]{ 0, 0 });

                            j.ToTable("races_has_e_languages");

                            j.HasIndex(new[]{ "LanguageName" }, "fk_RACES_has_E_LANGUAGES_E_LANGUAGES1_idx");

                            j.HasIndex(new[]{ "RaceId" }, "fk_RACES_has_E_LANGUAGES_RACES1_idx");

                            j.IndexerProperty<int>("RaceId").HasColumnName("RACE_ID");

                            j.IndexerProperty<string>("LanguageName").HasMaxLength(45).HasColumnName("LANGUAGE_NAME");
                        });
            });

            modelBuilder.Entity<Skill>(entity => {
                entity.ToTable("skills");

                entity.HasIndex(e => e.AbilityId, "fk_SKILLS_ABILITIES1_idx");

                entity.HasIndex(e => e.Name, "fk_SKILLS_E_SKILL_NAMES1_idx");

                entity.Property(e => e.SkillId).HasColumnName("SKILL_ID");

                entity.Property(e => e.AbilityId).HasColumnName("ABILITY_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");

                entity.Property(e => e.Proficient).HasColumnName("PROFICIENT");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SKILLS_ABILITIES1");

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SKILLS_E_SKILL_NAMES1");
            });

            modelBuilder.Entity<Spell>(entity => {
                entity.ToTable("spells");

                entity.HasIndex(e => e.DamageDieId, "fk_SPELLS_DICETHROWS1_idx");

                entity.HasIndex(e => e.DamageType, "fk_SPELLS_E_DAMAGE_TYPES1_idx");

                entity.Property(e => e.SpellId).HasColumnName("SPELL_ID");

                entity.Property(e => e.Components)
                    .HasColumnType("text")
                    .HasColumnName("COMPONENTS");

                entity.Property(e => e.DamageDieId).HasColumnName("DAMAGE_DIE_ID");

                entity.Property(e => e.DamageType).HasColumnName("DAMAGE_TYPE");

                entity.Property(e => e.Duration)
                    .HasMaxLength(45)
                    .HasColumnName("DURATION");

                entity.Property(e => e.Level).HasColumnName("LEVEL");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("NAME");

                entity.Property(e => e.Range)
                    .HasMaxLength(45)
                    .HasColumnName("RANGE");

                entity.HasOne(d => d.DamageDie)
                    .WithMany(p => p.Spells)
                    .HasForeignKey(d => d.DamageDieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SPELLS_DICETHROWS1");

                entity.HasOne(d => d.DamageTypeNavigation)
                    .WithMany(p => p.Spells)
                    .HasForeignKey(d => d.DamageType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SPELLS_E_DAMAGE_TYPES1");
            });

            modelBuilder.Entity<Trait>(entity => {
                entity.ToTable("traits");

                entity.Property(e => e.TraitId).HasColumnName("TRAIT_ID");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Label)
                    .HasMaxLength(45)
                    .HasColumnName("LABEL");

                entity.HasMany(d => d.Races)
                    .WithMany(p => p.Traits)
                    .UsingEntity<Dictionary<string, object>>(
                        "RaceHasTrait",
                        l => l.HasOne<Race>().WithMany().HasForeignKey("RaceId").OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_TRAITS_has_RACES_RACES1"),
                        r => r.HasOne<Trait>().WithMany().HasForeignKey("TraitId")
                            .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_TRAITS_has_RACES_TRAITS1"),
                        j => {
                            j.HasKey("TraitId", "RaceId").HasName("PRIMARY")
                                .HasAnnotation("MySql:IndexPrefixLength", new[]{ 0, 0 });

                            j.ToTable("race_has_traits");

                            j.HasIndex(new[]{ "RaceId" }, "fk_TRAITS_has_RACES_RACES1_idx");

                            j.HasIndex(new[]{ "TraitId" }, "fk_TRAITS_has_RACES_TRAITS1_idx");

                            j.IndexerProperty<int>("TraitId").HasColumnName("TRAIT_ID");

                            j.IndexerProperty<int>("RaceId").HasColumnName("RACE_ID");
                        });
            });

            modelBuilder.Entity<Weapon>(entity => {
                entity.ToTable("weapons");

                entity.HasIndex(e => e.DamageDieId, "fk_WEAPONS_DICETHROWS1_idx");

                entity.HasIndex(e => e.DamageTypes, "fk_WEAPONS_E_DAMAGE_TYPES1_idx");

                entity.HasIndex(e => e.WeaponType, "fk_WEAPONS_E_WEAPON_TYPES1_idx");

                entity.HasIndex(e => e.WeaponId, "fk_WEAPONS_ITEMS1_idx");

                entity.Property(e => e.WeaponId)
                    .ValueGeneratedNever()
                    .HasColumnName("WEAPON_ID");

                entity.Property(e => e.DamageDieId).HasColumnName("DAMAGE_DIE_ID");

                entity.Property(e => e.DamageTypes).HasColumnName("DAMAGE_TYPES");

                entity.Property(e => e.WeaponType).HasColumnName("WEAPON_TYPE");

                entity.HasOne(d => d.DamageDie)
                    .WithMany(p => p.Weapons)
                    .HasForeignKey(d => d.DamageDieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_WEAPONS_DICETHROWS1");

                entity.HasOne(d => d.DamageTypesNavigation)
                    .WithMany(p => p.Weapons)
                    .HasForeignKey(d => d.DamageTypes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_WEAPONS_E_DAMAGE_TYPES1");

                entity.HasOne(d => d.WeaponNavigation)
                    .WithOne(p => p.Weapon)
                    .HasForeignKey<Weapon>(d => d.WeaponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_WEAPONS_ITEMS1");

                entity.HasOne(d => d.WeaponTypeNavigation)
                    .WithMany(p => p.Weapons)
                    .HasForeignKey(d => d.WeaponType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_WEAPONS_E_WEAPON_TYPES1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}