using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Entities
{
  public class Movie
  {
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string Name { get; set; }
    [Required, MaxLength(400)]
    public string Description { get; set; }
    public ICollection<Cast> Cast { get; set; } = new List<Cast>();
  }
}