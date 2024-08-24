using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assement.Migrations
{
    /// <inheritdoc />
    public partial class NewFluentAplis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<DateOnly>(type: "date", nullable: false, computedColumnSql: "GETDATE()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Top_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Courses_Topics_Top_ID",
                        column: x => x.Top_ID,
                        principalTable: "Topics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course_Insts",
                columns: table => new
                {
                    Inst_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    evaluate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Insts", x => new { x.Course_ID, x.Inst_ID });
                    table.ForeignKey(
                        name: "FK_Course_Insts_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    instructorID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    HiringDate = table.Column<DateOnly>(type: "date", nullable: false, computedColumnSql: "GETDATE()"),
                    Ins_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Adress = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    HourRateBonous = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dept_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_instructors_Department_Dept_ID",
                        column: x => x.Dept_ID,
                        principalTable: "Department",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Lname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Adress = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Dept_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_Department_Dept_id",
                        column: x => x.Dept_id,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "student_Courses",
                columns: table => new
                {
                    Stud_ID = table.Column<int>(type: "int", nullable: false),
                    Cours_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student_Courses", x => new { x.Stud_ID, x.Cours_ID });
                    table.ForeignKey(
                        name: "FK_student_Courses_Courses_Cours_ID",
                        column: x => x.Cours_ID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_student_Courses_Students_Stud_ID",
                        column: x => x.Stud_ID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_Inst_ID",
                table: "Course_Insts",
                column: "Inst_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses",
                column: "Top_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Ins_ID",
                table: "Department",
                column: "Ins_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_instructorID",
                table: "Department",
                column: "instructorID");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_Dept_ID",
                table: "instructors",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_student_Courses_Cours_ID",
                table: "student_Courses",
                column: "Cours_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dept_id",
                table: "Students",
                column: "Dept_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_instructors_Inst_ID",
                table: "Course_Insts",
                column: "Inst_ID",
                principalTable: "instructors",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_instructors_Ins_ID",
                table: "Department",
                column: "Ins_ID",
                principalTable: "instructors",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_instructors_instructorID",
                table: "Department",
                column: "instructorID",
                principalTable: "instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_instructors_Ins_ID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_instructors_instructorID",
                table: "Department");

            migrationBuilder.DropTable(
                name: "Course_Insts");

            migrationBuilder.DropTable(
                name: "student_Courses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
