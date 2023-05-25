using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexAppealFitness.Migrations
{
    public partial class ahhhh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Bookings");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Bookings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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
    }
}
