using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEngagedUntil_and_IsDeleted_Fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerType_ContainerTypeId",
                table: "Containers");

            migrationBuilder.RenameColumn(
                name: "ContainerTypeId",
                table: "Containers",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Containers_ContainerTypeId",
                table: "Containers",
                newName: "IX_Containers_TypeId");

            migrationBuilder.AddColumn<DateTime>(
                name: "EngagedUntil",
                table: "Containers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Containers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerType_TypeId",
                table: "Containers",
                column: "TypeId",
                principalTable: "ContainerType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerType_TypeId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "EngagedUntil",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Containers");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Containers",
                newName: "ContainerTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Containers_TypeId",
                table: "Containers",
                newName: "IX_Containers_ContainerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerType_ContainerTypeId",
                table: "Containers",
                column: "ContainerTypeId",
                principalTable: "ContainerType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
