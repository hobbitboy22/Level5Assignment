using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexAppealFitness.Migrations
{
    public partial class sad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bcb8c18-69df-4ec6-8afa-766333491ad6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4a92862-d12a-4210-af3b-3b85f168cb2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfd471b1-1f51-4dd7-8578-609b6c5a8f68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f976d0b6-95f0-4a60-9afb-d8ad81442ae5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93dbbb4d-9041-40e1-9cf2-c9f95a400c47", "a5359924-7f99-4edd-9f2a-09449eb29690" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93dbbb4d-9041-40e1-9cf2-c9f95a400c47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5359924-7f99-4edd-9f2a-09449eb29690");

            migrationBuilder.DropColumn(
                name: "ClassName",
                table: "Bookings");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ClassName",
                table: "Bookings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bcb8c18-69df-4ec6-8afa-766333491ad6", "2721eb11-9325-48fc-a3fc-591504bad4de", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93dbbb4d-9041-40e1-9cf2-c9f95a400c47", "32b221e8-794b-45ec-8ed4-6769a923156e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4a92862-d12a-4210-af3b-3b85f168cb2a", "4b941fbb-cec1-4b5c-9690-e73cf8bc6394", "Instructor", "INSTRUCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfd471b1-1f51-4dd7-8578-609b6c5a8f68", "f6d43f1f-de49-44e0-ad5a-4694b25c4877", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f976d0b6-95f0-4a60-9afb-d8ad81442ae5", "7a42390e-2863-4513-a0e6-fe987347daf3", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a5359924-7f99-4edd-9f2a-09449eb29690", 0, "f4e47a88-149f-4a58-81c4-b947ab6cca32", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGMG8Jr1vMbDeFKA0NS1iGDxckaLs1lYNzOh4DRL82kyIvZrMNFFM5+aaIvF6MGBqA==", null, false, "e4aa1759-ded4-4db0-8088-43b377e1b001", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "93dbbb4d-9041-40e1-9cf2-c9f95a400c47", "a5359924-7f99-4edd-9f2a-09449eb29690" });
        }
    }
}
