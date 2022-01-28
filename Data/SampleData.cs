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
    };

    static List<City> cities = new List<City>() {
         new City {
             CityId = 1,
             CityName = "Vancouver",
             Population = 10000000,
             Province = "BC",
         },
         new City {
             CityId = 2,
             CityName = "Calgary",
             Population = 10000000,
             Province = "AB",
         },
    };

  public static List<Province> GetProvinces() {
      return provinces;
  }

  public static List<City> GetCities() {
      return cities;
  }

}