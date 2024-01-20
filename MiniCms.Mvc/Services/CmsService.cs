using Microsoft.EntityFrameworkCore;
using MiniCms.Mvc.Data;
using MiniCms.Mvc.Models;

namespace MiniCms.Mvc.Services;

public class CmsService : IAsyncCmsService
{
    private readonly CmsContext _context;

    public CmsService(CmsContext context)
    {
        _context = context;
    }

    public async Task<OrderViewModel> OrderAsync(OrderViewModel orderViewModel)
    {
        var order = new OrderViewModel
        {
            Id = Guid.NewGuid(),
            Name = orderViewModel.Name,
            Surname = orderViewModel.Surname,
            Phone = orderViewModel.Phone,
            Address = orderViewModel.Address,
            Order = orderViewModel.Order,
            Count = orderViewModel.Count,
            Notes = orderViewModel.Notes,
            IsDelivered = false
        };

        await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();

        return order;
    }

    public async Task<List<OrderViewModel>> GetOrdersAsync()
    {
        return (await _context.Orders.ToListAsync())!;
    }

    public async Task<OrderViewModel> GetOrderByIdAsync(Guid id)
    {
        return (await _context.Orders.FirstOrDefaultAsync(x => x.Id == id))!;
    }

    public async Task UpdateOrderAsync(OrderViewModel orderViewModel)
    {
        _context.Orders.Update(orderViewModel);
        await _context.SaveChangesAsync();
    }
}