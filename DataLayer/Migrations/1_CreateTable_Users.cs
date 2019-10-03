using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
namespace DataLayer.Migrations
{
    [Migration(1)]
   public class _1_CreateTable_Users: Migration
    {
        /// <summary>
        /// Функция для удаления таблицы
        /// </summary>
        public override void Down()
        {
            Delete.Table("Users");
        }
        /// <summary>
        /// Функция для Создания таблицы
        /// </summary>
         public override void Up()
        {
            Create.Table("Users")
                .WithColumn("ID").AsInt32().PrimaryKey().Identity().NotNullable().Indexed()
                .WithColumn("Name").AsString(int.MaxValue).NotNullable()
                .WithColumn("Surname").AsString(int.MaxValue).NotNullable()
                .WithColumn("DataOFBirth").AsDateTime().NotNullable()
                .WithColumn("Email").AsString(int.MaxValue).NotNullable()
                .WithColumn("Login").AsString(int.MaxValue).NotNullable()
                .WithColumn("Password").AsString(int.MaxValue).NotNullable();


        }
    }
}
