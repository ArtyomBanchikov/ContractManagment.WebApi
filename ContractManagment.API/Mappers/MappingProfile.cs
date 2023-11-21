using AutoMapper;
using ContractManagment.API.ViewModel;
using ContractManagment.API.ViewModel.Client;
using ContractManagment.API.ViewModel.PostViewModels;
using ContractManagment.API.ViewModel.Record;
using ContractManagment.API.ViewModel.User;
using ContractManagment.BLL.Models;
using ContractManagment.BLL.Models.Client;
using ContractManagment.BLL.Models.Post;
using ContractManagment.BLL.Models.Record;

namespace ContractManagment.API.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PostViewModel, PostModel>();
            CreateMap<PostModel, PostViewModel>();

            CreateMap<PostMetaViewModel, PostMetaModel>();
            CreateMap<PostMetaModel, PostMetaViewModel>();

            CreateMap<KeyViewModel, KeyModel>();
            CreateMap<KeyModel, KeyViewModel>();

            CreateMap<ContractViewModel, ContractModel>();
            CreateMap<ContractModel, ContractViewModel>();

            CreateMap<ContractKeyModel, ContractKeyViewModel>();
            CreateMap<ContractKeyViewModel, ContractKeyModel>();

            CreateMap<RecordViewModel, RecordModel>();
            CreateMap<RecordModel, RecordViewModel>();

            CreateMap<RecordKeyViewModel, RecordKeyModel>();
            CreateMap<RecordKeyModel, RecordKeyViewModel>();

            CreateMap<ClientModel, ClientViewModel>();
            CreateMap<ClientViewModel, ClientModel>();

            CreateMap<AdditionalParameterModel, AdditionalParameterViewModel>();
            CreateMap<AdditionalParameterViewModel, AdditionalParameterModel>();

            CreateMap<ClientAddParamModel, ClientAddParamViewModel>()
                .ForMember(x => x.ClientId, o => o.MapFrom(p => p.userid))
                .ForMember(x => x.ParamId, o => o.MapFrom(p => p.paramid));
            CreateMap<ClientAddParamViewModel, ClientAddParamModel>()
                .ForMember(x => x.userid, o => o.MapFrom(p => p.ClientId))
                .ForMember(x => x.paramid, o => o.MapFrom(p => p.ParamId));

            CreateMap<UserModel, UserViewModel>();
            CreateMap<UserViewModel, UserModel>();

            CreateMap<LoginUserViewModel, UserViewModel>();
            CreateMap<UserViewModel, LoginUserViewModel>();

            CreateMap<LoginUserViewModel, ShortUserViewModel>();
            CreateMap<ShortUserViewModel, LoginUserViewModel>();

            CreateMap<UserViewModel, ShortUserViewModel>();
            CreateMap<ShortUserViewModel, UserViewModel>();
        }
    }
}
