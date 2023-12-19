using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DietProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {

        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values = _foodService.GetList();
            return Ok(values);
        }
        [HttpGet("getFoodWithType/{type}")]
        public IActionResult getFoodWithType(string type)
        {
            var values = _foodService.getFoodWithType(type);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddFood(Food food)
        {
            _foodService.Add(food);
            return Ok();
        }
       
        [HttpDelete("{id}")]
        public IActionResult DeleteFood(int id)
        {
            var value = _foodService.GetById(id);
            _foodService.Delete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFood(Food food)
        {
            _foodService.Update(food);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _foodService.GetById(id);
            return Ok(value);
        }
    }
}

