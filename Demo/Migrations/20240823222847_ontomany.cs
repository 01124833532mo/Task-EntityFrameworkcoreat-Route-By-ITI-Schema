using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class ontomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "dbo",
                table: "Department",
                newName: "DeptID");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptID",
                table: "Emploeyes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emploeyes_DepartmentDeptID",
                table: "Emploeyes",
                column: "DepartmentDeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Emploeyes_Department_DepartmentDeptID",
                table: "Emploeyes",
                column: "DepartmentDeptID",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "DeptID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emploeyes_Department_DepartmentDeptID",
                table: "Emploeyes");

            migrationBuilder.DropIndex(
                name: "IX_Emploeyes_DepartmentDeptID",
                table: "Emploeyes");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptID",
                table: "Emploeyes");

            migrationBuilder.RenameColumn(
                name: "DeptID",
                schema: "dbo",
                table: "Department",
                newName: "ID");
        }
    }
}
