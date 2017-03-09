using System;
using Think.Erp.Api.Validation;

namespace Think.Erp.Api.Domain.Entities
{
    public class Entity 
    {
        protected Entity() { }

        public Entity(string firstName, string lastName, string fullName, string nickname, string abbreviation)
        {
            CreatedAt = DateTime.Now;
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Nickname = nickname;
            Abbreviation = abbreviation;
        }

        public Entity(int id, string firstName, string lastName, string fullName, string nickname, string abbreviation)
        {
            Id = id;
            UpdatedAt = DateTime.Now;
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Nickname = nickname;
            Abbreviation = abbreviation;
        }

        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid Guid { get; set; }
        public int? StatusId { get; set; }
        public int? EntityTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Nickname { get; set; }
        public string Abbreviation { get; set; }
        public long? TaxpayerRegistryNumber { get; set; }
        public int? EconomicActivityId { get; set; }
        public int? AddressId { get; set; }
        public int? PhoneId { get; set; }
        public int? EmailId { get; set; }
        public int? BankAccountId { get; set; }
        public DateTime? Birthday { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? GenderId { get; set; }
        public decimal? Patrimony { get; set; }
        public decimal? MonthlyIncome { get; set; }
        public decimal? YearlyIncome { get; set; }
    }
}