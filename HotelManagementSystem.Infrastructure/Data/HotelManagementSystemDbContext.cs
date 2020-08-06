using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HotelManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HotelManagementSystem.Infrastructure.Data
{
    public class HotelManagementSystemDbContext:DbContext
    {
        public HotelManagementSystemDbContext(DbContextOptions<HotelManagementSystemDbContext> options) : base(options)
        {

        }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<RoomType>(ConfigureRoomType);
        //    modelBuilder.Entity<Customer>(ConfigureCustomer);
        //    modelBuilder.Entity<Room>(ConfigureRoom);
        //    modelBuilder.Entity<Service>(ConfigureService);
        //}

        //private void ConfigureRoomType(EntityTypeBuilder<RoomType> modelBuilder)
        //{
        //    modelBuilder.HasKey(rt => new { rt.Id });
        //    modelBuilder.HasOne(rt => rt.)
        //}
    }
}
