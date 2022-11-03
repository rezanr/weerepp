using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppleWatchReprationPreis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skærm_A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm_C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm_D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri_A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri_A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    p_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppleWatchReprationPreis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CpmputerReparationPrice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ydelse_A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_F = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_F = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_G = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_G = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_H = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_H = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_I = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_I = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_K = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_K = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_L = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_L = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ydelse_M = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pris_M = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CpmputerReparationPrice", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Galaxy_A_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galaxy_A_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Galaxy_J_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galaxy_J_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Galaxy_S_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galaxy_S_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Galaxy_Xcover_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galaxy_Xcover_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GalaxyNoteSerien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalaxyNoteSerien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Huawei_Mate_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huawei_Mate_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Huawei_P_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huawei_P_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ImacReparation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ØreHøjtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_ØreHøjtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    front_Kamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_front_Kamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bakkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bakkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImacReparation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IpadReprationPreis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkærmLcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_SkærmLcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Panserglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Panserglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIM_KORT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_SIM_KORT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagcover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagcover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kamera_Glas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Kamera_Glas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Home_Knap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Home_Knap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WIFI_Antenne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_WIFI_Antenne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Antenne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Antenne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpadReprationPreis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IphoneReprationPreis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkærmOEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_SkærmOEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkærmOrgnal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_SkærmOrgnal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BagglasOgRamme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_BagglasOgRamme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKameraNærhedsensor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKameraNærhedsensor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TændSluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_TændSluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolumeLydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_VolumeLydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IphoneReprationPreis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MacbookReparation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tastetur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tastetur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Styresystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Styresystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackPad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_TrackPad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blæser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Blæser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bundplade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bundplade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MacbookReparation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Motorola_E_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorola_E_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Motorola_G_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorola_G_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MotorolaEdge_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorolaEdge_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MotorolaOne_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorolaOne_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NokiaRepartionPrice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NokiaRepartionPrice", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OneplusReparation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rensning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_rensning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_UV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneplusReparation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Xperia_X_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xperia_X_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Xperia_Z_Serien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xperia_Z_Serien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "XperiaTopModeller",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Skærm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Batteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagglas_Ramme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ørehøjtaler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_FrontKamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Bagkamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Ladestik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Højtale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Vibrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Tænd_Sluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Volume_Lydløs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Fejlfinding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XperiaTopModeller", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AppleWatchReprationPreis",
                columns: new[] { "ID", "Batteri_A", "Batteri_B", "Fejlfinding", "ImageName", "P_Batteri_A", "P_Batteri_B", "P_Skærm_A", "P_Skærm_B", "P_Skærm_C", "P_Skærm_D", "PhoneName", "Skærm_A", "Skærm_B", "Skærm_C", "Skærm_D", "p_Fejlfinding" },
                values: new object[] { 1, "Udskiftning af Batteri – 40mm", "Udskiftning af Batteri – 40mm", "Fejlfinding", "Apple Watch.png", "200", "200", "500", "500", "500", "500", "Apple Watch Serie 6", "Udskiftning af skærm – GPS 40mm (OEM)", "Udskiftning af skærm – GPS 40mm (OEM)", "Udskiftning af skærm – GPS 40mm (OEM)", "Udskiftning af skærm – GPS 40mm (OEM)", " 0" });

            migrationBuilder.InsertData(
                table: "CpmputerReparationPrice",
                columns: new[] { "ID", "ImageName", "PhoneName", "Pris_A", "Pris_B", "Pris_C", "Pris_D", "Pris_E", "Pris_F", "Pris_G", "Pris_H", "Pris_I", "Pris_K", "Pris_L", "Pris_M", "Ydelse_A", "Ydelse_B", "Ydelse_C", "Ydelse_D", "Ydelse_E", "Ydelse_F", "Ydelse_G", "Ydelse_H", "Ydelse_I", "Ydelse_K", "Ydelse_L", "Ydelse_M" },
                values: new object[] { 1, "iphone.png", "iPhone 13 Pro Max", "3299,-", "Kontakt", "999,-", "1999,-", "1999,-", "2499,-", "1499,-", "1499,-", "	1199,-", "	1199,-", "	1199,-", "249,-", "Udskiftning af skærm (OEM)", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Udskiftning af Bagglas", "Udskiftning af Bagglas", "Udskiftning af Bagglas og Ramme", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Højtaler (Musik)", "Fejlfinding" });

            migrationBuilder.InsertData(
                table: "GalaxyNoteSerien",
                columns: new[] { "ID", "Bagglas", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Tænd_Sluk", "P_UV", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Tænd_Sluk", "UV", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ørehøjtaler", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Galaxy_A_Serien",
                columns: new[] { "ID", "Bagglas", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Tænd_Sluk", "P_UV", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Tænd_Sluk", "UV", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ørehøjtaler", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Galaxy_J_Serien",
                columns: new[] { "ID", "Bagglas", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Tænd_Sluk", "P_UV", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Tænd_Sluk", "UV", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ørehøjtaler", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Galaxy_S_Serien",
                columns: new[] { "ID", "Bagglas", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Tænd_Sluk", "P_UV", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Tænd_Sluk", "UV", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ørehøjtaler", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Galaxy_Xcover_Serien",
                columns: new[] { "ID", "Bagglas", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Tænd_Sluk", "P_UV", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Tænd_Sluk", "UV", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ørehøjtaler", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Huawei_Mate_Serien",
                columns: new[] { "ID", "Bagglas", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Tænd_Sluk", "P_UV", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Tænd_Sluk", "UV", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ørehøjtaler", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Huawei_P_Serien",
                columns: new[] { "ID", "Bagglas", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Tænd_Sluk", "P_UV", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Tænd_Sluk", "UV", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ørehøjtaler", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "ImacReparation",
                columns: new[] { "ID", "Bagglas", "Bagglas_Ramme", "Bakkamera", "Batteri", "Fejlfinding", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagglas_Ramme", "P_Bakkamera", "P_Batteri", "P_Fejlfinding", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Skærm_B", "P_Tænd_Sluk", "P_Vibrator", "P_Volume_Lydløs", "P_front_Kamera", "P_ØreHøjtale", "PhoneName", "Skærm", "Skærm_B", "Tænd_Sluk", "Vibrator", "Volume_Lydløs", "front_Kamera", "ØreHøjtale" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Bagglas", "Udskiftning af Ørehøjtaler", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "1999,-", "1199,-", "999,-", "249,-", "	1199,-", "1499,-", "3299,-", "Kontakt", "	1199,-", "1499,-", "	1199,-", "1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af skærm (Original)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ørehøjtaler", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "ImageName" },
                values: new object[] { 1, "iphone.png" });

            migrationBuilder.InsertData(
                table: "IpadReprationPreis",
                columns: new[] { "ID", "Antenne", "Bagcover", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Home_Knap", "Højtale", "ImageName", "Kamera_Glas", "Ladestik", "P_Antenne", "P_Bagcover", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Home_Knap", "P_Højtale", "P_Kamera_Glas", "P_Ladestik", "P_Panserglas", "P_SIM_KORT", "P_Skærm", "P_SkærmLcd", "P_Tænd_Sluk", "P_WIFI_Antenne", "Panserglas", "PhoneName", "SIM_KORT", "Skærm", "SkærmLcd", "Tænd_Sluk", "WIFI_Antenne" },
                values: new object[] { 1, "Udskiftning af Vibrator", "Udskiftning af Tænd/Sluk funktion", "Udskiftning af Bagkamera", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af front Kamera og nærhedsensor", "Udskiftning af Tænd/Sluk funktion", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Bagglas og Ramme", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1199,-", "1199,-", "1999,-", "999,-", "249,-", "1999,-", "1199,-", "	1199,-", "2499,-", "1499,-", "1999,-", "1199,-", "3299,-", "Kontakt", "1999,-", "1199,-", "Udskiftning af Bagglas", "iPhone 13 Pro Max", "Udskiftning af Ørehøjtaler", "Udskiftning af skærm (OEM)", "Udskiftning af skærm (Original)", "Udskiftning af Bagglas", "Udskiftning af Volume/Lydløs knapper" });

            migrationBuilder.InsertData(
                table: "IphoneReprationPreis",
                columns: new[] { "ID", "Bagglas", "BagglasOgRamme", "Bagkamera", "Batteri", "Fejlfinding", "FrontKameraNærhedsensor", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_BagglasOgRamme", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKameraNærhedsensor", "P_Højtale", "P_Ladestik", "P_SkærmOEM", "P_SkærmOrgnal", "P_TændSluk", "P_Vibrator", "P_VolumeLydløs", "P_Ørehøjtaler", "PhoneName", "SkærmOEM", "SkærmOrgnal", "TændSluk", "Vibrator", "VolumeLydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Bagglas og Ramme", "Udskiftning af Bagkamera", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af front Kamera og nærhedsensor", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "2499,-", "1999,-", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "Kontakt", "1199,-", "1199,-", "1199,-", "1199,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af skærm (Original)", "Udskiftning af Tænd/Sluk funktion", "Udskiftning af Vibrator", "Udskiftning af Volume/Lydløs knapper", "Udskiftning af Ørehøjtaler" });

            migrationBuilder.InsertData(
                table: "MacbookReparation",
                columns: new[] { "ID", "Batteri", "Blæser", "Bundplade", "Fejlfinding", "Højtale", "ImageName", "Ladestik", "P_Batteri", "P_Blæser", "P_Bundplade", "P_Fejlfinding", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Styresystem", "P_Tastetur", "P_TrackPad", "PhoneName", "Skærm", "Styresystem", "Tastetur", "TrackPad" },
                values: new object[] { 1, "Udskiftning af Batteri", "Udskiftning af Bagglas og Ramme", "Udskiftning af Ørehøjtaler", "Fejlfinding", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "999,-", "2499,-", "1199,-", "249,-", "	1199,-", "1499,-", "3299,-", "1999,-", "Kontakt", "1999,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Bagglas", "Udskiftning af skærm (Original)", "Udskiftning af Bagglas" });

            migrationBuilder.InsertData(
                table: "MotorolaEdge_Serien",
                columns: new[] { "ID", "Bagglas", "Bagglas_Ramme", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagglas_Ramme", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Skærm_B", "P_Tænd_Sluk", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Skærm_B", "Tænd_Sluk", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "	1199,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "	1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "MotorolaOne_Serien",
                columns: new[] { "ID", "Bagglas", "Bagglas_Ramme", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagglas_Ramme", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Skærm_B", "P_Tænd_Sluk", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Skærm_B", "Tænd_Sluk", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "	1199,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "	1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Motorola_E_Serien",
                columns: new[] { "ID", "Bagglas", "Bagglas_Ramme", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagglas_Ramme", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Skærm_B", "P_Tænd_Sluk", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Skærm_B", "Tænd_Sluk", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "	1199,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "	1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Motorola_G_Serien",
                columns: new[] { "ID", "Bagglas", "Bagglas_Ramme", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagglas_Ramme", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Skærm_B", "P_Tænd_Sluk", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Skærm_B", "Tænd_Sluk", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "	1199,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "	1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "NokiaRepartionPrice",
                columns: new[] { "ID", "Bagglas", "Bagglas_Ramme", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagglas_Ramme", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Skærm_B", "P_Tænd_Sluk", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Skærm_B", "Tænd_Sluk", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "	1199,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "	1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "OneplusReparation",
                columns: new[] { "ID", "Bagglas", "Bagglas_Ramme", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagglas_Ramme", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Skærm_B", "P_Tænd_Sluk", "P_UV", "P_Vibrator", "P_Volume_Lydløs", "P_rensning", "P_Ørehøjtaler", "PhoneName", "Skærm", "Skærm_B", "Tænd_Sluk", "UV", "Vibrator", "Volume_Lydløs", "rensning", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "	1199,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "	1199,-", "1199,-", "1499,-", "	1199,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ørehøjtaler", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "XperiaTopModeller",
                columns: new[] { "ID", "Bagglas", "Bagglas_Ramme", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagglas_Ramme", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Tænd_Sluk", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Tænd_Sluk", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "	1199,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Xperia_X_Serien",
                columns: new[] { "ID", "Bagglas", "Bagglas_Ramme", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagglas_Ramme", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Tænd_Sluk", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Tænd_Sluk", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "	1199,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });

            migrationBuilder.InsertData(
                table: "Xperia_Z_Serien",
                columns: new[] { "ID", "Bagglas", "Bagglas_Ramme", "Bagkamera", "Batteri", "Fejlfinding", "FrontKamera", "Højtale", "ImageName", "Ladestik", "P_Bagglas", "P_Bagglas_Ramme", "P_Bagkamera", "P_Batteri", "P_Fejlfinding", "P_FrontKamera", "P_Højtale", "P_Ladestik", "P_Skærm", "P_Tænd_Sluk", "P_Vibrator", "P_Volume_Lydløs", "P_Ørehøjtaler", "PhoneName", "Skærm", "Tænd_Sluk", "Vibrator", "Volume_Lydløs", "Ørehøjtaler" },
                values: new object[] { 1, "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "Udskiftning af skærm (Original)", "Udskiftning af Batteri", "Fejlfinding", "Udskiftning af Bagglas", "Udskiftning af Højtaler (Musik)", "iphone.png", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "1999,-", "	1199,-", "Kontakt", "999,-", "249,-", "1999,-", "	1199,-", "1499,-", "3299,-", "	1199,-", "1499,-", "	1199,-", "2499,-", "iPhone 13 Pro Max", "Udskiftning af skærm (OEM)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Ladestik med (Mikrofon og Jack stik)", "Udskiftning af Højtaler (Musik)", "Udskiftning af Bagglas og Ramme" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppleWatchReprationPreis");

            migrationBuilder.DropTable(
                name: "CpmputerReparationPrice");

            migrationBuilder.DropTable(
                name: "Galaxy_A_Serien");

            migrationBuilder.DropTable(
                name: "Galaxy_J_Serien");

            migrationBuilder.DropTable(
                name: "Galaxy_S_Serien");

            migrationBuilder.DropTable(
                name: "Galaxy_Xcover_Serien");

            migrationBuilder.DropTable(
                name: "GalaxyNoteSerien");

            migrationBuilder.DropTable(
                name: "Huawei_Mate_Serien");

            migrationBuilder.DropTable(
                name: "Huawei_P_Serien");

            migrationBuilder.DropTable(
                name: "ImacReparation");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "IpadReprationPreis");

            migrationBuilder.DropTable(
                name: "IphoneReprationPreis");

            migrationBuilder.DropTable(
                name: "MacbookReparation");

            migrationBuilder.DropTable(
                name: "Motorola_E_Serien");

            migrationBuilder.DropTable(
                name: "Motorola_G_Serien");

            migrationBuilder.DropTable(
                name: "MotorolaEdge_Serien");

            migrationBuilder.DropTable(
                name: "MotorolaOne_Serien");

            migrationBuilder.DropTable(
                name: "NokiaRepartionPrice");

            migrationBuilder.DropTable(
                name: "OneplusReparation");

            migrationBuilder.DropTable(
                name: "Xperia_X_Serien");

            migrationBuilder.DropTable(
                name: "Xperia_Z_Serien");

            migrationBuilder.DropTable(
                name: "XperiaTopModeller");
        }
    }
}
