using Microsoft.EntityFrameworkCore;
using MyProject.Enums;
using MyProject.Models;

namespace MyProject.Data.Seeders
{
    public class DbSeederService : IDbSeeder
    {
        public void Seed(AppDbContext context)
        {
            SeedAreas(context);
            SeedBuses(context);
            SeedBusStops(context);
            SeedBusRoutes(context);
            SeedPopularities(context);
            SeedRoads(context);
            SeedRoadworks(context);
            SeedBusLocation(context);
            SeedScheduledJourneys(context);
            SeedStopSequences(context);
            SeedTrafficConditions(context);
        }
        private void SeedAreas(AppDbContext context)
        {
            if (!context.Areas.Any())
            {
                Console.WriteLine("Seeding Areas...");
                var areas = new List<Area>
                {
                    new Area { AreaName = "City Centre", Population = 100000 },
                    new Area { AreaName = "Clifton", Population = 24000 },
                    new Area { AreaName = "Southville", Population = 25000 },
                    new Area { AreaName = "Bedminster", Population = 30000 },
                    new Area { AreaName = "Redland", Population = 20000 },
                    new Area { AreaName = "Montpelier", Population = 15000 },
                    new Area { AreaName = "Cotham", Population = 12000 },
                    new Area { AreaName = "St. Paul’s", Population = 22000 },
                    new Area { AreaName = "St. Werburgh’s", Population = 18000 },
                    new Area { AreaName = "Bishopston", Population = 23000 },
                    new Area { AreaName = "Easton", Population = 35000 },
                    new Area { AreaName = "Stapleton", Population = 14000 },
                    new Area { AreaName = "Fishponds", Population = 35000 },
                    new Area { AreaName = "Kingswood", Population = 45000 },
                    new Area { AreaName = "Downend", Population = 25000 },
                    new Area { AreaName = "Brislington", Population = 28000 },
                    new Area { AreaName = "Lawrence Hill", Population = 28000 },
                    new Area { AreaName = "Horfield", Population = 27000 },
                    new Area { AreaName = "Filton", Population = 26000 },
                    new Area { AreaName = "Whitchurch", Population = 22000 },
                    new Area { AreaName = "Bristol Airport", Population = 1500 },
                    new Area { AreaName = "Bristol Parkway Station", Population = 2000 },
                    new Area { AreaName = "Patchway", Population = 27000 },
                    new Area { AreaName = "Bradley Stoke", Population = 30000 },
                    new Area { AreaName = "Avonmouth", Population = 20000 },
                    new Area { AreaName = "Hotwells", Population = 18000 },
                    new Area { AreaName = "Bedminster Down", Population = 22000 },
                    new Area { AreaName = "Knowle", Population = 35000 },
                    new Area { AreaName = "Eastville", Population = 25000 },
                    new Area { AreaName = "Stockwood", Population = 27000 },
                    new Area { AreaName = "St George", Population = 38000 },
                    new Area { AreaName = "Redfield", Population = 26000 },
                    new Area { AreaName = "Sea Mills", Population = 15000 },
                    new Area { AreaName = "Shirehampton", Population = 20000 }
                };
                context.Areas.AddRange(areas);
                context.SaveChanges();
            }
            else 
            {
                Console.WriteLine("Data already exists");
            }
        }
        private void SeedBusStops(AppDbContext context)
        {
            if (!context.BusStops.Any())
            {
                var busStops = new List<BusStop>
                {
                    new BusStop
                    {
                        BusStopName = "Cossham Hospital",
                        CurrentLatitude = 51.4634m,
                        CurrentLongitude = -2.5105m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 1) ?? throw new InvalidOperationException("Area not found") // Ensure Area is not null
                    },
                    new BusStop
                    {
                        BusStopName = "Lodge Causeway",
                        CurrentLatitude = 51.4789m,
                        CurrentLongitude = -2.5463m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 2) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Filton Avenue",
                        CurrentLatitude = 51.5090m,
                        CurrentLongitude = -2.5891m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 3) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Gloucester Road (North)",
                        CurrentLatitude = 51.4876m,
                        CurrentLongitude = -2.5950m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 4) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "North Street",
                        CurrentLatitude = 51.4392m,
                        CurrentLongitude = -2.5954m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 5) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Bristol Parkway Station",
                        CurrentLatitude = 51.5084m,
                        CurrentLongitude = -2.5491m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 6) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Kingswood High Street",
                        CurrentLatitude = 51.4578m,
                        CurrentLongitude = -2.5086m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 7) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Stoke Bishop",
                        CurrentLatitude = 51.4795m,
                        CurrentLongitude = -2.6149m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 8) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Redland Station",
                        CurrentLatitude = 51.4633m,
                        CurrentLongitude = -2.6035m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 9) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Eastville Park",
                        CurrentLatitude = 51.4682m,
                        CurrentLongitude = -2.5511m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 10) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Montpelier Station",
                        CurrentLatitude = 51.4653m,
                        CurrentLongitude = -2.5929m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 11) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Clifton Down",
                        CurrentLatitude = 51.4574m,
                        CurrentLongitude = -2.6165m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 12) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Bedminster Down",
                        CurrentLatitude = 51.4182m,
                        CurrentLongitude = -2.5963m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 13) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Southmead Hospital",
                        CurrentLatitude = 51.4971m,
                        CurrentLongitude = -2.5894m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 14) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Whitchurch Road",
                        CurrentLatitude = 51.4232m,
                        CurrentLongitude = -2.5968m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 15) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Broadmead (The Horsefair)",
                        CurrentLatitude = 51.4540m,
                        CurrentLongitude = -2.5959m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 1) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Clifton Down Railway Station",
                        CurrentLatitude = 51.4595m,
                        CurrentLongitude = -2.6125m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 2) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Southville (Bristol), Windmill Hill",
                        CurrentLatitude = 51.4395m,
                        CurrentLongitude = -2.5999m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 3) ??  throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Bedminster Down, The Old Dairy",
                        CurrentLatitude = 51.4170m,
                        CurrentLongitude = -2.5940m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 4) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Redland Station",
                        CurrentLatitude = 51.4633m,
                        CurrentLongitude = -2.6035m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 5) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Montpelier, Cheltenham Road",
                        CurrentLatitude = 51.4631m,
                        CurrentLongitude = -2.5884m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 6) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Cotham Hill, near the junction with Whiteladies Road",
                        CurrentLatitude = 51.4642m,
                        CurrentLongitude = -2.5934m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 7) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Horfield, Muller Road",
                        CurrentLatitude = 51.4887m,
                        CurrentLongitude = -2.5892m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 8) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "St. Paul’s, Portland Square",
                        CurrentLatitude = 51.4631m,
                        CurrentLongitude = -2.5914m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 9) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "St. Werburgh’s, Wellwood Road",
                        CurrentLatitude = 51.4517m,
                        CurrentLongitude = -2.5632m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 10) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Bishopston, Gloucester Road",
                        CurrentLatitude = 51.4785m,
                        CurrentLongitude = -2.5852m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 11) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Easton, Greenbank Cemetery",
                        CurrentLatitude = 51.4636m,
                        CurrentLongitude = -2.5409m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 12) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Stapleton, The Square",
                        CurrentLatitude = 51.4769m,
                        CurrentLongitude = -2.5585m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 13) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Fishponds, Station Road",
                        CurrentLatitude = 51.4797m,
                        CurrentLongitude = -2.5367m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 14) ?? throw new InvalidOperationException("Area not found")
                    },
                    new BusStop
                    {
                        BusStopName = "Kingswood, Kingswood High Street",
                        CurrentLatitude = 51.4577m,
                        CurrentLongitude = -2.5076m,
                        Area = context.Areas.FirstOrDefault(a => a.AreaID == 15) ?? throw new InvalidOperationException("Area not found")
                    }
                };

                context.BusStops.AddRange(busStops);
                context.SaveChanges();
            }
        }
        public void SeedBusRoutes(AppDbContext context)
        {
            var busRoutes = new List<BusRoute>
            {
                new BusRoute
                {
                    RouteName = "17 - Southmead Hospital to Kingswood",
                    TotalDistance = 10,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "1 - Cribbs Causeway to Long Ashton",
                    TotalDistance = 12,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "50 - Redland to Hengrove Park",
                    TotalDistance = 15,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "24 - Fishponds to Bristol City Centre",
                    TotalDistance = 8,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "72 - Bedminster to Shirehampton",
                    TotalDistance = 18,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "48 - St. Paul’s to Bradley Stoke",
                    TotalDistance = 20,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "19 - Bishopston to Temple Meads",
                    TotalDistance = 9,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "X2 - Bristol Parkway to City Centre",
                    TotalDistance = 11,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "8 - Easton to Southmead Hospital",
                    TotalDistance = 14,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "36 - Knowle to Weston-super-Mare",
                    TotalDistance = 25,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "75 - Clifton to Henbury",
                    TotalDistance = 10,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "99 - Horfield to Redfield",
                    TotalDistance = 7,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "10 - Montpelier to Bedminster",
                    TotalDistance = 6,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "21 - Bishopston to Eastville",
                    TotalDistance = 5,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "3 - Brislington to Filton",
                    TotalDistance = 11,
                    Status = RouteStatus.active
                },
                new BusRoute
                {
                    RouteName = "8A - Easton to Southmead Hospital via Redland",
                    TotalDistance = 16,
                    Status = RouteStatus.active
                }
            };

            context.Routes.AddRange(busRoutes);
            context.SaveChanges();
        }
        public void SeedRoads(AppDbContext context)
        {
            var roads = new List<Road>
            {
                new Road
                {
                    RoadName = "Park Street"
                },
                new Road
                {
                    RoadName = "Whiteladies Road"
                },
                new Road
                {
                    RoadName = "Clifton Down Road"
                },
                new Road
                {
                    RoadName = "Queen Square"
                },
                new Road
                {
                    RoadName = "College Green"
                },
                new Road
                {
                    RoadName = "Temple Way"
                },
                new Road
                {
                    RoadName = "Bath Road"
                },
                new Road
                {
                    RoadName = "Fishponds Road"
                },
                new Road
                {
                    RoadName = "Broadmead"
                },
                new Road
                {
                    RoadName = "St. Michael’s Hill"
                },
                new Road
                {
                    RoadName = "Redland Road"
                },
                new Road
                {
                    RoadName = "Gloucester Road"
                },
                new Road
                {
                    RoadName = "Bedminster Parade"
                },
                new Road
                {
                    RoadName = "Hotwells Road"
                },
                new Road
                {
                    RoadName = "North Street"
                },
                new Road
                {
                    RoadName = "Easton Road"
                },
                new Road
                {
                    RoadName = "Stapleton Road"
                },
                new Road
                {
                    RoadName = "West Street"
                },
                new Road
                {
                    RoadName = "Kingswood Road"
                },
                new Road
                {
                    RoadName = "St George’s Road"
                },
                new Road
                {
                    RoadName = "Whitchurch Road"
                },
                new Road
                {
                    RoadName = "Fishponds Road"
                },
                new Road
                {
                    RoadName = "Bristol Bridge"
                },
                new Road
                {
                    RoadName = "Trenchard Street"
                },
                new Road
                {
                    RoadName = "The Downs"
                },
                new Road
                {
                    RoadName = "Hotwells Road"
                },
                new Road
                {
                    RoadName = "Brislington Hill"
                },
                new Road
                {
                    RoadName = "Dean Lane"
                },
                new Road
                {
                    RoadName = "Ashley Down Road"
                },
                new Road
                {
                    RoadName = "Old Market Street"
                },
                new Road
                {
                    RoadName = "Stokes Croft"
                },
                new Road
                {
                    RoadName = "Cotham Hill"
                },
                new Road
                {
                    RoadName = "Redcliff Street"
                },
                new Road
                {
                    RoadName = "Bedminster Down"
                },
                new Road
                {
                    RoadName = "Henleaze Road"
                },
                new Road
                {
                    RoadName = "Ashley Road"
                },
                new Road
                {
                    RoadName = "Northumberland Place"
                },
                new Road
                {
                    RoadName = "Whitchurch Lane"
                },
                new Road
                {
                    RoadName = "Lower Ashley Road"
                },
                new Road
                {
                    RoadName = "Barrow Road"
                },
                new Road
                {
                    RoadName = "Clevedon Road"
                },
                new Road
                {
                    RoadName = "Broadlands Road"
                },
                new Road
                {
                    RoadName = "Clifton Road"
                },
                new Road
                {
                    RoadName = "Redland Grove"
                },
                new Road
                {
                    RoadName = "St Barnabas Road"
                },
                new Road
                {
                    RoadName = "Brunswick Square"
                },
                new Road
                {
                    RoadName = "Corn Street"
                },
                new Road
                {
                    RoadName = "The Mall"
                },
                new Road
                {
                    RoadName = "Victoria Street"
                }
            };

            context.Roads.AddRange(roads);
            context.SaveChanges();
        }
        public void SeedPopularities(AppDbContext context)
        {
            if (!context.Popularities.Any())
            {
                var popularities = new List<Popularity>
                {
                    // 17 - Southmead Hospital to Kingswood
                    new Popularity
                    {
                        StopID = 1,
                        RouteID = 1,
                        PopularityScore = PopularityScore.High,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Cossham Hospital") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "17 - Southmead Hospital to Kingswood") ?? throw new InvalidOperationException("BusRoute not found")
                    },
                    new Popularity
                    {
                        StopID = 2,
                        RouteID = 1,
                        PopularityScore = PopularityScore.Medium,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Lodge Causeway") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "17 - Southmead Hospital to Kingswood") ?? throw new InvalidOperationException("BusRoute not found")
                    },

                    // 1 - Cribbs Causeway to Long Ashton
                    new Popularity
                    {
                        StopID = 3,
                        RouteID = 2,
                        PopularityScore = PopularityScore.Low,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Filton Avenue") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "1 - Cribbs Causeway to Long Ashton") ?? throw new InvalidOperationException("BusRoute not found")
                    },
                    new Popularity
                    {
                        StopID = 4,
                        RouteID = 2,
                        PopularityScore = PopularityScore.Medium,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Gloucester Road (North)") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "1 - Cribbs Causeway to Long Ashton") ?? throw new InvalidOperationException("BusRoute not found")
                    },

                    // 50 - Redland to Hengrove Park
                    new Popularity
                    {
                        StopID = 5,
                        RouteID = 3,
                        PopularityScore = PopularityScore.Low,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Redland Station") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "50 - Redland to Hengrove Park") ?? throw new InvalidOperationException("BusRoute not found")
                    },
                    new Popularity
                    {
                        StopID = 6,
                        RouteID = 3,
                        PopularityScore = PopularityScore.Medium,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "North Street") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "50 - Redland to Hengrove Park") ?? throw new InvalidOperationException("BusRoute not found")
                    },

                    // 24 - Fishponds to Bristol City Centre
                    new Popularity
                    {
                        StopID = 7,
                        RouteID = 4,
                        PopularityScore = PopularityScore.Medium,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Southmead Hospital") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "24 - Fishponds to Bristol City Centre") ?? throw new InvalidOperationException("BusRoute not found")
                    },
                    new Popularity
                    {
                        StopID = 8,
                        RouteID = 4,
                        PopularityScore = PopularityScore.High,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Kingswood High Street") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "24 - Fishponds to Bristol City Centre") ?? throw new InvalidOperationException("BusRoute not found")
                    },

                    // 72 - Bedminster to Shirehampton
                    new Popularity
                    {
                        StopID = 9,
                        RouteID = 5,
                        PopularityScore = PopularityScore.Low,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Bristol Parkway Station") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "72 - Bedminster to Shirehampton") ?? throw new InvalidOperationException("BusRoute not found")
                    },
                    new Popularity
                    {
                        StopID = 10,
                        RouteID = 5,
                        PopularityScore = PopularityScore.Medium,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Bedminster Down") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "72 - Bedminster to Shirehampton") ?? throw new InvalidOperationException("BusRoute not found")
                    },

                    // 48 - St. Paul’s to Bradley Stoke
                    new Popularity
                    {
                        StopID = 11,
                        RouteID = 6,
                        PopularityScore = PopularityScore.High,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Stoke Bishop") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "48 - St. Paul’s to Bradley Stoke") ?? throw new InvalidOperationException("BusRoute not found")
                    },
                    new Popularity
                    {
                        StopID = 12,
                        RouteID = 6,
                        PopularityScore = PopularityScore.Low,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Clifton Down") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "48 - St. Paul’s to Bradley Stoke") ?? throw new InvalidOperationException("BusRoute not found")
                    },

                    // 19 - Bishopston to Temple Meads
                    new Popularity
                    {
                        StopID = 13,
                        RouteID = 7,
                        PopularityScore = PopularityScore.Medium,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Redland Station") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "19 - Bishopston to Temple Meads") ?? throw new InvalidOperationException("BusRoute not found")
                    },
                    new Popularity
                    {
                        StopID = 14,
                        RouteID = 7,
                        PopularityScore = PopularityScore.High,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Bristol Parkway Station") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "19 - Bishopston to Temple Meads") ?? throw new InvalidOperationException("BusRoute not found")
                    },

                    // 8A - Easton to Southmead Hospital
                    new Popularity
                    {
                        StopID = 15,
                        RouteID = 8,
                        PopularityScore = PopularityScore.Low,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Bristol Airport") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "8A - Easton to Southmead Hospital") ?? throw new InvalidOperationException("BusRoute not found")
                    },
                    new Popularity
                    {
                        StopID = 16,
                        RouteID = 8,
                        PopularityScore = PopularityScore.Medium,
                        BusStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Whitchurch") ?? throw new InvalidOperationException("BusStop not found"),
                        BusRoute = context.Routes.FirstOrDefault(br => br.RouteName == "8A - Easton to Southmead Hospital") ?? throw new InvalidOperationException("BusRoute not found")
                    }
                };

                context.Popularities.AddRange(popularities);
                context.SaveChanges();
            }
        }
        private void SeedRoadworks(AppDbContext context)
        {
            if (!context.Roadworks.Any())
            {
                var roadworks = new List<Roadwork>
                {
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Clifton")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 1, 10),
                        EndDate = new DateTime(2024, 1, 20),
                        Description = "Repaving and resurfacing work due to road damage after heavy rainfall."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Southville")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 2, 5),
                        EndDate = new DateTime(2024, 2, 15),
                        Description = "Utility maintenance work, including replacing old gas pipelines."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Bedminster")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 3, 1),
                        EndDate = new DateTime(2024, 3, 10),
                        Description = "Installation of new traffic lights at key intersections to improve traffic flow."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Redland")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 4, 10),
                        EndDate = new DateTime(2024, 4, 20),
                        Description = "Pedestrian walkway expansion, with lane closures during working hours."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Montpelier")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 5, 5),
                        EndDate = new DateTime(2024, 5, 12),
                        Description = "Complete street resurfacing due to road subsidence and potholes."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Cotham")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 6, 1),
                        EndDate = new DateTime(2024, 6, 10),
                        Description = "Installation of new drainage systems to prevent flooding during heavy rains."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Horfield")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 7, 15),
                        EndDate = new DateTime(2024, 7, 25),
                        Description = "Road widening and improvement work to accommodate more traffic."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "St. Paul’s")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 8, 1),
                        EndDate = new DateTime(2024, 8, 10),
                        Description = "Street lighting upgrade, including some road closures during the evening."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "St. Werburgh’s")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 9, 5),
                        EndDate = new DateTime(2024, 9, 15),
                        Description = "Water pipe replacement and road patching."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Bishopston")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 10, 10),
                        EndDate = new DateTime(2024, 10, 20),
                        Description = "Major sewer maintenance work requiring partial road closures and rerouted traffic."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Easton")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 11, 1),
                        EndDate = new DateTime(2024, 11, 15),
                        Description = "Street resurfacing and repaving, impacting bus routes and local traffic."
                    },
                    new Roadwork
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Stapleton")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        StartDate = new DateTime(2024, 12, 5),
                        EndDate = new DateTime(2024, 12, 15),
                        Description = "Speed bump installation and sidewalk repairs."
                    }
                };

                context.Roadworks.AddRange(roadworks);
                context.SaveChanges();
            }
        }
        public void SeedStopSequences(AppDbContext context)
        {
            if (!context.StopSequences.Any())
            {
                var stopSequences = new List<StopSequence>
                {
                    // 17 - Southmead Hospital to Kingswood
                    new StopSequence
                    {
                        RouteID = 1,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Southmead Hospital")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 1,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "17 - Southmead Hospital to Kingswood") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Southmead Hospital") ?? throw new InvalidOperationException("BusStop not found")
                    },
                    new StopSequence
                    {
                        RouteID = 1,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Cossham Hospital")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 2,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "17 - Southmead Hospital to Kingswood") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Cossham Hospital") ?? throw new InvalidOperationException("BusStop not found")
                    },
                    new StopSequence
                    {
                        RouteID = 1,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Lodge Causeway")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 3,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "17 - Southmead Hospital to Kingswood") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Lodge Causeway") ?? throw new InvalidOperationException("BusStop not found")
                    },

                    // 1 - Cribbs Causeway to Long Ashton
                    new StopSequence
                    {
                        RouteID = 2,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Cribbs Causeway")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 1,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "1 - Cribbs Causeway to Long Ashton") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Cribbs Causeway") ?? throw new InvalidOperationException("BusStop not found")
                    },
                    new StopSequence
                    {
                        RouteID = 2,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Gloucester Road (North)")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 2,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "1 - Cribbs Causeway to Long Ashton") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Gloucester Road (North)") ?? throw new InvalidOperationException("BusStop not found")
                    },

                    // 50 - Redland to Hengrove Park
                    new StopSequence
                    {
                        RouteID = 3,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Redland Station")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 1,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "50 - Redland to Hengrove Park") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Redland Station") ?? throw new InvalidOperationException("BusStop not found")
                    },
                    new StopSequence
                    {
                        RouteID = 3,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "North Street")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 2,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "50 - Redland to Hengrove Park") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "North Street") ?? throw new InvalidOperationException("BusStop not found")
                    },

                    // 24 - Fishponds to Bristol City Centre
                    new StopSequence
                    {
                        RouteID = 4,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Southmead Hospital")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 1,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "24 - Fishponds to Bristol City Centre") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Southmead Hospital") ?? throw new InvalidOperationException("BusStop not found")
                    },
                    new StopSequence
                    {
                        RouteID = 4,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Kingswood High Street")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 2,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "24 - Fishponds to Bristol City Centre") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Kingswood High Street") ?? throw new InvalidOperationException("BusStop not found")
                    },

                    // 72 - Bedminster to Shirehampton
                    new StopSequence
                    {
                        RouteID = 5,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Bristol Parkway Station")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 1,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "72 - Bedminster to Shirehampton") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Bristol Parkway Station") ?? throw new InvalidOperationException("BusStop not found")
                    },
                    new StopSequence
                    {
                        RouteID = 5,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Bedminster Down")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 2,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "72 - Bedminster to Shirehampton") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Bedminster Down") ?? throw new InvalidOperationException("BusStop not found")
                    },

                    // 48 - St. Paul’s to Bradley Stoke
                    new StopSequence
                    {
                        RouteID = 6,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Stoke Bishop")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 1,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "48 - St. Paul’s to Bradley Stoke") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Stoke Bishop") ?? throw new InvalidOperationException("BusStop not found")
                    },
                    new StopSequence
                    {
                        RouteID = 6,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Clifton Down")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 2,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "48 - St. Paul’s to Bradley Stoke") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Clifton Down") ?? throw new InvalidOperationException("BusStop not found")
                    },

                    // 19 - Bishopston to Temple Meads
                    new StopSequence
                    {
                        RouteID = 7,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Redland Station")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 1,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "19 - Bishopston to Temple Meads") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Redland Station") ?? throw new InvalidOperationException("BusStop not found")
                    },
                    new StopSequence
                    {
                        RouteID = 7,
                        StopID = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Bishopston")?.BusStopID ?? throw new InvalidOperationException("BusStop not found"),
                        StopOrder = 2,
                        busRoute = context.Routes.FirstOrDefault(br => br.RouteName == "19 - Bishopston to Temple Meads") ?? throw new InvalidOperationException("BusRoute not found"),
                        busStop = context.BusStops.FirstOrDefault(bs => bs.BusStopName == "Bishopston") ?? throw new InvalidOperationException("BusStop not found")
                    },
                };

                context.StopSequences.AddRange(stopSequences);
                context.SaveChanges();
            }
        }
        public void SeedTrafficConditions(AppDbContext context)
        {
            if (!context.TrafficConditions.Any())
            {
                var trafficConditions = new List<TrafficCondition>
                {
                    // Sample Traffic Conditions for different roads
                    new TrafficCondition
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "M32")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        CurrentCondition = CurrentCondition.High,
                        TimeStamp = DateTime.Now.AddMinutes(-10), // Recent condition
                        road = context.Roads.FirstOrDefault(r => r.RoadName == "M32") ?? throw new InvalidOperationException("Road not found")
                    },
                    new TrafficCondition
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Gloucester Road")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        CurrentCondition = CurrentCondition.Medium,
                        TimeStamp = DateTime.Now.AddMinutes(-30), // Condition from 30 minutes ago
                        road = context.Roads.FirstOrDefault(r => r.RoadName == "Gloucester Road") ?? throw new InvalidOperationException("Road not found")
                    },
                    new TrafficCondition
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "A4")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        CurrentCondition = CurrentCondition.Low,
                        TimeStamp = DateTime.Now.AddMinutes(-60), // Condition from 1 hour ago
                        road = context.Roads.FirstOrDefault(r => r.RoadName == "A4") ?? throw new InvalidOperationException("Road not found")
                    },
                    new TrafficCondition
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "M5")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        CurrentCondition = CurrentCondition.VeryHigh,
                        TimeStamp = DateTime.Now.AddMinutes(-5), // Recent heavy traffic condition
                        road = context.Roads.FirstOrDefault(r => r.RoadName == "M5") ?? throw new InvalidOperationException("Road not found")
                    },
                    new TrafficCondition
                    {
                        RoadID = context.Roads.FirstOrDefault(r => r.RoadName == "Bristol Road")?.RoadID ?? throw new InvalidOperationException("Road not found"),
                        CurrentCondition = CurrentCondition.VeryLow,
                        TimeStamp = DateTime.Now.AddMinutes(-120), // Condition from 2 hours ago
                        road = context.Roads.FirstOrDefault(r => r.RoadName == "Bristol Road") ?? throw new InvalidOperationException("Road not found")
                    }
                };

                context.TrafficConditions.AddRange(trafficConditions);
                context.SaveChanges();
            }
        }
        public void SeedBusLocation(AppDbContext context)
        {
            // Check if BusLocations are already seeded to avoid duplicates
            if (!context.BusLocations.Any())
            {
                var busLocations = new List<BusLocation>
                {
                    new BusLocation
                    {
                        BusID = 1, 
                        CurrentRouteID = 1, 
                        CurrentRoadID = 1, 
                        CurrentCapacity = 40,
                        CurrentLatitude = 51.456m, 
                        CurrentLongitude = -2.589m,
                        Status = BusStatus.OnRoute,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 1), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 1), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 1)
                    },
                    new BusLocation
                    {
                        BusID = 2, 
                        CurrentRouteID = 2, 
                        CurrentRoadID = 2, 
                        CurrentCapacity = 30,
                        CurrentLatitude = 51.469m, 
                        CurrentLongitude = -2.582m, 
                        Status = BusStatus.Delayed,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 2), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 2), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 2)
                    },
                    new BusLocation
                    {
                        BusID = 3, 
                        CurrentRouteID = 1, 
                        CurrentRoadID = 3, 
                        CurrentCapacity = 50,
                        CurrentLatitude = 51.460m, 
                        CurrentLongitude = -2.595m,
                        Status = BusStatus.OnRoute,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 3), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 1), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 3)
                    },
                    new BusLocation
                    {
                        BusID = 4, 
                        CurrentRouteID = 3, 
                        CurrentRoadID = 4, 
                        CurrentCapacity = 20,
                        CurrentLatitude = 51.478m,
                        CurrentLongitude = -2.570m,
                        Status = BusStatus.OutOfService,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 4), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 3), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 4)
                    },
                    new BusLocation
                    {
                        BusID = 5, 
                        CurrentRouteID = 2, 
                        CurrentRoadID = 5, 
                        CurrentCapacity = 35,
                        CurrentLatitude = 51.460m, 
                        CurrentLongitude = -2.585m,
                        Status = BusStatus.Unknown,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 5), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 2), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 5)
                    },
                    new BusLocation
                    {
                        BusID = 6, 
                        CurrentRouteID = 4, 
                        CurrentRoadID = 6, 
                        CurrentCapacity = 25, 
                        CurrentLatitude = 51.500m, 
                        CurrentLongitude = -2.600m, 
                        Status = BusStatus.OnRoute,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 6), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 4), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 6)
                    },
                    new BusLocation
                    {
                        BusID = 7, 
                        CurrentRouteID = 5, 
                        CurrentRoadID = 7, 
                        CurrentCapacity = 0, 
                        CurrentLatitude = 51.450m, 
                        CurrentLongitude = -2.620m, 
                        Status = BusStatus.OutOfService,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 7), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 5), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 7)
                    },
                    new BusLocation
                    {
                        BusID = 8, 
                        CurrentRouteID = 4, 
                        CurrentRoadID = 8, 
                        CurrentCapacity = 15, 
                        CurrentLatitude = 51.495m, 
                        CurrentLongitude = -2.605m, 
                        Status = BusStatus.Delayed,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 8), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 4), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 8)
                    },
                    new BusLocation
                    {
                        BusID = 9, 
                        CurrentRouteID = 6, 
                        CurrentRoadID = 9, 
                        CurrentCapacity = 50, 
                        CurrentLatitude = 51.505m, 
                        CurrentLongitude = -2.590m, 
                        Status = BusStatus.OnRoute,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 9), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 6), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 9)
                    },
                    new BusLocation
                    {
                        BusID = 10, 
                        CurrentRouteID = 7, 
                        CurrentRoadID = 10, 
                        CurrentCapacity = 40, 
                        CurrentLatitude = 51.520m, 
                        CurrentLongitude = -2.580m, 
                        Status = BusStatus.OnRoute,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 10), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 7), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 10)
                    },
                    new BusLocation
                    {
                        BusID = 11, 
                        CurrentRouteID = 8, 
                        CurrentRoadID = 11, 
                        CurrentCapacity = 10, 
                        CurrentLatitude = 51.480m, 
                        CurrentLongitude = -2.575m, 
                        Status = BusStatus.Unknown,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 11), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 8), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 11)
                    },
                    new BusLocation
                    {
                        BusID = 12, 
                        CurrentRouteID = 8, 
                        CurrentRoadID = 12, 
                        CurrentCapacity = 60, 
                        CurrentLatitude = 51.530m, 
                        CurrentLongitude = -2.590m, 
                        Status = BusStatus.OnRoute,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 12), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 8), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 12)
                    },
                    new BusLocation
                    {
                        BusID = 13, 
                        CurrentRouteID = 9, 
                        CurrentRoadID = 13, 
                        CurrentCapacity = 20, 
                        CurrentLatitude = 51.490m, 
                        CurrentLongitude = -2.570m, 
                        Status = BusStatus.Delayed,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 13), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 9), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 13)
                    },
                    new BusLocation
                    {
                        BusID = 14, 
                        CurrentRouteID = 10, 
                        CurrentRoadID = 14, 
                        CurrentCapacity = 0, 
                        CurrentLatitude = 51.475m, 
                        CurrentLongitude = -2.600m, 
                        Status = BusStatus.OutOfService,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 14), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 10), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 14)
                    },
                    new BusLocation
                    {
                        BusID = 15, 
                        CurrentRouteID = 11, 
                        CurrentRoadID = 15, 
                        CurrentCapacity = 45, 
                        CurrentLatitude = 51.505m, 
                        CurrentLongitude = -2.615m, 
                        Status = BusStatus.OnRoute,
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 15), 
                        CurrentRoute = context.Routes.FirstOrDefault(r => r.RouteID == 11), 
                        CurrentRoad = context.Roads.FirstOrDefault(r => r.RoadID == 15)
                    }
                };

                context.BusLocations.AddRange(busLocations);
                context.SaveChanges();
            }
        }
        private void SeedScheduledJourneys(AppDbContext context)
        {
            // Check if ScheduledJourneys are already seeded to avoid duplicates
            if (!context.ScheduledJourneys.Any())
            {
                var scheduledJourneys = new List<ScheduledJourney>
                {
                    new ScheduledJourney
                    {
                        BusID = 1,
                        RouteID = 1,
                        ExpDeparture = new DateTime(2024, 12, 15, 08, 00, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 08, 05, 00), // Example of actual departure
                        ExpArrival = new DateTime(2024, 12, 15, 09, 00, 00),
                        ActArrival = new DateTime(2024, 12, 15, 09, 10, 00), // Example of actual arrival
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 1), 
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 1)
                    },
                    new ScheduledJourney
                    {
                        BusID = 2,
                        RouteID = 2,
                        ExpDeparture = new DateTime(2024, 12, 15, 08, 30, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 08, 35, 00), // Example of actual departure
                        ExpArrival = new DateTime(2024, 12, 15, 09, 30, 00),
                        ActArrival = new DateTime(2024, 12, 15, 09, 40, 00), // Example of actual arrival
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 2), 
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 2)
                    },
                    new ScheduledJourney
                    {
                        BusID = 3,
                        RouteID = 3,
                        ExpDeparture = new DateTime(2024, 12, 15, 09, 00, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 09, 05, 00), // Example of actual departure
                        ExpArrival = new DateTime(2024, 12, 15, 10, 00, 00),
                        ActArrival = new DateTime(2024, 12, 15, 10, 10, 00), // Example of actual arrival
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 3), 
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 3)
                    },
                    new ScheduledJourney
                    {
                        BusID = 4,
                        RouteID = 4,
                        ExpDeparture = new DateTime(2024, 12, 15, 09, 30, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 09, 35, 00), // Example of actual departure
                        ExpArrival = new DateTime(2024, 12, 15, 10, 30, 00),
                        ActArrival = new DateTime(2024, 12, 15, 10, 40, 00), // Example of actual arrival
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 4), 
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 4)
                    },
                    new ScheduledJourney
                    {
                        BusID = 5,
                        RouteID = 5,
                        ExpDeparture = new DateTime(2024, 12, 15, 10, 00, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 10, 10, 00),
                        ExpArrival = new DateTime(2024, 12, 15, 11, 00, 00),
                        ActArrival = new DateTime(2024, 12, 15, 11, 05, 00),
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 5),
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 5)
                    },
                    new ScheduledJourney
                    {
                        BusID = 6,
                        RouteID = 6,
                        ExpDeparture = new DateTime(2024, 12, 15, 10, 30, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 10, 40, 00),
                        ExpArrival = new DateTime(2024, 12, 15, 11, 30, 00),
                        ActArrival = new DateTime(2024, 12, 15, 11, 45, 00),
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 6),
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 6)
                    },
                    new ScheduledJourney
                    {
                        BusID = 7,
                        RouteID = 7,
                        ExpDeparture = new DateTime(2024, 12, 15, 11, 00, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 11, 05, 00),
                        ExpArrival = new DateTime(2024, 12, 15, 12, 00, 00),
                        ActArrival = new DateTime(2024, 12, 15, 12, 10, 00),
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 7),
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 7)
                    },
                    new ScheduledJourney
                    {
                        BusID = 8,
                        RouteID = 8,
                        ExpDeparture = new DateTime(2024, 12, 15, 11, 30, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 11, 35, 00),
                        ExpArrival = new DateTime(2024, 12, 15, 12, 30, 00),
                        ActArrival = new DateTime(2024, 12, 15, 12, 40, 00),
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 8),
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 8)
                    },
                    new ScheduledJourney
                    {
                        BusID = 9,
                        RouteID = 9,
                        ExpDeparture = new DateTime(2024, 12, 15, 12, 00, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 12, 10, 00),
                        ExpArrival = new DateTime(2024, 12, 15, 13, 00, 00),
                        ActArrival = new DateTime(2024, 12, 15, 13, 05, 00),
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 9),
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 9)
                    },
                    new ScheduledJourney
                    {
                        BusID = 10,
                        RouteID = 10,
                        ExpDeparture = new DateTime(2024, 12, 15, 12, 30, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 12, 40, 00),
                        ExpArrival = new DateTime(2024, 12, 15, 13, 30, 00),
                        ActArrival = new DateTime(2024, 12, 15, 13, 40, 00),
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 10),
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 10)
                    },
                    new ScheduledJourney
                    {
                        BusID = 11,
                        RouteID = 11,
                        ExpDeparture = new DateTime(2024, 12, 15, 13, 00, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 13, 05, 00),
                        ExpArrival = new DateTime(2024, 12, 15, 14, 00, 00),
                        ActArrival = new DateTime(2024, 12, 15, 14, 10, 00),
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 11),
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 11)
                    },
                    new ScheduledJourney
                    {
                        BusID = 12,
                        RouteID = 12,
                        ExpDeparture = new DateTime(2024, 12, 15, 13, 30, 00),
                        ActDeparture = new DateTime(2024, 12, 15, 13, 40, 00),
                        ExpArrival = new DateTime(2024, 12, 15, 14, 30, 00),
                        ActArrival = new DateTime(2024, 12, 15, 14, 50, 00),
                        Bus = context.Buses.FirstOrDefault(b => b.BusID == 12),
                        BusRoute = context.Routes.FirstOrDefault(r => r.RouteID == 12)
                    }
                };

                context.ScheduledJourneys.AddRange(scheduledJourneys);
                context.SaveChanges();
            }
        }
        public void SeedBuses(AppDbContext context)
        {
            if (!context.Buses.Any())
            {
            var buses = new List<Bus>
            {
                new Bus
                {
                    RegistrationNum = "ABC123",
                    BusType = BusType.Standard,
                    TotalCapacity = 50
                },
                new Bus
                {
                    RegistrationNum = "XYZ456",
                    BusType = BusType.Mini,
                    TotalCapacity = 20
                },
                new Bus
                {
                    RegistrationNum = "DEF789",
                    BusType = BusType.DoubleDecker,
                    TotalCapacity = 80
                },
                new Bus
                {
                    RegistrationNum = "GHI012",
                    BusType = BusType.Standard,
                    TotalCapacity = 55
                },
                new Bus
                {
                    RegistrationNum = "JKL345",
                    BusType = BusType.Mini,
                    TotalCapacity = 25
                },
                new Bus
                {
                    RegistrationNum = "MNO678",
                    BusType = BusType.DoubleDecker,
                    TotalCapacity = 90
                },
                new Bus
                {
                    RegistrationNum = "PQR901",
                    BusType = BusType.Standard,
                    TotalCapacity = 60
                },
                new Bus
                {
                    RegistrationNum = "STU234",
                    BusType = BusType.Mini,
                    TotalCapacity = 18
                },
                new Bus
                {
                    RegistrationNum = "VWX567",
                    BusType = BusType.DoubleDecker,
                    TotalCapacity = 85
                },
                new Bus
                {
                    RegistrationNum = "YZA890",
                    BusType = BusType.Standard,
                    TotalCapacity = 50
                },
                new Bus
                {
                    RegistrationNum = "BCD123",
                    BusType = BusType.Mini,
                    TotalCapacity = 22
                },
                new Bus
                {
                    RegistrationNum = "EFG456",
                    BusType = BusType.DoubleDecker,
                    TotalCapacity = 75
                },
                new Bus
                {
                    RegistrationNum = "HIJ789",
                    BusType = BusType.Standard,
                    TotalCapacity = 55
                },
                new Bus
                {
                    RegistrationNum = "KLM012",
                    BusType = BusType.Mini,
                    TotalCapacity = 30
                },
                new Bus
                {
                    RegistrationNum = "NOP345",
                    BusType = BusType.DoubleDecker,
                    TotalCapacity = 95
                }
            };

            context.Buses.AddRange(buses);
            context.SaveChanges();
        }
        }
    }
}

