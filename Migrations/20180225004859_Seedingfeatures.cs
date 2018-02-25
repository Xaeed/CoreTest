using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace testing.Migrations
{
    public partial class Seedingfeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("INSERT INTO Make (Name) VALUES ('Make-4')");
       migrationBuilder.Sql("INSERT INTO  Features (PowerSteering)   VALUES ('TRUE')");
    //    migrationBuilder.Sql("INSERT INTO Features (Automatic,ModelID)   VALUES ('FALSE',3)");
    //     migrationBuilder.Sql("INSERT INTO Features (GPS,ModelID)   VALUES ('TRUE',3)");


    //  migrationBuilder.Sql("INSERT INTO Features (PowerSteering,ModelID)   VALUES ('test',5)");
    //  migrationBuilder.Sql("INSERT INTO Features (Automatic,ModelID)   VALUES ('test',5)");
    // migrationBuilder.Sql("INSERT INTO (GPS,ModelID)   VALUES ('1',5)");

    //     migrationBuilder.Sql("INSERT INTO Features (PowerSteering,ModelID)   VALUES ('0',7)");
    //    migrationBuilder.Sql("INSERT INTO Features (Automatic,ModelID)   VALUES ('test',7)");
    //   migrationBuilder.Sql("INSERT INTO Features (GPS,ModelID)   VALUES ('1'  ,7)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
