/*
 * @Author: live0x
 * @Date: 2020-09-07 09:33:14
 * @Last Modified by:   live0x
 * @Last Modified time: 2020-09-07 09:33:14
 */

namespace devitemapi.Dto.User
{
    public class UserAddOrUpdateDto : BaseDto
    {
        public string Name { get; set; }

        public string Account { get; set; }

        public string Pwd { get; set; }

        public string Address { get; set; }

        public string EMail { get; set; }

        public string Phone { get; set; }

        public int Status { get; set; }
    }
}