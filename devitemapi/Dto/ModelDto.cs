/*
 * @Author: live0x
 * @Date: 2020-09-03 14:55:48
 * @Last Modified by:   live0x
 * @Last Modified time: 2020-09-03 14:55:48
 */

using Microsoft.AspNetCore.Http;

namespace devitemapi.Dto
{
    public class ModelDto
    {
        public string ImgName { get; set; }

        public IFormFile Img { get; set; }
    }
}