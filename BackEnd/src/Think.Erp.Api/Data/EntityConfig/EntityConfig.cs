
using Microsoft.EntityFrameworkCore;
using Think.Erp.Api.Domain.Entities;


namespace Think.Erp.Api.Data.Contexts
{   public static class EntityConfig
    {
        public static void AddEntityConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>(entity =>
                 {
                     entity.ToTable("entities");

                     entity.Property(e => e.Id).HasColumnName("id");

                     entity.Property(e => e.Abbreviation)
                         .HasColumnName("abbreviation")
                         .HasColumnType("varchar(255)");

                     entity.Property(e => e.AddressId).HasColumnName("address_id");

                     entity.Property(e => e.BankAccountId).HasColumnName("bank_account_id");

                     entity.Property(e => e.Birthday)
                         .HasColumnName("birthday")
                         .HasColumnType("datetime");

                     entity.Property(e => e.CreatedAt)
                         .HasColumnName("created_at")
                         .HasColumnType("datetime");    

                     entity.Property(e => e.EconomicActivityId).HasColumnName("economic_activity_id");

                     entity.Property(e => e.EmailId).HasColumnName("email_id");

                     entity.Property(e => e.EntityTypeId).HasColumnName("entity_type_id");

                     entity.Property(e => e.FirstName)
                         .HasColumnName("first_name")
                         .HasColumnType("varchar(255)");

                     entity.Property(e => e.FullName)
                         .HasColumnName("full_name")
                         .HasColumnType("varchar(255)");

                     entity.Property(e => e.GenderId).HasColumnName("gender_id");

                     entity.Property(e => e.Guid).HasColumnName("uuid");

                     entity.Property(e => e.LastName)
                         .HasColumnName("last_name")
                         .HasColumnType("varchar(255)");

                     entity.Property(e => e.MaritalStatusId).HasColumnName("marital_status_id");

                     entity.Property(e => e.MonthlyIncome)
                         .HasColumnName("monthly_income")
                         .HasColumnType("decimal");

                     entity.Property(e => e.Nickname)
                         .HasColumnName("nickname")
                         .HasColumnType("varchar(255)");

                     entity.Property(e => e.Patrimony)
                         .HasColumnName("patrimony")
                         .HasColumnType("decimal");

                     entity.Property(e => e.PhoneId).HasColumnName("phone_id");

      

                     entity.Property(e => e.StatusId).HasColumnName("status_id");

                     entity.Property(e => e.TaxpayerRegistryNumber).HasColumnName("taxpayer_registry_number");

                     entity.Property(e => e.UpdatedAt)
                         .HasColumnName("updated_at")
                         .HasColumnType("datetime");

                     entity.Property(e => e.YearlyIncome)
                         .HasColumnName("yearly_income")
                         .HasColumnType("decimal");
                 });
        }
     
    }
}   