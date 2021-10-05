namespace Data.Migrations
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.LibraryDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Data.LibraryDB context)
        {
            context.DocGias.AddOrUpdate(DefaultDocGias.ToArray());
            context.Saches.AddOrUpdate(DefaultSaches.ToArray());
            context.SaveChanges();
        }
        List<DocGia> DefaultDocGias
        {
            get
            {
                List<DocGia> docGias = new List<DocGia>();
                for (int i = 10; i < 20; i++)
                {
                    var docGia = new DocGia()
                    {
                        idDocGia = String.Format($"{DateTime.Now.ToString("yyyyMMddhhmm")}{i}"),
                        tenDocGia = String.Format($"Doc Gia {i - 9}"),
                        GioiTinh = "Nam",
                        CMND = DateTime.Now.ToString("yyyyMMddhhmmss"),
                        soDienThoai = "0123456789",
                        DiaChi = "01 Võ Văn Ngân, thành phố Thủ Đức, HCM",
                        anhDaiDien = File.ReadAllBytes("./images/avatar.jpg")
                    };
                    docGias.Add(docGia);
                }
                return docGias;
            }
        }
        List<Sach> DefaultSaches
        {
            get
            {
                List<Sach> saches = new List<Sach>();
                saches.Add(new Sach()
                {
                    idSach = 1,
                    tenSach = "Giết con chim nhại",
                    tacGia = "Harper Lee",
                    anhSach = File.ReadAllBytes("./images/sach1.jpg")
                });
                saches.Add(new Sach()
                {
                    idSach = 2,
                    tenSach = "Đắc nhân tâm",
                    tacGia = "Dale Carnegie",
                    anhSach = File.ReadAllBytes("./images/sach2.jpg")
                });
                saches.Add(new Sach()
                {
                    idSach = 3,
                    tenSach = "Trên đường băng",
                    tacGia = "Tony Buổi Sáng",
                    anhSach = File.ReadAllBytes("./images/sach3.jpg")
                });
                saches.Add(new Sach()
                {
                    idSach = 4,
                    tenSach = "Tôi tài giỏi, bạn cũng thế!",
                    tacGia = "Adam Khoo",
                    anhSach = File.ReadAllBytes("./images/sach4.jpg")
                });
                return saches;
            }
        }
    }
}
