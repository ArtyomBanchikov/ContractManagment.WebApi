using AutoMapper;
using ContractManagment.BLL.Models;
using ContractManagment.BLL.Models.Client;
using ContractManagment.BLL.Models.Post;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Entities.Client;
using ContractManagment.DAL.Entities.Post;

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

            CreateMap<ClientEntity, ClientModel>();
            CreateMap<ClientModel, ClientEntity>();

            CreateMap<ClientAddParamEntity, ClientAddParamModel>();
            CreateMap<ClientAddParamModel, ClientAddParamEntity>();

            CreateMap<AdditionalParameterEntity, AdditionalParameterModel>();
            CreateMap<AdditionalParameterModel, AdditionalParameterEntity>();

            CreateMap<UserEntity, UserModel>();
            CreateMap<UserModel, UserEntity>();
        }
    }
}
