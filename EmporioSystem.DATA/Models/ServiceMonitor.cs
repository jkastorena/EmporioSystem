using System.ComponentModel.DataAnnotations;

namespace EmporioSystem.DATA;

public class ServiceMonitor
{
    [Key]
    public int Id { get; set; }
    public string? ComputerName { get; set; } = Environment.MachineName;
    public string? ServiceName { get; set; }
    public string? ServiceDescription { get; set; }
    public string? ServiceStatus { get; set; }
    public string? ServiceType { get; set; }
    public bool IsRunning { get; set; }
    public DateTime LastRun { get; set; }

}
