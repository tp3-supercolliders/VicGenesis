﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VicGenesis
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using VicGenesis.Models;

    public partial class regionalDatabaseEntities : DbContext
    {
        public regionalDatabaseEntities()
            : base("name=regionalDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Victoria>()
                .Property(e => e.COMM_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Community_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Community_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.DHS_Region)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Map_Reference)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Local_Government_Area)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Primary_Care_Partnership)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.ABS_Remoteness_Area)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Population_Difference)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Nearest_Health_Service)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Residential)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Business)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Industrial)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Rural)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Population_In_nonprivate_Dwellings)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Public_Rental_Dwellings)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Aboriginal_Or_Torres_Strait_Islander)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Not_Completed_Year_12)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Unemployed_Persons)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Household_Income_Less_Than_650)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Individual_Income_Less_Than_400)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Household_Without_Motor_Vehicle)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Household_With_Internet)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.One_Parent_Headed_Families)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Persons_aged_75_Above_Living_Alone)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Need_Assistance_With_Core_Activities)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Born_Overseas)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Non_Engisdh_Speaker_At_Home)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Poor_English_Proficiency)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Main_Cultural_group_1_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Main_cultural_group_1_Percentage)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Main_cultural_group_2_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Main_cultural_group_2_Percentage)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Main_cultural_group_3_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Victoria>()
                .Property(e => e.Main_cultural_group_3_Percentage)
                .IsUnicode(false);
        }
    
        public virtual DbSet<Victoria> Victorias { get; set; }
    }
}
