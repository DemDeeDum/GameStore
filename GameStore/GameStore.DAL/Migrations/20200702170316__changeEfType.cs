using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.DAL.Migrations
{
    public partial class _changeEfType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "32103412-d5a4-4186-ba71-9ca25a0f3d64", "d640fbe2-73a2-40ab-bf22-27df5fc9918a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d640fbe2-73a2-40ab-bf22-27df5fc9918a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32103412-d5a4-4186-ba71-9ca25a0f3d64");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "acdbbf01-f2e9-4935-aa5a-4e46be592996", "33091d1c-2300-4e99-af26-ae78bac82f6f", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f473b5c4-520a-40cf-8fbb-1df8c7908872", 0, "7989c6a9-666d-4cca-80b7-b1114e8f46b6", "my@email.com", true, false, null, "MY@EMAIL.COM", "MAINADMIN", "AQAAAAEAACcQAAAAEJQ9ds6y3HYIRMvmxgZ9aYBb4U8cY+frvMOzdsiYXVYsx+vkN/tKe5/sEKzpyVtxfw==", null, false, "", false, "MainAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "f473b5c4-520a-40cf-8fbb-1df8c7908872", "acdbbf01-f2e9-4935-aa5a-4e46be592996" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f473b5c4-520a-40cf-8fbb-1df8c7908872", "acdbbf01-f2e9-4935-aa5a-4e46be592996" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acdbbf01-f2e9-4935-aa5a-4e46be592996");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f473b5c4-520a-40cf-8fbb-1df8c7908872");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d640fbe2-73a2-40ab-bf22-27df5fc9918a", "18aaf2ba-12c6-4008-952e-6df64428beb4", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "32103412-d5a4-4186-ba71-9ca25a0f3d64", 0, "8643df65-f9bf-468f-87fc-a6ee5a53a319", "my@email.com", true, false, null, "MY@EMAIL.COM", "MAINADMIN", "AQAAAAEAACcQAAAAEB7Dpo9S3+Iik+9jR3DiWb8x7LuiWV0OWAg2Iu4YDmGkzqAtpOURcIPePpttDoIEzQ==", null, false, "", false, "MainAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "32103412-d5a4-4186-ba71-9ca25a0f3d64", "d640fbe2-73a2-40ab-bf22-27df5fc9918a" });
        }
    }
}
