
namespace Application.Interfaces
{
    public interface IDateTimeService
    {
        //esta interfaz me permite hacer un seguimiento o agregar el CreatedBy o LastModifiedBy
        DateTime NowUtc { get; }
    }
}
