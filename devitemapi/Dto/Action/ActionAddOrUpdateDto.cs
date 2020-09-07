/*
 * @Author: live0x
 * @Date: 2020-09-07 09:33:47
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-07 09:34:11
 */

namespace devitemapi.Dto.Action
{
    public class ActionAddOrUpdateDto : BaseDto
    {
        public string ActionName { get; set; }

        public string ActionCode { get; set; }
    }
}