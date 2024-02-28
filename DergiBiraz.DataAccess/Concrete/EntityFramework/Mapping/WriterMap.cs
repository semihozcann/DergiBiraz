using DergiBiraz.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.DataAccess.Concrete.EntityFramework.Mapping
{
    public class WriterMap : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.ImageUrl);
            builder.Property(x => x.InstagramUrl).HasMaxLength(100);
            builder.Property(x => x.FacebookUrl).HasMaxLength(100);
            builder.Property(x => x.LinkedInUrl).HasMaxLength(100);
            builder.Property(x => x.TwitterUrl).HasMaxLength(100);
            builder.Property(x => x.Job).HasMaxLength(100);


            builder.ToTable("Writers");

            builder.HasData(
                new Writer
                {
                    Id = 1,
                    FirstName = "Semih",
                    LastName = "Özcan",
                    Description = "Acemi şair",
                },
                new Writer
                {
                    Id = 2,
                    FirstName = "İbrahim",
                    LastName = "Aydın",
                    Description = "Acemi şair",
                },
                new Writer
                {
                    Id = 3,
                    FirstName = "Ahmet Haktan",
                    LastName = "Koçal",
                    Description = "Acemi şair",
                },
                new Writer
                {
                    Id = 4,
                    FirstName = "Mahmut Nurullah",
                    LastName = "Yıldız",
                    Description = "Acemi şair",
                }
                );
        }
    }
}
