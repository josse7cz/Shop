using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Microsoft.EntityFrameworkCore;
using Shop.Shared;

namespace Shop.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController(ApplicationDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<ShopItem>>> GetAll()
    {
        var items = await context.ShopItems.AsNoTracking().ToListAsync();
        return Ok(items);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ShopItem>> GetById(int id)
    {
        var item = await context.ShopItems.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
        return item is null ? NotFound() : Ok(item);
    }

    // [HttpPost]
    // public async Task<IActionResult> AddItem(Shop.Shared.ShopItem item)
    // {
    //     context.ShopItems.Add(item);
    //     await context.SaveChangesAsync();
    //     return CreatedAtAction(nameof(GetItems), new { id = item.Id }, item);
    // }
}