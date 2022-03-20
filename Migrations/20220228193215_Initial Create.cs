using Microsoft.EntityFrameworkCore.Migrations;

namespace TestAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatementDetails1",
                columns: table => new
                {
                    StatementDetailId1 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerName1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OwnerSurname1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OwnerPatronymic1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PasportSet1 = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    PasportNumber1 = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    PasportType1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OwnerINN = table.Column<string>(type: "nvarchar(12)", nullable: true),
                    OwnerBirthday1 = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    EmailAdress = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    KidName1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    KidSurname1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    KidPatronymic1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    СertificateSet1 = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    СertificateNumber1 = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    СertificateType1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    KidBirthday1 = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatementDetails1", x => x.StatementDetailId1);
                });

            migrationBuilder.CreateTable(
                name: "StatementDetails2",
                columns: table => new
                {
                    StatementDetailId2 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerName2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OwnerSurname2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OwnerPatronymic2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PasportSet2 = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    PasportNumber2 = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    PasportType2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OwnerSnils = table.Column<string>(type: "nvarchar(14)", nullable: true),
                    OwnerBirthday2 = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    KidName2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    KidSurname2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    KidPatronymic2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    СertificateSet2 = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    СertificateNumber2 = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    СertificateType2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    KidBirthday2 = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatementDetails2", x => x.StatementDetailId2);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatementDetails1");

            migrationBuilder.DropTable(
                name: "StatementDetails2");
        }
    }
}
