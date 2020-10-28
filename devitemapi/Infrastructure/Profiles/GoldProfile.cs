/*
 * @Author: live0x 
 * @Date: 2020-10-28 10:22:42 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-10-28 10:22:42 
 */
using AutoMapper;
using devitemapi.Dto.Wbl;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Profiles
{
    public class GoldProfile:Profile
    {
        public GoldProfile()
        {
            CreateMap<WblGoldDto,Gold>()
                .ForMember(des => des.ConsignmentId,opt => opt.MapFrom(src => src.consignment_id))
                .ForMember(des => des.ZoneId,opt => opt.MapFrom(src => src.zone_id))
                .ForMember(des => des.ServerId,opt => opt.MapFrom(src => src.server_id))
                .ForMember(des => des.Remark,opt => opt.MapFrom(src => src.info))
                .ForMember(des => des.TotalPrice,opt => opt.MapFrom(src => src.single_unit_price))
                .ForMember(des => des.UnitPrice,opt => opt.MapFrom(src => src.single_count_price))
                .ForMember(des => des.GoldAmount,opt => opt.MapFrom(src => src.single_unit_size))
                .ForMember(des => des.SellerRoleName,opt => opt.MapFrom(src => src.seller_role_name));
        }
    }
}