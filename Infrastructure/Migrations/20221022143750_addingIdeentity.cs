using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class addingIdeentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppleWatchReprationPreis",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CpmputerReparationPrice",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GalaxyNoteSerien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Galaxy_A_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Galaxy_J_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Galaxy_S_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Galaxy_Xcover_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Huawei_Mate_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Huawei_P_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ImacReparation",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IpadReprationPreis",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IphoneReprationPreis",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MacbookReparation",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MotorolaEdge_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MotorolaOne_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Motorola_E_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Motorola_G_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NokiaRepartionPrice",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OneplusReparation",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "XperiaTopModeller",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Xperia_X_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Xperia_Z_Serien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
