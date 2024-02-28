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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            builder.ToTable("Categories");

            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Fikir",
                },
                new Category
                {
                    Id = 2,
                    Name = "Edebiyat",
                },
                new Category
                {
                    Id = 3,
                    Name = "Sanat",
                },
                new Category
                {
                    Id = 4,
                    Name = "İnsan",
                },
                new Category
                {
                    Id = 5,
                    Name = "Hayat",
                }
                );
        }
    }
}
