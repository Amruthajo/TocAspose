using Aspose.Words;
using AsposeWordToc.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace AsposeWordToc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateDocController : ControllerBase
    {       
        private readonly ILogger<CreateDocController> _logger;
        private readonly CreateDocService _createDocService;

        public CreateDocController(ILogger<CreateDocController> logger, CreateDocService createDocService)
        {
            _logger = logger;
            this._createDocService = createDocService;
        }
      /// <summary>
      /// create document
      /// </summary>
        [HttpPost(Name ="CreateDoc")]
        public void CreateDoc()
        {
          this._createDocService.CreateDocument();
        }

       
    }
}