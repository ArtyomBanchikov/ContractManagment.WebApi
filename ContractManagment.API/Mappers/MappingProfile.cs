using AutoMapper;
using ContractManagment.API.Converters;
using ContractManagment.API.ViewModel;
using ContractManagment.API.ViewModel.ClientDigital;
using ContractManagment.API.ViewModel.ClientInternet;
using ContractManagment.API.ViewModel.ClientIPTV;
using ContractManagment.API.ViewModel.PostViewModels;
using ContractManagment.API.ViewModel.Record;
using ContractManagment.API.ViewModel.User;
using ContractManagment.BLL.Models;
using ContractManagment.BLL.Models.ClientDigital;
using ContractManagment.BLL.Models.ClientInternet;
using ContractManagment.BLL.Models.ClientIPTV;
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
            CreateMap<PostViewModel, LongRecordViewModel>()
                .ConvertUsing<PostToLongRecordConverter>();

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
            CreateMap<RecordViewModel, LongRecordViewModel>()
                .ConvertUsing<RecordToLongRecordConverter>();

            CreateMap<RecordKeyViewModel, RecordKeyModel>();
            CreateMap<RecordKeyModel, RecordKeyViewModel>();

            CreateMap<AccountTariffInternetModel, AccountTariffInternetViewModel>();
            CreateMap<AccountTariffInternetViewModel, AccountTariffInternetModel>();

            CreateMap<TariffInternetViewModel, TariffInternetModel>();
            CreateMap<TariffInternetModel, TariffInternetViewModel>();

            CreateMap<ClientInternetModel, ClientInternetViewModel>()
                .ForMember(x => x.ConnectDate, o => o.ConvertUsing<TimestampToDateTimeConverter, int>());
            CreateMap<ClientInternetViewModel, ClientInternetModel>()
                .ForMember(x => x.ConnectDate, o => o.ConvertUsing<DateTimeToTimestampConverter, DateTime>());

            CreateMap<InternetAddParamModel, InternetAddParamViewModel>();
            CreateMap<InternetAddParamViewModel, InternetAddParamModel>();

            CreateMap<ClientInternetAddParamModel, ClientInternetAddParamViewModel>()
                .ForMember(x => x.ClientId, o => o.MapFrom(p => p.userid))
                .ForMember(x => x.ParamId, o => o.MapFrom(p => p.paramid));
            CreateMap<ClientInternetAddParamViewModel, ClientInternetAddParamModel>()
                .ForMember(x => x.userid, o => o.MapFrom(p => p.ClientId))
                .ForMember(x => x.paramid, o => o.MapFrom(p => p.ParamId));

            CreateMap<AccountTariffDigitalViewModel, AccountTariffDigitalModel>();
            CreateMap<AccountTariffDigitalModel, AccountTariffDigitalViewModel>();

            CreateMap<TariffDigitalViewModel, TariffDigitalModel>();
            CreateMap<TariffDigitalModel, TariffDigitalViewModel>();

            CreateMap<ClientDigitalModel, ClientDigitalViewModel>()
                .ForMember(x => x.ConnectDate, o => o.ConvertUsing<TimestampToDateTimeConverter, int>());
            CreateMap<ClientDigitalViewModel, ClientDigitalModel>()
                .ForMember(x => x.ConnectDate, o => o.ConvertUsing<DateTimeToTimestampConverter, DateTime>());

            CreateMap<DigitalAddParamModel, DigitalAddParamViewModel>();
            CreateMap<DigitalAddParamViewModel, DigitalAddParamModel>();

            CreateMap<ClientDigitalAddParamModel, ClientDigitalAddParamViewModel>()
                .ForMember(x => x.ClientId, o => o.MapFrom(p => p.userid))
                .ForMember(x => x.ParamId, o => o.MapFrom(p => p.paramid));
            CreateMap<ClientDigitalAddParamViewModel, ClientDigitalAddParamModel>()
                .ForMember(x => x.userid, o => o.MapFrom(p => p.ClientId))
                .ForMember(x => x.paramid, o => o.MapFrom(p => p.ParamId));

            CreateMap<AccountTariffIPTVViewModel, AccountTariffIPTVModel>();
            CreateMap<AccountTariffIPTVModel, AccountTariffIPTVViewModel>();

            CreateMap<TariffIPTVViewModel, TariffIPTVModel>();
            CreateMap<TariffIPTVModel, TariffIPTVViewModel>();

            CreateMap<ClientIPTVModel, ClientIPTVViewModel>()
                .ForMember(x => x.ConnectDate, o => o.ConvertUsing<TimestampToDateTimeConverter, int>());
            CreateMap<ClientIPTVViewModel, ClientIPTVModel>()
                .ForMember(x => x.ConnectDate, o => o.ConvertUsing<DateTimeToTimestampConverter, DateTime>());

            CreateMap<IPTVAddParamModel, IPTVAddParamViewModel>();
            CreateMap<IPTVAddParamViewModel, IPTVAddParamModel>();

            CreateMap<ClientIPTVAddParamModel, ClientIPTVAddParamViewModel>()
                .ForMember(x => x.ClientId, o => o.MapFrom(p => p.userid))
                .ForMember(x => x.ParamId, o => o.MapFrom(p => p.paramid));
            CreateMap<ClientIPTVAddParamViewModel, ClientIPTVAddParamModel>()
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
