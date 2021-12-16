using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
	public class CommentMap : IEntityTypeConfiguration<Comment>
	{
		public void Configure(EntityTypeBuilder<Comment> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Id).ValueGeneratedOnAdd();
			builder.Property(c => c.Text).IsRequired();
			builder.Property(c => c.Text).HasMaxLength(2000);
			builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
			builder.Property(c => c.CreatedByName).IsRequired();
			builder.Property(c => c.CreatedByName).HasMaxLength(50);
			builder.Property(c => c.ModifiedByName).IsRequired();
			builder.Property(c => c.ModifiedByName).HasMaxLength(50);
			builder.Property(c => c.CreatedDate).IsRequired();
			builder.Property(c => c.ModifiedDate).IsRequired();
			builder.Property(c => c.IsActive).IsRequired();
			builder.Property(c => c.IsDeleted).IsRequired();
			builder.Property(c => c.Note).HasMaxLength(500);
			builder.ToTable("Comments");

			//builder.HasData(
			//new Comment
			//{
			//	Id=1,
			//	ArticleId=1,
			//	Text= "Eklenen yeni özelliklerden bahsederken aşağıda listeleyeceğim adımları uygulamaya özen göstereceğim." +
			//	"DateTime Model Binding (MVC and Razor)"+
			//	"Model Bindingartık DateTime için UTCzaman dilimlerini destekliyor. " +
			//	"Gelen request içerisinde UTCzaman dilimi içeriyorsa Model Bindingonu ilgili UTCaralığına bağlayacaktır."+
			//	"ASP.NET Core 5.0 sürümünden önce; kullanıcı request içerisinde " +
			//	"UTCzaman dilimini gönderdiğinde Model Bindingbunu UTC DateTimenesnesi yerine Local bir DateTimenesnesine dönüştürüyordu."+
			//	"Geliştiriciler kullanıcının request içerisinde gönderdiği UTCzaman dilimine ulaşmak için Custom Model Binder yazarak bu problemi çözüyorlardı.",
			//	IsActive = true,
			//	IsDeleted = false,
			//	CreatedByName = "InitialCreate",
			//	CreatedDate = DateTime.Now,
			//	ModifiedByName = "InitialCreate",
			//	ModifiedDate = DateTime.Now,
			//	Note = "C# Makale Yorumu",

			//},
			//new Comment
			//{
			//	Id = 2,
			//	ArticleId = 2,
			//	Text = "C#, Java, Python gibi modern programlama dilleri dinamik bellek yönetimini " +
			//	"çöp toplayıcı sayesinde otomatik olarak yapmasının yanında yazılım geliştiricilere çeşitli kolaylıklar getirdi."+
			//	"Bunlar otomatik tür değişken tanımlama, daha kolay döngüler, daha kısa fonksiyon tanımı olarak sıralanabilir."+
			//	"C++ dili uzun yıllar güncellenmemiş performans, bellek erişimi gibi nedenlerden dolayı kullanılmakta ve kullanımı giderek azalmaktaydı."+
			//	"C++ 98 ve C++03 (2003) den sonra Modern C++ olarak adlandırılan C++ 11 (2011) ile " +
			//	"modern programlama dillerinde yer alan otomatik tür değişkeni, lambda fonksiyonları gibi özelliği C++ diline kazandırdı.",
			//	IsActive = true,
			//	IsDeleted = false,
			//	CreatedByName = "InitialCreate",
			//	CreatedDate = DateTime.Now,
			//	ModifiedByName = "InitialCreate",
			//	ModifiedDate = DateTime.Now,
			//	Note = "C++ Makale Yorumu",

			//},
			//new Comment
			//{
			//	Id = 3,
			//	ArticleId = 3,
			//	Text = "JavaScript ES6 versiyonu ile oldukça fazla yeni özellik sundu. " +
			//	"Bu sayede JavaScript’teki geliştirme süreci olumlu olarak değişiklik gösterdi ve biz geliştiricilerinde hayatını kolaylaştırdı."+
			//	"matchAll , String tipi değişkenler için Regular Expressions ile ilgisi olan yeni bir metot." +
			//	" Bu metot, verdiğimiz parametrede eşleşen tüm grupları arka arkaya dizen bir iterator döndürür."+
			//	"Optional Chaining sentaksı sayesinde bir obje içerisinde" +
			//	" derinlerde bulunan bir veriye ulaşmak istediğimizde olup olmadığına tereddüt etmeden bunu deneyebiliriz."+
			//	"Anlaşılabilirlik açısından fotoğrafı biraz yorumlayalım. " +
			//	"İlk başta oldukça alt verisi olan bir obje tanımlıyoruz. Sonrasında başarılı şekilde prop5 bilgisine ulaşıyoruz.",
			//	IsActive = true,
			//	IsDeleted = false,
			//	CreatedByName = "InitialCreate",
			//	CreatedDate = DateTime.Now,
			//	ModifiedByName = "InitialCreate",
			//	ModifiedDate = DateTime.Now,
			//	Note = "Javascript Makale Yorumu",

			//}
			//);
		}
	}
}
