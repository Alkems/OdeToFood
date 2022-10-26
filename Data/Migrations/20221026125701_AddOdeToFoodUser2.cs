using Microsoft.EntityFrameworkCore.Migrations;

namespace OdeToFood.Data.Migrations
{
    public partial class AddOdeToFoodUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FavoriteRestaurant",
                table: "AspNetUsers",
                newName: "FavouriteRestaurant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FavouriteRestaurant",
                table: "AspNetUsers",
                newName: "FavoriteRestaurant");
        }
    }
}
