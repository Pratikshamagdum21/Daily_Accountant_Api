﻿using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;

namespace Daily_Accountant_Api.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<User> user { get; set; }
        public DbSet<Registers> register { get; set; }
        public DbSet<ExpensesDetail> expensesDetails { get; set; }
        public DbSet<WalletDetails> walletDetails { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<InvestmentDetails> investmentdetails { get; set; }
        public DbSet<InvestmentNameId> investmentnameid { get; set; }
        public DbSet<MoneyLender> moneyLender { get; set; }
        public DbSet<BorrowedMoney> borrowedMoney { get; set; }
        public DbSet<Budget> budget { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}