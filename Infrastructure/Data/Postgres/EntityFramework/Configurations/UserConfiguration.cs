﻿using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email).IsRequired();
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.UserName).IsRequired();
        builder.Property(x => x.SurName).IsRequired();
        builder.Property(x => x.Adress).IsRequired();
        builder.Property(x => x.Gsm).IsRequired();
        builder.HasIndex(x => x.Gsm).IsUnique();



        builder.Property(x => x.PasswordHash).IsRequired();
        builder.Property(x => x.PasswordSalt).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.IsDeleted).IsRequired();


      

        // Kullanıcının twitleri ilişkisi
        builder.HasMany(u => u.Tweets)
               .WithOne(t => t.User)
               .HasForeignKey(t => t.UserId);
    }



}
