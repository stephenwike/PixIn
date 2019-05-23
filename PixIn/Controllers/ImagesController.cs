using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace PixIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        // GET api/images/folder
        [HttpGet("{folder}")]
        public ActionResult<Dictionary<string, byte[]>> Get(string folder)
        {
            string path = Path.Combine(DataRepository.Config.RootDirectory, folder);
            List<FileInfo> fInfo = Utilities.FileSearch(path);

            Dictionary<string, byte[]> imgs = new Dictionary<string, byte[]>();
            foreach (FileInfo file in fInfo)
            {
                imgs.Add(file.Name, Utilities.ConvertFileToBytes(file.OpenRead()));
            }

            return imgs;
        }
    }
}
