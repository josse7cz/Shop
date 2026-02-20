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

    [HttpPost]
    public async Task<ActionResult<ShopItem>> Create([FromBody] ShopItem item)
    {
        await context.ShopItems.AddAsync(item);
        await context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<ShopItem>> Update(int id, [FromBody] ShopItem item)
    {
        var updatedItem = await context.ShopItems.FirstOrDefaultAsync(i => i.Id == id);
        if (updatedItem is null) return NotFound();
        updatedItem.Name = item.Name;
        updatedItem.IsBuy = item.IsBuy;
        updatedItem.Price = item.Price;
        updatedItem.ActionTo = item.ActionTo;
        updatedItem.Shop = item.Shop;
        await context.SaveChangesAsync();
        return Ok(updatedItem);
    }
    
    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deletedItem = await context.ShopItems.FindAsync(id);
        if (deletedItem is null) return NotFound();
        context.ShopItems.Remove(deletedItem);
        await context.SaveChangesAsync();
        return NoContent();
    }
}