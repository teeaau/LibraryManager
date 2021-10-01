using System;
using System.Data.Entity;
using System.Linq;

namespace Data
{
    public class LibraryDB : DbContext
    {
        public LibraryDB()
            : base("name=LibraryDB")
        {
        }

    }

}