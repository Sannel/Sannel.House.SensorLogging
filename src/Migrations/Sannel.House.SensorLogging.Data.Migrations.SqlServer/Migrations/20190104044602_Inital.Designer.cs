﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sannel.House.SensorLogging.Data;

namespace Sannel.House.SensorLogging.Data.Migrations.SqlServer.Migrations
{
    [DbContext(typeof(SensorLoggingContext))]
    [Migration("20190104044602_Inital")]
    partial class Inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sannel.House.SensorLogging.Models.SensorEntry", b =>
                {
                    b.Property<Guid>("SensorEntryId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("DeviceId");

                    b.Property<int>("SensorType");

                    b.Property<string>("Values");

                    b.HasKey("SensorEntryId");

                    b.HasIndex("DeviceId");

                    b.HasIndex("SensorType");

                    b.ToTable("SensorEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
