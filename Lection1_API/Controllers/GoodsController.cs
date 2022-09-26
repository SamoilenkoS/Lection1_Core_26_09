using Lection1_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lection1_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoodsController : ControllerBase
    {
        private readonly IGoodsService _goodsService;
        private static List<Good> _goods;

        static GoodsController()
        {
            _goods = new List<Good>()
            {
                new Good
                {
                    Id = Guid.NewGuid(),
                    Title = "First good",
                    Price = 100.5
                }
            };
        }

        public GoodsController(IGoodsService goodsService)
        {
            _goodsService = goodsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _goodsService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var good = _goods.Find(x => x.Id == id);
            if(good != null)
            {
                return Ok(good);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Create(Good good)
        {
            good.Id = Guid.NewGuid();
            _goods.Add(good);

            return Created(good.Id.ToString(), good);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Good good)
        {
            good.Id = id;
            int index = _goods.FindIndex(x => x.Id == id);
            if (index >= 0)
            {
                _goods[index] = good;

                return Ok(good);
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            int index = _goods.FindIndex(x => x.Id == id);
            if (index >= 0)
            {
                _goods.RemoveAt(index);

                return NoContent();
            }

            return NotFound();
        }
    }
}
