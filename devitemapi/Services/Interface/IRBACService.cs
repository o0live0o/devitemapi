/*
 * @Author: live0x 
 * @Date: 2020-09-08 17:47:17 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-09-08 17:47:17 
 */
using System;
using System.Threading.Tasks;
using devitemapi.Dto;

namespace devitemapi.Services.Interface
{
    public interface IRbacService
    {
        Task<TreeDto> GetMenuTreeByUser(Guid userId);
    }
}