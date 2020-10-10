using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService) =>
            _imageService = imageService;

        [HttpGet("{id}")]
        public IActionResult ConsultAsync(int id) =>
            Ok(new ImageModel(_imageService.Consult(id)));

        [HttpGet()]
        public IActionResult GetAll() =>
            Ok(_imageService.GetAll().Select(image => new ImageModel(image)));

        [HttpPost]
        public async Task<IActionResult> RegisterAsync([FromBody] ImageModel image) =>
             Ok(await _imageService.RegisterAsync(image.Descripion, image.Length, image.Picture));

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _imageService.Delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] ImageModel image)
        {
            await _imageService.UpdateAsync(
                id,
                image.Descripion,
                image.Length,
                image.Picture
            );
            return Ok();
        }
    }
}