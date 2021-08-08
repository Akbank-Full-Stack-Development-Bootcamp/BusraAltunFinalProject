using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.Concrete.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Concrete.EntityFramework.Mapping
{
    public class AuthorMapping : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {

            builder.ToTable("Authors", @"dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                   .HasColumnName("Name")
                   .HasMaxLength(50)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Surname)
                   .HasColumnName("SurName")
                   .HasMaxLength(50)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Bio)
                   .HasColumnName("Bio")
                   .HasMaxLength(1500)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Poster)
                   .HasColumnName("Poster")
                   .HasMaxLength(500)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.CreatedAuthorDate).HasDefaultValue(DateTime.Now);

            //data to show when the project is up and running

            builder.HasData(new Author
            {
                Id = 1,
                Name = "Cemil",
                Surname = "Meriç",
                Bio = "Meriç’in “aynı kaynaktan fışkırdılar” dediği eserler dizisinin önemli bir halkası. Bir çağın, bir ülkenin vicdanı olmak isteği Meriç’in bütün çabasına her zaman yön vermiştir: “Bu sayfalarda hayatımın bütünü, yani bütün sevgilerim, bütün kinlerim, bütün tecrübelerim var. Bana öyle geliyor ki, hayat denen mülakata bu kitabı yazmak için geldim; etimin eti, kemiğimin kemiği.” Bu Ülke, Meriç’in sürekli etrafında dolandığı Doğu-Batı sorunu yanında, sol-sağ kutuplaşmasına ve kalıplaşmasına ilişkin önemli tesbit ve aforizmalarını da içeriyor.",
                Poster = "https://ia.tmgrup.com.tr/ff6b76/0/0/0/0/0/0?u=https://i.tmgrup.com.tr/fikriyat//album/2018/12/12/1544618723987.jpg&mw=752",
                CreatedAuthorId = 1


            }); ;
        }
    }
}
