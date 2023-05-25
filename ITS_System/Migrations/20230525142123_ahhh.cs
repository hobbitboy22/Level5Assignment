using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexAppealFitness.Migrations
{
    public partial class ahhh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ebcb0a2-053e-4885-a841-e1f6a17a7a6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3968a76c-b9ce-4fcf-98f8-56ca6f36cd8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ee7243-f6f0-4b2b-8ceb-91b6cc6e1a03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f68b8e79-287a-44d7-8328-adc2c20a3c14");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea91ef70-ecae-431d-92d3-c7b514029c94", "a77910ce-855e-49ac-8004-edf8b764458c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea91ef70-ecae-431d-92d3-c7b514029c94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a77910ce-855e-49ac-8004-edf8b764458c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09527b55-842a-4b13-9125-4b52d2e5f8ce", "0766b2dc-839d-455c-a7c7-51d3a6a82137", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfc56e9d-b466-4495-840c-c3c86a7b3e7c", "3f27288c-ff07-498e-b6a8-f6c25ff927bd", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df5c56bb-128b-4dc2-8dab-048272b2fd03", "916dc335-17fe-4b31-aa55-0f58f1424db5", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3d00db6-2480-4024-bd7c-ae9bf47e3c74", "7f6ba558-ca02-4655-9327-909ad08aec95", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4139b49-e18d-4044-870c-e065c34b0c09", "107f2967-e81f-4610-a457-e3210d1c1b25", "Instructor", "INSTRUCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "549b322f-dc84-4b3d-b72e-edc02058516c", 0, "5926d1c5-9018-441d-9ccf-6da605cf5a62", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEH9KnhV++g3Q0TqS7oFreaaEJcdx3t8JAFQbQYLOksIAB2stxlWl9sMZlIGd1KTqHQ==", null, false, "0fe6e92b-1ab1-413d-bffb-42a6190b21ca", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09527b55-842a-4b13-9125-4b52d2e5f8ce", "549b322f-dc84-4b3d-b72e-edc02058516c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfc56e9d-b466-4495-840c-c3c86a7b3e7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df5c56bb-128b-4dc2-8dab-048272b2fd03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3d00db6-2480-4024-bd7c-ae9bf47e3c74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4139b49-e18d-4044-870c-e065c34b0c09");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09527b55-842a-4b13-9125-4b52d2e5f8ce", "549b322f-dc84-4b3d-b72e-edc02058516c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09527b55-842a-4b13-9125-4b52d2e5f8ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "549b322f-dc84-4b3d-b72e-edc02058516c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ebcb0a2-053e-4885-a841-e1f6a17a7a6d", "87600d04-7441-4c0f-84f8-dd4288af29be", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3968a76c-b9ce-4fcf-98f8-56ca6f36cd8b", "7d406a9b-5999-4874-834f-b4bfdcc1a798", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea91ef70-ecae-431d-92d3-c7b514029c94", "7cabd9aa-6603-405f-a012-787f4f995b01", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2ee7243-f6f0-4b2b-8ceb-91b6cc6e1a03", "3f7a7f73-e85c-4c04-b77b-97afdd651dc0", "Instructor", "INSTRUCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f68b8e79-287a-44d7-8328-adc2c20a3c14", "c8b1f8fc-74c4-442e-8e2d-3a9879e2375b", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a77910ce-855e-49ac-8004-edf8b764458c", 0, "8d223c61-02f6-4631-b59f-f493fa960829", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEG56Wd2muI4KTGtz+cXbwdokYhK/gdwB4ZMUlYof8SjtwA9JUq6oBrLCiANer2axqg==", null, false, "79f5ae76-b98d-4f73-a419-4d8c9f169455", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ea91ef70-ecae-431d-92d3-c7b514029c94", "a77910ce-855e-49ac-8004-edf8b764458c" });
        }
    }
}
