using System.ComponentModel.DataAnnotations;

namespace Shop.Shared;

public record ShopItem
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    public bool IsBuy { get; set; }
    [Range(0, double.MaxValue)]
    public double? Price { get; set; }
    public DateTime ActionTo { get; set; }
    [MaxLength(50)]
    public string? Shop { get; set; }
}