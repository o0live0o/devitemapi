/*
 * @Author: live0x 
 * @Date: 2020-09-03 14:55:48 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-09-03 14:55:48 
 */
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
