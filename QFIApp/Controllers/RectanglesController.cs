using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QFIApp.Logic;
using QFIApp.Models;

namespace QFIApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RectanglesController : ControllerBase
    {
        private readonly IRenderRectangleRepository _renderRectangleRepository;

        public RectanglesController(IRenderRectangleRepository renderRectangleRepository)
        {
            _renderRectangleRepository = renderRectangleRepository;
        }

        [HttpPost(Name = "GenerateRectanglesHorizontally")]
        public IActionResult GenerateRectanglesHorizontally(InputDto inputDto)
        {
            if (ModelState.IsValid)
            {
                return Ok(_renderRectangleRepository.GenerateRectanglesHorizontally(inputDto.NumberOfRectangles));
             }
            else
            {
                return BadRequest("The input number of Rectangles can only be between 3 and 20, please enter a valid number");
            }
        }

        [HttpPost(Name = "GenerateRectanglesVertically")]
        public IActionResult GenerateRectanglesVertically(List<RectangleModel> rectangleModels)
        {
            if (ModelState.IsValid)
            {
                return Ok(_renderRectangleRepository.GenerateRectanglesVertically(rectangleModels));
            }
            else
            {
                return BadRequest("The input number of Rectangles can only be between 3 and 20, please enter a valid number");
            }
        }
    }
}
