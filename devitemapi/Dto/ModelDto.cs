using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Dto
{
    public class ModelDto
    {
        public string ImgName { get; set; }

        public IFormFile  Img { get; set; }
    }
}
