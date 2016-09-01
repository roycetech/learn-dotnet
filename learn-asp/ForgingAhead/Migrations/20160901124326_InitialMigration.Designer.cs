using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ForgingAhead.Models;

namespace ForgingAhead.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160901124326_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("ForgingAhead.Models.Character", b =>
                {
                    b.Property<string>("Name");

                    b.Property<int>("Dexterity");

                    b.Property<int>("Intelligence");

                    b.Property<bool>("IsActive");

                    b.Property<int>("Level");

                    b.Property<string>("QuestName");

                    b.Property<int>("Strength");

                    b.HasKey("Name");

                    b.HasIndex("QuestName");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("ForgingAhead.Models.Equipment", b =>
                {
                    b.Property<string>("Name");

                    b.HasKey("Name");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("ForgingAhead.Models.Quest", b =>
                {
                    b.Property<string>("Name");

                    b.Property<bool>("IsActive");

                    b.HasKey("Name");

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("ForgingAhead.Models.Character", b =>
                {
                    b.HasOne("ForgingAhead.Models.Quest")
                        .WithMany("Characters")
                        .HasForeignKey("QuestName");
                });
        }
    }
}
