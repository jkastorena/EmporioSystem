using EmporioSystem.DATA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly EmporioDataContext _context;
        public ItemController(EmporioDataContext context)
        {
            _context = context; 
        }

        [HttpGet("GetAllItems")]
        public async Task<IActionResult> GetItems()
        {
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }

        [HttpPost("AddItem")]
        public async Task<IActionResult> AddItem(Item item)
        {
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();
            return Ok(item);
        }

        [HttpPost("AddItemConfig")]
        public async Task<IActionResult> AddItemConfig(ItemConfig itemConfig)
        {
            await _context.ItemConfigs.AddAsync(itemConfig);
            await _context.SaveChangesAsync();
            return Ok(itemConfig);
        }


    }
}
