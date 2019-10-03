using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;

namespace DataLayer.Migrations
{
    [Migration(2)]
  public  class _2_CreateTable_Tasks: Migration
    {
        /// <summary>
        /// Функция для удаления талицы Tasks
        /// </summary>
        public override void Down()
        {
            Delete.ForeignKey("Users_ID");
            Delete.Table("Tasks");
        }
        /// <summary>
        /// Функция lобавления столбцов в таблицу Tasks
        /// </summary>
        public override void Up()
        {
            Create.Table("Tasks")
                .WithColumn("ID").AsInt32().PrimaryKey().NotNullable()
                .WithColumn("Users_ID").AsInt32().NotNullable()
                .WithColumn("Start_Date").AsDate().NotNullable()
                .WithColumn("End_Date").AsDate().NotNullable()
                .WithColumn("Tasks").AsString(int.MaxValue).NotNullable()
                .WithColumn("Users_ID").AsInt32().ForeignKey("Users_ID", "Users", "ID");
                
             
                
        }

    }
}
