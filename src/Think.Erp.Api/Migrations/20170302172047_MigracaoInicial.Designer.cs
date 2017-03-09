using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Think.Erp.Api.Data.Contexts;

namespace Think.Erp.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170302172047_MigracaoInicial")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Think.Erp.Api.Domain.Entities.Entity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Abbreviation")
                        .HasColumnName("abbreviation")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("AddressId")
                        .HasColumnName("address_id");

                    b.Property<int?>("BankAccountId")
                        .HasColumnName("bank_account_id");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnName("birthday")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime");

                    b.Property<int?>("EconomicActivityId")
                        .HasColumnName("economic_activity_id");

                    b.Property<int?>("EmailId")
                        .HasColumnName("email_id");

                    b.Property<int?>("EntityTypeId")
                        .HasColumnName("entity_type_id");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FullName")
                        .HasColumnName("full_name")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("GenderId")
                        .HasColumnName("gender_id");

                    b.Property<Guid>("Guid")
                        .HasColumnName("uuid");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("MaritalStatusId")
                        .HasColumnName("marital_status_id");

                    b.Property<decimal?>("MonthlyIncome")
                        .HasColumnName("monthly_income")
                        .HasColumnType("decimal");

                    b.Property<string>("Nickname")
                        .HasColumnName("nickname")
                        .HasColumnType("varchar(255)");

                    b.Property<decimal?>("Patrimony")
                        .HasColumnName("patrimony")
                        .HasColumnType("decimal");

                    b.Property<int?>("PhoneId")
                        .HasColumnName("phone_id");

                    b.Property<int?>("StatusId")
                        .HasColumnName("status_id");

                    b.Property<long?>("TaxpayerRegistryNumber")
                        .HasColumnName("taxpayer_registry_number");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("YearlyIncome")
                        .HasColumnName("yearly_income")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.ToTable("entities");
                });
        }
    }
}
