using Ecommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", @"dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserName)
                   .HasColumnName("UserName")
                   .HasMaxLength(50)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.FirstName)
                   .HasColumnName("FirstName")
                   .HasMaxLength(50)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.LastName)
                   .HasColumnName("LastName")
                   .HasMaxLength(50)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Email)
                   .HasColumnName("Email")
                   .HasMaxLength(50)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Password)
                   .HasColumnName("Password")
                   .HasMaxLength(12)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Gender)
                   .HasColumnName("Gender")
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.DateOfBirth)
                   .HasColumnName("DateOfBirth")
                   .IsRequired(); //cannot be blank
            builder.Property(x => x.CreatedUserDate).HasDefaultValue(DateTime.Now);


            builder.Property(x => x.Address)
                   .HasColumnName("Address")
                   .HasMaxLength(250)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Role)
                   .HasColumnName("Role")
                   .IsRequired(); //cannot be blank

            //data to show when the project is up and running

            builder.HasData(new User
            {
                Id = 1,
                UserName = "busraltun",
                FirstName = "Büşra",
                LastName = "Altun",
                Email = "busraltunb@gmail.com",
                Password = "12345",
                Gender = true,
                DateOfBirth = Convert.ToDateTime("18-12-1996"),
                Address = "Hatay/Antakya",
                Role = false,
                CreatedUserDate = DateTime.Now,
                CreatedUserId = 1
                
            });
        }
    }
}
