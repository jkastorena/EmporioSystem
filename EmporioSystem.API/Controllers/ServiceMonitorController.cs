using EmporioSystem.DATA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop.Infrastructure;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceMonitorController : ControllerBase
    {
        private readonly EmporioDataContext _context;

        public ServiceMonitorController(EmporioDataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllServicesStatus")]
        public async Task<IActionResult> GetAllServicesStatus()
        {
            var services = await _context.ServiceMonitors.ToListAsync();
            return Ok(services);
        }

        [HttpPost("AddServiceStatus")]
        public async Task<IActionResult> AddServiceStatus(ServiceMonitor serviceMonitor)
        {
            _context.ServiceMonitors.Add(serviceMonitor);
            await _context.SaveChangesAsync();
            return Ok(serviceMonitor);
        }
    }
}
