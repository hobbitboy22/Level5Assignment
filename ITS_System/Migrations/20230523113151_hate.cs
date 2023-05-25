using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexAppealFitness.Migrations
{
    public partial class hate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1f1e3f6-6552-4fff-958e-18ce01c89b03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3b7388a-5afa-4d7d-876b-98fbfa302c56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7d0412a-fbdb-441b-9838-e58d7dc34ac3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb530d29-c3cc-4633-9541-cb855e2b746b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea2006df-95ce-4ed5-873f-9b079ccf89f9", "32bf764c-57cf-4409-aa7f-f842e940044b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea2006df-95ce-4ed5-873f-9b079ccf89f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32bf764c-57cf-4409-aa7f-f842e940044b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1fe45333-16ae-4bc5-a3a0-64dfa48c673e", "d756c6cf-3be5-4f87-bc1d-ef02510173cd", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4250b159-4e2c-4acb-8e87-93e5b84c0972", "94f84e33-f951-42c3-8929-e6c940182088", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b26b788-21bc-4ae9-a6f1-1c45558fd38d", "35eb459a-38c2-469c-92c6-b9e07c0aa9c8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e5abcd7-f2c4-4df2-815b-4742a664b971", "eeb63b78-c10e-401e-a7ec-f7e696e9cdd0", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f757f660-d742-41ae-af11-a77b79fad350", "d4111464-3c89-474a-88ad-db352ae5f216", "Instructor", "INSTRUCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "23b74423-e6e5-4b1a-954c-240f3a805418", 0, "da68e202-f5a7-44f3-96c8-c525fbfd4f7f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEMu/V3l+zTNkVPlJMlT5Sysv07JjbHLJbRYPPa/NcxMTKmvnnVblOYJ3a7VSUxZFKQ==", null, false, "7b386046-841e-451e-9ace-c5459a3924b1", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4250b159-4e2c-4acb-8e87-93e5b84c0972", "23b74423-e6e5-4b1a-954c-240f3a805418" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fe45333-16ae-4bc5-a3a0-64dfa48c673e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b26b788-21bc-4ae9-a6f1-1c45558fd38d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e5abcd7-f2c4-4df2-815b-4742a664b971");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f757f660-d742-41ae-af11-a77b79fad350");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4250b159-4e2c-4acb-8e87-93e5b84c0972", "23b74423-e6e5-4b1a-954c-240f3a805418" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4250b159-4e2c-4acb-8e87-93e5b84c0972");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23b74423-e6e5-4b1a-954c-240f3a805418");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1f1e3f6-6552-4fff-958e-18ce01c89b03", "cc1e8355-5f7f-42f6-9f58-c0b9e1b53e04", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3b7388a-5afa-4d7d-876b-98fbfa302c56", "f45196e4-714d-402c-b3ab-4ac8cabf968a", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea2006df-95ce-4ed5-873f-9b079ccf89f9", "7b4c480a-9fb8-4f97-abf3-ee81c808f74f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7d0412a-fbdb-441b-9838-e58d7dc34ac3", "010b1fa4-e282-483a-a875-2a6960447113", "Instructor", "INSTRUCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb530d29-c3cc-4633-9541-cb855e2b746b", "b2797a55-2ff0-470b-9b44-df99b141fbc6", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "32bf764c-57cf-4409-aa7f-f842e940044b", 0, "bf295a03-9d8e-42a8-bf18-a8ca8f92ee53", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEASvLSHa7zSh23verShH3JrCMBWVYyD9MGmtivLMlHP6301wkXS+wg36i67xqSIrIA==", null, false, "dff28b79-833f-44f1-ae3c-f8665698bd86", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ea2006df-95ce-4ed5-873f-9b079ccf89f9", "32bf764c-57cf-4409-aa7f-f842e940044b" });
        }
    }
}
