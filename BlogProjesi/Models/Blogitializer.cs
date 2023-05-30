using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogProjesi.Models
{
    public class Blogitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        // bunu yapmamızdaki amaç blog contexteki tablolarda değişiklik olursa
        //database siliyor yeniden oluşturuyor eğer model değişirse
        //seed methoduysa text verileri ekleme imkanı sağlar

        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler =new List<Category>()
            {
                new Category() { KategoriAdi = "C#" },
                new Category() { KategoriAdi = "MVC" },
                new Category() { KategoriAdi = "Windows form" },
                new Category() { KategoriAdi = ".Net" },
               
            };


            foreach (var item in kategoriler) 
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() { Baslik = "burası başlık kısmı", Aciklama = "Burada  hakkında acıklama olur", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = true, Icerik = "Burasıda içeriğin ne oldugu", Resim = "1.jpg", CategoryId = 1 },
                new Blog() { Baslik = "burası başlık kısmı", Aciklama = "Burada  hakkında acıklama olur", EklenmeTarihi = DateTime.Now.AddDays(-5), Anasayfa = true, Onay = true, Icerik = "Burasıda içeriğin ne oldugu", Resim = "1.jpg", CategoryId = 1 },
                new Blog() { Baslik = "burası başlık kısmı", Aciklama = "Burada  hakkında acıklama olur", EklenmeTarihi = DateTime.Now.AddDays(-1), Anasayfa = false, Onay = true, Icerik = "Burasıda içeriğin ne oldugu", Resim = "2.jpg", CategoryId = 2 },
                new Blog() { Baslik = "burası başlık kısmı", Aciklama = "Burada  hakkında acıklama olur", EklenmeTarihi = DateTime.Now.AddDays(-11), Anasayfa = true, Onay = false, Icerik = "Burasıda içeriğin ne oldugu", Resim = "12jpg", CategoryId = 2 },
                new Blog() { Baslik = "burası başlık kısmı", Aciklama = "Burada  hakkında acıklama olur", EklenmeTarihi = DateTime.Now.AddDays(-22), Anasayfa = false, Onay = true, Icerik = "Burasıda içeriğin ne oldugu", Resim = "3.jpg", CategoryId = 3 },
                new Blog() { Baslik = "C# Consol Hakkında", Aciklama = "Burada  hakkında acıklama olur", EklenmeTarihi = DateTime.Now.AddDays(-11), Anasayfa = false, Onay = true, Icerik = "Burasıda içeriğin ne oldugu", Resim = "3.jpg", CategoryId = 3 },
                new Blog() { Baslik = "C# Consol Hakkında", Aciklama = "Burada  hakkında acıklama olur", EklenmeTarihi = DateTime.Now.AddDays(-22), Anasayfa = true, Onay = false, Icerik = "Burasıda içeriğin ne oldugu", Resim = "4.jpg", CategoryId = 4 },
                new Blog() { Baslik = "C# Consol Hakkında", Aciklama = "Burada  hakkında acıklama olur", EklenmeTarihi = DateTime.Now.AddDays(-33), Anasayfa = true, Onay = true, Icerik = "Burasıda içeriğin ne oldugu", Resim = "3.jpg", CategoryId = 4 },
                //datetime.now.AddDays-10 bu ifade 10 gün önce eklenmiş oluyor
                //katogori ıdleri en sondaki 4 e kadar verdik 4 tane farklı yukarıda kategori var onun için
            };


            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
                
            }
            context.SaveChanges();

            base.Seed(context);
           
        }
    }
}