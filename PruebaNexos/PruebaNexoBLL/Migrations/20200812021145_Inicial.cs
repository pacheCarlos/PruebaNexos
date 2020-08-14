using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaNexosBLL.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorContexts",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameComplete = table.Column<string>(nullable: true),
                    Specialty = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<int>(nullable: false),
                    Hospital = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorContexts", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "PatientContexts",
                columns: table => new
                {
                    PatientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameComplete = table.Column<string>(nullable: true),
                    SocialSecurityNumber = table.Column<int>(nullable: false),
                    ZipCode = table.Column<int>(nullable: false),
                    Phone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientContexts", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "DoctorPatientContexts",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatientContexts", x => new { x.DoctorId, x.PatientId });
                    table.ForeignKey(
                        name: "FK_DoctorPatientContexts_DoctorContexts_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "DoctorContexts",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorPatientContexts_PatientContexts_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientContexts",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatientContexts_PatientId",
                table: "DoctorPatientContexts",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorPatientContexts");

            migrationBuilder.DropTable(
                name: "DoctorContexts");

            migrationBuilder.DropTable(
                name: "PatientContexts");
        }
    }
}
