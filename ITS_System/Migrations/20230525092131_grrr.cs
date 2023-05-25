using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexAppealFitness.Migrations
{
    public partial class grrr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65d3ebbb-37b4-4862-8419-24b03f93678d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b99c45ce-e9ca-49ce-b653-5410401041ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4774e17-50bd-450c-8cef-b5382db09085");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d73a5f88-0000-4ee8-be1d-49fa8b8cfeb4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed51fa1f-5555-46e8-86d0-6bd8a95e8874", "47254fad-a31a-4bf7-b491-bd1fefd37fe3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed51fa1f-5555-46e8-86d0-6bd8a95e8874");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47254fad-a31a-4bf7-b491-bd1fefd37fe3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "032372b7-56ea-43ab-b17f-07bd64451b9b", "389a76f0-26db-4cb9-9c7c-928bffe78724", "Instructor", "INSTRUCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c3b831f-940c-4d9a-b1ff-bbc4b20844d0", "69719265-2ba8-4c85-abbe-9cb266f48f4e", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69498813-2fde-4535-9ff7-f4d7d83d1b3f", "243c03e9-f1fd-44a5-ab3d-898f6676a169", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf013299-62d4-4d8e-94d3-30d7d6551610", "9f38f314-5537-4b63-b87a-a251d9457492", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec8db004-e122-4b5f-94a5-029af4e261ba", "2fd3fec8-d4b9-41a7-a0d3-38cd3837f776", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b34055aa-1863-4184-82aa-e8562dc910ae", 0, "11e525d8-fa14-47e5-b4c0-439904b4ea2c", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEM1K1EmFGR11BsufMXTAOCqSGR0NNHPict49BN9sowN8fmWXgmZ3ZUAGc71wwgm+GQ==", null, false, "c466a5ba-3b79-4f68-852f-ff1baac8735c", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cf013299-62d4-4d8e-94d3-30d7d6551610", "b34055aa-1863-4184-82aa-e8562dc910ae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "032372b7-56ea-43ab-b17f-07bd64451b9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c3b831f-940c-4d9a-b1ff-bbc4b20844d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69498813-2fde-4535-9ff7-f4d7d83d1b3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8db004-e122-4b5f-94a5-029af4e261ba");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf013299-62d4-4d8e-94d3-30d7d6551610", "b34055aa-1863-4184-82aa-e8562dc910ae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf013299-62d4-4d8e-94d3-30d7d6551610");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b34055aa-1863-4184-82aa-e8562dc910ae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65d3ebbb-37b4-4862-8419-24b03f93678d", "10dfd16f-4345-4f80-8d0b-4447dd8bead4", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b99c45ce-e9ca-49ce-b653-5410401041ef", "dad7a18a-66e3-413c-b5b1-349868f3430a", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4774e17-50bd-450c-8cef-b5382db09085", "8f61d945-d85d-4418-8000-0dce1ed127d2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d73a5f88-0000-4ee8-be1d-49fa8b8cfeb4", "82fc9717-a371-475f-950f-4c0e7f682aa0", "Instructor", "INSTRUCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed51fa1f-5555-46e8-86d0-6bd8a95e8874", "04440874-a28b-41ef-9315-601746a51367", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "47254fad-a31a-4bf7-b491-bd1fefd37fe3", 0, "5c29f7d6-c4ff-4d64-8298-2d11a37bd9b0", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGNinsm4w43q355fwC7QFHEWrTv6d9FDIIpV3gFlF+Mebfxd5kHgacDNkPnknZqC9g==", null, false, "31dd809c-155b-431b-a47c-f8c393686798", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ed51fa1f-5555-46e8-86d0-6bd8a95e8874", "47254fad-a31a-4bf7-b491-bd1fefd37fe3" });
        }
    }
}
