using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmporioSystem.DATA;

public class ItemConfig
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Item")]
    public int ItemId { get; set; }
    public IEnumerable<ConfigValue>? ConfigValues { get; set; }
}

public class ConfigValue
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("ItemConfig")]
    public int ItemConfigId { get; set; }
    public string? Config { get; set; }
    public string? Value { get; set; }
}
