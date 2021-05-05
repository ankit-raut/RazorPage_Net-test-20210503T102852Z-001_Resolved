using Microsoft.EntityFrameworkCore.Migrations;

namespace StardekkMediorFullstackDeveloper.Migrations
{
    public partial class udpdateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amanities_RoomTypes_RoomTypeId",
                table: "Amanities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Amanities",
                table: "Amanities");

            migrationBuilder.RenameTable(
                name: "Amanities",
                newName: "Amenities");

            migrationBuilder.RenameIndex(
                name: "IX_Amanities_RoomTypeId",
                table: "Amenities",
                newName: "IX_Amenities_RoomTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RoomTypes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Amenities",
                table: "Amenities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_RoomTypes_RoomTypeId",
                table: "Amenities",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_RoomTypes_RoomTypeId",
                table: "Amenities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Amenities",
                table: "Amenities");

            migrationBuilder.RenameTable(
                name: "Amenities",
                newName: "Amanities");

            migrationBuilder.RenameIndex(
                name: "IX_Amenities_RoomTypeId",
                table: "Amanities",
                newName: "IX_Amanities_RoomTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RoomTypes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amanities",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Amanities",
                table: "Amanities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Amanities_RoomTypes_RoomTypeId",
                table: "Amanities",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
