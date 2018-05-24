using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
  public class Value
  {
    public int id { get; set; }
    
    [MinLength(3)]
    public string value { get; set; }
  }

}