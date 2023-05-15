using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Villa_API.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaTableWithBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Hic debitis ullam rerum.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(6600), "Et aut nesciunt iure voluptates earum ipsam dolor nam laudantium.", "https://picsum.photos/640/480/?image=144", "Marcus Stiedemann II", 1, 4.0, 742, new DateTime(2022, 8, 10, 2, 54, 51, 422, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Mollitia nihil molestiae placeat dicta aut ratione odit deleniti.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(6800), "Voluptas id harum saepe.", "https://picsum.photos/640/480/?image=817", "Miss Sidney Buckridge", 4, 1.0, 753, new DateTime(2023, 4, 24, 13, 58, 26, 606, DateTimeKind.Local).AddTicks(3704) });

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
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Excepturi praesentium placeat ut.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(6980), "Porro voluptatem aut possimus voluptate et sed pariatur quia officia.", "https://picsum.photos/640/480/?image=487", "Willis Cassin II", 1, 1.0, 850, new DateTime(2022, 5, 17, 1, 6, 57, 627, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "Explicabo tempora sed.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7060), "Culpa sed vel repellendus officiis et accusantium qui id.", "https://picsum.photos/640/480/?image=847", "Terrence Rutherford IV", 6, 4.0, 347, new DateTime(2022, 11, 20, 20, 52, 31, 443, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[,]
                {
                    { 6, "Quae omnis autem perspiciatis soluta autem voluptatem saepe fugit.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7140), "Nemo eos unde tempora minus.", "https://picsum.photos/640/480/?image=456", "Edward Legros Jr.", 2, 2.0, 591, new DateTime(2023, 3, 9, 9, 28, 43, 45, DateTimeKind.Local).AddTicks(3478) },
                    { 7, "Sint molestiae et veritatis quisquam accusamus.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7220), "Et voluptas vitae itaque et facilis aliquam minima doloremque doloribus.", "https://picsum.photos/640/480/?image=50", "Mrs. Beulah Nolan", 3, 5.0, 590, new DateTime(2023, 2, 6, 11, 26, 9, 716, DateTimeKind.Local).AddTicks(3148) },
                    { 8, "Neque debitis officia nulla voluptate vero nihil corporis eos.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7300), "Modi ea est accusantium consectetur harum eveniet et ipsam.", "https://picsum.photos/640/480/?image=920", "Doug Wyman V", 9, 4.0, 791, new DateTime(2023, 3, 20, 8, 30, 54, 21, DateTimeKind.Local).AddTicks(1970) },
                    { 9, "Optio impedit beatae.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7370), "Iure nostrum sint hic et repellat distinctio id eaque.", "https://picsum.photos/640/480/?image=1029", "Bruce Beahan V", 9, 4.0, 882, new DateTime(2023, 2, 20, 14, 43, 31, 402, DateTimeKind.Local).AddTicks(9434) },
                    { 10, "Et quae optio adipisci modi voluptatem placeat.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7460), "Saepe quis eos et accusamus sapiente velit voluptate.", "https://picsum.photos/640/480/?image=925", "Ms. Manuel Armstrong", 1, 5.0, 886, new DateTime(2023, 1, 16, 17, 12, 41, 587, DateTimeKind.Local).AddTicks(9582) },
                    { 11, "Saepe quos aut voluptate in blanditiis et ut.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7530), "Ut dicta facilis.", "https://picsum.photos/640/480/?image=430", "Dr. Louis Cummings", 7, 1.0, 384, new DateTime(2023, 4, 11, 11, 6, 40, 788, DateTimeKind.Local).AddTicks(8439) },
                    { 12, "Molestiae illum ab possimus officiis atque porro ducimus voluptatum.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7610), "Sed a ea excepturi omnis ipsam voluptatem eum.", "https://picsum.photos/640/480/?image=796", "Mrs. Roosevelt Botsford", 10, 5.0, 504, new DateTime(2022, 7, 21, 9, 57, 57, 190, DateTimeKind.Local).AddTicks(8377) },
                    { 13, "Occaecati est dolorem soluta nam maiores eligendi natus quia id.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7700), "Sit repudiandae esse qui magnam possimus quia iusto ipsa.", "https://picsum.photos/640/480/?image=1063", "Sherry Hagenes II", 7, 2.0, 321, new DateTime(2022, 6, 23, 12, 2, 2, 374, DateTimeKind.Local).AddTicks(5173) },
                    { 14, "Laboriosam recusandae cumque sit vel eum non quis provident.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7770), "Fugiat nobis facere dolores autem.", "https://picsum.photos/640/480/?image=872", "Cary Shanahan DVM", 2, 1.0, 471, new DateTime(2023, 5, 3, 13, 10, 12, 182, DateTimeKind.Local).AddTicks(3019) },
                    { 15, "Tempora est itaque tenetur id sed id autem fuga.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7830), "Qui quia dolores.", "https://picsum.photos/640/480/?image=340", "Georgia Klein I", 7, 3.0, 471, new DateTime(2022, 7, 29, 15, 2, 20, 552, DateTimeKind.Local).AddTicks(9031) },
                    { 16, "Pariatur dolorum qui quis porro.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(7920), "Veniam nisi numquam praesentium necessitatibus rerum consequatur.", "https://picsum.photos/640/480/?image=874", "Mr. Vernon Hilll", 7, 5.0, 177, new DateTime(2022, 8, 10, 0, 1, 23, 854, DateTimeKind.Local).AddTicks(3440) },
                    { 17, "Porro quis quia et mollitia velit quia ullam sint.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8000), "Eveniet molestias quas ea sapiente et deserunt ex.", "https://picsum.photos/640/480/?image=830", "Ms. Francis Goodwin", 3, 2.0, 573, new DateTime(2022, 9, 10, 15, 12, 17, 620, DateTimeKind.Local).AddTicks(7277) },
                    { 18, "Nam quasi minima natus quaerat quam.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8070), "Qui maxime id occaecati perferendis deleniti fugit et ut.", "https://picsum.photos/640/480/?image=392", "Alice Reinger II", 8, 4.0, 120, new DateTime(2022, 5, 18, 20, 25, 14, 345, DateTimeKind.Local).AddTicks(1413) },
                    { 19, "Adipisci fugiat a aliquid laudantium expedita ipsam quisquam.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8130), "Tenetur ea distinctio.", "https://picsum.photos/640/480/?image=556", "Mr. Susan Fisher", 2, 4.0, 516, new DateTime(2022, 8, 8, 12, 59, 26, 855, DateTimeKind.Local).AddTicks(3329) },
                    { 20, "Ut inventore iure in.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8180), "Quis laudantium cumque.", "https://picsum.photos/640/480/?image=857", "Emily Kertzmann MD", 9, 4.0, 997, new DateTime(2022, 6, 8, 14, 30, 38, 608, DateTimeKind.Local).AddTicks(6626) },
                    { 21, "Et vel repellat velit.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8240), "Accusantium et optio accusantium magni.", "https://picsum.photos/640/480/?image=790", "Lucia Reichert PhD", 9, 5.0, 878, new DateTime(2023, 3, 25, 16, 29, 52, 832, DateTimeKind.Local).AddTicks(7736) },
                    { 22, "Autem suscipit repellat autem expedita quo sit asperiores quos porro.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8310), "Et in quod voluptas nesciunt.", "https://picsum.photos/640/480/?image=232", "Irving Champlin Sr.", 7, 5.0, 70, new DateTime(2022, 10, 8, 0, 1, 7, 838, DateTimeKind.Local).AddTicks(5185) },
                    { 23, "Corporis placeat ducimus et commodi eligendi.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8390), "Suscipit veniam magni amet et explicabo quia sunt.", "https://picsum.photos/640/480/?image=218", "Mr. Doug Mann", 8, 2.0, 462, new DateTime(2022, 6, 27, 21, 50, 53, 833, DateTimeKind.Local).AddTicks(2873) },
                    { 24, "Modi illo dolor voluptatem velit in.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8450), "Sit praesentium dolorem.", "https://picsum.photos/640/480/?image=501", "Jose Steuber MD", 2, 3.0, 613, new DateTime(2022, 7, 24, 0, 9, 7, 79, DateTimeKind.Local).AddTicks(7079) },
                    { 25, "Cupiditate architecto enim tenetur voluptas quae dolor rerum.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8520), "Et molestias dignissimos quia dolorum ut quia culpa.", "https://picsum.photos/640/480/?image=799", "Mae Rath III", 10, 3.0, 940, new DateTime(2022, 10, 24, 9, 5, 47, 64, DateTimeKind.Local).AddTicks(1421) },
                    { 26, "Autem qui qui dicta aliquam libero.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8590), "Eveniet a et voluptatum asperiores iusto modi.", "https://picsum.photos/640/480/?image=931", "Miss Mindy Sanford", 9, 5.0, 141, new DateTime(2022, 11, 4, 17, 57, 4, 841, DateTimeKind.Local).AddTicks(872) },
                    { 27, "Velit mollitia eligendi.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8650), "Dolorem velit eum laudantium repellendus quia dolorem sunt.", "https://picsum.photos/640/480/?image=579", "Miss Angel Effertz", 10, 5.0, 215, new DateTime(2022, 7, 25, 0, 55, 32, 57, DateTimeKind.Local).AddTicks(9302) },
                    { 28, "Repellendus sint vel excepturi similique nihil id ut iste eum.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8720), "In qui nihil eum accusamus animi et facere.", "https://picsum.photos/640/480/?image=582", "Mrs. Inez Rosenbaum", 10, 3.0, 265, new DateTime(2022, 8, 30, 15, 58, 8, 92, DateTimeKind.Local).AddTicks(8730) },
                    { 29, "Quaerat iste aspernatur eos deserunt officiis nemo.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8810), "Quaerat id earum quibusdam voluptatum aliquam.", "https://picsum.photos/640/480/?image=443", "Mr. Iris Walker", 8, 2.0, 820, new DateTime(2022, 7, 16, 16, 33, 3, 432, DateTimeKind.Local).AddTicks(1218) },
                    { 30, "Nesciunt veniam qui perspiciatis et sint voluptate sequi.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8880), "Minus atque doloremque occaecati provident nemo velit voluptate.", "https://picsum.photos/640/480/?image=631", "Miss Diane Dietrich", 4, 2.0, 453, new DateTime(2022, 6, 21, 1, 34, 20, 833, DateTimeKind.Local).AddTicks(9303) },
                    { 31, "Consequatur reprehenderit dolor.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(8940), "Quia debitis harum earum reprehenderit delectus accusantium quod.", "https://picsum.photos/640/480/?image=1070", "Dr. Christian Stokes", 8, 1.0, 771, new DateTime(2023, 2, 28, 9, 40, 22, 773, DateTimeKind.Local).AddTicks(9761) },
                    { 32, "Similique recusandae reiciendis neque aperiam aut ut voluptas.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9010), "Et velit nemo autem consequatur incidunt hic veritatis.", "https://picsum.photos/640/480/?image=285", "Dr. William Osinski", 8, 5.0, 870, new DateTime(2022, 8, 26, 1, 15, 9, 368, DateTimeKind.Local).AddTicks(5346) },
                    { 33, "Voluptate fugit provident neque maiores porro aut a.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9080), "Maiores ut consectetur sint minima officiis qui eius.", "https://picsum.photos/640/480/?image=561", "Diane Sanford DDS", 6, 5.0, 269, new DateTime(2023, 1, 13, 22, 59, 4, 37, DateTimeKind.Local).AddTicks(2974) },
                    { 34, "Quae dicta ipsam eum reiciendis corrupti molestiae quos.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9150), "Impedit est perspiciatis id eum perspiciatis odit nihil voluptatem reiciendis.", "https://picsum.photos/640/480/?image=543", "Bridget Raynor IV", 10, 1.0, 585, new DateTime(2022, 6, 17, 11, 58, 3, 774, DateTimeKind.Local).AddTicks(5870) },
                    { 35, "Iste occaecati eum alias quia omnis eaque tempore.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9240), "Deleniti voluptatem alias reprehenderit.", "https://picsum.photos/640/480/?image=827", "Andres Muller Jr.", 2, 2.0, 453, new DateTime(2022, 8, 14, 6, 50, 39, 730, DateTimeKind.Local).AddTicks(2284) },
                    { 36, "Omnis ducimus placeat modi voluptatibus assumenda quibusdam cupiditate ut consequatur.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9320), "Consequuntur ratione quibusdam officiis fuga quia qui perferendis eos fugiat.", "https://picsum.photos/640/480/?image=715", "Rodney Reichel Jr.", 3, 5.0, 781, new DateTime(2022, 5, 25, 3, 8, 2, 766, DateTimeKind.Local).AddTicks(2111) },
                    { 37, "Dolorum at eligendi quia.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9380), "Consequatur ratione a aspernatur minima et blanditiis sit.", "https://picsum.photos/640/480/?image=932", "Mr. Bill Ortiz", 6, 5.0, 282, new DateTime(2023, 3, 10, 15, 17, 10, 742, DateTimeKind.Local).AddTicks(5381) },
                    { 38, "Odio modi odio rerum voluptas suscipit earum voluptatem.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9440), "Voluptas vel numquam voluptatem qui eum alias.", "https://picsum.photos/640/480/?image=299", "Arlene Steuber I", 10, 3.0, 990, new DateTime(2023, 3, 3, 22, 50, 17, 375, DateTimeKind.Local).AddTicks(7412) },
                    { 39, "Adipisci adipisci voluptatem deleniti saepe nemo itaque animi assumenda.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9520), "Perferendis assumenda illo fuga modi ut necessitatibus facere.", "https://picsum.photos/640/480/?image=978", "Dr. Andrea Pfannerstill", 6, 3.0, 662, new DateTime(2023, 4, 26, 20, 20, 2, 662, DateTimeKind.Local).AddTicks(2686) },
                    { 40, "Non dolorem at odio.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9580), "Ea maiores quod architecto ad aut quo accusamus.", "https://picsum.photos/640/480/?image=303", "Shelley Cormier Sr.", 5, 5.0, 844, new DateTime(2022, 10, 5, 2, 52, 22, 181, DateTimeKind.Local).AddTicks(238) },
                    { 41, "Ut omnis non iste sed aut quia dolores.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9630), "Eius omnis nostrum.", "https://picsum.photos/640/480/?image=373", "Dr. Peggy Hudson", 6, 5.0, 97, new DateTime(2023, 3, 8, 1, 35, 19, 567, DateTimeKind.Local).AddTicks(843) },
                    { 42, "Saepe quibusdam minima non.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9680), "Excepturi recusandae itaque.", "https://picsum.photos/640/480/?image=958", "Tami Ferry MD", 10, 3.0, 960, new DateTime(2022, 11, 23, 19, 5, 3, 709, DateTimeKind.Local).AddTicks(625) },
                    { 43, "Architecto omnis nulla dolorem quia sit aut error.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9810), "Omnis aut cupiditate deleniti.", "https://picsum.photos/640/480/?image=259", "Miss Spencer Okuneva", 10, 2.0, 422, new DateTime(2023, 3, 7, 23, 22, 5, 311, DateTimeKind.Local).AddTicks(9681) },
                    { 44, "Laudantium aperiam nobis vitae deleniti autem eaque quaerat.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9890), "Velit excepturi ut reprehenderit voluptatem eos quidem voluptatem atque aut.", "https://picsum.photos/640/480/?image=244", "Courtney Torp I", 3, 5.0, 198, new DateTime(2022, 11, 1, 14, 48, 57, 425, DateTimeKind.Local).AddTicks(5714) },
                    { 45, "Repellat officia libero sit nulla sapiente et quidem et.", new DateTime(2023, 5, 8, 19, 53, 47, 386, DateTimeKind.Local).AddTicks(9960), "Temporibus nihil voluptatem perspiciatis assumenda in velit animi.", "https://picsum.photos/640/480/?image=324", "Emily Feil IV", 7, 4.0, 90, new DateTime(2022, 12, 1, 0, 36, 6, 617, DateTimeKind.Local).AddTicks(9367) },
                    { 46, "Expedita reiciendis nihil eveniet repellat.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(20), "Eos rerum molestiae eum dolorem.", "https://picsum.photos/640/480/?image=838", "Josephine Kuphal Sr.", 9, 5.0, 643, new DateTime(2023, 2, 6, 7, 50, 0, 957, DateTimeKind.Local).AddTicks(6088) },
                    { 47, "Id tempore veritatis est blanditiis soluta deserunt id temporibus dolorem.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(80), "Delectus porro iusto odit aut.", "https://picsum.photos/640/480/?image=879", "Delores Mitchell PhD", 5, 2.0, 928, new DateTime(2022, 11, 1, 1, 28, 29, 318, DateTimeKind.Local).AddTicks(8906) },
                    { 48, "Beatae deleniti nobis suscipit assumenda esse rem eum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(170), "Dolores quo quasi sunt ut distinctio eum.", "https://picsum.photos/640/480/?image=71", "Ms. Yvette Rutherford", 6, 2.0, 828, new DateTime(2022, 9, 3, 11, 6, 7, 517, DateTimeKind.Local).AddTicks(9562) },
                    { 49, "Nulla officiis tenetur natus qui numquam aspernatur non.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(240), "Ea aspernatur minima sunt eos quod voluptatem.", "https://picsum.photos/640/480/?image=987", "Ms. Vanessa Heidenreich", 6, 3.0, 940, new DateTime(2022, 8, 13, 2, 19, 37, 812, DateTimeKind.Local).AddTicks(3301) },
                    { 50, "Dicta exercitationem et et aut voluptatem sapiente veritatis.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(300), "Autem rerum labore repellendus.", "https://picsum.photos/640/480/?image=806", "Danny Cormier V", 2, 4.0, 619, new DateTime(2022, 8, 13, 6, 5, 33, 0, DateTimeKind.Local).AddTicks(5889) },
                    { 51, "A accusamus dolorem rerum voluptatem qui voluptates voluptas atque consequatur.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(380), "Aut deleniti consequatur adipisci consequatur laudantium omnis nulla ex aspernatur.", "https://picsum.photos/640/480/?image=260", "Patsy Reichert V", 5, 1.0, 498, new DateTime(2022, 6, 7, 19, 14, 48, 944, DateTimeKind.Local).AddTicks(8566) },
                    { 52, "Quos nihil maxime.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(430), "Corporis in quos.", "https://picsum.photos/640/480/?image=175", "Dr. Theodore Littel", 6, 1.0, 770, new DateTime(2022, 7, 11, 7, 10, 46, 580, DateTimeKind.Local).AddTicks(5673) },
                    { 53, "In placeat et ea molestias tenetur quo.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(490), "Amet ut architecto et.", "https://picsum.photos/640/480/?image=538", "Ms. Rita Dickens", 5, 4.0, 456, new DateTime(2023, 3, 24, 9, 13, 46, 686, DateTimeKind.Local).AddTicks(7510) },
                    { 54, "Repudiandae fugit vitae iusto porro.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(540), "Quidem sint corrupti ut quasi.", "https://picsum.photos/640/480/?image=499", "Dr. Doris Sawayn", 4, 5.0, 558, new DateTime(2023, 5, 5, 13, 38, 39, 341, DateTimeKind.Local).AddTicks(4809) },
                    { 55, "Ullam veniam debitis.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(620), "Facere vel qui pariatur nulla et eius ut nam qui.", "https://picsum.photos/640/480/?image=457", "Mr. Rosalie Altenwerth", 9, 3.0, 448, new DateTime(2022, 6, 25, 11, 2, 46, 568, DateTimeKind.Local).AddTicks(4406) },
                    { 56, "Illum et repudiandae fugiat.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(680), "Et sit illum corporis magni.", "https://picsum.photos/640/480/?image=66", "Mr. Dominic Borer", 1, 4.0, 361, new DateTime(2023, 1, 16, 8, 37, 7, 751, DateTimeKind.Local).AddTicks(8467) },
                    { 57, "Culpa illo quaerat voluptatibus reprehenderit iusto.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(740), "Accusamus et sed dolor sapiente qui.", "https://picsum.photos/640/480/?image=643", "Cedric Sauer V", 1, 5.0, 698, new DateTime(2022, 9, 6, 6, 58, 29, 309, DateTimeKind.Local).AddTicks(8942) },
                    { 58, "Veritatis impedit voluptates facilis sapiente repudiandae laudantium fugit rerum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(800), "Inventore ab sed aut commodi.", "https://picsum.photos/640/480/?image=69", "Mrs. James Howell", 1, 5.0, 908, new DateTime(2023, 1, 21, 15, 42, 6, 394, DateTimeKind.Local).AddTicks(8779) },
                    { 59, "Voluptatum aut neque pariatur sint veniam maiores eum consequuntur.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(870), "Accusantium nemo saepe rerum dolor vel.", "https://picsum.photos/640/480/?image=754", "Myron Stehr DDS", 7, 5.0, 803, new DateTime(2023, 3, 3, 15, 49, 0, 439, DateTimeKind.Local).AddTicks(9735) },
                    { 60, "Harum consequatur ab dolorem eos est qui vero voluptatibus assumenda.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(940), "Eaque facere est aliquid repellat ut vero at.", "https://picsum.photos/640/480/?image=308", "Johanna Carroll V", 8, 3.0, 602, new DateTime(2023, 3, 19, 23, 35, 17, 5, DateTimeKind.Local).AddTicks(3516) },
                    { 61, "Expedita rerum occaecati ducimus odit.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1020), "Distinctio autem ea perferendis ducimus dolorem.", "https://picsum.photos/640/480/?image=439", "Corey Raynor DVM", 9, 3.0, 337, new DateTime(2022, 5, 18, 0, 20, 7, 710, DateTimeKind.Local).AddTicks(7174) },
                    { 62, "Sit possimus aut quia voluptas itaque esse.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1090), "Ea nobis unde voluptatem repellendus esse molestias.", "https://picsum.photos/640/480/?image=524", "Ms. Carolyn Lang", 7, 4.0, 587, new DateTime(2023, 2, 17, 22, 34, 52, 82, DateTimeKind.Local).AddTicks(5290) },
                    { 63, "Non aspernatur et sequi a non laudantium voluptatem rerum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1150), "Et unde reiciendis ipsam.", "https://picsum.photos/640/480/?image=1009", "Ms. Daryl Huels", 7, 1.0, 956, new DateTime(2023, 3, 6, 20, 31, 0, 872, DateTimeKind.Local).AddTicks(2695) },
                    { 64, "Voluptas saepe veritatis nam dolorem soluta quo atque laborum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1210), "Rerum nemo et suscipit.", "https://picsum.photos/640/480/?image=998", "Marco Kuphal Sr.", 10, 2.0, 41, new DateTime(2022, 5, 26, 21, 44, 19, 803, DateTimeKind.Local).AddTicks(6850) },
                    { 65, "Possimus iste qui sit consequatur ducimus consequuntur facere maiores.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1280), "Consequatur sit maxime deleniti adipisci porro.", "https://picsum.photos/640/480/?image=1080", "Miss Marian Mante", 4, 2.0, 965, new DateTime(2023, 4, 16, 23, 4, 5, 339, DateTimeKind.Local).AddTicks(9515) },
                    { 66, "Fuga ab et qui aut soluta nesciunt asperiores.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1350), "Molestiae temporibus non sed quibusdam omnis dolorem quia porro quia.", "https://picsum.photos/640/480/?image=531", "Helen Schamberger I", 3, 1.0, 379, new DateTime(2022, 7, 11, 14, 37, 39, 669, DateTimeKind.Local).AddTicks(7830) },
                    { 67, "Ea blanditiis fugiat dignissimos quia.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1430), "Alias ut quaerat ea nesciunt debitis repudiandae.", "https://picsum.photos/640/480/?image=11", "Winston Stracke V", 6, 1.0, 920, new DateTime(2022, 7, 8, 9, 27, 48, 106, DateTimeKind.Local).AddTicks(9099) },
                    { 68, "Omnis aut dolores rerum autem cumque reiciendis voluptatem.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1490), "Sint voluptas quo cumque debitis.", "https://picsum.photos/640/480/?image=481", "Ms. Desiree Bruen", 4, 2.0, 274, new DateTime(2022, 11, 5, 15, 42, 58, 545, DateTimeKind.Local).AddTicks(2276) },
                    { 69, "Dolores molestiae fugiat aperiam corrupti dolor vero consequatur.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1550), "Id officia sint est dicta eaque.", "https://picsum.photos/640/480/?image=389", "Miss Rochelle Krajcik", 3, 1.0, 767, new DateTime(2022, 5, 12, 22, 54, 50, 431, DateTimeKind.Local).AddTicks(2362) },
                    { 70, "Magnam labore sed earum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1610), "Aut officia omnis velit.", "https://picsum.photos/640/480/?image=927", "Ms. Christine Donnelly", 4, 2.0, 352, new DateTime(2022, 6, 1, 5, 22, 4, 774, DateTimeKind.Local).AddTicks(8861) },
                    { 71, "Eius quos ut commodi vel et quia velit ab.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1680), "Quis eaque praesentium ut earum alias quia.", "https://picsum.photos/640/480/?image=652", "Ms. Edith Schoen", 10, 4.0, 817, new DateTime(2023, 3, 27, 1, 33, 52, 50, DateTimeKind.Local).AddTicks(8487) },
                    { 72, "Quisquam quia alias temporibus dicta non deserunt dolores ipsam.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1750), "Molestias quasi voluptatem eos natus ratione vel non deserunt.", "https://picsum.photos/640/480/?image=664", "Ms. Crystal Schimmel", 3, 3.0, 25, new DateTime(2022, 12, 2, 13, 23, 19, 973, DateTimeKind.Local).AddTicks(3983) },
                    { 73, "Labore exercitationem non illum mollitia et perferendis ut in labore.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1840), "Magnam perferendis mollitia ad aut eum dolor.", "https://picsum.photos/640/480/?image=53", "Miss Lewis O'Reilly", 10, 3.0, 880, new DateTime(2023, 1, 31, 15, 32, 12, 384, DateTimeKind.Local).AddTicks(1104) },
                    { 74, "Asperiores id voluptates.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1890), "Eum mollitia eligendi qui.", "https://picsum.photos/640/480/?image=265", "Mrs. Emanuel White", 4, 2.0, 504, new DateTime(2022, 9, 30, 18, 31, 6, 336, DateTimeKind.Local).AddTicks(2414) },
                    { 75, "Quia dolorum et quas sint repellendus minima earum possimus distinctio.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(1960), "Illum alias dolor et iusto beatae aut.", "https://picsum.photos/640/480/?image=1084", "Dianna Doyle III", 4, 2.0, 554, new DateTime(2023, 3, 5, 13, 24, 17, 513, DateTimeKind.Local).AddTicks(2228) },
                    { 76, "Ea at est voluptatem beatae ipsum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2030), "Dicta omnis ducimus nisi autem praesentium ratione non.", "https://picsum.photos/640/480/?image=660", "Miss Jasmine Abbott", 4, 5.0, 900, new DateTime(2023, 2, 13, 4, 57, 8, 281, DateTimeKind.Local).AddTicks(7614) },
                    { 77, "Corrupti inventore id voluptas et labore itaque.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2090), "Provident ipsum vero quia animi perspiciatis fugiat.", "https://picsum.photos/640/480/?image=17", "Dr. Crystal Bayer", 9, 2.0, 411, new DateTime(2022, 7, 25, 16, 58, 38, 99, DateTimeKind.Local).AddTicks(2334) },
                    { 78, "Ab debitis sed assumenda labore et.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2160), "Sint consectetur ipsa praesentium quam facere porro atque reprehenderit sint.", "https://picsum.photos/640/480/?image=191", "Miss Felipe Ziemann", 1, 4.0, 162, new DateTime(2022, 7, 10, 17, 51, 16, 971, DateTimeKind.Local).AddTicks(1562) },
                    { 79, "Dolores sed qui quibusdam voluptate minima optio molestiae.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2240), "Alias repudiandae doloribus voluptatum.", "https://picsum.photos/640/480/?image=96", "Mrs. Steven Legros", 2, 3.0, 777, new DateTime(2022, 10, 14, 4, 34, 12, 624, DateTimeKind.Local).AddTicks(6311) },
                    { 80, "Deleniti dicta qui est explicabo.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2300), "Ipsum unde aut necessitatibus molestias aut ratione.", "https://picsum.photos/640/480/?image=1016", "Mr. Tommy Nienow", 3, 1.0, 621, new DateTime(2022, 11, 11, 21, 21, 5, 528, DateTimeKind.Local).AddTicks(5033) },
                    { 81, "Facilis tempore natus et exercitationem ducimus.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2360), "Laborum autem non consequatur.", "https://picsum.photos/640/480/?image=500", "Willard Crona II", 2, 5.0, 612, new DateTime(2022, 10, 12, 15, 51, 7, 369, DateTimeKind.Local).AddTicks(7417) },
                    { 82, "Est amet deleniti eos laborum qui ex ut.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2420), "Ad ut fugit pariatur.", "https://picsum.photos/640/480/?image=909", "Willie Monahan DDS", 9, 4.0, 163, new DateTime(2022, 9, 17, 16, 54, 17, 274, DateTimeKind.Local).AddTicks(2418) },
                    { 83, "Aut eligendi ex illo est.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2490), "Illum nisi id nihil rerum vitae exercitationem velit recusandae consequatur.", "https://picsum.photos/640/480/?image=36", "Alexandra Ryan V", 4, 3.0, 397, new DateTime(2023, 4, 3, 16, 18, 16, 284, DateTimeKind.Local).AddTicks(7164) },
                    { 84, "Rerum animi perferendis quia et numquam nostrum ea velit officia.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2560), "Modi alias harum quo facere illo sint porro.", "https://picsum.photos/640/480/?image=285", "Dr. Delbert Bogan", 10, 1.0, 76, new DateTime(2022, 5, 23, 0, 13, 8, 439, DateTimeKind.Local).AddTicks(6537) },
                    { 85, "Natus est rerum.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2620), "Reprehenderit est est.", "https://picsum.photos/640/480/?image=116", "Mr. Gerald Gleason", 2, 5.0, 334, new DateTime(2022, 5, 20, 11, 52, 7, 672, DateTimeKind.Local).AddTicks(7878) },
                    { 86, "Nihil consequatur excepturi.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2680), "Tenetur occaecati voluptas voluptatem.", "https://picsum.photos/640/480/?image=22", "Marianne Metz V", 4, 5.0, 410, new DateTime(2022, 9, 25, 1, 10, 13, 308, DateTimeKind.Local).AddTicks(9778) },
                    { 87, "Rem voluptatibus nesciunt.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(2730), "Dolores saepe perferendis et numquam et.", "https://picsum.photos/640/480/?image=412", "Ken Morissette DVM", 6, 2.0, 817, new DateTime(2022, 12, 13, 4, 9, 57, 102, DateTimeKind.Local).AddTicks(3610) },
                    { 88, "Fugiat rerum excepturi qui aut impedit aut maxime dolor.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3150), "Provident aut necessitatibus et saepe non commodi odio unde minima.", "https://picsum.photos/640/480/?image=323", "Lisa Kuhlman MD", 1, 2.0, 886, new DateTime(2022, 7, 27, 21, 53, 21, 523, DateTimeKind.Local).AddTicks(486) },
                    { 89, "Rerum quas consequuntur tempore minus.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3210), "Odit optio pariatur molestiae atque.", "https://picsum.photos/640/480/?image=647", "Geoffrey Bosco II", 1, 5.0, 197, new DateTime(2023, 1, 16, 14, 22, 34, 330, DateTimeKind.Local).AddTicks(3026) },
                    { 90, "Ut itaque et quaerat et totam sint cum et.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3270), "Fugit sit deserunt.", "https://picsum.photos/640/480/?image=969", "Dr. Wendy Terry", 4, 2.0, 169, new DateTime(2022, 12, 4, 5, 24, 22, 351, DateTimeKind.Local).AddTicks(8945) },
                    { 91, "Quo maxime qui rem animi et repellat rem ut.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3340), "Doloremque harum sunt dolor sint aut magni et.", "https://picsum.photos/640/480/?image=586", "Amos Yost III", 9, 4.0, 337, new DateTime(2023, 1, 31, 5, 25, 22, 943, DateTimeKind.Local).AddTicks(6040) },
                    { 92, "Laborum repudiandae eos enim magni placeat est eum quia quam.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3440), "Et voluptas sapiente cupiditate dolore est dicta eligendi in.", "https://picsum.photos/640/480/?image=599", "Ms. Margie Schroeder", 8, 1.0, 208, new DateTime(2022, 8, 23, 18, 59, 22, 683, DateTimeKind.Local).AddTicks(1976) },
                    { 93, "Debitis accusantium assumenda sit veniam voluptatem aut ut doloremque quod.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3520), "Pariatur culpa dolorem ipsum non nihil doloribus dolorem maxime sunt.", "https://picsum.photos/640/480/?image=9", "Roberta Zulauf MD", 2, 1.0, 831, new DateTime(2023, 3, 26, 21, 51, 24, 667, DateTimeKind.Local).AddTicks(3682) },
                    { 94, "Repellendus officia repellat sit quo voluptates deleniti ipsam iure.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3580), "Enim sint minus in corporis.", "https://picsum.photos/640/480/?image=945", "Emily Satterfield DVM", 1, 3.0, 46, new DateTime(2023, 5, 5, 17, 57, 18, 828, DateTimeKind.Local).AddTicks(9308) },
                    { 95, "Quibusdam placeat fugiat fugiat.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3640), "Qui ut repellendus modi ad possimus.", "https://picsum.photos/640/480/?image=1028", "Miss Sherman Luettgen", 3, 2.0, 46, new DateTime(2023, 1, 8, 15, 53, 36, 117, DateTimeKind.Local).AddTicks(6137) },
                    { 96, "Labore quaerat omnis assumenda.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3690), "Eum ut ea dolores repudiandae.", "https://picsum.photos/640/480/?image=414", "Marcella West DVM", 10, 3.0, 539, new DateTime(2022, 11, 30, 12, 21, 48, 889, DateTimeKind.Local).AddTicks(910) },
                    { 97, "Laboriosam omnis a ut enim omnis.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3750), "Distinctio dolorem sapiente maxime ipsum asperiores.", "https://picsum.photos/640/480/?image=97", "Lowell Stamm III", 2, 1.0, 419, new DateTime(2022, 12, 28, 21, 23, 23, 385, DateTimeKind.Local).AddTicks(9634) },
                    { 98, "A et a omnis explicabo magni corporis et dicta maxime.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3840), "Qui debitis nulla animi doloribus asperiores aut.", "https://picsum.photos/640/480/?image=600", "Margie Runolfsdottir I", 1, 5.0, 889, new DateTime(2022, 8, 19, 23, 47, 39, 267, DateTimeKind.Local).AddTicks(418) },
                    { 99, "Accusantium sit accusamus voluptatem hic dolor quis.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3900), "Est architecto consequatur tempore eveniet voluptatem non.", "https://picsum.photos/640/480/?image=584", "Beth Bernhard V", 6, 2.0, 613, new DateTime(2022, 12, 22, 18, 33, 30, 801, DateTimeKind.Local).AddTicks(6345) },
                    { 100, "Magnam cupiditate labore.", new DateTime(2023, 5, 8, 19, 53, 47, 387, DateTimeKind.Local).AddTicks(3950), "Illo ea fugit aut.", "https://picsum.photos/640/480/?image=748", "Nick Hane III", 10, 3.0, 690, new DateTime(2023, 3, 12, 3, 22, 2, 308, DateTimeKind.Local).AddTicks(7034) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "", new DateTime(2023, 5, 8, 3, 59, 3, 400, DateTimeKind.Local).AddTicks(8830), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "", "Royal Villa", 5, 200.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "", new DateTime(2023, 5, 8, 3, 59, 3, 400, DateTimeKind.Local).AddTicks(8860), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "", "Luxury Villa", 7, 500.0, 1500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "", new DateTime(2023, 5, 8, 3, 59, 3, 400, DateTimeKind.Local).AddTicks(8860), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "", "Wooden Villa", 3, 100.0, 2000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "", new DateTime(2023, 5, 8, 3, 59, 3, 400, DateTimeKind.Local).AddTicks(8860), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "", "Sea Resort Villa", 10, 600.0, 580, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "SqureFeet", "UpdatedDate" },
                values: new object[] { "", new DateTime(2023, 5, 8, 3, 59, 3, 400, DateTimeKind.Local).AddTicks(8860), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "", "Hill Resort Villa", 8, 900.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
