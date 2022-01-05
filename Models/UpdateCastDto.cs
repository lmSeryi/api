using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
  public class UpdateCastDto
  {
    [Required, MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(50)]
    public string Character { get; set; }

  }
}
