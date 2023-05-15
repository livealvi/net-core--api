using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa_API.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaTableWithBogus2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quo cumque nisi voluptatem possimus incidunt dolorum.", new DateTime(2023, 5, 7, 20, 42, 40, 850, DateTimeKind.Local).AddTicks(8990), "Eos voluptatem labore.", "https://picsum.photos/640/480/?image=716", "Jan Bernhard I", 5, 430, new DateTime(2023, 1, 13, 23, 57, 26, 468, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Beatae magnam doloribus.", new DateTime(2023, 5, 8, 9, 42, 6, 147, DateTimeKind.Local).AddTicks(1168), "Qui ut amet voluptatem.", "https://picsum.photos/640/480/?image=726", "Elsa Heaney DVM", 4.0, 412, new DateTime(2022, 6, 1, 12, 42, 56, 251, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsum velit enim neque veniam sed ea dolore nam excepturi.", new DateTime(2023, 5, 7, 23, 26, 32, 736, DateTimeKind.Local).AddTicks(7332), "Incidunt debitis temporibus omnis ut cumque deleniti.", "https://picsum.photos/640/480/?image=969", "Juan Renner IV", 8, 4.0, 679, new DateTime(2022, 9, 25, 8, 20, 6, 114, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur aliquam facilis ab eum voluptatem magnam.", new DateTime(2023, 5, 7, 20, 29, 10, 574, DateTimeKind.Local).AddTicks(8794), "Ullam ipsa nemo eveniet qui ipsa et.", "https://picsum.photos/640/480/?image=15", "Ms. Michael Luettgen", 122, new DateTime(2023, 4, 26, 1, 46, 57, 28, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut consequatur est.", new DateTime(2023, 5, 8, 2, 46, 44, 315, DateTimeKind.Local).AddTicks(682), "Architecto quaerat doloribus facilis sit maxime.", "https://picsum.photos/640/480/?image=78", "Ms. Felix Schmitt", 5, 3.0, 100, new DateTime(2022, 6, 25, 9, 32, 34, 936, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Modi adipisci et.", new DateTime(2023, 5, 7, 22, 37, 1, 450, DateTimeKind.Local).AddTicks(3227), "A aut quis quidem.", "https://picsum.photos/640/480/?image=993", "Audrey Mohr Jr.", 4, 5.0, 197, new DateTime(2022, 10, 29, 14, 57, 54, 711, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repudiandae dolores aut quo velit ducimus ut eligendi.", new DateTime(2023, 5, 8, 0, 34, 42, 267, DateTimeKind.Local).AddTicks(9157), "Architecto animi et molestias velit ipsa animi quas vero.", "https://picsum.photos/640/480/?image=255", "Ella Koss Jr.", 2, 3.0, 685, new DateTime(2022, 12, 26, 0, 53, 7, 569, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et laboriosam aut totam autem ipsam labore.", new DateTime(2023, 5, 8, 8, 7, 43, 862, DateTimeKind.Local).AddTicks(1961), "Placeat totam ab in culpa voluptas molestiae.", "https://picsum.photos/640/480/?image=33", "Pam Boyer III", 10, 1.0, 579, new DateTime(2023, 2, 21, 0, 29, 18, 305, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia veritatis dignissimos laborum nostrum fugiat.", new DateTime(2023, 5, 8, 0, 44, 14, 272, DateTimeKind.Local).AddTicks(9518), "Sit non nulla.", "https://picsum.photos/640/480/?image=336", "Mr. Miriam Homenick", 10, 2.0, 647, new DateTime(2022, 6, 23, 4, 0, 36, 121, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sequi libero labore non.", new DateTime(2023, 5, 8, 5, 59, 1, 990, DateTimeKind.Local).AddTicks(4081), "Dolore deserunt quia.", "https://picsum.photos/640/480/?image=468", "Mrs. Rachel Hermiston", 5, 725, new DateTime(2022, 7, 15, 21, 15, 9, 939, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aspernatur perspiciatis optio sapiente iure eveniet excepturi asperiores ipsam nobis.", new DateTime(2023, 5, 8, 0, 25, 49, 195, DateTimeKind.Local).AddTicks(4154), "Consequatur blanditiis nesciunt voluptates in.", "https://picsum.photos/640/480/?image=537", "Anna Wintheiser II", 2, 4.0, 965, new DateTime(2022, 12, 25, 11, 33, 7, 952, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Maiores velit nihil repellat alias consequatur aliquid.", new DateTime(2023, 5, 8, 10, 22, 32, 556, DateTimeKind.Local).AddTicks(3433), "Quaerat consequatur reiciendis ab unde ut qui quas voluptates.", "https://picsum.photos/640/480/?image=565", "Madeline Weimann II", 3, 896, new DateTime(2022, 10, 12, 16, 38, 59, 821, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum consequatur aut neque pariatur.", new DateTime(2023, 5, 8, 5, 31, 20, 6, DateTimeKind.Local).AddTicks(5986), "Vel est quasi amet corrupti similique cumque.", "https://picsum.photos/640/480/?image=544", "Ms. Belinda Ledner", 10, 1.0, 670, new DateTime(2022, 9, 14, 4, 47, 8, 97, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui porro sint corporis est quia quo fugit voluptatum.", new DateTime(2023, 5, 8, 14, 41, 55, 951, DateTimeKind.Local).AddTicks(5839), "Temporibus eligendi non nulla qui atque explicabo.", "https://picsum.photos/640/480/?image=629", "Madeline Purdy IV", 7, 5.0, 775, new DateTime(2022, 9, 7, 5, 22, 12, 454, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Doloribus voluptatum at et earum unde reprehenderit pariatur nemo.", new DateTime(2023, 5, 8, 14, 36, 5, 493, DateTimeKind.Local).AddTicks(4652), "Alias rerum porro aliquid qui et officiis consectetur.", "https://picsum.photos/640/480/?image=566", "Roman Rohan Jr.", 10, 2.0, 321, new DateTime(2022, 7, 6, 4, 46, 21, 826, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempore et reiciendis.", new DateTime(2023, 5, 7, 23, 21, 42, 223, DateTimeKind.Local).AddTicks(1897), "Laboriosam vel deserunt et ut vel quas suscipit illo.", "https://picsum.photos/640/480/?image=562", "Yolanda VonRueden III", 973, new DateTime(2022, 12, 20, 8, 44, 54, 595, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est ipsa qui aut non numquam illo hic nesciunt.", new DateTime(2023, 5, 7, 22, 1, 26, 941, DateTimeKind.Local).AddTicks(5466), "Quia et reprehenderit dignissimos corporis.", "https://picsum.photos/640/480/?image=820", "Terence Larkin PhD", 8, 1.0, 830, new DateTime(2022, 7, 24, 9, 32, 36, 571, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nemo ratione ea dolorum natus in odit est deserunt.", new DateTime(2023, 5, 8, 8, 1, 40, 259, DateTimeKind.Local).AddTicks(5924), "Cum similique earum molestias magni aut.", "https://picsum.photos/640/480/?image=840", "Kelli Robel MD", 1, 2.0, 519, new DateTime(2022, 6, 13, 2, 12, 19, 358, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolorum ab ullam alias non et sunt.", new DateTime(2023, 5, 8, 4, 11, 36, 194, DateTimeKind.Local).AddTicks(1689), "Aut dolor consequatur distinctio.", "https://picsum.photos/640/480/?image=567", "Mr. Melody Blanda", 2.0, 250, new DateTime(2022, 10, 23, 3, 52, 23, 442, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rem officia nihil inventore enim sed itaque.", new DateTime(2023, 5, 8, 1, 19, 37, 498, DateTimeKind.Local).AddTicks(9732), "Voluptate distinctio consequatur adipisci nam.", "https://picsum.photos/640/480/?image=810", "Ms. Nadine Blanda", 8, 3.0, 484, new DateTime(2022, 11, 25, 9, 25, 50, 979, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et explicabo similique.", new DateTime(2023, 5, 8, 5, 32, 50, 940, DateTimeKind.Local).AddTicks(8885), "Sit error voluptates omnis consectetur excepturi praesentium.", "https://picsum.photos/640/480/?image=1070", "Mr. Samantha Rohan", 5, 632, new DateTime(2022, 6, 14, 19, 35, 35, 249, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "In officiis et voluptatibus omnis alias omnis qui.", new DateTime(2023, 5, 8, 19, 33, 9, 814, DateTimeKind.Local).AddTicks(2414), "Qui unde asperiores provident delectus ut sequi dolor.", "https://picsum.photos/640/480/?image=1057", "Ms. Josh Nolan", 10, 492, new DateTime(2023, 1, 4, 11, 42, 39, 685, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nostrum nisi necessitatibus optio quas.", new DateTime(2023, 5, 8, 3, 41, 52, 793, DateTimeKind.Local).AddTicks(515), "Mollitia placeat voluptate quae dolore impedit sed.", "https://picsum.photos/640/480/?image=665", "Mr. Kathryn Bode", 9, 4.0, 712, new DateTime(2023, 2, 25, 20, 50, 48, 41, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Delectus aspernatur sunt hic autem vel optio.", new DateTime(2023, 5, 8, 0, 21, 47, 175, DateTimeKind.Local).AddTicks(773), "Tenetur numquam laboriosam dolorem eveniet esse numquam ex doloremque.", "https://picsum.photos/640/480/?image=988", "Juanita Wyman DVM", 1, 5.0, 10, new DateTime(2022, 11, 18, 18, 40, 0, 565, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nemo non facere vel id ducimus.", new DateTime(2023, 5, 8, 11, 54, 34, 727, DateTimeKind.Local).AddTicks(1237), "Qui dicta sint.", "https://picsum.photos/640/480/?image=692", "Belinda Turner Jr.", 6, 5.0, 6, new DateTime(2022, 5, 29, 19, 26, 18, 134, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Mollitia dolore hic quod quos voluptate.", new DateTime(2023, 5, 8, 13, 11, 53, 430, DateTimeKind.Local).AddTicks(9292), "Qui laudantium est minus illo et qui quo aperiam.", "https://picsum.photos/640/480/?image=242", "Dr. Danielle Keeling", 10, 3.0, 694, new DateTime(2022, 10, 19, 6, 23, 31, 125, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsam ab sed dicta nemo quia exercitationem iure.", new DateTime(2023, 5, 7, 23, 12, 15, 214, DateTimeKind.Local).AddTicks(2059), "Eius aut dolore sunt ad quam et dolore laboriosam sint.", "https://picsum.photos/640/480/?image=699", "Curtis Wisoky III", 3, 2.0, 479, new DateTime(2023, 3, 5, 23, 0, 8, 111, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Odit enim voluptas accusamus cumque ab.", new DateTime(2023, 5, 8, 4, 32, 45, 541, DateTimeKind.Local).AddTicks(9782), "Modi hic voluptatem nihil non harum officia consequatur ducimus.", "https://picsum.photos/640/480/?image=7", "Miss Harriet Donnelly", 4, 451, new DateTime(2023, 1, 23, 5, 25, 59, 207, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Adipisci veniam magnam.", new DateTime(2023, 5, 8, 19, 31, 21, 542, DateTimeKind.Local).AddTicks(5182), "In illo quibusdam nihil esse dolorum totam est.", "https://picsum.photos/640/480/?image=1074", "Thelma Sauer PhD", 10, 4.0, 969, new DateTime(2023, 3, 12, 12, 1, 7, 519, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum ea ad sint quis et optio.", new DateTime(2023, 5, 8, 19, 9, 7, 951, DateTimeKind.Local).AddTicks(5308), "Nobis ratione debitis.", "https://picsum.photos/640/480/?image=275", "Al Balistreri MD", 3, 417, new DateTime(2023, 3, 14, 20, 15, 55, 760, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Itaque sed distinctio quas.", new DateTime(2023, 5, 8, 11, 2, 56, 375, DateTimeKind.Local).AddTicks(8351), "Quam quaerat magnam magni velit sed et molestias nesciunt.", "https://picsum.photos/640/480/?image=202", "Mr. Frankie Hagenes", 2, 5.0, 741, new DateTime(2023, 4, 13, 20, 50, 57, 264, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Praesentium architecto rerum sunt impedit doloremque.", new DateTime(2023, 5, 8, 19, 16, 11, 411, DateTimeKind.Local).AddTicks(1061), "Dolorem quisquam libero quae rem reprehenderit sequi qui quisquam.", "https://picsum.photos/640/480/?image=263", "Rick Walker DDS", 10, 4.0, 364, new DateTime(2022, 6, 6, 7, 4, 22, 312, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Officia aut in voluptas est expedita hic minima iste.", new DateTime(2023, 5, 7, 20, 44, 49, 543, DateTimeKind.Local).AddTicks(3998), "Dolor cum minus ea mollitia similique.", "https://picsum.photos/640/480/?image=1058", "Milton Kertzmann Jr.", 4, 3.0, 60, new DateTime(2022, 9, 16, 14, 35, 56, 212, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Enim ex quam cumque.", new DateTime(2023, 5, 8, 11, 59, 11, 811, DateTimeKind.Local).AddTicks(8001), "Error impedit ullam ut aut.", "https://picsum.photos/640/480/?image=584", "Mr. Clark Paucek", 4, 3.0, 44, new DateTime(2022, 9, 15, 18, 40, 56, 298, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Magni delectus et id repudiandae nam excepturi et dolore nihil.", new DateTime(2023, 5, 8, 1, 50, 44, 631, DateTimeKind.Local).AddTicks(1845), "Rerum est sint non.", "https://picsum.photos/640/480/?image=224", "Marilyn Cartwright V", 3.0, 556, new DateTime(2022, 8, 3, 6, 3, 35, 41, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Non aut et eius.", new DateTime(2023, 5, 8, 4, 1, 2, 91, DateTimeKind.Local).AddTicks(6784), "Qui qui exercitationem reiciendis alias sed qui.", "https://picsum.photos/640/480/?image=894", "Ms. Andres Purdy", 6, 2.0, 922, new DateTime(2022, 9, 20, 16, 35, 11, 92, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem maxime sed itaque.", new DateTime(2023, 5, 8, 4, 18, 36, 351, DateTimeKind.Local).AddTicks(8274), "Quis modi natus odit dignissimos sunt nemo maiores eos.", "https://picsum.photos/640/480/?image=717", "Forrest Gerhold II", 9, 416, new DateTime(2023, 3, 14, 2, 58, 3, 194, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui atque unde vitae.", new DateTime(2023, 5, 8, 8, 51, 39, 215, DateTimeKind.Local).AddTicks(6097), "Officia veniam sint non.", "https://picsum.photos/640/480/?image=402", "Mrs. Marjorie Greenfelder", 3, 5.0, 781, new DateTime(2022, 9, 24, 20, 52, 32, 157, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Totam et saepe enim vitae.", new DateTime(2023, 5, 8, 5, 59, 34, 187, DateTimeKind.Local).AddTicks(155), "Deleniti omnis sapiente inventore.", "https://picsum.photos/640/480/?image=447", "Ms. Jeremy O'Reilly", 10, 5.0, 259, new DateTime(2023, 1, 10, 0, 54, 11, 824, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolorum cumque illum reprehenderit omnis ea.", new DateTime(2023, 5, 8, 5, 8, 14, 111, DateTimeKind.Local).AddTicks(9261), "Aut laborum sit veritatis.", "https://picsum.photos/640/480/?image=1048", "Casey Marquardt IV", 704, new DateTime(2022, 12, 20, 5, 5, 49, 62, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestiae maiores unde.", new DateTime(2023, 5, 8, 10, 21, 0, 306, DateTimeKind.Local).AddTicks(7548), "Velit qui nulla velit est alias veritatis molestiae provident doloribus.", "https://picsum.photos/640/480/?image=797", "Mrs. Alexis Raynor", 3, 4.0, 609, new DateTime(2023, 1, 1, 7, 26, 57, 203, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Labore repellendus suscipit libero aspernatur atque enim necessitatibus sit eos.", new DateTime(2023, 5, 7, 23, 55, 23, 585, DateTimeKind.Local).AddTicks(2621), "Voluptate esse quasi magni perspiciatis.", "https://picsum.photos/640/480/?image=864", "Alice Schiller MD", 5, 2.0, 619, new DateTime(2022, 11, 6, 7, 10, 45, 953, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem repellat ratione necessitatibus ex itaque at.", new DateTime(2023, 5, 7, 21, 30, 9, 253, DateTimeKind.Local).AddTicks(2424), "Repudiandae architecto officiis qui eius est et dignissimos.", "https://picsum.photos/640/480/?image=863", "Mr. Kristine Schmidt", 7, 1.0, 789, new DateTime(2022, 8, 28, 10, 16, 36, 26, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit dolore similique est quasi consectetur dicta quisquam sunt qui.", new DateTime(2023, 5, 8, 16, 28, 25, 644, DateTimeKind.Local).AddTicks(9044), "Non sit nemo vel qui ea aut qui.", "https://picsum.photos/640/480/?image=1043", "Sue Greenholt II", 4, 4.0, 554, new DateTime(2022, 6, 2, 20, 3, 25, 987, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quasi quis consequuntur eos quis a quis cum non.", new DateTime(2023, 5, 8, 5, 55, 18, 411, DateTimeKind.Local).AddTicks(6091), "Doloremque dolorem sequi fugiat eum at dicta est quaerat.", "https://picsum.photos/640/480/?image=764", "Ken Thompson PhD", 2, 3.0, 255, new DateTime(2022, 5, 17, 22, 21, 3, 729, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempora dolorum molestiae ad.", new DateTime(2023, 5, 8, 5, 14, 11, 772, DateTimeKind.Local).AddTicks(7669), "Qui non ut neque et voluptatibus sit ad.", "https://picsum.photos/640/480/?image=966", "Ms. Marguerite McClure", 6, 4.0, 175, new DateTime(2022, 6, 5, 5, 46, 47, 216, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Non non dolorem minus consequatur.", new DateTime(2023, 5, 8, 19, 42, 9, 351, DateTimeKind.Local).AddTicks(6551), "Rerum aut et blanditiis quas et libero vel et.", "https://picsum.photos/640/480/?image=665", "Marlon Hoppe MD", 9, 5.0, 676, new DateTime(2022, 6, 15, 12, 25, 55, 143, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laudantium sit itaque eligendi cupiditate eius et.", new DateTime(2023, 5, 8, 2, 42, 54, 729, DateTimeKind.Local).AddTicks(6768), "Facilis aut itaque sunt tenetur.", "https://picsum.photos/640/480/?image=626", "Wilfred Lowe V", 1, 1.0, 831, new DateTime(2022, 9, 7, 11, 42, 59, 349, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ratione harum ea dicta laudantium corrupti.", new DateTime(2023, 5, 8, 19, 54, 46, 237, DateTimeKind.Local).AddTicks(4539), "Inventore harum suscipit amet ut eos accusantium aut aspernatur nisi.", "https://picsum.photos/640/480/?image=244", "Dr. Alfred Wuckert", 5, 1.0, 713, new DateTime(2023, 1, 15, 20, 7, 38, 484, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis sit omnis quo voluptatem.", new DateTime(2023, 5, 7, 22, 13, 35, 948, DateTimeKind.Local).AddTicks(9834), "Qui facilis esse deleniti neque.", "https://picsum.photos/640/480/?image=324", "Miss George Bartell", 4, 3.0, 739, new DateTime(2022, 10, 21, 15, 41, 51, 428, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iure accusantium dolor quo expedita et sed pariatur sed voluptatibus.", new DateTime(2023, 5, 8, 9, 29, 47, 484, DateTimeKind.Local).AddTicks(7688), "Voluptate ea aut harum non deleniti et aut.", "https://picsum.photos/640/480/?image=518", "Jamie Baumbach II", 9, 5.0, 708, new DateTime(2022, 12, 10, 22, 52, 51, 614, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "In id harum temporibus qui perspiciatis facilis accusamus.", new DateTime(2023, 5, 8, 11, 34, 21, 390, DateTimeKind.Local).AddTicks(986), "Saepe nihil maxime ut aut sint aliquam sit sit vitae.", "https://picsum.photos/640/480/?image=1056", "Mrs. Marcia Block", 7, 4.0, 514, new DateTime(2023, 4, 20, 23, 43, 51, 736, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quidem dolor maiores delectus tenetur aperiam.", new DateTime(2023, 5, 8, 0, 16, 48, 373, DateTimeKind.Local).AddTicks(5446), "Aliquam sapiente sit qui quo.", "https://picsum.photos/640/480/?image=1064", "Eric Osinski DDS", 6, 3.0, 442, new DateTime(2022, 9, 3, 23, 47, 19, 603, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ad id nulla.", new DateTime(2023, 5, 7, 20, 33, 28, 436, DateTimeKind.Local).AddTicks(7072), "Quia neque velit.", "https://picsum.photos/640/480/?image=1080", "Sherman Morar IV", 3.0, 5, new DateTime(2022, 12, 5, 1, 53, 27, 69, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Earum ut qui quia omnis et vitae est est.", new DateTime(2023, 5, 8, 13, 22, 54, 918, DateTimeKind.Local).AddTicks(5371), "Voluptatem explicabo amet illum fuga quis ea placeat ratione perferendis.", "https://picsum.photos/640/480/?image=443", "Camille Conroy Sr.", 7, 1.0, 443, new DateTime(2023, 2, 16, 3, 40, 9, 226, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui quas ullam tenetur odio at.", new DateTime(2023, 5, 8, 0, 51, 44, 0, DateTimeKind.Local).AddTicks(15), "Consequuntur et odio velit praesentium quas at esse enim eius.", "https://picsum.photos/640/480/?image=461", "Jaime Koss I", 9, 2.0, 207, new DateTime(2022, 8, 25, 18, 1, 59, 176, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur laudantium ad nam ducimus sed ut voluptates sed.", new DateTime(2023, 5, 8, 14, 39, 58, 602, DateTimeKind.Local).AddTicks(3809), "Officiis eum quo.", "https://picsum.photos/640/480/?image=437", "Jason Lynch Jr.", 3, 2.0, 335, new DateTime(2022, 12, 5, 6, 10, 7, 179, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "In ipsam voluptatibus.", new DateTime(2023, 5, 8, 8, 17, 54, 814, DateTimeKind.Local).AddTicks(3597), "Molestias provident numquam omnis deserunt ipsum voluptas ut blanditiis quia.", "https://picsum.photos/640/480/?image=650", "Caroline Bartoletti V", 6, 4.0, 728, new DateTime(2022, 8, 17, 1, 4, 53, 110, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit beatae aut sapiente libero qui quis.", new DateTime(2023, 5, 8, 10, 53, 13, 440, DateTimeKind.Local).AddTicks(9450), "Labore rerum debitis nobis numquam.", "https://picsum.photos/640/480/?image=163", "Ms. Viola Schinner", 4, 3.0, 818, new DateTime(2023, 2, 15, 12, 31, 51, 224, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Vitae distinctio blanditiis quo modi temporibus ut tempore quia vitae.", new DateTime(2023, 5, 8, 17, 12, 1, 387, DateTimeKind.Local).AddTicks(2879), "Alias laudantium rerum necessitatibus et.", "https://picsum.photos/640/480/?image=812", "Ms. Pat Fay", 7, 721, new DateTime(2023, 3, 24, 22, 43, 16, 154, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum reprehenderit fugiat labore sed quisquam dolorem atque maiores soluta.", new DateTime(2023, 5, 8, 13, 39, 46, 899, DateTimeKind.Local).AddTicks(7799), "Et porro voluptatum recusandae.", "https://picsum.photos/640/480/?image=701", "Mrs. Gustavo Schaden", 5, 1.0, 801, new DateTime(2023, 2, 15, 23, 47, 40, 804, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tenetur magnam iste.", new DateTime(2023, 5, 8, 15, 15, 1, 664, DateTimeKind.Local).AddTicks(9078), "Sit soluta saepe voluptas vero.", "https://picsum.photos/640/480/?image=777", "Mr. Bernadette MacGyver", 6, 5.0, 34, new DateTime(2023, 4, 10, 5, 8, 30, 580, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed sint culpa et sit adipisci.", new DateTime(2023, 5, 8, 17, 30, 49, 283, DateTimeKind.Local).AddTicks(2474), "Qui culpa et vero totam.", "https://picsum.photos/640/480/?image=155", "Mrs. Clint Pfannerstill", 1, 5.0, 680, new DateTime(2023, 3, 5, 5, 59, 50, 668, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut tenetur odio et voluptas quam doloribus.", new DateTime(2023, 5, 8, 11, 28, 20, 807, DateTimeKind.Local).AddTicks(141), "Consequuntur similique inventore voluptate molestiae.", "https://picsum.photos/640/480/?image=385", "Jenna Kerluke PhD", 3, 4.0, 968, new DateTime(2023, 1, 27, 2, 43, 48, 806, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Expedita sunt ut culpa voluptas tenetur rerum occaecati.", new DateTime(2023, 5, 8, 17, 46, 21, 991, DateTimeKind.Local).AddTicks(162), "Ab non quidem non omnis.", "https://picsum.photos/640/480/?image=156", "Mr. Philip Greenfelder", 8, 5.0, 482, new DateTime(2022, 9, 14, 18, 55, 28, 724, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ullam ea et ex quas aut minus.", new DateTime(2023, 5, 8, 11, 50, 53, 686, DateTimeKind.Local).AddTicks(3458), "Praesentium dolorem corporis dolor.", "https://picsum.photos/640/480/?image=530", "Ms. Jennie Ward", 4.0, 729, new DateTime(2022, 12, 4, 21, 1, 44, 488, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Esse saepe occaecati expedita.", new DateTime(2023, 5, 7, 23, 40, 18, 844, DateTimeKind.Local).AddTicks(9925), "At qui debitis quidem ut porro recusandae voluptate quia quaerat.", "https://picsum.photos/640/480/?image=310", "Leslie Jacobs Jr.", 5, 4.0, 507, new DateTime(2022, 9, 22, 4, 8, 57, 797, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quod excepturi et sed fuga odit.", new DateTime(2023, 5, 7, 22, 54, 26, 1, DateTimeKind.Local).AddTicks(1620), "Illum autem autem iure quaerat vero molestiae laboriosam.", "https://picsum.photos/640/480/?image=71", "Miss Vicki Carroll", 763, new DateTime(2022, 5, 29, 22, 49, 37, 691, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iste ut quis asperiores ratione saepe voluptatibus.", new DateTime(2023, 5, 8, 5, 32, 13, 177, DateTimeKind.Local).AddTicks(4038), "Vel in officiis sed.", "https://picsum.photos/640/480/?image=608", "Miss Ramona Brakus", 1, 2.0, 984, new DateTime(2023, 1, 27, 8, 2, 24, 195, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Hic enim culpa quo.", new DateTime(2023, 5, 7, 20, 38, 0, 375, DateTimeKind.Local).AddTicks(9902), "Est ab sunt sint.", "https://picsum.photos/640/480/?image=527", "Lynette Heidenreich DDS", 7, 3.0, 166, new DateTime(2022, 11, 26, 0, 43, 55, 23, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laudantium enim qui qui.", new DateTime(2023, 5, 8, 12, 54, 38, 512, DateTimeKind.Local).AddTicks(7293), "Autem ipsa dolorum repudiandae eos.", "https://picsum.photos/640/480/?image=907", "Dr. Sheryl King", 5, 3.0, 421, new DateTime(2022, 11, 28, 0, 21, 22, 92, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui ipsa et architecto dolore consectetur aut sed doloribus.", new DateTime(2023, 5, 8, 0, 42, 25, 531, DateTimeKind.Local).AddTicks(4325), "Ducimus occaecati placeat perspiciatis assumenda est explicabo est.", "https://picsum.photos/640/480/?image=238", "Brandi Bartell DVM", 1.0, 321, new DateTime(2023, 4, 28, 1, 42, 24, 701, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et est ipsum sit corrupti tempore nulla animi sunt tempore.", new DateTime(2023, 5, 8, 7, 35, 15, 96, DateTimeKind.Local).AddTicks(2042), "Aut non nulla quam et sint quis est cumque et.", "https://picsum.photos/640/480/?image=520", "Eugene Howell DDS", 9, 5.0, 11, new DateTime(2023, 1, 15, 9, 22, 47, 485, DateTimeKind.Local).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ullam porro est.", new DateTime(2023, 5, 8, 2, 53, 51, 865, DateTimeKind.Local).AddTicks(7874), "In minus repellat ut sequi quia et.", "https://picsum.photos/640/480/?image=771", "Miss Tonya Toy", 1, 4.0, 575, new DateTime(2022, 10, 3, 10, 22, 12, 685, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur recusandae et numquam corporis voluptas architecto corrupti eveniet eligendi.", new DateTime(2023, 5, 8, 18, 22, 46, 113, DateTimeKind.Local).AddTicks(9886), "Non soluta placeat dignissimos iste maxime voluptas voluptatem.", "https://picsum.photos/640/480/?image=355", "Ms. Luz Reinger", 3, 3.0, 520, new DateTime(2023, 2, 11, 17, 1, 57, 208, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Similique placeat neque vero consequatur non ut dolorem ut.", new DateTime(2023, 5, 8, 11, 33, 7, 918, DateTimeKind.Local).AddTicks(7846), "Occaecati officiis sunt iure illo possimus quia ratione.", "https://picsum.photos/640/480/?image=434", "Mr. Billie Strosin", 10, 4.0, 822, new DateTime(2022, 8, 10, 11, 5, 3, 345, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis iste architecto qui.", new DateTime(2023, 5, 8, 0, 12, 58, 696, DateTimeKind.Local).AddTicks(7427), "Repellendus at voluptate.", "https://picsum.photos/640/480/?image=991", "Heather Padberg I", 6, 1.0, 806, new DateTime(2022, 12, 26, 18, 51, 13, 6, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit facilis ut dolor vitae perferendis.", new DateTime(2023, 5, 8, 12, 56, 9, 50, DateTimeKind.Local).AddTicks(5557), "Voluptatem impedit animi eum hic qui reiciendis.", "https://picsum.photos/640/480/?image=65", "Miss Darren Toy", 6, 5.0, 419, new DateTime(2022, 9, 22, 1, 15, 18, 735, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia omnis aspernatur aut.", new DateTime(2023, 5, 8, 6, 48, 8, 544, DateTimeKind.Local).AddTicks(4517), "Eum soluta itaque ut minus fugiat repellat.", "https://picsum.photos/640/480/?image=839", "Mrs. Robin Smith", 10, 5.0, 393, new DateTime(2022, 11, 7, 6, 26, 29, 363, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Officia quia illum omnis quia culpa odit laborum cumque.", new DateTime(2023, 5, 7, 22, 35, 51, 256, DateTimeKind.Local).AddTicks(1674), "Numquam neque perspiciatis.", "https://picsum.photos/640/480/?image=102", "Brent Mann DVM", 1, 666, new DateTime(2023, 2, 12, 16, 32, 18, 962, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis necessitatibus labore.", new DateTime(2023, 5, 8, 6, 44, 13, 160, DateTimeKind.Local).AddTicks(1888), "Et eos eveniet voluptate.", "https://picsum.photos/640/480/?image=19", "Mr. Aubrey Kohler", 5, 3.0, 432, new DateTime(2022, 7, 11, 17, 52, 34, 520, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et quia similique atque incidunt.", new DateTime(2023, 5, 8, 12, 10, 40, 806, DateTimeKind.Local).AddTicks(7881), "Reiciendis ut atque sint quod nemo voluptatem aliquid veniam.", "https://picsum.photos/640/480/?image=41", "Jean Doyle I", 5, 313, new DateTime(2022, 9, 26, 6, 33, 16, 595, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui repellat odit et.", new DateTime(2023, 5, 8, 11, 30, 18, 194, DateTimeKind.Local).AddTicks(6338), "Quam architecto rerum fugiat et itaque pariatur ea.", "https://picsum.photos/640/480/?image=179", "Miss Merle Boehm", 8, 1.0, 157, new DateTime(2023, 2, 18, 19, 2, 53, 988, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aliquid doloribus cupiditate aut et ipsam.", new DateTime(2023, 5, 7, 20, 11, 14, 886, DateTimeKind.Local).AddTicks(5089), "Quas architecto cumque quis corporis dolores quod non unde doloribus.", "https://picsum.photos/640/480/?image=114", "Dr. Elsie Vandervort", 3.0, 966, new DateTime(2023, 1, 6, 9, 58, 32, 1, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nihil sed maiores earum eligendi labore consequuntur.", new DateTime(2023, 5, 8, 17, 6, 10, 851, DateTimeKind.Local).AddTicks(3121), "Cum vel id commodi ut.", "https://picsum.photos/640/480/?image=914", "Alfred Runolfsdottir PhD", 6, 3.0, 622, new DateTime(2022, 6, 5, 1, 56, 32, 444, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aspernatur odit atque voluptatum ut officia dolorem officiis.", new DateTime(2023, 5, 8, 14, 35, 28, 488, DateTimeKind.Local).AddTicks(767), "Voluptatem dolorem mollitia aut ratione porro quae unde sit.", "https://picsum.photos/640/480/?image=1013", "Lawrence Smith IV", 10, 1.0, 385, new DateTime(2022, 12, 7, 11, 14, 24, 883, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum adipisci a et eaque nihil vel ipsa ea.", new DateTime(2023, 5, 8, 11, 40, 48, 69, DateTimeKind.Local).AddTicks(9519), "Quia dolorem blanditiis error et maxime veniam optio.", "https://picsum.photos/640/480/?image=575", "Mrs. Jesse Huel", 1, 290, new DateTime(2022, 10, 10, 8, 28, 52, 498, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut est saepe odit nulla ut id repudiandae.", new DateTime(2023, 5, 8, 16, 16, 44, 50, DateTimeKind.Local).AddTicks(9579), "Et et impedit aut dolores voluptatibus quod quis velit ut.", "https://picsum.photos/640/480/?image=105", "Miss Noel Goyette", 2, 5.0, 22, new DateTime(2022, 6, 24, 15, 24, 1, 681, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis vel voluptates consequatur incidunt molestiae ipsam iste inventore.", new DateTime(2023, 5, 8, 15, 41, 2, 71, DateTimeKind.Local).AddTicks(5842), "Aut doloribus rerum enim aperiam.", "https://picsum.photos/640/480/?image=742", "Mrs. Trevor Langworth", 7, 2.0, 838, new DateTime(2022, 10, 9, 18, 26, 39, 347, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quasi voluptas reprehenderit.", new DateTime(2023, 5, 8, 10, 38, 47, 512, DateTimeKind.Local).AddTicks(6263), "Voluptatem impedit quam ad.", "https://picsum.photos/640/480/?image=286", "Krystal Grimes Sr.", 3, 575, new DateTime(2023, 4, 16, 9, 51, 0, 836, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellendus at exercitationem dolore.", new DateTime(2023, 5, 8, 14, 45, 23, 555, DateTimeKind.Local).AddTicks(9148), "Occaecati molestias nihil qui.", "https://picsum.photos/640/480/?image=85", "Bridget Koepp Jr.", 6, 2.0, 77, new DateTime(2023, 1, 28, 1, 42, 37, 312, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellendus iure numquam blanditiis atque.", new DateTime(2023, 5, 8, 2, 35, 13, 121, DateTimeKind.Local).AddTicks(351), "Voluptatum impedit assumenda corporis.", "https://picsum.photos/640/480/?image=538", "Dr. Willie Von", 3, 5.0, 915, new DateTime(2022, 8, 23, 19, 41, 2, 461, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis beatae illum est rerum quas cumque aut mollitia.", new DateTime(2023, 5, 8, 1, 14, 44, 910, DateTimeKind.Local).AddTicks(106), "Velit quos est pariatur ipsa tempore aut.", "https://picsum.photos/640/480/?image=514", "Mr. Beatrice Barrows", 1, 5.0, 789, new DateTime(2023, 4, 12, 17, 21, 29, 1, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sapiente pariatur atque tempora animi.", new DateTime(2023, 5, 8, 2, 29, 54, 806, DateTimeKind.Local).AddTicks(6541), "Praesentium optio nostrum nulla sunt dolor consequatur.", "https://picsum.photos/640/480/?image=707", "Mr. Latoya Blick", 7, 5.0, 224, new DateTime(2022, 9, 22, 17, 43, 58, 707, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit dolores assumenda consectetur eos in rerum porro dignissimos laborum.", new DateTime(2023, 5, 8, 4, 46, 47, 121, DateTimeKind.Local).AddTicks(9862), "Est iure optio nobis voluptatem aut cum.", "https://picsum.photos/640/480/?image=238", "Kate Moore V", 4, 5.0, 281, new DateTime(2022, 9, 16, 23, 53, 2, 362, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quo numquam repellendus tempora dolorum consequatur culpa laboriosam.", new DateTime(2023, 5, 8, 10, 39, 25, 361, DateTimeKind.Local).AddTicks(3333), "Aut autem maiores exercitationem ad cumque.", "https://picsum.photos/640/480/?image=460", "Dr. Eunice Crooks", 4, 2.0, 136, new DateTime(2022, 12, 19, 21, 32, 18, 584, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Fugiat eligendi vero.", new DateTime(2023, 5, 7, 20, 9, 5, 895, DateTimeKind.Local).AddTicks(5376), "Libero tempore repudiandae enim molestias ex nesciunt ducimus.", "https://picsum.photos/640/480/?image=348", "Dwayne Lemke I", 1, 5.0, 384, new DateTime(2022, 8, 24, 3, 0, 0, 872, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas fugiat velit suscipit vero doloremque asperiores et ut vitae.", new DateTime(2023, 5, 8, 11, 26, 52, 261, DateTimeKind.Local).AddTicks(5946), "Eveniet exercitationem dolor nostrum et.", "https://picsum.photos/640/480/?image=1006", "Mr. Willie McKenzie", 6, 135, new DateTime(2022, 11, 14, 19, 31, 30, 75, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestiae numquam nulla voluptatem fugiat unde ea dolor voluptatum sed.", new DateTime(2023, 5, 8, 17, 25, 8, 124, DateTimeKind.Local).AddTicks(7041), "Inventore delectus nobis consequuntur.", "https://picsum.photos/640/480/?image=833", "Mr. Darin Johns", 8, 656, new DateTime(2023, 4, 19, 9, 47, 44, 580, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Exercitationem qui nobis possimus.", new DateTime(2023, 5, 8, 15, 48, 47, 466, DateTimeKind.Local).AddTicks(9539), "Amet excepturi sint tenetur deleniti officiis ut eum consequatur in.", "https://picsum.photos/640/480/?image=922", "Jesse Shields II", 9, 862, new DateTime(2022, 5, 30, 11, 59, 34, 279, DateTimeKind.Local).AddTicks(545) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Hic debitis ullam rerum.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(6600), "Et aut nesciunt iure voluptates earum ipsam dolor nam laudantium.", "https://picsum.photos/640/480/?image=144", "Marcus Stiedemann II", 1, 742, new DateTime(2022, 8, 10, 2, 54, 51, 422, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Mollitia nihil molestiae placeat dicta aut ratione odit deleniti.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(6800), "Voluptas id harum saepe.", "https://picsum.photos/640/480/?image=817", "Miss Sidney Buckridge", 1.0, 753, new DateTime(2023, 4, 24, 13, 58, 26, 606, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatum optio quam dignissimos rerum aut maiores quibusdam quos aut.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(6890), "Omnis quo atque maxime et magnam.", "https://picsum.photos/640/480/?image=862", "Miss Brendan Corkery", 1, 1.0, 182, new DateTime(2022, 7, 31, 0, 31, 12, 760, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Excepturi praesentium placeat ut.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(6980), "Porro voluptatem aut possimus voluptate et sed pariatur quia officia.", "https://picsum.photos/640/480/?image=487", "Willis Cassin II", 850, new DateTime(2022, 5, 17, 1, 6, 57, 627, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Explicabo tempora sed.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7060), "Culpa sed vel repellendus officiis et accusantium qui id.", "https://picsum.photos/640/480/?image=847", "Terrence Rutherford IV", 6, 4.0, 347, new DateTime(2022, 11, 20, 20, 52, 31, 443, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quae omnis autem perspiciatis soluta autem voluptatem saepe fugit.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7140), "Nemo eos unde tempora minus.", "https://picsum.photos/640/480/?image=456", "Edward Legros Jr.", 2, 2.0, 591, new DateTime(2023, 3, 9, 9, 28, 43, 45, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sint molestiae et veritatis quisquam accusamus.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7220), "Et voluptas vitae itaque et facilis aliquam minima doloremque doloribus.", "https://picsum.photos/640/480/?image=50", "Mrs. Beulah Nolan", 3, 5.0, 590, new DateTime(2023, 2, 6, 11, 26, 9, 716, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Neque debitis officia nulla voluptate vero nihil corporis eos.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7300), "Modi ea est accusantium consectetur harum eveniet et ipsam.", "https://picsum.photos/640/480/?image=920", "Doug Wyman V", 9, 4.0, 791, new DateTime(2023, 3, 20, 8, 30, 54, 21, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Optio impedit beatae.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7370), "Iure nostrum sint hic et repellat distinctio id eaque.", "https://picsum.photos/640/480/?image=1029", "Bruce Beahan V", 9, 4.0, 882, new DateTime(2023, 2, 20, 14, 43, 31, 402, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et quae optio adipisci modi voluptatem placeat.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7460), "Saepe quis eos et accusamus sapiente velit voluptate.", "https://picsum.photos/640/480/?image=925", "Ms. Manuel Armstrong", 1, 886, new DateTime(2023, 1, 16, 17, 12, 41, 587, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Saepe quos aut voluptate in blanditiis et ut.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7530), "Ut dicta facilis.", "https://picsum.photos/640/480/?image=430", "Dr. Louis Cummings", 7, 1.0, 384, new DateTime(2023, 4, 11, 11, 6, 40, 788, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestiae illum ab possimus officiis atque porro ducimus voluptatum.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7610), "Sed a ea excepturi omnis ipsam voluptatem eum.", "https://picsum.photos/640/480/?image=796", "Mrs. Roosevelt Botsford", 10, 504, new DateTime(2022, 7, 21, 9, 57, 57, 190, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Occaecati est dolorem soluta nam maiores eligendi natus quia id.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7700), "Sit repudiandae esse qui magnam possimus quia iusto ipsa.", "https://picsum.photos/640/480/?image=1063", "Sherry Hagenes II", 7, 2.0, 321, new DateTime(2022, 6, 23, 12, 2, 2, 374, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laboriosam recusandae cumque sit vel eum non quis provident.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7770), "Fugiat nobis facere dolores autem.", "https://picsum.photos/640/480/?image=872", "Cary Shanahan DVM", 2, 1.0, 471, new DateTime(2023, 5, 3, 13, 10, 12, 182, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempora est itaque tenetur id sed id autem fuga.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7830), "Qui quia dolores.", "https://picsum.photos/640/480/?image=340", "Georgia Klein I", 7, 3.0, 471, new DateTime(2022, 7, 29, 15, 2, 20, 552, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Pariatur dolorum qui quis porro.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7920), "Veniam nisi numquam praesentium necessitatibus rerum consequatur.", "https://picsum.photos/640/480/?image=874", "Mr. Vernon Hilll", 177, new DateTime(2022, 8, 10, 0, 1, 23, 854, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Porro quis quia et mollitia velit quia ullam sint.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8000), "Eveniet molestias quas ea sapiente et deserunt ex.", "https://picsum.photos/640/480/?image=830", "Ms. Francis Goodwin", 3, 2.0, 573, new DateTime(2022, 9, 10, 15, 12, 17, 620, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nam quasi minima natus quaerat quam.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8070), "Qui maxime id occaecati perferendis deleniti fugit et ut.", "https://picsum.photos/640/480/?image=392", "Alice Reinger II", 8, 4.0, 120, new DateTime(2022, 5, 18, 20, 25, 14, 345, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Adipisci fugiat a aliquid laudantium expedita ipsam quisquam.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8130), "Tenetur ea distinctio.", "https://picsum.photos/640/480/?image=556", "Mr. Susan Fisher", 4.0, 516, new DateTime(2022, 8, 8, 12, 59, 26, 855, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut inventore iure in.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8180), "Quis laudantium cumque.", "https://picsum.photos/640/480/?image=857", "Emily Kertzmann MD", 9, 4.0, 997, new DateTime(2022, 6, 8, 14, 30, 38, 608, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et vel repellat velit.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8240), "Accusantium et optio accusantium magni.", "https://picsum.photos/640/480/?image=790", "Lucia Reichert PhD", 9, 878, new DateTime(2023, 3, 25, 16, 29, 52, 832, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Autem suscipit repellat autem expedita quo sit asperiores quos porro.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8310), "Et in quod voluptas nesciunt.", "https://picsum.photos/640/480/?image=232", "Irving Champlin Sr.", 7, 70, new DateTime(2022, 10, 8, 0, 1, 7, 838, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Corporis placeat ducimus et commodi eligendi.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8390), "Suscipit veniam magni amet et explicabo quia sunt.", "https://picsum.photos/640/480/?image=218", "Mr. Doug Mann", 8, 2.0, 462, new DateTime(2022, 6, 27, 21, 50, 53, 833, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Modi illo dolor voluptatem velit in.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8450), "Sit praesentium dolorem.", "https://picsum.photos/640/480/?image=501", "Jose Steuber MD", 2, 3.0, 613, new DateTime(2022, 7, 24, 0, 9, 7, 79, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cupiditate architecto enim tenetur voluptas quae dolor rerum.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8520), "Et molestias dignissimos quia dolorum ut quia culpa.", "https://picsum.photos/640/480/?image=799", "Mae Rath III", 10, 3.0, 940, new DateTime(2022, 10, 24, 9, 5, 47, 64, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Autem qui qui dicta aliquam libero.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8590), "Eveniet a et voluptatum asperiores iusto modi.", "https://picsum.photos/640/480/?image=931", "Miss Mindy Sanford", 9, 5.0, 141, new DateTime(2022, 11, 4, 17, 57, 4, 841, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Velit mollitia eligendi.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8650), "Dolorem velit eum laudantium repellendus quia dolorem sunt.", "https://picsum.photos/640/480/?image=579", "Miss Angel Effertz", 10, 5.0, 215, new DateTime(2022, 7, 25, 0, 55, 32, 57, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellendus sint vel excepturi similique nihil id ut iste eum.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8720), "In qui nihil eum accusamus animi et facere.", "https://picsum.photos/640/480/?image=582", "Mrs. Inez Rosenbaum", 10, 265, new DateTime(2022, 8, 30, 15, 58, 8, 92, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quaerat iste aspernatur eos deserunt officiis nemo.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8810), "Quaerat id earum quibusdam voluptatum aliquam.", "https://picsum.photos/640/480/?image=443", "Mr. Iris Walker", 8, 2.0, 820, new DateTime(2022, 7, 16, 16, 33, 3, 432, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nesciunt veniam qui perspiciatis et sint voluptate sequi.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8880), "Minus atque doloremque occaecati provident nemo velit voluptate.", "https://picsum.photos/640/480/?image=631", "Miss Diane Dietrich", 4, 453, new DateTime(2022, 6, 21, 1, 34, 20, 833, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur reprehenderit dolor.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8940), "Quia debitis harum earum reprehenderit delectus accusantium quod.", "https://picsum.photos/640/480/?image=1070", "Dr. Christian Stokes", 8, 1.0, 771, new DateTime(2023, 2, 28, 9, 40, 22, 773, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Similique recusandae reiciendis neque aperiam aut ut voluptas.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9010), "Et velit nemo autem consequatur incidunt hic veritatis.", "https://picsum.photos/640/480/?image=285", "Dr. William Osinski", 8, 5.0, 870, new DateTime(2022, 8, 26, 1, 15, 9, 368, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptate fugit provident neque maiores porro aut a.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9080), "Maiores ut consectetur sint minima officiis qui eius.", "https://picsum.photos/640/480/?image=561", "Diane Sanford DDS", 6, 5.0, 269, new DateTime(2023, 1, 13, 22, 59, 4, 37, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quae dicta ipsam eum reiciendis corrupti molestiae quos.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9150), "Impedit est perspiciatis id eum perspiciatis odit nihil voluptatem reiciendis.", "https://picsum.photos/640/480/?image=543", "Bridget Raynor IV", 10, 1.0, 585, new DateTime(2022, 6, 17, 11, 58, 3, 774, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iste occaecati eum alias quia omnis eaque tempore.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9240), "Deleniti voluptatem alias reprehenderit.", "https://picsum.photos/640/480/?image=827", "Andres Muller Jr.", 2.0, 453, new DateTime(2022, 8, 14, 6, 50, 39, 730, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis ducimus placeat modi voluptatibus assumenda quibusdam cupiditate ut consequatur.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9320), "Consequuntur ratione quibusdam officiis fuga quia qui perferendis eos fugiat.", "https://picsum.photos/640/480/?image=715", "Rodney Reichel Jr.", 3, 5.0, 781, new DateTime(2022, 5, 25, 3, 8, 2, 766, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolorum at eligendi quia.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9380), "Consequatur ratione a aspernatur minima et blanditiis sit.", "https://picsum.photos/640/480/?image=932", "Mr. Bill Ortiz", 6, 282, new DateTime(2023, 3, 10, 15, 17, 10, 742, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Odio modi odio rerum voluptas suscipit earum voluptatem.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9440), "Voluptas vel numquam voluptatem qui eum alias.", "https://picsum.photos/640/480/?image=299", "Arlene Steuber I", 10, 3.0, 990, new DateTime(2023, 3, 3, 22, 50, 17, 375, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Adipisci adipisci voluptatem deleniti saepe nemo itaque animi assumenda.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9520), "Perferendis assumenda illo fuga modi ut necessitatibus facere.", "https://picsum.photos/640/480/?image=978", "Dr. Andrea Pfannerstill", 6, 3.0, 662, new DateTime(2023, 4, 26, 20, 20, 2, 662, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Non dolorem at odio.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9580), "Ea maiores quod architecto ad aut quo accusamus.", "https://picsum.photos/640/480/?image=303", "Shelley Cormier Sr.", 844, new DateTime(2022, 10, 5, 2, 52, 22, 181, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut omnis non iste sed aut quia dolores.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9630), "Eius omnis nostrum.", "https://picsum.photos/640/480/?image=373", "Dr. Peggy Hudson", 6, 5.0, 97, new DateTime(2023, 3, 8, 1, 35, 19, 567, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Saepe quibusdam minima non.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9680), "Excepturi recusandae itaque.", "https://picsum.photos/640/480/?image=958", "Tami Ferry MD", 10, 3.0, 960, new DateTime(2022, 11, 23, 19, 5, 3, 709, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Architecto omnis nulla dolorem quia sit aut error.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9810), "Omnis aut cupiditate deleniti.", "https://picsum.photos/640/480/?image=259", "Miss Spencer Okuneva", 10, 2.0, 422, new DateTime(2023, 3, 7, 23, 22, 5, 311, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laudantium aperiam nobis vitae deleniti autem eaque quaerat.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9890), "Velit excepturi ut reprehenderit voluptatem eos quidem voluptatem atque aut.", "https://picsum.photos/640/480/?image=244", "Courtney Torp I", 3, 5.0, 198, new DateTime(2022, 11, 1, 14, 48, 57, 425, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellat officia libero sit nulla sapiente et quidem et.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9960), "Temporibus nihil voluptatem perspiciatis assumenda in velit animi.", "https://picsum.photos/640/480/?image=324", "Emily Feil IV", 7, 4.0, 90, new DateTime(2022, 12, 1, 0, 36, 6, 617, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Expedita reiciendis nihil eveniet repellat.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(20), "Eos rerum molestiae eum dolorem.", "https://picsum.photos/640/480/?image=838", "Josephine Kuphal Sr.", 9, 5.0, 643, new DateTime(2023, 2, 6, 7, 50, 0, 957, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Id tempore veritatis est blanditiis soluta deserunt id temporibus dolorem.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(80), "Delectus porro iusto odit aut.", "https://picsum.photos/640/480/?image=879", "Delores Mitchell PhD", 5, 2.0, 928, new DateTime(2022, 11, 1, 1, 28, 29, 318, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Beatae deleniti nobis suscipit assumenda esse rem eum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(170), "Dolores quo quasi sunt ut distinctio eum.", "https://picsum.photos/640/480/?image=71", "Ms. Yvette Rutherford", 6, 2.0, 828, new DateTime(2022, 9, 3, 11, 6, 7, 517, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nulla officiis tenetur natus qui numquam aspernatur non.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(240), "Ea aspernatur minima sunt eos quod voluptatem.", "https://picsum.photos/640/480/?image=987", "Ms. Vanessa Heidenreich", 6, 3.0, 940, new DateTime(2022, 8, 13, 2, 19, 37, 812, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dicta exercitationem et et aut voluptatem sapiente veritatis.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(300), "Autem rerum labore repellendus.", "https://picsum.photos/640/480/?image=806", "Danny Cormier V", 2, 4.0, 619, new DateTime(2022, 8, 13, 6, 5, 33, 0, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "A accusamus dolorem rerum voluptatem qui voluptates voluptas atque consequatur.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(380), "Aut deleniti consequatur adipisci consequatur laudantium omnis nulla ex aspernatur.", "https://picsum.photos/640/480/?image=260", "Patsy Reichert V", 5, 1.0, 498, new DateTime(2022, 6, 7, 19, 14, 48, 944, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quos nihil maxime.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(430), "Corporis in quos.", "https://picsum.photos/640/480/?image=175", "Dr. Theodore Littel", 6, 1.0, 770, new DateTime(2022, 7, 11, 7, 10, 46, 580, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "In placeat et ea molestias tenetur quo.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(490), "Amet ut architecto et.", "https://picsum.photos/640/480/?image=538", "Ms. Rita Dickens", 5, 4.0, 456, new DateTime(2023, 3, 24, 9, 13, 46, 686, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repudiandae fugit vitae iusto porro.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(540), "Quidem sint corrupti ut quasi.", "https://picsum.photos/640/480/?image=499", "Dr. Doris Sawayn", 5.0, 558, new DateTime(2023, 5, 5, 13, 38, 39, 341, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ullam veniam debitis.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(620), "Facere vel qui pariatur nulla et eius ut nam qui.", "https://picsum.photos/640/480/?image=457", "Mr. Rosalie Altenwerth", 9, 3.0, 448, new DateTime(2022, 6, 25, 11, 2, 46, 568, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Illum et repudiandae fugiat.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(680), "Et sit illum corporis magni.", "https://picsum.photos/640/480/?image=66", "Mr. Dominic Borer", 1, 4.0, 361, new DateTime(2023, 1, 16, 8, 37, 7, 751, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Culpa illo quaerat voluptatibus reprehenderit iusto.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(740), "Accusamus et sed dolor sapiente qui.", "https://picsum.photos/640/480/?image=643", "Cedric Sauer V", 1, 5.0, 698, new DateTime(2022, 9, 6, 6, 58, 29, 309, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Veritatis impedit voluptates facilis sapiente repudiandae laudantium fugit rerum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(800), "Inventore ab sed aut commodi.", "https://picsum.photos/640/480/?image=69", "Mrs. James Howell", 1, 5.0, 908, new DateTime(2023, 1, 21, 15, 42, 6, 394, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatum aut neque pariatur sint veniam maiores eum consequuntur.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(870), "Accusantium nemo saepe rerum dolor vel.", "https://picsum.photos/640/480/?image=754", "Myron Stehr DDS", 7, 5.0, 803, new DateTime(2023, 3, 3, 15, 49, 0, 439, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Harum consequatur ab dolorem eos est qui vero voluptatibus assumenda.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(940), "Eaque facere est aliquid repellat ut vero at.", "https://picsum.photos/640/480/?image=308", "Johanna Carroll V", 8, 602, new DateTime(2023, 3, 19, 23, 35, 17, 5, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Expedita rerum occaecati ducimus odit.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1020), "Distinctio autem ea perferendis ducimus dolorem.", "https://picsum.photos/640/480/?image=439", "Corey Raynor DVM", 9, 3.0, 337, new DateTime(2022, 5, 18, 0, 20, 7, 710, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit possimus aut quia voluptas itaque esse.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1090), "Ea nobis unde voluptatem repellendus esse molestias.", "https://picsum.photos/640/480/?image=524", "Ms. Carolyn Lang", 7, 4.0, 587, new DateTime(2023, 2, 17, 22, 34, 52, 82, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Non aspernatur et sequi a non laudantium voluptatem rerum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1150), "Et unde reiciendis ipsam.", "https://picsum.photos/640/480/?image=1009", "Ms. Daryl Huels", 7, 1.0, 956, new DateTime(2023, 3, 6, 20, 31, 0, 872, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas saepe veritatis nam dolorem soluta quo atque laborum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1210), "Rerum nemo et suscipit.", "https://picsum.photos/640/480/?image=998", "Marco Kuphal Sr.", 10, 2.0, 41, new DateTime(2022, 5, 26, 21, 44, 19, 803, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Possimus iste qui sit consequatur ducimus consequuntur facere maiores.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1280), "Consequatur sit maxime deleniti adipisci porro.", "https://picsum.photos/640/480/?image=1080", "Miss Marian Mante", 4, 2.0, 965, new DateTime(2023, 4, 16, 23, 4, 5, 339, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Fuga ab et qui aut soluta nesciunt asperiores.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1350), "Molestiae temporibus non sed quibusdam omnis dolorem quia porro quia.", "https://picsum.photos/640/480/?image=531", "Helen Schamberger I", 1.0, 379, new DateTime(2022, 7, 11, 14, 37, 39, 669, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ea blanditiis fugiat dignissimos quia.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1430), "Alias ut quaerat ea nesciunt debitis repudiandae.", "https://picsum.photos/640/480/?image=11", "Winston Stracke V", 6, 1.0, 920, new DateTime(2022, 7, 8, 9, 27, 48, 106, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis aut dolores rerum autem cumque reiciendis voluptatem.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1490), "Sint voluptas quo cumque debitis.", "https://picsum.photos/640/480/?image=481", "Ms. Desiree Bruen", 274, new DateTime(2022, 11, 5, 15, 42, 58, 545, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolores molestiae fugiat aperiam corrupti dolor vero consequatur.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1550), "Id officia sint est dicta eaque.", "https://picsum.photos/640/480/?image=389", "Miss Rochelle Krajcik", 3, 1.0, 767, new DateTime(2022, 5, 12, 22, 54, 50, 431, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Magnam labore sed earum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1610), "Aut officia omnis velit.", "https://picsum.photos/640/480/?image=927", "Ms. Christine Donnelly", 4, 2.0, 352, new DateTime(2022, 6, 1, 5, 22, 4, 774, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eius quos ut commodi vel et quia velit ab.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1680), "Quis eaque praesentium ut earum alias quia.", "https://picsum.photos/640/480/?image=652", "Ms. Edith Schoen", 10, 4.0, 817, new DateTime(2023, 3, 27, 1, 33, 52, 50, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quisquam quia alias temporibus dicta non deserunt dolores ipsam.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1750), "Molestias quasi voluptatem eos natus ratione vel non deserunt.", "https://picsum.photos/640/480/?image=664", "Ms. Crystal Schimmel", 3.0, 25, new DateTime(2022, 12, 2, 13, 23, 19, 973, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Labore exercitationem non illum mollitia et perferendis ut in labore.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1840), "Magnam perferendis mollitia ad aut eum dolor.", "https://picsum.photos/640/480/?image=53", "Miss Lewis O'Reilly", 10, 3.0, 880, new DateTime(2023, 1, 31, 15, 32, 12, 384, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Asperiores id voluptates.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1890), "Eum mollitia eligendi qui.", "https://picsum.photos/640/480/?image=265", "Mrs. Emanuel White", 4, 2.0, 504, new DateTime(2022, 9, 30, 18, 31, 6, 336, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia dolorum et quas sint repellendus minima earum possimus distinctio.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1960), "Illum alias dolor et iusto beatae aut.", "https://picsum.photos/640/480/?image=1084", "Dianna Doyle III", 4, 2.0, 554, new DateTime(2023, 3, 5, 13, 24, 17, 513, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ea at est voluptatem beatae ipsum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2030), "Dicta omnis ducimus nisi autem praesentium ratione non.", "https://picsum.photos/640/480/?image=660", "Miss Jasmine Abbott", 4, 5.0, 900, new DateTime(2023, 2, 13, 4, 57, 8, 281, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Corrupti inventore id voluptas et labore itaque.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2090), "Provident ipsum vero quia animi perspiciatis fugiat.", "https://picsum.photos/640/480/?image=17", "Dr. Crystal Bayer", 9, 2.0, 411, new DateTime(2022, 7, 25, 16, 58, 38, 99, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ab debitis sed assumenda labore et.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2160), "Sint consectetur ipsa praesentium quam facere porro atque reprehenderit sint.", "https://picsum.photos/640/480/?image=191", "Miss Felipe Ziemann", 1, 4.0, 162, new DateTime(2022, 7, 10, 17, 51, 16, 971, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolores sed qui quibusdam voluptate minima optio molestiae.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2240), "Alias repudiandae doloribus voluptatum.", "https://picsum.photos/640/480/?image=96", "Mrs. Steven Legros", 2, 3.0, 777, new DateTime(2022, 10, 14, 4, 34, 12, 624, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Deleniti dicta qui est explicabo.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2300), "Ipsum unde aut necessitatibus molestias aut ratione.", "https://picsum.photos/640/480/?image=1016", "Mr. Tommy Nienow", 3, 621, new DateTime(2022, 11, 11, 21, 21, 5, 528, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Facilis tempore natus et exercitationem ducimus.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2360), "Laborum autem non consequatur.", "https://picsum.photos/640/480/?image=500", "Willard Crona II", 2, 5.0, 612, new DateTime(2022, 10, 12, 15, 51, 7, 369, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est amet deleniti eos laborum qui ex ut.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2420), "Ad ut fugit pariatur.", "https://picsum.photos/640/480/?image=909", "Willie Monahan DDS", 9, 163, new DateTime(2022, 9, 17, 16, 54, 17, 274, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut eligendi ex illo est.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2490), "Illum nisi id nihil rerum vitae exercitationem velit recusandae consequatur.", "https://picsum.photos/640/480/?image=36", "Alexandra Ryan V", 4, 3.0, 397, new DateTime(2023, 4, 3, 16, 18, 16, 284, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum animi perferendis quia et numquam nostrum ea velit officia.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2560), "Modi alias harum quo facere illo sint porro.", "https://picsum.photos/640/480/?image=285", "Dr. Delbert Bogan", 1.0, 76, new DateTime(2022, 5, 23, 0, 13, 8, 439, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Natus est rerum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2620), "Reprehenderit est est.", "https://picsum.photos/640/480/?image=116", "Mr. Gerald Gleason", 2, 5.0, 334, new DateTime(2022, 5, 20, 11, 52, 7, 672, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nihil consequatur excepturi.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2680), "Tenetur occaecati voluptas voluptatem.", "https://picsum.photos/640/480/?image=22", "Marianne Metz V", 4, 5.0, 410, new DateTime(2022, 9, 25, 1, 10, 13, 308, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rem voluptatibus nesciunt.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2730), "Dolores saepe perferendis et numquam et.", "https://picsum.photos/640/480/?image=412", "Ken Morissette DVM", 6, 817, new DateTime(2022, 12, 13, 4, 9, 57, 102, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Fugiat rerum excepturi qui aut impedit aut maxime dolor.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3150), "Provident aut necessitatibus et saepe non commodi odio unde minima.", "https://picsum.photos/640/480/?image=323", "Lisa Kuhlman MD", 1, 2.0, 886, new DateTime(2022, 7, 27, 21, 53, 21, 523, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum quas consequuntur tempore minus.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3210), "Odit optio pariatur molestiae atque.", "https://picsum.photos/640/480/?image=647", "Geoffrey Bosco II", 1, 5.0, 197, new DateTime(2023, 1, 16, 14, 22, 34, 330, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut itaque et quaerat et totam sint cum et.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3270), "Fugit sit deserunt.", "https://picsum.photos/640/480/?image=969", "Dr. Wendy Terry", 4, 169, new DateTime(2022, 12, 4, 5, 24, 22, 351, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quo maxime qui rem animi et repellat rem ut.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3340), "Doloremque harum sunt dolor sint aut magni et.", "https://picsum.photos/640/480/?image=586", "Amos Yost III", 9, 4.0, 337, new DateTime(2023, 1, 31, 5, 25, 22, 943, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laborum repudiandae eos enim magni placeat est eum quia quam.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3440), "Et voluptas sapiente cupiditate dolore est dicta eligendi in.", "https://picsum.photos/640/480/?image=599", "Ms. Margie Schroeder", 8, 1.0, 208, new DateTime(2022, 8, 23, 18, 59, 22, 683, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Debitis accusantium assumenda sit veniam voluptatem aut ut doloremque quod.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3520), "Pariatur culpa dolorem ipsum non nihil doloribus dolorem maxime sunt.", "https://picsum.photos/640/480/?image=9", "Roberta Zulauf MD", 2, 1.0, 831, new DateTime(2023, 3, 26, 21, 51, 24, 667, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellendus officia repellat sit quo voluptates deleniti ipsam iure.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3580), "Enim sint minus in corporis.", "https://picsum.photos/640/480/?image=945", "Emily Satterfield DVM", 1, 3.0, 46, new DateTime(2023, 5, 5, 17, 57, 18, 828, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quibusdam placeat fugiat fugiat.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3640), "Qui ut repellendus modi ad possimus.", "https://picsum.photos/640/480/?image=1028", "Miss Sherman Luettgen", 3, 2.0, 46, new DateTime(2023, 1, 8, 15, 53, 36, 117, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Labore quaerat omnis assumenda.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3690), "Eum ut ea dolores repudiandae.", "https://picsum.photos/640/480/?image=414", "Marcella West DVM", 10, 3.0, 539, new DateTime(2022, 11, 30, 12, 21, 48, 889, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laboriosam omnis a ut enim omnis.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3750), "Distinctio dolorem sapiente maxime ipsum asperiores.", "https://picsum.photos/640/480/?image=97", "Lowell Stamm III", 2, 1.0, 419, new DateTime(2022, 12, 28, 21, 23, 23, 385, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "A et a omnis explicabo magni corporis et dicta maxime.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3840), "Qui debitis nulla animi doloribus asperiores aut.", "https://picsum.photos/640/480/?image=600", "Margie Runolfsdottir I", 1, 889, new DateTime(2022, 8, 19, 23, 47, 39, 267, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Accusantium sit accusamus voluptatem hic dolor quis.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3900), "Est architecto consequatur tempore eveniet voluptatem non.", "https://picsum.photos/640/480/?image=584", "Beth Bernhard V", 6, 613, new DateTime(2022, 12, 22, 18, 33, 30, 801, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Magnam cupiditate labore.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3950), "Illo ea fugit aut.", "https://picsum.photos/640/480/?image=748", "Nick Hane III", 10, 690, new DateTime(2023, 3, 12, 3, 22, 2, 308, DateTimeKind.Local).AddTicks(7034) });
        }
    }
}
