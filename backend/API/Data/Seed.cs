using System.Globalization;
using API.Models;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedData(AppDbContext context)
        {
            if (!context.Cars.Any())
            {
                Console.WriteLine("seeding...");
                var countries = new List<CountryModel>
                {
                    new CountryModel
                    {
                        Id = 1,
                        Name = "UNITED STATES (USA)"
                    },
                    new CountryModel
                    {
                        Id = 2,
                        Name = "CANADA"
                    },
                    new CountryModel
                    {
                        Id = 3,
                        Name = "UNITED KINGDOM (UK)"
                    },
                    new CountryModel
                    {
                        Id = 4,
                        Name = "MEXICO"
                    },
                    new CountryModel
                    {
                        Id = 5,
                        Name = "BELGIUM"
                    },
                    new CountryModel
                    {
                        Id = 6,
                        Name = "CHINA"
                    },
                    new CountryModel
                    {
                        Id = 7,
                        Name = "JAPAN"
                    },
                    new CountryModel
                    {
                        Id = 8,
                        Name = "SPAIN"
                    },
                    new CountryModel
                    {
                        Id = 9,
                        Name = "HONG KONG"
                    }
                };
                
                var cars = new List<CarModel>
                {
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-03-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 987,
                        Name = "HONDA MOTOR CO., LTD",
                        UpdatedOn = DateTime.ParseExact("2015-06-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Passenger Car",
                        WMI = "JHM"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 988,
                        Name = "HONDA OF AMERICA MFG., INC.",
                        UpdatedOn = null,
                        VehicleType = "Passenger Car",
                        WMI = "1HG"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 989,
                        Name = "HONDA MFG., ALABAMA., LLC.",
                        UpdatedOn = null,
                        VehicleType = "Passenger Car",
                        WMI = "5KB"
                    },
                    new CarModel
                    {
                        CountryId = countries[1].Id,
                        Country = countries[1],
                        CreatedOn = DateTime.ParseExact("2015-03-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 990,
                        Name = "HONDA OF CANADA MFG., INC.",
                        UpdatedOn = null,
                        VehicleType = "Passenger Car",
                        WMI = "2HG"
                    },
                    new CarModel
                    {
                        CountryId = countries[2].Id,
                        Country = countries[2],
                        CreatedOn = DateTime.ParseExact("2015-03-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 991,
                        Name = "HONDA OF THE U.K. MFG., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Passenger Car",
                        WMI = "SHH"
                    },
                    new CarModel
                    {
                        CountryId = countries[3].Id,
                        Country = countries[3],
                        CreatedOn = DateTime.ParseExact("2015-03-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 992,
                        Name = "HONDA DE MEXICO",
                        UpdatedOn = null,
                        VehicleType = "Passenger Car",
                        WMI = "3HG"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-03-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 993,
                        Name = "HONDA MFG., INDIANA., LLC.",
                        UpdatedOn = null,
                        VehicleType = "Passenger Car",
                        WMI = "19X"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 987,
                        Name = "HONDA MOTOR CO., LTD",
                        UpdatedOn = null,
                        VehicleType = "Passenger Car",
                        WMI = "JH4"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 987,
                        Name = "HONDA MOTOR CO., LTD",
                        UpdatedOn = null,
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "JHL"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 987,
                        Name = "HONDA MOTOR CO., LTD",
                        UpdatedOn = null,
                        VehicleType = "Truck ",
                        WMI = "JH1"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 988,
                        Name = "HONDA OF AMERICA MFG., INC.",
                        UpdatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Passenger Car",
                        WMI = "19U"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 988,
                        Name = "HONDA OF AMERICA MFG., INC.",
                        UpdatedOn = null,
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "5J6"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 988,
                        Name = "HONDA OF AMERICA MFG., INC.",
                        UpdatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "5J8"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 988,
                        Name = "HONDA OF AMERICA MFG., INC.",
                        UpdatedOn = null,
                        VehicleType = "Truck ",
                        WMI = "5J7"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 988,
                        Name = "HONDA OF AMERICA MFG., INC.",
                        UpdatedOn = null,
                        VehicleType = "Truck ",
                        WMI = "5J0"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 989,
                        Name = "HONDA MFG., ALABAMA., LLC.",
                        UpdatedOn = null,
                        VehicleType = "Passenger Car",
                        WMI = "5KC"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 989,
                        Name = "HONDA MFG., ALABAMA., LLC.",
                        UpdatedOn = null,
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "5FN"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 989,
                        Name = "HONDA MFG., ALABAMA., LLC.",
                        UpdatedOn = null,
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "5FR"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 989,
                        Name = "HONDA MFG., ALABAMA., LLC.",
                        UpdatedOn = null,
                        VehicleType = "Truck ",
                        WMI = "5FP"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 989,
                        Name = "HONDA MFG., ALABAMA., LLC.",
                        UpdatedOn = null,
                        VehicleType = "Truck ",
                        WMI = "5FS"
                    },
                    new CarModel
                    {
                        CountryId = countries[1].Id,
                        Country = countries[1],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 990,
                        Name = "HONDA OF CANADA MFG., INC.",
                        UpdatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Passenger Car",
                        WMI = "2HH"
                    },
                    new CarModel
                    {
                        CountryId = countries[1].Id,
                        Country = countries[1],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 990,
                        Name = "HONDA OF CANADA MFG., INC.",
                        UpdatedOn = null,
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "2HK"
                    },
                    new CarModel
                    {
                        CountryId = countries[1].Id,
                        Country = countries[1],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 990,
                        Name = "HONDA OF CANADA MFG., INC.",
                        UpdatedOn = null,
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "2HN"
                    },
                    new CarModel
                    {
                        CountryId = countries[1].Id,
                        Country = countries[1],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 990,
                        Name = "HONDA OF CANADA MFG., INC.",
                        UpdatedOn = null,
                        VehicleType = "Truck ",
                        WMI = "2HJ"
                    },
                    new CarModel
                    {
                        CountryId = countries[1].Id,
                        Country = countries[1],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 990,
                        Name = "HONDA OF CANADA MFG., INC.",
                        UpdatedOn = null,
                        VehicleType = "Truck ",
                        WMI = "2HU"
                    },
                    new CarModel
                    {
                        CountryId = countries[2].Id,
                        Country = countries[2],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 991,
                        Name = "HONDA OF THE U.K. MFG., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "SHS"
                    },
                    new CarModel
                    {
                        CountryId = countries[3].Id,
                        Country = countries[3],
                        CreatedOn = DateTime.ParseExact("2015-03-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 992,
                        Name = "HONDA DE MEXICO",
                        UpdatedOn = null,
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "3CZ"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-04-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1154,
                        Name = "AMERICAN HONDA MOTOR CO., INC.",
                        UpdatedOn = DateTime.ParseExact("2015-06-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "JH2"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-04-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1154,
                        Name = "AMERICAN HONDA MOTOR CO., INC.",
                        UpdatedOn = DateTime.ParseExact("2015-06-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "1HF"
                    },
                    new CarModel
                    {
                        CountryId = countries[4].Id,
                        Country = countries[4],
                        CreatedOn = DateTime.ParseExact("2015-04-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 988,
                        Name = "HONDA OF AMERICA MFG., INC.",
                        UpdatedOn = DateTime.ParseExact("2016-07-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "YC1"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-04-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1154,
                        Name = "AMERICAN HONDA MOTOR CO., INC.",
                        UpdatedOn = DateTime.ParseExact("2015-06-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "3H1"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-04-21", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 993,
                        Name = "HONDA MFG., INDIANA., LLC.",
                        UpdatedOn = null,
                        VehicleType = "Passenger Car",
                        WMI = "19V"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-06-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1154,
                        Name = "AMERICAN HONDA MOTOR CO., INC.",
                        UpdatedOn = DateTime.ParseExact("2016-06-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "ZDC"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-06-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1154,
                        Name = "AMERICAN HONDA MOTOR CO., INC.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "MLH"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-06-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 14790,
                        Name = "SUNDIRO HONDA MOTORCYCLE CO., LTD.",
                        UpdatedOn = DateTime.ParseExact("2017-08-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "LAL"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-06-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1154,
                        Name = "AMERICAN HONDA MOTOR CO., INC.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "RLH"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-06-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1154,
                        Name = "AMERICAN HONDA MOTOR CO., INC.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "VTM"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-06-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1154,
                        Name = "AMERICAN HONDA MOTOR CO., INC.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LWB"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 12142,
                        Name = "CHONGQING GUANGYU MOTORCYCLE MANUFACTURE CO., LTD.",
                        UpdatedOn = DateTime.ParseExact("2019-11-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "LRY"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 11163,
                        Name = "CHONGQING HI-BIRD MOTORCYCLE INDUSTRY CO., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LSR"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 12294,
                        Name = "CHONGQING KAIER MOTORCYCLE MANUFACTURING CO.,",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LYE"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 10479,
                        Name = "CHONGQING KINLON MOTORCYCLE MANUFACTURE CO., LTD",
                        UpdatedOn = DateTime.ParseExact("2015-07-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "LLC"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 11366,
                        Name = "CHONGQING HUANSONG INDUSTRIES (GROUP) CO., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LWG"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1471,
                        Name = "CHONGQING RATO POWER CO., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LRP"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 6877,
                        Name = "CHONGQING YINXIANG MOTORCYCLE (GROUP) CO., LTD.",
                        UpdatedOn = DateTime.ParseExact("2015-09-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "LB4"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-07-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1154,
                        Name = "AMERICAN HONDA MOTOR CO., INC.",
                        UpdatedOn = null,
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "JR2"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-16", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 10754,
                        Name = "WUXI JINHONG MOTORCYCLE CO., LTD",
                        UpdatedOn = DateTime.ParseExact("2017-08-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "LC3"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-07-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 6460,
                        Name = "JOYHON, INC.",
                        UpdatedOn = null,
                        VehicleType = "Trailer",
                        WMI = "1J9390"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 6108,
                        Name = "CHANGZHOU ZHONGMAO MACHINERY CO., LTD",
                        UpdatedOn = null,
                        VehicleType = "Trailer",
                        WMI = "L0H"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-21", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 12293,
                        Name = "CHONGQING ASTRONAUTIC BASHAN MOTORCYCLE MANUFACTURING CO., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LHJ"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-07-23", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 11400,
                        Name = "MARATHON METALWORKS",
                        UpdatedOn = null,
                        VehicleType = "Trailer",
                        WMI = "1M9822"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-07-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-07-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 11152,
                        Name = "CHONGQING HENSIM GROUP CO., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LUA"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-08-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-08-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 13493,
                        Name = "JIANGMEN SINO-HONGKONG BAOTIAN MOTORCYCLE INDUSTRIAL CO., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "L82"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-08-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-08-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 7575,
                        Name = "SHANDONG ZHONGTONG FEIYAN AUTOMOBILE CO. LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "L69FYK"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-08-10", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-08-10", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 9274,
                        Name = "TAIZHOU ZHONGNENG MOTORCYCLE CO., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "L5Y"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-08-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-08-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1327,
                        Name = "SHANGHAI HUIZHONG AUTOMOTIVE MANUFACTURING CO., LTD",
                        UpdatedOn = null,
                        VehicleType = "Trailer",
                        WMI = "LSB"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-08-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-08-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 8915,
                        Name = "SHANGHAI HONLING MOTORCYCLE MANUFACTURE CO., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LLA"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-08-31", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-08-31", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 18814,
                        Name = "CHONGQING ANDES MOTORCYCLE MANUFACTURING CO.,LTD.",
                        UpdatedOn = DateTime.ParseExact("2020-05-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "LKX"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-09-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-09-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 10038,
                        Name = "CHONGQING SHUANGQING MECHANICAL & ELECTRICAL CO.",
                        UpdatedOn = DateTime.ParseExact("2016-06-24", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "LZX"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-09-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-09-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 9554,
                        Name = "CHONGQUING DAJIANG MOTORCYCLES CO., LTD",
                        UpdatedOn = DateTime.ParseExact("2019-11-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "L1P"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2015-09-16", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-09-16", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1695,
                        Name = "MARATHON HOMES CORPORATION",
                        UpdatedOn = null,
                        VehicleType = "Trailer",
                        WMI = "1M9019"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-11-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-11-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 7363,
                        Name = "Xinri E-Vehicle Hongkong Co., Limited",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "R12"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2015-12-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2015-12-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 14236,
                        Name = "CHONGQING SHINERAY MOTORCYCLE CO., LTD.",
                        UpdatedOn = DateTime.ParseExact("2018-08-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "LXY"
                    },
                    new CarModel
                    {
                        CountryId = null,
                        Country = null,
                        CreatedOn = DateTime.ParseExact("2015-12-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("1988-12-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1154,
                        Name = "AMERICAN HONDA MOTOR CO., INC.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "9C2"
                    },
                    new CarModel
                    {
                        CountryId = countries[6].Id,
                        Country = countries[6],
                        CreatedOn = DateTime.ParseExact("2016-06-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2016-06-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 987,
                        Name = "HONDA MOTOR CO., LTD",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "JH3"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2016-06-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2016-06-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 993,
                        Name = "HONDA MFG., INDIANA., LLC.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "478"
                    },
                    new CarModel
                    {
                        CountryId = countries[7].Id,
                        Country = countries[7],
                        CreatedOn = DateTime.ParseExact("2016-06-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2016-06-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 15171,
                        Name = "MONTESA HONDA SA",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "VTD"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2016-08-31", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2016-08-31", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 15538,
                        Name = "CHONGQING YINGANG SCIENCE & TECHNOLOGY (GROUP) CO., LTD.",
                        UpdatedOn = DateTime.ParseExact("2016-09-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Motorcycle",
                        WMI = "LY4"
                    },
                    new CarModel
                    {
                        CountryId = countries[8].Id,
                        Country = countries[8],
                        CreatedOn = DateTime.ParseExact("2016-10-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2016-10-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 15739,
                        Name = "RONGCHENG COMPAKS (HONG KONG) NEW ENERGY AUTOMOBILE CO LTD",
                        UpdatedOn = null,
                        VehicleType = "Trailer",
                        WMI = "R1V"
                    },
                    new CarModel
                    {
                        CountryId = countries[1].Id,
                        Country = countries[1],
                        CreatedOn = DateTime.ParseExact("2017-02-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2017-02-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 15238,
                        Name = "MARATHON EQUIPMENT LTD ",
                        UpdatedOn = DateTime.ParseExact("2017-04-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        VehicleType = "Trailer",
                        WMI = "2M9004"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2017-03-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2017-03-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 993,
                        Name = "HONDA MFG., INDIANA., LLC.",
                        UpdatedOn = null,
                        VehicleType = "Multipurpose Passenger Vehicle (MPV)",
                        WMI = "7FA"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2017-05-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2017-05-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 8769,
                        Name = "GRYPHON BIKES & CHOPPERS",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "1G9340"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2017-05-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2017-05-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 9042,
                        Name = "JIANGMEN ZHONGYU MOTOR (GROUP) CO., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LMF"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2017-05-23", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2017-05-23", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 16100,
                        Name = "JHC NEW ENERGY VEHICLE HONGKONG CO.,LTD",
                        UpdatedOn = null,
                        VehicleType = "Low Speed Vehicle (LSV)",
                        WMI = "R1A"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2017-06-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2017-06-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 16653,
                        Name = "NANCHANG AIRCRAFT MFG. CO ( HONGDU MACHINERY PLANT)",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LPP"
                    },
                    new CarModel
                    {
                        CountryId = countries[2].Id,
                        Country = countries[2],
                        CreatedOn = DateTime.ParseExact("2017-11-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2017-11-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 1879,
                        Name = "HONNOR MARINE LTD",
                        UpdatedOn = null,
                        VehicleType = "Trailer",
                        WMI = "SA9112"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2018-01-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2018-01-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 17562,
                        Name = "HONGDU ELECTRIC VEHICLE HONGKONG CO.,LIMITED",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "R2L"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2018-01-25", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2018-01-25", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 9877,
                        Name = "HONGDOU GROUP CHITUMA MOTORCYCLE COMPANY",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LE6"
                    },
                    new CarModel
                    {
                        CountryId = countries[0].Id,
                        Country = countries[0],
                        CreatedOn = DateTime.ParseExact("2018-03-14", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2018-03-14", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 3847,
                        Name = "MARATHON EQUIPMENT COMPANY (DEL)",
                        UpdatedOn = null,
                        VehicleType = "Trailer",
                        WMI = "1M9371"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2018-05-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2018-05-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 17686,
                        Name = "CHONGQING HUANGHE MOTORCYCLE CO.,LTD. ",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LDU"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2018-08-10", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2018-08-10", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 18570,
                        Name = "CHONGQING LIYANG JIAYU MOTORCYCLE CO., LTD.",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "LC4"
                    },
                    new CarModel
                    {
                        CountryId = countries[5].Id,
                        Country = countries[5],
                        CreatedOn = DateTime.ParseExact("2020-08-31", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DateAvailableToPublic = DateTime.ParseExact("2020-08-31", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Id = 20032,
                        Name = "ELYX SMART TECHNOLOGY HOLDINGS (HONGKONG) LIMITED",
                        UpdatedOn = null,
                        VehicleType = "Motorcycle",
                        WMI = "R4N"
                    }
                };

                await context.Cars.AddRangeAsync(cars);
                await context.Countries.AddRangeAsync(countries);
                await context.SaveChangesAsync();
            }
        }
    }
}