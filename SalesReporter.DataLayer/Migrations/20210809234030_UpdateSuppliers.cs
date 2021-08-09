using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesReporter.DataLayer.Migrations
{
    public partial class UpdateSuppliers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "176a4c62-fb1b-4d77-9698-f1d80c116039");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "2a44dd92-e06d-4ffa-bbf2-62577ea0e1b7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "5d804063-10cc-4cf8-b2b2-d93fc98f8f59");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "69644191-a282-4679-8b00-d4446cfe24a8");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "8516c789-d0c4-40d7-ba97-7fe73b4e01d8");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "9702377d-512a-432a-8608-4a1281e42292");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "de260896-b1f5-4d62-81ae-930689c9dc35");

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "City", "CompanyName", "Country", "Phone", "PostalCode", "State" },
                values: new object[,]
                {
                    { "4502bdb5-e121-4d79-a66a-1766880c882b", "Topaz", "Sloganaut", "Western Sahara", "(812) 596-3786", "35856", "North Carolina" },
                    { "30eb03f2-1a33-43b0-b300-0d35918977e9", "Fairlee", "Confrenzy", "Liberia", "(994) 417-3976", "35859", "Massachusetts" },
                    { "2613956c-7b0d-4ffe-a1a2-c7d007a2c34d", "Waterview", "Letpro", "Croatia (Hrvatska)", "(879) 589-2032", "35856", "Kentucky" },
                    { "ce7f06b1-af75-4341-95b3-9b7c13cea42c", "Bentonville", "Portica", "Belgium", "(878) 471-2173", "35866", "Colorado" },
                    { "11b51e93-f79e-43c5-a365-5ae6e3873e41", "Crumpler", "Comveyor", "Marshall Islands", "(905) 514-2447", "35056", "Iowa" },
                    { "accae86b-e16a-4c64-a277-8e517660d415", "Odessa", "Intrawear", "Australia", "(911) 498-3277", "35856", "Arkansas" },
                    { "c2bacd1f-4c88-453c-bc2c-21551396069a", "Malo", "Qualitex", "Latvia", "(863) 502-2069", "35858", "New Hampshire" },
                    { "ef5c9a0f-d475-45f5-8eda-279019a4ff13", "Nord", "Frenex", "Cocos (Keeling Islands)", "(969) 576-3650", "35806", "Puerto Rico" },
                    { "e67beab4-9126-437c-bf35-cc53eaae055c", "Turah", "Isosphere", "Zimbabwe", "(913) 536-3166", "35886", "Marshall Islands" },
                    { "222e4f5f-fe2b-4e55-a50a-0671f5d9a2fa", "Islandia", "Futurity", "Malaysia", "(951) 584-3833", "35806", "Georgia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: "11b51e93-f79e-43c5-a365-5ae6e3873e41");

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: "222e4f5f-fe2b-4e55-a50a-0671f5d9a2fa");

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: "2613956c-7b0d-4ffe-a1a2-c7d007a2c34d");

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: "30eb03f2-1a33-43b0-b300-0d35918977e9");

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: "4502bdb5-e121-4d79-a66a-1766880c882b");

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: "accae86b-e16a-4c64-a277-8e517660d415");

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: "c2bacd1f-4c88-453c-bc2c-21551396069a");

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: "ce7f06b1-af75-4341-95b3-9b7c13cea42c");

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: "e67beab4-9126-437c-bf35-cc53eaae055c");

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: "ef5c9a0f-d475-45f5-8eda-279019a4ff13");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { "176a4c62-fb1b-4d77-9698-f1d80c116039", "Groceries", "Food items and provision" },
                    { "9702377d-512a-432a-8608-4a1281e42292", "Fashion", "Custom wears and apparels" },
                    { "5d804063-10cc-4cf8-b2b2-d93fc98f8f59", "Health and Beauty", "Rejuvenate your essence" },
                    { "de260896-b1f5-4d62-81ae-930689c9dc35", "Home and Office", "Small and large appliances and gadgets" },
                    { "2a44dd92-e06d-4ffa-bbf2-62577ea0e1b7", "Baby Products", "Apparel and freshly baked diapers" },
                    { "69644191-a282-4679-8b00-d4446cfe24a8", "Sporting goods", "Pump up the fitness vibe" },
                    { "8516c789-d0c4-40d7-ba97-7fe73b4e01d8", "Gaming", "All things playstation and vibes" }
                });
        }
    }
}
