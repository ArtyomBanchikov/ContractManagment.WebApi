using AutoMapper;
using ContractManagment.API.ViewModel.PostViewModels;
using ContractManagment.API.ViewModel.Record;

namespace ContractManagment.API.Converters
{
    public class PostToLongRecordConverter : ITypeConverter<PostViewModel, LongRecordViewModel>
    {
        public LongRecordViewModel Convert(PostViewModel source, LongRecordViewModel destination, ResolutionContext context)
        {
            LongRecordViewModel longRecord = new() { Value = $"{source.Date}", Record = new() { RecordKeys = new List<RecordKeyViewModel>() } };
            if (source.Meta != null && source.Meta.Any())
            {
                PostMetaViewModel nameMeta = source.Meta.FirstOrDefault(nameM => nameM.Key == "_user_name");
                if (nameMeta != null && !string.IsNullOrEmpty(nameMeta.Value))
                {
                    longRecord.Value += $", {nameMeta.Value}";
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyFIOClient", Name = "Абонент", Value = nameMeta.Value });
                }

                PostMetaViewModel streetMeta = source.Meta.FirstOrDefault(streetM => streetM.Key == "_user_street");
                if (streetMeta != null && !string.IsNullOrEmpty(streetMeta.Value))
                {
                    longRecord.Value += $", {streetMeta.Value}";
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyInstallStreet", Name = "Улица установки", Value = streetMeta.Value });
                }

                PostMetaViewModel houseMeta = source.Meta.FirstOrDefault(houseM => houseM.Key == "_user_home_number");
                if (houseMeta != null && !string.IsNullOrEmpty(houseMeta.Value))
                {
                    longRecord.Value += $", д. {houseMeta.Value}";
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyInstallBuilding", Name = "Дом установки", Value = houseMeta.Value });
                }

                PostMetaViewModel flatMeta = source.Meta.FirstOrDefault(flatM => flatM.Key == "_user_flat_number");
                if (flatMeta != null && !string.IsNullOrEmpty(flatMeta.Value))
                {
                    longRecord.Value += $", кв. {flatMeta.Value}";
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyInstallApartment", Name = "Квартира установки", Value = flatMeta.Value });
                }

                PostMetaViewModel porchMeta = source.Meta.FirstOrDefault(porchM => porchM.Key == "_user_entrance_number");
                if (porchMeta != null && !string.IsNullOrEmpty(porchMeta.Value))
                {
                    longRecord.Value += $", под. {porchMeta.Value}";
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyInstallPorch", Name = "Подъезд", Value = porchMeta.Value });
                }

                PostMetaViewModel floorMeta = source.Meta.FirstOrDefault(floorM => floorM.Key == "_user_floor_number");
                if (floorMeta != null && !string.IsNullOrEmpty(floorMeta.Value))
                {
                    longRecord.Value += $", этаж {floorMeta.Value}";
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyInstallStorey", Name = "Этаж", Value = floorMeta.Value });
                }

                PostMetaViewModel mobPhoneMeta = source.Meta.FirstOrDefault(mobPhoneM => mobPhoneM.Key == "_user_mobile_phone");
                if (mobPhoneMeta != null && !string.IsNullOrEmpty(mobPhoneMeta.Value))
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyClientMobilePhone", Name = "Моб.тел", Value = mobPhoneMeta.Value });

                PostMetaViewModel homePhoneMeta = source.Meta.FirstOrDefault(homePhoneM => homePhoneM.Key == "_user_home_phone");
                if (homePhoneMeta != null && !string.IsNullOrEmpty(homePhoneMeta.Value))
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyClientHomePhone", Name = "Дом.тел", Value = homePhoneMeta.Value });

                PostMetaViewModel regMeta = source.Meta.FirstOrDefault(regM => regM.Key == "_user_reg_address");
                if (regMeta != null && !string.IsNullOrEmpty(regMeta.Value))
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "RegistrationAddress", Name = "Адрес регистрации", Value = regMeta.Value });

                PostMetaViewModel passMeta = source.Meta.FirstOrDefault(passM => passM.Key == "_user_passport_number");
                if (passMeta != null && !string.IsNullOrEmpty(passMeta.Value))
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyClientPassportSmallNumber", Name = "Паспорт", Value = passMeta.Value });

                PostMetaViewModel idMeta = source.Meta.FirstOrDefault(idM => idM.Key == "_user_id_number");
                if (idMeta != null && !string.IsNullOrEmpty(idMeta.Value))
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyClientPassportFullNumber", Name = "Личный номер", Value = idMeta.Value });

                PostMetaViewModel organMeta = source.Meta.FirstOrDefault(organM => organM.Key == "_user_passport_organ");
                PostMetaViewModel passportDateMeta = source.Meta.FirstOrDefault(passDateM => passDateM.Key == "_user_date_passport");
                if (organMeta != null && !string.IsNullOrEmpty(organMeta.Value))
                {
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyClientPassportIssued", Name = "Выдан", Value = organMeta.Value });
                    if (passportDateMeta != null && !string.IsNullOrEmpty(passportDateMeta.Value))
                        longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyClientPassportIssued", Name = "Выдан", Value = $"{organMeta.Value} {passportDateMeta.Value}" });
                    else
                        longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyClientPassportIssued", Name = "Выдан", Value = organMeta.Value });
                }
                else if (passportDateMeta != null && !string.IsNullOrEmpty(passportDateMeta.Value))
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyClientPassportIssued", Name = "Выдан", Value = passportDateMeta.Value });

                PostMetaViewModel rateMeta = source.Meta.FirstOrDefault(rateM => rateM.Key == "_user_rate_title");
                if (rateMeta != null && !string.IsNullOrEmpty(rateMeta.Value))
                    longRecord.Record.RecordKeys.Add(new RecordKeyViewModel { Key = "KeyTariff", Name = "Тариф", Value = rateMeta.Value });
            }
            return longRecord;
        }
    }
}
