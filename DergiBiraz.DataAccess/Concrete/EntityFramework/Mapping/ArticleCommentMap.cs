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
    public class ArticleCommentMap : IEntityTypeConfiguration<ArticleComment>
    {
        public void Configure(EntityTypeBuilder<ArticleComment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Content).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Assent).IsRequired();

            builder.ToTable("ArticleComments");
        }
    }
}
