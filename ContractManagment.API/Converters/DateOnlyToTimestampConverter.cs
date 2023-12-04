using AutoMapper;

namespace ContractManagment.API.Converters
{
    public class DateOnlyToTimestampConverter : IValueConverter<DateOnly, int>
    {
        public int Convert(DateOnly sourceMember, ResolutionContext context)
        {
            double seconds = sourceMember.ToDateTime(new TimeOnly()).Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            return System.Convert.ToInt32(seconds);
        }
    }
    public class TimestampToDateOnlyConverter : IValueConverter<int, DateOnly>
    {
        public DateOnly Convert(int sourceMember, ResolutionContext context)
        {
            DateTime dateTime = new DateTime(1970, 1, 1);
            dateTime = dateTime.AddSeconds(sourceMember);
            return DateOnly.FromDateTime(dateTime);
        }
    }
}
