using System;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DietProject.API.Controllers
{
    [ApiController]
	[Route("api/[controller]")]
    public class MealController : ControllerBase
	{
		private readonly IMealService _mealService;

        public MealController(IMealService mealService)
        {
            _mealService = mealService;
        }
        [HttpGet]
        public IActionResult GetMealList()
        {
            var values = _mealService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMeal(Meal meal)
        {
            _mealService.Add(meal);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMeal(Meal meal)
        {
            _mealService.Update(meal);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMeal(int id)
        {
            var value = _mealService.GetById(id);
            _mealService.Delete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _mealService.GetById(id);
            return Ok(value);
        }
    }
}

