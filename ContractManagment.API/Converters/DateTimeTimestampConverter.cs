using AutoMapper;

namespace ContractManagment.API.Converters
{
    public class DateTimeToTimestampConverter : IValueConverter<DateTime, int>
    {
        public int Convert(DateTime sourceMember, ResolutionContext context)
        {
            double seconds = sourceMember.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            return System.Convert.ToInt32(seconds);
        }
    }
    public class TimestampToDateTimeConverter : IValueConverter<int, DateTime>
    {
        public DateTime Convert(int sourceMember, ResolutionContext context)
        {
            DateTime dateTime = new DateTime(1970, 1, 1);
            dateTime = dateTime.AddSeconds(sourceMember);
            return dateTime;
        }
    }
}
