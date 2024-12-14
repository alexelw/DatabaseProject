using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AreaName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Population = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaID);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    BusID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegistrationNum = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    BusType = table.Column<int>(type: "integer", nullable: false),
                    TotalCapacity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.BusID);
                });

            migrationBuilder.CreateTable(
                name: "Roads",
                columns: table => new
                {
                    RoadID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoadName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roads", x => x.RoadID);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RouteName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TotalDistance = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteID);
                });

            migrationBuilder.CreateTable(
                name: "BusStops",
                columns: table => new
                {
                    BusStopID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BusStopName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    AreaID = table.Column<int>(type: "integer", nullable: false),
                    CurrentLatitude = table.Column<decimal>(type: "numeric", nullable: false),
                    CurrentLongitude = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusStops", x => x.BusStopID);
                    table.ForeignKey(
                        name: "FK_BusStops_Areas_AreaID",
                        column: x => x.AreaID,
                        principalTable: "Areas",
                        principalColumn: "AreaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roadworks",
                columns: table => new
                {
                    RoadworkID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoadID = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roadworks", x => x.RoadworkID);
                    table.ForeignKey(
                        name: "FK_Roadworks_Roads_RoadID",
                        column: x => x.RoadID,
                        principalTable: "Roads",
                        principalColumn: "RoadID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrafficConditions",
                columns: table => new
                {
                    TrafficID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoadID = table.Column<int>(type: "integer", nullable: false),
                    CurrentCondition = table.Column<int>(type: "integer", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrafficConditions", x => x.TrafficID);
                    table.ForeignKey(
                        name: "FK_TrafficConditions_Roads_RoadID",
                        column: x => x.RoadID,
                        principalTable: "Roads",
                        principalColumn: "RoadID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusLocations",
                columns: table => new
                {
                    BusLocationID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BusID = table.Column<int>(type: "integer", nullable: false),
                    CurrentRouteID = table.Column<int>(type: "integer", nullable: false),
                    CurrentRoadID = table.Column<int>(type: "integer", nullable: false),
                    CurrentCapacity = table.Column<int>(type: "integer", nullable: false),
                    CurrentLatitude = table.Column<decimal>(type: "numeric", nullable: false),
                    CurrentLongitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusLocations", x => x.BusLocationID);
                    table.ForeignKey(
                        name: "FK_BusLocations_Buses_BusID",
                        column: x => x.BusID,
                        principalTable: "Buses",
                        principalColumn: "BusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusLocations_Roads_CurrentRoadID",
                        column: x => x.CurrentRoadID,
                        principalTable: "Roads",
                        principalColumn: "RoadID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusLocations_Routes_CurrentRouteID",
                        column: x => x.CurrentRouteID,
                        principalTable: "Routes",
                        principalColumn: "RouteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduledJourneys",
                columns: table => new
                {
                    JourneyID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BusID = table.Column<int>(type: "integer", nullable: false),
                    RouteID = table.Column<int>(type: "integer", nullable: false),
                    ExpDeparture = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ActDeparture = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExpArrival = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ActArrival = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    BusRouteRouteID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledJourneys", x => x.JourneyID);
                    table.ForeignKey(
                        name: "FK_ScheduledJourneys_Buses_BusID",
                        column: x => x.BusID,
                        principalTable: "Buses",
                        principalColumn: "BusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduledJourneys_Routes_BusRouteRouteID",
                        column: x => x.BusRouteRouteID,
                        principalTable: "Routes",
                        principalColumn: "RouteID");
                });

            migrationBuilder.CreateTable(
                name: "Popularities",
                columns: table => new
                {
                    PopularityID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StopID = table.Column<int>(type: "integer", nullable: false),
                    RouteID = table.Column<int>(type: "integer", nullable: false),
                    PopularityScore = table.Column<int>(type: "integer", nullable: false),
                    BusStopID = table.Column<int>(type: "integer", nullable: false),
                    BusRouteRouteID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Popularities", x => x.PopularityID);
                    table.ForeignKey(
                        name: "FK_Popularities_BusStops_BusStopID",
                        column: x => x.BusStopID,
                        principalTable: "BusStops",
                        principalColumn: "BusStopID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Popularities_Routes_BusRouteRouteID",
                        column: x => x.BusRouteRouteID,
                        principalTable: "Routes",
                        principalColumn: "RouteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StopSequences",
                columns: table => new
                {
                    SequenceID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RouteID = table.Column<int>(type: "integer", nullable: false),
                    StopID = table.Column<int>(type: "integer", nullable: false),
                    StopOrder = table.Column<int>(type: "integer", nullable: false),
                    busRouteRouteID = table.Column<int>(type: "integer", nullable: false),
                    BusStopID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopSequences", x => x.SequenceID);
                    table.ForeignKey(
                        name: "FK_StopSequences_BusStops_BusStopID",
                        column: x => x.BusStopID,
                        principalTable: "BusStops",
                        principalColumn: "BusStopID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StopSequences_Routes_busRouteRouteID",
                        column: x => x.busRouteRouteID,
                        principalTable: "Routes",
                        principalColumn: "RouteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusLocations_BusID",
                table: "BusLocations",
                column: "BusID");

            migrationBuilder.CreateIndex(
                name: "IX_BusLocations_CurrentRoadID",
                table: "BusLocations",
                column: "CurrentRoadID");

            migrationBuilder.CreateIndex(
                name: "IX_BusLocations_CurrentRouteID",
                table: "BusLocations",
                column: "CurrentRouteID");

            migrationBuilder.CreateIndex(
                name: "IX_BusStops_AreaID",
                table: "BusStops",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Popularities_BusRouteRouteID",
                table: "Popularities",
                column: "BusRouteRouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Popularities_BusStopID",
                table: "Popularities",
                column: "BusStopID");

            migrationBuilder.CreateIndex(
                name: "IX_Roadworks_RoadID",
                table: "Roadworks",
                column: "RoadID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledJourneys_BusID",
                table: "ScheduledJourneys",
                column: "BusID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledJourneys_BusRouteRouteID",
                table: "ScheduledJourneys",
                column: "BusRouteRouteID");

            migrationBuilder.CreateIndex(
                name: "IX_StopSequences_busRouteRouteID",
                table: "StopSequences",
                column: "busRouteRouteID");

            migrationBuilder.CreateIndex(
                name: "IX_StopSequences_BusStopID",
                table: "StopSequences",
                column: "BusStopID");

            migrationBuilder.CreateIndex(
                name: "IX_TrafficConditions_RoadID",
                table: "TrafficConditions",
                column: "RoadID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusLocations");

            migrationBuilder.DropTable(
                name: "Popularities");

            migrationBuilder.DropTable(
                name: "Roadworks");

            migrationBuilder.DropTable(
                name: "ScheduledJourneys");

            migrationBuilder.DropTable(
                name: "StopSequences");

            migrationBuilder.DropTable(
                name: "TrafficConditions");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "BusStops");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Roads");

            migrationBuilder.DropTable(
                name: "Areas");
        }
    }
}
