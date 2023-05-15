using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa_API.Migrations
{
    /// <inheritdoc />
    public partial class AddNewVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum molestias quia corporis rerum laudantium est necessitatibus et.", new DateTime(2023, 5, 13, 5, 1, 0, 631, DateTimeKind.Local).AddTicks(1963), "Sed omnis est et nam qui.", "https://picsum.photos/640/480/?image=549", "Ellen Considine II", 1, 5.0, 1771, new DateTime(2022, 9, 14, 1, 0, 57, 659, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia dolor illum.", new DateTime(2023, 5, 12, 23, 24, 45, 701, DateTimeKind.Local).AddTicks(5529), "Nihil sequi quaerat voluptate cumque id aperiam adipisci quia molestias.", "https://picsum.photos/640/480/?image=384", "Miss Dave Boyle", 4, 3.0, 1565, new DateTime(2022, 10, 4, 22, 23, 25, 920, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Velit sint ut veniam quis.", new DateTime(2023, 5, 13, 13, 47, 24, 686, DateTimeKind.Local).AddTicks(776), "Vel doloremque quam praesentium eum labore quod aut.\nAlias et nihil.", "https://picsum.photos/640/480/?image=218", "Ms. Timmy Upton", 2, 1949, new DateTime(2022, 11, 21, 13, 32, 45, 920, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut voluptas incidunt totam deserunt facilis in.", new DateTime(2023, 5, 13, 7, 59, 40, 85, DateTimeKind.Local).AddTicks(2957), "Error in porro veritatis eos non eos voluptatem et.\nQuia dolorem molestiae eligendi tenetur.\nMinus illum nulla voluptatem.", "https://picsum.photos/640/480/?image=195", "Mr. Patsy Kshlerin", 8, 2.0, 1299, new DateTime(2023, 4, 11, 15, 11, 13, 937, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Accusamus fugiat nam sed cum sequi magnam distinctio culpa.", new DateTime(2023, 5, 13, 7, 29, 11, 121, DateTimeKind.Local).AddTicks(2709), "Et nam hic.\nLaudantium tempore quae voluptates in doloremque consequatur vel maiores.", "https://picsum.photos/640/480/?image=350", "Miss Merle Mohr", 6, 5.0, 2487, new DateTime(2022, 11, 16, 19, 10, 44, 44, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et repudiandae voluptatem explicabo occaecati.", new DateTime(2023, 5, 13, 8, 55, 46, 584, DateTimeKind.Local).AddTicks(656), "Explicabo dignissimos non.\nAperiam aut quo voluptatem suscipit.\nIpsa qui veniam ratione quidem ut a.\nMolestias in dicta voluptas dolore omnis recusandae sapiente debitis sed.\nNon culpa error omnis officia vero amet.", "https://picsum.photos/640/480/?image=210", "Mr. Karen Wisozk", 3, 2.0, 1531, new DateTime(2022, 8, 18, 17, 29, 17, 485, DateTimeKind.Local).AddTicks(2411) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sapiente natus aut nihil voluptates qui harum voluptatem deserunt.", new DateTime(2023, 5, 13, 9, 8, 34, 905, DateTimeKind.Local).AddTicks(629), "Qui ea perspiciatis enim odio consequuntur.\nIn eligendi magnam eos sunt nemo necessitatibus dolorem magni.\nQuia et quo suscipit facilis quam facilis.\nNulla praesentium asperiores id.", "https://picsum.photos/640/480/?image=406", "Miss Christy McClure", 1, 4.0, 1852, new DateTime(2022, 12, 21, 5, 12, 3, 212, DateTimeKind.Local).AddTicks(2111) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nam qui odio in labore harum.", new DateTime(2023, 5, 13, 9, 12, 59, 443, DateTimeKind.Local).AddTicks(2839), "Voluptatem consequatur accusamus et.\nDelectus voluptatem magnam est sint.\nFacere velit in excepturi voluptatum qui enim.", "https://picsum.photos/640/480/?image=736", "Tracy Nicolas V", 4, 2130, new DateTime(2022, 7, 14, 6, 38, 37, 511, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum et quasi.", new DateTime(2023, 5, 13, 16, 11, 0, 553, DateTimeKind.Local).AddTicks(8935), "Cupiditate est neque sequi aspernatur ipsam.\nUt fuga amet consequatur molestias.", "https://picsum.photos/640/480/?image=683", "Alfred Sipes III", 8, 1.0, 554, new DateTime(2022, 10, 23, 7, 46, 53, 201, DateTimeKind.Local).AddTicks(2847) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Pariatur laborum aut deserunt occaecati facere laborum qui.", new DateTime(2023, 5, 12, 23, 30, 16, 16, DateTimeKind.Local).AddTicks(9176), "Praesentium consequatur consequatur dolor maiores sed.\nUt est et recusandae.\nQuia iure enim veritatis reprehenderit est beatae exercitationem.\nNobis nisi quia pariatur sunt ut hic totam in.", "https://picsum.photos/640/480/?image=752", "Dr. Jodi Buckridge", 9, 5.0, 2310, new DateTime(2023, 1, 8, 5, 47, 35, 213, DateTimeKind.Local).AddTicks(7382) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Incidunt architecto corporis animi consequatur expedita occaecati voluptatem.", new DateTime(2023, 5, 13, 17, 38, 29, 20, DateTimeKind.Local).AddTicks(1229), "Ea a quo pariatur eveniet eos impedit voluptates quae doloremque.\nNihil nobis doloremque possimus non dolor et quidem.\nInventore dolores facere odit aut modi voluptas.\nOmnis dolores exercitationem corporis molestiae non atque id.", "https://picsum.photos/640/480/?image=242", "Miss Fernando Bruen", 4.0, 760, new DateTime(2022, 8, 23, 20, 26, 46, 556, DateTimeKind.Local).AddTicks(5372) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Minima vitae minima odit dolorum possimus non.", new DateTime(2023, 5, 13, 17, 23, 50, 901, DateTimeKind.Local).AddTicks(9409), "Magni alias id hic nihil rerum praesentium deleniti.\nUt et voluptatibus dolore quod quasi voluptate.\nConsequatur vel dolores consequatur magnam non.\nMagni unde tempore libero quo et fugiat inventore.\nAliquam suscipit natus quas voluptates doloribus sit.", "https://picsum.photos/640/480/?image=488", "Jeremiah Ratke II", 6, 1001, new DateTime(2022, 10, 22, 14, 54, 10, 830, DateTimeKind.Local).AddTicks(6814) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Perspiciatis error autem quaerat sint adipisci laboriosam.", new DateTime(2023, 5, 13, 11, 17, 11, 43, DateTimeKind.Local).AddTicks(9634), "Suscipit nostrum odio.\nQuo et alias voluptates ullam facere.\nQuo vitae vel.\nAut voluptate cum iure.", "https://picsum.photos/640/480/?image=917", "Miss Sue Nikolaus", 4, 1646, new DateTime(2023, 2, 12, 18, 13, 27, 848, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ad veritatis officia ut.", new DateTime(2023, 5, 13, 5, 39, 29, 560, DateTimeKind.Local).AddTicks(3624), "Ut et officia omnis possimus.\nPossimus et aut natus voluptatum eius est ex doloribus.\nVeniam dolores assumenda vel in enim atque commodi et voluptatem.\nAutem aut odit quis consequuntur deleniti.\nAut mollitia eum aspernatur repellendus veniam ut rem dolor non.", "https://picsum.photos/640/480/?image=696", "Larry Lemke I", 6, 4.0, 1535, new DateTime(2023, 5, 1, 7, 33, 51, 919, DateTimeKind.Local).AddTicks(2852) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Id dolores et ab reiciendis similique et eveniet laboriosam qui.", new DateTime(2023, 5, 13, 3, 39, 5, 331, DateTimeKind.Local).AddTicks(686), "Libero ratione corrupti amet ut harum omnis.\nVero iure repudiandae consequatur iure.\nVeritatis vel sed quas odit molestiae qui dolorum.", "https://picsum.photos/640/480/?image=675", "Ms. Antonia Orn", 1.0, 2361, new DateTime(2022, 5, 27, 19, 54, 31, 233, DateTimeKind.Local).AddTicks(5548) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ducimus libero quam.", new DateTime(2023, 5, 13, 15, 32, 7, 200, DateTimeKind.Local).AddTicks(7325), "Et saepe repellendus.\nDicta quaerat nesciunt possimus excepturi accusantium deserunt nihil rerum omnis.\nNisi fuga id aspernatur et ea dolorem sunt.\nIste quis tempore voluptatem hic odio reiciendis molestiae.", "https://picsum.photos/640/480/?image=193", "Cameron Olson Sr.", 6, 1057, new DateTime(2023, 3, 17, 17, 59, 15, 691, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Labore animi quia libero eum atque quasi accusantium.", new DateTime(2023, 5, 13, 10, 7, 5, 201, DateTimeKind.Local).AddTicks(4012), "Magnam alias illo tenetur.\nSed pariatur aliquid fugit quas tempore in in.\nConsequatur officia molestiae officia porro.\nSed voluptate accusamus libero ut id maxime sed.\nLaborum sunt adipisci omnis eligendi est rerum.", "https://picsum.photos/640/480/?image=841", "May Wiza I", 5, 523, new DateTime(2022, 9, 27, 23, 7, 24, 761, DateTimeKind.Local).AddTicks(7368) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut asperiores commodi quisquam sed.", new DateTime(2023, 5, 13, 12, 38, 6, 899, DateTimeKind.Local).AddTicks(8460), "Quas occaecati nemo numquam earum maxime hic molestiae.\nVoluptate enim accusantium explicabo ut.\nCorporis ipsum et.", "https://picsum.photos/640/480/?image=149", "Miss Robin Abshire", 2, 2.0, 656, new DateTime(2022, 12, 4, 18, 35, 38, 681, DateTimeKind.Local).AddTicks(1774) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis voluptates porro quisquam consectetur quo sunt tenetur.", new DateTime(2023, 5, 13, 3, 5, 43, 53, DateTimeKind.Local).AddTicks(6864), "In inventore vitae.\nDolor neque magni eligendi ea tenetur impedit.\nExpedita ut molestias incidunt sint minus molestiae consequatur sed.", "https://picsum.photos/640/480/?image=767", "Courtney Wunsch V", 5, 2107, new DateTime(2022, 6, 29, 14, 37, 24, 332, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Vitae omnis numquam.", new DateTime(2023, 5, 13, 17, 13, 11, 127, DateTimeKind.Local).AddTicks(2898), "Quas consequatur distinctio corrupti quo ipsum doloremque harum sint.\nA numquam saepe.\nEt saepe ea qui quo distinctio dignissimos minus.\nEum aut quia debitis et.", "https://picsum.photos/640/480/?image=62", "Mr. Mitchell Dickens", 1755, new DateTime(2023, 4, 5, 20, 20, 51, 444, DateTimeKind.Local).AddTicks(822) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Explicabo quae est.", new DateTime(2023, 5, 13, 1, 57, 49, 938, DateTimeKind.Local).AddTicks(3361), "Deleniti non sed quae.\nVoluptatem illo reprehenderit et aut harum porro incidunt voluptas.", "https://picsum.photos/640/480/?image=846", "Miss Luther McKenzie", 1044, new DateTime(2022, 12, 29, 4, 5, 58, 979, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Error veritatis nihil rem iste.", new DateTime(2023, 5, 13, 3, 25, 52, 143, DateTimeKind.Local).AddTicks(5643), "Perferendis aut dignissimos.\nCumque et fuga est.\nEius voluptatum aut qui.\nCum enim qui nulla voluptates totam.\nNemo optio quisquam est doloremque consectetur sint labore dolor.", "https://picsum.photos/640/480/?image=101", "Carroll Collier II", 7, 2.0, 2314, new DateTime(2022, 7, 7, 20, 39, 46, 691, DateTimeKind.Local).AddTicks(2548) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nesciunt deleniti fugit accusamus possimus provident temporibus consequatur error rerum.", new DateTime(2023, 5, 13, 17, 5, 5, 541, DateTimeKind.Local).AddTicks(3832), "Ut a quam facere blanditiis.\nQuis in ratione assumenda.\nVoluptatem repudiandae tenetur aut eius totam est ratione consectetur autem.", "https://picsum.photos/640/480/?image=222", "Ms. Hannah Armstrong", 2.0, 2303, new DateTime(2022, 6, 8, 14, 57, 3, 276, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolorem sunt ut.", new DateTime(2023, 5, 12, 22, 18, 17, 755, DateTimeKind.Local).AddTicks(9656), "Cumque molestias vitae tempore accusantium sed cum unde aut voluptas.\nExpedita sed repudiandae veniam officiis dolores aut hic inventore.\nMinus eum ut sapiente fugiat dolorum odio nihil.\nOfficia deleniti deleniti consequatur consequuntur voluptatibus et.", "https://picsum.photos/640/480/?image=909", "Miss Theodore Gerlach", 5, 731, new DateTime(2023, 3, 16, 17, 18, 8, 709, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quo eum enim.", new DateTime(2023, 5, 13, 7, 6, 41, 95, DateTimeKind.Local).AddTicks(9416), "Accusantium optio et possimus illo molestiae aut.", "https://picsum.photos/640/480/?image=128", "Jessie Ledner PhD", 3, 1.0, 967, new DateTime(2022, 8, 18, 21, 17, 0, 916, DateTimeKind.Local).AddTicks(1213) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iste voluptatem eveniet.", new DateTime(2023, 5, 13, 7, 23, 21, 274, DateTimeKind.Local).AddTicks(4140), "Quas voluptatem accusamus sit est sunt laboriosam modi aut sapiente.\nPerferendis soluta voluptatem modi aut suscipit et sit.", "https://picsum.photos/640/480/?image=1077", "Mrs. Inez Bosco", 7, 2.0, 1541, new DateTime(2022, 6, 18, 17, 14, 18, 204, DateTimeKind.Local).AddTicks(1141) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sapiente deserunt dolor.", new DateTime(2023, 5, 13, 10, 47, 51, 700, DateTimeKind.Local).AddTicks(6206), "Labore inventore consequuntur velit alias sit odio numquam delectus quo.\nSit necessitatibus cum inventore beatae et itaque.\nUt aliquam omnis dolorem ab.\nAspernatur blanditiis nam a qui velit expedita facere dolores asperiores.\nAtque blanditiis inventore aperiam et sed ducimus assumenda eligendi fugiat.", "https://picsum.photos/640/480/?image=841", "Carole Robel MD", 4, 3.0, 1103, new DateTime(2023, 4, 13, 8, 8, 32, 996, DateTimeKind.Local).AddTicks(3820) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "At sunt mollitia non ullam earum laudantium aut nobis amet.", new DateTime(2023, 5, 13, 1, 18, 25, 727, DateTimeKind.Local).AddTicks(8667), "Corporis ad voluptates.\nLibero aliquam eligendi atque.\nQuasi facere id labore pariatur animi ducimus omnis ex.", "https://picsum.photos/640/480/?image=1053", "Lila Quigley MD", 10, 4.0, 1589, new DateTime(2023, 3, 5, 10, 59, 58, 174, DateTimeKind.Local).AddTicks(7654) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsam veritatis sint inventore consequatur modi modi.", new DateTime(2023, 5, 13, 16, 24, 12, 903, DateTimeKind.Local).AddTicks(1312), "Dolorem doloribus ut ut accusantium asperiores ut voluptatem corrupti.\nEst exercitationem quasi quia.\nRecusandae suscipit iure est.", "https://picsum.photos/640/480/?image=423", "Miss Lynda Tremblay", 6, 1265, new DateTime(2022, 10, 6, 15, 52, 12, 771, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui aspernatur non.", new DateTime(2023, 5, 13, 15, 45, 37, 518, DateTimeKind.Local).AddTicks(9999), "Dolorum error nostrum laboriosam eaque sunt nulla.\nConsequatur sed hic omnis cum placeat sunt.\nProvident qui provident iusto sed dolor iusto corporis.\nNumquam rem voluptatem eaque quia ipsam animi iusto.", "https://picsum.photos/640/480/?image=658", "Johnathan Collins Jr.", 2, 2001, new DateTime(2022, 7, 5, 18, 31, 53, 612, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et mollitia delectus.", new DateTime(2023, 5, 12, 19, 47, 43, 303, DateTimeKind.Local).AddTicks(3658), "Voluptas quis et quo ut et aut.\nEum consequuntur veritatis eius sit dignissimos.\nNisi ea fuga enim vero optio autem sit expedita maxime.\nEt delectus ullam ducimus quia est eligendi sit suscipit et.\nLabore dolores sequi et ut.", "https://picsum.photos/640/480/?image=806", "Eduardo Jakubowski DDS", 6, 4.0, 537, new DateTime(2023, 3, 25, 19, 49, 58, 501, DateTimeKind.Local).AddTicks(4237) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis ex id tempore iure ut esse dolor.", new DateTime(2023, 5, 13, 0, 51, 43, 613, DateTimeKind.Local).AddTicks(4167), "Et iusto sed.\nDucimus quam et deserunt non iure asperiores qui.\nSed necessitatibus est molestias mollitia mollitia et alias nemo.", "https://picsum.photos/640/480/?image=125", "Miss Woodrow Kassulke", 7, 2396, new DateTime(2023, 5, 10, 9, 45, 8, 645, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolor magni sint perspiciatis.", new DateTime(2023, 5, 13, 15, 19, 21, 735, DateTimeKind.Local).AddTicks(5663), "Deserunt voluptatem sequi.\nEnim eaque accusantium ut minima et.\nSed velit dolores earum dolores soluta repudiandae in.\nUt voluptatem aut esse sint.\nDolor quae officiis in rerum deserunt quisquam.", "https://picsum.photos/640/480/?image=901", "Mrs. Mike Stoltenberg", 2, 1.0, 1202, new DateTime(2022, 10, 20, 14, 51, 59, 36, DateTimeKind.Local).AddTicks(7057) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas accusamus ducimus dignissimos et vel nemo perferendis beatae.", new DateTime(2023, 5, 12, 21, 28, 20, 125, DateTimeKind.Local).AddTicks(5814), "Molestiae veritatis possimus consequatur necessitatibus delectus officia.\nTemporibus debitis aut adipisci eum consequatur.", "https://picsum.photos/640/480/?image=74", "Alberto Block III", 2, 5.0, 862, new DateTime(2023, 4, 28, 22, 5, 38, 454, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cupiditate dolorem qui saepe fuga ut et corrupti.", new DateTime(2023, 5, 13, 13, 43, 37, 583, DateTimeKind.Local).AddTicks(5462), "Cum et consectetur dicta nesciunt.\nFacere repellendus eum assumenda placeat quaerat iste molestiae eum.\nSequi est repudiandae molestiae vitae.", "https://picsum.photos/640/480/?image=684", "Jackie Kuhlman PhD", 9, 1.0, 1352, new DateTime(2022, 8, 1, 12, 28, 4, 297, DateTimeKind.Local).AddTicks(1375) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut maiores reprehenderit quam dolores tempore quia illum pariatur.", new DateTime(2023, 5, 13, 11, 43, 43, 586, DateTimeKind.Local).AddTicks(6869), "Nulla ut incidunt velit unde occaecati saepe nemo.\nNobis id nulla corporis ad illum.\nQuae molestias odio quibusdam deserunt fugiat recusandae repellendus voluptas.\nVel necessitatibus doloribus sit est nobis.\nSimilique ad eaque vero.", "https://picsum.photos/640/480/?image=142", "Angel Morar V", 1, 4.0, 2376, new DateTime(2023, 3, 27, 5, 46, 50, 710, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Culpa modi velit perspiciatis voluptas at aspernatur minus et.", new DateTime(2023, 5, 13, 10, 31, 49, 795, DateTimeKind.Local).AddTicks(9814), "Quis rerum reprehenderit repudiandae quidem debitis quis laborum.\nSuscipit numquam eum quis magnam vitae.\nSoluta nihil rem repudiandae totam omnis non et nihil amet.", "https://picsum.photos/640/480/?image=1024", "Angelo Skiles I", 3.0, 988, new DateTime(2023, 2, 1, 10, 4, 10, 905, DateTimeKind.Local).AddTicks(5766) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Expedita nihil voluptate dolor quae odit.", new DateTime(2023, 5, 13, 12, 43, 8, 219, DateTimeKind.Local).AddTicks(4932), "Sint velit qui debitis ipsum eum atque.\nSit dolorem fugit perspiciatis adipisci mollitia consequatur.", "https://picsum.photos/640/480/?image=1049", "Ramona Miller DDS", 4, 4.0, 1099, new DateTime(2022, 8, 5, 15, 39, 32, 524, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Totam aliquam quo.", new DateTime(2023, 5, 13, 13, 18, 31, 561, DateTimeKind.Local).AddTicks(3215), "Nisi alias ipsa.", "https://picsum.photos/640/480/?image=294", "Ms. Delia Champlin", 6, 1409, new DateTime(2022, 6, 19, 21, 59, 21, 978, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et provident quia pariatur molestiae iure consectetur.", new DateTime(2023, 5, 13, 10, 43, 23, 806, DateTimeKind.Local).AddTicks(3695), "Assumenda molestiae quas voluptatem dolor et nulla.", "https://picsum.photos/640/480/?image=942", "Mrs. Rachel Rice", 3, 3.0, 1447, new DateTime(2023, 3, 28, 0, 58, 36, 517, DateTimeKind.Local).AddTicks(9420) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed minima qui veniam placeat et laborum possimus.", new DateTime(2023, 5, 13, 11, 14, 36, 329, DateTimeKind.Local).AddTicks(8092), "Fuga dolores velit facilis aut nemo nihil quos.\nRepudiandae omnis provident deleniti laudantium quo architecto asperiores mollitia delectus.\nDolores architecto est voluptatem saepe eum molestiae voluptas.", "https://picsum.photos/640/480/?image=503", "Robin Powlowski V", 1, 1.0, 1096, new DateTime(2023, 3, 9, 12, 31, 52, 196, DateTimeKind.Local).AddTicks(7576) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur ad dolorem nihil explicabo maxime aliquid voluptatibus.", new DateTime(2023, 5, 13, 6, 6, 58, 428, DateTimeKind.Local).AddTicks(1804), "Ut dolor neque ab illo consequatur quis unde voluptatibus iste.\nPerferendis ut voluptas quo repudiandae quia commodi.\nMolestiae voluptates asperiores a.\nAlias itaque assumenda enim earum culpa accusamus iure.", "https://picsum.photos/640/480/?image=164", "Wilma Hilll II", 9, 2367, new DateTime(2023, 4, 3, 0, 7, 8, 849, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eveniet est mollitia.", new DateTime(2023, 5, 13, 17, 16, 55, 675, DateTimeKind.Local).AddTicks(4212), "Possimus rerum aperiam et maxime.\nSuscipit et nisi non beatae.\nConsectetur eum iure odio tenetur.\nIncidunt sed et cumque et corporis quibusdam saepe id.", "https://picsum.photos/640/480/?image=1033", "Ms. Corey Muller", 3, 1694, new DateTime(2022, 6, 9, 11, 45, 8, 625, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia vel aliquid.", new DateTime(2023, 5, 13, 9, 19, 40, 343, DateTimeKind.Local).AddTicks(4402), "Veritatis et qui ea maxime ut voluptatem mollitia ipsum non.\nEa sunt autem minima.\nRepudiandae blanditiis eum quis aliquam quisquam.\nOmnis ducimus est nam repudiandae et ut corrupti labore.\nSint quam perferendis nesciunt at occaecati et eos aspernatur.", "https://picsum.photos/640/480/?image=1030", "Dr. Marvin D'Amore", 3, 1274, new DateTime(2023, 4, 13, 5, 21, 55, 293, DateTimeKind.Local).AddTicks(929) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Veritatis a assumenda alias sit quia voluptate aperiam aut libero.", new DateTime(2023, 5, 13, 14, 47, 4, 118, DateTimeKind.Local).AddTicks(8471), "Magni et dolorem modi.\nAut odit omnis at.\nRepudiandae est quia iusto maiores eum.", "https://picsum.photos/640/480/?image=76", "Miss Joanne Weimann", 10, 1759, new DateTime(2022, 11, 29, 0, 9, 7, 133, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Autem iure in doloribus sint mollitia sed dicta.", new DateTime(2023, 5, 13, 7, 56, 28, 185, DateTimeKind.Local).AddTicks(8395), "Assumenda qui sunt repellat beatae deserunt reprehenderit voluptate explicabo.", "https://picsum.photos/640/480/?image=423", "Kimberly Weber I", 1408, new DateTime(2023, 1, 24, 3, 31, 24, 361, DateTimeKind.Local).AddTicks(6748) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Earum cum hic sed nihil velit nihil et.", new DateTime(2023, 5, 12, 20, 45, 0, 260, DateTimeKind.Local).AddTicks(5264), "Unde recusandae dicta sint.\nOmnis similique nesciunt fugiat.", "https://picsum.photos/640/480/?image=133", "Mrs. Tara Kovacek", 6, 4.0, 1082, new DateTime(2022, 5, 21, 6, 9, 11, 924, DateTimeKind.Local).AddTicks(4621) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quos non aut quibusdam error cupiditate quia velit.", new DateTime(2023, 5, 13, 3, 40, 2, 902, DateTimeKind.Local).AddTicks(5780), "Fugit provident repellendus sit reprehenderit est cum et laboriosam assumenda.\nConsectetur minus iusto quia magnam quas.", "https://picsum.photos/640/480/?image=719", "Elbert Schultz PhD", 10, 2.0, 1154, new DateTime(2022, 5, 15, 17, 50, 40, 198, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Earum cupiditate amet reiciendis asperiores perferendis corporis.", new DateTime(2023, 5, 12, 20, 11, 2, 884, DateTimeKind.Local).AddTicks(6114), "Fugiat voluptas ratione dolore alias eos ad sapiente sit dolorem.", "https://picsum.photos/640/480/?image=90", "Madeline Gleichner MD", 1, 869, new DateTime(2023, 2, 27, 18, 23, 7, 70, DateTimeKind.Local).AddTicks(2001) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Fuga magni sint in ut nam in.", new DateTime(2023, 5, 13, 8, 11, 25, 846, DateTimeKind.Local).AddTicks(1207), "Cupiditate voluptates ut ad cumque deleniti est nulla.\nEnim maxime qui maiores qui asperiores et.\nQuibusdam perferendis in ut officiis eligendi illo dolor modi necessitatibus.\nQuis labore ipsam illum et enim beatae veritatis.\nNecessitatibus asperiores reiciendis asperiores vitae qui.", "https://picsum.photos/640/480/?image=59", "Traci Luettgen III", 10, 5.0, 2399, new DateTime(2022, 6, 11, 7, 5, 56, 104, DateTimeKind.Local).AddTicks(3204) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestiae perspiciatis vel dolorem natus rerum minima.", new DateTime(2023, 5, 13, 7, 0, 12, 304, DateTimeKind.Local).AddTicks(2402), "Distinctio et sit accusantium sint maiores qui ab accusantium.\nQui amet eum animi pariatur suscipit maiores fugiat vel animi.\nFacere incidunt rerum facere et architecto et harum.\nSaepe illo omnis et autem.\nNumquam architecto et ipsa.", "https://picsum.photos/640/480/?image=92", "Franklin Strosin Sr.", 9, 1.0, 1891, new DateTime(2022, 7, 28, 21, 41, 39, 262, DateTimeKind.Local).AddTicks(8694) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Adipisci soluta qui ut cupiditate dolores explicabo est.", new DateTime(2023, 5, 13, 5, 30, 12, 111, DateTimeKind.Local).AddTicks(1633), "Quibusdam nesciunt architecto nihil sit.\nVelit non necessitatibus odit.\nAperiam eaque totam voluptate sed.", "https://picsum.photos/640/480/?image=898", "Mrs. Santiago Davis", 1, 1.0, 1000, new DateTime(2022, 7, 23, 23, 32, 35, 346, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum adipisci tempora non voluptate et maiores accusamus.", new DateTime(2023, 5, 12, 19, 2, 32, 975, DateTimeKind.Local).AddTicks(2241), "At et asperiores.\nVoluptate ut voluptatem perspiciatis eum consectetur.", "https://picsum.photos/640/480/?image=166", "James Waters I", 5, 5.0, 1344, new DateTime(2023, 1, 6, 0, 24, 22, 262, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Officiis qui a qui ut praesentium quis tempore.", new DateTime(2023, 5, 13, 9, 55, 19, 342, DateTimeKind.Local).AddTicks(7837), "Sed in saepe laboriosam iure ut voluptatem.\nEt debitis voluptatem et voluptates in autem numquam.\nSed voluptas quo soluta mollitia ipsum.\nDolor fugit magni tempora explicabo voluptatem fugiat.", "https://picsum.photos/640/480/?image=919", "Mr. Laverne Considine", 7, 1402, new DateTime(2022, 12, 20, 6, 33, 43, 18, DateTimeKind.Local).AddTicks(785) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Veritatis error qui et voluptatem suscipit.", new DateTime(2023, 5, 13, 5, 23, 57, 265, DateTimeKind.Local).AddTicks(8021), "Voluptatibus quasi optio recusandae ullam illo impedit excepturi saepe.\nQuidem dolores sint sed at cupiditate excepturi qui et.\nDebitis voluptatem consequatur quam est aliquam blanditiis error.", "https://picsum.photos/640/480/?image=150", "Mrs. Valerie Champlin", 3, 3.0, 2195, new DateTime(2023, 4, 3, 8, 47, 31, 510, DateTimeKind.Local).AddTicks(7878) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Excepturi temporibus quae ad officiis.", new DateTime(2023, 5, 13, 5, 1, 3, 805, DateTimeKind.Local).AddTicks(7739), "Doloribus deleniti corrupti voluptatem nihil qui commodi.\nTenetur et non incidunt.\nSit in ullam dolorem reiciendis et est aliquam rerum alias.\nQui quos sed sint enim at.", "https://picsum.photos/640/480/?image=507", "Francis Cummings I", 1.0, 1110, new DateTime(2022, 7, 4, 12, 14, 1, 549, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolores itaque sapiente et rerum eum ipsam adipisci.", new DateTime(2023, 5, 13, 1, 9, 40, 667, DateTimeKind.Local).AddTicks(9214), "Voluptas et autem maiores maxime.\nPariatur unde est veritatis.\nDolor voluptatem temporibus.", "https://picsum.photos/640/480/?image=947", "Mrs. Eloise Williamson", 4.0, 2028, new DateTime(2022, 6, 21, 0, 57, 5, 549, DateTimeKind.Local).AddTicks(6042) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quisquam dicta odit eius ea velit quaerat aut.", new DateTime(2023, 5, 13, 7, 27, 3, 651, DateTimeKind.Local).AddTicks(6792), "Consequatur fugit praesentium accusantium quasi et.\nFacilis laborum facere non.", "https://picsum.photos/640/480/?image=1", "Mr. Jasmine Champlin", 3.0, 1600, new DateTime(2022, 5, 21, 3, 20, 20, 631, DateTimeKind.Local).AddTicks(2726) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Id omnis et consectetur accusamus omnis quis similique sit.", new DateTime(2023, 5, 13, 0, 45, 45, 946, DateTimeKind.Local).AddTicks(1030), "Qui facilis ut.\nUt fugiat tempora est quia quod voluptates fugiat.\nUt aut dolor occaecati reprehenderit tempora odit possimus est.\nEligendi et sit.", "https://picsum.photos/640/480/?image=189", "Emilio Marquardt DDS", 8, 2486, new DateTime(2023, 2, 16, 14, 6, 27, 778, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sunt consequuntur sunt.", new DateTime(2023, 5, 13, 11, 55, 19, 669, DateTimeKind.Local).AddTicks(3578), "Vel est molestiae occaecati accusantium quo quo.\nUt debitis ea.\nConsequatur dolorem hic.", "https://picsum.photos/640/480/?image=77", "Ms. Shannon Adams", 2, 2.0, 2086, new DateTime(2022, 7, 1, 12, 0, 49, 378, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est veniam totam.", new DateTime(2023, 5, 13, 16, 6, 55, 307, DateTimeKind.Local).AddTicks(2530), "Maiores aspernatur nihil consectetur neque dignissimos amet odio.\nRepellat esse vero officiis minus excepturi porro.\nDeleniti alias aperiam ipsa velit dolor eveniet qui.\nQuod incidunt voluptatem similique et temporibus.", "https://picsum.photos/640/480/?image=85", "Mr. Sylvia McClure", 6, 1522, new DateTime(2022, 11, 1, 3, 54, 59, 18, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Itaque inventore delectus illum vel facere et.", new DateTime(2023, 5, 12, 19, 33, 10, 326, DateTimeKind.Local).AddTicks(1693), "Sapiente aliquid blanditiis hic odio.\nMinima autem quibusdam repudiandae architecto et sed aut.\nFugit et eveniet aliquid ea vel quam fugit sit.\nPlaceat et qui ipsum unde voluptatem id et omnis.\nQui in aliquid.", "https://picsum.photos/640/480/?image=535", "Josh Dicki III", 1, 1536, new DateTime(2022, 8, 29, 7, 31, 8, 972, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ex voluptatem ut ut corrupti blanditiis.", new DateTime(2023, 5, 13, 15, 25, 24, 775, DateTimeKind.Local).AddTicks(2482), "Voluptas omnis iste ut distinctio repudiandae facilis.\nMolestias cupiditate cupiditate quos consequatur accusamus cupiditate quam.\nConsequatur facere nesciunt dolores autem laboriosam veritatis dolorem.\nQui repudiandae unde et animi eveniet velit corrupti debitis impedit.\nIpsa et cum eum.", "https://picsum.photos/640/480/?image=258", "Stanley Morissette MD", 7, 1.0, 1459, new DateTime(2022, 9, 9, 22, 8, 48, 478, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsum iure eum corrupti non ratione accusantium laboriosam.", new DateTime(2023, 5, 13, 2, 38, 50, 272, DateTimeKind.Local).AddTicks(1632), "Nemo delectus quasi vero aut sit quasi et cupiditate voluptatem.\nMolestias quod placeat nisi aspernatur.\nAtque nisi voluptatem.", "https://picsum.photos/640/480/?image=262", "Constance Bayer Jr.", 10, 5.0, 1615, new DateTime(2022, 10, 15, 4, 44, 28, 544, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Alias sed veniam harum et cupiditate rerum omnis.", new DateTime(2023, 5, 13, 14, 4, 48, 402, DateTimeKind.Local).AddTicks(5717), "Quo voluptatem quis sed ex sunt.\nVoluptas delectus ducimus eos sit qui quam.\nPerspiciatis debitis laborum.", "https://picsum.photos/640/480/?image=973", "Mr. Violet Wintheiser", 4, 4.0, 1595, new DateTime(2022, 9, 15, 10, 24, 28, 515, DateTimeKind.Local).AddTicks(6060) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem quia saepe consequatur porro quo sunt facilis tenetur.", new DateTime(2023, 5, 13, 9, 58, 25, 837, DateTimeKind.Local).AddTicks(5056), "Laudantium amet occaecati occaecati sit.\nCulpa ea consequuntur.\nDolorum aut et.\nAspernatur fuga amet adipisci nihil inventore quo.\nPerferendis ut impedit adipisci sed similique magni.", "https://picsum.photos/640/480/?image=331", "Arthur Goyette III", 1, 641, new DateTime(2022, 12, 18, 1, 6, 28, 234, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ex omnis ea quis optio sed.", new DateTime(2023, 5, 13, 4, 16, 27, 754, DateTimeKind.Local).AddTicks(6105), "Natus et nobis tempora est et officia esse.\nDoloremque eum et et aliquam iusto impedit nam officiis aliquid.\nRecusandae labore laudantium rerum dolorum ad nostrum pariatur ea.\nTemporibus ut nihil sunt quisquam assumenda nihil.", "https://picsum.photos/640/480/?image=993", "Ann Gutkowski MD", 2, 2.0, 1989, new DateTime(2022, 8, 28, 16, 59, 38, 387, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum voluptatem voluptatem dolorem.", new DateTime(2023, 5, 13, 5, 10, 27, 520, DateTimeKind.Local).AddTicks(8203), "Aspernatur eius velit suscipit corporis quia praesentium et deserunt.\nEum omnis occaecati ipsam perspiciatis nostrum voluptatibus.\nQuia odio nam consequatur.\nDolorem asperiores quos.\nAtque eum voluptatem aut cumque omnis vel impedit.", "https://picsum.photos/640/480/?image=1004", "Bradford Stark PhD", 9, 589, new DateTime(2023, 5, 9, 16, 43, 12, 447, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum nemo quod ut non accusamus incidunt magnam accusantium.", new DateTime(2023, 5, 12, 20, 5, 48, 26, DateTimeKind.Local).AddTicks(1994), "Perferendis voluptates dolore ullam repellendus.\nRepellat ratione aut ut consectetur.\nIste saepe voluptatem eligendi tenetur.", "https://picsum.photos/640/480/?image=453", "Bryan Considine MD", 8, 5.0, 2190, new DateTime(2023, 1, 14, 8, 56, 8, 830, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eum debitis dicta tempora ad a aut.", new DateTime(2023, 5, 13, 6, 6, 49, 431, DateTimeKind.Local).AddTicks(1189), "Officia qui et quis et ipsa nemo beatae dolore.\nAutem rerum laborum velit quisquam fugit vero vel.\nQuis vel id consequatur voluptas totam et sit.", "https://picsum.photos/640/480/?image=211", "Miss Beth Wilderman", 3, 4.0, 1982, new DateTime(2022, 7, 14, 7, 51, 49, 440, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Minus qui nesciunt exercitationem repellat.", new DateTime(2023, 5, 13, 12, 12, 48, 231, DateTimeKind.Local).AddTicks(4372), "Unde voluptas tenetur voluptatibus ducimus.\nEarum assumenda nemo quasi explicabo.\nEt mollitia et.\nUnde odio esse qui.\nEarum quis soluta necessitatibus fugit excepturi molestiae aut eum.", "https://picsum.photos/640/480/?image=0", "Moses Nolan II", 5, 789, new DateTime(2022, 5, 16, 23, 17, 43, 215, DateTimeKind.Local).AddTicks(9661) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis deserunt totam.", new DateTime(2023, 5, 13, 5, 31, 58, 142, DateTimeKind.Local).AddTicks(1648), "Pariatur quas sit alias quisquam laboriosam sint accusamus.\nFugiat harum veritatis officia soluta.\nIn vel modi veritatis voluptatem ut nostrum.\nPossimus facere soluta odit et necessitatibus maxime rerum quasi amet.", "https://picsum.photos/640/480/?image=391", "Nettie Orn DVM", 5, 5.0, 1077, new DateTime(2022, 10, 21, 20, 55, 0, 595, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Provident dolorem officia expedita deserunt rerum accusantium rerum.", new DateTime(2023, 5, 12, 21, 51, 34, 291, DateTimeKind.Local).AddTicks(7655), "Rerum sit vel.\nVitae illo adipisci commodi perferendis adipisci aperiam iste non.", "https://picsum.photos/640/480/?image=747", "Gerardo Metz IV", 1111, new DateTime(2023, 2, 9, 20, 25, 47, 782, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laboriosam adipisci eius repellat et inventore.", new DateTime(2023, 5, 13, 9, 20, 15, 1, DateTimeKind.Local).AddTicks(8124), "Et non corporis et nihil totam commodi quam.\nMollitia voluptatum cumque consequatur ratione consequatur.\nSit sit accusamus est nam nihil a neque similique quod.", "https://picsum.photos/640/480/?image=525", "Darnell O'Reilly PhD", 2, 1.0, 503, new DateTime(2022, 5, 20, 19, 41, 10, 718, DateTimeKind.Local).AddTicks(5713) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis cumque voluptatem reiciendis est quo et quia.", new DateTime(2023, 5, 13, 6, 46, 51, 661, DateTimeKind.Local).AddTicks(3286), "Error expedita eos non.\nSoluta dolorum omnis recusandae dolorem.\nAliquam doloremque ex deserunt.\nMollitia reiciendis sed voluptatem incidunt accusamus deserunt quia temporibus architecto.", "https://picsum.photos/640/480/?image=159", "Thelma Donnelly II", 3, 1665, new DateTime(2023, 2, 3, 21, 25, 6, 174, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Vel consequatur ut dolores et modi alias expedita itaque hic.", new DateTime(2023, 5, 13, 3, 53, 17, 637, DateTimeKind.Local).AddTicks(1288), "Distinctio illo architecto sed ut consectetur.\nVoluptatem est similique.\nVoluptatem et et consequuntur autem.\nHic eos et aut qui voluptatem aut.", "https://picsum.photos/640/480/?image=736", "Neal Morissette MD", 1, 1.0, 1314, new DateTime(2022, 7, 6, 14, 12, 6, 885, DateTimeKind.Local).AddTicks(8199) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit deleniti velit omnis quaerat magnam.", new DateTime(2023, 5, 13, 7, 19, 19, 965, DateTimeKind.Local).AddTicks(5666), "Molestias voluptate et eius.\nEveniet aut eos.", "https://picsum.photos/640/480/?image=237", "Jenny Johns DDS", 1, 766, new DateTime(2022, 11, 26, 13, 38, 54, 981, DateTimeKind.Local).AddTicks(3208) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quaerat quis odit omnis esse nisi.", new DateTime(2023, 5, 12, 19, 23, 12, 27, DateTimeKind.Local).AddTicks(6898), "Autem et velit.\nAutem sapiente rerum eius nostrum enim architecto quia.", "https://picsum.photos/640/480/?image=769", "Iris Anderson DVM", 10, 2.0, 1462, new DateTime(2022, 12, 16, 21, 29, 36, 564, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempore facilis odit sed alias consequatur.", new DateTime(2023, 5, 13, 10, 35, 16, 175, DateTimeKind.Local).AddTicks(2981), "Ab dolorum et et nostrum ab.\nEt dolor placeat occaecati sunt ullam quam voluptatibus omnis.\nFacere corrupti veritatis repellendus.\nFugiat quos saepe ex nulla eaque deleniti et.\nEa neque aut reprehenderit vitae.", "https://picsum.photos/640/480/?image=543", "Mrs. Christie Tillman", 5, 1774, new DateTime(2023, 1, 8, 21, 10, 25, 194, DateTimeKind.Local).AddTicks(9283) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "UpdatedDate" },
                values: new object[] { "Sit eius nulla dolores mollitia.", new DateTime(2023, 5, 13, 12, 38, 41, 945, DateTimeKind.Local).AddTicks(2808), "Quia dolorum aliquid laborum ullam.\nUt qui reiciendis dolore aut officiis eius.\nImpedit aut dolores repellendus.\nPariatur nulla beatae ipsum possimus autem quia et aut ea.", "https://picsum.photos/640/480/?image=999", "Tyrone Jacobs V", 4, 4.0, new DateTime(2022, 5, 19, 12, 36, 58, 88, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tenetur aperiam suscipit nostrum excepturi.", new DateTime(2023, 5, 12, 22, 20, 11, 924, DateTimeKind.Local).AddTicks(4474), "Ut quis nam et eum et iste.\nTempora impedit id dolorum distinctio delectus odit illo cupiditate.", "https://picsum.photos/640/480/?image=323", "Mrs. Belinda Boehm", 9, 1.0, 968, new DateTime(2022, 12, 5, 4, 38, 40, 574, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed sit laboriosam repudiandae assumenda consectetur vero maiores nisi.", new DateTime(2023, 5, 12, 20, 41, 14, 34, DateTimeKind.Local).AddTicks(2926), "Fugit veritatis ea at sit.", "https://picsum.photos/640/480/?image=478", "Richard Schowalter MD", 5, 2.0, 733, new DateTime(2022, 10, 28, 8, 58, 11, 336, DateTimeKind.Local).AddTicks(1475) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestiae inventore corporis dolore cumque nihil illum enim tempore.", new DateTime(2023, 5, 13, 8, 29, 19, 942, DateTimeKind.Local).AddTicks(8002), "Harum libero sint accusantium.\nEt similique error ullam.\nEarum perspiciatis dicta amet consectetur eum qui.\nNihil soluta odit.", "https://picsum.photos/640/480/?image=810", "Dallas Pacocha MD", 6, 2148, new DateTime(2023, 3, 16, 19, 42, 31, 518, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quis reiciendis quam aliquid quae aut quasi ipsam exercitationem et.", new DateTime(2023, 5, 13, 12, 3, 5, 805, DateTimeKind.Local).AddTicks(7024), "Eum sunt repellendus quidem consequatur.\nAt ratione tempora nemo similique deleniti occaecati dolores voluptatem.\nNeque omnis amet ad et harum voluptas.\nConsequuntur et magni omnis molestiae quae alias eligendi.", "https://picsum.photos/640/480/?image=1065", "Eleanor Berge DDS", 3, 1.0, 1107, new DateTime(2023, 5, 1, 19, 17, 18, 73, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Id occaecati voluptas veniam sed consequatur unde alias.", new DateTime(2023, 5, 13, 10, 17, 58, 200, DateTimeKind.Local).AddTicks(1922), "Dolores deleniti illo qui autem iure.", "https://picsum.photos/640/480/?image=713", "Mr. Isabel Ratke", 6, 725, new DateTime(2022, 5, 13, 22, 54, 7, 772, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nisi nulla ex consequatur ut.", new DateTime(2023, 5, 13, 16, 18, 56, 520, DateTimeKind.Local).AddTicks(9088), "Eum accusantium odit consequuntur.\nAsperiores provident nulla magnam aut natus.\nAb eius eligendi animi.\nCulpa officia amet incidunt ut non necessitatibus quia.\nAlias rerum ea non perferendis.", "https://picsum.photos/640/480/?image=220", "Orville Thompson DVM", 3.0, 1818, new DateTime(2022, 10, 27, 4, 50, 17, 40, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia et nesciunt rem tempora aliquid quia recusandae velit.", new DateTime(2023, 5, 13, 9, 50, 5, 576, DateTimeKind.Local).AddTicks(3091), "Non vero voluptatum distinctio sed nihil.\nIncidunt excepturi nisi occaecati ut rem.\nTotam unde est vel maiores odio assumenda facilis.", "https://picsum.photos/640/480/?image=180", "Maurice Goodwin Jr.", 10, 979, new DateTime(2022, 11, 11, 10, 48, 19, 242, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eaque vero recusandae non ab omnis asperiores ut sed commodi.", new DateTime(2023, 5, 12, 23, 52, 50, 392, DateTimeKind.Local).AddTicks(8814), "Eos dolores repellendus ipsam suscipit adipisci beatae nobis veniam perspiciatis.\nExpedita temporibus neque accusamus sit in suscipit blanditiis nisi fugit.\nEst architecto reiciendis sed fuga quisquam.\nQuis enim quidem rerum aspernatur possimus sed eum.", "https://picsum.photos/640/480/?image=428", "Melvin Stroman MD", 5.0, 697, new DateTime(2022, 8, 29, 22, 13, 12, 652, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Perferendis quo eveniet dolorem sequi quia quam qui culpa.", new DateTime(2023, 5, 13, 8, 32, 0, 259, DateTimeKind.Local).AddTicks(8227), "Ipsam voluptate dicta sit pariatur enim corrupti veritatis ut.\nSit itaque sed minus id et ducimus.\nNulla quisquam quis nihil provident qui fugit consequatur.\nQui omnis sint eius.", "https://picsum.photos/640/480/?image=135", "Miss Kim Adams", 1.0, 648, new DateTime(2023, 4, 3, 16, 30, 24, 237, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est sit enim atque accusamus consectetur ut non et ea.", new DateTime(2023, 5, 13, 3, 37, 58, 715, DateTimeKind.Local).AddTicks(3082), "Quam amet dolor.\nVoluptas fugit id adipisci dolorum nisi.", "https://picsum.photos/640/480/?image=33", "Dr. Maria Stroman", 3.0, 575, new DateTime(2023, 1, 24, 3, 31, 59, 755, DateTimeKind.Local).AddTicks(9174) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Doloribus ipsum iste et doloremque doloribus.", new DateTime(2023, 5, 13, 5, 22, 16, 459, DateTimeKind.Local).AddTicks(7831), "Qui error soluta quas.\nQuia enim quia eum officia quia id veritatis consequatur.\nQuis tempora nobis distinctio recusandae amet suscipit at.", "https://picsum.photos/640/480/?image=95", "Elmer Stamm V", 1.0, 2270, new DateTime(2022, 12, 10, 11, 42, 36, 523, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eius et nulla nihil ipsum reprehenderit veritatis molestiae ut fuga.", new DateTime(2023, 5, 13, 17, 48, 55, 608, DateTimeKind.Local).AddTicks(5628), "Id est molestiae iure autem ipsum sed.\nQuis numquam aut incidunt nobis.\nInventore perferendis voluptas maxime magni aut.\nMaiores voluptatem perspiciatis autem.\nAtque minima sunt.", "https://picsum.photos/640/480/?image=724", "Mr. Teresa McCullough", 4, 1.0, 1108, new DateTime(2022, 7, 26, 23, 3, 8, 667, DateTimeKind.Local).AddTicks(7247) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellat cupiditate quia commodi.", new DateTime(2023, 5, 13, 11, 30, 56, 768, DateTimeKind.Local).AddTicks(255), "Numquam assumenda autem at architecto adipisci.\nNon voluptas a.\nEt rem maxime provident.\nCorrupti dolorem distinctio aut architecto quod.", "https://picsum.photos/640/480/?image=1016", "Ms. Winston MacGyver", 5, 2060, new DateTime(2023, 3, 5, 15, 27, 35, 668, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Optio mollitia nihil qui placeat autem consequatur dolore voluptatem.", new DateTime(2023, 5, 13, 5, 8, 5, 795, DateTimeKind.Local).AddTicks(7419), "Ipsa et molestiae asperiores porro consequatur quia sit.", "https://picsum.photos/640/480/?image=664", "Cindy Huel DVM", 4, 1692, new DateTime(2023, 2, 14, 20, 16, 0, 292, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Maxime in nostrum asperiores nostrum et nesciunt quas.", new DateTime(2023, 5, 13, 2, 45, 26, 2, DateTimeKind.Local).AddTicks(5067), "Ut itaque quis rerum incidunt inventore laborum rem quo ut.\nVitae officiis laudantium nisi.", "https://picsum.photos/640/480/?image=756", "Mrs. Constance Auer", 8, 1337, new DateTime(2023, 3, 26, 18, 3, 44, 318, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Temporibus provident quis aut exercitationem corporis corrupti dolor rerum quia.", new DateTime(2023, 5, 13, 1, 41, 52, 304, DateTimeKind.Local).AddTicks(5760), "Optio qui qui molestias numquam.\nDolor quasi est deserunt sint ipsam neque repellendus.\nUt aspernatur vel debitis.\nMinus veniam voluptatibus delectus eos ad.", "https://picsum.photos/640/480/?image=359", "Mrs. Gladys Langworth", 10, 5.0, 1247, new DateTime(2022, 12, 30, 17, 0, 21, 326, DateTimeKind.Local).AddTicks(326) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellat in illo.", new DateTime(2023, 5, 13, 6, 16, 36, 370, DateTimeKind.Local).AddTicks(7650), "Ipsum quia perferendis vel quis laudantium rerum.\nEt et sit itaque.\nQuia voluptatem excepturi ut delectus voluptatem.", "https://picsum.photos/640/480/?image=890", "Dr. Lloyd Dibbert", 4.0, 532, new DateTime(2022, 7, 5, 23, 15, 35, 109, DateTimeKind.Local).AddTicks(2708) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nesciunt ut ea aut.", new DateTime(2023, 5, 12, 20, 22, 52, 895, DateTimeKind.Local).AddTicks(4453), "Et ratione cupiditate consectetur.\nEnim repellendus veniam maxime vero expedita odit vel.\nEst qui ipsum beatae sed debitis autem velit.\nQui quibusdam cumque dolores illo asperiores consequuntur dolorum dolor voluptatum.\nVoluptatem doloremque rerum maxime earum cumque delectus et.", "https://picsum.photos/640/480/?image=454", "Mr. Terrell Gislason", 1.0, 2233, new DateTime(2022, 7, 25, 20, 24, 5, 890, DateTimeKind.Local).AddTicks(3751) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Amet aspernatur inventore dolorem eius consequuntur.", new DateTime(2023, 5, 12, 19, 26, 34, 446, DateTimeKind.Local).AddTicks(8770), "Est consequatur eveniet soluta sint at cum minima veniam.\nNostrum ut ipsam aut voluptatem asperiores.\nTotam aut quisquam ut quia veniam eos.\nVoluptas magnam nisi odit asperiores quia qui.\nMollitia nostrum eligendi sit modi possimus aut.", "https://picsum.photos/640/480/?image=225", "Lynette Larkin IV", 9, 2.0, 2474, new DateTime(2023, 2, 28, 20, 12, 58, 432, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut fugit dolores.", new DateTime(2023, 5, 13, 4, 57, 49, 970, DateTimeKind.Local).AddTicks(2313), "Sint accusamus excepturi nemo totam asperiores.\nVoluptatem nostrum est repellendus dolor dolores quia et eveniet.", "https://picsum.photos/640/480/?image=1010", "Ms. Sandy Gottlieb", 5.0, 1414, new DateTime(2022, 5, 20, 16, 57, 9, 340, DateTimeKind.Local).AddTicks(4201) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum quibusdam voluptatem et et facilis eveniet voluptas.", new DateTime(2023, 5, 8, 16, 18, 44, 933, DateTimeKind.Local).AddTicks(3581), "Sapiente culpa est.\nAspernatur veritatis doloribus officia quos dolor.\nSapiente sit aut saepe illum.\nTempore est at error reprehenderit.\nOccaecati earum doloribus magni est aut commodi quibusdam necessitatibus.", "https://picsum.photos/640/480/?image=464", "Mrs. Lola Quitzon", 6, 3.0, 667, new DateTime(2022, 5, 29, 6, 22, 42, 224, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Architecto placeat animi cum illum omnis optio non.", new DateTime(2023, 5, 7, 21, 22, 31, 889, DateTimeKind.Local).AddTicks(5112), "Quam voluptatem consequatur harum omnis exercitationem.\nEt id qui.", "https://picsum.photos/640/480/?image=580", "Ms. Rickey Ortiz", 3, 5.0, 1130, new DateTime(2023, 1, 12, 11, 41, 37, 796, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cupiditate dolor beatae aut iusto fugit optio non.", new DateTime(2023, 5, 8, 15, 6, 19, 989, DateTimeKind.Local).AddTicks(9465), "Quos nisi et.\nEnim eum perspiciatis corrupti illo eum perspiciatis qui.", "https://picsum.photos/640/480/?image=832", "Mr. Leslie Sporer", 5, 1035, new DateTime(2022, 7, 11, 13, 11, 52, 808, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consectetur vel quod debitis beatae.", new DateTime(2023, 5, 8, 4, 24, 20, 762, DateTimeKind.Local).AddTicks(9472), "Corrupti aut eos.\nFacere temporibus aut nisi nemo laudantium nulla hic quaerat eveniet.\nUt facilis illo ratione qui.\nDolorum consequatur est et nobis aspernatur repellat.\nEt odit recusandae quaerat occaecati corporis nam tenetur magnam rerum.", "https://picsum.photos/640/480/?image=582", "Dianne Kuhlman Jr.", 2, 1.0, 598, new DateTime(2022, 8, 31, 17, 56, 3, 676, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aspernatur cum hic rerum occaecati occaecati officiis velit.", new DateTime(2023, 5, 8, 18, 3, 30, 99, DateTimeKind.Local).AddTicks(2861), "Repellendus deleniti asperiores odit dolorem.\nId in omnis ut vel quod.\nAut exercitationem aut ut.\nQuis expedita reprehenderit.", "https://picsum.photos/640/480/?image=630", "Katie Sawayn II", 8, 4.0, 1207, new DateTime(2023, 2, 20, 8, 23, 46, 428, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cupiditate maiores ex harum eos dolor qui et at.", new DateTime(2023, 5, 8, 2, 44, 36, 664, DateTimeKind.Local).AddTicks(6757), "Voluptatem voluptas delectus est nihil porro.", "https://picsum.photos/640/480/?image=886", "Mr. Marcia Wiza", 9, 4.0, 2005, new DateTime(2022, 8, 3, 19, 59, 9, 491, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Modi occaecati sed.", new DateTime(2023, 5, 8, 8, 31, 54, 200, DateTimeKind.Local).AddTicks(6593), "Quia nihil omnis aut dolorem quia.\nEius atque doloribus dolorem.\nVoluptates dolorum incidunt voluptas perspiciatis fugiat.\nAut fuga repellat est.\nNeque quia dolorem quis et delectus ut voluptatem.", "https://picsum.photos/640/480/?image=947", "Steven Will I", 7, 1.0, 557, new DateTime(2023, 3, 22, 11, 18, 8, 903, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Perferendis sapiente aut libero rerum recusandae laborum amet sint beatae.", new DateTime(2023, 5, 8, 17, 35, 39, 741, DateTimeKind.Local).AddTicks(2265), "Vero temporibus eius molestiae eligendi iure eligendi iste ut.\nDoloremque doloribus fugiat autem porro voluptatem.\nUt nobis est aperiam maiores eius aut dolorum placeat.", "https://picsum.photos/640/480/?image=968", "Miss Myrtle Daniel", 7, 2.0, 1640, new DateTime(2022, 11, 20, 16, 38, 7, 111, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatum ut libero enim dolor pariatur tempore voluptas.", new DateTime(2023, 5, 8, 8, 47, 8, 297, DateTimeKind.Local).AddTicks(2785), "Autem est fugiat ea facilis at magnam asperiores ut.\nEst praesentium sit placeat sunt.\nEt ea quaerat explicabo doloribus.\nDeserunt est a.\nImpedit aliquam sint ea hic quos sit deserunt et consectetur.", "https://picsum.photos/640/480/?image=936", "Jermaine Hilpert III", 4, 2.0, 2189, new DateTime(2023, 3, 28, 23, 11, 56, 182, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Similique deleniti et aut aliquam quae neque.", new DateTime(2023, 5, 8, 1, 30, 47, 306, DateTimeKind.Local).AddTicks(934), "Inventore et corporis quis.\nVeniam totam harum asperiores.\nSapiente iusto id eum occaecati libero soluta vel quibusdam.\nOmnis tempora delectus quia quia assumenda ut excepturi cumque.", "https://picsum.photos/640/480/?image=684", "Jana Wisoky V", 7, 585, new DateTime(2022, 8, 12, 7, 27, 39, 696, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui qui aliquam quidem eum.", new DateTime(2023, 5, 8, 8, 14, 4, 650, DateTimeKind.Local).AddTicks(9621), "Ut sed aut et aliquam.\nHarum iste molestiae unde ex nam inventore rerum eos explicabo.", "https://picsum.photos/640/480/?image=436", "Hilda Borer II", 2, 2.0, 731, new DateTime(2022, 6, 12, 3, 6, 7, 454, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quibusdam est omnis dolores.", new DateTime(2023, 5, 8, 12, 51, 34, 957, DateTimeKind.Local).AddTicks(9042), "Ipsa totam voluptatem ut voluptatem.\nAd fugit quia voluptatum repellat harum.\nLaborum aut asperiores sequi ut.\nRecusandae qui fugit totam.\nVoluptatibus totam quo facere nemo distinctio sit odio praesentium.", "https://picsum.photos/640/480/?image=828", "Sheri Thompson I", 5, 5.0, 1441, new DateTime(2023, 2, 5, 9, 52, 51, 404, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repudiandae consequatur animi ducimus error earum enim vitae dolorem.", new DateTime(2023, 5, 8, 14, 13, 33, 659, DateTimeKind.Local).AddTicks(7386), "Provident unde aut recusandae et saepe non.\nQuam atque tenetur est non.\nQuia non cum enim.\nLabore sint ut rerum exercitationem autem omnis id nulla excepturi.", "https://picsum.photos/640/480/?image=1002", "Ryan Dare V", 7, 1.0, 643, new DateTime(2022, 11, 1, 13, 39, 7, 983, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis non enim sint iste.", new DateTime(2023, 5, 8, 8, 35, 36, 386, DateTimeKind.Local).AddTicks(4718), "Enim harum quia occaecati eum.\nNemo aut aliquid voluptatem distinctio sit ea molestiae.\nAut et odit ratione veniam amet.", "https://picsum.photos/640/480/?image=54", "Mr. Rudy Johnson", 8, 4.0, 1240, new DateTime(2023, 5, 8, 13, 50, 15, 373, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nemo vel architecto modi quos pariatur praesentium et.", new DateTime(2023, 5, 7, 21, 57, 43, 485, DateTimeKind.Local).AddTicks(968), "Quibusdam repellendus est.\nNon aut qui minima consequuntur aliquid eum nihil hic.\nUt expedita provident voluptatem officia sunt fuga voluptatem nesciunt.\nRatione maxime architecto est.\nEst voluptate a iure eum et.", "https://picsum.photos/640/480/?image=229", "Barbara Roberts II", 2.0, 608, new DateTime(2022, 6, 15, 6, 0, 46, 897, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eius quaerat sit vel.", new DateTime(2023, 5, 8, 19, 28, 44, 990, DateTimeKind.Local).AddTicks(6307), "Corporis voluptatem iure.\nEaque minima veniam sunt nostrum.\nLaboriosam vel illum ut et at officia animi non quibusdam.", "https://picsum.photos/640/480/?image=747", "Mr. Judith Conroy", 2, 5.0, 2263, new DateTime(2022, 10, 12, 7, 43, 16, 961, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem tempore quae perferendis minus sed cum corrupti totam temporibus.", new DateTime(2023, 5, 8, 17, 38, 47, 805, DateTimeKind.Local).AddTicks(5519), "Dolore consequatur reprehenderit ullam.\nTotam velit aspernatur dolore ut et dolorum quas maxime dolorum.", "https://picsum.photos/640/480/?image=1053", "Sherry Walter Sr.", 6, 1.0, 1176, new DateTime(2023, 5, 8, 9, 20, 34, 523, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptate ad sed voluptatem quibusdam soluta.", new DateTime(2023, 5, 8, 0, 55, 9, 988, DateTimeKind.Local).AddTicks(6556), "Qui dolores soluta ut ut aut.", "https://picsum.photos/640/480/?image=993", "Ms. Tommie Von", 3, 1548, new DateTime(2023, 5, 3, 1, 38, 18, 58, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Natus unde alias numquam sunt est.", new DateTime(2023, 5, 7, 22, 17, 3, 861, DateTimeKind.Local).AddTicks(600), "Id ut dolorum eaque et incidunt illo neque.\nDelectus eaque ipsa reiciendis non.\nPerferendis molestiae mollitia.\nEt consequuntur doloribus nisi vel omnis minus quia.", "https://picsum.photos/640/480/?image=852", "Benjamin Stokes MD", 1, 3.0, 1148, new DateTime(2023, 2, 20, 21, 58, 29, 160, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum aut quo illo sit omnis.", new DateTime(2023, 5, 8, 19, 47, 29, 396, DateTimeKind.Local).AddTicks(5074), "Vero ad cupiditate natus aperiam.\nVitae vero vitae ex unde et nisi.\nQuia in aut in deserunt nostrum aliquid libero omnis voluptates.\nPraesentium necessitatibus qui occaecati porro enim ut minus qui amet.\nDolorem in atque explicabo atque maxime quaerat.", "https://picsum.photos/640/480/?image=692", "Forrest Trantow I", 9, 2.0, 937, new DateTime(2023, 2, 21, 17, 22, 55, 350, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Deleniti ut odit sequi inventore aspernatur quia.", new DateTime(2023, 5, 8, 8, 54, 53, 138, DateTimeKind.Local).AddTicks(7791), "Dolorem explicabo nemo.\nNeque atque consequuntur quas totam ea qui rem.\nNumquam dolor quo.", "https://picsum.photos/640/480/?image=974", "Miss Ramon Lockman", 4, 5.0, 1130, new DateTime(2022, 6, 9, 9, 34, 54, 168, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Placeat et sed quod.", new DateTime(2023, 5, 8, 3, 37, 50, 226, DateTimeKind.Local).AddTicks(6541), "Ullam odit corrupti et consequatur fugit id tempora autem.\nMagni repellat id ratione dolores.\nEt qui tempore repellat voluptatem.\nQuam dicta natus consequatur quisquam et numquam pariatur.\nQui sed est nostrum dolores dicta.", "https://picsum.photos/640/480/?image=281", "Gary Rowe III", 6, 3.0, 708, new DateTime(2022, 9, 29, 4, 18, 20, 663, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempora molestiae voluptate adipisci rerum.", new DateTime(2023, 5, 8, 13, 1, 57, 181, DateTimeKind.Local).AddTicks(1189), "Autem unde et quis doloribus voluptatem ullam aut consequuntur.\nEnim ducimus pariatur et architecto quaerat autem dolorem molestiae.\nAssumenda atque nisi.\nEt consequatur quis est animi voluptate culpa.", "https://picsum.photos/640/480/?image=499", "Darnell Brakus Jr.", 2, 4.0, 751, new DateTime(2022, 12, 10, 1, 36, 12, 301, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est expedita explicabo ratione inventore tempore accusamus omnis.", new DateTime(2023, 5, 8, 16, 34, 34, 135, DateTimeKind.Local).AddTicks(5578), "Inventore aut odit aut ducimus.\nDebitis nemo ipsum dolor nobis.\nEarum nam consequatur minus porro eum et.", "https://picsum.photos/640/480/?image=408", "Ralph Harris DDS", 9, 4.0, 1760, new DateTime(2022, 6, 10, 12, 44, 5, 791, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas magnam ratione.", new DateTime(2023, 5, 8, 10, 10, 17, 289, DateTimeKind.Local).AddTicks(8713), "Ut perferendis ratione et.\nAutem quos nulla aperiam ad.", "https://picsum.photos/640/480/?image=876", "Mr. Edmond Nienow", 2, 1874, new DateTime(2022, 10, 30, 20, 21, 44, 281, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Itaque in qui quos sint.", new DateTime(2023, 5, 8, 18, 29, 22, 105, DateTimeKind.Local).AddTicks(8220), "Ut qui iure fugit vel mollitia non.\nVoluptatem expedita illum.", "https://picsum.photos/640/480/?image=90", "Carrie Pfannerstill Sr.", 7, 5.0, 1692, new DateTime(2022, 6, 22, 17, 53, 1, 510, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Modi quia qui.", new DateTime(2023, 5, 8, 10, 58, 44, 729, DateTimeKind.Local).AddTicks(841), "Tempore id ipsum et ut non hic.\nHic earum qui dolorum impedit ut maiores impedit assumenda.\nOfficiis consequatur quis autem aut hic asperiores dolores nisi et.\nQui natus ut est sunt.", "https://picsum.photos/640/480/?image=544", "Mr. Mark Feil", 5, 4.0, 1582, new DateTime(2023, 2, 8, 15, 22, 9, 505, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolorem sapiente ut autem consequatur aut.", new DateTime(2023, 5, 8, 10, 32, 13, 801, DateTimeKind.Local).AddTicks(6324), "Aperiam eos suscipit modi commodi recusandae voluptate consectetur id ipsam.\nSunt in necessitatibus voluptas suscipit suscipit dicta.\nMolestias dolore quo quae qui labore.\nEst amet velit in.", "https://picsum.photos/640/480/?image=681", "Andres Weissnat IV", 7, 4.0, 1031, new DateTime(2022, 5, 13, 6, 14, 36, 100, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Temporibus sunt ullam culpa deleniti et quos ratione.", new DateTime(2023, 5, 8, 15, 3, 49, 968, DateTimeKind.Local).AddTicks(1567), "Quis maxime nesciunt.\nFugiat autem voluptatem.\nAtque explicabo et delectus neque culpa dolor ipsam soluta.\nAtque tempore ab est est.", "https://picsum.photos/640/480/?image=25", "Frances Brekke PhD", 2.0, 2178, new DateTime(2022, 9, 7, 4, 35, 11, 354, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nobis quae omnis quibusdam animi incidunt et eius beatae.", new DateTime(2023, 5, 7, 20, 34, 58, 222, DateTimeKind.Local).AddTicks(503), "Libero facilis at.\nAperiam velit ut sit ex.\nQuibusdam sit quis cumque dolorem qui qui qui.", "https://picsum.photos/640/480/?image=416", "Ms. Donna Deckow", 8, 4.0, 1345, new DateTime(2022, 7, 8, 23, 12, 2, 771, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Doloremque temporibus rerum et possimus molestiae.", new DateTime(2023, 5, 8, 2, 35, 6, 327, DateTimeKind.Local).AddTicks(5184), "Neque recusandae nostrum voluptates quia doloribus incidunt.\nMaxime quis quam et placeat sint consequatur repudiandae.\nAut veniam nihil aut quam et commodi.\nQui magnam libero est.\nDolor et maiores omnis ratione doloribus rerum.", "https://picsum.photos/640/480/?image=794", "Dr. Clayton Haley", 2, 2429, new DateTime(2022, 12, 6, 22, 6, 55, 776, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Magni tempore praesentium eaque omnis minima voluptas.", new DateTime(2023, 5, 8, 3, 47, 23, 423, DateTimeKind.Local).AddTicks(9169), "Voluptatem minus et et aut excepturi pariatur pariatur assumenda.\nVoluptate ipsum atque officiis occaecati exercitationem voluptates ut.\nTemporibus impedit doloremque quia non ipsam illum optio dolore ut.\nAsperiores libero quis hic dignissimos qui omnis animi.", "https://picsum.photos/640/480/?image=966", "Edwin Aufderhar V", 6, 1775, new DateTime(2023, 2, 1, 23, 1, 39, 393, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Similique rerum totam eos est voluptatibus.", new DateTime(2023, 5, 8, 6, 21, 25, 563, DateTimeKind.Local).AddTicks(8928), "Dolorem sit iure consequatur cupiditate et fugiat quaerat voluptates.\nDistinctio consequuntur aspernatur sit.\nMollitia incidunt id velit laudantium facere molestiae reiciendis quasi.\nMagni nulla ducimus pariatur a in.\nUllam consequatur facere laboriosam consequuntur quo placeat provident.", "https://picsum.photos/640/480/?image=544", "Ismael MacGyver III", 3, 2.0, 528, new DateTime(2022, 5, 13, 22, 19, 40, 940, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit quam reiciendis.", new DateTime(2023, 5, 8, 2, 17, 12, 871, DateTimeKind.Local).AddTicks(9689), "Magnam sit iusto temporibus distinctio praesentium asperiores et consequatur cumque.\nEt incidunt delectus accusamus sit aut.", "https://picsum.photos/640/480/?image=546", "Mrs. Krista Bauch", 6, 3.0, 594, new DateTime(2022, 6, 5, 8, 16, 39, 963, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Itaque eum in necessitatibus voluptas.", new DateTime(2023, 5, 7, 20, 36, 18, 803, DateTimeKind.Local).AddTicks(9963), "Alias esse aut fugit.", "https://picsum.photos/640/480/?image=746", "Mr. Shaun Gislason", 4, 4.0, 2142, new DateTime(2022, 9, 6, 3, 6, 20, 268, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Similique deleniti itaque.", new DateTime(2023, 5, 8, 5, 49, 30, 748, DateTimeKind.Local).AddTicks(1336), "Quasi commodi saepe asperiores fuga amet iure aut debitis.\nUt architecto provident.", "https://picsum.photos/640/480/?image=557", "Leland Waelchi V", 1, 918, new DateTime(2022, 5, 30, 22, 0, 46, 177, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Enim dolorem dolores reiciendis voluptatem fugit laboriosam alias.", new DateTime(2023, 5, 8, 17, 3, 4, 342, DateTimeKind.Local).AddTicks(1503), "Molestias sequi quia architecto sunt eos aut.\nDucimus aut ea.\nAd recusandae beatae et esse ducimus veritatis aut nihil odit.\nOmnis ab suscipit et delectus.\nQui rem quos id molestiae tempore quas saepe.", "https://picsum.photos/640/480/?image=458", "Ms. Ernestine Cartwright", 834, new DateTime(2022, 10, 20, 9, 46, 53, 765, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Officia est sit velit cumque provident ad qui quia ducimus.", new DateTime(2023, 5, 8, 11, 31, 16, 981, DateTimeKind.Local).AddTicks(76), "Quod voluptatem voluptas.", "https://picsum.photos/640/480/?image=718", "Mr. Essie Nikolaus", 4, 5.0, 2260, new DateTime(2022, 7, 22, 18, 6, 37, 232, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Recusandae quaerat cupiditate omnis atque voluptates voluptatem blanditiis dicta.", new DateTime(2023, 5, 8, 13, 41, 23, 787, DateTimeKind.Local).AddTicks(7337), "Vero ut nisi quidem neque.\nEst magnam nihil quod voluptas error aliquam.\nRepellendus rem commodi expedita eos non laborum.\nVelit reprehenderit repudiandae harum et.\nVoluptatum maiores sit sunt provident pariatur et.", "https://picsum.photos/640/480/?image=99", "Rose Reynolds I", 6, 1.0, 1507, new DateTime(2022, 7, 17, 0, 48, 27, 720, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Impedit tempora laborum tenetur asperiores sit repellat pariatur.", new DateTime(2023, 5, 8, 16, 10, 29, 116, DateTimeKind.Local).AddTicks(8753), "Velit quod ab suscipit illum aliquid deleniti.\nNeque est dicta.", "https://picsum.photos/640/480/?image=881", "Roosevelt Stark I", 7, 4.0, 1029, new DateTime(2023, 2, 22, 20, 51, 24, 781, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nihil mollitia dignissimos corrupti voluptas.", new DateTime(2023, 5, 8, 19, 4, 28, 939, DateTimeKind.Local).AddTicks(5359), "Voluptate et ut ut.\nSuscipit veritatis et aliquid sed.", "https://picsum.photos/640/480/?image=611", "Ervin Cassin PhD", 5, 1.0, 2377, new DateTime(2022, 8, 2, 2, 54, 39, 759, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis quidem quo illum sapiente omnis sit.", new DateTime(2023, 5, 8, 8, 33, 56, 486, DateTimeKind.Local).AddTicks(5794), "Necessitatibus corrupti fugiat voluptatem enim vel blanditiis qui.\nQui est reprehenderit vitae.\nQuos reprehenderit voluptas voluptatibus qui qui aut error voluptas.", "https://picsum.photos/640/480/?image=692", "Miss Crystal Braun", 2177, new DateTime(2023, 3, 31, 0, 16, 49, 35, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptates dolor fuga.", new DateTime(2023, 5, 8, 17, 1, 24, 616, DateTimeKind.Local).AddTicks(8964), "Vitae in odio eum id repudiandae suscipit veniam.\nAutem est et sequi non delectus qui voluptatum.", "https://picsum.photos/640/480/?image=467", "Trevor Fahey MD", 1, 4.0, 2245, new DateTime(2022, 12, 20, 3, 59, 19, 399, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quidem alias non ipsam quaerat aut soluta deserunt ut repudiandae.", new DateTime(2023, 5, 8, 9, 54, 56, 998, DateTimeKind.Local).AddTicks(288), "Eligendi eum quam labore beatae est ut.\nNulla non voluptatibus molestias eum dolorem beatae.", "https://picsum.photos/640/480/?image=966", "Cora Johns DDS", 3, 4.0, 2366, new DateTime(2022, 8, 31, 15, 31, 6, 178, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Non sit et modi et veniam eum temporibus voluptatem.", new DateTime(2023, 5, 8, 14, 15, 12, 405, DateTimeKind.Local).AddTicks(7661), "Modi repudiandae est autem.\nVeritatis non rerum quae.\nFacilis enim vero consequuntur eos iusto perferendis explicabo ut aut.\nRatione aut dolore ea nesciunt rem atque quasi.", "https://picsum.photos/640/480/?image=289", "Ms. Annie Hammes", 3.0, 638, new DateTime(2023, 3, 14, 16, 42, 47, 601, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed molestiae iusto.", new DateTime(2023, 5, 8, 5, 37, 45, 679, DateTimeKind.Local).AddTicks(4561), "Et optio consectetur accusamus qui impedit.\nCommodi quae animi.", "https://picsum.photos/640/480/?image=544", "Miss Harry Waelchi", 7, 1059, new DateTime(2022, 11, 13, 2, 29, 12, 298, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui quae eaque fugit quis provident consequatur dicta tenetur tempore.", new DateTime(2023, 5, 7, 21, 46, 59, 144, DateTimeKind.Local).AddTicks(6068), "Iusto aliquam eos doloribus est harum sint nam itaque.\nMagnam aut dolorum cupiditate sed quis ipsa sint.\nFacere molestias doloremque ut architecto aut.", "https://picsum.photos/640/480/?image=190", "Miss Taylor Champlin", 9, 3.0, 1626, new DateTime(2023, 2, 16, 12, 53, 26, 864, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Deserunt nemo voluptatibus est.", new DateTime(2023, 5, 7, 23, 11, 26, 709, DateTimeKind.Local).AddTicks(8237), "Illum molestias voluptate exercitationem quam.", "https://picsum.photos/640/480/?image=783", "Mrs. Edith Wyman", 10, 2204, new DateTime(2023, 1, 8, 17, 14, 17, 719, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Enim qui aspernatur aspernatur quos asperiores.", new DateTime(2023, 5, 8, 2, 54, 2, 597, DateTimeKind.Local).AddTicks(4337), "Quasi nihil aut id modi recusandae veniam consequuntur.\nSit et omnis sapiente deleniti sunt eum ea amet.\nUt at facilis nihil magnam minima non eos et.", "https://picsum.photos/640/480/?image=500", "Fannie O'Hara V", 4, 5.0, 599, new DateTime(2022, 9, 13, 21, 42, 34, 601, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed esse nihil ut.", new DateTime(2023, 5, 8, 19, 34, 35, 93, DateTimeKind.Local).AddTicks(3115), "Et ut earum.\nNon aut doloremque tempora qui tempore consequuntur.\nEsse et ducimus enim illum maxime ut repellat dolores deserunt.\nQuo est qui labore debitis consequatur porro.", "https://picsum.photos/640/480/?image=8", "Miss Eva Schaefer", 2, 2.0, 1175, new DateTime(2022, 12, 24, 23, 10, 27, 330, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Optio neque molestiae vel ipsam nam doloremque vel.", new DateTime(2023, 5, 8, 0, 56, 9, 878, DateTimeKind.Local).AddTicks(3481), "At odit temporibus blanditiis.\nExercitationem provident ducimus aut.", "https://picsum.photos/640/480/?image=393", "Dr. Tracey Bartell", 9, 3.0, 1347, new DateTime(2022, 7, 22, 16, 52, 1, 688, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Deleniti ut harum eius temporibus harum tempora facere aut.", new DateTime(2023, 5, 8, 8, 16, 13, 335, DateTimeKind.Local).AddTicks(7405), "Blanditiis sint voluptatem sint enim.\nEt est tenetur enim qui quisquam aut.\nEt amet repudiandae quo et veniam.", "https://picsum.photos/640/480/?image=369", "Mrs. Viola Medhurst", 8, 5.0, 1925, new DateTime(2022, 12, 14, 23, 44, 17, 501, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quia sed reiciendis velit consequatur voluptates voluptatem.", new DateTime(2023, 5, 7, 22, 53, 12, 827, DateTimeKind.Local).AddTicks(5217), "Cum et dolorem sint ullam ratione recusandae.\nEligendi sit voluptatibus velit rerum sit eligendi esse.", "https://picsum.photos/640/480/?image=926", "Jose Weimann IV", 5, 3.0, 559, new DateTime(2023, 4, 8, 6, 58, 11, 513, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et vel libero consequatur laborum debitis.", new DateTime(2023, 5, 8, 5, 43, 37, 132, DateTimeKind.Local).AddTicks(5080), "Quia voluptates ipsam quo exercitationem quis cumque quo assumenda omnis.\nAut corrupti perspiciatis dolorum id.\nOptio et aut dolorem sunt.\nDolorem et consequuntur.", "https://picsum.photos/640/480/?image=628", "Dr. Lynn Cole", 9, 4.0, 2407, new DateTime(2022, 7, 5, 22, 3, 48, 208, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rerum eligendi et qui tempore et provident voluptas expedita nobis.", new DateTime(2023, 5, 8, 15, 0, 27, 164, DateTimeKind.Local).AddTicks(3250), "Vitae iste et.\nVoluptatum omnis est id est exercitationem porro possimus.\nEst reiciendis vel velit voluptatem recusandae ab quae.", "https://picsum.photos/640/480/?image=755", "Ms. Peter McGlynn", 1, 4.0, 1644, new DateTime(2022, 8, 8, 7, 19, 44, 96, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eos adipisci voluptatum nihil.", new DateTime(2023, 5, 8, 12, 27, 24, 63, DateTimeKind.Local).AddTicks(6254), "Ut consequatur ipsum consequatur ipsam nesciunt sed amet.\nConsectetur et doloribus minima voluptas.\nEnim quisquam ipsa doloremque aut alias rem unde.", "https://picsum.photos/640/480/?image=241", "Mr. Jake Kuphal", 5, 4.0, 2190, new DateTime(2022, 8, 4, 3, 11, 38, 635, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Vel fugiat labore quia magnam nam qui voluptates sit.", new DateTime(2023, 5, 8, 0, 59, 32, 985, DateTimeKind.Local).AddTicks(919), "Quaerat eos et.\nDolore sint consequatur dolor aut commodi est modi.\nEum facere unde quos et ut nobis excepturi laudantium voluptatum.\nOmnis voluptatum ut aut.", "https://picsum.photos/640/480/?image=913", "Roberto Nitzsche III", 8, 1.0, 1250, new DateTime(2022, 12, 30, 9, 51, 44, 124, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quidem consequatur culpa animi et numquam sint nobis beatae ipsam.", new DateTime(2023, 5, 8, 11, 17, 48, 414, DateTimeKind.Local).AddTicks(2725), "Vitae et harum nihil et ducimus odio laudantium recusandae consequatur.\nNeque autem expedita et deleniti labore qui voluptate.\nConsectetur numquam accusantium laborum maiores voluptas dolores.\nMolestiae voluptatibus eum sunt.", "https://picsum.photos/640/480/?image=265", "Bradley Emard MD", 3, 4.0, 707, new DateTime(2023, 4, 3, 7, 6, 58, 674, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eaque numquam sed quasi vel sequi omnis.", new DateTime(2023, 5, 8, 11, 47, 3, 105, DateTimeKind.Local).AddTicks(2024), "Mollitia rerum quis reiciendis culpa nihil eligendi porro praesentium sapiente.\nPariatur iure aut debitis et.\nNesciunt omnis eum possimus numquam et et.", "https://picsum.photos/640/480/?image=1062", "Ms. Wilson Jacobson", 2, 3.0, 2118, new DateTime(2022, 5, 11, 7, 20, 29, 185, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iusto eaque voluptas impedit adipisci.", new DateTime(2023, 5, 8, 4, 55, 41, 131, DateTimeKind.Local).AddTicks(6258), "Vel perspiciatis nisi fugiat ipsam qui.\nTempore et sapiente enim.", "https://picsum.photos/640/480/?image=194", "Lamar Bednar II", 1, 5.0, 2096, new DateTime(2022, 6, 19, 17, 41, 27, 65, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Mollitia sequi qui illum dolor unde quo.", new DateTime(2023, 5, 8, 14, 22, 31, 392, DateTimeKind.Local).AddTicks(2471), "Sunt voluptas et.\nDebitis perspiciatis dolore.\nMinima occaecati magnam perferendis sit rem.", "https://picsum.photos/640/480/?image=783", "Eric Lubowitz III", 8, 1221, new DateTime(2022, 6, 26, 22, 6, 27, 190, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et consequuntur quisquam qui.", new DateTime(2023, 5, 7, 21, 58, 7, 788, DateTimeKind.Local).AddTicks(9793), "Voluptate repellat quasi ipsum.\nEnim aperiam est aut exercitationem quia.\nAlias nisi qui sint qui necessitatibus reprehenderit eos doloribus nesciunt.\nDelectus quae dolores quam rerum corporis.", "https://picsum.photos/640/480/?image=378", "Franklin Batz IV", 1, 1636, new DateTime(2023, 3, 10, 9, 23, 18, 309, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est cum dolores dicta consequuntur voluptatibus et esse.", new DateTime(2023, 5, 8, 4, 21, 45, 222, DateTimeKind.Local).AddTicks(4230), "Occaecati nisi cumque voluptas inventore cum dolores ut iste.\nAd non consequatur placeat dignissimos libero aut.", "https://picsum.photos/640/480/?image=88", "Mr. Marion Smith", 2, 5.0, 1372, new DateTime(2023, 5, 7, 20, 46, 20, 467, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nobis dolorum earum ut dolorem omnis quibusdam nihil.", new DateTime(2023, 5, 8, 19, 51, 35, 412, DateTimeKind.Local).AddTicks(7721), "Praesentium praesentium voluptatibus doloremque placeat.", "https://picsum.photos/640/480/?image=613", "Alicia West IV", 1, 4.0, 1366, new DateTime(2023, 4, 28, 12, 38, 55, 224, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut libero est et et.", new DateTime(2023, 5, 7, 21, 5, 2, 810, DateTimeKind.Local).AddTicks(3014), "Rerum facere natus cupiditate voluptatem.", "https://picsum.photos/640/480/?image=791", "Tyrone Rogahn III", 1, 1895, new DateTime(2022, 6, 14, 17, 36, 9, 751, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et dolore non odit odio odit quisquam.", new DateTime(2023, 5, 8, 1, 37, 41, 698, DateTimeKind.Local).AddTicks(9765), "Tempora sequi eos voluptate quam reiciendis fugiat.", "https://picsum.photos/640/480/?image=423", "Ms. Erma Pagac", 1, 5.0, 1623, new DateTime(2023, 4, 9, 23, 0, 22, 393, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Occaecati ut vitae tenetur qui voluptatibus.", new DateTime(2023, 5, 8, 18, 59, 32, 984, DateTimeKind.Local).AddTicks(7869), "Eum voluptatem libero ad quia.\nSimilique dolorem omnis ea consequatur aut necessitatibus consequuntur sit.\nArchitecto repellat sed voluptatem voluptas error minima.", "https://picsum.photos/640/480/?image=11", "Andre Hermann PhD", 6, 1.0, 1944, new DateTime(2022, 12, 24, 3, 16, 53, 597, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Unde cum deleniti rerum.", new DateTime(2023, 5, 8, 2, 39, 6, 126, DateTimeKind.Local).AddTicks(4690), "Voluptas qui consequuntur et quia alias.\nIpsum qui et qui et laboriosam.", "https://picsum.photos/640/480/?image=788", "Ms. Myrtle Harber", 8, 2009, new DateTime(2022, 5, 28, 17, 8, 10, 245, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Rem ab odit nam doloribus aliquam et consequatur fuga.", new DateTime(2023, 5, 8, 6, 11, 28, 745, DateTimeKind.Local).AddTicks(1908), "Velit harum distinctio nihil aut et accusantium.\nSunt eveniet aliquam beatae ipsam quae est enim optio officiis.", "https://picsum.photos/640/480/?image=292", "Dr. Travis Hammes", 7, 2.0, 1776, new DateTime(2022, 12, 11, 15, 37, 44, 638, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ex velit expedita adipisci accusamus et eveniet aspernatur sequi.", new DateTime(2023, 5, 7, 23, 3, 21, 438, DateTimeKind.Local).AddTicks(7353), "Hic veritatis aperiam quod odio nulla suscipit vel maiores.", "https://picsum.photos/640/480/?image=168", "Mrs. Elvira Littel", 10, 4.0, 1673, new DateTime(2022, 11, 18, 6, 6, 19, 765, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Minus explicabo deserunt eos aspernatur dolor corrupti nobis et esse.", new DateTime(2023, 5, 8, 9, 16, 44, 252, DateTimeKind.Local).AddTicks(5728), "Dolore distinctio sint.\nEnim consequatur vel.\nAliquid totam quis quia minima tempore.\nQui quo atque et ab dolore aperiam placeat.\nQuae quas praesentium est omnis non laborum sapiente est dolores.", "https://picsum.photos/640/480/?image=749", "Dr. Elisa Bartell", 2, 3.0, 899, new DateTime(2022, 6, 1, 9, 28, 19, 16, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Numquam doloremque adipisci dolores maiores quis quisquam architecto asperiores explicabo.", new DateTime(2023, 5, 8, 15, 23, 11, 602, DateTimeKind.Local).AddTicks(7764), "Quo temporibus sed est dicta.\nAut omnis consequatur dolorem est dolorem sint tenetur.\nEt voluptatem commodi aspernatur tempora fugit odio et voluptate eos.\nAut vel nostrum assumenda maiores quae.\nSequi aut et consequatur autem praesentium est et.", "https://picsum.photos/640/480/?image=747", "Dr. Donnie Bergnaum", 3, 2.0, 1983, new DateTime(2022, 12, 26, 22, 32, 43, 881, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Veritatis quia dignissimos aut omnis et sunt ut.", new DateTime(2023, 5, 8, 11, 47, 6, 509, DateTimeKind.Local).AddTicks(7852), "Culpa non tenetur et dicta.\nEt voluptas quia labore dolorum aliquid doloremque.\nCum voluptate magni molestiae quo beatae maxime et.\nPariatur voluptas numquam sint officia et dolor aliquid et distinctio.", "https://picsum.photos/640/480/?image=137", "Dennis Trantow MD", 5, 2.0, 797, new DateTime(2022, 10, 21, 10, 17, 49, 532, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repellendus illo qui dolore vel cumque voluptatibus necessitatibus.", new DateTime(2023, 5, 8, 4, 3, 19, 64, DateTimeKind.Local).AddTicks(9923), "Ducimus cumque placeat dignissimos.", "https://picsum.photos/640/480/?image=623", "Brooke Ebert DVM", 10, 2.0, 1626, new DateTime(2022, 7, 1, 12, 46, 10, 692, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem ea sed quasi quisquam atque sed quis.", new DateTime(2023, 5, 8, 14, 4, 55, 50, DateTimeKind.Local).AddTicks(5870), "Fugit minima quia sit velit et ut deleniti similique.", "https://picsum.photos/640/480/?image=731", "Mrs. Ben Botsford", 6, 2.0, 1336, new DateTime(2022, 6, 20, 20, 30, 30, 983, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Suscipit veniam sapiente sed quos laborum.", new DateTime(2023, 5, 7, 23, 2, 1, 350, DateTimeKind.Local).AddTicks(3722), "Ad autem nostrum id nesciunt.\nQuibusdam perspiciatis rem doloremque totam.\nPerspiciatis qui id odio eius distinctio magnam soluta rerum.", "https://picsum.photos/640/480/?image=366", "Sean Thiel DVM", 2.0, 2223, new DateTime(2022, 8, 24, 3, 42, 21, 603, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cum nam quibusdam molestias dolor autem omnis omnis et.", new DateTime(2023, 5, 8, 15, 13, 22, 221, DateTimeKind.Local).AddTicks(7961), "Voluptas et omnis.", "https://picsum.photos/640/480/?image=918", "Miss Alfred Russel", 7, 1.0, 2416, new DateTime(2022, 12, 8, 21, 4, 50, 92, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sint quasi doloribus et laboriosam laborum.", new DateTime(2023, 5, 8, 11, 17, 11, 452, DateTimeKind.Local).AddTicks(863), "Corporis omnis neque et.\nVoluptates sapiente velit dolores est qui eius impedit itaque.\nCupiditate aut neque quisquam.\nMollitia corrupti et error aliquid velit aliquam excepturi dolores.\nVeniam necessitatibus accusamus sint aperiam tempore.", "https://picsum.photos/640/480/?image=462", "Mr. Tomas Borer", 2, 5.0, 1539, new DateTime(2022, 12, 31, 12, 59, 44, 188, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Molestiae ipsa cupiditate minima.", new DateTime(2023, 5, 8, 4, 47, 57, 929, DateTimeKind.Local).AddTicks(9369), "Fugiat consequatur similique.\nFuga aut libero temporibus mollitia placeat vel.", "https://picsum.photos/640/480/?image=1002", "Mr. Tommy Schuppe", 3, 4.0, 1895, new DateTime(2022, 12, 26, 4, 48, 24, 200, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quas sint ut est culpa culpa amet.", new DateTime(2023, 5, 7, 23, 42, 15, 548, DateTimeKind.Local).AddTicks(372), "Ab ratione qui saepe animi est assumenda dolorem cumque.\nDolorem corrupti sed dolores voluptas nam facere praesentium.\nDeserunt consectetur in est necessitatibus quo non dolorum voluptas ut.\nDoloribus ut aspernatur sit laboriosam.\nEum ea similique cumque.", "https://picsum.photos/640/480/?image=415", "Mrs. Lillie Homenick", 5, 5.0, 1485, new DateTime(2022, 9, 9, 21, 35, 50, 198, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Error voluptates rerum perspiciatis ratione delectus repudiandae repellendus.", new DateTime(2023, 5, 8, 6, 38, 6, 4, DateTimeKind.Local).AddTicks(7859), "Fugit animi voluptas enim aut fugit ut.\nAb aut facilis in recusandae.\nMaxime commodi ipsum autem rerum modi voluptatem.\nNon reprehenderit itaque recusandae consequatur est perferendis nam.\nSunt hic excepturi eius et aut vero vero et neque.", "https://picsum.photos/640/480/?image=43", "Miss Bernard Koch", 6, 4.0, 1964, new DateTime(2022, 11, 5, 19, 2, 48, 193, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur odio aperiam commodi non architecto eaque cupiditate quas quia.", new DateTime(2023, 5, 8, 17, 35, 0, 686, DateTimeKind.Local).AddTicks(3439), "Explicabo est dolores quos.\nImpedit suscipit maiores quaerat ab voluptas quia suscipit ut tempore.", "https://picsum.photos/640/480/?image=352", "Mildred Hartmann Jr.", 5, 5.0, 2352, new DateTime(2022, 10, 9, 4, 59, 48, 635, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et velit quia in nostrum distinctio.", new DateTime(2023, 5, 8, 2, 38, 33, 998, DateTimeKind.Local).AddTicks(5281), "Temporibus deserunt molestias laboriosam sequi.\nQui illum repellat.\nEt odio fugit.", "https://picsum.photos/640/480/?image=325", "Ms. Ernestine Barrows", 7, 554, new DateTime(2023, 4, 12, 20, 4, 5, 902, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est doloremque odio officiis atque quia incidunt ut.", new DateTime(2023, 5, 8, 17, 6, 21, 811, DateTimeKind.Local).AddTicks(1), "Vitae aut est exercitationem magni provident et.\nRerum deserunt sint sed sit aut omnis et ratione totam.", "https://picsum.photos/640/480/?image=154", "Mrs. Marian Reichel", 1, 5.0, 1013, new DateTime(2022, 7, 10, 8, 45, 18, 578, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Neque porro minima.", new DateTime(2023, 5, 8, 1, 16, 5, 753, DateTimeKind.Local).AddTicks(5912), "Aliquid numquam rem.\nEa non sint.\nRatione voluptatem numquam.\nEum voluptatem quo ab rerum.\nIllum labore soluta aut neque ex nihil est.", "https://picsum.photos/640/480/?image=692", "Candace Bernhard III", 7, 2.0, 978, new DateTime(2023, 1, 3, 18, 2, 59, 162, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Magnam quae magnam voluptatem facere et quisquam voluptas inventore quo.", new DateTime(2023, 5, 8, 15, 0, 25, 536, DateTimeKind.Local).AddTicks(8708), "Porro tempore possimus maiores qui consequatur.\nPraesentium laborum nulla fuga veniam fugit et.\nMagnam incidunt assumenda quis.\nRatione magnam repellendus sit.\nMaiores mollitia est adipisci voluptas ratione voluptas est.", "https://picsum.photos/640/480/?image=579", "Mrs. Rodney Schneider", 8, 5.0, 1532, new DateTime(2022, 7, 18, 3, 4, 46, 224, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Adipisci neque necessitatibus quasi id.", new DateTime(2023, 5, 7, 20, 31, 42, 130, DateTimeKind.Local).AddTicks(9874), "Ut sed amet ea tempore quo qui consequuntur.\nEaque consequuntur temporibus.\nSint non sit iusto maiores est sunt.\nSaepe explicabo molestias illo error suscipit.\nNon accusantium et incidunt.", "https://picsum.photos/640/480/?image=300", "Jackie Dibbert I", 2, 1.0, 1058, new DateTime(2022, 9, 17, 20, 30, 30, 837, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Asperiores iusto quod sunt optio.", new DateTime(2023, 5, 7, 23, 53, 53, 450, DateTimeKind.Local).AddTicks(2443), "Cumque deserunt dolores autem.\nQui facilis illum eum voluptatem eaque voluptates.\nSit velit dolor molestiae et aspernatur dolore accusamus.", "https://picsum.photos/640/480/?image=810", "Dr. Gail Goyette", 9, 3.0, 1508, new DateTime(2022, 9, 4, 23, 8, 58, 286, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut velit aliquam aut voluptas.", new DateTime(2023, 5, 8, 11, 42, 57, 373, DateTimeKind.Local).AddTicks(1427), "Ipsam sunt beatae sed deserunt natus distinctio.\nVoluptates eum cumque sapiente porro necessitatibus aut cum quis cum.\nQuo et error dolorum voluptatibus libero enim.\nBeatae quasi qui commodi incidunt qui qui et esse ducimus.", "https://picsum.photos/640/480/?image=259", "Mr. Willie Marvin", 6, 5.0, 1836, new DateTime(2022, 7, 21, 2, 52, 46, 804, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Temporibus minus et quo.", new DateTime(2023, 5, 8, 0, 7, 32, 332, DateTimeKind.Local).AddTicks(1551), "Dolorum alias distinctio voluptatem quis.\nEst voluptas est unde magnam quasi iusto et incidunt id.\nVoluptates fugiat quas esse.\nA natus id aut et aut et ea.\nQuisquam animi sunt neque consequatur quo illo dolores.", "https://picsum.photos/640/480/?image=140", "Desiree Shields V", 9, 5.0, 2088, new DateTime(2022, 12, 17, 12, 51, 35, 779, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut ut quos id.", new DateTime(2023, 5, 7, 21, 36, 38, 795, DateTimeKind.Local).AddTicks(2710), "Sit ut qui a dolores exercitationem minus dolorem earum aut.", "https://picsum.photos/640/480/?image=911", "Ms. Ramona Schumm", 5, 2.0, 1471, new DateTime(2022, 7, 4, 23, 46, 41, 827, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tenetur ex porro fugit ad animi aut ea cupiditate.", new DateTime(2023, 5, 8, 7, 36, 40, 307, DateTimeKind.Local).AddTicks(5762), "Nihil perspiciatis iure nesciunt.\nEum et est in quam veritatis quam.\nOfficiis voluptatem esse quod.\nAut illo qui eos accusantium qui rerum.", "https://picsum.photos/640/480/?image=285", "Corey King MD", 9, 1.0, 1144, new DateTime(2023, 3, 8, 20, 12, 0, 81, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est ipsam architecto dignissimos quisquam voluptates aut minus nulla numquam.", new DateTime(2023, 5, 8, 4, 19, 5, 341, DateTimeKind.Local).AddTicks(5455), "Doloremque corporis est at.\nAliquam facere alias quia sit nobis vitae aut aut.", "https://picsum.photos/640/480/?image=999", "Christine Mohr MD", 9, 2.0, 1781, new DateTime(2022, 9, 19, 15, 35, 40, 903, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "A laborum error est veritatis magnam quo aut.", new DateTime(2023, 5, 7, 21, 58, 45, 829, DateTimeKind.Local).AddTicks(1364), "Eos modi et unde possimus aperiam omnis unde et labore.", "https://picsum.photos/640/480/?image=900", "Mr. Betsy Schneider", 10, 1128, new DateTime(2022, 9, 29, 12, 3, 44, 649, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolor voluptatem ut.", new DateTime(2023, 5, 8, 1, 52, 55, 734, DateTimeKind.Local).AddTicks(6935), "Dolor aperiam voluptas occaecati ab magni.", "https://picsum.photos/640/480/?image=85", "Moses Halvorson MD", 6, 1070, new DateTime(2022, 7, 24, 17, 17, 4, 150, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et ullam nostrum non.", new DateTime(2023, 5, 8, 7, 25, 41, 802, DateTimeKind.Local).AddTicks(4540), "Cumque eius aut doloremque atque consequuntur quidem.", "https://picsum.photos/640/480/?image=699", "Phillip Von IV", 2, 1549, new DateTime(2022, 7, 18, 9, 24, 36, 650, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Vel perferendis quibusdam adipisci tenetur et veritatis nemo modi.", new DateTime(2023, 5, 8, 5, 27, 45, 408, DateTimeKind.Local).AddTicks(8207), "Illo autem aliquid eos.", "https://picsum.photos/640/480/?image=327", "Jill Gusikowski Sr.", 2.0, 914, new DateTime(2022, 8, 17, 14, 9, 6, 894, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur animi qui dolores quis assumenda tempora.", new DateTime(2023, 5, 8, 11, 49, 20, 158, DateTimeKind.Local).AddTicks(4263), "Delectus iste dolorem exercitationem quasi.\nPossimus harum quos enim.\nPossimus ut et dolorem consequatur veritatis omnis et.", "https://picsum.photos/640/480/?image=38", "Chester Lockman I", 1, 1502, new DateTime(2022, 8, 19, 20, 16, 50, 692, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eos omnis non eligendi aut nam cum voluptatum.", new DateTime(2023, 5, 8, 12, 48, 34, 324, DateTimeKind.Local).AddTicks(9186), "Quisquam officiis qui et sapiente harum neque aut inventore quas.\nRerum sit ratione dolores qui est.\nQuasi deleniti qui ipsum tempora qui dolores cupiditate totam id.\nDolores qui est assumenda numquam sunt sed in excepturi.\nDucimus id est rem error quo sunt dolor dolor aspernatur.", "https://picsum.photos/640/480/?image=171", "Dr. Hubert Pollich", 1084, new DateTime(2023, 4, 26, 18, 31, 35, 852, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quasi qui magnam.", new DateTime(2023, 5, 8, 4, 30, 50, 902, DateTimeKind.Local).AddTicks(8126), "Molestiae in et voluptatum quibusdam aut quisquam.\nRerum illo quaerat voluptates pariatur.\nDolores voluptas itaque.\nSequi doloremque debitis.\nConsequatur voluptas architecto voluptas labore ipsum qui.", "https://picsum.photos/640/480/?image=426", "Mr. Nancy Trantow", 6, 1.0, 2008, new DateTime(2023, 2, 15, 1, 15, 57, 292, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsam eos magni velit aspernatur unde.", new DateTime(2023, 5, 8, 7, 7, 25, 498, DateTimeKind.Local).AddTicks(3263), "Qui voluptas tempora tempore accusantium incidunt totam in quo.\nNihil rerum et animi ut mollitia sed excepturi.\nNostrum omnis consequatur.", "https://picsum.photos/640/480/?image=637", "Dr. Nicolas Muller", 6, 5.0, 2407, new DateTime(2022, 6, 8, 5, 33, 32, 784, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Tempore in nulla quisquam tempore harum labore et.", new DateTime(2023, 5, 8, 17, 11, 21, 371, DateTimeKind.Local).AddTicks(2107), "Qui at nam aut quia quas consequuntur exercitationem exercitationem.\nDolores ea non fugiat ut fugit quasi dolor culpa.\nIncidunt quo optio possimus beatae aspernatur.\nAccusantium molestiae illo autem.\nUllam optio vitae perferendis earum modi aperiam.", "https://picsum.photos/640/480/?image=1048", "Mr. Wilfred Russel", 9, 5.0, 2353, new DateTime(2023, 3, 20, 3, 15, 0, 712, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut perspiciatis mollitia qui necessitatibus eveniet voluptatem illo aut.", new DateTime(2023, 5, 8, 20, 4, 57, 860, DateTimeKind.Local).AddTicks(1508), "Perspiciatis laborum saepe mollitia accusamus libero.\nAut nemo nostrum non quo aut.\nQuia maxime et et modi accusantium reiciendis aut.\nIncidunt reiciendis aut.\nVeritatis rem delectus praesentium quibusdam quam.", "https://picsum.photos/640/480/?image=370", "Mr. Willard Bechtelar", 8, 2.0, 1049, new DateTime(2022, 11, 8, 2, 23, 10, 92, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Repudiandae aperiam ducimus ipsum mollitia error dicta temporibus velit.", new DateTime(2023, 5, 8, 17, 36, 51, 48, DateTimeKind.Local).AddTicks(1198), "Esse perspiciatis earum iusto sapiente et sed accusamus molestiae explicabo.\nQuaerat et sed qui expedita quidem est sed dolor.", "https://picsum.photos/640/480/?image=552", "Mr. Carroll Walker", 8, 4.0, 2349, new DateTime(2022, 8, 11, 17, 56, 45, 359, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Facere eos non in praesentium consequatur voluptatem et.", new DateTime(2023, 5, 8, 1, 23, 52, 430, DateTimeKind.Local).AddTicks(1041), "Est a labore eius quisquam perferendis voluptas.\nVoluptatibus eveniet eum possimus consectetur ratione id.", "https://picsum.photos/640/480/?image=975", "Jan Gaylord DDS", 6, 3.0, 2071, new DateTime(2023, 3, 10, 4, 12, 58, 694, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Occaecati laboriosam dolores culpa voluptas excepturi in eum.", new DateTime(2023, 5, 8, 15, 41, 35, 577, DateTimeKind.Local).AddTicks(5376), "A dolorem et veritatis maiores.\nSed omnis natus dolores.\nEnim est eaque et aut dolorem sed quia corporis fugiat.", "https://picsum.photos/640/480/?image=233", "Doris Braun III", 9, 3.0, 2163, new DateTime(2023, 4, 17, 9, 39, 57, 791, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Occaecati ut saepe corporis.", new DateTime(2023, 5, 8, 2, 27, 16, 904, DateTimeKind.Local).AddTicks(4638), "Nihil sunt sit quod praesentium voluptatem ex et minus.\nFuga consequuntur qui rerum amet.", "https://picsum.photos/640/480/?image=753", "Nicole Gibson DDS", 2, 4.0, 1513, new DateTime(2022, 11, 28, 12, 38, 8, 230, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Minus soluta architecto quia laboriosam et quaerat.", new DateTime(2023, 5, 8, 2, 5, 16, 434, DateTimeKind.Local).AddTicks(4721), "Qui aut aut.", "https://picsum.photos/640/480/?image=601", "Mrs. Dorothy Gorczany", 10, 1580, new DateTime(2022, 12, 21, 22, 11, 19, 408, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Velit quos voluptas distinctio expedita.", new DateTime(2023, 5, 8, 4, 54, 2, 65, DateTimeKind.Local).AddTicks(2618), "Dolores quaerat sit qui autem voluptatem fugiat maiores.\nVoluptate expedita provident consectetur exercitationem vitae reiciendis quia.\nOmnis sed ut eum assumenda et molestiae numquam autem.", "https://picsum.photos/640/480/?image=713", "Miss Eula Mann", 10, 3.0, 1520, new DateTime(2022, 11, 7, 14, 23, 1, 79, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Optio doloribus magnam.", new DateTime(2023, 5, 8, 16, 55, 4, 954, DateTimeKind.Local).AddTicks(2932), "Rerum impedit ut voluptas omnis dolorem.\nDolore sed voluptas harum vel itaque eveniet est.\nError quo velit.\nAccusantium ipsa at iste quis.", "https://picsum.photos/640/480/?image=422", "Mrs. Kayla Corkery", 6, 3.0, 538, new DateTime(2022, 9, 10, 23, 6, 56, 972, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Reiciendis eaque unde in.", new DateTime(2023, 5, 8, 12, 39, 35, 854, DateTimeKind.Local).AddTicks(1399), "Quae dolorem temporibus ea.\nVel voluptatem reprehenderit modi.\nIn eveniet voluptas quis illum aspernatur fuga sapiente dolor officiis.\nUt repellendus et impedit ad praesentium.", "https://picsum.photos/640/480/?image=926", "Whitney Brown II", 1, 5.0, 2241, new DateTime(2022, 12, 23, 22, 52, 3, 340, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quos ea sunt vel molestiae tempore possimus.", new DateTime(2023, 5, 8, 13, 9, 55, 451, DateTimeKind.Local).AddTicks(3266), "Sunt optio deleniti dolorum.\nAut commodi ut.\nQuibusdam officia cumque consectetur maxime reprehenderit.", "https://picsum.photos/640/480/?image=164", "Clara Bailey V", 8, 4.0, 529, new DateTime(2022, 11, 20, 0, 13, 58, 654, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Corrupti eligendi illo hic molestias reiciendis tempore sint omnis.", new DateTime(2023, 5, 8, 5, 39, 59, 346, DateTimeKind.Local).AddTicks(6802), "Maiores corporis consequatur cupiditate sed reiciendis laudantium.\nDolorem est blanditiis hic repellendus recusandae.", "https://picsum.photos/640/480/?image=259", "Miss Laura Harris", 9, 4.0, 1501, new DateTime(2022, 11, 23, 14, 34, 53, 272, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Possimus suscipit laborum maiores.", new DateTime(2023, 5, 8, 5, 1, 19, 229, DateTimeKind.Local).AddTicks(1647), "Natus quibusdam numquam tempora nisi.\nFuga quibusdam accusantium quis ad accusantium repellat quos voluptas.\nSaepe et cum beatae necessitatibus autem delectus voluptatem aliquid.\nModi molestias ratione ipsam laborum commodi inventore quo sint.", "https://picsum.photos/640/480/?image=628", "Mr. Linda Mraz", 10, 4.0, 2290, new DateTime(2022, 9, 28, 1, 28, 32, 880, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Consequatur quam consequatur vel ea ea.", new DateTime(2023, 5, 8, 5, 48, 34, 684, DateTimeKind.Local).AddTicks(238), "Voluptatem et consequatur recusandae ipsam atque.", "https://picsum.photos/640/480/?image=321", "Bertha Becker Jr.", 7, 4.0, 1040, new DateTime(2022, 12, 27, 0, 22, 44, 797, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui nihil et eligendi quam.", new DateTime(2023, 5, 8, 15, 27, 6, 467, DateTimeKind.Local).AddTicks(6904), "Odio aperiam similique optio reprehenderit deleniti.", "https://picsum.photos/640/480/?image=40", "Myra Schinner V", 5, 4.0, 1466, new DateTime(2023, 5, 4, 14, 5, 15, 102, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Neque quidem omnis ea labore est aut.", new DateTime(2023, 5, 8, 5, 16, 29, 79, DateTimeKind.Local).AddTicks(9166), "Praesentium eligendi assumenda voluptatibus eum magni id vel libero.\nDolores nemo rerum et dolor repudiandae delectus autem illum.\nVoluptas vel quod aspernatur.", "https://picsum.photos/640/480/?image=587", "Miss Angelo Beier", 7, 5.0, 1532, new DateTime(2023, 4, 25, 17, 58, 48, 556, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem itaque consequatur ipsam omnis.", new DateTime(2023, 5, 8, 14, 29, 38, 425, DateTimeKind.Local).AddTicks(7248), "Iure adipisci eaque culpa iure.\nCulpa consequuntur sapiente eos eius.\nQuam doloremque alias atque voluptatem.", "https://picsum.photos/640/480/?image=58", "Ms. Teresa Gusikowski", 4, 2.0, 1544, new DateTime(2023, 3, 13, 5, 43, 36, 936, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Delectus saepe sequi amet sequi blanditiis modi omnis eveniet.", new DateTime(2023, 5, 8, 4, 27, 48, 468, DateTimeKind.Local).AddTicks(4189), "Temporibus dicta sit voluptas ut facere voluptas neque consequatur repellendus.\nMagni iure debitis sit placeat ut.\nPlaceat alias blanditiis.\nIn et error a voluptas.", "https://picsum.photos/640/480/?image=95", "Mr. Lynette Wintheiser", 1, 848, new DateTime(2022, 11, 27, 11, 2, 38, 582, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Est quia nam quis illum quisquam atque consequatur.", new DateTime(2023, 5, 8, 10, 58, 15, 508, DateTimeKind.Local).AddTicks(8064), "Et ratione sequi non nisi qui rerum.\nAperiam excepturi accusamus quam iure odio et ipsa.\nVoluptas ratione officiis officia at aliquam ab eum.\nSit ratione temporibus eum molestiae eveniet est.", "https://picsum.photos/640/480/?image=1000", "Elbert Brakus Jr.", 4, 5.0, 1130, new DateTime(2022, 8, 28, 17, 45, 30, 215, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nihil iste dolor maxime sint nesciunt debitis.", new DateTime(2023, 5, 8, 7, 37, 49, 486, DateTimeKind.Local).AddTicks(5537), "Velit dolores officia commodi harum.\nVoluptates saepe molestiae nihil omnis facere dolor ut eos incidunt.\nEst consectetur illum laboriosam dignissimos sequi in laudantium.", "https://picsum.photos/640/480/?image=330", "Mr. Wilbert Casper", 7, 2.0, 754, new DateTime(2023, 2, 21, 6, 10, 21, 677, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas et magni quos saepe.", new DateTime(2023, 5, 8, 16, 51, 46, 472, DateTimeKind.Local).AddTicks(6500), "Quaerat ut consequatur laudantium tempore non dolorem.\nSit eum reiciendis.\nNon voluptatum voluptatem corrupti.\nEnim sit commodi in.", "https://picsum.photos/640/480/?image=226", "Brandon Grant II", 6, 1.0, 2076, new DateTime(2023, 4, 7, 19, 21, 15, 674, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et ea harum voluptas ut.", new DateTime(2023, 5, 8, 18, 12, 16, 584, DateTimeKind.Local).AddTicks(7596), "Nihil quidem dolores omnis vel consequatur dolorem.", "https://picsum.photos/640/480/?image=75", "Kelly Bashirian DDS", 1, 3.0, 670, new DateTime(2023, 5, 1, 19, 7, 29, 475, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laboriosam nemo fugit sunt architecto quam.", new DateTime(2023, 5, 8, 9, 41, 46, 850, DateTimeKind.Local).AddTicks(6091), "Sit numquam consectetur nostrum excepturi ea harum.", "https://picsum.photos/640/480/?image=476", "Dr. Ted Keeling", 5.0, 1085, new DateTime(2022, 6, 15, 7, 21, 4, 499, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aliquam nisi error autem aspernatur incidunt est error illum dicta.", new DateTime(2023, 5, 7, 23, 7, 50, 859, DateTimeKind.Local).AddTicks(9215), "Consequuntur et officiis distinctio animi cupiditate.\nUt a nihil voluptatem dignissimos eveniet.\nAperiam maiores iste eum velit voluptatem enim maiores.\nSed tempora et minima fugit dicta.", "https://picsum.photos/640/480/?image=49", "Jason Braun DDS", 5.0, 1200, new DateTime(2023, 4, 19, 18, 28, 16, 398, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aliquid velit dolore deleniti inventore quisquam facilis tempora.", new DateTime(2023, 5, 7, 20, 43, 2, 709, DateTimeKind.Local).AddTicks(1378), "Eum molestias a voluptatibus est voluptas.", "https://picsum.photos/640/480/?image=644", "Mr. Jeannie VonRueden", 10, 5.0, 1846, new DateTime(2022, 7, 21, 18, 24, 8, 339, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Odit eligendi aut rerum in ex perspiciatis.", new DateTime(2023, 5, 7, 23, 40, 7, 274, DateTimeKind.Local).AddTicks(247), "Quis voluptatum voluptatem eveniet adipisci rem sed quia.\nExcepturi tenetur voluptatum.\nTempore et amet sequi.", "https://picsum.photos/640/480/?image=1070", "Freddie Carter IV", 2.0, 2300, new DateTime(2023, 4, 30, 2, 57, 8, 646, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "A ab doloremque quia.", new DateTime(2023, 5, 8, 5, 27, 19, 770, DateTimeKind.Local).AddTicks(6581), "Doloremque ipsa aut optio rerum nobis.\nIncidunt eos aliquam vel.", "https://picsum.photos/640/480/?image=177", "Simon Bechtelar DVM", 7, 2.0, 675, new DateTime(2023, 3, 27, 21, 44, 44, 396, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Numquam consectetur dolorem.", new DateTime(2023, 5, 8, 16, 53, 50, 179, DateTimeKind.Local).AddTicks(8676), "Nulla eum beatae nulla beatae enim itaque.\nEnim necessitatibus libero recusandae id dolores.", "https://picsum.photos/640/480/?image=850", "Ms. Stella Klein", 4, 1.0, 1369, new DateTime(2023, 4, 8, 0, 25, 11, 462, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cum eveniet perferendis saepe beatae.", new DateTime(2023, 5, 7, 21, 4, 34, 417, DateTimeKind.Local).AddTicks(6075), "Autem et alias quia expedita consectetur sapiente magni animi quis.\nAutem qui atque.\nLabore corporis iste.", "https://picsum.photos/640/480/?image=586", "Byron Brakus V", 6, 1308, new DateTime(2022, 5, 27, 16, 43, 51, 885, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ex sed accusamus qui.", new DateTime(2023, 5, 7, 20, 42, 18, 639, DateTimeKind.Local).AddTicks(4384), "Rerum repudiandae quia temporibus atque adipisci.\nQuia quibusdam dolores alias sapiente.\nCupiditate in corporis illum illo qui est voluptas quas.\nEst dolore quisquam rerum quaerat aut.", "https://picsum.photos/640/480/?image=447", "Blanche Kuhn IV", 1, 1.0, 510, new DateTime(2022, 11, 10, 14, 35, 13, 949, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dicta beatae iste.", new DateTime(2023, 5, 8, 1, 9, 23, 589, DateTimeKind.Local).AddTicks(7938), "Quibusdam aut et nemo non quod distinctio error doloribus.\nPariatur optio tempora ut nisi.\nEa repellendus aspernatur eius unde sit ut animi porro odit.\nVelit repellendus et necessitatibus quo esse laboriosam ipsa dolores enim.", "https://picsum.photos/640/480/?image=605", "Marjorie Tillman I", 1, 1191, new DateTime(2023, 4, 2, 12, 17, 6, 333, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et quod aliquid et voluptatem voluptatem hic.", new DateTime(2023, 5, 8, 9, 48, 20, 941, DateTimeKind.Local).AddTicks(1083), "Iste autem commodi qui ducimus odio excepturi sit.\nAnimi aut facilis temporibus nobis aspernatur voluptatem est libero quas.\nOmnis aut omnis blanditiis ducimus velit.", "https://picsum.photos/640/480/?image=1044", "Mrs. Brendan Hills", 5, 681, new DateTime(2022, 9, 21, 4, 47, 19, 285, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem id tempore.", new DateTime(2023, 5, 8, 16, 45, 56, 763, DateTimeKind.Local).AddTicks(3042), "Non inventore ut aut doloribus quisquam.\nAlias vitae libero totam sed nemo.\nAut totam eos enim illo et magnam assumenda harum in.", "https://picsum.photos/640/480/?image=137", "Bryant Mitchell Jr.", 6, 4.0, 2103, new DateTime(2022, 10, 8, 0, 1, 51, 255, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Beatae at impedit ad molestiae magni quia.", new DateTime(2023, 5, 8, 0, 57, 57, 151, DateTimeKind.Local).AddTicks(7924), "Velit sed corrupti voluptatem aut est aut consequatur.", "https://picsum.photos/640/480/?image=887", "Clayton Zemlak V", 1, 3.0, 1206, new DateTime(2022, 7, 23, 21, 58, 39, 328, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eius quisquam ipsam quia.", new DateTime(2023, 5, 8, 13, 31, 51, 814, DateTimeKind.Local).AddTicks(6702), "Tempore quia aliquam.\nSit recusandae voluptatum omnis aperiam ad.\nFugiat non alias dicta blanditiis architecto.\nEveniet enim quos eos.", "https://picsum.photos/640/480/?image=253", "Forrest Balistreri I", 10, 5.0, 1117, new DateTime(2022, 8, 16, 13, 12, 58, 278, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iure quaerat at ipsam ut et.", new DateTime(2023, 5, 8, 12, 13, 35, 590, DateTimeKind.Local).AddTicks(1422), "Est nesciunt et sit.", "https://picsum.photos/640/480/?image=328", "Abel Wilderman II", 2, 2.0, 842, new DateTime(2022, 8, 28, 7, 21, 40, 209, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quaerat autem commodi.", new DateTime(2023, 5, 7, 20, 15, 4, 213, DateTimeKind.Local).AddTicks(4294), "Molestias accusamus cumque optio mollitia illo animi ex vitae similique.\nQui expedita aut odio perferendis ut sit.\nCorrupti dolor dignissimos.", "https://picsum.photos/640/480/?image=178", "Ms. Merle Effertz", 5, 2.0, 1521, new DateTime(2022, 10, 15, 13, 57, 29, 8, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed vitae quidem et porro possimus eveniet.", new DateTime(2023, 5, 8, 0, 26, 54, 298, DateTimeKind.Local).AddTicks(6382), "Itaque aut illum modi est ut explicabo velit qui.\nAccusamus ipsam velit.\nEa molestiae non sint.", "https://picsum.photos/640/480/?image=745", "Mr. Brandy Metz", 8, 709, new DateTime(2022, 12, 23, 7, 26, 4, 621, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Minus hic explicabo odio repellendus qui iste repudiandae ullam.", new DateTime(2023, 5, 8, 17, 56, 5, 451, DateTimeKind.Local).AddTicks(7502), "Est quia error officia ratione omnis voluptas odio.\nUllam et soluta.\nIpsum quas ipsa ut dolore impedit sed aut voluptate.\nVoluptas temporibus doloribus pariatur et accusantium quod consectetur excepturi.\nVoluptatem et consequuntur distinctio corrupti.", "https://picsum.photos/640/480/?image=994", "Mrs. Oscar Hirthe", 3, 1.0, 2241, new DateTime(2022, 11, 3, 16, 47, 6, 357, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et vitae voluptas et explicabo in id impedit aspernatur et.", new DateTime(2023, 5, 8, 0, 19, 28, 95, DateTimeKind.Local).AddTicks(3134), "Est distinctio iusto nobis molestias ad labore laudantium sapiente.\nDeserunt similique ut odit quia sunt doloribus repellendus.\nReiciendis earum modi animi sapiente doloribus.\nBeatae voluptas sunt ut incidunt omnis.", "https://picsum.photos/640/480/?image=196", "Fredrick Mosciski V", 3, 1054, new DateTime(2022, 11, 6, 23, 23, 25, 135, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut aliquam corrupti commodi ducimus officiis reprehenderit voluptatem mollitia.", new DateTime(2023, 5, 7, 22, 15, 45, 98, DateTimeKind.Local).AddTicks(1629), "Sit maxime harum voluptatem alias corporis possimus et.\nMaiores ullam voluptatem.\nEst cumque hic fugiat itaque non numquam sed recusandae laboriosam.\nLibero voluptas cumque molestiae magnam mollitia quidem quidem.\nQuia sit et sed repellendus sed et.", "https://picsum.photos/640/480/?image=186", "Mrs. Gretchen Bartoletti", 6, 4.0, 606, new DateTime(2023, 4, 11, 4, 23, 43, 191, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eos ut aut facilis accusantium tenetur qui quos dignissimos.", new DateTime(2023, 5, 8, 8, 30, 54, 633, DateTimeKind.Local).AddTicks(738), "Dolor eius laborum ipsam veritatis porro.\nQui velit ipsa.\nVoluptate exercitationem qui inventore eius distinctio cumque ut.", "https://picsum.photos/640/480/?image=790", "Teresa Will PhD", 9, 1.0, 2142, new DateTime(2023, 2, 10, 7, 34, 9, 767, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Natus officiis qui velit sed ut architecto.", new DateTime(2023, 5, 8, 5, 40, 56, 717, DateTimeKind.Local).AddTicks(5304), "Aliquam aspernatur quia eligendi ducimus enim.", "https://picsum.photos/640/480/?image=747", "Miss Jean Mayer", 6, 1258, new DateTime(2022, 9, 20, 6, 50, 44, 337, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et aut ad.", new DateTime(2023, 5, 8, 7, 2, 38, 980, DateTimeKind.Local).AddTicks(9034), "Non occaecati non repellendus iste.\nHic perspiciatis est harum fugit omnis accusantium quo voluptas eos.", "https://picsum.photos/640/480/?image=239", "Ms. Rodney Cronin", 6, 4.0, 957, new DateTime(2023, 4, 14, 9, 35, 5, 621, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aperiam voluptatem et laboriosam.", new DateTime(2023, 5, 8, 5, 57, 39, 201, DateTimeKind.Local).AddTicks(7337), "Laudantium saepe earum vitae ipsam doloremque molestiae eaque.\nVelit labore ipsum velit cumque illum ut.\nEst eligendi qui incidunt consequatur ad.\nMaxime officiis nobis aut.\nAt doloribus iure sint eveniet aspernatur.", "https://picsum.photos/640/480/?image=345", "Miss Gabriel Bashirian", 8, 1.0, 980, new DateTime(2022, 8, 3, 1, 39, 51, 353, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nihil sint earum voluptates.", new DateTime(2023, 5, 8, 13, 36, 52, 417, DateTimeKind.Local).AddTicks(338), "Debitis expedita facilis velit nihil rem dolore iste laudantium ut.\nQuia autem et asperiores nam repellat delectus nihil eligendi similique.\nId dolores inventore nemo.\nDeserunt rem officia vitae sint.\nQuod consequatur fugit expedita quo et.", "https://picsum.photos/640/480/?image=119", "Miss Lionel Koepp", 984, new DateTime(2023, 3, 12, 1, 42, 13, 215, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem quas quis facilis aspernatur autem quia velit repellat ea.", new DateTime(2023, 5, 8, 16, 22, 0, 637, DateTimeKind.Local).AddTicks(2840), "Dolor quibusdam laborum quod porro quia in libero est dolorem.\nDolor ut et hic dicta veritatis non cum saepe unde.\nNemo modi et est ducimus in facilis.\nVoluptatem est harum veritatis error.\nEst molestiae laboriosam saepe quaerat.", "https://picsum.photos/640/480/?image=935", "Melanie Champlin IV", 3, 5.0, 1490, new DateTime(2022, 12, 20, 17, 39, 8, 807, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Fuga commodi voluptatem eos dolore voluptatem numquam.", new DateTime(2023, 5, 8, 6, 6, 58, 950, DateTimeKind.Local).AddTicks(1364), "Voluptatum illo dicta ut quidem omnis est esse quos.\nLaborum eligendi ratione ad fugiat repellat consequatur.\nAccusamus suscipit dolor sit enim.", "https://picsum.photos/640/480/?image=618", "Carl Mueller DDS", 9, 1.0, 921, new DateTime(2023, 1, 16, 2, 40, 32, 853, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Iusto aut inventore quod est sed sed autem ratione dignissimos.", new DateTime(2023, 5, 8, 17, 42, 42, 619, DateTimeKind.Local).AddTicks(2650), "Tenetur officiis repellendus assumenda porro officia quia eos debitis.\nQui sint saepe ea asperiores placeat expedita impedit eligendi.\nDeserunt debitis occaecati perspiciatis.\nQuis corrupti quis mollitia deleniti ex quisquam consequatur.\nCum magnam repudiandae aut doloremque officia culpa nulla et sed.", "https://picsum.photos/640/480/?image=354", "Mr. Israel Krajcik", 8, 3.0, 1990, new DateTime(2023, 2, 7, 22, 21, 15, 459, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Omnis ut iste animi.", new DateTime(2023, 5, 8, 3, 39, 22, 24, DateTimeKind.Local).AddTicks(9452), "Nesciunt accusantium amet.\nDebitis iure et doloremque.\nDolor aut explicabo saepe aperiam sequi accusantium sapiente doloribus.", "https://picsum.photos/640/480/?image=932", "Mrs. Dennis Prosacco", 8, 1849, new DateTime(2022, 11, 10, 12, 27, 23, 232, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatem esse blanditiis quos ut voluptatum.", new DateTime(2023, 5, 8, 7, 58, 45, 403, DateTimeKind.Local).AddTicks(4917), "Vel nam sed sunt.\nDoloribus totam aut.\nVoluptatem aut consectetur molestiae odit facere.", "https://picsum.photos/640/480/?image=849", "Dr. Naomi Dach", 8, 4.0, 2382, new DateTime(2022, 7, 31, 17, 54, 23, 294, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Quam vel repellat magni sit.", new DateTime(2023, 5, 8, 9, 26, 35, 632, DateTimeKind.Local).AddTicks(6544), "In doloremque iure est dolorem qui distinctio ullam ducimus labore.", "https://picsum.photos/640/480/?image=542", "Dr. Leslie Goyette", 9, 1.0, 1519, new DateTime(2022, 12, 5, 10, 22, 41, 127, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui adipisci saepe et.", new DateTime(2023, 5, 8, 14, 3, 43, 654, DateTimeKind.Local).AddTicks(6267), "Eius non natus earum.\nVoluptatem numquam nobis perspiciatis.", "https://picsum.photos/640/480/?image=1048", "Kristin Hartmann V", 5, 2.0, 528, new DateTime(2022, 7, 23, 20, 3, 59, 247, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Eius pariatur ut debitis sint.", new DateTime(2023, 5, 8, 18, 54, 7, 803, DateTimeKind.Local).AddTicks(5587), "Cum sit doloremque molestiae sapiente et omnis praesentium quidem.\nQuia quisquam fuga eos dolores velit.\nTempore et officiis dolorum.\nEnim reprehenderit impedit quibusdam aut.\nAliquam nulla libero et eligendi omnis.", "https://picsum.photos/640/480/?image=1064", "Karl Gleason MD", 5, 1143, new DateTime(2023, 2, 2, 19, 40, 30, 571, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nulla ex dicta possimus inventore enim maxime quis soluta.", new DateTime(2023, 5, 8, 9, 19, 24, 403, DateTimeKind.Local).AddTicks(1487), "Et fuga dolor beatae accusamus quia ullam est saepe perspiciatis.\nFugiat deleniti qui quisquam ut in mollitia illum iure.\nQui hic voluptatem asperiores quae et odit.\nCorrupti atque cum est qui aut aut.\nRerum qui autem hic.", "https://picsum.photos/640/480/?image=369", "Ms. Edwin Rodriguez", 8, 3.0, 974, new DateTime(2022, 8, 9, 18, 44, 10, 991, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Esse voluptates tenetur mollitia tempora eius iste eveniet earum tempora.", new DateTime(2023, 5, 8, 10, 59, 58, 779, DateTimeKind.Local).AddTicks(6844), "Quia eos minus non assumenda recusandae ipsa voluptatem.\nOccaecati quo iusto earum distinctio.\nSaepe vero dicta aut quisquam alias officiis porro consequuntur.", "https://picsum.photos/640/480/?image=192", "Dallas Rippin II", 3, 1.0, 2076, new DateTime(2023, 2, 7, 7, 18, 15, 151, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Aut soluta et voluptatibus illum et id dolor temporibus deleniti.", new DateTime(2023, 5, 8, 11, 51, 12, 95, DateTimeKind.Local).AddTicks(7377), "Voluptatem quos veniam repellat.\nExplicabo sed et aperiam.\nBeatae esse facilis cumque sunt nam vel assumenda sit.\nQuam cumque sunt.\nQuo at et nisi hic.", "https://picsum.photos/640/480/?image=109", "Mrs. Greg Monahan", 2, 2.0, 699, new DateTime(2022, 10, 3, 17, 50, 55, 8, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Autem excepturi qui fuga.", new DateTime(2023, 5, 8, 6, 24, 29, 487, DateTimeKind.Local).AddTicks(7188), "Nihil blanditiis sint quidem quidem mollitia eius.", "https://picsum.photos/640/480/?image=976", "Dr. Kelley West", 8, 2056, new DateTime(2022, 9, 7, 4, 43, 50, 626, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Nemo sed eius sunt aperiam ea velit.", new DateTime(2023, 5, 7, 23, 41, 23, 881, DateTimeKind.Local).AddTicks(9883), "Illum voluptatem alias fugit tempore nihil.\nUt quo ea ut consequatur consequuntur aut eos commodi.", "https://picsum.photos/640/480/?image=562", "Chad Grimes PhD", 9, 5.0, 1670, new DateTime(2023, 4, 24, 6, 48, 40, 361, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Magni enim officiis eveniet quo debitis omnis optio sunt sed.", new DateTime(2023, 5, 7, 20, 19, 55, 500, DateTimeKind.Local).AddTicks(2185), "Nulla cum libero eos neque dolores et repellat qui quos.", "https://picsum.photos/640/480/?image=272", "Mrs. Erik Feest", 1, 3.0, 1110, new DateTime(2022, 9, 26, 9, 2, 7, 178, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Minus ut et voluptate.", new DateTime(2023, 5, 8, 4, 20, 47, 673, DateTimeKind.Local).AddTicks(1814), "Earum sint voluptatem.\nPlaceat qui aliquid sit voluptatem aut dolorum rerum amet.\nAssumenda maiores aut debitis suscipit error sed inventore.\nCulpa cum et sunt.", "https://picsum.photos/640/480/?image=856", "Lucy Green Jr.", 5, 1.0, 1579, new DateTime(2022, 12, 8, 11, 40, 4, 653, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Libero a assumenda suscipit.", new DateTime(2023, 5, 8, 14, 25, 31, 807, DateTimeKind.Local).AddTicks(2950), "Tenetur eligendi ut cumque eum in aut nesciunt.\nSimilique cumque est sequi ut dolorum et.\nBlanditiis dicta corporis error deleniti iste sint ut perferendis.", "https://picsum.photos/640/480/?image=948", "Ms. Bethany Strosin", 1270, new DateTime(2022, 11, 11, 17, 17, 53, 838, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolore ab quia.", new DateTime(2023, 5, 8, 17, 25, 32, 979, DateTimeKind.Local).AddTicks(7834), "Numquam quidem non fuga.\nQuam suscipit et laudantium quae sequi.", "https://picsum.photos/640/480/?image=610", "Clint Kessler III", 6, 5.0, 1491, new DateTime(2023, 3, 15, 0, 37, 44, 351, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptas eos voluptatibus ipsum officia voluptatem.", new DateTime(2023, 5, 8, 13, 40, 38, 181, DateTimeKind.Local).AddTicks(6910), "Dolores fuga quaerat voluptas nesciunt tempora molestiae consequuntur.\nAt sunt voluptatem voluptatibus magnam assumenda voluptate velit deleniti asperiores.\nAut libero ipsum corrupti reiciendis aut.\nAb minima nihil cumque placeat libero sapiente rerum voluptatem.", "https://picsum.photos/640/480/?image=354", "Ben Hackett MD", 8, 5.0, 1429, new DateTime(2022, 7, 24, 20, 36, 21, 565, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "In deleniti nisi beatae qui et eum dicta.", new DateTime(2023, 5, 8, 18, 23, 36, 199, DateTimeKind.Local).AddTicks(6224), "Vel labore odit minus quia odit omnis ullam illum.\nSed culpa quae enim quisquam beatae nesciunt et est.\nCumque laborum voluptas dolor.\nUllam commodi porro perspiciatis porro odio animi id.", "https://picsum.photos/640/480/?image=509", "Mrs. Elsie Halvorson", 8, 1275, new DateTime(2023, 4, 26, 19, 10, 57, 504, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Perferendis quaerat officiis officia quidem commodi ut.", new DateTime(2023, 5, 8, 0, 14, 18, 954, DateTimeKind.Local).AddTicks(3137), "Esse soluta autem.\nCumque ut a et labore possimus molestiae.\nAdipisci consequuntur ipsa et ipsam culpa vitae eveniet laboriosam alias.", "https://picsum.photos/640/480/?image=93", "Mrs. Karen Gutkowski", 8, 1.0, 902, new DateTime(2023, 4, 8, 11, 22, 49, 988, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Veritatis dolor quibusdam.", new DateTime(2023, 5, 8, 14, 27, 7, 168, DateTimeKind.Local).AddTicks(9142), "Vero quibusdam et voluptatem quis porro aut.\nEnim et numquam repellendus natus quisquam est non nemo sit.\nTemporibus nihil libero dolores facere et officiis repellendus.\nSimilique fugit saepe minima voluptatem doloribus dolores.", "https://picsum.photos/640/480/?image=349", "Vivian Schaefer V", 6, 1.0, 904, new DateTime(2023, 4, 1, 10, 50, 9, 299, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit omnis autem ut voluptatem ut voluptatem nostrum qui necessitatibus.", new DateTime(2023, 5, 8, 13, 14, 13, 920, DateTimeKind.Local).AddTicks(7210), "Aut consequuntur commodi et esse quidem veniam.", "https://picsum.photos/640/480/?image=605", "Ms. Wilbert Grant", 5.0, 528, new DateTime(2023, 1, 24, 18, 33, 50, 542, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Necessitatibus nobis et adipisci aspernatur.", new DateTime(2023, 5, 8, 19, 8, 30, 536, DateTimeKind.Local).AddTicks(6647), "Velit possimus nemo sit quisquam cumque eum.\nEt dicta expedita.\nTempore enim quibusdam libero.\nModi quibusdam necessitatibus dolores aliquid in reprehenderit possimus.", "https://picsum.photos/640/480/?image=755", "Dr. Marcia Gerhold", 5, 4.0, 1613, new DateTime(2022, 10, 31, 4, 36, 8, 434, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "UpdatedDate" },
                values: new object[] { "Voluptatem inventore omnis molestiae numquam neque.", new DateTime(2023, 5, 8, 20, 1, 4, 24, DateTimeKind.Local).AddTicks(9879), "Tenetur qui qui.", "https://picsum.photos/640/480/?image=196", "Andrea Lubowitz PhD", 2, 1.0, new DateTime(2022, 10, 13, 14, 48, 25, 575, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed magni recusandae atque dolor dolore aut nisi explicabo eos.", new DateTime(2023, 5, 8, 9, 25, 21, 626, DateTimeKind.Local).AddTicks(675), "Eos eos quia hic.", "https://picsum.photos/640/480/?image=627", "Dr. Sylvia Schowalter", 2, 2.0, 747, new DateTime(2022, 12, 5, 23, 46, 48, 559, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptatibus cumque voluptatibus aut itaque laborum accusantium quo tenetur.", new DateTime(2023, 5, 8, 16, 56, 53, 827, DateTimeKind.Local).AddTicks(7505), "Velit aliquid sint.\nA consequatur est assumenda voluptates nihil ea qui rerum qui.\nUt consequatur corporis doloremque rerum nihil odit voluptatum voluptas.\nAut sint vel.\nUllam optio libero nam.", "https://picsum.photos/640/480/?image=1007", "Ms. Trevor Howe", 1, 4.0, 1771, new DateTime(2022, 6, 11, 19, 5, 5, 22, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Soluta qui ducimus eius ut voluptates blanditiis est maiores mollitia.", new DateTime(2023, 5, 8, 13, 34, 33, 251, DateTimeKind.Local).AddTicks(2771), "Natus dolorem voluptatibus occaecati maxime voluptate rerum nobis.\nEt placeat at.\nArchitecto quaerat necessitatibus non beatae enim.\nEaque odio omnis.\nNatus necessitatibus sit saepe quae aut quia illo exercitationem debitis.", "https://picsum.photos/640/480/?image=970", "Andrew Hoeger V", 3, 1.0, 760, new DateTime(2023, 3, 12, 7, 0, 56, 473, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ab laudantium ut nihil vel repellat aliquid.", new DateTime(2023, 5, 8, 9, 59, 36, 134, DateTimeKind.Local).AddTicks(3221), "Perspiciatis omnis soluta.\nPlaceat deserunt porro repellat iusto cumque velit natus.", "https://picsum.photos/640/480/?image=589", "Mr. Patti Hand", 4, 3.0, 1480, new DateTime(2023, 1, 8, 13, 40, 33, 375, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et error maxime consequuntur vero.", new DateTime(2023, 5, 8, 12, 29, 43, 440, DateTimeKind.Local).AddTicks(3180), "Aut itaque quia excepturi dolorem porro harum illum.", "https://picsum.photos/640/480/?image=1041", "Rickey Turner Jr.", 8, 2149, new DateTime(2023, 1, 8, 6, 38, 8, 251, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cumque reiciendis modi vel voluptate sit quo qui.", new DateTime(2023, 5, 8, 15, 41, 22, 47, DateTimeKind.Local).AddTicks(9681), "Repellat qui eius blanditiis commodi.\nQuia aut et minima asperiores molestiae adipisci.\nNon aut a amet laboriosam non ut ut.\nNesciunt nihil tenetur.", "https://picsum.photos/640/480/?image=898", "Miss Jeanette Bergnaum", 4, 3.0, 1678, new DateTime(2022, 10, 28, 20, 16, 49, 582, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Blanditiis voluptas inventore amet.", new DateTime(2023, 5, 8, 2, 38, 10, 32, DateTimeKind.Local).AddTicks(7424), "Id odit ea magnam nisi neque rerum repellat eum.\nAut necessitatibus corrupti nostrum.\nOdio qui dolor.\nEarum nisi sit magnam aut qui consequatur.", "https://picsum.photos/640/480/?image=544", "Mr. Clifford Bartoletti", 3, 1412, new DateTime(2022, 7, 31, 2, 31, 14, 288, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Totam dolor praesentium.", new DateTime(2023, 5, 8, 12, 50, 35, 217, DateTimeKind.Local).AddTicks(6046), "Distinctio rerum excepturi magnam voluptatem et aut nemo qui sed.\nDolorum aut nam repellat consequatur doloremque quos dolore odio.\nVoluptates non esse.", "https://picsum.photos/640/480/?image=126", "Mrs. Jesus Ullrich", 4.0, 2293, new DateTime(2022, 6, 20, 13, 56, 23, 746, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Expedita aut repellendus dignissimos laudantium dolor corrupti itaque unde repellendus.", new DateTime(2023, 5, 8, 0, 48, 26, 351, DateTimeKind.Local).AddTicks(2813), "Magnam recusandae nostrum dolor suscipit qui dolorem eos rerum.\nExpedita rem doloribus est sed consequuntur minus.", "https://picsum.photos/640/480/?image=824", "Mr. Gertrude Hessel", 3, 2249, new DateTime(2022, 5, 16, 9, 23, 56, 834, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Earum quaerat rem qui et quidem.", new DateTime(2023, 5, 8, 13, 5, 32, 892, DateTimeKind.Local).AddTicks(1451), "Explicabo eligendi nihil eum fugit harum dignissimos ab fugiat autem.\nUllam in ut dolor rerum eveniet veniam harum culpa quis.", "https://picsum.photos/640/480/?image=674", "Stacey Walter DDS", 3.0, 1812, new DateTime(2022, 9, 29, 12, 23, 49, 192, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Laborum ipsum qui velit rerum dignissimos totam mollitia.", new DateTime(2023, 5, 8, 6, 17, 12, 286, DateTimeKind.Local).AddTicks(1541), "Dignissimos tenetur rerum dolorem et fugit corrupti vero.\nAut quos maiores eligendi totam qui reprehenderit beatae eaque veniam.\nBeatae reiciendis autem consectetur necessitatibus.\nVoluptas ea sed cum aut est rerum.", "https://picsum.photos/640/480/?image=1040", "Ms. Freda Runte", 2.0, 2359, new DateTime(2022, 10, 1, 19, 18, 42, 222, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et tempore commodi aspernatur omnis ut ipsa culpa.", new DateTime(2023, 5, 8, 5, 34, 57, 673, DateTimeKind.Local).AddTicks(1749), "Molestiae eos ut consequatur quidem reiciendis porro.\nTotam molestiae laudantium sed rem reiciendis ratione eos accusamus veritatis.", "https://picsum.photos/640/480/?image=853", "Alton Luettgen II", 5.0, 2110, new DateTime(2022, 10, 20, 11, 52, 15, 973, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ipsum rerum voluptatem ut alias dicta nihil.", new DateTime(2023, 5, 8, 19, 55, 10, 775, DateTimeKind.Local).AddTicks(2953), "Architecto voluptatem dignissimos.\nQui voluptate eum dignissimos rerum in.", "https://picsum.photos/640/480/?image=220", "Sophia Lind MD", 2, 2.0, 694, new DateTime(2022, 10, 19, 5, 32, 32, 130, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Non cumque eum officia incidunt sunt sit.", new DateTime(2023, 5, 8, 2, 34, 17, 565, DateTimeKind.Local).AddTicks(6048), "Minus culpa ea ab cum a veniam officia hic.\nDolores aperiam sunt.\nFacere saepe nihil eaque reiciendis ut vel aliquid.", "https://picsum.photos/640/480/?image=94", "Armando Romaguera I", 2.0, 1623, new DateTime(2022, 11, 1, 22, 7, 45, 686, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sed consequatur sed ratione sunt voluptas eveniet.", new DateTime(2023, 5, 8, 1, 32, 30, 165, DateTimeKind.Local).AddTicks(3226), "Harum beatae consequatur.\nVoluptatem omnis libero autem natus sit omnis velit delectus.\nNesciunt enim sunt porro omnis libero quia ea.\nProvident sed sed eos hic praesentium aliquam ut.", "https://picsum.photos/640/480/?image=826", "Antoinette Schoen Jr.", 3, 5.0, 1717, new DateTime(2022, 6, 15, 8, 11, 46, 265, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Ut qui iusto molestiae.", new DateTime(2023, 5, 8, 18, 41, 17, 26, DateTimeKind.Local).AddTicks(708), "Dolores dolores quia est soluta.\nVel est eius magnam corrupti voluptatem porro est voluptatem tenetur.\nOfficia non ut enim iusto id laboriosam.\nAutem numquam nihil.", "https://picsum.photos/640/480/?image=1025", "Miss Daniel Herzog", 4.0, 1318, new DateTime(2023, 1, 27, 14, 48, 31, 816, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et consequuntur quisquam ut quam minus quisquam.", new DateTime(2023, 5, 8, 17, 51, 3, 903, DateTimeKind.Local).AddTicks(7928), "Saepe magnam quis porro quos expedita.\nNon nihil rem doloribus ducimus eos magni perspiciatis corrupti et.\nPossimus non quas eveniet sit voluptas distinctio qui.", "https://picsum.photos/640/480/?image=96", "Isabel Weissnat III", 9, 2425, new DateTime(2022, 7, 19, 6, 16, 9, 451, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Dolore magni nobis unde est dicta tempore officia alias.", new DateTime(2023, 5, 8, 7, 37, 22, 198, DateTimeKind.Local).AddTicks(1603), "Ab omnis eos et sed facilis reprehenderit vel dolor dolor.", "https://picsum.photos/640/480/?image=116", "Dr. Eva McKenzie", 6, 957, new DateTime(2023, 1, 15, 21, 34, 8, 715, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Facilis tempore distinctio.", new DateTime(2023, 5, 8, 6, 2, 23, 823, DateTimeKind.Local).AddTicks(9304), "Quidem voluptas provident in ut ratione omnis autem libero tempore.\nDignissimos aut esse.", "https://picsum.photos/640/480/?image=449", "Jenny West DDS", 10, 576, new DateTime(2023, 4, 1, 23, 8, 44, 970, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Accusantium quia magnam dolore sit excepturi repudiandae quae.", new DateTime(2023, 5, 8, 10, 20, 4, 575, DateTimeKind.Local).AddTicks(6217), "Dolores omnis nostrum odio et voluptas et nisi dolor.\nUt nostrum earum rerum aut consectetur porro.\nTempora quo commodi doloremque et et corrupti hic.\nQuam sit accusantium vel pariatur similique exercitationem commodi iusto omnis.", "https://picsum.photos/640/480/?image=508", "Ira Flatley II", 8, 4.0, 2358, new DateTime(2023, 4, 14, 5, 39, 53, 159, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Cum dignissimos incidunt.", new DateTime(2023, 5, 8, 16, 33, 30, 575, DateTimeKind.Local).AddTicks(4009), "Ab doloremque porro ducimus odio.\nFugiat doloribus hic rerum accusamus laboriosam.\nOfficia rerum vel debitis a voluptatibus aut quibusdam accusantium nemo.\nDolorem vero vel asperiores amet autem magni.", "https://picsum.photos/640/480/?image=667", "Mrs. Antoinette Gerlach", 2, 2.0, 1114, new DateTime(2022, 7, 20, 0, 28, 20, 852, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Delectus voluptatem sed sequi.", new DateTime(2023, 5, 8, 1, 55, 29, 594, DateTimeKind.Local).AddTicks(9929), "Harum voluptatem animi perspiciatis explicabo aut ipsam dolor provident et.\nQui enim aut deserunt voluptatem ipsa sit cumque.\nCommodi consectetur rem neque.", "https://picsum.photos/640/480/?image=1074", "Laura Volkman MD", 5, 2.0, 1864, new DateTime(2022, 11, 29, 19, 31, 52, 458, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Amet voluptatem nesciunt quam exercitationem omnis quis.", new DateTime(2023, 5, 8, 3, 47, 19, 57, DateTimeKind.Local).AddTicks(3768), "Delectus neque est eius vel porro totam magnam.\nNulla rem illum nihil ipsum.\nEt distinctio ut animi.", "https://picsum.photos/640/480/?image=915", "Cedric Metz IV", 8, 5.0, 1426, new DateTime(2023, 1, 18, 23, 50, 6, 691, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Sit facilis ea.", new DateTime(2023, 5, 8, 6, 41, 1, 113, DateTimeKind.Local).AddTicks(82), "Non illum in dolor cumque architecto.\nDucimus mollitia sequi nulla earum repellat.\nVitae molestiae laudantium modi unde voluptatum quae quam.\nQuo distinctio mollitia dolorem nisi non.\nAb iure fugiat magni esse ut beatae reiciendis repellendus.", "https://picsum.photos/640/480/?image=382", "Pamela Larkin Jr.", 2.0, 1024, new DateTime(2022, 5, 26, 10, 2, 44, 916, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Qui similique officiis quibusdam aliquam voluptatum error.", new DateTime(2023, 5, 8, 11, 25, 36, 535, DateTimeKind.Local).AddTicks(766), "Dolores velit nemo sint.", "https://picsum.photos/640/480/?image=627", "Miss Cameron Romaguera", 1, 5.0, 2332, new DateTime(2023, 2, 17, 20, 33, 33, 644, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Adipisci sint dolor.", new DateTime(2023, 5, 8, 0, 0, 33, 683, DateTimeKind.Local).AddTicks(8435), "Velit nam culpa atque est.\nOccaecati voluptatum aut.\nUt quisquam eligendi optio necessitatibus.\nId ratione modi.", "https://picsum.photos/640/480/?image=436", "Mrs. Christine Frami", 3.0, 636, new DateTime(2022, 12, 9, 6, 40, 58, 977, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Et aut quae.", new DateTime(2023, 5, 8, 4, 33, 41, 571, DateTimeKind.Local).AddTicks(1269), "Quae expedita reprehenderit et quisquam ut at dolor sed.", "https://picsum.photos/640/480/?image=312", "Ms. Estelle Ward", 10, 2.0, 1208, new DateTime(2022, 6, 3, 7, 24, 41, 960, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Doloremque quibusdam eaque quia itaque velit.", new DateTime(2023, 5, 8, 12, 21, 16, 302, DateTimeKind.Local).AddTicks(2942), "Odit dolore vel quos totam exercitationem velit.", "https://picsum.photos/640/480/?image=519", "Mrs. Jimmy Beatty", 3, 1.0, 785, new DateTime(2022, 11, 16, 10, 37, 30, 760, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Voluptate quod sit autem molestiae omnis similique necessitatibus est molestias.", new DateTime(2023, 5, 7, 23, 9, 45, 982, DateTimeKind.Local).AddTicks(7760), "Voluptatem in et necessitatibus molestiae nostrum quia saepe similique ratione.", "https://picsum.photos/640/480/?image=334", "Ron Mayer V", 3.0, 1078, new DateTime(2022, 11, 19, 19, 22, 29, 106, DateTimeKind.Local).AddTicks(5046) });
        }
    }
}
