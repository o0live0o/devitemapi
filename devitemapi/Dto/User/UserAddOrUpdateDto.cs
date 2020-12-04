/*
 * @Author: live0x
 * @Date: 2020-09-07 09:33:14
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-21 15:11:44
 */

namespace devitemapi.Dto.User
{
    public class UserAddOrUpdateDto : OperatorDto
    {
        public string Name { get; set; }

        public string Account { get; set; }

        public string Address { get; set; }

        public string EMail { get; set; }

        public string Phone { get; set; }

        public int Age { get; set; }

        public int Sex { get; set; }

        public int Status { get; set; }
    }
}