using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSU.Coins.dbContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleWebSites",
                table: "RoleWebSites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coins",
                table: "Coins");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Coins");

            migrationBuilder.RenameColumn(
                name: "RoleWebSite",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoleWebSites",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Materials",
                newName: "CoinId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Countries",
                newName: "CoinId");

            migrationBuilder.RenameColumn(
                name: "IdMaterial",
                table: "Coins",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "IdCountry",
                table: "Coins",
                newName: "CoinId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "RoleWebSites",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RoleWebSiteId",
                table: "RoleWebSites",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CoinId",
                table: "Materials",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Materials",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CoinId",
                table: "Countries",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Coins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CoinId",
                table: "Coins",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "Activ",
                table: "Coins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPresentation",
                table: "Coins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleWebSites",
                table: "RoleWebSites",
                column: "RoleWebSiteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "MaterialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coins",
                table: "Coins",
                column: "CoinId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleWebSites_UserId",
                table: "RoleWebSites",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CoinId",
                table: "Materials",
                column: "CoinId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CoinId",
                table: "Countries",
                column: "CoinId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coins_UserId",
                table: "Coins",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coins_Users_UserId",
                table: "Coins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Coins_CoinId",
                table: "Countries",
                column: "CoinId",
                principalTable: "Coins",
                principalColumn: "CoinId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Coins_CoinId",
                table: "Materials",
                column: "CoinId",
                principalTable: "Coins",
                principalColumn: "CoinId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleWebSites_Users_UserId",
                table: "RoleWebSites",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coins_Users_UserId",
                table: "Coins");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Coins_CoinId",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Coins_CoinId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleWebSites_Users_UserId",
                table: "RoleWebSites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleWebSites",
                table: "RoleWebSites");

            migrationBuilder.DropIndex(
                name: "IX_RoleWebSites_UserId",
                table: "RoleWebSites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_CoinId",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CoinId",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coins",
                table: "Coins");

            migrationBuilder.DropIndex(
                name: "IX_Coins_UserId",
                table: "Coins");

            migrationBuilder.DropColumn(
                name: "RoleWebSiteId",
                table: "RoleWebSites");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Activ",
                table: "Coins");

            migrationBuilder.DropColumn(
                name: "IsPresentation",
                table: "Coins");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "RoleWebSite");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "RoleWebSites",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CoinId",
                table: "Materials",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CoinId",
                table: "Countries",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Coins",
                newName: "IdMaterial");

            migrationBuilder.RenameColumn(
                name: "CoinId",
                table: "Coins",
                newName: "IdCountry");

            migrationBuilder.AlterColumn<int>(
                name: "RoleWebSite",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "RoleWebSites",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Materials",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Countries",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Coins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdCountry",
                table: "Coins",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Coins",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleWebSites",
                table: "RoleWebSites",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coins",
                table: "Coins",
                column: "Id");
        }
    }
}
