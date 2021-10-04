using Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Data
{
    public class LibraryDB : DbContext
    {
        public DbSet<DocGia> DocGias { get; set; }
        public LibraryDB()
            : base("name=LibraryDB")
        {
        }

    }
}