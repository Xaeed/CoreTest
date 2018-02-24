using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace testing.Migrations
{
    public partial class seedingdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Make (Name) VALUES ('Make-1')");
             migrationBuilder.Sql("INSERT INTO Make (Name) VALUES ('Make-2')");
             migrationBuilder.Sql("INSERT INTO Make (Name) VALUES ('Make-2')");

            //    migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES ('Make1-MODELA',1");
            //    migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES ('Make1-MODELB',1)");
            //    migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES ('Make1-MODELC',1)");
            //    migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES ('Make2-MODELA',2)");
            //    migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES ('Make2-MODELB',2)");
            //    migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES ('Make2-MODELC',2)");
            //    migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES ('Make3-MODELA',3)");
            //    migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES ('Make3-MODELB',3)");
            //    migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES ('Make3-MODELC',3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          migrationBuilder.Sql("DELETE * FROM Make");
        }
    }
}
