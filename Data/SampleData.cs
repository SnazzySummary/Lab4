using Lab4.Models;

namespace Lab4.Data;
public class SampleData {

    static List<Province> provinces = new List<Province>() {
         new Province() {
             ProvinceCode="BC",
             ProvinceName="British Columbia",
         },
         new Province() {
             ProvinceCode="AB",
             ProvinceName="Alberta",
         },
         new Province() {
             ProvinceCode="ON",
             ProvinceName="Ontatrio",
         },
    };

    static List<City> cities = new List<City>() {
         new City {
             CityId = 1,
             CityName = "Vancouver",
             Population = 10000000,
             ProvinceCode = "BC",
         },
         new City {
             CityId = 2,
             CityName = "Mission",
             Population = 50000,
             ProvinceCode = "BC",
         },
         new City {
             CityId = 3,
             CityName = "Maple Ridge",
             Population = 80000,
             ProvinceCode = "BC",
         },
         new City {
             CityId = 4,
             CityName = "Calgary",
             Population = 10000000,
             ProvinceCode = "AB",
         },
         new City {
             CityId = 5,
             CityName = "Drumheller",
             Population = 40000,
             ProvinceCode = "AB",
         },
         new City {
             CityId = 6,
             CityName = "Edmondton",
             Population = 1000000,
             ProvinceCode = "AB",
         },
         new City {
             CityId = 7,
             CityName = "Toronto",
             Population = 1000000,
             ProvinceCode = "ON",
         },
         new City {
             CityId = 8,
             CityName = "Mississauga",
             Population = 2001511,
             ProvinceCode = "ON",
         },
         new City {
             CityId = 9,
             CityName = "Hamilton",
             Population = 150000,
             ProvinceCode = "ON",
         },
    };

  public static List<Province> GetProvinces() {
      return provinces;
  }

  public static List<City> GetCities() {
      return cities;
  }

}