using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication2.Models;

#nullable disable

namespace WebApplication2.Migrations
{
    public partial class V0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuilderForm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Option = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: true),
                    Label = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    HelpText = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Buttion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuilderForm", x => x.Id);
                });
            for(int i=0 ; i<7; i++){
                bool flag;
                if (i % 2 == 0) { 
                    flag = true; 
                    }
                else {
                    flag = false; 
                    }
                migrationBuilder.InsertData(
                    table: "BuilderForm",
                    columns: new[]{"Name","Option","Required","Label","HelpText","Buttion"},
                    values: new object[]{
                        "Item" +(i%4+1).ToString(),
                        "Option"+(i%4+1).ToString(),
                        flag,
                        "Label"+ i.ToString(),
                        "HelpText"+ i.ToString(),
                        "Danger"
                    }
                );
            }
        }
    

        //


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuilderForm");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
