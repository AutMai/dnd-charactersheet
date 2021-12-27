using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class initCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8");

            migrationBuilder.CreateTable(
                name: "backgrounds",
                columns: table => new
                {
                    BACKGROUND_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    SKILL_PROFICIENCIES = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_backgrounds", x => x.BACKGROUND_ID);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "dicethrows",
                columns: table => new
                {
                    DICETHROW_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DICE_COUNT = table.Column<int>(type: "int", nullable: false),
                    DICE_TYPE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dicethrows", x => x.DICETHROW_ID);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "e_ability_names",
                columns: table => new
                {
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.NAME);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "e_armor_type",
                columns: table => new
                {
                    LABEL = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.LABEL);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "e_damage_types",
                columns: table => new
                {
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.NAME);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "e_languages",
                columns: table => new
                {
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.NAME);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "e_size",
                columns: table => new
                {
                    LABEL = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.LABEL);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "e_skill_names",
                columns: table => new
                {
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.NAME);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "e_weapon_types",
                columns: table => new
                {
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.NAME);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "features",
                columns: table => new
                {
                    FEATURE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LABEL = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DESCRIPTION = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    LEVEL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_features", x => x.FEATURE_ID);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    ITEM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DESCRIPTION = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PRICE = table.Column<int>(type: "int", nullable: false),
                    WEIGHT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.ITEM_ID);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "personalities",
                columns: table => new
                {
                    PERSONALITIES_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DESCRIPTION = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.PERSONALITIES_ID);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "traits",
                columns: table => new
                {
                    TRAIT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LABEL = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DESCRIPTION = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_traits", x => x.TRAIT_ID);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    CLASS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DESCRIPTION = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    HIT_DIE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.CLASS_ID);
                    table.ForeignKey(
                        name: "fk_CLASSES_DICETHROWS1",
                        column: x => x.HIT_DIE_ID,
                        principalTable: "dicethrows",
                        principalColumn: "DICETHROW_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "spells",
                columns: table => new
                {
                    SPELL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    LEVEL = table.Column<int>(type: "int", nullable: false),
                    RANGE = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DURATION = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    COMPONENTS = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DAMAGE_TYPE = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DAMAGE_DIE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spells", x => x.SPELL_ID);
                    table.ForeignKey(
                        name: "fk_SPELLS_DICETHROWS1",
                        column: x => x.DAMAGE_DIE_ID,
                        principalTable: "dicethrows",
                        principalColumn: "DICETHROW_ID");
                    table.ForeignKey(
                        name: "fk_SPELLS_E_DAMAGE_TYPES1",
                        column: x => x.DAMAGE_TYPE,
                        principalTable: "e_damage_types",
                        principalColumn: "NAME");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "races",
                columns: table => new
                {
                    RACE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DESCRIPTION = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    SIZE = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    SPEED = table.Column<int>(type: "int", nullable: false),
                    PARENT_RACE_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_races", x => x.RACE_ID);
                    table.ForeignKey(
                        name: "fk_RACES_E_SIZE",
                        column: x => x.SIZE,
                        principalTable: "e_size",
                        principalColumn: "LABEL");
                    table.ForeignKey(
                        name: "fk_RACES_RACES1",
                        column: x => x.PARENT_RACE_ID,
                        principalTable: "races",
                        principalColumn: "RACE_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "armors",
                columns: table => new
                {
                    ARMOR_ID = table.Column<int>(type: "int", nullable: false),
                    ARMOR_TYPE = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ARMOR_CLASS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armors", x => x.ARMOR_ID);
                    table.ForeignKey(
                        name: "fk_ARMORS_E_ARMOR_TYPE1",
                        column: x => x.ARMOR_TYPE,
                        principalTable: "e_armor_type",
                        principalColumn: "LABEL");
                    table.ForeignKey(
                        name: "fk_ARMORS_ITEMS1",
                        column: x => x.ARMOR_ID,
                        principalTable: "items",
                        principalColumn: "ITEM_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "weapons",
                columns: table => new
                {
                    WEAPON_ID = table.Column<int>(type: "int", nullable: false),
                    DAMAGE_DIE_ID = table.Column<int>(type: "int", nullable: false),
                    WEAPON_TYPE = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DAMAGE_TYPE = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weapons", x => x.WEAPON_ID);
                    table.ForeignKey(
                        name: "fk_WEAPONS_DICETHROWS1",
                        column: x => x.DAMAGE_DIE_ID,
                        principalTable: "dicethrows",
                        principalColumn: "DICETHROW_ID");
                    table.ForeignKey(
                        name: "fk_WEAPONS_E_DAMAGE_TYPES1",
                        column: x => x.DAMAGE_TYPE,
                        principalTable: "e_damage_types",
                        principalColumn: "NAME");
                    table.ForeignKey(
                        name: "fk_WEAPONS_E_WEAPON_TYPES1",
                        column: x => x.WEAPON_TYPE,
                        principalTable: "e_weapon_types",
                        principalColumn: "NAME");
                    table.ForeignKey(
                        name: "fk_WEAPONS_ITEMS1",
                        column: x => x.WEAPON_ID,
                        principalTable: "items",
                        principalColumn: "ITEM_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "class_has_proficiencies",
                columns: table => new
                {
                    ITEM_ID = table.Column<int>(type: "int", nullable: false),
                    CLASS_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.ITEM_ID, x.CLASS_ID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_ITEMS_has_CLASSES_CLASSES1",
                        column: x => x.CLASS_ID,
                        principalTable: "classes",
                        principalColumn: "CLASS_ID");
                    table.ForeignKey(
                        name: "fk_ITEMS_has_CLASSES_ITEMS1",
                        column: x => x.ITEM_ID,
                        principalTable: "items",
                        principalColumn: "ITEM_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "features_has_classes",
                columns: table => new
                {
                    FEATURE_ID = table.Column<int>(type: "int", nullable: false),
                    CLASS_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.FEATURE_ID, x.CLASS_ID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_FEATURES_has_CLASSES_CLASSES1",
                        column: x => x.CLASS_ID,
                        principalTable: "classes",
                        principalColumn: "CLASS_ID");
                    table.ForeignKey(
                        name: "fk_FEATURES_has_CLASSES_FEATURES1",
                        column: x => x.FEATURE_ID,
                        principalTable: "features",
                        principalColumn: "FEATURE_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "class_has_spells",
                columns: table => new
                {
                    CLASS_ID = table.Column<int>(type: "int", nullable: false),
                    SPELL_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.CLASS_ID, x.SPELL_ID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_CLASSES_has_SPELLS_CLASSES1",
                        column: x => x.CLASS_ID,
                        principalTable: "classes",
                        principalColumn: "CLASS_ID");
                    table.ForeignKey(
                        name: "fk_CLASSES_has_SPELLS_SPELLS1",
                        column: x => x.SPELL_ID,
                        principalTable: "spells",
                        principalColumn: "SPELL_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "characters",
                columns: table => new
                {
                    CHARACTER_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    RACE_ID = table.Column<int>(type: "int", nullable: false),
                    CLASS_ID = table.Column<int>(type: "int", nullable: false),
                    BACKGROUND_ID = table.Column<int>(type: "int", nullable: false),
                    MAX_HP = table.Column<int>(type: "int", nullable: false),
                    CURRENT_HP = table.Column<int>(type: "int", nullable: false),
                    TEMPORARY_HP = table.Column<int>(type: "int", nullable: false),
                    INSPIRATION = table.Column<sbyte>(type: "tinyint", nullable: false),
                    XP = table.Column<int>(type: "int", nullable: false),
                    BRONZE_COINS = table.Column<int>(type: "int", nullable: false),
                    SPEED = table.Column<int>(type: "int", nullable: false),
                    ALIGNMENT = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    HIT_DICE = table.Column<int>(type: "int", nullable: false),
                    ARMOR_CLASS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characters", x => x.CHARACTER_ID);
                    table.ForeignKey(
                        name: "fk_CHARACTERS_BACKGROUNDS1",
                        column: x => x.BACKGROUND_ID,
                        principalTable: "backgrounds",
                        principalColumn: "BACKGROUND_ID");
                    table.ForeignKey(
                        name: "fk_CHARACTERS_CLASSES1",
                        column: x => x.CLASS_ID,
                        principalTable: "classes",
                        principalColumn: "CLASS_ID");
                    table.ForeignKey(
                        name: "fk_CHARACTERS_RACES1",
                        column: x => x.RACE_ID,
                        principalTable: "races",
                        principalColumn: "RACE_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "race_has_traits",
                columns: table => new
                {
                    TRAIT_ID = table.Column<int>(type: "int", nullable: false),
                    RACE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.TRAIT_ID, x.RACE_ID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_TRAITS_has_RACES_RACES1",
                        column: x => x.RACE_ID,
                        principalTable: "races",
                        principalColumn: "RACE_ID");
                    table.ForeignKey(
                        name: "fk_TRAITS_has_RACES_TRAITS1",
                        column: x => x.TRAIT_ID,
                        principalTable: "traits",
                        principalColumn: "TRAIT_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "races_has_e_languages",
                columns: table => new
                {
                    RACE_ID = table.Column<int>(type: "int", nullable: false),
                    LANGUAGE_NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.RACE_ID, x.LANGUAGE_NAME })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_RACES_has_E_LANGUAGES_E_LANGUAGES1",
                        column: x => x.LANGUAGE_NAME,
                        principalTable: "e_languages",
                        principalColumn: "NAME");
                    table.ForeignKey(
                        name: "fk_RACES_has_E_LANGUAGES_RACES1",
                        column: x => x.RACE_ID,
                        principalTable: "races",
                        principalColumn: "RACE_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "abilities",
                columns: table => new
                {
                    ABILITY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ABILITY_SCORE = table.Column<int>(type: "int", nullable: false),
                    PROFICIENT = table.Column<sbyte>(type: "tinyint", nullable: false),
                    CHARACTER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abilities", x => x.ABILITY_ID);
                    table.ForeignKey(
                        name: "fk_ABILITIES_CHARACTERS1",
                        column: x => x.CHARACTER_ID,
                        principalTable: "characters",
                        principalColumn: "CHARACTER_ID");
                    table.ForeignKey(
                        name: "fk_E_ABILITIES_E_ABILITY_NAMES1",
                        column: x => x.NAME,
                        principalTable: "e_ability_names",
                        principalColumn: "NAME");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "character_has_languages",
                columns: table => new
                {
                    CHARACTER_ID = table.Column<int>(type: "int", nullable: false),
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.CHARACTER_ID, x.NAME })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_CHARACTERS_has_E_LANGUAGES_CHARACTERS1",
                        column: x => x.CHARACTER_ID,
                        principalTable: "characters",
                        principalColumn: "CHARACTER_ID");
                    table.ForeignKey(
                        name: "fk_CHARACTERS_has_E_LANGUAGES_E_LANGUAGES1",
                        column: x => x.NAME,
                        principalTable: "e_languages",
                        principalColumn: "NAME");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "character_has_spells",
                columns: table => new
                {
                    CHARACTER_ID = table.Column<int>(type: "int", nullable: false),
                    SPELL_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.CHARACTER_ID, x.SPELL_ID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_CHARACTERS_has_SPELLS_CHARACTERS1",
                        column: x => x.CHARACTER_ID,
                        principalTable: "characters",
                        principalColumn: "CHARACTER_ID");
                    table.ForeignKey(
                        name: "fk_CHARACTERS_has_SPELLS_SPELLS1",
                        column: x => x.SPELL_ID,
                        principalTable: "spells",
                        principalColumn: "SPELL_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "characters_has_items",
                columns: table => new
                {
                    CHARACTER_ID = table.Column<int>(type: "int", nullable: false),
                    ITEM_ID = table.Column<int>(type: "int", nullable: false),
                    AMOUNT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.CHARACTER_ID, x.ITEM_ID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_CHARACTERS_has_ITEMS_CHARACTERS1",
                        column: x => x.CHARACTER_ID,
                        principalTable: "characters",
                        principalColumn: "CHARACTER_ID");
                    table.ForeignKey(
                        name: "fk_CHARACTERS_has_ITEMS_ITEMS1",
                        column: x => x.ITEM_ID,
                        principalTable: "items",
                        principalColumn: "ITEM_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "characters_has_personalities",
                columns: table => new
                {
                    CHARACTER_ID = table.Column<int>(type: "int", nullable: false),
                    PERSONALITIES_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.CHARACTER_ID, x.PERSONALITIES_ID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_CHARACTERS_has_PERSONALITIES_CHARACTERS1",
                        column: x => x.CHARACTER_ID,
                        principalTable: "characters",
                        principalColumn: "CHARACTER_ID");
                    table.ForeignKey(
                        name: "fk_CHARACTERS_has_PERSONALITIES_PERSONALITIES1",
                        column: x => x.PERSONALITIES_ID,
                        principalTable: "personalities",
                        principalColumn: "PERSONALITIES_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "death_saves",
                columns: table => new
                {
                    CHARACTER_ID = table.Column<int>(type: "int", nullable: false),
                    SUCCESS = table.Column<sbyte>(type: "tinyint", nullable: false),
                    COUNT = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.CHARACTER_ID);
                    table.ForeignKey(
                        name: "fk_DEATH_SAVES_CHARACTERS1",
                        column: x => x.CHARACTER_ID,
                        principalTable: "characters",
                        principalColumn: "CHARACTER_ID");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    SKILL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PROFICIENT = table.Column<sbyte>(type: "tinyint", nullable: false),
                    ABILITY_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.SKILL_ID);
                    table.ForeignKey(
                        name: "fk_SKILLS_ABILITIES1",
                        column: x => x.ABILITY_ID,
                        principalTable: "abilities",
                        principalColumn: "ABILITY_ID");
                    table.ForeignKey(
                        name: "fk_SKILLS_E_SKILL_NAMES1",
                        column: x => x.NAME,
                        principalTable: "e_skill_names",
                        principalColumn: "NAME");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateIndex(
                name: "fk_ABILITIES_CHARACTERS1_idx",
                table: "abilities",
                column: "CHARACTER_ID");

            migrationBuilder.CreateIndex(
                name: "fk_E_ABILITIES_E_ABILITY_NAMES1_idx",
                table: "abilities",
                column: "NAME");

            migrationBuilder.CreateIndex(
                name: "fk_ARMORS_E_ARMOR_TYPE1_idx",
                table: "armors",
                column: "ARMOR_TYPE");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_has_E_LANGUAGES_CHARACTERS1_idx",
                table: "character_has_languages",
                column: "CHARACTER_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_has_E_LANGUAGES_E_LANGUAGES1_idx",
                table: "character_has_languages",
                column: "NAME");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_has_SPELLS_CHARACTERS1_idx",
                table: "character_has_spells",
                column: "CHARACTER_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_has_SPELLS_SPELLS1_idx",
                table: "character_has_spells",
                column: "SPELL_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_BACKGROUNDS1_idx",
                table: "characters",
                column: "BACKGROUND_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_CLASSES1_idx",
                table: "characters",
                column: "CLASS_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_RACES1_idx",
                table: "characters",
                column: "RACE_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_has_ITEMS_CHARACTERS1_idx",
                table: "characters_has_items",
                column: "CHARACTER_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_has_ITEMS_ITEMS1_idx",
                table: "characters_has_items",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_has_PERSONALITIES_CHARACTERS1_idx",
                table: "characters_has_personalities",
                column: "CHARACTER_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CHARACTERS_has_PERSONALITIES_PERSONALITIES1_idx",
                table: "characters_has_personalities",
                column: "PERSONALITIES_ID");

            migrationBuilder.CreateIndex(
                name: "fk_ITEMS_has_CLASSES_CLASSES1_idx",
                table: "class_has_proficiencies",
                column: "CLASS_ID");

            migrationBuilder.CreateIndex(
                name: "fk_ITEMS_has_CLASSES_ITEMS1_idx",
                table: "class_has_proficiencies",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CLASSES_has_SPELLS_CLASSES1_idx",
                table: "class_has_spells",
                column: "CLASS_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CLASSES_has_SPELLS_SPELLS1_idx",
                table: "class_has_spells",
                column: "SPELL_ID");

            migrationBuilder.CreateIndex(
                name: "fk_CLASSES_DICETHROWS1_idx",
                table: "classes",
                column: "HIT_DIE_ID");

            migrationBuilder.CreateIndex(
                name: "fk_FEATURES_has_CLASSES_CLASSES1_idx",
                table: "features_has_classes",
                column: "CLASS_ID");

            migrationBuilder.CreateIndex(
                name: "fk_FEATURES_has_CLASSES_FEATURES1_idx",
                table: "features_has_classes",
                column: "FEATURE_ID");

            migrationBuilder.CreateIndex(
                name: "fk_TRAITS_has_RACES_RACES1_idx",
                table: "race_has_traits",
                column: "RACE_ID");

            migrationBuilder.CreateIndex(
                name: "fk_TRAITS_has_RACES_TRAITS1_idx",
                table: "race_has_traits",
                column: "TRAIT_ID");

            migrationBuilder.CreateIndex(
                name: "fk_RACES_E_SIZE_idx",
                table: "races",
                column: "SIZE");

            migrationBuilder.CreateIndex(
                name: "fk_RACES_RACES1_idx",
                table: "races",
                column: "PARENT_RACE_ID");

            migrationBuilder.CreateIndex(
                name: "fk_RACES_has_E_LANGUAGES_E_LANGUAGES1_idx",
                table: "races_has_e_languages",
                column: "LANGUAGE_NAME");

            migrationBuilder.CreateIndex(
                name: "fk_RACES_has_E_LANGUAGES_RACES1_idx",
                table: "races_has_e_languages",
                column: "RACE_ID");

            migrationBuilder.CreateIndex(
                name: "fk_SKILLS_ABILITIES1_idx",
                table: "skills",
                column: "ABILITY_ID");

            migrationBuilder.CreateIndex(
                name: "fk_SKILLS_E_SKILL_NAMES1_idx",
                table: "skills",
                column: "NAME");

            migrationBuilder.CreateIndex(
                name: "fk_SPELLS_DICETHROWS1_idx",
                table: "spells",
                column: "DAMAGE_DIE_ID");

            migrationBuilder.CreateIndex(
                name: "fk_SPELLS_E_DAMAGE_TYPES1_idx",
                table: "spells",
                column: "DAMAGE_TYPE");

            migrationBuilder.CreateIndex(
                name: "fk_WEAPONS_DICETHROWS1_idx",
                table: "weapons",
                column: "DAMAGE_DIE_ID");

            migrationBuilder.CreateIndex(
                name: "fk_WEAPONS_E_DAMAGE_TYPES1_idx",
                table: "weapons",
                column: "DAMAGE_TYPE");

            migrationBuilder.CreateIndex(
                name: "fk_WEAPONS_E_WEAPON_TYPES1_idx",
                table: "weapons",
                column: "WEAPON_TYPE");

            migrationBuilder.CreateIndex(
                name: "fk_WEAPONS_ITEMS1_idx",
                table: "weapons",
                column: "WEAPON_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "armors");

            migrationBuilder.DropTable(
                name: "character_has_languages");

            migrationBuilder.DropTable(
                name: "character_has_spells");

            migrationBuilder.DropTable(
                name: "characters_has_items");

            migrationBuilder.DropTable(
                name: "characters_has_personalities");

            migrationBuilder.DropTable(
                name: "class_has_proficiencies");

            migrationBuilder.DropTable(
                name: "class_has_spells");

            migrationBuilder.DropTable(
                name: "death_saves");

            migrationBuilder.DropTable(
                name: "features_has_classes");

            migrationBuilder.DropTable(
                name: "race_has_traits");

            migrationBuilder.DropTable(
                name: "races_has_e_languages");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DropTable(
                name: "weapons");

            migrationBuilder.DropTable(
                name: "e_armor_type");

            migrationBuilder.DropTable(
                name: "personalities");

            migrationBuilder.DropTable(
                name: "spells");

            migrationBuilder.DropTable(
                name: "features");

            migrationBuilder.DropTable(
                name: "traits");

            migrationBuilder.DropTable(
                name: "e_languages");

            migrationBuilder.DropTable(
                name: "abilities");

            migrationBuilder.DropTable(
                name: "e_skill_names");

            migrationBuilder.DropTable(
                name: "e_weapon_types");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "e_damage_types");

            migrationBuilder.DropTable(
                name: "characters");

            migrationBuilder.DropTable(
                name: "e_ability_names");

            migrationBuilder.DropTable(
                name: "backgrounds");

            migrationBuilder.DropTable(
                name: "classes");

            migrationBuilder.DropTable(
                name: "races");

            migrationBuilder.DropTable(
                name: "dicethrows");

            migrationBuilder.DropTable(
                name: "e_size");
        }
    }
}
