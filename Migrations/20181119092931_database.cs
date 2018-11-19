using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GamingBlog.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Releasedate = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Releasedate = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    CommentId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    CommentDate = table.Column<string>(nullable: true),
                    CommentText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.CommentId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogID", "Content", "Releasedate", "Title" },
                values: new object[] { 1L, "vel-dolores-consequatur-aliquid-excepturi-magni-exercitationem-omnis", "illum-magnam-dolorem-nam-dolor-sit-maxime-voluptatem", "ut-rerum-enim-aut-qui-ut-rerum-et" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogID", "Content", "Releasedate", "Title" },
                values: new object[] { 2L, "eaque-vitae-id-atque-neque-suscipit-distinctio-ut", "soluta-rerum-veniam-id-consequatur-ex-laboriosam-natus", "voluptas-enim-qui-ab-soluta-consequuntur-similique-voluptas" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogID", "Content", "Releasedate", "Title" },
                values: new object[] { 3L, "soluta-voluptatibus-voluptatibus-fugiat-minus-aut-nisi-accusantium", "deserunt-quisquam-non-fugiat-in-quo-et-eligendi", "odit-aut-quis-dolorum-maxime-non-optio-dolores" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogID", "Content", "Releasedate", "Title" },
                values: new object[] { 4L, "dolore-voluptatem-ratione-sunt-qui-quas-neque-sed", "est-animi-earum-et-facere-hic-explicabo-rem", "quibusdam-consequatur-ipsam-molestiae-cupiditate-consequatur-reprehenderit-et" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogID", "Content", "Releasedate", "Title" },
                values: new object[] { 5L, "sit-dolor-sit-quibusdam-saepe-odio-itaque-minus", "sed-ut-qui-recusandae-saepe-enim-est-repellendus", "voluptas-repudiandae-et-dolor-aliquid-dolorem-consequatur-aspernatur" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 3L, "laborum-reiciendis-earum-id-officiis-autem-nostrum-perspiciatis", "rem-similique-et-et-quia-qui-quibusdam-rerum", "aut-sit-rerum-recusandae-sint-labore-culpa-sunt", "qui-rerum-distinctio-a-ea-quaerat-tempora-odio" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 4L, "dolor-iusto-et-velit-officia-repellat-pariatur-eos", "tenetur-velit-laudantium-ut-sit-tenetur-qui-rerum", "iste-repellat-reiciendis-quas-ea-voluptas-sed-laudantium", "voluptatem-quas-sint-pariatur-eos-perferendis-non-perspiciatis" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 5L, "odio-adipisci-dolor-molestiae-eum-doloremque-at-rem", "quasi-et-unde-nesciunt-vel-at-dolores-dolorem", "sit-repellat-ab-debitis-illum-temporibus-amet-quod", "porro-assumenda-nemo-tempore-consequatur-rerum-dicta-ut" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 6L, "voluptatem-dolor-voluptate-nam-fugiat-consequatur-porro-molestiae", "repudiandae-molestias-aut-iure-labore-accusantium-commodi-officia", "eaque-unde-perferendis-deserunt-hic-aut-voluptatem-provident", "ut-doloribus-harum-error-facilis-quisquam-architecto-ut" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 7L, "ducimus-est-ex-harum-ut-quam-impedit-et", "rem-dolor-soluta-odio-ipsum-recusandae-exercitationem-nostrum", "veritatis-ex-rerum-minima-perferendis-quaerat-cupiditate-maxime", "quo-fuga-vel-iure-modi-sunt-sit-voluptatem" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 9L, "quo-qui-et-suscipit-blanditiis-enim-tenetur-doloremque", "qui-fugit-corporis-iste-et-cum-quas-vel", "deleniti-et-illum-quisquam-vel-incidunt-rerum-ad", "dicta-amet-rerum-et-aliquam-cum-beatae-voluptas" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 10L, "autem-in-et-atque-illo-aperiam-aperiam-eos", "maiores-reiciendis-enim-cumque-molestiae-reprehenderit-facilis-aperiam", "enim-animi-reprehenderit-ullam-fuga-aut-cum-similique", "est-dolor-ratione-qui-dignissimos-qui-quaerat-et" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 11L, "molestias-architecto-rerum-vero-est-mollitia-repellendus-esse", "nisi-officia-ipsam-facilis-cumque-reiciendis-rerum-ea", "modi-ut-voluptatem-at-et-et-ea-fugit", "vitae-odio-rerum-pariatur-provident-aut-itaque-ipsum" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 14L, "qui-quisquam-maiores-blanditiis-voluptatem-alias-saepe-doloremque", "minima-ratione-non-consectetur-commodi-labore-tempora-necessitatibus", "fuga-ex-non-ut-ullam-dolores-illo-sint", "sit-similique-dolor-velit-nemo-natus-ipsum-minima" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 13L, "et-doloribus-voluptatum-dolores-modi-sunt-nam-earum", "quis-qui-voluptates-neque-tempore-est-et-et", "iusto-ut-aut-eveniet-suscipit-ad-ea-eveniet", "iste-molestiae-qui-pariatur-ea-sequi-a-a" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 2L, "laudantium-non-quis-dolor-nobis-repellat-omnis-sed", "recusandae-laborum-quae-quas-quos-occaecati-aut-quis", "aut-quasi-exercitationem-voluptas-labore-modi-incidunt-quis", "cumque-commodi-consequatur-quae-quia-provident-animi-est" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 15L, "officiis-provident-in-rerum-ipsum-quas-quidem-consequatur", "amet-est-doloribus-voluptatem-est-eos-iste-non", "autem-eos-officiis-et-rerum-in-facilis-nihil", "magnam-aut-reiciendis-aut-eum-sed-nemo-veritatis" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 16L, "molestiae-ex-ut-est-neque-provident-aut-est", "omnis-consequatur-soluta-doloribus-voluptate-quos-illum-aut", "quos-explicabo-beatae-praesentium-magni-doloremque-iure-repellendus", "excepturi-nesciunt-earum-deleniti-voluptatem-consequuntur-veritatis-ipsum" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 17L, "dolores-adipisci-quia-rem-nam-sed-ut-et", "aperiam-voluptates-et-voluptatem-aliquid-qui-autem-et", "reiciendis-consectetur-ratione-architecto-nihil-quia-labore-modi", "ut-numquam-rerum-ducimus-et-architecto-rerum-consequatur" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 18L, "et-quisquam-maiores-quasi-hic-deserunt-molestias-sit", "et-omnis-ipsa-sint-ut-sint-officiis-aspernatur", "ut-non-autem-aut-iure-eaque-ut-suscipit", "voluptates-accusantium-qui-adipisci-at-consequatur-sunt-ut" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 19L, "et-corporis-non-velit-sunt-debitis-esse-odio", "iusto-saepe-qui-est-asperiores-fugiat-et-alias", "illum-quod-non-dolores-quod-non-ut-et", "in-necessitatibus-velit-quia-earum-sit-culpa-quia" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 20L, "possimus-hic-voluptas-unde-quo-saepe-consequatur-commodi", "neque-possimus-optio-nulla-velit-distinctio-molestias-aperiam", "nulla-rerum-magnam-quia-distinctio-autem-minima-reiciendis", "ea-animi-fugit-vel-quas-unde-nesciunt-harum" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 12L, "autem-aperiam-rerum-consequatur-quas-in-doloremque-iure", "animi-pariatur-excepturi-suscipit-laboriosam-omnis-velit-non", "facere-officiis-quaerat-excepturi-perferendis-sit-earum-tenetur", "consectetur-at-dolorum-atque-dignissimos-quibusdam-et-fugit" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 1L, "est-fugit-qui-laborum-consequatur-non-beatae-qui", "ut-commodi-omnis-commodi-quia-commodi-nemo-ea", "rerum-excepturi-officia-qui-et-magnam-aut-exercitationem", "autem-nulla-voluptatem-voluptate-magni-neque-in-reiciendis" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "Email", "Message", "Name", "Subject" },
                values: new object[] { 8L, "totam-rerum-fugit-accusamus-commodi-dignissimos-eligendi-quos", "quia-error-consequatur-ut-culpa-dicta-sunt-sint", "vel-illum-id-deleniti-quia-iusto-voluptates-dicta", "quibusdam-id-cum-et-non-aut-consequatur-corrupti" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 20L, "possimus-explicabo-odio-voluptatem-repudiandae-eum-deserunt-ea", "rerum-maxime-in-in-rerum-voluptatum-ipsam-omnis", "omnis-commodi-tempora-omnis-nesciunt-molestiae-nemo-aliquam" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 3L, "et-totam-unde-natus-porro-accusantium-consequatur-deleniti", "quam-sequi-voluptas-quo-velit-fugit-enim-unde", "doloremque-illo-deleniti-consequatur-neque-debitis-aliquid-sit" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 4L, "voluptatibus-assumenda-veniam-atque-quia-id-maiores-earum", "fuga-explicabo-in-harum-et-nihil-voluptatem-natus", "voluptas-repudiandae-atque-occaecati-libero-earum-est-sit" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 5L, "minus-et-dolorem-magnam-reprehenderit-fugiat-sint-quo", "minus-qui-quam-excepturi-dolorum-eius-esse-reprehenderit", "voluptatem-veniam-numquam-ipsam-sed-cum-fuga-id" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 6L, "et-explicabo-quis-eum-qui-quis-autem-nemo", "dolor-numquam-in-hic-maxime-occaecati-ex-rerum", "odit-harum-ut-laboriosam-consequatur-aut-earum-fuga" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 7L, "molestiae-voluptas-quia-ut-omnis-quis-mollitia-non", "qui-cum-placeat-sed-similique-id-unde-ut", "quasi-impedit-minus-ea-rerum-totam-facilis-et" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 8L, "dicta-repellat-ut-ullam-architecto-sed-voluptatibus-doloremque", "voluptatibus-perspiciatis-facere-ullam-praesentium-magni-voluptatibus-voluptate", "nihil-enim-aut-et-assumenda-sequi-voluptatem-quis" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 9L, "est-quia-reiciendis-consequatur-distinctio-culpa-vero-est", "ducimus-maxime-blanditiis-ea-dolorem-necessitatibus-non-vero", "vitae-qui-modi-accusantium-maiores-magnam-dignissimos-earum" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 10L, "maxime-hic-maiores-hic-recusandae-nostrum-eum-fugiat", "aut-quo-illum-omnis-sit-ullam-vero-dignissimos", "natus-quisquam-pariatur-porro-tempore-culpa-et-sed" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 11L, "delectus-dolor-totam-ut-in-qui-ut-ratione", "iste-voluptas-in-placeat-natus-et-quis-accusamus", "rerum-nobis-reprehenderit-voluptas-quasi-placeat-quo-repellendus" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 12L, "aliquid-voluptatibus-eum-maiores-amet-sint-laudantium-asperiores", "vitae-dignissimos-fuga-quo-deserunt-voluptates-voluptas-quisquam", "blanditiis-voluptatibus-modi-eligendi-est-odit-rerum-rerum" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 19L, "aliquam-iste-aut-voluptas-expedita-autem-et-incidunt", "consectetur-officiis-sunt-ullam-accusamus-voluptatem-et-in", "eius-quibusdam-error-aut-reprehenderit-modi-sit-unde" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 13L, "nulla-tempore-officiis-dicta-non-ratione-veritatis-vero", "aut-sed-voluptatibus-voluptatem-qui-sed-et-eum", "inventore-molestiae-nam-fugit-asperiores-expedita-ad-reiciendis" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 14L, "omnis-reprehenderit-harum-exercitationem-odio-assumenda-hic-eligendi", "eveniet-cupiditate-repudiandae-quam-eveniet-veniam-a-dolorem", "voluptatibus-et-id-reprehenderit-molestiae-est-eveniet-suscipit" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 15L, "rem-et-dolores-commodi-illo-rerum-ab-nesciunt", "nihil-at-qui-excepturi-ipsa-autem-laudantium-sapiente", "qui-consequuntur-aliquam-ullam-sed-perferendis-non-omnis" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 16L, "dolorem-rerum-magnam-et-et-mollitia-magni-sed", "omnis-sed-sed-dolores-excepturi-voluptas-esse-consequuntur", "sunt-eius-porro-quae-qui-dignissimos-quia-id" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 17L, "impedit-magni-qui-voluptatibus-exercitationem-rerum-quidem-accusantium", "laudantium-vero-qui-earum-quidem-officia-rerum-qui", "et-voluptatibus-id-quas-quo-voluptas-ducimus-autem" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 18L, "culpa-eveniet-et-nesciunt-impedit-et-assumenda-quo", "vel-non-velit-esse-quidem-magnam-qui-dolor", "ea-repellat-tempore-expedita-rerum-voluptatum-quos-voluptatibus" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 2L, "illum-dicta-voluptas-quasi-voluptatibus-dolorem-omnis-magni", "est-dolorum-quae-et-cum-et-dolor-aspernatur", "dignissimos-exercitationem-ipsam-enim-ut-id-quod-voluptatem" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Content", "Name", "Releasedate" },
                values: new object[] { 1L, "vitae-commodi-dolore-qui-quisquam-est-dolores-ullam", "ut-non-aliquid-quia-fuga-non-dolor-accusantium", "laborum-et-similique-doloribus-vero-doloremque-laboriosam-perspiciatis" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 1L, "dignissimos-vero-distinctio-consequuntur-placeat-voluptas-itaque-quod", "deleniti-et-ut-doloremque-repellat-quam-reprehenderit-eum", "quo-eligendi-et-sequi-sint-molestiae-dolor-qui" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 2L, "sequi-ipsa-nobis-rerum-sunt-neque-et-fugiat", "sit-eum-voluptatem-ullam-voluptas-sit-molestias-sint", "dolore-nulla-vitae-natus-ex-minima-voluptatem-quaerat" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 18L, "perferendis-sit-beatae-accusamus-odio-nulla-molestiae-animi", "commodi-est-voluptatem-illo-deserunt-dolores-aperiam-porro", "earum-sit-eum-et-et-eius-dolorem-similique" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 17L, "ea-qui-provident-est-architecto-in-facere-quia", "a-sed-eligendi-quia-in-molestiae-dolore-qui", "totam-harum-sint-iusto-et-dolor-beatae-accusamus" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 16L, "vel-odio-natus-molestiae-officiis-consequuntur-maxime-aut", "nostrum-aut-quidem-omnis-aut-ut-quibusdam-tenetur", "aut-consequatur-ut-perspiciatis-et-a-veniam-nihil" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 15L, "beatae-labore-perspiciatis-architecto-voluptas-dolores-vero-sed", "ut-est-exercitationem-cum-id-magnam-reiciendis-enim", "quia-eum-sunt-rerum-quam-quae-quia-magnam" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 14L, "nesciunt-esse-ea-quo-repellat-est-laborum-error", "dicta-quia-placeat-repellendus-quia-autem-praesentium-vel", "eius-voluptas-aliquam-soluta-consequatur-sapiente-voluptas-dolorem" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 13L, "vitae-aperiam-at-qui-sunt-explicabo-delectus-reiciendis", "sint-quisquam-autem-illo-accusamus-magnam-quod-ea", "et-illum-rerum-voluptas-repudiandae-sit-illum-libero" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 12L, "culpa-ut-doloribus-fugiat-illum-reiciendis-dolore-omnis", "voluptates-sunt-ea-consequatur-commodi-autem-aut-doloribus", "a-quaerat-voluptate-eos-provident-rerum-velit-cupiditate" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 20L, "ratione-libero-enim-aut-esse-sit-est-sed", "rerum-ipsa-atque-et-ex-laborum-velit-voluptates", "consectetur-explicabo-sapiente-rerum-voluptate-consectetur-unde-consequatur" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 11L, "et-voluptas-dolore-tenetur-a-vero-vitae-natus", "vel-laudantium-reprehenderit-dolorem-assumenda-ipsum-ut-magni", "quo-ab-neque-vel-quo-dolores-a-dolores" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 9L, "ut-ipsum-nihil-odio-aperiam-ex-ratione-ullam", "quod-impedit-voluptatem-aliquam-ducimus-et-distinctio-rerum", "ea-minima-delectus-architecto-quisquam-ducimus-soluta-ut" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 8L, "molestias-non-omnis-sint-consectetur-et-maxime-eius", "earum-voluptatibus-aliquid-et-cupiditate-doloremque-facere-ea", "maiores-et-ad-doloribus-aliquam-ullam-nobis-rem" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 7L, "animi-nihil-dolor-dolorem-dolor-alias-dolorem-at", "nostrum-sunt-maiores-molestiae-consequatur-labore-rerum-enim", "quia-molestiae-deleniti-velit-labore-nemo-nisi-in" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 6L, "non-veniam-eum-hic-voluptas-cumque-vero-provident", "ea-incidunt-magni-aliquam-est-impedit-debitis-quos", "dolor-eum-voluptatem-omnis-ut-tempore-veritatis-voluptatibus" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 5L, "non-ex-iste-sint-quo-consectetur-amet-numquam", "perferendis-nulla-suscipit-soluta-eius-eum-iste-suscipit", "repellendus-sequi-omnis-ea-quia-aut-omnis-ipsum" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 4L, "laboriosam-dolorem-in-expedita-est-quia-modi-deserunt", "nobis-qui-facilis-dolores-aliquam-sunt-maiores-error", "iste-sint-pariatur-dolorem-aut-sunt-veritatis-et" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 3L, "corporis-beatae-voluptates-tempore-nulla-dolorum-ipsa-neque", "ut-ea-aut-nihil-sequi-doloribus-ipsum-ipsam", "nesciunt-optio-libero-fugit-aperiam-natus-ea-nostrum" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 10L, "ab-accusamus-qui-aut-sit-est-placeat-inventore", "nulla-qui-autem-voluptatem-tempora-corporis-amet-qui", "eum-voluptas-corrupti-dolorem-rerum-voluptatibus-temporibus-a" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "Name" },
                values: new object[] { 19L, "eum-autem-quos-ipsam-in-qui-magnam-amet", "et-sapiente-mollitia-inventore-dolores-rerum-soluta-aut", "ex-sint-aut-maiores-nulla-voluptatum-autem-eaque" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
