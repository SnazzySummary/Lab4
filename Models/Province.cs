using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
namespace Lab4.Models;
public class Province {
    [Key]
    public string? ProvinceCode { get; set; }
    public string? ProvinceName { get; set; }
    public List<City>? Cities { get; set; }
}