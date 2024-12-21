using AutoMapper;
using BookStoreAPI.DTOs.OrdersDTOs;
using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        UnitOfWork.UnitOfWork Unit;
        IMapper mapper;
        public OrderController(UnitOfWork.UnitOfWork unit, IMapper mapper) {
            this.Unit = unit;
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddOrder(AddOrderDTO orderDTO)
        {


            Order order = new Order()
            {
                CustomerId = orderDTO.CustomerId,
                OrderDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                Status = "create"

            };
            Unit.orderRepository.Add(order);
            decimal tp = 0;
            foreach(var item in orderDTO.Books)
            {
                Book b= Unit.bookRepository.GetById(item.BookId);
                tp = tp + (b.Price * item.Quntity);
                OrderItems d = new OrderItems()
                {
                    OrderId = order.Id,
                    BookId = item.BookId,
                    Quntity = item.Quntity,
                    UnitPrice = b.Price
                };
                if (b.Stock > d.Quntity)
                {
                    order.OrderItems.Add(d);
                    b.Stock -= item.Quntity;
                    Unit.bookRepository.Update(b);
                }
                else
                    return BadRequest("Invalid Quntity");
            }
            order.TotalPrice = tp;
            Unit.orderRepository.Save();



            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var order =Unit.orderRepository.GetById(id);
            if(order == null)
                return NotFound($"No Order With This ID{id}");

            var dto = mapper.Map<DisplayOrderDTO>(order);
            return Ok(dto);
        }

        [HttpPut("{id}")]
        public IActionResult EditOrder(int id, EditOrderDTO editOrderDTO)
        {
            var order = Unit.orderRepository.GetById(id);
            if (order == null)
                return NotFound($"No Order With This ID {id}");

            foreach (var item in order.OrderItems)
            {
                var book = Unit.bookRepository.GetById(item.BookId);
                book.Stock += item.Quntity;
            }

            order.OrderItems.Clear();
            decimal nTPrice = 0;

            foreach (var item in editOrderDTO.Books)
            {
                var book = Unit.bookRepository.GetById(item.BookId);
                if (book.Stock < item.Quntity)
                    return BadRequest("Invalid Quntity For This Book");

                var orderitem = mapper.Map<OrderItems>(item);
                orderitem.UnitPrice = book.Price;

                nTPrice += book.Price * orderitem.Quntity;
                book.Stock -= item.Quntity;
                Unit.bookRepository.Update(book);
                order.OrderItems.Add(orderitem);
            }

            order.Status = editOrderDTO.Status;
            order.TotalPrice = nTPrice;
            Unit.orderRepository.Update(order);
            Unit.orderRepository.Save();
            return NoContent();
        }



        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var order = Unit.orderRepository.GetById(id);
            if (order == null)
                return NotFound($"No Order with ID {id}.");

            foreach (var item in order.OrderItems)
            {
                var book = Unit.bookRepository.GetById(item.BookId);
                if (book != null)
                {
                    book.Stock += item.Quntity;
                    Unit.bookRepository.Update(book);
                }
            }

            Unit.orderRepository.Delete(order.Id);
            Unit.orderRepository.Save();
            return NoContent();
        }
    
    
    }

}
