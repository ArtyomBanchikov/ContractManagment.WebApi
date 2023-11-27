using AutoMapper;
using ContractManagment.BLL.Models;
using ContractManagment.BLL.Models.ClientDigital;
using ContractManagment.BLL.Models.ClientInternet;
using ContractManagment.BLL.Models.Post;
using ContractManagment.BLL.Models.Record;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Entities.Post;
using ContractManagment.DAL.Entities.Record;

namespace ContractManagment.BLL.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<KeyEntity, KeyModel>();
            CreateMap<KeyModel, KeyEntity>();

            CreateMap<ContractEntity, ContractModel>();
            CreateMap<ContractModel, ContractEntity>();

            CreateMap<ContractKeyEntity, ContractKeyModel>();
            CreateMap<ContractKeyModel, ContractKeyEntity>();

            CreateMap<PostEntity, PostModel>();
            CreateMap<PostModel, PostEntity>();

            CreateMap<PostMetaEntity, PostMetaModel>();
            CreateMap<PostMetaModel, PostMetaEntity>();

            CreateMap<ClientInternetEntity, ClientInternetModel>();
            CreateMap<ClientInternetModel, ClientInternetEntity>();

            CreateMap<ClientInternetAddParamEntity, ClientInternetAddParamModel>();
            CreateMap<ClientInternetAddParamModel, ClientInternetAddParamEntity>();

            CreateMap<InternetAddParamEntity, InternetAddParamModel>();
            CreateMap<InternetAddParamModel, InternetAddParamEntity>();

            CreateMap<ClientDigitalEntity, ClientDigitalModel>();
            CreateMap<ClientDigitalModel, ClientDigitalEntity>();

            CreateMap<ClientDigitalAddParamEntity, ClientDigitalAddParamModel>();
            CreateMap<ClientDigitalAddParamModel, ClientDigitalAddParamEntity>();

            CreateMap<DigitalAddParamEntity, DigitalAddParamModel>();
            CreateMap<DigitalAddParamModel, DigitalAddParamEntity>();

            CreateMap<UserEntity, UserModel>();
            CreateMap<UserModel, UserEntity>();

            CreateMap<RecordModel, RecordEntity>();
            CreateMap<RecordEntity, RecordModel>();
            
            CreateMap<RecordKeyModel, RecordKeyEntity>();
            CreateMap<RecordKeyEntity, RecordKeyModel>();
        }
    }
}
