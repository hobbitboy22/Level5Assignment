using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexAppealFitness.Migrations
{
    public partial class anger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c45783e-0bc1-439e-9d91-2f0a7a9614af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bae0c29b-076e-4ca8-9f49-5a4025295476");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f457c893-832d-4591-a02a-422d18591232");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff8bffc5-29c4-4ec6-8f77-f333a239c8d7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f49d2cc-afbc-47ff-92f8-03ccaac8526a", "92539951-1b9b-4758-bc42-ab8ff0ea9e23" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f49d2cc-afbc-47ff-92f8-03ccaac8526a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92539951-1b9b-4758-bc42-ab8ff0ea9e23");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0f49d2cc-afbc-47ff-92f8-03ccaac8526a", "d1945d4d-0fa3-4520-8d2a-b6569024c812", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c45783e-0bc1-439e-9d91-2f0a7a9614af", "3eae6c61-ef48-4c9b-b098-27f30b7197c9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bae0c29b-076e-4ca8-9f49-5a4025295476", "4a9d9401-f247-45e0-906d-816a6cc52533", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f457c893-832d-4591-a02a-422d18591232", "e9ecb8b0-9675-458f-aeab-95620994d75e", "Instructor", "INSTRUCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff8bffc5-29c4-4ec6-8f77-f333a239c8d7", "45cdb889-1cf2-4c0b-b2f5-e3cbcc834b15", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "92539951-1b9b-4758-bc42-ab8ff0ea9e23", 0, "5f421a7a-1885-4c6d-9119-bf5558524dd4", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEMzXp9Y4GS6kzZKvFzmm3XFcv+H/rflOYMjMDSqmNJjOv50JMZTzDVV6r2f6mvOCmw==", null, false, "4225f50e-bd04-4b63-8558-1b2d7b86f55c", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0f49d2cc-afbc-47ff-92f8-03ccaac8526a", "92539951-1b9b-4758-bc42-ab8ff0ea9e23" });
        }
    }
}
