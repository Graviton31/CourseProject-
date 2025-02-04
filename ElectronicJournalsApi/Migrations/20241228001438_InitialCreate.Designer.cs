﻿// <auto-generated />
using System;
using ElectronicJournalsApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectronicJournalApi.Migrations
{
    [DbContext(typeof(ElectronicJournalContext))]
    [Migration("20241228001438_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");
            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ElectronicJournalsApi.Models.Group", b =>
                {
                    b.Property<int>("IdGroup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_group");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdGroup"));

                    b.Property<string>("Classroom")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("classroom");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int")
                        .HasColumnName("id_subject");

                    b.Property<int>("IdUsers")
                        .HasColumnType("int")
                        .HasColumnName("id_users");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.Property<sbyte?>("StudentCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("student_count");

                    b.HasKey("IdGroup")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdSubject" }, "fk_groups_subjects1_idx");

                    b.HasIndex(new[] { "IdUsers" }, "fk_groups_users_idx");

                    b.ToTable("groups", (string)null);
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.Journal", b =>
                {
                    b.Property<int>("IdJournal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_journal");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdJournal"));

                    b.Property<int>("IdGroup")
                        .HasColumnType("int")
                        .HasColumnName("id_group");

                    b.Property<int>("IdStudent")
                        .HasColumnType("int")
                        .HasColumnName("id_student");

                    b.Property<int?>("IdUnvisitedStatus")
                        .HasColumnType("int")
                        .HasColumnName("id_unvisited_status");

                    b.Property<DateOnly?>("LessonDate")
                        .HasColumnType("date")
                        .HasColumnName("lesson_date");

                    b.HasKey("IdJournal")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdGroup" }, "fk_journals_groups1_idx");

                    b.HasIndex(new[] { "IdStudent" }, "fk_journals_students1_idx");

                    b.HasIndex(new[] { "IdUnvisitedStatus" }, "fk_journals_unvisited_statuses1_idx");

                    b.ToTable("journals", (string)null);
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.Schedule", b =>
                {
                    b.Property<int>("IdSchedule")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_schedule");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdSchedule"));

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time")
                        .HasColumnName("end_time");

                    b.Property<int>("IdGroup")
                        .HasColumnType("int")
                        .HasColumnName("id_group");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time")
                        .HasColumnName("start_time");

                    b.Property<sbyte?>("WeekDay")
                        .HasColumnType("tinyint")
                        .HasColumnName("week_day");

                    b.HasKey("IdSchedule")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdGroup" }, "fk_schedules_groups1_idx");

                    b.ToTable("schedules", (string)null);
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.ScheduleChange", b =>
                {
                    b.Property<int>("IdScheduleChange")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_schedule_change");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdScheduleChange"));

                    b.Property<TimeOnly?>("EndTime")
                        .HasColumnType("time")
                        .HasColumnName("end_time");

                    b.Property<int>("IdGroup")
                        .HasColumnType("int")
                        .HasColumnName("id_group");

                    b.Property<DateOnly?>("NewDate")
                        .HasColumnType("date")
                        .HasColumnName("new_date");

                    b.Property<DateOnly?>("OldDate")
                        .HasColumnType("date")
                        .HasColumnName("old_date");

                    b.Property<TimeOnly?>("StartTime")
                        .HasColumnType("time")
                        .HasColumnName("start_time");

                    b.HasKey("IdScheduleChange")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdGroup" }, "fk_schedule_changes_groups1_idx");

                    b.ToTable("schedule_changes", (string)null);
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.Student", b =>
                {
                    b.Property<int>("IdStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_student");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdStudent"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.Property<string>("ParentPhone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("parent_phone");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("patronymic");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("phone");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("surname");

                    b.HasKey("IdStudent")
                        .HasName("PRIMARY");

                    b.ToTable("students", (string)null);
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.Subject", b =>
                {
                    b.Property<int>("IdSubject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_subject");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdSubject"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("description");

                    b.Property<sbyte>("Duration")
                        .HasColumnType("tinyint")
                        .HasColumnName("duration");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("full_name");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_delete");

                    b.Property<sbyte>("LessonLength")
                        .HasColumnType("tinyint")
                        .HasColumnName("lesson_length");

                    b.Property<sbyte>("LessonsCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("lessons_count");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.HasKey("IdSubject")
                        .HasName("PRIMARY");

                    b.ToTable("subjects", (string)null);
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.UnvisitedStatus", b =>
                {
                    b.Property<int>("IdUnvisitedStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_unvisited_status");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdUnvisitedStatus"));

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.Property<string>("ShortName")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("short_name");

                    b.HasKey("IdUnvisitedStatus")
                        .HasName("PRIMARY");

                    b.ToTable("unvisited_statuses", (string)null);
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.User", b =>
                {
                    b.Property<int>("IdUsers")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_users");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdUsers"));

                    b.Property<DateOnly?>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("birth_date");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_delete");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("login");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varbinary(32)")
                        .HasColumnName("password");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("patronymic");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("phone");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("enum('администратор','руководитель','учитель')")
                        .HasColumnName("role");

                    b.Property<string>("Surname")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("surname");

                    b.HasKey("IdUsers")
                        .HasName("PRIMARY");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("StudentsHasGroup", b =>
                {
                    b.Property<int>("IdStudent")
                        .HasColumnType("int")
                        .HasColumnName("id_student");

                    b.Property<int>("IdGroup")
                        .HasColumnType("int")
                        .HasColumnName("id_group");

                    b.HasKey("IdStudent", "IdGroup")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "IdGroup" }, "fk_students_has_groups_groups1_idx");

                    b.HasIndex(new[] { "IdStudent" }, "fk_students_has_groups_students1_idx");

                    b.ToTable("students_has_groups", (string)null);
                });

            modelBuilder.Entity("SubjectsHasUser", b =>
                {
                    b.Property<int>("IdSubject")
                        .HasColumnType("int")
                        .HasColumnName("id_subject");

                    b.Property<int>("IdUsers")
                        .HasColumnType("int")
                        .HasColumnName("id_users");

                    b.HasKey("IdSubject", "IdUsers")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "IdSubject" }, "fk_subjects_has_users_subjects1_idx");

                    b.HasIndex(new[] { "IdUsers" }, "fk_subjects_has_users_users1_idx");

                    b.ToTable("subjects_has_users", (string)null);
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.Group", b =>
                {
                    b.HasOne("ElectronicJournalsApi.Models.Subject", "IdSubjectNavigation")
                        .WithMany("Groups")
                        .HasForeignKey("IdSubject")
                        .IsRequired()
                        .HasConstraintName("fk_groups_subjects1");

                    b.HasOne("ElectronicJournalsApi.Models.User", "IdUsersNavigation")
                        .WithMany("Groups")
                        .HasForeignKey("IdUsers")
                        .IsRequired()
                        .HasConstraintName("fk_groups_users");

                    b.Navigation("IdSubjectNavigation");

                    b.Navigation("IdUsersNavigation");
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.Journal", b =>
                {
                    b.HasOne("ElectronicJournalsApi.Models.Group", "IdGroupNavigation")
                        .WithMany("Journals")
                        .HasForeignKey("IdGroup")
                        .IsRequired()
                        .HasConstraintName("fk_journals_groups1");

                    b.HasOne("ElectronicJournalsApi.Models.Student", "IdStudentNavigation")
                        .WithMany("Journals")
                        .HasForeignKey("IdStudent")
                        .IsRequired()
                        .HasConstraintName("fk_journals_students1");

                    b.HasOne("ElectronicJournalsApi.Models.UnvisitedStatus", "IdUnvisitedStatusNavigation")
                        .WithMany("Journals")
                        .HasForeignKey("IdUnvisitedStatus")
                        .HasConstraintName("fk_journals_unvisited_statuses1");

                    b.Navigation("IdGroupNavigation");

                    b.Navigation("IdStudentNavigation");

                    b.Navigation("IdUnvisitedStatusNavigation");
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.Schedule", b =>
                {
                    b.HasOne("ElectronicJournalsApi.Models.Group", "IdGroupNavigation")
                        .WithMany("Schedules")
                        .HasForeignKey("IdGroup")
                        .IsRequired()
                        .HasConstraintName("fk_schedules_groups1");

                    b.Navigation("IdGroupNavigation");
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.ScheduleChange", b =>
                {
                    b.HasOne("ElectronicJournalsApi.Models.Group", "IdGroupNavigation")
                        .WithMany("ScheduleChanges")
                        .HasForeignKey("IdGroup")
                        .IsRequired()
                        .HasConstraintName("fk_schedule_changes_groups1");

                    b.Navigation("IdGroupNavigation");
                });

            modelBuilder.Entity("StudentsHasGroup", b =>
                {
                    b.HasOne("ElectronicJournalsApi.Models.Group", null)
                        .WithMany()
                        .HasForeignKey("IdGroup")
                        .IsRequired()
                        .HasConstraintName("fk_students_has_groups_groups1");

                    b.HasOne("ElectronicJournalsApi.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("IdStudent")
                        .IsRequired()
                        .HasConstraintName("fk_students_has_groups_students1");
                });

            modelBuilder.Entity("SubjectsHasUser", b =>
                {
                    b.HasOne("ElectronicJournalsApi.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("IdSubject")
                        .IsRequired()
                        .HasConstraintName("fk_subjects_has_users_subjects1");

                    b.HasOne("ElectronicJournalsApi.Models.User", null)
                        .WithMany()
                        .HasForeignKey("IdUsers")
                        .IsRequired()
                        .HasConstraintName("fk_subjects_has_users_users1");
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.Group", b =>
                {
                    b.Navigation("Journals");

                    b.Navigation("ScheduleChanges");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.Student", b =>
                {
                    b.Navigation("Journals");
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.Subject", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.UnvisitedStatus", b =>
                {
                    b.Navigation("Journals");
                });

            modelBuilder.Entity("ElectronicJournalsApi.Models.User", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
