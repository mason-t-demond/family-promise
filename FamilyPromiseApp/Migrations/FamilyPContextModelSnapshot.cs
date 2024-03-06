﻿// <auto-generated />
using System;
using FamilyPromiseApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FamilyPromiseApp.Migrations
{
    [DbContext(typeof(FamilyPContext))]
    partial class FamilyPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("FamilyPromiseApp.Models.Case", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CurrentSituation")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("DomesticViolenceHistory")
                        .HasColumnType("TEXT");

                    b.Property<string>("HealthChallenge")
                        .HasColumnType("TEXT");

                    b.Property<string>("IsEmployed")
                        .HasColumnType("TEXT");

                    b.Property<string>("IsHoused")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReferringAgency")
                        .HasColumnType("TEXT");

                    b.Property<int>("Substance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TakenBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.Property<int>("TransportMethod")
                        .HasColumnType("INTEGER");

                    b.Property<string>("income")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Case", (string)null);
                });

            modelBuilder.Entity("FamilyPromiseApp.Models.IntakeModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdultAge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdultCellPhone")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AdultDateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdultEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdultName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdultNum")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdultWorkPhone")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CellPhoneNum")
                        .HasColumnType("TEXT");

                    b.Property<int>("ChildAge")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ChildDateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<int>("ChildGrade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChildName")
                        .HasColumnType("TEXT");

                    b.Property<int>("ChildNum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChildSchool")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompletionDate")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<int>("DateAdmitted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateToday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Education")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAdd")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstMidName")
                        .HasColumnType("TEXT")
                        .HasColumnName("FirstName");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomeAddress")
                        .HasColumnType("TEXT");

                    b.Property<int?>("HouseHoldChildrenExists")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HouseHoldMemberExists")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HouseType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDNum")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IsEmployed")
                        .HasColumnType("TEXT");

                    b.Property<string>("IsHoused")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Race")
                        .HasColumnType("TEXT");

                    b.Property<int>("Reason")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Reason2")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RecentHousing")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ReferralAgency")
                        .HasColumnType("TEXT");

                    b.Property<string>("Relationships")
                        .HasColumnType("TEXT");

                    b.Property<int>("SSN")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SpouseLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubstanceIss")
                        .HasColumnType("TEXT");

                    b.Property<string>("TakenByNow")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeNow")
                        .HasColumnType("TEXT");

                    b.Property<string>("TransportMethod")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkPhoneNum")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkStudy")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("IntakeModel", null, t =>
                        {
                            t.Property("FirstName")
                                .HasColumnName("FirstName1");
                        });
                });

            modelBuilder.Entity("FamilyPromiseApp.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdultCellPhone")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AdultDateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdultEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdultName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdultWorkPhone")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CaseID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CellPhone")
                        .HasColumnType("TEXT");

                    b.Property<int>("ChildAge")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ChildDateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChildName")
                        .HasColumnType("TEXT");

                    b.Property<int>("ChildNum")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstMidName")
                        .HasColumnType("TEXT")
                        .HasColumnName("FirstName");

                    b.Property<int?>("HouseHoldChildrenExist")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HouseHoldMemberExist")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HouseHoldNum")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkPhone")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CaseID");

                    b.ToTable("Person", (string)null);
                });

            modelBuilder.Entity("FamilyPromiseApp.Models.Referral", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactInfo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PersonID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ReferralName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Referral", (string)null);
                });

            modelBuilder.Entity("FamilyPromiseApp.Models.Resource", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Resource", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Mvc.Rendering.SelectListGroup", b =>
                {
                    b.Property<bool>("Disabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.ToTable("SelectListGroup");
                });

            modelBuilder.Entity("FamilyPromiseApp.Models.Person", b =>
                {
                    b.HasOne("FamilyPromiseApp.Models.Case", "Case")
                        .WithMany()
                        .HasForeignKey("CaseID");

                    b.Navigation("Case");
                });

            modelBuilder.Entity("FamilyPromiseApp.Models.Referral", b =>
                {
                    b.HasOne("FamilyPromiseApp.Models.Person", null)
                        .WithMany("Referral")
                        .HasForeignKey("PersonID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FamilyPromiseApp.Models.Person", b =>
                {
                    b.Navigation("Referral");
                });
#pragma warning restore 612, 618
        }
    }
}
