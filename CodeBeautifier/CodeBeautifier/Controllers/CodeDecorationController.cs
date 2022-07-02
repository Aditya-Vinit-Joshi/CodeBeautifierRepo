using CodeBeautifier.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeBeautifier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeDecorationController : ControllerBase
    {

        private readonly IBeautifyCodeRepository _beautify;

        public CodeDecorationController(IBeautifyCodeRepository beautify)
        {
            _beautify = beautify;
        }

        [HttpPost("{id}/{code}")]
        public IActionResult FormatCode([FromRoute] string code, int id)
        {
            var modifiedCode = _beautify.Beautify(code, id);
            return Ok(modifiedCode);
        }
    }
}
