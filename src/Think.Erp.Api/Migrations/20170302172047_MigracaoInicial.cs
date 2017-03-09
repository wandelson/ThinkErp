using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Think.Erp.Api.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entities",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    abbreviation = table.Column<string>(type: "varchar(255)", nullable: true),
                    address_id = table.Column<int>(nullable: true),
                    bank_account_id = table.Column<int>(nullable: true),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    economic_activity_id = table.Column<int>(nullable: true),
                    email_id = table.Column<int>(nullable: true),
                    entity_type_id = table.Column<int>(nullable: true),
                    first_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    full_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    gender_id = table.Column<int>(nullable: true),
                    uuid = table.Column<Guid>(nullable: false),
                    last_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    marital_status_id = table.Column<int>(nullable: true),
                    monthly_income = table.Column<decimal>(type: "decimal", nullable: true),
                    nickname = table.Column<string>(type: "varchar(255)", nullable: true),
                    patrimony = table.Column<decimal>(type: "decimal", nullable: true),
                    phone_id = table.Column<int>(nullable: true),
                    status_id = table.Column<int>(nullable: true),
                    taxpayer_registry_number = table.Column<long>(nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    yearly_income = table.Column<decimal>(type: "decimal", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entities", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entities");
        }
    }
}
