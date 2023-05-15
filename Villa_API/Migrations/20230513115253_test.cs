using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa_API.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et dignissimos dicta.", new DateTime(2023, 5, 13, 14, 54, 55, 505, DateTimeKind.Local).AddTicks(9857), "Quae et dolorum nobis fuga quia veniam.\nConsectetur in sint dolore dolorum iste.", "https://picsum.photos/640/480/?image=540", "Susan Cartwright DVM", 4.0, 2387, new DateTime(2022, 12, 16, 21, 7, 1, 689, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut non corporis.", new DateTime(2023, 5, 13, 15, 32, 45, 524, DateTimeKind.Local).AddTicks(896), "Veritatis doloremque aut hic repellendus fugiat amet.\nDolor odit eligendi eos.\nQui dolore quidem vel qui ut vel sed nulla.", "https://picsum.photos/640/480/?image=394", "Ray Bruen DDS", 1490, new DateTime(2022, 8, 21, 22, 14, 38, 983, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aliquid odit nesciunt adipisci vel.", new DateTime(2023, 5, 13, 14, 9, 32, 872, DateTimeKind.Local).AddTicks(8148), "Itaque qui doloremque quia qui id.\nReprehenderit sit aliquid dolorum ex velit placeat.\nSint sed consequatur aspernatur aut aut vero sapiente.", "https://picsum.photos/640/480/?image=78", "Mr. Hope Volkman", 8, 5.0, 1519, new DateTime(2022, 10, 10, 7, 31, 44, 287, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Distinctio aliquid cupiditate sed.", new DateTime(2023, 5, 13, 17, 4, 52, 388, DateTimeKind.Local).AddTicks(2941), "Quaerat officia facere alias.\nAnimi doloribus laborum ea tempora similique aspernatur sunt eaque.", "https://picsum.photos/640/480/?image=1", "Ms. Renee Spinka", 3, 2328, new DateTime(2022, 6, 10, 16, 11, 0, 414, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum eos incidunt voluptate.", new DateTime(2023, 5, 12, 22, 29, 57, 746, DateTimeKind.Local).AddTicks(4371), "Consequuntur quia quaerat necessitatibus itaque corrupti aperiam ut.\nSed et reiciendis vitae dolore saepe.\nQuasi earum aliquam quae dolore iusto rerum blanditiis in.\nVitae eum consectetur excepturi animi.\nUnde est et dolore inventore ut dolore.", "https://picsum.photos/640/480/?image=423", "Ms. Ross Hahn", 3, 889, new DateTime(2023, 3, 13, 12, 5, 45, 574, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur illum assumenda earum ad.", new DateTime(2023, 5, 13, 6, 37, 34, 985, DateTimeKind.Local).AddTicks(3280), "Quasi laboriosam facilis vitae molestiae blanditiis harum nesciunt rem.\nQuaerat laudantium qui qui laboriosam beatae.\nEveniet perspiciatis sit autem itaque nihil natus est sed voluptatum.", "https://picsum.photos/640/480/?image=409", "Dr. Denise Ritchie", 908, new DateTime(2022, 7, 23, 14, 48, 41, 557, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quo totam aperiam et fugiat odit non repellat.", new DateTime(2023, 5, 12, 19, 57, 57, 280, DateTimeKind.Local).AddTicks(3165), "Molestias qui enim velit voluptatibus minima expedita.", "https://picsum.photos/640/480/?image=1020", "Miss Carolyn Ryan", 3, 2.0, 1933, new DateTime(2023, 1, 12, 14, 33, 21, 731, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Exercitationem sit ipsum veritatis alias perferendis ipsum.", new DateTime(2023, 5, 13, 13, 4, 27, 155, DateTimeKind.Local).AddTicks(8198), "Nisi ut deserunt et libero id quam qui.\nMolestiae et sed nam enim maxime veritatis.\nQuaerat dolorem rerum eum aliquam eaque vitae et autem.", "https://picsum.photos/640/480/?image=114", "Bennie Ernser Jr.", 4, 1841, new DateTime(2022, 12, 14, 18, 42, 1, 643, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Assumenda et enim assumenda ab corrupti neque iure.", new DateTime(2023, 5, 13, 4, 45, 20, 874, DateTimeKind.Local).AddTicks(1218), "Illum ratione nisi eligendi labore illo voluptate ut dolore dolorum.", "https://picsum.photos/640/480/?image=261", "Mr. Yvette Walsh", 4, 3.0, 2411, new DateTime(2022, 12, 23, 22, 26, 56, 239, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut tempore corporis voluptatum nostrum rem doloremque odit quia.", new DateTime(2023, 5, 13, 1, 40, 48, 493, DateTimeKind.Local).AddTicks(7321), "Ea eos et sit impedit.", "https://picsum.photos/640/480/?image=895", "Mr. Lloyd Greenholt", 7, 1.0, 2084, new DateTime(2023, 4, 10, 2, 18, 44, 192, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sequi omnis quam est quod numquam doloribus voluptas.", new DateTime(2023, 5, 13, 11, 56, 49, 222, DateTimeKind.Local).AddTicks(4548), "Veniam non fugit quaerat.", "https://picsum.photos/640/480/?image=595", "Matthew MacGyver Jr.", 4.0, 1084, new DateTime(2022, 11, 14, 2, 42, 29, 237, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Hic earum et aut.", new DateTime(2023, 5, 13, 2, 54, 32, 375, DateTimeKind.Local).AddTicks(1942), "Non aut et ullam qui.", "https://picsum.photos/640/480/?image=38", "Mr. Emmett Kessler", 7, 5.0, 1337, new DateTime(2022, 5, 19, 4, 45, 30, 268, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quisquam doloremque suscipit consequatur non quo provident.", new DateTime(2023, 5, 13, 8, 33, 46, 629, DateTimeKind.Local).AddTicks(7943), "Sed ipsam occaecati id.\nDucimus voluptatem sint laudantium voluptatem facere occaecati quae.\nRepellat quia rerum nulla est.\nDebitis in vitae veritatis rerum consequatur dolor.\nDolorum voluptatem ipsum sapiente cumque non est aliquam.", "https://picsum.photos/640/480/?image=729", "Marion Kautzer Sr.", 4.0, 985, new DateTime(2022, 12, 30, 12, 48, 20, 817, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit veniam beatae sit provident autem repellat deserunt ut.", new DateTime(2023, 5, 12, 18, 30, 15, 787, DateTimeKind.Local).AddTicks(4825), "Id qui ullam non odit.", "https://picsum.photos/640/480/?image=393", "Kirk Balistreri Sr.", 4, 5.0, 2091, new DateTime(2023, 3, 20, 4, 35, 55, 300, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Error excepturi eveniet optio error quia libero dolores.", new DateTime(2023, 5, 13, 13, 51, 14, 273, DateTimeKind.Local).AddTicks(9071), "A vero possimus consequuntur excepturi doloremque vel excepturi et.\nAccusamus molestiae autem fugit rem minus tempora vel sapiente amet.\nAccusamus quia quam.", "https://picsum.photos/640/480/?image=699", "Cassandra Bode III", 5, 1.0, 1285, new DateTime(2022, 10, 31, 9, 51, 18, 740, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Animi possimus voluptatem distinctio.", new DateTime(2023, 5, 13, 10, 33, 26, 201, DateTimeKind.Local).AddTicks(7949), "Eius veniam tenetur.\nIpsum alias expedita sint est iusto molestiae porro aliquid sint.\nEst recusandae et doloremque consequatur.\nEos non qui vitae sed eos ipsum veritatis molestiae.", "https://picsum.photos/640/480/?image=1010", "Mable Brekke IV", 2, 4.0, 728, new DateTime(2022, 10, 29, 5, 47, 45, 754, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Autem perferendis quod quis sapiente error qui quia ratione.", new DateTime(2023, 5, 13, 16, 59, 54, 86, DateTimeKind.Local).AddTicks(5913), "Molestiae dolores et magni debitis dicta qui.\nEnim iusto sequi quia nisi et deserunt consequatur delectus dicta.\nRatione sit et non.\nEa placeat aut qui ducimus.", "https://picsum.photos/640/480/?image=507", "Mr. Latoya Ondricka", 4, 1.0, 1161, new DateTime(2022, 9, 25, 0, 37, 48, 51, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "In enim doloremque inventore qui deleniti dignissimos aspernatur vel voluptatem.", new DateTime(2023, 5, 12, 20, 36, 51, 682, DateTimeKind.Local).AddTicks(7949), "Explicabo voluptate tempore rerum ea.\nAccusantium voluptatem qui in ea cupiditate perferendis.\nEst molestiae quam ut tempore sit officia fugiat optio.\nNesciunt esse est unde modi excepturi iure est dolores natus.\nSed est ducimus velit.", "https://picsum.photos/640/480/?image=340", "Henry Schultz DDS", 3, 3.0, 2089, new DateTime(2022, 5, 23, 18, 31, 41, 165, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Neque quasi iste.", new DateTime(2023, 5, 12, 20, 21, 38, 601, DateTimeKind.Local).AddTicks(455), "Ipsam cumque voluptatibus quis dolorem numquam.\nVoluptatem odit molestiae labore nam nulla voluptates.\nEx rem dolore voluptates.\nNemo et sequi error consequuntur eos cumque.\nEst non perspiciatis eveniet facilis voluptas.", "https://picsum.photos/640/480/?image=125", "Dr. Muriel Schimmel", 6, 1.0, 2446, new DateTime(2023, 1, 14, 5, 47, 4, 770, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatibus est esse aut.", new DateTime(2023, 5, 12, 20, 2, 54, 92, DateTimeKind.Local).AddTicks(2474), "A ipsa dolorum a.\nVelit est est.\nImpedit et nam iusto accusamus ut quisquam maxime.", "https://picsum.photos/640/480/?image=259", "Dr. Guadalupe Ziemann", 2, 2.0, 2459, new DateTime(2022, 12, 24, 0, 48, 11, 591, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Soluta sit repellendus perferendis repudiandae voluptatem est repudiandae.", new DateTime(2023, 5, 12, 19, 41, 3, 60, DateTimeKind.Local).AddTicks(1112), "Eos qui impedit et quia amet ut et sit.", "https://picsum.photos/640/480/?image=675", "Gene Wiza I", 7, 3.0, 1935, new DateTime(2023, 2, 16, 17, 24, 45, 276, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut fuga eos rerum eius et blanditiis ut doloremque.", new DateTime(2023, 5, 13, 17, 51, 0, 861, DateTimeKind.Local).AddTicks(295), "Aut et id necessitatibus itaque iusto voluptas.\nNihil vitae est sint nulla incidunt praesentium illum quo.", "https://picsum.photos/640/480/?image=332", "Miss Clifford Haley", 2, 5.0, 2088, new DateTime(2022, 7, 29, 5, 2, 39, 510, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Magni eligendi consectetur occaecati doloremque sunt laudantium.", new DateTime(2023, 5, 13, 5, 36, 4, 129, DateTimeKind.Local).AddTicks(6438), "Minima doloremque voluptates commodi possimus eum iusto aut exercitationem qui.\nRepudiandae vel et.", "https://picsum.photos/640/480/?image=1006", "Miss Jon Mante", 10, 1.0, 2367, new DateTime(2022, 7, 7, 21, 16, 41, 595, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aliquam repellendus eos ad consequatur possimus.", new DateTime(2023, 5, 13, 3, 31, 9, 660, DateTimeKind.Local).AddTicks(5672), "Nemo sapiente doloremque eos animi.\nSunt dolore cupiditate tempora aspernatur veritatis fuga.\nEt deleniti fugit mollitia harum fuga provident quasi laborum qui.\nIusto consequatur quas ut aliquid accusamus dolores dolores quia.\nAlias ipsum cumque ea molestiae nobis numquam.", "https://picsum.photos/640/480/?image=264", "Ms. Kristina Schuppe", 2, 5.0, 2362, new DateTime(2022, 10, 5, 23, 37, 51, 318, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Reiciendis nostrum nulla quia accusantium esse illum harum architecto consequatur.", new DateTime(2023, 5, 13, 5, 14, 28, 227, DateTimeKind.Local).AddTicks(9577), "Qui reprehenderit cum autem.\nRepellendus vel recusandae aut at quis.\nEligendi tempora consequatur in odio enim.\nEt officia pariatur quis.", "https://picsum.photos/640/480/?image=222", "Terence Stiedemann DDS", 7, 4.0, 1039, new DateTime(2022, 12, 22, 8, 24, 58, 871, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed consequuntur accusamus commodi praesentium.", new DateTime(2023, 5, 12, 21, 44, 4, 499, DateTimeKind.Local).AddTicks(6297), "Ea repellendus quod quia expedita doloremque et.\nAd repellat libero et laboriosam odit.\nUt delectus accusamus consectetur alias temporibus voluptate animi.\nAut suscipit dolorem maiores voluptas autem corporis repellat ut neque.", "https://picsum.photos/640/480/?image=511", "Jody Beier PhD", 8, 975, new DateTime(2022, 7, 10, 10, 9, 40, 589, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Soluta qui rerum non quis.", new DateTime(2023, 5, 13, 14, 17, 53, 613, DateTimeKind.Local).AddTicks(8558), "Dignissimos corrupti maiores accusamus ipsam at nobis doloribus in.\nVel modi enim.\nNobis temporibus rem laudantium facere.\nLaboriosam molestias est enim voluptas aut sequi tempore eaque.\nEsse sunt accusantium neque.", "https://picsum.photos/640/480/?image=46", "Anthony Huel DVM", 5, 1.0, 1414, new DateTime(2022, 6, 18, 23, 46, 35, 896, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas ut temporibus quaerat minus beatae.", new DateTime(2023, 5, 13, 6, 27, 49, 733, DateTimeKind.Local).AddTicks(9548), "Laborum adipisci aspernatur commodi consequatur quidem impedit rem assumenda.\nNon laborum qui recusandae distinctio.", "https://picsum.photos/640/480/?image=62", "Dr. Bobby Stroman", 1, 3.0, 1224, new DateTime(2022, 11, 7, 12, 53, 39, 874, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eos qui nihil.", new DateTime(2023, 5, 12, 20, 16, 47, 144, DateTimeKind.Local).AddTicks(9279), "Sed harum sunt earum eos et vel.\nQuia dolorem aliquam enim praesentium molestias culpa repudiandae id sed.\nExplicabo quia debitis.\nIpsa quae exercitationem reiciendis.", "https://picsum.photos/640/480/?image=64", "Jeannie Gorczany II", 2, 5.0, 939, new DateTime(2022, 7, 31, 2, 23, 23, 728, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem sit dolores est repellat perspiciatis in animi soluta dicta.", new DateTime(2023, 5, 13, 3, 30, 41, 602, DateTimeKind.Local).AddTicks(5723), "Qui voluptatem explicabo qui occaecati.\nDolorem et commodi adipisci possimus et est.\nMaiores non explicabo eius dolore autem unde dolores pariatur.\nVelit illum rerum dolorem voluptas eum possimus tempore iure.", "https://picsum.photos/640/480/?image=567", "Mr. Dexter Nader", 7, 4.0, 545, new DateTime(2023, 2, 14, 14, 44, 31, 443, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellendus excepturi sint qui provident quia architecto ipsum dolores tempora.", new DateTime(2023, 5, 13, 2, 32, 30, 462, DateTimeKind.Local).AddTicks(2603), "Temporibus delectus sit impedit repellat.\nVeritatis incidunt non qui aut corporis sed qui et.\nVoluptatibus odio sit sint voluptas reprehenderit sint dignissimos.", "https://picsum.photos/640/480/?image=927", "Ms. Debra Greenfelder", 9, 4.0, 1303, new DateTime(2022, 7, 25, 20, 15, 20, 765, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Enim sint eos.", new DateTime(2023, 5, 13, 13, 19, 54, 610, DateTimeKind.Local).AddTicks(1872), "Enim dolorem sint veniam quisquam.\nAccusamus mollitia voluptas facilis dolore.\nAliquam tempora est deserunt est voluptas magni quidem omnis veritatis.", "https://picsum.photos/640/480/?image=726", "Rickey Torp III", 6, 2.0, 2119, new DateTime(2023, 1, 6, 6, 1, 5, 760, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed asperiores ut reiciendis molestiae et atque itaque.", new DateTime(2023, 5, 13, 17, 32, 56, 740, DateTimeKind.Local).AddTicks(2170), "Facilis laborum odit voluptatem voluptatem quia.\nUt dignissimos impedit.\nTemporibus est reprehenderit minima dolor delectus modi eveniet explicabo commodi.", "https://picsum.photos/640/480/?image=167", "Ms. Domingo Berge", 1, 2.0, 770, new DateTime(2023, 4, 19, 23, 16, 1, 387, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Animi ipsam maiores et.", new DateTime(2023, 5, 12, 23, 46, 21, 599, DateTimeKind.Local).AddTicks(8415), "Totam nisi qui.", "https://picsum.photos/640/480/?image=117", "Miriam Hintz DVM", 1.0, 1686, new DateTime(2023, 1, 12, 8, 7, 47, 587, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sunt libero blanditiis commodi praesentium est fuga.", new DateTime(2023, 5, 12, 20, 44, 11, 559, DateTimeKind.Local).AddTicks(2600), "Officiis quibusdam ratione excepturi qui similique repellat.\nEaque consequatur iste ut sunt ipsa et perferendis quia provident.\nNatus sequi dolorem nemo.\nDignissimos placeat sint ut laboriosam eaque eius eaque sapiente molestiae.", "https://picsum.photos/640/480/?image=40", "Virginia Reilly DDS", 8, 3.0, 1405, new DateTime(2022, 7, 20, 23, 57, 15, 132, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repudiandae qui culpa sit expedita.", new DateTime(2023, 5, 13, 11, 17, 45, 1, DateTimeKind.Local).AddTicks(6562), "Deleniti id fuga et.\nExplicabo vel ut eaque neque sed.\nUt quis ea rerum amet optio sed.\nMinus porro est debitis omnis hic.\nQui quo sit laborum impedit autem voluptatem voluptas aut.", "https://picsum.photos/640/480/?image=891", "Miss Margaret Schumm", 8, 1.0, 1305, new DateTime(2023, 4, 5, 8, 44, 39, 146, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rem in aut delectus similique ratione iste consequatur praesentium omnis.", new DateTime(2023, 5, 12, 21, 55, 52, 263, DateTimeKind.Local).AddTicks(2325), "Quisquam molestiae omnis est necessitatibus natus iste rem nostrum illum.\nEt corporis sunt neque.\nEnim sequi dolorem iusto et et accusamus.\nId aut aut itaque saepe animi.\nVoluptatem tenetur libero nesciunt ut.", "https://picsum.photos/640/480/?image=684", "Delbert Ullrich I", 4, 4.0, 2057, new DateTime(2022, 11, 16, 6, 38, 7, 799, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Id quo voluptatem eligendi fugit.", new DateTime(2023, 5, 13, 12, 48, 2, 563, DateTimeKind.Local).AddTicks(8150), "Sint voluptatem dolore esse incidunt libero.\nFuga hic soluta.\nDebitis vel architecto impedit consequuntur.", "https://picsum.photos/640/480/?image=435", "Miss Colleen Gibson", 10, 1.0, 904, new DateTime(2022, 11, 29, 15, 26, 34, 808, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Commodi distinctio labore repellat nulla.", new DateTime(2023, 5, 13, 5, 8, 58, 916, DateTimeKind.Local).AddTicks(2456), "Sed iure tempore eum nam ea.\nQuo recusandae nihil aliquam temporibus at occaecati.\nRepellendus voluptatum molestiae quia est nobis quis molestiae et.\nExcepturi qui quia recusandae illum facilis.\nTenetur quis adipisci voluptas nihil nobis neque et modi.", "https://picsum.photos/640/480/?image=425", "Joyce Hettinger V", 9, 2.0, 1598, new DateTime(2023, 1, 1, 11, 57, 24, 21, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ad consequatur dolores culpa.", new DateTime(2023, 5, 13, 4, 32, 5, 400, DateTimeKind.Local).AddTicks(4346), "Dolorum quo asperiores.\nEx quia explicabo eius occaecati.", "https://picsum.photos/640/480/?image=93", "Teri Koelpin V", 5, 2.0, 1369, new DateTime(2022, 7, 30, 22, 18, 4, 365, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eaque perferendis qui impedit reprehenderit consectetur.", new DateTime(2023, 5, 12, 22, 40, 44, 420, DateTimeKind.Local).AddTicks(3269), "Molestiae reiciendis est consequatur possimus cum quo.\nVitae ipsam ratione molestiae enim earum.\nOfficia inventore quam praesentium dolor.\nQui temporibus sint porro voluptatem alias repudiandae fugit.", "https://picsum.photos/640/480/?image=432", "Ms. Wanda Runolfsdottir", 9, 5.0, 1254, new DateTime(2022, 6, 27, 6, 24, 45, 744, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aliquam qui possimus est iure optio.", new DateTime(2023, 5, 13, 14, 47, 20, 981, DateTimeKind.Local).AddTicks(4722), "Autem mollitia quod provident et.\nPerspiciatis id vero dolorem.", "https://picsum.photos/640/480/?image=541", "Mrs. Margaret D'Amore", 9, 2.0, 2406, new DateTime(2022, 9, 3, 13, 37, 26, 211, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Placeat id dolorum.", new DateTime(2023, 5, 13, 13, 54, 42, 427, DateTimeKind.Local).AddTicks(3375), "Quam omnis amet ipsam pariatur.\nNon reiciendis harum atque nostrum.\nEligendi repellat sapiente mollitia.\nAperiam nobis ipsam.\nVoluptatem voluptatem voluptatem laborum voluptas hic quod voluptatem laborum.", "https://picsum.photos/640/480/?image=956", "Clifton Balistreri IV", 5.0, 1179, new DateTime(2022, 9, 26, 12, 51, 36, 11, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iste non libero voluptas quia sit praesentium ipsum expedita commodi.", new DateTime(2023, 5, 12, 20, 19, 34, 396, DateTimeKind.Local).AddTicks(1497), "Provident officia aperiam aut beatae et veritatis.\nLabore autem aut veniam.\nExplicabo doloribus impedit sed quis mollitia voluptates vel maiores.\nTenetur illum aut quos a voluptas.\nEt et nostrum rerum.", "https://picsum.photos/640/480/?image=721", "Jessica Brown Jr.", 3, 1.0, 1872, new DateTime(2023, 3, 14, 6, 30, 26, 957, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sunt est asperiores ut minima repellat nulla repudiandae soluta aut.", new DateTime(2023, 5, 13, 11, 41, 16, 778, DateTimeKind.Local).AddTicks(9519), "Aut est quod excepturi.\nAliquam nemo minima qui nihil ab amet voluptate.\nDolore sit illo ipsum fugit odit deserunt necessitatibus.", "https://picsum.photos/640/480/?image=516", "Bobbie Lehner DVM", 7, 1.0, 2065, new DateTime(2022, 9, 13, 8, 53, 49, 297, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum quo laboriosam voluptas.", new DateTime(2023, 5, 13, 9, 10, 2, 882, DateTimeKind.Local).AddTicks(5485), "Quo enim sint maiores doloremque voluptatem pariatur.\nQuibusdam necessitatibus fuga consequuntur quibusdam.\nQuos quam libero deleniti commodi et quo aut.\nPerspiciatis a accusamus occaecati et.\nAliquid voluptatum quo omnis quibusdam nihil repellat.", "https://picsum.photos/640/480/?image=173", "Neil Mohr DDS", 2, 2.0, 1828, new DateTime(2022, 9, 22, 9, 26, 46, 15, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et porro qui aliquam officiis velit.", new DateTime(2023, 5, 13, 2, 11, 5, 706, DateTimeKind.Local).AddTicks(4143), "Nihil porro iusto doloremque.\nQuod enim porro rerum quam distinctio ipsum aut quidem sunt.\nConsequuntur voluptatibus et odit illum ut sed.", "https://picsum.photos/640/480/?image=929", "Alma Wiegand Sr.", 10, 554, new DateTime(2022, 12, 20, 11, 53, 12, 375, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Porro saepe ipsa et quidem rerum rem.", new DateTime(2023, 5, 13, 15, 51, 49, 504, DateTimeKind.Local).AddTicks(5912), "Neque velit libero accusantium atque.\nConsequatur vel cum ut sit blanditiis dolorum et.\nTempore voluptatibus officiis error eos.\nSint facilis consequatur molestiae fuga eum ab.\nSunt ea a eos qui voluptatibus laudantium laboriosam quia et.", "https://picsum.photos/640/480/?image=689", "Dr. Sherri Koepp", 6, 944, new DateTime(2022, 9, 15, 23, 25, 49, 526, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Mollitia aperiam sint.", new DateTime(2023, 5, 13, 15, 4, 53, 387, DateTimeKind.Local).AddTicks(2404), "Quasi et aliquid in cum.\nNon eum sit dolores ipsum ut quasi est.\nOmnis similique qui quia rem et incidunt est.", "https://picsum.photos/640/480/?image=168", "Lisa Lemke PhD", 2, 2.0, 2127, new DateTime(2023, 3, 26, 19, 35, 8, 684, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Velit esse sequi qui veniam rerum est.", new DateTime(2023, 5, 13, 12, 18, 55, 650, DateTimeKind.Local).AddTicks(1952), "Voluptate odit nemo.\nAssumenda velit minima nobis.\nQuo doloribus non eaque quam iste doloribus.\nAccusamus molestiae deserunt.\nNobis vitae deserunt eius amet eum veniam.", "https://picsum.photos/640/480/?image=75", "Joanne O'Keefe Jr.", 10, 5.0, 1823, new DateTime(2022, 7, 24, 7, 16, 25, 77, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ab asperiores eum molestiae et culpa aspernatur atque.", new DateTime(2023, 5, 13, 4, 59, 0, 5, DateTimeKind.Local).AddTicks(4121), "Sequi laudantium ratione id fugiat alias qui sint.\nNam sint et.\nQuas quasi accusantium quidem et quae aut.", "https://picsum.photos/640/480/?image=438", "Darin Treutel III", 3, 4.0, 887, new DateTime(2023, 4, 25, 2, 19, 40, 660, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolores est fugiat veritatis consequuntur laudantium aut quibusdam rerum sint.", new DateTime(2023, 5, 13, 3, 38, 38, 821, DateTimeKind.Local).AddTicks(8628), "Eius sed similique perferendis quos tempore vitae possimus occaecati.\nVoluptatem quisquam culpa.\nEt eaque et enim ad exercitationem dolores.\nQuis voluptatum ipsa non sit dignissimos voluptatibus.", "https://picsum.photos/640/480/?image=816", "Morris Marks DDS", 575, new DateTime(2022, 10, 30, 6, 19, 26, 697, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et expedita impedit sint in est autem animi.", new DateTime(2023, 5, 13, 6, 6, 24, 14, DateTimeKind.Local).AddTicks(62), "Voluptas itaque officia repellendus eum aperiam ipsa voluptates fugiat.", "https://picsum.photos/640/480/?image=6", "Flora Haley II", 9, 4.0, 647, new DateTime(2023, 5, 3, 15, 14, 42, 609, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Natus et voluptas dolores omnis.", new DateTime(2023, 5, 12, 23, 26, 28, 627, DateTimeKind.Local).AddTicks(5616), "Earum tempora repellendus quia eaque sint.\nQui mollitia soluta.\nCorporis illo fugit.\nSit aspernatur at et impedit.", "https://picsum.photos/640/480/?image=370", "Karen Bergnaum Jr.", 9, 1.0, 950, new DateTime(2022, 9, 26, 7, 48, 13, 251, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Labore cum minus dolorum perferendis.", new DateTime(2023, 5, 13, 4, 27, 0, 84, DateTimeKind.Local).AddTicks(7669), "Et optio aut qui possimus.\nQuaerat voluptatem aliquam vel tempora mollitia tempore aut reiciendis.\nNisi fugit incidunt id expedita dignissimos error modi autem et.", "https://picsum.photos/640/480/?image=627", "Miss Lorraine Mosciski", 10, 4.0, 1516, new DateTime(2022, 11, 16, 20, 23, 41, 34, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ea repellat qui velit porro.", new DateTime(2023, 5, 13, 8, 45, 39, 32, DateTimeKind.Local).AddTicks(9333), "Ab excepturi et voluptas ab enim excepturi corporis laborum.", "https://picsum.photos/640/480/?image=709", "Ms. Casey Haag", 2.0, 1891, new DateTime(2022, 9, 28, 3, 18, 9, 839, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quibusdam mollitia nihil ducimus rem voluptates quibusdam odit tenetur et.", new DateTime(2023, 5, 12, 19, 11, 54, 351, DateTimeKind.Local).AddTicks(8815), "Eos et quis et cumque molestiae dolore.\nLibero laborum odit odio sunt atque veniam.\nSunt voluptas ex cupiditate voluptatum aut tempora distinctio voluptates aut.\nQuaerat saepe facilis ipsum omnis dolore.\nMolestiae animi harum libero illum odit.", "https://picsum.photos/640/480/?image=395", "Shelley Bode V", 5, 4.0, 1134, new DateTime(2022, 12, 13, 2, 41, 3, 418, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Explicabo ea ipsam provident ducimus.", new DateTime(2023, 5, 13, 13, 11, 10, 52, DateTimeKind.Local).AddTicks(7008), "Molestias voluptates quasi ea minus minima architecto accusamus fugiat.\nNesciunt aliquid praesentium neque sint est repudiandae doloremque esse porro.\nEt voluptatibus animi consectetur.", "https://picsum.photos/640/480/?image=471", "Jaime Green V", 2, 2.0, 2150, new DateTime(2022, 11, 23, 22, 12, 31, 626, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit corrupti dicta aut.", new DateTime(2023, 5, 12, 20, 18, 25, 684, DateTimeKind.Local).AddTicks(9205), "At quo est officia dolore eum.\nModi repellendus in repudiandae non voluptas consectetur.", "https://picsum.photos/640/480/?image=159", "Gilbert Dach II", 3.0, 2017, new DateTime(2022, 9, 7, 8, 45, 51, 832, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est ut suscipit a.", new DateTime(2023, 5, 13, 12, 8, 36, 324, DateTimeKind.Local).AddTicks(104), "Quo amet repellendus doloribus iste.\nA ab id dolorem perspiciatis dolores.\nVoluptatibus quia ea unde nobis velit.\nFugit consectetur similique ut explicabo accusantium at.\nQuia tempore expedita.", "https://picsum.photos/640/480/?image=647", "Dr. Richard Erdman", 8, 1.0, 1943, new DateTime(2023, 2, 22, 19, 33, 16, 899, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Delectus quo sunt omnis aut veniam atque.", new DateTime(2023, 5, 13, 8, 15, 46, 886, DateTimeKind.Local).AddTicks(525), "Ut accusamus nostrum tenetur ea id accusantium quasi.", "https://picsum.photos/640/480/?image=814", "Ms. Teresa Kulas", 4, 1.0, 2376, new DateTime(2022, 5, 25, 20, 43, 36, 593, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laborum accusantium tenetur doloremque maxime aliquam pariatur.", new DateTime(2023, 5, 13, 0, 16, 44, 471, DateTimeKind.Local).AddTicks(8901), "Nihil deleniti magnam quod.\nAlias sit est.\nDebitis sequi omnis eius.\nQuaerat at non quae maxime similique in dolorum.", "https://picsum.photos/640/480/?image=962", "Cory Hilll IV", 10, 1.0, 1133, new DateTime(2022, 9, 27, 16, 47, 23, 535, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum ut vitae cum fuga.", new DateTime(2023, 5, 13, 6, 12, 40, 285, DateTimeKind.Local).AddTicks(750), "Iusto exercitationem laboriosam asperiores totam velit non officiis.", "https://picsum.photos/640/480/?image=205", "Mrs. Harvey Kozey", 1260, new DateTime(2022, 6, 20, 17, 2, 21, 241, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Vitae veritatis illo est.", new DateTime(2023, 5, 13, 16, 50, 7, 985, DateTimeKind.Local).AddTicks(3241), "Natus adipisci sequi eum ex hic ex.\nAutem est et consequuntur aliquam perspiciatis.\nLaudantium omnis voluptas.", "https://picsum.photos/640/480/?image=1028", "Santos Leffler IV", 6, 5.0, 1649, new DateTime(2022, 6, 3, 19, 14, 48, 87, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed laudantium consequuntur sunt tenetur itaque aperiam.", new DateTime(2023, 5, 13, 14, 54, 46, 748, DateTimeKind.Local).AddTicks(5685), "Est doloremque optio quo provident.\nFugit in sint facere asperiores voluptas sed qui reiciendis.\nExpedita beatae sed nisi sequi fugiat esse et.", "https://picsum.photos/640/480/?image=746", "Sue Crooks IV", 6, 1.0, 1997, new DateTime(2023, 3, 30, 3, 0, 35, 839, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequuntur maxime aut tempore consequatur quis blanditiis aut beatae dolorum.", new DateTime(2023, 5, 13, 3, 5, 6, 174, DateTimeKind.Local).AddTicks(2461), "Beatae labore velit iure neque optio tempore aliquid quia veritatis.\nEt est repudiandae ratione inventore doloremque.\nInventore sed aliquid dolorem cumque mollitia id rerum eos.\nVoluptatem aut harum modi voluptatem voluptatum.", "https://picsum.photos/640/480/?image=904", "Ms. John Brown", 3.0, 2341, new DateTime(2022, 6, 3, 0, 19, 57, 39, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Provident nesciunt dignissimos.", new DateTime(2023, 5, 13, 1, 16, 22, 413, DateTimeKind.Local).AddTicks(5085), "Et perspiciatis laudantium.\nAtque consequatur temporibus sit adipisci neque.\nMagnam autem cumque.\nNeque vero autem sunt veritatis enim fugiat.", "https://picsum.photos/640/480/?image=865", "Ms. Bernadette Murazik", 7, 4.0, 1384, new DateTime(2023, 2, 12, 13, 55, 8, 834, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum dolores pariatur.", new DateTime(2023, 5, 13, 15, 33, 40, 831, DateTimeKind.Local).AddTicks(8674), "Ipsa doloremque dolorem impedit eum reprehenderit nulla architecto.\nFuga et sint ipsum quibusdam sint.\nTempora voluptatem cumque.\nEnim nemo error occaecati ea.\nIpsam et aut fuga voluptatum facere qui et.", "https://picsum.photos/640/480/?image=408", "Ken Stehr DVM", 4, 1613, new DateTime(2022, 12, 11, 7, 1, 30, 862, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsa dolores vitae enim odio voluptates ut nesciunt possimus quia.", new DateTime(2023, 5, 13, 0, 9, 2, 747, DateTimeKind.Local).AddTicks(4208), "Facere pariatur asperiores sit.\nVoluptatem minus praesentium voluptatum aut sequi odit.\nUt eveniet dicta temporibus nobis occaecati rerum quis.\nPraesentium cupiditate id enim.\nVoluptatem iste explicabo repudiandae.", "https://picsum.photos/640/480/?image=237", "Mr. Clifford Crooks", 9, 3.0, 1458, new DateTime(2022, 9, 29, 2, 48, 45, 634, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Enim asperiores quaerat animi.", new DateTime(2023, 5, 13, 5, 24, 24, 42, DateTimeKind.Local).AddTicks(5455), "Ipsam eligendi voluptas eos est hic occaecati illum.", "https://picsum.photos/640/480/?image=17", "Anita Cummerata IV", 4, 1724, new DateTime(2023, 5, 13, 6, 8, 38, 754, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Accusamus sunt architecto sapiente officiis laudantium error eligendi doloribus.", new DateTime(2023, 5, 12, 18, 57, 33, 686, DateTimeKind.Local).AddTicks(2135), "Commodi et sed quo cumque repellendus delectus autem repellat.\nQui deleniti vel rerum excepturi.\nOdio saepe beatae in.", "https://picsum.photos/640/480/?image=810", "Dr. Homer Schulist", 4.0, 2001, new DateTime(2023, 2, 2, 23, 53, 23, 880, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsam est cum.", new DateTime(2023, 5, 12, 20, 28, 24, 116, DateTimeKind.Local).AddTicks(4791), "Praesentium corporis quaerat aut blanditiis placeat eum reprehenderit placeat.\nConsequatur quod voluptatem qui non dolorum est.", "https://picsum.photos/640/480/?image=365", "Ignacio Predovic Sr.", 6, 3.0, 548, new DateTime(2022, 6, 22, 14, 38, 43, 102, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Officia ut ex id.", new DateTime(2023, 5, 13, 0, 59, 46, 850, DateTimeKind.Local).AddTicks(2109), "Ullam sed quas quod sapiente.\nQuis dolorem soluta incidunt ipsam omnis voluptatem.\nQui molestias molestiae omnis.\nIpsam rerum vitae est soluta non in sequi.", "https://picsum.photos/640/480/?image=37", "Miss Sheila Cruickshank", 2, 2.0, 2130, new DateTime(2022, 12, 31, 1, 52, 19, 59, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut est impedit et voluptas voluptas laudantium nihil et.", new DateTime(2023, 5, 13, 13, 7, 38, 402, DateTimeKind.Local).AddTicks(2009), "Facilis id voluptatibus fugit est.\nEt debitis iure itaque quasi delectus deleniti rem.\nNobis dolorum praesentium repudiandae doloribus dolores deserunt sed rerum.\nDebitis deleniti similique tempora esse.\nIncidunt magnam illum sed.", "https://picsum.photos/640/480/?image=915", "Christina Rodriguez III", 8, 4.0, 2035, new DateTime(2022, 5, 20, 0, 46, 45, 427, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et dignissimos esse.", new DateTime(2023, 5, 12, 20, 48, 51, 108, DateTimeKind.Local).AddTicks(3891), "Velit nesciunt provident sapiente quo reiciendis.\nOmnis eos consequatur dolor ut temporibus in.\nEst dolor quis aperiam repellendus eaque.\nDignissimos magnam qui eveniet ut deleniti ea est tempora ea.\nNeque ad autem quis repellat veniam rerum explicabo eligendi.", "https://picsum.photos/640/480/?image=53", "Catherine Koepp IV", 1554, new DateTime(2022, 11, 29, 23, 29, 50, 698, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "In deleniti itaque.", new DateTime(2023, 5, 13, 14, 8, 4, 887, DateTimeKind.Local).AddTicks(8598), "Voluptatem repudiandae error ipsam rerum assumenda.\nSapiente exercitationem qui eos saepe nihil.", "https://picsum.photos/640/480/?image=692", "Lewis Davis V", 2, 1.0, 1997, new DateTime(2022, 10, 2, 9, 52, 19, 255, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellendus cupiditate rerum nesciunt vero fuga aut eligendi voluptatem amet.", new DateTime(2023, 5, 13, 3, 21, 7, 226, DateTimeKind.Local).AddTicks(4368), "Sed reiciendis quae aut deserunt sint temporibus quasi magnam.", "https://picsum.photos/640/480/?image=551", "Mr. Dominic Grady", 10, 2.0, 765, new DateTime(2023, 4, 26, 17, 49, 51, 319, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur ad eaque debitis libero magni quibusdam soluta.", new DateTime(2023, 5, 12, 18, 33, 56, 264, DateTimeKind.Local).AddTicks(3332), "Totam est qui.\nEst quia provident non laudantium ut sit.\nFugiat ex autem.\nItaque est repellat omnis est doloremque modi.\nVoluptatibus qui culpa dolores doloremque nihil perspiciatis explicabo sed impedit.", "https://picsum.photos/640/480/?image=921", "Gustavo Luettgen III", 5, 1.0, 2249, new DateTime(2023, 2, 10, 3, 38, 50, 384, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit omnis temporibus.", new DateTime(2023, 5, 13, 9, 26, 50, 408, DateTimeKind.Local).AddTicks(1686), "In quas suscipit doloribus consequatur eaque aut non.\nSit est nisi itaque et vitae tenetur.\nRecusandae est qui.\nConsequatur ea qui voluptatem quos rerum vel.\nDebitis dignissimos accusamus et unde deserunt nobis sit.", "https://picsum.photos/640/480/?image=121", "Lindsey Beier DDS", 10, 2.0, 983, new DateTime(2022, 5, 24, 23, 36, 39, 929, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsam id dolorum aut quia non excepturi explicabo quod et.", new DateTime(2023, 5, 13, 8, 10, 21, 947, DateTimeKind.Local).AddTicks(7630), "Itaque in ut qui.\nFugiat recusandae molestias itaque dolorum.\nNulla est itaque veniam consequatur neque labore ea.", "https://picsum.photos/640/480/?image=107", "Miss Joseph Stehr", 9, 1.0, 1686, new DateTime(2022, 10, 21, 23, 2, 49, 413, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "At repellendus blanditiis aut dolores.", new DateTime(2023, 5, 12, 22, 55, 2, 402, DateTimeKind.Local).AddTicks(6086), "Aut consequatur et quas impedit est ratione rem odio.\nNesciunt tempore quisquam minus ducimus rem dolor.", "https://picsum.photos/640/480/?image=183", "Dr. Dave Kessler", 1, 3.0, 2496, new DateTime(2023, 3, 6, 10, 57, 4, 40, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Accusamus eligendi harum cum saepe molestiae.", new DateTime(2023, 5, 13, 5, 43, 24, 172, DateTimeKind.Local).AddTicks(3238), "Quas qui dolore rerum qui molestiae facere natus in eos.\nEius iure temporibus rerum et reprehenderit in cumque omnis dolore.", "https://picsum.photos/640/480/?image=396", "Caroline Lockman IV", 7, 847, new DateTime(2022, 8, 7, 23, 13, 26, 930, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Reiciendis sint qui voluptates qui odit aspernatur tenetur voluptatem.", new DateTime(2023, 5, 12, 21, 50, 25, 878, DateTimeKind.Local).AddTicks(4430), "Sit assumenda quis ducimus praesentium nobis facere.", "https://picsum.photos/640/480/?image=333", "Lora Bernhard Sr.", 3.0, 847, new DateTime(2023, 1, 16, 23, 16, 55, 509, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sunt asperiores rem accusantium cum soluta.", new DateTime(2023, 5, 13, 1, 5, 15, 513, DateTimeKind.Local).AddTicks(7187), "Soluta non iusto nihil possimus.\nAliquid maiores vitae enim ab error optio non sunt quis.\nVoluptas et aut odit laudantium vel nostrum.\nIn hic architecto id quia.\nAspernatur facere corrupti.", "https://picsum.photos/640/480/?image=487", "Gayle Ritchie PhD", 4.0, 1878, new DateTime(2022, 9, 21, 8, 30, 39, 222, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Numquam tempore dolores eius est voluptatem occaecati assumenda velit.", new DateTime(2023, 5, 12, 20, 20, 46, 612, DateTimeKind.Local).AddTicks(9986), "Dolores tempora dolores blanditiis.", "https://picsum.photos/640/480/?image=282", "Cecelia Gottlieb II", 5, 5.0, 2209, new DateTime(2022, 6, 11, 15, 23, 52, 330, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Similique et harum deleniti.", new DateTime(2023, 5, 13, 17, 32, 56, 707, DateTimeKind.Local).AddTicks(8955), "Omnis ducimus saepe mollitia amet.", "https://picsum.photos/640/480/?image=879", "Lawrence Walker I", 9, 3.0, 536, new DateTime(2022, 11, 8, 23, 4, 37, 820, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Odit est natus.", new DateTime(2023, 5, 13, 16, 53, 57, 291, DateTimeKind.Local).AddTicks(8145), "Autem ipsum amet sed ullam tempore cum magni.\nSunt quae ducimus explicabo sed vel.\nCorporis ut inventore dolores neque.", "https://picsum.photos/640/480/?image=673", "Miss Brent Leffler", 2, 1.0, 1325, new DateTime(2023, 3, 29, 8, 25, 55, 539, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sunt placeat quidem alias cum.", new DateTime(2023, 5, 13, 15, 54, 42, 974, DateTimeKind.Local).AddTicks(5546), "Aliquid consequuntur exercitationem autem reiciendis totam molestiae quos inventore praesentium.\nEt neque quis dignissimos quidem deserunt sunt eos et qui.", "https://picsum.photos/640/480/?image=1005", "Mr. Mario Gislason", 1, 2.0, 1470, new DateTime(2023, 4, 23, 20, 39, 52, 269, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ea natus magni molestiae.", new DateTime(2023, 5, 13, 4, 17, 13, 15, DateTimeKind.Local).AddTicks(6811), "Dolores non totam atque sed nihil aut neque aut dignissimos.", "https://picsum.photos/640/480/?image=105", "Kim Hirthe IV", 7, 1.0, 2316, new DateTime(2023, 3, 17, 4, 45, 9, 123, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et magnam officia tempora deserunt sed eveniet ut reiciendis dolorum.", new DateTime(2023, 5, 12, 22, 35, 19, 920, DateTimeKind.Local).AddTicks(760), "Impedit quis explicabo est dolorem reprehenderit.\nOdio optio sint magni aut ad est sed eos.\nCum eum unde dolorem perferendis accusantium.\nRerum sed vel rerum eligendi temporibus ipsam sunt velit.\nSit maiores sed exercitationem.", "https://picsum.photos/640/480/?image=126", "Lowell Osinski IV", 5.0, 1028, new DateTime(2023, 1, 15, 14, 6, 29, 858, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nostrum temporibus quos repellat culpa odit.", new DateTime(2023, 5, 13, 8, 8, 31, 918, DateTimeKind.Local).AddTicks(1491), "Sed non commodi a.\nVel possimus sunt qui quae nisi.", "https://picsum.photos/640/480/?image=532", "Mr. Anita Goodwin", 8, 1.0, 1392, new DateTime(2023, 1, 5, 10, 5, 9, 224, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repudiandae nisi ea nihil esse.", new DateTime(2023, 5, 12, 22, 9, 48, 254, DateTimeKind.Local).AddTicks(6951), "Et vero nihil enim.\nRepudiandae commodi sed minus.", "https://picsum.photos/640/480/?image=996", "Miss Terri Olson", 8, 2.0, 1464, new DateTime(2022, 10, 6, 23, 16, 36, 411, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Saepe asperiores voluptatibus nemo.", new DateTime(2023, 5, 13, 11, 8, 17, 569, DateTimeKind.Local).AddTicks(184), "Dolor expedita distinctio est qui.\nAut quibusdam est fugit quasi et.\nInventore aut qui rerum earum in.\nOmnis voluptas eligendi.\nVoluptates sit temporibus facere necessitatibus voluptates nostrum accusantium exercitationem qui.", "https://picsum.photos/640/480/?image=1032", "Dr. Dianna Klein", 4, 1.0, 596, new DateTime(2022, 9, 11, 7, 1, 3, 110, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est doloremque rerum eos cupiditate eligendi.", new DateTime(2023, 5, 13, 17, 34, 18, 714, DateTimeKind.Local).AddTicks(2360), "Aut voluptas libero temporibus quam aut ex ad.\nUt id qui voluptatem aliquam officiis molestias aspernatur.", "https://picsum.photos/640/480/?image=118", "Bethany Lebsack III", 6, 3.0, 1966, new DateTime(2023, 1, 25, 11, 12, 10, 686, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem ut autem qui non aut.", new DateTime(2023, 5, 12, 20, 56, 20, 138, DateTimeKind.Local).AddTicks(5477), "Omnis in deserunt porro.", "https://picsum.photos/640/480/?image=429", "Mr. Patty Runolfsson", 8, 3.0, 976, new DateTime(2022, 6, 30, 1, 46, 22, 439, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestias rerum sint.", new DateTime(2023, 5, 12, 23, 18, 31, 927, DateTimeKind.Local).AddTicks(2442), "Expedita iusto itaque quam nihil perferendis tenetur et eum aliquam.\nEst adipisci ad.\nLaudantium quaerat natus velit repellendus est soluta nesciunt sit iste.", "https://picsum.photos/640/480/?image=213", "Traci Bogisich II", 6, 4.0, 1356, new DateTime(2022, 12, 6, 23, 57, 56, 302, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolor iusto aliquid ipsum alias quia asperiores.", new DateTime(2023, 5, 13, 12, 25, 14, 184, DateTimeKind.Local).AddTicks(3707), "Labore amet debitis velit cupiditate placeat ducimus ut saepe praesentium.\nExercitationem voluptatem quibusdam et consectetur necessitatibus veritatis.\nBeatae enim cupiditate.", "https://picsum.photos/640/480/?image=943", "Dr. Rosalie Stokes", 1.0, 616, new DateTime(2023, 4, 23, 4, 11, 56, 672, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellendus ullam dolorem quidem quia.", new DateTime(2023, 5, 13, 4, 55, 54, 452, DateTimeKind.Local).AddTicks(9554), "Aut accusantium ipsa ea nesciunt.\nLaudantium fugit animi consectetur natus.\nVoluptatem alias molestiae vitae omnis rerum ratione sint.\nAccusamus aut debitis sint ut magnam a odio ratione.\nVitae amet minus est dolorem molestiae earum qui.", "https://picsum.photos/640/480/?image=1040", "Dr. Sonja Bergstrom", 2, 3.0, 1805, new DateTime(2023, 3, 18, 15, 42, 47, 369, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iure tempora occaecati quo sit animi molestiae.", new DateTime(2023, 5, 13, 0, 19, 38, 515, DateTimeKind.Local).AddTicks(1694), "Itaque eaque ut voluptas id magni fuga ut.", "https://picsum.photos/640/480/?image=302", "Tara Powlowski V", 2, 1022, new DateTime(2022, 6, 2, 14, 14, 18, 875, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum ut beatae ad culpa ipsa et voluptatem neque dolorum.", new DateTime(2023, 5, 13, 4, 17, 37, 616, DateTimeKind.Local).AddTicks(1008), "Itaque sunt occaecati id reiciendis rerum tempora.\nEst est est ab at natus.\nVel minus sit.\nRem dolorem suscipit unde voluptas et debitis quisquam illum odit.", "https://picsum.photos/640/480/?image=1035", "Louise Upton PhD", 10, 3.0, 1132, new DateTime(2022, 10, 10, 15, 28, 39, 207, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Corrupti ullam modi esse dolore quod.", new DateTime(2023, 5, 13, 5, 2, 56, 937, DateTimeKind.Local).AddTicks(5785), "Laborum corporis sapiente molestiae facere consequatur.\nCupiditate sint ea dolores dicta eveniet debitis.\nSed aut et maiores voluptate nesciunt a labore.\nDolor at deserunt explicabo eos et est.", "https://picsum.photos/640/480/?image=885", "Mrs. Tyrone Williamson", 7, 2.0, 1538, new DateTime(2022, 10, 14, 19, 5, 56, 784, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem ea natus necessitatibus eligendi voluptate eaque eligendi.", new DateTime(2023, 5, 12, 21, 31, 26, 547, DateTimeKind.Local).AddTicks(4493), "Suscipit recusandae soluta beatae impedit voluptate sunt.", "https://picsum.photos/640/480/?image=34", "Mr. Pablo Keebler", 1.0, 502, new DateTime(2023, 4, 1, 6, 37, 52, 914, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Praesentium dolorem impedit ea laborum neque.", new DateTime(2023, 5, 13, 7, 56, 46, 121, DateTimeKind.Local).AddTicks(8028), "Eos et incidunt voluptatibus velit ut repudiandae tempore nesciunt.\nEnim a quo mollitia quia aut voluptatum aperiam laborum.", "https://picsum.photos/640/480/?image=997", "Chad Wilderman III", 9, 3.0, 818, new DateTime(2023, 4, 12, 4, 10, 38, 933, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut dolorem repellendus sint iusto.", new DateTime(2023, 5, 12, 19, 35, 4, 505, DateTimeKind.Local).AddTicks(5344), "Quasi fugiat natus delectus vitae molestias asperiores.\nDistinctio reiciendis labore provident ipsa nihil odio sed.\nSimilique omnis possimus voluptas dolor.\nPossimus harum officia fuga sunt dolore et mollitia.\nEligendi non earum et ratione.", "https://picsum.photos/640/480/?image=506", "Ms. Linda Reinger", 10, 4.0, 2254, new DateTime(2023, 1, 25, 17, 45, 56, 962, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut ea tempore ea.", new DateTime(2023, 5, 13, 5, 27, 29, 918, DateTimeKind.Local).AddTicks(9688), "Aut voluptate molestiae ea sed iure animi tempore ab.\nEst doloribus velit totam aliquid.\nCommodi quasi quos voluptas quo vero.", "https://picsum.photos/640/480/?image=995", "Laverne Parisian MD", 6, 5.0, 1277, new DateTime(2023, 2, 4, 6, 50, 0, 224, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui et eaque eum earum quia possimus deserunt.", new DateTime(2023, 5, 13, 2, 47, 23, 862, DateTimeKind.Local).AddTicks(8614), "Voluptas ex perferendis sunt possimus fugit quod atque consequuntur unde.\nNulla ipsum quas in est et eveniet qui sit aut.\nEst ratione aspernatur aspernatur quo iure excepturi tempora eveniet autem.\nQuo sed pariatur cumque vel.\nEt vitae explicabo.", "https://picsum.photos/640/480/?image=363", "Robin Simonis DVM", 1, 2.0, 1829, new DateTime(2022, 10, 22, 22, 54, 51, 300, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sunt et dolorem.", new DateTime(2023, 5, 13, 2, 13, 41, 508, DateTimeKind.Local).AddTicks(1071), "Aut voluptatem consequatur nesciunt.\nEst amet et voluptatem vitae eveniet aut eos.\nVoluptatem doloribus exercitationem rem repudiandae.", "https://picsum.photos/640/480/?image=502", "Mrs. Samantha Effertz", 1, 1339, new DateTime(2022, 8, 17, 2, 55, 38, 273, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et quo et praesentium commodi.", new DateTime(2023, 5, 12, 21, 25, 24, 638, DateTimeKind.Local).AddTicks(4663), "Et consequuntur quibusdam est sapiente soluta laborum.", "https://picsum.photos/640/480/?image=844", "Patrick Reilly Sr.", 9, 5.0, 607, new DateTime(2023, 3, 27, 15, 46, 56, 765, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sint provident rerum est quam.", new DateTime(2023, 5, 13, 4, 14, 44, 700, DateTimeKind.Local).AddTicks(2087), "Omnis consectetur perferendis sunt nemo ut dolorum et.", "https://picsum.photos/640/480/?image=213", "Abraham Streich MD", 5, 4.0, 963, new DateTime(2023, 1, 15, 11, 5, 42, 364, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis dicta est.", new DateTime(2023, 5, 13, 8, 38, 40, 500, DateTimeKind.Local).AddTicks(5109), "Eveniet aperiam dignissimos rerum nihil id eveniet necessitatibus laudantium.\nVoluptatibus quo omnis voluptatem qui atque dicta aperiam at facilis.\nOfficiis explicabo est molestias blanditiis.\nConsequuntur consequatur fugiat aspernatur dolorem sit possimus consequatur autem.\nQuod rerum illo praesentium et quia atque.", "https://picsum.photos/640/480/?image=661", "Miss Carole Reilly", 5, 2.0, 2295, new DateTime(2022, 7, 18, 19, 18, 34, 519, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui repudiandae hic neque et unde voluptatem repellendus.", new DateTime(2023, 5, 12, 20, 9, 32, 346, DateTimeKind.Local).AddTicks(9981), "Aut dicta eligendi in eaque.\nIn similique ex adipisci et debitis.\nOmnis rerum id sit vel vero labore sunt a.", "https://picsum.photos/640/480/?image=474", "Dr. Cary Kiehn", 10, 3.0, 1999, new DateTime(2023, 1, 28, 2, 57, 20, 352, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aperiam deserunt quas ut eum voluptatem aut cupiditate dicta enim.", new DateTime(2023, 5, 13, 14, 38, 57, 218, DateTimeKind.Local).AddTicks(3727), "Cupiditate consequatur repellendus dolorem adipisci sequi maiores dolorum.\nId qui ab culpa numquam eveniet aut sed vel consequatur.\nNulla explicabo delectus ipsa voluptas enim illum numquam ipsum quidem.\nRerum nemo reiciendis iste sequi et non repellendus porro non.\nSapiente illo officia ut iure voluptatem totam.", "https://picsum.photos/640/480/?image=328", "Rosie Kutch III", 1634, new DateTime(2022, 8, 6, 21, 20, 59, 682, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui dolores quo.", new DateTime(2023, 5, 13, 10, 2, 27, 766, DateTimeKind.Local).AddTicks(6130), "Nostrum qui magni dolores sed cumque ut libero corrupti et.\nQuasi est ad possimus recusandae in laborum.", "https://picsum.photos/640/480/?image=153", "Reginald Gutmann DVM", 10, 4.0, 1447, new DateTime(2023, 4, 4, 6, 33, 26, 846, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut minima rem ut.", new DateTime(2023, 5, 12, 23, 40, 51, 701, DateTimeKind.Local).AddTicks(1842), "Saepe sint accusantium.\nIste incidunt tempore iure et possimus.\nFugit non et laudantium sed est.", "https://picsum.photos/640/480/?image=617", "Mrs. Kelvin Corkery", 1571, new DateTime(2022, 7, 27, 12, 14, 51, 158, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut qui neque aut dolorum voluptates pariatur ipsa ab.", new DateTime(2023, 5, 13, 8, 2, 58, 223, DateTimeKind.Local).AddTicks(8165), "Maiores ut deserunt eius sequi sapiente a.\nSed minus veniam voluptatem est tempore sapiente.", "https://picsum.photos/640/480/?image=1008", "Colin Nader Jr.", 6, 3.0, 1418, new DateTime(2022, 6, 6, 4, 0, 33, 676, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Optio sint rerum.", new DateTime(2023, 5, 12, 21, 0, 1, 781, DateTimeKind.Local).AddTicks(2794), "Voluptate et sit temporibus fugiat et sit minima accusamus ullam.\nQuasi unde cum tempora voluptatem.\nEos beatae officiis tempore at.\nSed illum magni voluptas.\nDeserunt assumenda a officiis eos quis maxime.", "https://picsum.photos/640/480/?image=412", "Miss Luther Stoltenberg", 7, 5.0, 1411, new DateTime(2022, 7, 16, 2, 44, 17, 645, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis ipsum voluptas et provident deleniti voluptatem et.", new DateTime(2023, 5, 13, 5, 36, 13, 39, DateTimeKind.Local).AddTicks(3867), "Dolore error nesciunt est reprehenderit eligendi iure ducimus.", "https://picsum.photos/640/480/?image=698", "Miss Alyssa Dooley", 5, 1351, new DateTime(2023, 3, 12, 23, 33, 43, 912, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Commodi repellat assumenda est.", new DateTime(2023, 5, 12, 23, 25, 59, 738, DateTimeKind.Local).AddTicks(9295), "Eum error libero.", "https://picsum.photos/640/480/?image=103", "Dr. Jay Considine", 1, 1992, new DateTime(2022, 11, 24, 14, 21, 38, 240, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quisquam eos in quis vitae modi aut dolores voluptatibus.", new DateTime(2023, 5, 13, 15, 1, 41, 938, DateTimeKind.Local).AddTicks(2560), "Impedit quo magni odit voluptatum libero facere totam.\nEum aperiam nesciunt est.", "https://picsum.photos/640/480/?image=751", "Miss Max Koch", 2, 5.0, 2183, new DateTime(2023, 5, 7, 16, 8, 8, 743, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Alias iste et debitis omnis aspernatur ratione soluta ullam.", new DateTime(2023, 5, 13, 12, 33, 39, 504, DateTimeKind.Local).AddTicks(6154), "Labore quos est.\nDucimus rem rerum consequuntur molestias illum voluptates itaque.\nQuaerat sequi voluptas.\nEos ducimus provident saepe velit ut et quia est eaque.", "https://picsum.photos/640/480/?image=420", "Derek Block I", 7, 5.0, 884, new DateTime(2022, 6, 7, 6, 44, 58, 726, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed consectetur quisquam soluta similique nihil id itaque incidunt.", new DateTime(2023, 5, 12, 22, 43, 55, 678, DateTimeKind.Local).AddTicks(6596), "Adipisci non dolorem.\nConsectetur nihil occaecati beatae assumenda tempore.", "https://picsum.photos/640/480/?image=134", "Chris Buckridge Sr.", 6, 5.0, 1300, new DateTime(2023, 3, 7, 10, 8, 28, 918, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Soluta aperiam ea ea.", new DateTime(2023, 5, 13, 16, 54, 28, 119, DateTimeKind.Local).AddTicks(1461), "Natus rem natus dolore itaque animi quo vitae totam.\nIusto distinctio aspernatur qui dolorem ad.\nOdio libero reiciendis ut et sunt et aut nobis sequi.", "https://picsum.photos/640/480/?image=767", "Miss Darnell Smitham", 5.0, 2137, new DateTime(2023, 3, 22, 18, 24, 51, 129, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Numquam eum quod.", new DateTime(2023, 5, 13, 12, 49, 28, 855, DateTimeKind.Local).AddTicks(3763), "Consequuntur et ut vitae aut autem ratione aut corporis autem.\nQuos enim recusandae illum quo et.\nAperiam sit eos et.\nEt asperiores eos consectetur et qui itaque quae.", "https://picsum.photos/640/480/?image=750", "Clifford Walter II", 9, 5.0, 1876, new DateTime(2022, 10, 15, 7, 3, 49, 363, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ab reiciendis hic ea quidem doloremque quae quidem ducimus.", new DateTime(2023, 5, 13, 16, 49, 41, 237, DateTimeKind.Local).AddTicks(8209), "Sunt nihil necessitatibus quidem vel.\nLaudantium libero similique nihil tenetur nihil molestiae.\nPariatur commodi quos.\nArchitecto repellat reiciendis quia alias incidunt nobis.", "https://picsum.photos/640/480/?image=873", "Ms. Leroy Kovacek", 2, 2.0, 934, new DateTime(2023, 4, 14, 3, 43, 35, 428, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Vitae officiis provident facere eaque beatae molestiae laboriosam consectetur id.", new DateTime(2023, 5, 13, 2, 3, 45, 913, DateTimeKind.Local).AddTicks(9238), "Ullam impedit labore reprehenderit repellat distinctio quas.", "https://picsum.photos/640/480/?image=1075", "Dr. Kerry Veum", 4, 2.0, 1735, new DateTime(2023, 2, 11, 11, 1, 30, 376, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et cumque rem.", new DateTime(2023, 5, 13, 6, 10, 34, 773, DateTimeKind.Local).AddTicks(5945), "Optio possimus itaque minus deleniti fugit omnis.", "https://picsum.photos/640/480/?image=372", "Jacqueline Nienow I", 10, 2.0, 2438, new DateTime(2022, 7, 25, 20, 38, 1, 793, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas magni voluptatum tenetur molestias.", new DateTime(2023, 5, 12, 20, 59, 27, 47, DateTimeKind.Local).AddTicks(7623), "Illum ducimus porro aut repudiandae ipsam aut.\nExercitationem assumenda ex iste quo.", "https://picsum.photos/640/480/?image=214", "Ms. Katrina Huel", 10, 5.0, 1289, new DateTime(2022, 7, 20, 17, 12, 59, 446, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Amet est nemo.", new DateTime(2023, 5, 12, 22, 12, 25, 657, DateTimeKind.Local).AddTicks(629), "Eos minima commodi doloribus sint et quis.\nIncidunt ex ad ut et sed facilis nihil eaque quia.\nRerum illum et sed inventore eos dignissimos.\nVoluptatibus deserunt dolores et reiciendis molestiae pariatur.", "https://picsum.photos/640/480/?image=320", "Mr. Clay Kulas", 2, 5.0, 2359, new DateTime(2022, 6, 22, 14, 16, 21, 956, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dicta qui qui consequatur neque aspernatur eligendi dolor.", new DateTime(2023, 5, 13, 15, 29, 37, 514, DateTimeKind.Local).AddTicks(234), "Quia et qui eum incidunt pariatur quos qui molestias sapiente.\nImpedit laborum suscipit reprehenderit molestiae consequatur et.\nAt in qui fugit non qui facilis ducimus ipsum occaecati.", "https://picsum.photos/640/480/?image=385", "Gina Cremin Jr.", 1, 4.0, 2178, new DateTime(2022, 6, 7, 15, 19, 2, 494, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sequi possimus soluta.", new DateTime(2023, 5, 12, 18, 52, 4, 267, DateTimeKind.Local).AddTicks(6482), "Et similique eveniet veniam.\nRepudiandae beatae blanditiis corrupti dignissimos vitae fuga.\nOdit qui illo magni reprehenderit est magnam ut fuga.\nVeritatis vero aut totam.\nUt et illum et qui a minima possimus.", "https://picsum.photos/640/480/?image=484", "Phillip Collier PhD", 3.0, 764, new DateTime(2022, 11, 22, 12, 55, 33, 498, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas rerum repellat est sunt aut ipsum et nihil.", new DateTime(2023, 5, 13, 1, 27, 23, 963, DateTimeKind.Local).AddTicks(5240), "Quas officia quos ab repellendus aut facere officia suscipit at.\nRatione fugiat nam quas odio ut cumque atque vel.\nQuisquam odit ipsa est ut omnis blanditiis quis recusandae.\nEa reiciendis quaerat voluptas sit perferendis libero porro enim.\nMolestias voluptatibus sapiente rerum nam deleniti voluptas dolor delectus hic.", "https://picsum.photos/640/480/?image=66", "Mrs. Jeffrey Johnston", 3.0, 1181, new DateTime(2022, 6, 1, 5, 20, 33, 876, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ducimus illum voluptatum et est nostrum dolorem necessitatibus ab.", new DateTime(2023, 5, 13, 11, 7, 30, 566, DateTimeKind.Local).AddTicks(6066), "Non voluptatum eius totam accusantium blanditiis quod eaque.", "https://picsum.photos/640/480/?image=1063", "Eva Zboncak Sr.", 5, 1.0, 1873, new DateTime(2023, 4, 7, 13, 49, 59, 517, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequuntur voluptatem totam vel voluptatem debitis consectetur.", new DateTime(2023, 5, 12, 20, 28, 59, 379, DateTimeKind.Local).AddTicks(3048), "Et asperiores ipsam sunt non a dicta repellendus.\nIllo qui iure et pariatur ex ex ipsam.\nTemporibus ipsam quia.\nNon iure delectus temporibus optio enim.", "https://picsum.photos/640/480/?image=399", "Mrs. Sammy Baumbach", 10, 1.0, 1362, new DateTime(2023, 3, 31, 22, 8, 55, 375, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laudantium aut nihil consequuntur commodi rem debitis quaerat.", new DateTime(2023, 5, 13, 16, 48, 1, 187, DateTimeKind.Local).AddTicks(2532), "Sint itaque et placeat voluptatum quis ut aliquam ipsam qui.\nInventore recusandae autem.\nRerum voluptatibus animi nesciunt illum.\nAut fuga iste doloremque tempore est.\nAut et debitis voluptatem distinctio aliquam odit aut neque.", "https://picsum.photos/640/480/?image=1038", "Mr. Ronald Deckow", 8, 1630, new DateTime(2022, 8, 17, 13, 51, 36, 155, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Maxime et minus voluptas earum voluptas est.", new DateTime(2023, 5, 13, 11, 43, 47, 403, DateTimeKind.Local).AddTicks(3877), "Nihil assumenda eum.", "https://picsum.photos/640/480/?image=671", "Sheila Gutkowski III", 8, 2351, new DateTime(2023, 1, 11, 16, 44, 30, 123, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempore odit omnis earum aut adipisci minus aliquid consequuntur accusantium.", new DateTime(2023, 5, 12, 19, 6, 40, 335, DateTimeKind.Local).AddTicks(2546), "Dicta nemo alias rem non omnis doloribus ab.\nTemporibus molestiae a deleniti.\nOmnis corporis corrupti.", "https://picsum.photos/640/480/?image=714", "Ms. Willie Shields", 2.0, 1806, new DateTime(2023, 3, 8, 3, 21, 55, 167, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Debitis voluptas temporibus.", new DateTime(2023, 5, 13, 1, 25, 26, 984, DateTimeKind.Local).AddTicks(8314), "Libero sit est inventore et ut quibusdam rerum.", "https://picsum.photos/640/480/?image=36", "Tabitha Steuber IV", 7, 2.0, 1034, new DateTime(2022, 9, 12, 14, 11, 22, 927, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ducimus eum illum et.", new DateTime(2023, 5, 13, 16, 31, 28, 911, DateTimeKind.Local).AddTicks(3863), "Rem quia itaque ad consequatur.\nCorporis corporis tenetur qui.\nVoluptate nemo aut reprehenderit eligendi quisquam sed possimus est nemo.\nHarum sapiente rerum.\nSuscipit dolores qui animi vel quo.", "https://picsum.photos/640/480/?image=711", "Scott Wuckert Jr.", 1, 4.0, 1360, new DateTime(2022, 6, 12, 9, 6, 1, 923, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aspernatur consequatur repellat et et corrupti ea corporis nihil.", new DateTime(2023, 5, 13, 15, 11, 35, 493, DateTimeKind.Local).AddTicks(741), "Maiores sunt autem possimus deleniti molestiae.\nEt nobis ipsum autem sed voluptatibus at quia.\nRecusandae mollitia est eos.", "https://picsum.photos/640/480/?image=115", "Mrs. Troy Ebert", 3.0, 934, new DateTime(2022, 7, 2, 1, 16, 35, 413, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et harum ut dolorum.", new DateTime(2023, 5, 13, 6, 23, 49, 549, DateTimeKind.Local).AddTicks(840), "Impedit deleniti molestias libero iure aut error.\nIn aliquid voluptatem quo.\nAd corporis nulla ut iure iusto animi ut.", "https://picsum.photos/640/480/?image=72", "Martin Rosenbaum I", 4.0, 2200, new DateTime(2022, 11, 29, 23, 10, 2, 25, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Corrupti architecto ea qui iure ex ratione voluptas.", new DateTime(2023, 5, 13, 16, 23, 24, 255, DateTimeKind.Local).AddTicks(5753), "Voluptas consectetur libero reprehenderit iste est.\nQuo reprehenderit consectetur quo amet.\nEt maiores perferendis nam ullam est et non et.", "https://picsum.photos/640/480/?image=212", "Benny Schaden V", 4, 2.0, 2167, new DateTime(2022, 11, 24, 19, 36, 41, 343, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolores ducimus soluta.", new DateTime(2023, 5, 13, 5, 55, 49, 668, DateTimeKind.Local).AddTicks(1396), "Cumque libero quia quaerat odit occaecati consequuntur accusamus tenetur.", "https://picsum.photos/640/480/?image=869", "Dr. Jody Thiel", 2, 2493, new DateTime(2022, 6, 9, 17, 17, 24, 894, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et rerum et qui harum.", new DateTime(2023, 5, 13, 4, 8, 50, 626, DateTimeKind.Local).AddTicks(2302), "Sequi commodi sed voluptate quia consequuntur quidem.\nNon similique earum animi eaque qui cum.\nBeatae doloribus illo sed est odit dolores ea voluptatibus.", "https://picsum.photos/640/480/?image=154", "Ms. Horace Price", 5.0, 2446, new DateTime(2022, 6, 24, 18, 22, 5, 446, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "A et commodi odit sint in rerum ex architecto.", new DateTime(2023, 5, 13, 15, 33, 4, 350, DateTimeKind.Local).AddTicks(7652), "Cupiditate iure repellendus enim optio eos molestiae nulla.\nSapiente a maxime eum ipsum beatae vitae magni aut enim.", "https://picsum.photos/640/480/?image=659", "Mrs. Cody McKenzie", 7, 5.0, 2053, new DateTime(2023, 3, 17, 17, 44, 44, 342, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas enim placeat natus ipsum aperiam inventore veniam voluptatum.", new DateTime(2023, 5, 12, 20, 12, 53, 333, DateTimeKind.Local).AddTicks(9837), "Voluptas dolorem atque.\nAperiam maiores libero.", "https://picsum.photos/640/480/?image=478", "Kristen Spinka IV", 5, 4.0, 655, new DateTime(2022, 8, 17, 1, 8, 32, 52, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Velit impedit ut consequatur minus magnam saepe delectus et.", new DateTime(2023, 5, 13, 6, 47, 33, 382, DateTimeKind.Local).AddTicks(7811), "Deleniti est accusantium.\nDebitis nesciunt omnis deserunt blanditiis reprehenderit ipsa.\nError deserunt dolor odio fugiat quia sit possimus.\nAssumenda consectetur omnis dolorem molestiae itaque sit debitis voluptas aut.", "https://picsum.photos/640/480/?image=970", "Dr. Vera Beatty", 1223, new DateTime(2023, 4, 17, 2, 41, 21, 278, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsa delectus a sit similique commodi omnis cumque.", new DateTime(2023, 5, 13, 0, 12, 38, 993, DateTimeKind.Local).AddTicks(7188), "Quod quos maxime.\nUt sit maxime ad.\nAdipisci dicta amet dolorem adipisci ut et quisquam ipsam.", "https://picsum.photos/640/480/?image=572", "Laverne Blick II", 10, 1.0, 2206, new DateTime(2023, 2, 18, 22, 17, 2, 571, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum assumenda aperiam vel labore beatae unde ea qui.", new DateTime(2023, 5, 13, 3, 49, 33, 137, DateTimeKind.Local).AddTicks(3381), "Quae autem doloribus sint excepturi id sit.", "https://picsum.photos/640/480/?image=760", "Maria Bayer III", 5, 1201, new DateTime(2022, 8, 26, 14, 12, 47, 256, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolor sunt quo et et asperiores quos iure.", new DateTime(2023, 5, 13, 3, 37, 51, 945, DateTimeKind.Local).AddTicks(3325), "Neque sed sint.\nIusto corporis facere.\nEt asperiores in aut molestias dolor.\nUt ut nisi laudantium.\nOccaecati iure ipsam quibusdam quia perspiciatis mollitia omnis voluptatem.", "https://picsum.photos/640/480/?image=802", "Miranda Raynor MD", 10, 2.0, 1246, new DateTime(2023, 4, 20, 18, 56, 25, 39, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis voluptas neque quo sint provident.", new DateTime(2023, 5, 12, 19, 7, 32, 662, DateTimeKind.Local).AddTicks(7737), "Ut veritatis doloremque quidem aut dolore corrupti illo quas nisi.\nQuae laboriosam omnis qui earum.\nEst fuga similique distinctio nobis animi nemo sapiente aut vero.\nIusto possimus officia est vel iusto.\nExercitationem fuga dignissimos.", "https://picsum.photos/640/480/?image=959", "Silvia Oberbrunner Sr.", 7, 5.0, 1089, new DateTime(2022, 11, 1, 19, 13, 25, 182, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut consectetur eaque ut tempore animi mollitia et ratione.", new DateTime(2023, 5, 13, 1, 30, 21, 79, DateTimeKind.Local).AddTicks(4215), "Repellat eaque possimus.\nId consequuntur sit non voluptatem.\nDoloribus aliquid dolore.\nConsequatur est iste facilis laudantium sed.", "https://picsum.photos/640/480/?image=465", "Darrin Cremin PhD", 7, 573, new DateTime(2022, 11, 25, 16, 20, 18, 321, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Animi sequi et quia autem culpa et tempora.", new DateTime(2023, 5, 13, 15, 50, 32, 877, DateTimeKind.Local).AddTicks(4452), "Id laborum voluptatem ratione non accusamus ut.", "https://picsum.photos/640/480/?image=730", "Julius Lueilwitz DVM", 1, 2.0, 909, new DateTime(2022, 12, 3, 5, 8, 6, 179, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Deleniti fugit accusamus est et.", new DateTime(2023, 5, 13, 7, 0, 44, 278, DateTimeKind.Local).AddTicks(9931), "Quia provident saepe in animi quia in officiis aut.\nFugit et eos accusantium enim omnis fuga vero fugit necessitatibus.\nNatus ut porro cupiditate.", "https://picsum.photos/640/480/?image=383", "Monique Daugherty Jr.", 5, 2.0, 1700, new DateTime(2022, 12, 21, 17, 12, 51, 693, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nobis asperiores aperiam consequatur aut vel.", new DateTime(2023, 5, 12, 18, 17, 5, 980, DateTimeKind.Local).AddTicks(2990), "Saepe qui voluptatem consectetur unde saepe sit.\nDeleniti quia illo saepe.\nItaque magnam dolore officia sed qui aperiam dicta sit vel.", "https://picsum.photos/640/480/?image=826", "Ms. Rochelle Dickinson", 9, 4.0, 2008, new DateTime(2022, 8, 3, 21, 4, 23, 318, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Harum illo delectus recusandae magnam omnis ut corrupti provident.", new DateTime(2023, 5, 13, 0, 43, 6, 255, DateTimeKind.Local).AddTicks(3504), "Labore accusantium facere deserunt voluptatem veritatis rerum in.", "https://picsum.photos/640/480/?image=770", "Maureen Champlin MD", 4, 4.0, 1045, new DateTime(2023, 3, 28, 10, 36, 43, 584, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Modi et inventore provident accusantium et.", new DateTime(2023, 5, 12, 21, 37, 32, 121, DateTimeKind.Local).AddTicks(5898), "Unde nostrum esse cupiditate a dolorem iusto.\nMolestiae facere sed libero perferendis nulla est earum soluta.", "https://picsum.photos/640/480/?image=228", "Mrs. Nick Conn", 3.0, 1139, new DateTime(2022, 6, 6, 11, 10, 18, 582, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed sint minima ex provident maiores.", new DateTime(2023, 5, 13, 9, 29, 53, 105, DateTimeKind.Local).AddTicks(2851), "Odit iusto eos qui iure voluptatem nesciunt est itaque.\nIusto non velit eligendi omnis porro inventore similique.\nReiciendis quod ab.\nDelectus blanditiis vel omnis a ipsum sequi quas ipsum nemo.", "https://picsum.photos/640/480/?image=408", "Traci Glover V", 8, 1.0, 1123, new DateTime(2022, 11, 2, 22, 9, 46, 405, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eveniet alias quidem deserunt nesciunt commodi dolores illo tempora aliquam.", new DateTime(2023, 5, 12, 23, 18, 36, 984, DateTimeKind.Local).AddTicks(2789), "Aut maiores ab illo qui.", "https://picsum.photos/640/480/?image=174", "Ms. Jennifer Nicolas", 3, 4.0, 2273, new DateTime(2022, 12, 25, 23, 57, 17, 525, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut et numquam sed consequatur aut voluptas fugiat.", new DateTime(2023, 5, 13, 16, 31, 49, 932, DateTimeKind.Local).AddTicks(2771), "Ipsum dolores rerum et ab.\nNostrum recusandae vel dolores quo possimus.", "https://picsum.photos/640/480/?image=39", "Terrell Kuhic I", 2, 1.0, 1054, new DateTime(2023, 2, 17, 5, 15, 2, 173, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui non accusamus quas fuga hic voluptatem commodi.", new DateTime(2023, 5, 13, 3, 48, 29, 798, DateTimeKind.Local).AddTicks(5625), "Animi voluptatem rem vitae.\nIusto dicta ut ut repellat eum vero aut inventore.\nOfficiis inventore enim esse neque autem et in blanditiis.", "https://picsum.photos/640/480/?image=254", "Silvia MacGyver MD", 9, 1.0, 552, new DateTime(2022, 10, 27, 2, 1, 17, 615, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem est cumque beatae ut iste quidem.", new DateTime(2023, 5, 13, 16, 14, 1, 931, DateTimeKind.Local).AddTicks(9378), "Et optio sunt.\nEa dolorum odio atque sapiente.\nRepudiandae cumque corporis omnis.\nTempora voluptas dolorum est fugit maxime dignissimos ipsam consequatur.\nBeatae unde et.", "https://picsum.photos/640/480/?image=936", "Mr. Bridget Smith", 6, 3.0, 607, new DateTime(2023, 1, 12, 10, 2, 10, 107, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Fuga consequatur hic minima harum quam.", new DateTime(2023, 5, 13, 3, 26, 37, 540, DateTimeKind.Local).AddTicks(9014), "Quibusdam ut odit.\nNon nam dolore vitae beatae.\nAut minus eligendi quidem quia reprehenderit quas.\nQuo autem quasi recusandae voluptas nihil sit rerum possimus eveniet.", "https://picsum.photos/640/480/?image=223", "Mrs. Julia Bins", 5, 5.0, 1238, new DateTime(2022, 6, 13, 15, 4, 1, 145, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Fuga nemo sit dolorum voluptatem non excepturi fugit rerum.", new DateTime(2023, 5, 13, 6, 37, 9, 995, DateTimeKind.Local).AddTicks(3704), "Pariatur esse omnis aut iusto odit beatae eligendi perferendis aut.\nError a provident adipisci voluptas quaerat.", "https://picsum.photos/640/480/?image=975", "Dr. Krystal Marks", 1896, new DateTime(2022, 5, 24, 14, 14, 55, 811, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui dicta animi amet ut.", new DateTime(2023, 5, 13, 2, 27, 11, 479, DateTimeKind.Local).AddTicks(1354), "Occaecati non asperiores libero autem consequuntur adipisci sunt necessitatibus.\nQuisquam quibusdam dignissimos.\nSaepe reiciendis laboriosam nihil minus rem et perferendis culpa explicabo.\nIncidunt cupiditate corporis.", "https://picsum.photos/640/480/?image=949", "Mrs. Andrea White", 3, 2.0, 730, new DateTime(2022, 8, 1, 14, 20, 2, 600, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sequi molestiae sapiente sit non.", new DateTime(2023, 5, 13, 5, 37, 45, 626, DateTimeKind.Local).AddTicks(625), "Magni qui dolores dolorem.\nVoluptatum quisquam rerum suscipit cumque ab autem.\nFuga necessitatibus consequatur itaque quam optio ea non quo.\nQuaerat doloremque voluptas ipsam quam provident.", "https://picsum.photos/640/480/?image=100", "Mr. Laurie Barrows", 9, 1634, new DateTime(2022, 9, 22, 13, 1, 42, 135, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sint sint sed quidem animi et perspiciatis quod.", new DateTime(2023, 5, 13, 6, 38, 39, 645, DateTimeKind.Local).AddTicks(3690), "Est suscipit vel in aut et suscipit.", "https://picsum.photos/640/480/?image=1080", "Dr. Maxine Rath", 9, 3.0, 1867, new DateTime(2022, 12, 20, 22, 29, 53, 537, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolore non ab quis numquam velit quis molestiae vel.", new DateTime(2023, 5, 13, 3, 2, 7, 369, DateTimeKind.Local).AddTicks(2900), "Nulla consequatur voluptas totam natus vel voluptatem.", "https://picsum.photos/640/480/?image=858", "Mr. Earnest Ullrich", 9, 5.0, 1795, new DateTime(2022, 10, 1, 19, 35, 26, 232, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolores veniam voluptatibus impedit.", new DateTime(2023, 5, 13, 2, 51, 7, 888, DateTimeKind.Local).AddTicks(2443), "Officiis fugiat dolorem ad exercitationem a.", "https://picsum.photos/640/480/?image=46", "Mrs. Myra Waelchi", 7, 1.0, 1381, new DateTime(2022, 8, 6, 4, 17, 16, 521, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et illum et fugiat aspernatur vitae error consectetur et.", new DateTime(2023, 5, 13, 4, 45, 53, 863, DateTimeKind.Local).AddTicks(4219), "Reiciendis sit architecto exercitationem neque ipsa cum ratione temporibus.", "https://picsum.photos/640/480/?image=621", "Terence Graham I", 2.0, 1553, new DateTime(2023, 3, 11, 20, 28, 25, 332, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Facere quia et.", new DateTime(2023, 5, 13, 9, 38, 39, 881, DateTimeKind.Local).AddTicks(5760), "Et exercitationem cumque dolorem autem vero.\nVeniam et inventore quo deleniti non ut alias totam accusantium.\nSaepe sint voluptatem quo ex ratione.\nQui animi repellat aut eligendi dolore.\nVitae voluptas vitae culpa itaque.", "https://picsum.photos/640/480/?image=233", "Miss Jane Price", 10, 5.0, 2216, new DateTime(2022, 5, 20, 6, 6, 42, 503, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ducimus quo quibusdam qui sunt repellendus.", new DateTime(2023, 5, 13, 11, 1, 42, 439, DateTimeKind.Local).AddTicks(1820), "Omnis ullam odio.\nNemo repudiandae unde.\nTempore commodi officia occaecati ipsum.\nOdit laudantium repellat modi et ullam impedit nobis ut.", "https://picsum.photos/640/480/?image=868", "Dr. Delia Homenick", 5, 2.0, 674, new DateTime(2022, 8, 7, 17, 4, 42, 555, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laboriosam explicabo commodi quos.", new DateTime(2023, 5, 13, 7, 59, 48, 136, DateTimeKind.Local).AddTicks(9618), "Impedit omnis est.\nEt asperiores sint officia qui nam consequatur perspiciatis.", "https://picsum.photos/640/480/?image=948", "Scott Carroll V", 2, 1767, new DateTime(2022, 9, 17, 3, 28, 25, 956, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas aut nihil et.", new DateTime(2023, 5, 13, 6, 51, 18, 965, DateTimeKind.Local).AddTicks(9257), "Ut labore expedita et doloremque itaque.\nQuo consectetur repudiandae sed in.\nVitae pariatur velit vero rerum velit vitae.\nQuod hic modi natus eum dolores.\nArchitecto tenetur corporis.", "https://picsum.photos/640/480/?image=468", "Wanda Sauer Jr.", 4.0, 1465, new DateTime(2022, 10, 7, 0, 17, 23, 555, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit autem cumque et quia.", new DateTime(2023, 5, 13, 5, 50, 33, 239, DateTimeKind.Local).AddTicks(9445), "Veniam sed sed omnis reiciendis aut.", "https://picsum.photos/640/480/?image=870", "Dr. Bill Legros", 1, 2.0, 1102, new DateTime(2022, 8, 2, 10, 12, 32, 388, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem omnis veniam quis et.", new DateTime(2023, 5, 13, 10, 39, 58, 103, DateTimeKind.Local).AddTicks(1895), "Beatae culpa aspernatur consequuntur ipsa est aut ad.\nAsperiores et est architecto qui consequatur adipisci et nesciunt dolorum.\nDelectus laudantium voluptatem vel dolor est sed.", "https://picsum.photos/640/480/?image=331", "David Brekke III", 10, 4.0, 2343, new DateTime(2022, 9, 5, 10, 36, 40, 224, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui ullam adipisci.", new DateTime(2023, 5, 13, 13, 11, 56, 828, DateTimeKind.Local).AddTicks(1296), "Culpa reprehenderit libero labore quaerat.", "https://picsum.photos/640/480/?image=577", "Rafael Waelchi MD", 5, 1.0, 1277, new DateTime(2022, 5, 19, 10, 11, 10, 548, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et sint quia et rerum quod rerum.", new DateTime(2023, 5, 12, 18, 18, 2, 450, DateTimeKind.Local).AddTicks(416), "Magni aut nihil nam atque pariatur voluptatem ex.\nEt quos et nobis nostrum totam commodi pariatur enim rem.\nReiciendis quae consequatur temporibus ipsam ex.\nItaque iste minus reprehenderit natus possimus placeat et ut.", "https://picsum.photos/640/480/?image=464", "Mr. Sylvia Rippin", 4, 974, new DateTime(2023, 3, 4, 2, 9, 30, 940, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ullam repellat et doloribus iusto ipsum.", new DateTime(2023, 5, 13, 0, 54, 46, 325, DateTimeKind.Local).AddTicks(3470), "Delectus et asperiores nisi maiores et amet.", "https://picsum.photos/640/480/?image=737", "Mrs. Salvatore Cole", 2.0, 1178, new DateTime(2022, 12, 6, 13, 2, 38, 217, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dignissimos magnam minima dolorum rem.", new DateTime(2023, 5, 13, 17, 29, 22, 184, DateTimeKind.Local).AddTicks(4332), "Omnis veritatis cupiditate magni.\nQuia nisi voluptas omnis laudantium dolor et similique quas autem.\nUt reprehenderit dolorem.", "https://picsum.photos/640/480/?image=964", "Mr. Lucille Thiel", 6, 4.0, 2116, new DateTime(2023, 1, 20, 18, 46, 40, 720, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Doloribus et qui placeat mollitia consectetur qui.", new DateTime(2023, 5, 13, 3, 11, 1, 250, DateTimeKind.Local).AddTicks(5308), "Qui corrupti laudantium eum deserunt voluptatibus.\nOfficiis ut quis a.\nQuasi quos sed et quia sed inventore dolor laudantium.", "https://picsum.photos/640/480/?image=21", "Ms. Crystal Rowe", 3, 4.0, 2412, new DateTime(2023, 4, 15, 0, 59, 7, 433, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Neque aut sit repellat quia maiores ducimus molestiae doloribus et.", new DateTime(2023, 5, 13, 6, 54, 52, 153, DateTimeKind.Local).AddTicks(8267), "Excepturi cupiditate voluptatem nisi et quas quo delectus dolore.\nEt natus recusandae sit voluptas.\nIpsam rerum veritatis est recusandae qui nostrum enim.\nEveniet magnam ducimus.\nSit et omnis adipisci dolore asperiores perferendis.", "https://picsum.photos/640/480/?image=686", "Mr. Cecelia Williamson", 4, 2.0, 796, new DateTime(2022, 11, 1, 16, 51, 29, 932, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quod enim et.", new DateTime(2023, 5, 13, 11, 31, 55, 99, DateTimeKind.Local).AddTicks(4071), "Explicabo quidem sed vel qui adipisci quibusdam et.\nUt culpa doloribus quo assumenda deleniti libero sed quia.\nUt qui quo aut.\nEst similique corporis tenetur.\nAliquam impedit sed unde quis at adipisci.", "https://picsum.photos/640/480/?image=96", "Arturo Collier DDS", 5, 4.0, 2388, new DateTime(2022, 11, 26, 20, 36, 22, 263, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis pariatur sequi ipsa qui maiores doloremque fugiat alias.", new DateTime(2023, 5, 13, 14, 51, 6, 252, DateTimeKind.Local).AddTicks(7149), "Quae ea delectus doloremque sit dolorum vel.\nQuos soluta reiciendis qui.\nMolestias optio quae eius asperiores corrupti cupiditate voluptatem ab.\nDolorem ea est error adipisci nostrum.\nAliquid delectus quibusdam rerum sed consequatur eius.", "https://picsum.photos/640/480/?image=592", "Brandy Prosacco Jr.", 10, 608, new DateTime(2022, 8, 30, 1, 34, 16, 77, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit natus aliquam sapiente.", new DateTime(2023, 5, 13, 14, 13, 53, 584, DateTimeKind.Local).AddTicks(823), "Magnam iusto asperiores a et itaque tempore.\nEa voluptatibus aut voluptatem voluptates molestiae ducimus fugiat veritatis.\nQuis voluptas qui maxime ipsum.\nOmnis omnis quasi repellat nemo tenetur rerum architecto est.\nQuidem rerum natus consectetur vel dolorem.", "https://picsum.photos/640/480/?image=553", "Cody West DVM", 2, 2.0, 1951, new DateTime(2023, 4, 7, 19, 11, 41, 470, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Accusantium placeat ut minima qui aut itaque amet.", new DateTime(2023, 5, 13, 11, 59, 27, 319, DateTimeKind.Local).AddTicks(4887), "Blanditiis minus accusantium debitis sit et et at.\nDolor tempore ratione ipsa nobis eos amet distinctio.\nNemo iure omnis fugit aut.\nDicta iusto dolores quas nisi dolorum.\nEt qui culpa odio assumenda laudantium perspiciatis.", "https://picsum.photos/640/480/?image=119", "Ruth Goodwin IV", 2, 1226, new DateTime(2022, 10, 25, 11, 6, 29, 78, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iste error consequatur est assumenda et.", new DateTime(2023, 5, 12, 21, 24, 25, 238, DateTimeKind.Local).AddTicks(7819), "Ab aspernatur sunt minus id.\nVoluptas nihil nihil.\nQuia labore autem dolore officia tempora ut.\nTempore quia velit ex quis optio accusamus quia.\nBlanditiis labore adipisci magnam omnis voluptates.", "https://picsum.photos/640/480/?image=478", "Minnie Bernhard Jr.", 10, 1489, new DateTime(2022, 5, 26, 21, 23, 35, 337, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestiae corporis omnis ratione reprehenderit nobis dignissimos corporis.", new DateTime(2023, 5, 12, 22, 16, 11, 609, DateTimeKind.Local).AddTicks(6441), "Consequatur sequi et beatae magnam animi qui nulla.\nOmnis aut labore occaecati rerum voluptatum similique dolores.\nPraesentium est rem nulla sit.\nTenetur voluptatem tenetur at.", "https://picsum.photos/640/480/?image=975", "Willie Dooley DVM", 1.0, 2136, new DateTime(2022, 8, 6, 8, 18, 40, 482, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Maiores omnis quod id omnis ut animi voluptas.", new DateTime(2023, 5, 13, 4, 9, 58, 16, DateTimeKind.Local).AddTicks(2247), "Necessitatibus voluptatem nostrum adipisci facilis nesciunt explicabo ea fugit.\nAt occaecati non molestias ducimus fugiat tempora nesciunt.\nRerum sed suscipit enim beatae totam.\nQuod est voluptas doloribus qui quis in.", "https://picsum.photos/640/480/?image=652", "Mrs. Curtis Cronin", 2, 3.0, 1984, new DateTime(2022, 11, 9, 9, 4, 30, 401, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dicta aspernatur architecto error at facere quis porro ut voluptas.", new DateTime(2023, 5, 13, 14, 24, 47, 939, DateTimeKind.Local).AddTicks(3336), "Harum quibusdam modi.\nExercitationem aut qui quam quis quis.", "https://picsum.photos/640/480/?image=737", "Ms. Ryan Schowalter", 3, 5.0, 1286, new DateTime(2023, 2, 22, 12, 33, 51, 396, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quae inventore et voluptas nam vero cupiditate tempora.", new DateTime(2023, 5, 12, 21, 24, 27, 573, DateTimeKind.Local).AddTicks(5070), "Unde vero voluptatem voluptatum sit nihil aliquid veritatis numquam.\nVoluptatem nam perspiciatis est in cupiditate debitis non.\nQuo possimus iste.", "https://picsum.photos/640/480/?image=407", "Ms. Ray Botsford", 3, 3.0, 1102, new DateTime(2023, 3, 19, 15, 48, 25, 407, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Amet nisi amet eum nulla quae autem est accusamus sed.", new DateTime(2023, 5, 13, 5, 14, 7, 485, DateTimeKind.Local).AddTicks(8865), "Commodi et qui sint facilis et amet.\nLaboriosam dicta quis voluptas temporibus.\nVero illum repellendus sunt fuga quis.", "https://picsum.photos/640/480/?image=601", "Vicki Prosacco DDS", 1, 867, new DateTime(2023, 1, 29, 17, 36, 58, 890, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit eaque velit cum voluptatem officiis quidem optio dolores maiores.", new DateTime(2023, 5, 12, 21, 50, 5, 131, DateTimeKind.Local).AddTicks(5024), "Quia quasi tenetur eaque voluptas animi non.\nVoluptas deserunt voluptates corporis aliquam deserunt repellendus nesciunt quo.\nEt dignissimos omnis ullam vero accusantium porro ratione et sapiente.\nLaudantium quis quia.\nCupiditate neque aut omnis.", "https://picsum.photos/640/480/?image=1067", "Sally Hills DVM", 7, 5.0, 2031, new DateTime(2023, 3, 14, 19, 25, 38, 668, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Labore nemo voluptatem et beatae odio animi.", new DateTime(2023, 5, 13, 12, 52, 41, 411, DateTimeKind.Local).AddTicks(5767), "Quaerat dolorem eum voluptatibus impedit exercitationem quidem culpa velit omnis.\nAspernatur ullam ratione et blanditiis quaerat.\nLaboriosam et et.", "https://picsum.photos/640/480/?image=1004", "Ms. Glen Larkin", 9, 2.0, 1184, new DateTime(2022, 12, 27, 0, 45, 2, 921, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Provident ea voluptas esse non repellendus iste qui officia necessitatibus.", new DateTime(2023, 5, 13, 12, 44, 25, 660, DateTimeKind.Local).AddTicks(2922), "Atque modi aut rerum eum quis non ut fugit.\nExpedita rerum laborum hic.\nVoluptatem doloribus sapiente porro et magni magnam eos non.", "https://picsum.photos/640/480/?image=229", "Miss Dale Wilderman", 10, 3.0, 1106, new DateTime(2022, 10, 2, 22, 17, 3, 28, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed temporibus quasi consequatur at placeat harum et corporis at.", new DateTime(2023, 5, 13, 11, 42, 45, 379, DateTimeKind.Local).AddTicks(4113), "Mollitia repellendus doloribus mollitia vitae sequi voluptatem.\nQuasi modi iure illum et.\nNulla odit qui et aut quae.\nConsequatur id dolorem nulla odit eum illo nostrum.\nNecessitatibus sequi esse.", "https://picsum.photos/640/480/?image=638", "Dr. Marlene Pollich", 1, 766, new DateTime(2023, 4, 18, 17, 28, 51, 324, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui enim id sequi aspernatur.", new DateTime(2023, 5, 12, 19, 9, 27, 400, DateTimeKind.Local).AddTicks(227), "Voluptatem aut asperiores velit qui saepe.\nId delectus neque sit rem vero et recusandae perspiciatis accusamus.", "https://picsum.photos/640/480/?image=369", "Cody Stroman Jr.", 5, 3.0, 1185, new DateTime(2023, 3, 6, 7, 34, 18, 177, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit minus omnis fuga repudiandae omnis dolorum.", new DateTime(2023, 5, 13, 7, 6, 19, 469, DateTimeKind.Local).AddTicks(3353), "Eligendi ut aspernatur excepturi tenetur id ullam et.\nOmnis consequuntur eos.", "https://picsum.photos/640/480/?image=461", "Miss Gladys Legros", 5, 5.0, 827, new DateTime(2022, 11, 11, 22, 30, 59, 444, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Mollitia reiciendis eos ipsa deleniti et.", new DateTime(2023, 5, 13, 14, 26, 45, 512, DateTimeKind.Local).AddTicks(1467), "Totam esse est neque sit et id.", "https://picsum.photos/640/480/?image=654", "Lynette Donnelly MD", 4, 3.0, 1144, new DateTime(2022, 9, 28, 22, 43, 39, 351, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem temporibus voluptas repudiandae.", new DateTime(2023, 5, 13, 11, 35, 14, 928, DateTimeKind.Local).AddTicks(4953), "Vel corporis odio et consectetur et.\nDoloribus enim officia.", "https://picsum.photos/640/480/?image=234", "Fannie Mayer DVM", 2, 598, new DateTime(2022, 11, 7, 20, 20, 9, 281, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolorem aspernatur reiciendis.", new DateTime(2023, 5, 13, 1, 40, 46, 991, DateTimeKind.Local).AddTicks(1576), "Et labore totam voluptatum qui ullam itaque enim quae porro.\nEa voluptatem nesciunt.", "https://picsum.photos/640/480/?image=404", "Mr. Sue Ziemann", 8, 4.0, 2436, new DateTime(2022, 7, 9, 11, 35, 53, 592, DateTimeKind.Local).AddTicks(6079) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum molestias quia corporis rerum laudantium est necessitatibus et.", new DateTime(2023, 5, 13, 5, 1, 0, 631, DateTimeKind.Local).AddTicks(1963), "Sed omnis est et nam qui.", "https://picsum.photos/640/480/?image=549", "Ellen Considine II", 5.0, 1771, new DateTime(2022, 9, 14, 1, 0, 57, 659, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia dolor illum.", new DateTime(2023, 5, 12, 23, 24, 45, 701, DateTimeKind.Local).AddTicks(5529), "Nihil sequi quaerat voluptate cumque id aperiam adipisci quia molestias.", "https://picsum.photos/640/480/?image=384", "Miss Dave Boyle", 1565, new DateTime(2022, 10, 4, 22, 23, 25, 920, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Velit sint ut veniam quis.", new DateTime(2023, 5, 13, 13, 47, 24, 686, DateTimeKind.Local).AddTicks(776), "Vel doloremque quam praesentium eum labore quod aut.\nAlias et nihil.", "https://picsum.photos/640/480/?image=218", "Ms. Timmy Upton", 2, 4.0, 1949, new DateTime(2022, 11, 21, 13, 32, 45, 920, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut voluptas incidunt totam deserunt facilis in.", new DateTime(2023, 5, 13, 7, 59, 40, 85, DateTimeKind.Local).AddTicks(2957), "Error in porro veritatis eos non eos voluptatem et.\nQuia dolorem molestiae eligendi tenetur.\nMinus illum nulla voluptatem.", "https://picsum.photos/640/480/?image=195", "Mr. Patsy Kshlerin", 8, 1299, new DateTime(2023, 4, 11, 15, 11, 13, 937, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Accusamus fugiat nam sed cum sequi magnam distinctio culpa.", new DateTime(2023, 5, 13, 7, 29, 11, 121, DateTimeKind.Local).AddTicks(2709), "Et nam hic.\nLaudantium tempore quae voluptates in doloremque consequatur vel maiores.", "https://picsum.photos/640/480/?image=350", "Miss Merle Mohr", 6, 2487, new DateTime(2022, 11, 16, 19, 10, 44, 44, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et repudiandae voluptatem explicabo occaecati.", new DateTime(2023, 5, 13, 8, 55, 46, 584, DateTimeKind.Local).AddTicks(656), "Explicabo dignissimos non.\nAperiam aut quo voluptatem suscipit.\nIpsa qui veniam ratione quidem ut a.\nMolestias in dicta voluptas dolore omnis recusandae sapiente debitis sed.\nNon culpa error omnis officia vero amet.", "https://picsum.photos/640/480/?image=210", "Mr. Karen Wisozk", 1531, new DateTime(2022, 8, 18, 17, 29, 17, 485, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur vel repellat ullam omnis.", new DateTime(2023, 5, 13, 13, 56, 17, 939, DateTimeKind.Local).AddTicks(3248), "Quia voluptatum expedita fugit commodi voluptas.\nRem commodi voluptatem deleniti molestiae non accusantium perspiciatis dolorum.\nOfficia perferendis ut vel nostrum aut voluptatibus odio.", "https://picsum.photos/640/480/?image=202", "Velma Boehm I", 4, 5.0, 1489, new DateTime(2022, 7, 1, 17, 17, 55, 313, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sapiente natus aut nihil voluptates qui harum voluptatem deserunt.", new DateTime(2023, 5, 13, 9, 8, 34, 905, DateTimeKind.Local).AddTicks(629), "Qui ea perspiciatis enim odio consequuntur.\nIn eligendi magnam eos sunt nemo necessitatibus dolorem magni.\nQuia et quo suscipit facilis quam facilis.\nNulla praesentium asperiores id.", "https://picsum.photos/640/480/?image=406", "Miss Christy McClure", 1, 1852, new DateTime(2022, 12, 21, 5, 12, 3, 212, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nam repellat excepturi quam neque id deleniti et reprehenderit.", new DateTime(2023, 5, 13, 1, 7, 39, 832, DateTimeKind.Local).AddTicks(7679), "Minima fuga fugiat aspernatur.\nAut voluptas non dolores.\nItaque harum culpa modi assumenda.", "https://picsum.photos/640/480/?image=847", "Miss May Gottlieb", 9, 5.0, 1008, new DateTime(2023, 5, 10, 19, 27, 23, 93, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nam qui odio in labore harum.", new DateTime(2023, 5, 13, 9, 12, 59, 443, DateTimeKind.Local).AddTicks(2839), "Voluptatem consequatur accusamus et.\nDelectus voluptatem magnam est sint.\nFacere velit in excepturi voluptatum qui enim.", "https://picsum.photos/640/480/?image=736", "Tracy Nicolas V", 4, 5.0, 2130, new DateTime(2022, 7, 14, 6, 38, 37, 511, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum et quasi.", new DateTime(2023, 5, 13, 16, 11, 0, 553, DateTimeKind.Local).AddTicks(8935), "Cupiditate est neque sequi aspernatur ipsam.\nUt fuga amet consequatur molestias.", "https://picsum.photos/640/480/?image=683", "Alfred Sipes III", 1.0, 554, new DateTime(2022, 10, 23, 7, 46, 53, 201, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Corporis similique consequuntur libero voluptates fugiat qui adipisci et.", new DateTime(2023, 5, 13, 13, 7, 48, 823, DateTimeKind.Local).AddTicks(6813), "Necessitatibus voluptas sed ut qui temporibus est et eos.\nReiciendis quia aut.\nVoluptatibus consequatur amet adipisci enim.\nDistinctio est voluptatem.\nId consequuntur voluptate reiciendis quisquam rerum tenetur sit tempore.", "https://picsum.photos/640/480/?image=752", "George MacGyver DVM", 2, 1.0, 765, new DateTime(2023, 4, 4, 11, 2, 43, 900, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Pariatur laborum aut deserunt occaecati facere laborum qui.", new DateTime(2023, 5, 12, 23, 30, 16, 16, DateTimeKind.Local).AddTicks(9176), "Praesentium consequatur consequatur dolor maiores sed.\nUt est et recusandae.\nQuia iure enim veritatis reprehenderit est beatae exercitationem.\nNobis nisi quia pariatur sunt ut hic totam in.", "https://picsum.photos/640/480/?image=752", "Dr. Jodi Buckridge", 5.0, 2310, new DateTime(2023, 1, 8, 5, 47, 35, 213, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eius rem ea quibusdam repellendus est impedit enim ad.", new DateTime(2023, 5, 13, 8, 36, 11, 811, DateTimeKind.Local).AddTicks(7168), "Sit possimus inventore.\nDistinctio eveniet fuga saepe debitis iure aliquam at omnis veritatis.", "https://picsum.photos/640/480/?image=565", "Mrs. Ashley Gusikowski", 1, 1.0, 1440, new DateTime(2022, 6, 1, 17, 35, 44, 859, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Incidunt architecto corporis animi consequatur expedita occaecati voluptatem.", new DateTime(2023, 5, 13, 17, 38, 29, 20, DateTimeKind.Local).AddTicks(1229), "Ea a quo pariatur eveniet eos impedit voluptates quae doloremque.\nNihil nobis doloremque possimus non dolor et quidem.\nInventore dolores facere odit aut modi voluptas.\nOmnis dolores exercitationem corporis molestiae non atque id.", "https://picsum.photos/640/480/?image=242", "Miss Fernando Bruen", 7, 4.0, 760, new DateTime(2022, 8, 23, 20, 26, 46, 556, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsum eum ipsum qui dolor quas velit.", new DateTime(2023, 5, 13, 2, 37, 37, 281, DateTimeKind.Local).AddTicks(8368), "Laboriosam corrupti quae veritatis vitae eius nulla aut inventore.\nRem voluptatem eum possimus.\nSint et fugit ad debitis dolor quos voluptatem perspiciatis expedita.", "https://picsum.photos/640/480/?image=251", "Shawna Bernhard II", 9, 3.0, 995, new DateTime(2022, 10, 11, 23, 41, 52, 42, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Optio aut rem excepturi sint.", new DateTime(2023, 5, 13, 17, 30, 39, 587, DateTimeKind.Local).AddTicks(238), "Modi ea in beatae impedit aut quis voluptas praesentium.\nQuia officiis non pariatur reiciendis.", "https://picsum.photos/640/480/?image=485", "Mrs. Albert Franecki", 10, 3.0, 2176, new DateTime(2023, 4, 21, 6, 57, 54, 84, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Minima vitae minima odit dolorum possimus non.", new DateTime(2023, 5, 13, 17, 23, 50, 901, DateTimeKind.Local).AddTicks(9409), "Magni alias id hic nihil rerum praesentium deleniti.\nUt et voluptatibus dolore quod quasi voluptate.\nConsequatur vel dolores consequatur magnam non.\nMagni unde tempore libero quo et fugiat inventore.\nAliquam suscipit natus quas voluptates doloribus sit.", "https://picsum.photos/640/480/?image=488", "Jeremiah Ratke II", 6, 2.0, 1001, new DateTime(2022, 10, 22, 14, 54, 10, 830, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut dolor provident.", new DateTime(2023, 5, 12, 20, 24, 47, 234, DateTimeKind.Local).AddTicks(8818), "Doloribus minus aperiam est.\nAspernatur porro minus eius.", "https://picsum.photos/640/480/?image=196", "Mrs. Fredrick White", 4, 4.0, 1639, new DateTime(2022, 7, 28, 9, 40, 19, 551, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Labore voluptatem earum ea voluptatem.", new DateTime(2023, 5, 13, 0, 19, 14, 256, DateTimeKind.Local).AddTicks(7022), "Et consequatur amet vero quis eum nemo.\nVelit consequuntur ducimus esse.\nConsequatur consequatur ut esse est culpa aliquam.", "https://picsum.photos/640/480/?image=1035", "Ms. Jon Klocko", 8, 3.0, 688, new DateTime(2022, 6, 27, 5, 47, 49, 689, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "At ut iure praesentium quas omnis.", new DateTime(2023, 5, 13, 11, 19, 0, 421, DateTimeKind.Local).AddTicks(4991), "Optio molestias deleniti ipsum unde aut sed dicta.", "https://picsum.photos/640/480/?image=250", "Jana Mraz Jr.", 5, 1.0, 1856, new DateTime(2022, 6, 28, 23, 45, 52, 253, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui asperiores eius ut et eveniet placeat qui corporis.", new DateTime(2023, 5, 13, 15, 35, 14, 269, DateTimeKind.Local).AddTicks(6274), "Eligendi atque quam consequatur et eum quibusdam minima quisquam quam.\nCorporis asperiores molestiae sit molestiae aut ex ipsa aliquid ut.\nNon nobis aut molestiae.", "https://picsum.photos/640/480/?image=628", "Gilberto Auer DVM", 1, 4.0, 1086, new DateTime(2022, 6, 11, 4, 20, 17, 272, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et ut distinctio eius voluptas natus est voluptas dolorem.", new DateTime(2023, 5, 13, 7, 43, 28, 837, DateTimeKind.Local).AddTicks(2670), "Alias ex voluptate qui est iste.\nEt aliquam voluptatibus et dicta at voluptas qui facilis.\nLaboriosam sed ducimus molestiae.\nNostrum voluptatem qui.\nAut quam a vel magni laboriosam molestias eos consequatur.", "https://picsum.photos/640/480/?image=531", "Teresa Blick III", 9, 3.0, 1706, new DateTime(2023, 1, 14, 9, 6, 37, 43, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aliquam magnam tempora ducimus.", new DateTime(2023, 5, 13, 5, 1, 8, 921, DateTimeKind.Local).AddTicks(7711), "Enim earum nulla.\nNon soluta reprehenderit qui fugit.", "https://picsum.photos/640/480/?image=942", "Dr. Jared Emmerich", 7, 2.0, 2079, new DateTime(2022, 10, 19, 0, 12, 44, 878, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Perspiciatis error autem quaerat sint adipisci laboriosam.", new DateTime(2023, 5, 13, 11, 17, 11, 43, DateTimeKind.Local).AddTicks(9634), "Suscipit nostrum odio.\nQuo et alias voluptates ullam facere.\nQuo vitae vel.\nAut voluptate cum iure.", "https://picsum.photos/640/480/?image=917", "Miss Sue Nikolaus", 4, 2.0, 1646, new DateTime(2023, 2, 12, 18, 13, 27, 848, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ad veritatis officia ut.", new DateTime(2023, 5, 13, 5, 39, 29, 560, DateTimeKind.Local).AddTicks(3624), "Ut et officia omnis possimus.\nPossimus et aut natus voluptatum eius est ex doloribus.\nVeniam dolores assumenda vel in enim atque commodi et voluptatem.\nAutem aut odit quis consequuntur deleniti.\nAut mollitia eum aspernatur repellendus veniam ut rem dolor non.", "https://picsum.photos/640/480/?image=696", "Larry Lemke I", 6, 1535, new DateTime(2023, 5, 1, 7, 33, 51, 919, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut sequi velit.", new DateTime(2023, 5, 13, 16, 45, 19, 838, DateTimeKind.Local).AddTicks(6898), "Provident fugiat suscipit quo maiores omnis temporibus ab et non.", "https://picsum.photos/640/480/?image=549", "Toni Funk III", 10, 2.0, 538, new DateTime(2022, 9, 25, 3, 50, 27, 54, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Illo similique veritatis quibusdam exercitationem beatae.", new DateTime(2023, 5, 13, 5, 10, 15, 210, DateTimeKind.Local).AddTicks(9703), "Labore et vero et unde non.\nDolore qui dignissimos dolor at.\nIpsam rerum dolor dignissimos.\nEsse optio error aut ut saepe ipsa iusto quia nemo.", "https://picsum.photos/640/480/?image=146", "Mrs. Carla Windler", 3, 1.0, 1418, new DateTime(2022, 9, 23, 23, 17, 32, 392, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Id dolores et ab reiciendis similique et eveniet laboriosam qui.", new DateTime(2023, 5, 13, 3, 39, 5, 331, DateTimeKind.Local).AddTicks(686), "Libero ratione corrupti amet ut harum omnis.\nVero iure repudiandae consequatur iure.\nVeritatis vel sed quas odit molestiae qui dolorum.", "https://picsum.photos/640/480/?image=675", "Ms. Antonia Orn", 4, 1.0, 2361, new DateTime(2022, 5, 27, 19, 54, 31, 233, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Reiciendis aut quisquam animi soluta quae enim.", new DateTime(2023, 5, 12, 21, 17, 5, 106, DateTimeKind.Local).AddTicks(1377), "Omnis exercitationem reiciendis odit adipisci et dolorem et.\nUllam veniam voluptas cum magni non animi provident.", "https://picsum.photos/640/480/?image=123", "Dr. Pamela Smith", 9, 1.0, 830, new DateTime(2023, 2, 10, 23, 57, 27, 420, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ducimus libero quam.", new DateTime(2023, 5, 13, 15, 32, 7, 200, DateTimeKind.Local).AddTicks(7325), "Et saepe repellendus.\nDicta quaerat nesciunt possimus excepturi accusantium deserunt nihil rerum omnis.\nNisi fuga id aspernatur et ea dolorem sunt.\nIste quis tempore voluptatem hic odio reiciendis molestiae.", "https://picsum.photos/640/480/?image=193", "Cameron Olson Sr.", 6, 5.0, 1057, new DateTime(2023, 3, 17, 17, 59, 15, 691, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Labore animi quia libero eum atque quasi accusantium.", new DateTime(2023, 5, 13, 10, 7, 5, 201, DateTimeKind.Local).AddTicks(4012), "Magnam alias illo tenetur.\nSed pariatur aliquid fugit quas tempore in in.\nConsequatur officia molestiae officia porro.\nSed voluptate accusamus libero ut id maxime sed.\nLaborum sunt adipisci omnis eligendi est rerum.", "https://picsum.photos/640/480/?image=841", "May Wiza I", 5, 3.0, 523, new DateTime(2022, 9, 27, 23, 7, 24, 761, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et asperiores blanditiis itaque.", new DateTime(2023, 5, 12, 22, 45, 18, 465, DateTimeKind.Local).AddTicks(210), "Ut temporibus voluptatum perspiciatis placeat fugiat facere culpa aut rerum.\nSint est natus eum consequatur.\nRepellat est fuga quod molestias itaque velit.\nAperiam dolore corrupti eveniet minus mollitia occaecati.\nRatione et natus quis optio quas sed id consequatur ut.", "https://picsum.photos/640/480/?image=884", "Mr. Dexter Hirthe", 2, 3.0, 1606, new DateTime(2023, 1, 4, 6, 8, 10, 213, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut asperiores commodi quisquam sed.", new DateTime(2023, 5, 13, 12, 38, 6, 899, DateTimeKind.Local).AddTicks(8460), "Quas occaecati nemo numquam earum maxime hic molestiae.\nVoluptate enim accusantium explicabo ut.\nCorporis ipsum et.", "https://picsum.photos/640/480/?image=149", "Miss Robin Abshire", 2.0, 656, new DateTime(2022, 12, 4, 18, 35, 38, 681, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Autem et voluptatem non magni itaque itaque maxime.", new DateTime(2023, 5, 13, 12, 7, 27, 250, DateTimeKind.Local).AddTicks(1347), "Libero quam repellendus quod.\nSed atque quis eos.", "https://picsum.photos/640/480/?image=760", "Dr. Brad Harvey", 7, 5.0, 531, new DateTime(2022, 12, 15, 9, 55, 28, 22, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis voluptates porro quisquam consectetur quo sunt tenetur.", new DateTime(2023, 5, 13, 3, 5, 43, 53, DateTimeKind.Local).AddTicks(6864), "In inventore vitae.\nDolor neque magni eligendi ea tenetur impedit.\nExpedita ut molestias incidunt sint minus molestiae consequatur sed.", "https://picsum.photos/640/480/?image=767", "Courtney Wunsch V", 5, 5.0, 2107, new DateTime(2022, 6, 29, 14, 37, 24, 332, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Vitae omnis numquam.", new DateTime(2023, 5, 13, 17, 13, 11, 127, DateTimeKind.Local).AddTicks(2898), "Quas consequatur distinctio corrupti quo ipsum doloremque harum sint.\nA numquam saepe.\nEt saepe ea qui quo distinctio dignissimos minus.\nEum aut quia debitis et.", "https://picsum.photos/640/480/?image=62", "Mr. Mitchell Dickens", 6, 2.0, 1755, new DateTime(2023, 4, 5, 20, 20, 51, 444, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui dolores expedita ut voluptatem.", new DateTime(2023, 5, 13, 8, 14, 41, 38, DateTimeKind.Local).AddTicks(1715), "Consequatur modi modi voluptatum ab cumque aliquam ad.\nVeniam quo fugit eos.\nInventore molestiae eligendi velit ducimus praesentium est ex.\nSimilique numquam minima qui.", "https://picsum.photos/640/480/?image=242", "Arlene Gutkowski IV", 7, 2.0, 1737, new DateTime(2022, 6, 17, 7, 9, 6, 926, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est neque et incidunt nesciunt consequatur delectus placeat dolorem.", new DateTime(2023, 5, 13, 15, 0, 14, 770, DateTimeKind.Local).AddTicks(5203), "Eius non fugit.\nDignissimos reiciendis et quos voluptas saepe ratione quo assumenda.", "https://picsum.photos/640/480/?image=785", "Gwen Denesik V", 5, 5.0, 582, new DateTime(2022, 10, 1, 21, 52, 56, 106, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Vitae voluptas magnam ut nostrum et amet accusantium omnis.", new DateTime(2023, 5, 13, 15, 10, 35, 790, DateTimeKind.Local).AddTicks(341), "Culpa eligendi dolor est.\nExplicabo animi ullam.", "https://picsum.photos/640/480/?image=624", "Miss Derrick Becker", 1, 1.0, 1408, new DateTime(2023, 2, 13, 6, 30, 57, 639, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et consectetur expedita nihil eligendi repudiandae suscipit ea.", new DateTime(2023, 5, 13, 14, 39, 39, 703, DateTimeKind.Local).AddTicks(5921), "Vel est at.\nIpsa voluptas accusantium.", "https://picsum.photos/640/480/?image=908", "Harvey Kuhic III", 3, 3.0, 2395, new DateTime(2022, 5, 30, 19, 26, 41, 350, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Explicabo quae est.", new DateTime(2023, 5, 13, 1, 57, 49, 938, DateTimeKind.Local).AddTicks(3361), "Deleniti non sed quae.\nVoluptatem illo reprehenderit et aut harum porro incidunt voluptas.", "https://picsum.photos/640/480/?image=846", "Miss Luther McKenzie", 10, 4.0, 1044, new DateTime(2022, 12, 29, 4, 5, 58, 979, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Error veritatis nihil rem iste.", new DateTime(2023, 5, 13, 3, 25, 52, 143, DateTimeKind.Local).AddTicks(5643), "Perferendis aut dignissimos.\nCumque et fuga est.\nEius voluptatum aut qui.\nCum enim qui nulla voluptates totam.\nNemo optio quisquam est doloremque consectetur sint labore dolor.", "https://picsum.photos/640/480/?image=101", "Carroll Collier II", 2.0, 2314, new DateTime(2022, 7, 7, 20, 39, 46, 691, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et placeat quo.", new DateTime(2023, 5, 12, 20, 51, 38, 996, DateTimeKind.Local).AddTicks(7919), "Eum ratione quo repellendus eos quae ea maiores.\nTemporibus dolorem fugit error ducimus odio et veniam quo.\nInventore voluptas quam voluptas et.\nEveniet suscipit eaque ut.\nEt temporibus facere sint.", "https://picsum.photos/640/480/?image=838", "Mr. James Stamm", 10, 5.0, 1545, new DateTime(2023, 2, 17, 11, 28, 44, 543, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nesciunt deleniti fugit accusamus possimus provident temporibus consequatur error rerum.", new DateTime(2023, 5, 13, 17, 5, 5, 541, DateTimeKind.Local).AddTicks(3832), "Ut a quam facere blanditiis.\nQuis in ratione assumenda.\nVoluptatem repudiandae tenetur aut eius totam est ratione consectetur autem.", "https://picsum.photos/640/480/?image=222", "Ms. Hannah Armstrong", 6, 2.0, 2303, new DateTime(2022, 6, 8, 14, 57, 3, 276, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolorem sunt ut.", new DateTime(2023, 5, 12, 22, 18, 17, 755, DateTimeKind.Local).AddTicks(9656), "Cumque molestias vitae tempore accusantium sed cum unde aut voluptas.\nExpedita sed repudiandae veniam officiis dolores aut hic inventore.\nMinus eum ut sapiente fugiat dolorum odio nihil.\nOfficia deleniti deleniti consequatur consequuntur voluptatibus et.", "https://picsum.photos/640/480/?image=909", "Miss Theodore Gerlach", 5, 1.0, 731, new DateTime(2023, 3, 16, 17, 18, 8, 709, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quo eum enim.", new DateTime(2023, 5, 13, 7, 6, 41, 95, DateTimeKind.Local).AddTicks(9416), "Accusantium optio et possimus illo molestiae aut.", "https://picsum.photos/640/480/?image=128", "Jessie Ledner PhD", 3, 967, new DateTime(2022, 8, 18, 21, 17, 0, 916, DateTimeKind.Local).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut repudiandae ut iure quo nam aut illo consequatur.", new DateTime(2023, 5, 13, 4, 39, 57, 428, DateTimeKind.Local).AddTicks(1649), "Suscipit quo cupiditate autem et non.\nNisi molestiae dolor repudiandae tempore quia.\nEarum quis facere.\nAspernatur fugit non nulla repudiandae saepe aliquid modi mollitia perspiciatis.\nReiciendis aliquam quasi vero.", "https://picsum.photos/640/480/?image=440", "Miss Greg Maggio", 7, 764, new DateTime(2022, 11, 10, 23, 57, 21, 349, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et quia quo atque deserunt aut.", new DateTime(2023, 5, 12, 20, 42, 10, 45, DateTimeKind.Local).AddTicks(2221), "Non quia eius.", "https://picsum.photos/640/480/?image=778", "Minnie Wolf Sr.", 10, 4.0, 1796, new DateTime(2022, 11, 25, 3, 22, 14, 375, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellat rerum molestiae quibusdam praesentium.", new DateTime(2023, 5, 13, 6, 52, 7, 681, DateTimeKind.Local).AddTicks(5411), "Voluptatem fugit sed quisquam voluptatem et tempore quo similique est.\nAutem modi ut.\nNam blanditiis non ut.\nEst fugiat et qui.", "https://picsum.photos/640/480/?image=931", "Steve Lynch DVM", 5, 4.0, 711, new DateTime(2022, 10, 5, 9, 54, 52, 611, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum et repudiandae perspiciatis commodi veritatis.", new DateTime(2023, 5, 13, 3, 39, 1, 804, DateTimeKind.Local).AddTicks(9038), "Tempora qui soluta.", "https://picsum.photos/640/480/?image=966", "Betty Crona DDS", 6, 1.0, 1434, new DateTime(2022, 6, 28, 20, 0, 18, 789, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iste voluptatem eveniet.", new DateTime(2023, 5, 13, 7, 23, 21, 274, DateTimeKind.Local).AddTicks(4140), "Quas voluptatem accusamus sit est sunt laboriosam modi aut sapiente.\nPerferendis soluta voluptatem modi aut suscipit et sit.", "https://picsum.photos/640/480/?image=1077", "Mrs. Inez Bosco", 1541, new DateTime(2022, 6, 18, 17, 14, 18, 204, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nostrum aliquam voluptatem impedit ut totam.", new DateTime(2023, 5, 13, 5, 56, 33, 460, DateTimeKind.Local).AddTicks(8400), "In suscipit perspiciatis maxime sed ut dolores consequatur vel.", "https://picsum.photos/640/480/?image=483", "Mrs. Nathaniel Watsica", 10, 1.0, 2405, new DateTime(2022, 10, 4, 12, 29, 34, 692, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Veniam quas harum voluptatum quam doloremque et tenetur est.", new DateTime(2023, 5, 13, 17, 0, 18, 108, DateTimeKind.Local).AddTicks(1051), "Voluptas id velit.\nQui mollitia excepturi veniam dolores eveniet impedit fuga quo aut.\nNemo et est reiciendis molestias dolores.\nDucimus possimus est nihil consequatur sapiente explicabo sint eaque quo.\nRerum saepe culpa consequatur dolores molestiae ipsum ex.", "https://picsum.photos/640/480/?image=1040", "Ada Moen III", 10, 3.0, 1473, new DateTime(2022, 9, 4, 8, 11, 41, 938, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut est accusamus atque repellat consequatur.", new DateTime(2023, 5, 13, 14, 38, 44, 951, DateTimeKind.Local).AddTicks(3082), "Voluptates incidunt sint nostrum sit dolorem minima repellendus.\nEarum dolore voluptatem.\nQuod corporis sapiente corrupti consequuntur quo.\nSapiente eos temporibus aliquam architecto qui totam officiis eligendi.", "https://picsum.photos/640/480/?image=371", "Miss Luis O'Keefe", 5, 2.0, 1017, new DateTime(2022, 7, 1, 1, 32, 58, 644, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sapiente deserunt dolor.", new DateTime(2023, 5, 13, 10, 47, 51, 700, DateTimeKind.Local).AddTicks(6206), "Labore inventore consequuntur velit alias sit odio numquam delectus quo.\nSit necessitatibus cum inventore beatae et itaque.\nUt aliquam omnis dolorem ab.\nAspernatur blanditiis nam a qui velit expedita facere dolores asperiores.\nAtque blanditiis inventore aperiam et sed ducimus assumenda eligendi fugiat.", "https://picsum.photos/640/480/?image=841", "Carole Robel MD", 3.0, 1103, new DateTime(2023, 4, 13, 8, 8, 32, 996, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Illo non accusamus maxime vitae temporibus.", new DateTime(2023, 5, 13, 2, 16, 23, 50, DateTimeKind.Local).AddTicks(1963), "Impedit doloremque blanditiis rerum eos est vero praesentium.\nQuos porro consequatur dolorum eligendi.\nEt aspernatur reprehenderit sed sed neque porro.\nAperiam reprehenderit explicabo tenetur aspernatur qui voluptatem ut iusto ea.\nVoluptate adipisci et libero nesciunt eius distinctio et qui.", "https://picsum.photos/640/480/?image=19", "Erika Yost III", 10, 3.0, 2461, new DateTime(2022, 9, 9, 9, 43, 45, 433, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Deleniti qui optio sed ut cumque est at repellendus ut.", new DateTime(2023, 5, 13, 15, 48, 40, 336, DateTimeKind.Local).AddTicks(6035), "Et quod et sed aut eos voluptas tempore quisquam.\nVitae assumenda qui optio ut aspernatur laboriosam explicabo.\nEum qui ullam sit laboriosam est.", "https://picsum.photos/640/480/?image=273", "Karla Gulgowski DDS", 6, 1.0, 2460, new DateTime(2022, 11, 2, 0, 14, 12, 499, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "At sunt mollitia non ullam earum laudantium aut nobis amet.", new DateTime(2023, 5, 13, 1, 18, 25, 727, DateTimeKind.Local).AddTicks(8667), "Corporis ad voluptates.\nLibero aliquam eligendi atque.\nQuasi facere id labore pariatur animi ducimus omnis ex.", "https://picsum.photos/640/480/?image=1053", "Lila Quigley MD", 4.0, 1589, new DateTime(2023, 3, 5, 10, 59, 58, 174, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quos consectetur voluptatem consequatur ab aut odit.", new DateTime(2023, 5, 12, 23, 34, 49, 312, DateTimeKind.Local).AddTicks(6988), "Cum quod similique labore autem eum veritatis enim.\nRepellendus doloribus et aut voluptatem quia aperiam.", "https://picsum.photos/640/480/?image=628", "Lori Bernhard MD", 2, 4.0, 2427, new DateTime(2023, 4, 3, 20, 6, 38, 358, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsam veritatis sint inventore consequatur modi modi.", new DateTime(2023, 5, 13, 16, 24, 12, 903, DateTimeKind.Local).AddTicks(1312), "Dolorem doloribus ut ut accusantium asperiores ut voluptatem corrupti.\nEst exercitationem quasi quia.\nRecusandae suscipit iure est.", "https://picsum.photos/640/480/?image=423", "Miss Lynda Tremblay", 6, 4.0, 1265, new DateTime(2022, 10, 6, 15, 52, 12, 771, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui aspernatur non.", new DateTime(2023, 5, 13, 15, 45, 37, 518, DateTimeKind.Local).AddTicks(9999), "Dolorum error nostrum laboriosam eaque sunt nulla.\nConsequatur sed hic omnis cum placeat sunt.\nProvident qui provident iusto sed dolor iusto corporis.\nNumquam rem voluptatem eaque quia ipsam animi iusto.", "https://picsum.photos/640/480/?image=658", "Johnathan Collins Jr.", 2, 4.0, 2001, new DateTime(2022, 7, 5, 18, 31, 53, 612, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et mollitia delectus.", new DateTime(2023, 5, 12, 19, 47, 43, 303, DateTimeKind.Local).AddTicks(3658), "Voluptas quis et quo ut et aut.\nEum consequuntur veritatis eius sit dignissimos.\nNisi ea fuga enim vero optio autem sit expedita maxime.\nEt delectus ullam ducimus quia est eligendi sit suscipit et.\nLabore dolores sequi et ut.", "https://picsum.photos/640/480/?image=806", "Eduardo Jakubowski DDS", 537, new DateTime(2023, 3, 25, 19, 49, 58, 501, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laboriosam dolor quasi excepturi iusto quod ex reprehenderit minima tempore.", new DateTime(2023, 5, 13, 8, 53, 36, 238, DateTimeKind.Local).AddTicks(4660), "Doloribus in qui perspiciatis laudantium doloribus aliquam quis et.", "https://picsum.photos/640/480/?image=904", "Leslie Roob MD", 10, 3.0, 2125, new DateTime(2022, 11, 2, 20, 8, 30, 62, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis ex id tempore iure ut esse dolor.", new DateTime(2023, 5, 13, 0, 51, 43, 613, DateTimeKind.Local).AddTicks(4167), "Et iusto sed.\nDucimus quam et deserunt non iure asperiores qui.\nSed necessitatibus est molestias mollitia mollitia et alias nemo.", "https://picsum.photos/640/480/?image=125", "Miss Woodrow Kassulke", 7, 2.0, 2396, new DateTime(2023, 5, 10, 9, 45, 8, 645, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolor magni sint perspiciatis.", new DateTime(2023, 5, 13, 15, 19, 21, 735, DateTimeKind.Local).AddTicks(5663), "Deserunt voluptatem sequi.\nEnim eaque accusantium ut minima et.\nSed velit dolores earum dolores soluta repudiandae in.\nUt voluptatem aut esse sint.\nDolor quae officiis in rerum deserunt quisquam.", "https://picsum.photos/640/480/?image=901", "Mrs. Mike Stoltenberg", 1.0, 1202, new DateTime(2022, 10, 20, 14, 51, 59, 36, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem sunt et eos.", new DateTime(2023, 5, 13, 16, 41, 46, 383, DateTimeKind.Local).AddTicks(8248), "Nemo et dignissimos ipsa.\nNihil beatae id veritatis.\nEt nulla quisquam quasi.", "https://picsum.photos/640/480/?image=195", "Mr. Kimberly Johns", 8, 2.0, 614, new DateTime(2022, 12, 25, 14, 22, 18, 289, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed ratione necessitatibus id dignissimos temporibus rem.", new DateTime(2023, 5, 13, 11, 36, 25, 646, DateTimeKind.Local).AddTicks(5941), "Et voluptatem occaecati at est quod et.", "https://picsum.photos/640/480/?image=937", "Mr. Sylvester Donnelly", 9, 1716, new DateTime(2022, 7, 2, 5, 2, 29, 268, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Maiores enim deserunt atque quia quia eius quaerat.", new DateTime(2023, 5, 13, 7, 32, 16, 455, DateTimeKind.Local).AddTicks(5659), "Corrupti sunt eos.\nQuibusdam ea vel facere debitis possimus at quibusdam consequatur aut.\nFugiat repudiandae et officiis quia rerum voluptas.\nSed perferendis ut est harum illo architecto doloremque sit.\nDolorum impedit rem praesentium beatae.", "https://picsum.photos/640/480/?image=1076", "Miss Blake Bogisich", 10, 4.0, 1877, new DateTime(2022, 10, 17, 23, 57, 10, 656, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas accusamus ducimus dignissimos et vel nemo perferendis beatae.", new DateTime(2023, 5, 12, 21, 28, 20, 125, DateTimeKind.Local).AddTicks(5814), "Molestiae veritatis possimus consequatur necessitatibus delectus officia.\nTemporibus debitis aut adipisci eum consequatur.", "https://picsum.photos/640/480/?image=74", "Alberto Block III", 2, 862, new DateTime(2023, 4, 28, 22, 5, 38, 454, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cupiditate dolorem qui saepe fuga ut et corrupti.", new DateTime(2023, 5, 13, 13, 43, 37, 583, DateTimeKind.Local).AddTicks(5462), "Cum et consectetur dicta nesciunt.\nFacere repellendus eum assumenda placeat quaerat iste molestiae eum.\nSequi est repudiandae molestiae vitae.", "https://picsum.photos/640/480/?image=684", "Jackie Kuhlman PhD", 1.0, 1352, new DateTime(2022, 8, 1, 12, 28, 4, 297, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consectetur ad harum est impedit veniam.", new DateTime(2023, 5, 12, 20, 42, 57, 974, DateTimeKind.Local).AddTicks(6835), "Itaque labore et a aut iure error.\nVoluptatum perspiciatis officia quaerat rerum ut nisi fugit.\nQuae aperiam maiores quisquam sit.\nIllo quasi dolores consequuntur facilis repudiandae asperiores.", "https://picsum.photos/640/480/?image=828", "Camille Schroeder III", 10, 5.0, 2039, new DateTime(2023, 3, 17, 21, 30, 41, 139, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptate in sit sapiente sunt ipsam.", new DateTime(2023, 5, 13, 0, 13, 50, 386, DateTimeKind.Local).AddTicks(7720), "Tempora ut optio commodi sed fugiat magni omnis.\nDolores fugit praesentium voluptatum quod enim.\nEt omnis at id aut.", "https://picsum.photos/640/480/?image=692", "Paul Klein II", 8, 5.0, 605, new DateTime(2022, 10, 23, 17, 18, 33, 952, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Perspiciatis nisi consequuntur qui.", new DateTime(2023, 5, 12, 21, 24, 45, 778, DateTimeKind.Local).AddTicks(2331), "Dignissimos ipsum veritatis ipsum veritatis enim maiores dolore et dolores.\nUnde quia inventore nesciunt ut earum assumenda.\nAccusamus doloribus deserunt ut consequuntur quisquam aut fugit mollitia dicta.\nCumque placeat quia quasi aperiam earum tempore.\nEa voluptatem numquam et.", "https://picsum.photos/640/480/?image=806", "Janie Pfannerstill II", 7, 1.0, 1377, new DateTime(2023, 4, 27, 21, 7, 33, 691, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut maiores reprehenderit quam dolores tempore quia illum pariatur.", new DateTime(2023, 5, 13, 11, 43, 43, 586, DateTimeKind.Local).AddTicks(6869), "Nulla ut incidunt velit unde occaecati saepe nemo.\nNobis id nulla corporis ad illum.\nQuae molestias odio quibusdam deserunt fugiat recusandae repellendus voluptas.\nVel necessitatibus doloribus sit est nobis.\nSimilique ad eaque vero.", "https://picsum.photos/640/480/?image=142", "Angel Morar V", 2376, new DateTime(2023, 3, 27, 5, 46, 50, 710, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Culpa modi velit perspiciatis voluptas at aspernatur minus et.", new DateTime(2023, 5, 13, 10, 31, 49, 795, DateTimeKind.Local).AddTicks(9814), "Quis rerum reprehenderit repudiandae quidem debitis quis laborum.\nSuscipit numquam eum quis magnam vitae.\nSoluta nihil rem repudiandae totam omnis non et nihil amet.", "https://picsum.photos/640/480/?image=1024", "Angelo Skiles I", 8, 3.0, 988, new DateTime(2023, 2, 1, 10, 4, 10, 905, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cumque dignissimos nesciunt.", new DateTime(2023, 5, 13, 9, 14, 42, 752, DateTimeKind.Local).AddTicks(6479), "Minima libero omnis quos et repudiandae fugit aut ab.\nNihil dolore asperiores nihil.\nAdipisci praesentium qui aliquam.", "https://picsum.photos/640/480/?image=251", "Miss Celia Hegmann", 4, 5.0, 1514, new DateTime(2022, 5, 25, 8, 35, 28, 674, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tenetur iste repellendus eveniet.", new DateTime(2023, 5, 13, 10, 36, 15, 622, DateTimeKind.Local).AddTicks(4160), "Velit vero consectetur.", "https://picsum.photos/640/480/?image=1065", "Mrs. Stephen Gleason", 4, 2.0, 2191, new DateTime(2023, 2, 21, 2, 40, 36, 69, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Labore soluta aut aut fuga.", new DateTime(2023, 5, 13, 5, 13, 57, 70, DateTimeKind.Local).AddTicks(746), "Eaque sunt molestiae molestiae rem perspiciatis dignissimos.\nLaborum temporibus odit ab ad autem aut excepturi nihil commodi.\nBeatae molestias officia sit.\nSunt et minus rerum aut quasi blanditiis perspiciatis vero.\nTempore exercitationem eos rerum voluptatibus.", "https://picsum.photos/640/480/?image=385", "Van Grady Sr.", 5, 1.0, 1880, new DateTime(2023, 1, 3, 9, 32, 19, 99, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas voluptas sunt impedit quia dolorem.", new DateTime(2023, 5, 13, 9, 5, 56, 894, DateTimeKind.Local).AddTicks(1149), "Illum est perspiciatis architecto in.", "https://picsum.photos/640/480/?image=163", "Mr. Santiago Bosco", 1, 4.0, 1667, new DateTime(2022, 6, 14, 19, 43, 2, 403, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cumque id voluptatibus sit cupiditate.", new DateTime(2023, 5, 13, 0, 53, 17, 812, DateTimeKind.Local).AddTicks(8218), "Aut aspernatur impedit quos.\nEos vero architecto rerum deserunt molestiae.\nIncidunt molestiae omnis suscipit minima illum aliquid consequatur.", "https://picsum.photos/640/480/?image=784", "Victor Davis IV", 8, 5.0, 1411, new DateTime(2023, 1, 6, 19, 34, 57, 598, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Expedita nihil voluptate dolor quae odit.", new DateTime(2023, 5, 13, 12, 43, 8, 219, DateTimeKind.Local).AddTicks(4932), "Sint velit qui debitis ipsum eum atque.\nSit dolorem fugit perspiciatis adipisci mollitia consequatur.", "https://picsum.photos/640/480/?image=1049", "Ramona Miller DDS", 4, 1099, new DateTime(2022, 8, 5, 15, 39, 32, 524, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Totam aliquam quo.", new DateTime(2023, 5, 13, 13, 18, 31, 561, DateTimeKind.Local).AddTicks(3215), "Nisi alias ipsa.", "https://picsum.photos/640/480/?image=294", "Ms. Delia Champlin", 1.0, 1409, new DateTime(2022, 6, 19, 21, 59, 21, 978, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et provident quia pariatur molestiae iure consectetur.", new DateTime(2023, 5, 13, 10, 43, 23, 806, DateTimeKind.Local).AddTicks(3695), "Assumenda molestiae quas voluptatem dolor et nulla.", "https://picsum.photos/640/480/?image=942", "Mrs. Rachel Rice", 3.0, 1447, new DateTime(2023, 3, 28, 0, 58, 36, 517, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nihil alias aut deserunt ut omnis at.", new DateTime(2023, 5, 13, 0, 46, 27, 464, DateTimeKind.Local).AddTicks(995), "Eum neque facilis.\nItaque dolorem ducimus fugiat in beatae.\nEt nesciunt commodi nihil repudiandae unde.\nCulpa harum ut accusantium minima totam culpa eius laboriosam id.", "https://picsum.photos/640/480/?image=67", "Jake Abshire DDS", 10, 3.0, 1614, new DateTime(2022, 11, 5, 18, 6, 21, 38, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Soluta laborum rerum ducimus est.", new DateTime(2023, 5, 13, 5, 48, 54, 728, DateTimeKind.Local).AddTicks(9960), "Commodi corrupti voluptas ut omnis nostrum iure.\nExcepturi error adipisci maiores doloribus dicta fugiat enim quo veniam.\nOmnis dolorum eaque facere.\nQuibusdam occaecati quo asperiores quis omnis est.", "https://picsum.photos/640/480/?image=790", "Misty Lesch IV", 6, 1.0, 1630, new DateTime(2023, 3, 24, 16, 29, 26, 91, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Non maiores omnis et.", new DateTime(2023, 5, 13, 1, 3, 31, 896, DateTimeKind.Local).AddTicks(5617), "Est soluta saepe error explicabo nulla est perspiciatis vitae.\nDebitis sunt perspiciatis et nam est aut est quis dolorum.", "https://picsum.photos/640/480/?image=793", "Christian Bechtelar DDS", 9, 5.0, 1747, new DateTime(2023, 1, 30, 17, 8, 28, 905, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eos aut aperiam necessitatibus tempora perferendis explicabo quis.", new DateTime(2023, 5, 13, 15, 36, 19, 112, DateTimeKind.Local).AddTicks(802), "Nesciunt excepturi sapiente eligendi.\nEst magnam quia numquam velit ea voluptas.\nAd dolorum quia consequatur est harum ex amet sed vel.", "https://picsum.photos/640/480/?image=848", "Frederick Hegmann Sr.", 8, 1.0, 1244, new DateTime(2023, 2, 4, 16, 52, 9, 244, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et molestias voluptatem quae cum.", new DateTime(2023, 5, 13, 0, 16, 52, 445, DateTimeKind.Local).AddTicks(7707), "Commodi ex ea beatae possimus pariatur quia.\nEligendi corporis voluptatem et eum sed.\nConsequuntur ut incidunt quia in repellendus illo expedita.\nMaiores qui temporibus repellendus ut.\nIure sint reprehenderit dolore quibusdam architecto neque molestiae consequuntur.", "https://picsum.photos/640/480/?image=685", "Dr. Gilbert Bednar", 1, 4.0, 742, new DateTime(2022, 5, 15, 13, 5, 20, 451, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed minima qui veniam placeat et laborum possimus.", new DateTime(2023, 5, 13, 11, 14, 36, 329, DateTimeKind.Local).AddTicks(8092), "Fuga dolores velit facilis aut nemo nihil quos.\nRepudiandae omnis provident deleniti laudantium quo architecto asperiores mollitia delectus.\nDolores architecto est voluptatem saepe eum molestiae voluptas.", "https://picsum.photos/640/480/?image=503", "Robin Powlowski V", 1.0, 1096, new DateTime(2023, 3, 9, 12, 31, 52, 196, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eius eveniet est nobis dignissimos vel et incidunt.", new DateTime(2023, 5, 13, 14, 28, 16, 372, DateTimeKind.Local).AddTicks(8853), "Ut ipsam adipisci omnis.\nLabore aperiam et facilis dolor repellendus molestiae.", "https://picsum.photos/640/480/?image=199", "Ricardo Wilkinson II", 3, 3.0, 1026, new DateTime(2022, 7, 25, 20, 9, 46, 378, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut sed ea pariatur saepe eum autem repellendus perferendis.", new DateTime(2023, 5, 13, 10, 58, 26, 952, DateTimeKind.Local).AddTicks(7292), "Rem quos consequuntur.\nSit asperiores fugiat assumenda.\nAnimi et mollitia eius perferendis alias consequuntur sunt vero.\nQuaerat illum quod molestiae sit eos eius temporibus.\nEst et vitae veniam reiciendis sunt occaecati.", "https://picsum.photos/640/480/?image=457", "Cameron Hettinger MD", 6, 3.0, 1190, new DateTime(2022, 10, 4, 22, 0, 0, 403, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sapiente atque sequi ullam reprehenderit est.", new DateTime(2023, 5, 12, 21, 43, 23, 674, DateTimeKind.Local).AddTicks(835), "Repellendus ut vel officia odit autem quia nemo iste et.\nAd assumenda vitae molestiae.", "https://picsum.photos/640/480/?image=939", "Larry Harris II", 1, 5.0, 1664, new DateTime(2022, 7, 26, 15, 26, 39, 260, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur ad dolorem nihil explicabo maxime aliquid voluptatibus.", new DateTime(2023, 5, 13, 6, 6, 58, 428, DateTimeKind.Local).AddTicks(1804), "Ut dolor neque ab illo consequatur quis unde voluptatibus iste.\nPerferendis ut voluptas quo repudiandae quia commodi.\nMolestiae voluptates asperiores a.\nAlias itaque assumenda enim earum culpa accusamus iure.", "https://picsum.photos/640/480/?image=164", "Wilma Hilll II", 9, 1.0, 2367, new DateTime(2023, 4, 3, 0, 7, 8, 849, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eveniet est mollitia.", new DateTime(2023, 5, 13, 17, 16, 55, 675, DateTimeKind.Local).AddTicks(4212), "Possimus rerum aperiam et maxime.\nSuscipit et nisi non beatae.\nConsectetur eum iure odio tenetur.\nIncidunt sed et cumque et corporis quibusdam saepe id.", "https://picsum.photos/640/480/?image=1033", "Ms. Corey Muller", 3, 2.0, 1694, new DateTime(2022, 6, 9, 11, 45, 8, 625, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia vel aliquid.", new DateTime(2023, 5, 13, 9, 19, 40, 343, DateTimeKind.Local).AddTicks(4402), "Veritatis et qui ea maxime ut voluptatem mollitia ipsum non.\nEa sunt autem minima.\nRepudiandae blanditiis eum quis aliquam quisquam.\nOmnis ducimus est nam repudiandae et ut corrupti labore.\nSint quam perferendis nesciunt at occaecati et eos aspernatur.", "https://picsum.photos/640/480/?image=1030", "Dr. Marvin D'Amore", 3, 3.0, 1274, new DateTime(2023, 4, 13, 5, 21, 55, 293, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est placeat non.", new DateTime(2023, 5, 13, 8, 6, 31, 170, DateTimeKind.Local).AddTicks(8452), "Maxime fugit et cumque non voluptas ipsam id quasi et.\nIpsum qui occaecati et.\nIusto eum enim molestias ullam.\nQui totam provident voluptatem magni at et distinctio.", "https://picsum.photos/640/480/?image=0", "Mr. Terry Ziemann", 4.0, 854, new DateTime(2022, 7, 14, 21, 44, 43, 920, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Veritatis a assumenda alias sit quia voluptate aperiam aut libero.", new DateTime(2023, 5, 13, 14, 47, 4, 118, DateTimeKind.Local).AddTicks(8471), "Magni et dolorem modi.\nAut odit omnis at.\nRepudiandae est quia iusto maiores eum.", "https://picsum.photos/640/480/?image=76", "Miss Joanne Weimann", 10, 5.0, 1759, new DateTime(2022, 11, 29, 0, 9, 7, 133, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Autem iure in doloribus sint mollitia sed dicta.", new DateTime(2023, 5, 13, 7, 56, 28, 185, DateTimeKind.Local).AddTicks(8395), "Assumenda qui sunt repellat beatae deserunt reprehenderit voluptate explicabo.", "https://picsum.photos/640/480/?image=423", "Kimberly Weber I", 7, 1408, new DateTime(2023, 1, 24, 3, 31, 24, 361, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Minima omnis tenetur et et.", new DateTime(2023, 5, 13, 15, 17, 37, 147, DateTimeKind.Local).AddTicks(7293), "Ratione veniam et placeat tenetur.\nOptio quasi natus non totam.", "https://picsum.photos/640/480/?image=911", "Mrs. Guadalupe Abbott", 3, 4.0, 820, new DateTime(2022, 12, 21, 2, 24, 23, 846, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Non sit qui sint.", new DateTime(2023, 5, 13, 4, 36, 1, 384, DateTimeKind.Local).AddTicks(9039), "Sit voluptas sapiente explicabo necessitatibus vel ipsa dolores minima aut.\nSoluta deserunt et sed facere omnis vitae facere.\nNon dolor velit nihil tenetur.\nQui quas voluptas officiis voluptatem nisi reiciendis sed.\nEligendi sit accusamus eum sequi aut vitae sed.", "https://picsum.photos/640/480/?image=269", "Miss Heidi Okuneva", 10, 4.0, 1103, new DateTime(2023, 3, 30, 6, 58, 52, 579, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Earum cum hic sed nihil velit nihil et.", new DateTime(2023, 5, 12, 20, 45, 0, 260, DateTimeKind.Local).AddTicks(5264), "Unde recusandae dicta sint.\nOmnis similique nesciunt fugiat.", "https://picsum.photos/640/480/?image=133", "Mrs. Tara Kovacek", 4.0, 1082, new DateTime(2022, 5, 21, 6, 9, 11, 924, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Soluta tempora nemo.", new DateTime(2023, 5, 13, 4, 43, 57, 354, DateTimeKind.Local).AddTicks(7461), "Sit consequatur dignissimos.\nDicta quis aut iusto.\nUt dignissimos tenetur debitis vel.\nBeatae repellendus possimus adipisci.\nEt labore cupiditate ut optio culpa unde corrupti.", "https://picsum.photos/640/480/?image=795", "Lester Lebsack II", 6, 1.0, 1959, new DateTime(2023, 1, 23, 8, 15, 38, 449, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cupiditate alias qui autem asperiores.", new DateTime(2023, 5, 13, 12, 15, 59, 452, DateTimeKind.Local).AddTicks(408), "Tempora aut repellendus incidunt sit recusandae ullam possimus voluptate voluptas.", "https://picsum.photos/640/480/?image=64", "Dr. Laurie Heaney", 6, 5.0, 1204, new DateTime(2023, 1, 24, 13, 26, 13, 238, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Animi sequi velit beatae eligendi qui ad illum tempore non.", new DateTime(2023, 5, 13, 14, 5, 54, 673, DateTimeKind.Local).AddTicks(8853), "Et repudiandae fuga voluptatibus aut aut nulla quia sit alias.\nQuod impedit maiores dolores delectus ut.\nNon ea et consequatur distinctio.", "https://picsum.photos/640/480/?image=367", "Mr. Rosalie Douglas", 9, 4.0, 1035, new DateTime(2023, 3, 8, 18, 59, 29, 149, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut voluptatem aut totam eaque id.", new DateTime(2023, 5, 12, 21, 9, 37, 765, DateTimeKind.Local).AddTicks(8306), "Consequatur odio laborum omnis sed accusantium consequuntur.\nOccaecati earum pariatur in molestias fuga non est pariatur voluptatem.", "https://picsum.photos/640/480/?image=294", "Sandy Olson Jr.", 2, 1.0, 1508, new DateTime(2023, 4, 24, 20, 6, 25, 150, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quos non aut quibusdam error cupiditate quia velit.", new DateTime(2023, 5, 13, 3, 40, 2, 902, DateTimeKind.Local).AddTicks(5780), "Fugit provident repellendus sit reprehenderit est cum et laboriosam assumenda.\nConsectetur minus iusto quia magnam quas.", "https://picsum.photos/640/480/?image=719", "Elbert Schultz PhD", 10, 1154, new DateTime(2022, 5, 15, 17, 50, 40, 198, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Earum cupiditate amet reiciendis asperiores perferendis corporis.", new DateTime(2023, 5, 12, 20, 11, 2, 884, DateTimeKind.Local).AddTicks(6114), "Fugiat voluptas ratione dolore alias eos ad sapiente sit dolorem.", "https://picsum.photos/640/480/?image=90", "Madeline Gleichner MD", 1, 4.0, 869, new DateTime(2023, 2, 27, 18, 23, 7, 70, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sapiente ullam rerum a perspiciatis consequatur nemo.", new DateTime(2023, 5, 12, 18, 44, 21, 419, DateTimeKind.Local).AddTicks(2989), "Minus possimus qui perferendis.\nTemporibus ipsum sint impedit sint facilis facere doloribus dolor.\nPossimus officia sequi voluptatibus architecto qui sunt vitae.\nIure sunt neque natus odit.", "https://picsum.photos/640/480/?image=938", "Chris Kunde V", 3, 2.0, 921, new DateTime(2022, 8, 31, 10, 34, 21, 898, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laborum tempora quasi voluptatem ut.", new DateTime(2023, 5, 13, 4, 43, 50, 206, DateTimeKind.Local).AddTicks(1301), "Quis eligendi omnis.", "https://picsum.photos/640/480/?image=515", "Erica Jenkins Jr.", 10, 4.0, 964, new DateTime(2023, 4, 4, 4, 13, 10, 340, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Perspiciatis velit in fugit labore.", new DateTime(2023, 5, 13, 17, 27, 16, 629, DateTimeKind.Local).AddTicks(3175), "Quas voluptate aut consequatur quaerat unde sapiente ratione.\nSoluta laudantium harum soluta molestiae distinctio quos qui non.", "https://picsum.photos/640/480/?image=395", "Mr. Jake Pagac", 8, 4.0, 1586, new DateTime(2023, 4, 27, 5, 54, 16, 183, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Fuga magni sint in ut nam in.", new DateTime(2023, 5, 13, 8, 11, 25, 846, DateTimeKind.Local).AddTicks(1207), "Cupiditate voluptates ut ad cumque deleniti est nulla.\nEnim maxime qui maiores qui asperiores et.\nQuibusdam perferendis in ut officiis eligendi illo dolor modi necessitatibus.\nQuis labore ipsam illum et enim beatae veritatis.\nNecessitatibus asperiores reiciendis asperiores vitae qui.", "https://picsum.photos/640/480/?image=59", "Traci Luettgen III", 2399, new DateTime(2022, 6, 11, 7, 5, 56, 104, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Officia minus est nemo dolor ipsa.", new DateTime(2023, 5, 13, 2, 42, 40, 698, DateTimeKind.Local).AddTicks(5401), "Ut porro sapiente.\nSed aut eligendi beatae delectus illo.\nAt ipsa occaecati error.", "https://picsum.photos/640/480/?image=574", "Betsy Fay MD", 2, 1.0, 792, new DateTime(2023, 4, 22, 20, 17, 19, 197, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestiae perspiciatis vel dolorem natus rerum minima.", new DateTime(2023, 5, 13, 7, 0, 12, 304, DateTimeKind.Local).AddTicks(2402), "Distinctio et sit accusantium sint maiores qui ab accusantium.\nQui amet eum animi pariatur suscipit maiores fugiat vel animi.\nFacere incidunt rerum facere et architecto et harum.\nSaepe illo omnis et autem.\nNumquam architecto et ipsa.", "https://picsum.photos/640/480/?image=92", "Franklin Strosin Sr.", 1891, new DateTime(2022, 7, 28, 21, 41, 39, 262, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laborum suscipit autem dolore ex sit natus.", new DateTime(2023, 5, 13, 1, 1, 9, 308, DateTimeKind.Local).AddTicks(1869), "Asperiores dignissimos perspiciatis atque praesentium officia ipsum.\nNostrum aliquam nihil id pariatur aut quam aspernatur sequi.\nDelectus illo ut quaerat eaque asperiores laudantium non fugit.\nError eos officia et non ratione dolorum sit vel.", "https://picsum.photos/640/480/?image=843", "Moses Altenwerth Sr.", 2, 2.0, 1041, new DateTime(2022, 6, 16, 18, 28, 8, 139, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui ut ut voluptatem illum voluptatem.", new DateTime(2023, 5, 13, 5, 56, 33, 677, DateTimeKind.Local).AddTicks(3613), "Et earum aperiam incidunt autem nobis et corporis aut numquam.", "https://picsum.photos/640/480/?image=148", "Jan Blick DVM", 8, 2.0, 988, new DateTime(2023, 4, 8, 7, 21, 9, 165, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Adipisci soluta qui ut cupiditate dolores explicabo est.", new DateTime(2023, 5, 13, 5, 30, 12, 111, DateTimeKind.Local).AddTicks(1633), "Quibusdam nesciunt architecto nihil sit.\nVelit non necessitatibus odit.\nAperiam eaque totam voluptate sed.", "https://picsum.photos/640/480/?image=898", "Mrs. Santiago Davis", 1, 1000, new DateTime(2022, 7, 23, 23, 32, 35, 346, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum adipisci tempora non voluptate et maiores accusamus.", new DateTime(2023, 5, 12, 19, 2, 32, 975, DateTimeKind.Local).AddTicks(2241), "At et asperiores.\nVoluptate ut voluptatem perspiciatis eum consectetur.", "https://picsum.photos/640/480/?image=166", "James Waters I", 5, 1344, new DateTime(2023, 1, 6, 0, 24, 22, 262, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Officiis qui a qui ut praesentium quis tempore.", new DateTime(2023, 5, 13, 9, 55, 19, 342, DateTimeKind.Local).AddTicks(7837), "Sed in saepe laboriosam iure ut voluptatem.\nEt debitis voluptatem et voluptates in autem numquam.\nSed voluptas quo soluta mollitia ipsum.\nDolor fugit magni tempora explicabo voluptatem fugiat.", "https://picsum.photos/640/480/?image=919", "Mr. Laverne Considine", 7, 4.0, 1402, new DateTime(2022, 12, 20, 6, 33, 43, 18, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempore saepe illo corrupti rerum.", new DateTime(2023, 5, 13, 6, 22, 13, 841, DateTimeKind.Local).AddTicks(7049), "Quia fugiat et.", "https://picsum.photos/640/480/?image=486", "Marty Hackett II", 3, 3.0, 2153, new DateTime(2023, 1, 24, 14, 41, 22, 554, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Reprehenderit autem nobis tempore asperiores.", new DateTime(2023, 5, 13, 6, 7, 5, 829, DateTimeKind.Local).AddTicks(1941), "Temporibus nemo est.\nLaboriosam minima sit.\nIpsam facere sed et.\nIusto sint necessitatibus voluptatem.", "https://picsum.photos/640/480/?image=452", "Mrs. Julian Powlowski", 5, 3.0, 599, new DateTime(2022, 5, 17, 3, 15, 12, 601, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Veritatis error qui et voluptatem suscipit.", new DateTime(2023, 5, 13, 5, 23, 57, 265, DateTimeKind.Local).AddTicks(8021), "Voluptatibus quasi optio recusandae ullam illo impedit excepturi saepe.\nQuidem dolores sint sed at cupiditate excepturi qui et.\nDebitis voluptatem consequatur quam est aliquam blanditiis error.", "https://picsum.photos/640/480/?image=150", "Mrs. Valerie Champlin", 3.0, 2195, new DateTime(2023, 4, 3, 8, 47, 31, 510, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est et rerum vel.", new DateTime(2023, 5, 13, 0, 1, 21, 618, DateTimeKind.Local).AddTicks(5356), "Officia ea dolorem illum natus suscipit.\nDolore doloribus quo expedita omnis molestiae.\nVeniam eveniet impedit voluptate magnam pariatur accusantium illum illum quod.\nNon fuga omnis cupiditate modi voluptas autem.\nSuscipit vero illum et qui.", "https://picsum.photos/640/480/?image=394", "Mrs. Evelyn Ferry", 2, 4.0, 2023, new DateTime(2023, 1, 29, 5, 3, 15, 825, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Excepturi temporibus quae ad officiis.", new DateTime(2023, 5, 13, 5, 1, 3, 805, DateTimeKind.Local).AddTicks(7739), "Doloribus deleniti corrupti voluptatem nihil qui commodi.\nTenetur et non incidunt.\nSit in ullam dolorem reiciendis et est aliquam rerum alias.\nQui quos sed sint enim at.", "https://picsum.photos/640/480/?image=507", "Francis Cummings I", 3, 1.0, 1110, new DateTime(2022, 7, 4, 12, 14, 1, 549, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolores itaque sapiente et rerum eum ipsam adipisci.", new DateTime(2023, 5, 13, 1, 9, 40, 667, DateTimeKind.Local).AddTicks(9214), "Voluptas et autem maiores maxime.\nPariatur unde est veritatis.\nDolor voluptatem temporibus.", "https://picsum.photos/640/480/?image=947", "Mrs. Eloise Williamson", 10, 4.0, 2028, new DateTime(2022, 6, 21, 0, 57, 5, 549, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Inventore inventore dolor qui commodi unde.", new DateTime(2023, 5, 12, 20, 35, 4, 813, DateTimeKind.Local).AddTicks(419), "Eaque autem est illum aut laboriosam natus quaerat sint.", "https://picsum.photos/640/480/?image=597", "Dr. Toni Padberg", 2, 1.0, 2469, new DateTime(2022, 6, 22, 10, 25, 49, 374, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quisquam dicta odit eius ea velit quaerat aut.", new DateTime(2023, 5, 13, 7, 27, 3, 651, DateTimeKind.Local).AddTicks(6792), "Consequatur fugit praesentium accusantium quasi et.\nFacilis laborum facere non.", "https://picsum.photos/640/480/?image=1", "Mr. Jasmine Champlin", 8, 3.0, 1600, new DateTime(2022, 5, 21, 3, 20, 20, 631, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur sed id facere et eveniet voluptas delectus.", new DateTime(2023, 5, 13, 0, 51, 27, 352, DateTimeKind.Local).AddTicks(1327), "Et dolorum voluptatem non.\nReiciendis sit magni eos.", "https://picsum.photos/640/480/?image=704", "Irene Roberts Jr.", 1, 3.0, 1555, new DateTime(2022, 8, 26, 14, 4, 1, 188, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Id et in aut ut et animi.", new DateTime(2023, 5, 13, 1, 57, 28, 222, DateTimeKind.Local).AddTicks(6784), "Magni illum nostrum.\nUt quam nam aliquid omnis et voluptas.\nDolore corporis dolores ipsam.", "https://picsum.photos/640/480/?image=662", "Ms. Kellie Corkery", 5, 2.0, 1264, new DateTime(2022, 6, 14, 10, 58, 42, 766, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Id omnis et consectetur accusamus omnis quis similique sit.", new DateTime(2023, 5, 13, 0, 45, 45, 946, DateTimeKind.Local).AddTicks(1030), "Qui facilis ut.\nUt fugiat tempora est quia quod voluptates fugiat.\nUt aut dolor occaecati reprehenderit tempora odit possimus est.\nEligendi et sit.", "https://picsum.photos/640/480/?image=189", "Emilio Marquardt DDS", 4.0, 2486, new DateTime(2023, 2, 16, 14, 6, 27, 778, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sunt consequuntur sunt.", new DateTime(2023, 5, 13, 11, 55, 19, 669, DateTimeKind.Local).AddTicks(3578), "Vel est molestiae occaecati accusantium quo quo.\nUt debitis ea.\nConsequatur dolorem hic.", "https://picsum.photos/640/480/?image=77", "Ms. Shannon Adams", 2.0, 2086, new DateTime(2022, 7, 1, 12, 0, 49, 378, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est veniam totam.", new DateTime(2023, 5, 13, 16, 6, 55, 307, DateTimeKind.Local).AddTicks(2530), "Maiores aspernatur nihil consectetur neque dignissimos amet odio.\nRepellat esse vero officiis minus excepturi porro.\nDeleniti alias aperiam ipsa velit dolor eveniet qui.\nQuod incidunt voluptatem similique et temporibus.", "https://picsum.photos/640/480/?image=85", "Mr. Sylvia McClure", 6, 3.0, 1522, new DateTime(2022, 11, 1, 3, 54, 59, 18, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Itaque inventore delectus illum vel facere et.", new DateTime(2023, 5, 12, 19, 33, 10, 326, DateTimeKind.Local).AddTicks(1693), "Sapiente aliquid blanditiis hic odio.\nMinima autem quibusdam repudiandae architecto et sed aut.\nFugit et eveniet aliquid ea vel quam fugit sit.\nPlaceat et qui ipsum unde voluptatem id et omnis.\nQui in aliquid.", "https://picsum.photos/640/480/?image=535", "Josh Dicki III", 1, 5.0, 1536, new DateTime(2022, 8, 29, 7, 31, 8, 972, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ex voluptatem ut ut corrupti blanditiis.", new DateTime(2023, 5, 13, 15, 25, 24, 775, DateTimeKind.Local).AddTicks(2482), "Voluptas omnis iste ut distinctio repudiandae facilis.\nMolestias cupiditate cupiditate quos consequatur accusamus cupiditate quam.\nConsequatur facere nesciunt dolores autem laboriosam veritatis dolorem.\nQui repudiandae unde et animi eveniet velit corrupti debitis impedit.\nIpsa et cum eum.", "https://picsum.photos/640/480/?image=258", "Stanley Morissette MD", 7, 1459, new DateTime(2022, 9, 9, 22, 8, 48, 478, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsum iure eum corrupti non ratione accusantium laboriosam.", new DateTime(2023, 5, 13, 2, 38, 50, 272, DateTimeKind.Local).AddTicks(1632), "Nemo delectus quasi vero aut sit quasi et cupiditate voluptatem.\nMolestias quod placeat nisi aspernatur.\nAtque nisi voluptatem.", "https://picsum.photos/640/480/?image=262", "Constance Bayer Jr.", 10, 1615, new DateTime(2022, 10, 15, 4, 44, 28, 544, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Alias sed veniam harum et cupiditate rerum omnis.", new DateTime(2023, 5, 13, 14, 4, 48, 402, DateTimeKind.Local).AddTicks(5717), "Quo voluptatem quis sed ex sunt.\nVoluptas delectus ducimus eos sit qui quam.\nPerspiciatis debitis laborum.", "https://picsum.photos/640/480/?image=973", "Mr. Violet Wintheiser", 4.0, 1595, new DateTime(2022, 9, 15, 10, 24, 28, 515, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nobis esse rerum et enim molestiae quis omnis delectus.", new DateTime(2023, 5, 13, 13, 15, 22, 905, DateTimeKind.Local).AddTicks(5382), "Et ut suscipit.\nEum velit ut rerum ducimus sed sequi quo.\nCulpa veritatis et rerum fuga laborum aut sit nemo.\nAb tenetur iusto repudiandae consequatur placeat molestias autem in laudantium.\nDeleniti officiis laborum vero libero quis voluptatem.", "https://picsum.photos/640/480/?image=768", "Thelma Sanford V", 8, 1.0, 1554, new DateTime(2022, 9, 13, 18, 6, 0, 889, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Non eum autem et amet consectetur occaecati commodi.", new DateTime(2023, 5, 12, 21, 38, 31, 12, DateTimeKind.Local).AddTicks(1609), "Atque quibusdam aspernatur aperiam molestiae quaerat.\nAtque officia ut nisi voluptatem rem.", "https://picsum.photos/640/480/?image=692", "Luke Hartmann V", 2, 5.0, 1183, new DateTime(2023, 3, 22, 10, 56, 6, 491, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem quia saepe consequatur porro quo sunt facilis tenetur.", new DateTime(2023, 5, 13, 9, 58, 25, 837, DateTimeKind.Local).AddTicks(5056), "Laudantium amet occaecati occaecati sit.\nCulpa ea consequuntur.\nDolorum aut et.\nAspernatur fuga amet adipisci nihil inventore quo.\nPerferendis ut impedit adipisci sed similique magni.", "https://picsum.photos/640/480/?image=331", "Arthur Goyette III", 4.0, 641, new DateTime(2022, 12, 18, 1, 6, 28, 234, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ex omnis ea quis optio sed.", new DateTime(2023, 5, 13, 4, 16, 27, 754, DateTimeKind.Local).AddTicks(6105), "Natus et nobis tempora est et officia esse.\nDoloremque eum et et aliquam iusto impedit nam officiis aliquid.\nRecusandae labore laudantium rerum dolorum ad nostrum pariatur ea.\nTemporibus ut nihil sunt quisquam assumenda nihil.", "https://picsum.photos/640/480/?image=993", "Ann Gutkowski MD", 2.0, 1989, new DateTime(2022, 8, 28, 16, 59, 38, 387, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum voluptatem voluptatem dolorem.", new DateTime(2023, 5, 13, 5, 10, 27, 520, DateTimeKind.Local).AddTicks(8203), "Aspernatur eius velit suscipit corporis quia praesentium et deserunt.\nEum omnis occaecati ipsam perspiciatis nostrum voluptatibus.\nQuia odio nam consequatur.\nDolorem asperiores quos.\nAtque eum voluptatem aut cumque omnis vel impedit.", "https://picsum.photos/640/480/?image=1004", "Bradford Stark PhD", 9, 4.0, 589, new DateTime(2023, 5, 9, 16, 43, 12, 447, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum nemo quod ut non accusamus incidunt magnam accusantium.", new DateTime(2023, 5, 12, 20, 5, 48, 26, DateTimeKind.Local).AddTicks(1994), "Perferendis voluptates dolore ullam repellendus.\nRepellat ratione aut ut consectetur.\nIste saepe voluptatem eligendi tenetur.", "https://picsum.photos/640/480/?image=453", "Bryan Considine MD", 8, 2190, new DateTime(2023, 1, 14, 8, 56, 8, 830, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum debitis dicta tempora ad a aut.", new DateTime(2023, 5, 13, 6, 6, 49, 431, DateTimeKind.Local).AddTicks(1189), "Officia qui et quis et ipsa nemo beatae dolore.\nAutem rerum laborum velit quisquam fugit vero vel.\nQuis vel id consequatur voluptas totam et sit.", "https://picsum.photos/640/480/?image=211", "Miss Beth Wilderman", 4.0, 1982, new DateTime(2022, 7, 14, 7, 51, 49, 440, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Minus qui nesciunt exercitationem repellat.", new DateTime(2023, 5, 13, 12, 12, 48, 231, DateTimeKind.Local).AddTicks(4372), "Unde voluptas tenetur voluptatibus ducimus.\nEarum assumenda nemo quasi explicabo.\nEt mollitia et.\nUnde odio esse qui.\nEarum quis soluta necessitatibus fugit excepturi molestiae aut eum.", "https://picsum.photos/640/480/?image=0", "Moses Nolan II", 5, 3.0, 789, new DateTime(2022, 5, 16, 23, 17, 43, 215, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Velit vero sapiente adipisci.", new DateTime(2023, 5, 13, 13, 28, 53, 780, DateTimeKind.Local).AddTicks(6848), "Earum animi at ducimus voluptas.", "https://picsum.photos/640/480/?image=617", "Mrs. Alma Gleichner", 9, 5.0, 1779, new DateTime(2023, 2, 17, 6, 4, 39, 619, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis deserunt totam.", new DateTime(2023, 5, 13, 5, 31, 58, 142, DateTimeKind.Local).AddTicks(1648), "Pariatur quas sit alias quisquam laboriosam sint accusamus.\nFugiat harum veritatis officia soluta.\nIn vel modi veritatis voluptatem ut nostrum.\nPossimus facere soluta odit et necessitatibus maxime rerum quasi amet.", "https://picsum.photos/640/480/?image=391", "Nettie Orn DVM", 1077, new DateTime(2022, 10, 21, 20, 55, 0, 595, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Provident dolorem officia expedita deserunt rerum accusantium rerum.", new DateTime(2023, 5, 12, 21, 51, 34, 291, DateTimeKind.Local).AddTicks(7655), "Rerum sit vel.\nVitae illo adipisci commodi perferendis adipisci aperiam iste non.", "https://picsum.photos/640/480/?image=747", "Gerardo Metz IV", 8, 4.0, 1111, new DateTime(2023, 2, 9, 20, 25, 47, 782, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laboriosam adipisci eius repellat et inventore.", new DateTime(2023, 5, 13, 9, 20, 15, 1, DateTimeKind.Local).AddTicks(8124), "Et non corporis et nihil totam commodi quam.\nMollitia voluptatum cumque consequatur ratione consequatur.\nSit sit accusamus est nam nihil a neque similique quod.", "https://picsum.photos/640/480/?image=525", "Darnell O'Reilly PhD", 2, 503, new DateTime(2022, 5, 20, 19, 41, 10, 718, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempora nam est molestias minima vitae consequatur assumenda ut.", new DateTime(2023, 5, 13, 13, 45, 32, 873, DateTimeKind.Local).AddTicks(4600), "Magnam sunt vero non ea qui.\nEius mollitia sunt tempore nisi.", "https://picsum.photos/640/480/?image=137", "Ms. Tonya Hahn", 4, 4.0, 1382, new DateTime(2022, 9, 28, 21, 29, 56, 309, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis et voluptatem eum quibusdam inventore aliquid voluptatem voluptates.", new DateTime(2023, 5, 13, 0, 54, 17, 294, DateTimeKind.Local).AddTicks(2744), "Odio quia culpa natus.", "https://picsum.photos/640/480/?image=293", "Miss Elias Boyle", 6, 2.0, 1931, new DateTime(2023, 2, 4, 7, 12, 45, 821, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Illum omnis temporibus minima quisquam modi laudantium aliquid similique.", new DateTime(2023, 5, 12, 22, 22, 42, 687, DateTimeKind.Local).AddTicks(7041), "Sit consectetur id neque et.\nVoluptates nostrum delectus aspernatur voluptatem et distinctio qui aut sunt.\nPraesentium harum optio possimus vitae repellat fugit et eius minus.", "https://picsum.photos/640/480/?image=772", "Mr. Elijah Skiles", 10, 1171, new DateTime(2022, 7, 30, 0, 4, 10, 857, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestias et officia consectetur eveniet.", new DateTime(2023, 5, 12, 23, 21, 22, 797, DateTimeKind.Local).AddTicks(3996), "Ex tempore a saepe totam autem quia est incidunt.\nConsequatur assumenda dolore cum quis vitae dignissimos minus amet.\nDolorem repellat ratione minima.", "https://picsum.photos/640/480/?image=717", "Franklin Goyette II", 3, 5.0, 1298, new DateTime(2023, 4, 16, 7, 4, 30, 506, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Suscipit quisquam perferendis rerum ipsum.", new DateTime(2023, 5, 13, 15, 16, 22, 178, DateTimeKind.Local).AddTicks(418), "Officia quia molestias in ipsa saepe asperiores enim repudiandae.\nDebitis dolorem illum.", "https://picsum.photos/640/480/?image=193", "Kristina Altenwerth Sr.", 7, 4.0, 1420, new DateTime(2022, 10, 6, 12, 30, 51, 772, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Fugiat eum in commodi sit.", new DateTime(2023, 5, 12, 22, 48, 7, 311, DateTimeKind.Local).AddTicks(925), "Ratione delectus rerum inventore eligendi ducimus et aperiam.\nSequi consequatur nobis consequatur.\nQuisquam et nulla ea rem et est alias atque.\nCorporis quod ullam voluptatem.\nOccaecati voluptas maxime dolores enim similique molestiae quo ut.", "https://picsum.photos/640/480/?image=8", "Noah Zieme IV", 4, 3.0, 1514, new DateTime(2023, 3, 5, 14, 58, 16, 294, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis cumque voluptatem reiciendis est quo et quia.", new DateTime(2023, 5, 13, 6, 46, 51, 661, DateTimeKind.Local).AddTicks(3286), "Error expedita eos non.\nSoluta dolorum omnis recusandae dolorem.\nAliquam doloremque ex deserunt.\nMollitia reiciendis sed voluptatem incidunt accusamus deserunt quia temporibus architecto.", "https://picsum.photos/640/480/?image=159", "Thelma Donnelly II", 3, 3.0, 1665, new DateTime(2023, 2, 3, 21, 25, 6, 174, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Vel consequatur ut dolores et modi alias expedita itaque hic.", new DateTime(2023, 5, 13, 3, 53, 17, 637, DateTimeKind.Local).AddTicks(1288), "Distinctio illo architecto sed ut consectetur.\nVoluptatem est similique.\nVoluptatem et et consequuntur autem.\nHic eos et aut qui voluptatem aut.", "https://picsum.photos/640/480/?image=736", "Neal Morissette MD", 1.0, 1314, new DateTime(2022, 7, 6, 14, 12, 6, 885, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Explicabo nemo excepturi aperiam aut asperiores voluptatem sunt molestiae quidem.", new DateTime(2023, 5, 13, 1, 11, 1, 395, DateTimeKind.Local).AddTicks(6032), "Aut voluptate ratione reprehenderit exercitationem.\nNatus atque illum.\nSit magni occaecati reprehenderit numquam voluptates.\nQui praesentium fugit autem debitis eum est.", "https://picsum.photos/640/480/?image=614", "Josefina Daugherty MD", 10, 5.0, 1056, new DateTime(2023, 3, 29, 23, 39, 24, 676, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit nulla corrupti accusamus.", new DateTime(2023, 5, 12, 18, 1, 17, 828, DateTimeKind.Local).AddTicks(8425), "Repellendus dolorem aut velit repellendus iure cupiditate est eligendi.\nAccusantium ea ut hic.", "https://picsum.photos/640/480/?image=645", "Randall Frami V", 8, 3.0, 2110, new DateTime(2022, 11, 14, 7, 13, 6, 637, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit deleniti velit omnis quaerat magnam.", new DateTime(2023, 5, 13, 7, 19, 19, 965, DateTimeKind.Local).AddTicks(5666), "Molestias voluptate et eius.\nEveniet aut eos.", "https://picsum.photos/640/480/?image=237", "Jenny Johns DDS", 1, 3.0, 766, new DateTime(2022, 11, 26, 13, 38, 54, 981, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia et consectetur asperiores.", new DateTime(2023, 5, 13, 3, 39, 2, 668, DateTimeKind.Local).AddTicks(9037), "Quibusdam labore vel.\nFacere incidunt quis quae ut aspernatur quia quod et porro.\nEt neque perferendis qui perspiciatis dolorum.\nArchitecto quae qui molestiae voluptate eum sit recusandae fugit.\nEst nisi ut vel ab facere.", "https://picsum.photos/640/480/?image=356", "Mr. Jeff Koelpin", 4, 4.0, 865, new DateTime(2022, 12, 27, 19, 43, 53, 253, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Illum aspernatur neque beatae harum et iste qui.", new DateTime(2023, 5, 12, 20, 11, 11, 939, DateTimeKind.Local).AddTicks(9524), "Ea voluptatem rem dolores maiores dignissimos odit culpa neque laborum.\nOfficiis distinctio ratione odit nihil aspernatur ex odit et.", "https://picsum.photos/640/480/?image=1000", "Alice Kutch MD", 2, 5.0, 1086, new DateTime(2022, 7, 3, 11, 15, 8, 430, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Architecto quod necessitatibus delectus consequatur deserunt libero in.", new DateTime(2023, 5, 13, 2, 22, 14, 299, DateTimeKind.Local).AddTicks(6679), "Ipsa tempore dolore commodi est possimus.\nVeritatis nesciunt totam.", "https://picsum.photos/640/480/?image=565", "Kenny Goodwin Jr.", 1, 2.0, 1491, new DateTime(2022, 10, 26, 8, 4, 28, 234, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quam qui sed magni maiores repudiandae officiis et odit consectetur.", new DateTime(2023, 5, 12, 20, 1, 21, 582, DateTimeKind.Local).AddTicks(4409), "Corrupti omnis laboriosam.\nQui eaque in cumque.\nMinima error ducimus est.\nUt aut minus eos accusamus non voluptatum qui nobis.\nNobis et ut aperiam quas.", "https://picsum.photos/640/480/?image=943", "Darin Torp DVM", 2062, new DateTime(2022, 5, 24, 23, 24, 34, 542, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quisquam et sint fuga.", new DateTime(2023, 5, 13, 12, 50, 52, 511, DateTimeKind.Local).AddTicks(1789), "Laboriosam itaque non.", "https://picsum.photos/640/480/?image=573", "Viola Gerhold V", 9, 4.0, 785, new DateTime(2022, 12, 10, 7, 9, 18, 564, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quaerat quis odit omnis esse nisi.", new DateTime(2023, 5, 12, 19, 23, 12, 27, DateTimeKind.Local).AddTicks(6898), "Autem et velit.\nAutem sapiente rerum eius nostrum enim architecto quia.", "https://picsum.photos/640/480/?image=769", "Iris Anderson DVM", 10, 1462, new DateTime(2022, 12, 16, 21, 29, 36, 564, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempore facilis odit sed alias consequatur.", new DateTime(2023, 5, 13, 10, 35, 16, 175, DateTimeKind.Local).AddTicks(2981), "Ab dolorum et et nostrum ab.\nEt dolor placeat occaecati sunt ullam quam voluptatibus omnis.\nFacere corrupti veritatis repellendus.\nFugiat quos saepe ex nulla eaque deleniti et.\nEa neque aut reprehenderit vitae.", "https://picsum.photos/640/480/?image=543", "Mrs. Christie Tillman", 5, 5.0, 1774, new DateTime(2023, 1, 8, 21, 10, 25, 194, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Officiis fugiat voluptatem rerum dolorem et sed ex.", new DateTime(2023, 5, 13, 0, 58, 19, 351, DateTimeKind.Local).AddTicks(8600), "Perspiciatis aut dolorem quasi sed placeat non quia sit.\nRecusandae cum velit in dolorum nobis nesciunt porro.\nMinus aut nihil.", "https://picsum.photos/640/480/?image=49", "Mrs. Lynn Paucek", 10, 3.0, 1653, new DateTime(2022, 12, 16, 18, 53, 30, 250, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aliquam sed fuga vel.", new DateTime(2023, 5, 12, 22, 2, 9, 466, DateTimeKind.Local).AddTicks(4012), "Tempore expedita veritatis cumque deserunt iure sint.\nQuia est suscipit qui consequatur consequatur assumenda.", "https://picsum.photos/640/480/?image=608", "Susan Oberbrunner MD", 3, 5.0, 2077, new DateTime(2023, 3, 10, 18, 30, 21, 921, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut quia ut inventore vel in cupiditate fugiat vero facilis.", new DateTime(2023, 5, 13, 0, 5, 40, 971, DateTimeKind.Local).AddTicks(1533), "Vitae quo est ut adipisci.\nMolestiae excepturi ut.\nSequi repellendus saepe doloribus quam.", "https://picsum.photos/640/480/?image=171", "Mr. Johnny Rohan", 3.0, 567, new DateTime(2022, 10, 14, 16, 40, 13, 135, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia quos est quia et sit recusandae.", new DateTime(2023, 5, 13, 11, 24, 41, 374, DateTimeKind.Local).AddTicks(6915), "Voluptatem esse a.\nSed iure nisi aut delectus sit.", "https://picsum.photos/640/480/?image=79", "Ms. Marion Swaniawski", 2, 1.0, 1414, new DateTime(2022, 7, 25, 17, 37, 14, 886, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit eius nulla dolores mollitia.", new DateTime(2023, 5, 13, 12, 38, 41, 945, DateTimeKind.Local).AddTicks(2808), "Quia dolorum aliquid laborum ullam.\nUt qui reiciendis dolore aut officiis eius.\nImpedit aut dolores repellendus.\nPariatur nulla beatae ipsum possimus autem quia et aut ea.", "https://picsum.photos/640/480/?image=999", "Tyrone Jacobs V", 4, 4.0, 980, new DateTime(2022, 5, 19, 12, 36, 58, 88, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tenetur aperiam suscipit nostrum excepturi.", new DateTime(2023, 5, 12, 22, 20, 11, 924, DateTimeKind.Local).AddTicks(4474), "Ut quis nam et eum et iste.\nTempora impedit id dolorum distinctio delectus odit illo cupiditate.", "https://picsum.photos/640/480/?image=323", "Mrs. Belinda Boehm", 9, 968, new DateTime(2022, 12, 5, 4, 38, 40, 574, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed sit laboriosam repudiandae assumenda consectetur vero maiores nisi.", new DateTime(2023, 5, 12, 20, 41, 14, 34, DateTimeKind.Local).AddTicks(2926), "Fugit veritatis ea at sit.", "https://picsum.photos/640/480/?image=478", "Richard Schowalter MD", 2.0, 733, new DateTime(2022, 10, 28, 8, 58, 11, 336, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quae dolores aut maxime possimus quis ducimus voluptatum praesentium.", new DateTime(2023, 5, 12, 22, 26, 57, 910, DateTimeKind.Local).AddTicks(9875), "Ipsum quis quisquam enim ex aut quae excepturi.\nProvident quos maxime.\nQuisquam laudantium et hic rerum aperiam.", "https://picsum.photos/640/480/?image=539", "Courtney Moore I", 6, 3.0, 536, new DateTime(2022, 7, 27, 7, 32, 3, 316, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dignissimos delectus assumenda fugiat.", new DateTime(2023, 5, 13, 7, 21, 44, 529, DateTimeKind.Local).AddTicks(4705), "Laborum necessitatibus repellendus est magnam unde vel sed earum voluptates.", "https://picsum.photos/640/480/?image=480", "Dr. Raquel Auer", 2, 2.0, 2127, new DateTime(2022, 12, 13, 23, 42, 1, 258, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestiae inventore corporis dolore cumque nihil illum enim tempore.", new DateTime(2023, 5, 13, 8, 29, 19, 942, DateTimeKind.Local).AddTicks(8002), "Harum libero sint accusantium.\nEt similique error ullam.\nEarum perspiciatis dicta amet consectetur eum qui.\nNihil soluta odit.", "https://picsum.photos/640/480/?image=810", "Dallas Pacocha MD", 6, 5.0, 2148, new DateTime(2023, 3, 16, 19, 42, 31, 518, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis reiciendis quam aliquid quae aut quasi ipsam exercitationem et.", new DateTime(2023, 5, 13, 12, 3, 5, 805, DateTimeKind.Local).AddTicks(7024), "Eum sunt repellendus quidem consequatur.\nAt ratione tempora nemo similique deleniti occaecati dolores voluptatem.\nNeque omnis amet ad et harum voluptas.\nConsequuntur et magni omnis molestiae quae alias eligendi.", "https://picsum.photos/640/480/?image=1065", "Eleanor Berge DDS", 3, 1107, new DateTime(2023, 5, 1, 19, 17, 18, 73, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Id occaecati voluptas veniam sed consequatur unde alias.", new DateTime(2023, 5, 13, 10, 17, 58, 200, DateTimeKind.Local).AddTicks(1922), "Dolores deleniti illo qui autem iure.", "https://picsum.photos/640/480/?image=713", "Mr. Isabel Ratke", 4.0, 725, new DateTime(2022, 5, 13, 22, 54, 7, 772, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nisi nulla ex consequatur ut.", new DateTime(2023, 5, 13, 16, 18, 56, 520, DateTimeKind.Local).AddTicks(9088), "Eum accusantium odit consequuntur.\nAsperiores provident nulla magnam aut natus.\nAb eius eligendi animi.\nCulpa officia amet incidunt ut non necessitatibus quia.\nAlias rerum ea non perferendis.", "https://picsum.photos/640/480/?image=220", "Orville Thompson DVM", 9, 3.0, 1818, new DateTime(2022, 10, 27, 4, 50, 17, 40, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia et nesciunt rem tempora aliquid quia recusandae velit.", new DateTime(2023, 5, 13, 9, 50, 5, 576, DateTimeKind.Local).AddTicks(3091), "Non vero voluptatum distinctio sed nihil.\nIncidunt excepturi nisi occaecati ut rem.\nTotam unde est vel maiores odio assumenda facilis.", "https://picsum.photos/640/480/?image=180", "Maurice Goodwin Jr.", 10, 1.0, 979, new DateTime(2022, 11, 11, 10, 48, 19, 242, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eaque vero recusandae non ab omnis asperiores ut sed commodi.", new DateTime(2023, 5, 12, 23, 52, 50, 392, DateTimeKind.Local).AddTicks(8814), "Eos dolores repellendus ipsam suscipit adipisci beatae nobis veniam perspiciatis.\nExpedita temporibus neque accusamus sit in suscipit blanditiis nisi fugit.\nEst architecto reiciendis sed fuga quisquam.\nQuis enim quidem rerum aspernatur possimus sed eum.", "https://picsum.photos/640/480/?image=428", "Melvin Stroman MD", 3, 5.0, 697, new DateTime(2022, 8, 29, 22, 13, 12, 652, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Perferendis quo eveniet dolorem sequi quia quam qui culpa.", new DateTime(2023, 5, 13, 8, 32, 0, 259, DateTimeKind.Local).AddTicks(8227), "Ipsam voluptate dicta sit pariatur enim corrupti veritatis ut.\nSit itaque sed minus id et ducimus.\nNulla quisquam quis nihil provident qui fugit consequatur.\nQui omnis sint eius.", "https://picsum.photos/640/480/?image=135", "Miss Kim Adams", 9, 1.0, 648, new DateTime(2023, 4, 3, 16, 30, 24, 237, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est sit enim atque accusamus consectetur ut non et ea.", new DateTime(2023, 5, 13, 3, 37, 58, 715, DateTimeKind.Local).AddTicks(3082), "Quam amet dolor.\nVoluptas fugit id adipisci dolorum nisi.", "https://picsum.photos/640/480/?image=33", "Dr. Maria Stroman", 8, 575, new DateTime(2023, 1, 24, 3, 31, 59, 755, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et fugiat qui aspernatur.", new DateTime(2023, 5, 13, 10, 55, 5, 274, DateTimeKind.Local).AddTicks(5800), "Velit veritatis vero et veniam vitae sunt fuga aut et.\nNemo et dicta tenetur nihil aut perspiciatis.\nNulla aut dolorum placeat autem voluptatibus doloremque.\nEligendi aut molestiae et debitis perferendis et occaecati.", "https://picsum.photos/640/480/?image=594", "Angel Marks V", 5, 3.0, 613, new DateTime(2023, 2, 8, 11, 34, 15, 297, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Doloribus ipsum iste et doloremque doloribus.", new DateTime(2023, 5, 13, 5, 22, 16, 459, DateTimeKind.Local).AddTicks(7831), "Qui error soluta quas.\nQuia enim quia eum officia quia id veritatis consequatur.\nQuis tempora nobis distinctio recusandae amet suscipit at.", "https://picsum.photos/640/480/?image=95", "Elmer Stamm V", 7, 2270, new DateTime(2022, 12, 10, 11, 42, 36, 523, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eius et nulla nihil ipsum reprehenderit veritatis molestiae ut fuga.", new DateTime(2023, 5, 13, 17, 48, 55, 608, DateTimeKind.Local).AddTicks(5628), "Id est molestiae iure autem ipsum sed.\nQuis numquam aut incidunt nobis.\nInventore perferendis voluptas maxime magni aut.\nMaiores voluptatem perspiciatis autem.\nAtque minima sunt.", "https://picsum.photos/640/480/?image=724", "Mr. Teresa McCullough", 4, 1108, new DateTime(2022, 7, 26, 23, 3, 8, 667, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempora voluptatem distinctio delectus praesentium dicta cum ea nihil placeat.", new DateTime(2023, 5, 13, 11, 46, 43, 954, DateTimeKind.Local).AddTicks(5449), "Qui esse incidunt nam libero.\nQuidem animi beatae.\nEt aspernatur id et pariatur voluptatem incidunt enim reiciendis doloremque.\nAut ut id qui.", "https://picsum.photos/640/480/?image=1076", "Patsy Rolfson DDS", 2.0, 2097, new DateTime(2022, 9, 16, 10, 32, 39, 321, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellat cupiditate quia commodi.", new DateTime(2023, 5, 13, 11, 30, 56, 768, DateTimeKind.Local).AddTicks(255), "Numquam assumenda autem at architecto adipisci.\nNon voluptas a.\nEt rem maxime provident.\nCorrupti dolorem distinctio aut architecto quod.", "https://picsum.photos/640/480/?image=1016", "Ms. Winston MacGyver", 5, 1.0, 2060, new DateTime(2023, 3, 5, 15, 27, 35, 668, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Optio mollitia nihil qui placeat autem consequatur dolore voluptatem.", new DateTime(2023, 5, 13, 5, 8, 5, 795, DateTimeKind.Local).AddTicks(7419), "Ipsa et molestiae asperiores porro consequatur quia sit.", "https://picsum.photos/640/480/?image=664", "Cindy Huel DVM", 4, 4.0, 1692, new DateTime(2023, 2, 14, 20, 16, 0, 292, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Maxime in nostrum asperiores nostrum et nesciunt quas.", new DateTime(2023, 5, 13, 2, 45, 26, 2, DateTimeKind.Local).AddTicks(5067), "Ut itaque quis rerum incidunt inventore laborum rem quo ut.\nVitae officiis laudantium nisi.", "https://picsum.photos/640/480/?image=756", "Mrs. Constance Auer", 8, 5.0, 1337, new DateTime(2023, 3, 26, 18, 3, 44, 318, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Temporibus provident quis aut exercitationem corporis corrupti dolor rerum quia.", new DateTime(2023, 5, 13, 1, 41, 52, 304, DateTimeKind.Local).AddTicks(5760), "Optio qui qui molestias numquam.\nDolor quasi est deserunt sint ipsam neque repellendus.\nUt aspernatur vel debitis.\nMinus veniam voluptatibus delectus eos ad.", "https://picsum.photos/640/480/?image=359", "Mrs. Gladys Langworth", 10, 1247, new DateTime(2022, 12, 30, 17, 0, 21, 326, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repudiandae voluptas explicabo aut quos consequuntur expedita quisquam.", new DateTime(2023, 5, 13, 4, 15, 40, 827, DateTimeKind.Local).AddTicks(2049), "Sunt a illo pariatur ipsam.\nEius aut possimus ab.\nEt sint cupiditate iure dolor voluptatem.\nAnimi maiores nihil consectetur.\nOdio dolor qui inventore ea excepturi suscipit natus.", "https://picsum.photos/640/480/?image=564", "Shelia Kling Jr.", 3, 1.0, 1369, new DateTime(2023, 4, 17, 20, 27, 32, 869, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et inventore aut dignissimos doloremque tenetur ut et.", new DateTime(2023, 5, 13, 10, 20, 35, 149, DateTimeKind.Local).AddTicks(9388), "Natus est suscipit laborum voluptatem.", "https://picsum.photos/640/480/?image=263", "Julia Heaney V", 2, 4.0, 2358, new DateTime(2023, 1, 3, 14, 19, 17, 307, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cupiditate et ab sit quibusdam.", new DateTime(2023, 5, 13, 16, 6, 41, 456, DateTimeKind.Local).AddTicks(3633), "Quas fugit omnis voluptatem dignissimos et nihil quibusdam provident quod.", "https://picsum.photos/640/480/?image=319", "Miss Kristie Littel", 9, 2.0, 734, new DateTime(2022, 8, 22, 13, 49, 39, 118, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellat in illo.", new DateTime(2023, 5, 13, 6, 16, 36, 370, DateTimeKind.Local).AddTicks(7650), "Ipsum quia perferendis vel quis laudantium rerum.\nEt et sit itaque.\nQuia voluptatem excepturi ut delectus voluptatem.", "https://picsum.photos/640/480/?image=890", "Dr. Lloyd Dibbert", 9, 532, new DateTime(2022, 7, 5, 23, 15, 35, 109, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quibusdam eligendi doloremque quis expedita rerum.", new DateTime(2023, 5, 13, 17, 23, 52, 171, DateTimeKind.Local).AddTicks(1164), "Placeat quas esse pariatur consequatur nesciunt ut et eligendi aut.\nEsse aut enim maiores pariatur accusantium velit.", "https://picsum.photos/640/480/?image=1016", "Grady Blick DDS", 10, 1.0, 1423, new DateTime(2022, 12, 24, 22, 16, 51, 983, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nesciunt ut ea aut.", new DateTime(2023, 5, 12, 20, 22, 52, 895, DateTimeKind.Local).AddTicks(4453), "Et ratione cupiditate consectetur.\nEnim repellendus veniam maxime vero expedita odit vel.\nEst qui ipsum beatae sed debitis autem velit.\nQui quibusdam cumque dolores illo asperiores consequuntur dolorum dolor voluptatum.\nVoluptatem doloremque rerum maxime earum cumque delectus et.", "https://picsum.photos/640/480/?image=454", "Mr. Terrell Gislason", 6, 1.0, 2233, new DateTime(2022, 7, 25, 20, 24, 5, 890, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum voluptatem est aut ipsa non est.", new DateTime(2023, 5, 13, 16, 48, 17, 914, DateTimeKind.Local).AddTicks(8728), "Cupiditate sint aliquid totam ipsum.", "https://picsum.photos/640/480/?image=246", "Miss Lynne Gottlieb", 2, 1.0, 2307, new DateTime(2022, 5, 26, 22, 54, 13, 499, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Amet aspernatur inventore dolorem eius consequuntur.", new DateTime(2023, 5, 12, 19, 26, 34, 446, DateTimeKind.Local).AddTicks(8770), "Est consequatur eveniet soluta sint at cum minima veniam.\nNostrum ut ipsam aut voluptatem asperiores.\nTotam aut quisquam ut quia veniam eos.\nVoluptas magnam nisi odit asperiores quia qui.\nMollitia nostrum eligendi sit modi possimus aut.", "https://picsum.photos/640/480/?image=225", "Lynette Larkin IV", 9, 2474, new DateTime(2023, 2, 28, 20, 12, 58, 432, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut fugit dolores.", new DateTime(2023, 5, 13, 4, 57, 49, 970, DateTimeKind.Local).AddTicks(2313), "Sint accusamus excepturi nemo totam asperiores.\nVoluptatem nostrum est repellendus dolor dolores quia et eveniet.", "https://picsum.photos/640/480/?image=1010", "Ms. Sandy Gottlieb", 6, 5.0, 1414, new DateTime(2022, 5, 20, 16, 57, 9, 340, DateTimeKind.Local).AddTicks(4201) });
        }
    }
}
