using Microsoft.AspNetCore.Mvc;
using MiniCms.Mvc.Models;
using MiniCms.Mvc.Services;

namespace MiniCms.Mvc.Controllers;

public class OrderController : Controller
{
    private readonly IAsyncCmsService _service;

    public OrderController(IAsyncCmsService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var orders = await _service.GetOrdersAsync();
        return View(orders);
    }


    [HttpPost]
    public async Task<IActionResult> Update(OrderViewModel orderViewModel)
    {
        await _service.UpdateOrderAsync(orderViewModel);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(OrderViewModel orderViewModel)
    {
        var order = await _service.OrderAsync(orderViewModel);
        return View(order);
    }

    [HttpGet]
    public async Task<IActionResult> CreateOrder()
    {
        return await Task.FromResult<IActionResult>(View());
    }
}