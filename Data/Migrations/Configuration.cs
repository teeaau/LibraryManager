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
            foreach (var docGia in DefaultDocGias)
            {
                context.DocGias.AddOrUpdate(docGia);
            }
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
                        anhDaiDien = File.ReadAllBytes("./avatar.jpg")
                    };
                    docGias.Add(docGia);
                }
                return docGias;
            }
        }
    }
}
