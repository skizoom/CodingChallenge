using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodingChallenge.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var resorts = JsonConvert.DeserializeObject<IEnumerable<Resort>>(File.ReadAllText("resorts.json"));

            modelBuilder.Entity<Resort>().HasKey(r => r.Code);
            modelBuilder.Entity<Resort>().HasData(resorts.ToArray());

        }
    }
    public class Resort
    {
        public Resort() { }

        public string Code { get; set; }


        public string Name { get; set; }

        public string Country { get; set; }

        public bool BeginnerFriendly { get; set; }

        public bool HighAltitude { get; set; }

        public bool FamilyFriendly { get; set; }
    }
}
