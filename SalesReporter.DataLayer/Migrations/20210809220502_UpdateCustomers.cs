using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesReporter.DataLayer.Migrations
{
    public partial class UpdateCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "FirstName", "LastName", "Phone", "Street", "ZipCode" },
                values: new object[,]
                {
                    { "2452ca0b-13a8-499e-b7cd-82ef0cb0d3bc", "Enlow", "Bethany", "Schroeder", "(844) 539-3422", "Riverdale Avenue", "35857" },
                    { "0f3bb335-5bac-4037-807c-b0c53833ebf2", "Unionville", "Jocelyn", "Wilder", "(814) 592-2250", "Albemarle Road", "35857" },
                    { "49671ecf-cfe5-4493-8206-3b0464eb4781", "Nash", "Gwendolyn", "Parks", "(973) 540-3779", "Dakota Place", "35856" },
                    { "1698c7a5-03c5-4f03-adcd-34dffe2771bd", "Rose", "Shirley", "Murray", "(855) 493-2038", "Gem Street", "35847" },
                    { "49ac076a-6f3b-4ed8-9512-fd5f4cb53b43", "Rodman", "Clark", "Benton", "(896) 475-3153", "Williams Court", "35896" },
                    { "743d4ca5-f460-41ce-9169-73910dce6672", "Duryea", "Corine", "Rodriquez", "(894) 536-3453", "Dwight Street", "35859" },
                    { "b0e89d76-96df-4986-8949-6218f3c99625", "Roland", "Nadine", "Snider", "(921) 584-2672", "Legion Street", "35890" },
                    { "7256e251-bf53-4914-a8d4-1d588457d391", "Dargan", "Susana", "Walters", "(950) 562-2546", "Miami Court", "35856" },
                    { "d379f1b4-e090-4e94-ba0a-b26873bf2060", "Orason", "Jodie", "Villarreal", "(877) 596-4000", "Love Lane", "35756" },
                    { "e351da94-ee13-4540-9299-7fcf95205ae0", "Fontanelle", "Rodriguez", "Battle", "(857) 554-3947", "River Street", "35855" },
                    { "74082c2b-b50e-4d37-8b6d-ffa63e8d26ae", "Abrams", "Christine", "Cameron", "(928) 422-3334", "Ivan Court", "34856" },
                    { "f2a88666-d226-4316-9d31-e879dd334e3c", "Motley", "Heidi", "Rivers", "(865) 475-3915", "Verona Street", "35856" },
                    { "a0214e01-d7dd-47d5-8832-e7608dd954dd", "Caron", "Edna", "May", "(993) 493-3490", "Harbor Court", "35898" },
                    { "d72abb87-aa6e-476c-a77f-ac4023df752b", "Wattsville", "Tamara", "Holman", "(985) 554-3493", "Florence Avenue", "33856" },
                    { "3529d5c3-13be-4903-b0d4-0d468a0941e3", "Steinhatchee", "Reilly", "Cunningham", "(882) 437-3366", "Oakland Place", "33886" },
                    { "22786b90-4554-4fd5-ac5a-a4aa3edb9c55", "Lopezo", "Lilia", "Parsons", "(983) 547-2639", "Vandalia Avenue", "95856" },
                    { "d5d78f36-290c-4d5b-bec2-77a836cc4e6e", "Dahlen", "Powell", "Stone", "(856) 430-2295", "Plaza Street", "35850" },
                    { "b49c2428-d020-46e9-90be-e9725c772b4e", "Belfair", "Adele", "Moss", "(988) 428-2435", "Coffey Street", "35856" },
                    { "7c85e6e8-a378-4fa8-ac1f-80435c75da9e", "Williamson", "Noreen", "Dejesus", "(966) 471-2919", "Thames Street", "35866" },
                    { "f2e88107-4530-4ae3-93a7-08f3214e6475", "Camino", "Blackwell", "Maynard", "(805) 503-2117", "Metrotech Courtr", "35756" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "0f3bb335-5bac-4037-807c-b0c53833ebf2");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "1698c7a5-03c5-4f03-adcd-34dffe2771bd");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "22786b90-4554-4fd5-ac5a-a4aa3edb9c55");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "2452ca0b-13a8-499e-b7cd-82ef0cb0d3bc");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "3529d5c3-13be-4903-b0d4-0d468a0941e3");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "49671ecf-cfe5-4493-8206-3b0464eb4781");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "49ac076a-6f3b-4ed8-9512-fd5f4cb53b43");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "7256e251-bf53-4914-a8d4-1d588457d391");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "74082c2b-b50e-4d37-8b6d-ffa63e8d26ae");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "743d4ca5-f460-41ce-9169-73910dce6672");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "7c85e6e8-a378-4fa8-ac1f-80435c75da9e");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "a0214e01-d7dd-47d5-8832-e7608dd954dd");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "b0e89d76-96df-4986-8949-6218f3c99625");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "b49c2428-d020-46e9-90be-e9725c772b4e");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "d379f1b4-e090-4e94-ba0a-b26873bf2060");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "d5d78f36-290c-4d5b-bec2-77a836cc4e6e");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "d72abb87-aa6e-476c-a77f-ac4023df752b");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "e351da94-ee13-4540-9299-7fcf95205ae0");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "f2a88666-d226-4316-9d31-e879dd334e3c");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "f2e88107-4530-4ae3-93a7-08f3214e6475");
        }
    }
}
