using AutoMapper;
using ContractManagment.API.ViewModel.Record;

namespace ContractManagment.API.Converters
{
    public class RecordToLongRecordConverter : ITypeConverter<RecordViewModel, LongRecordViewModel>
    {
        public LongRecordViewModel Convert(RecordViewModel source, LongRecordViewModel destination, ResolutionContext context)
        {
            LongRecordViewModel longRecord = new() { Record = source, Value = $"{source.Time}" };
            if (longRecord.Record.RecordKeys.Any())
            {
                RecordKeyViewModel accountKey = longRecord.Record.RecordKeys.FirstOrDefault(accKey => accKey.Key == "KeyIdContract");
                if (accountKey != null)
                    longRecord.Value += $", {accountKey.Value}";

                RecordKeyViewModel nameKey = longRecord.Record.RecordKeys.FirstOrDefault(nameK => nameK.Key == "KeyFIOClient");
                if (nameKey != null)
                    longRecord.Value += $", {nameKey.Value}";

                RecordKeyViewModel streetKey = longRecord.Record.RecordKeys.FirstOrDefault(streetK => streetK.Key == "KeyInstallStreet");
                if (streetKey != null)
                    longRecord.Value += $", {streetKey.Value}";

                RecordKeyViewModel houseKey = longRecord.Record.RecordKeys.FirstOrDefault(houseK => houseK.Key == "KeyInstallBuilding");
                if (houseKey != null)
                    longRecord.Value += $", д. {houseKey.Value}";

                RecordKeyViewModel flatKey = longRecord.Record.RecordKeys.FirstOrDefault(flatK => flatK.Key == "KeyInstallApartment");
                if (flatKey != null)
                    longRecord.Value += $", кв. {flatKey.Value}";

                RecordKeyViewModel porchKey = longRecord.Record.RecordKeys.FirstOrDefault(porchK => porchK.Key == "KeyInstallPorch");
                if (porchKey != null)
                    longRecord.Value += $", под. {porchKey.Value}";

                RecordKeyViewModel floorKey = longRecord.Record.RecordKeys.FirstOrDefault(floorK => floorK.Key == "KeyInstallStorey");
                if (floorKey != null)
                    longRecord.Value += $", этаж {floorKey.Value}";
            }
            return longRecord;
        }
    }
}
