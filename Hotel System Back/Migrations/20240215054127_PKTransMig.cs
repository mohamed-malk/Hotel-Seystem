﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_System_Back.Migrations
{
    /// <inheritdoc />
    public partial class PKTransMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TransactionTable",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionTable",
                table: "TransactionTable",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionTable",
                table: "TransactionTable");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TransactionTable");
        }
    }
}
