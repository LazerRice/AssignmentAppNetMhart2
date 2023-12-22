using AssignmentAppNetMhart2.Enums;

namespace AssignmentAppNetMhart2.Interfaces
{
    public interface IServiceResult
    {
        object Result { get; set; }
        ServiceStatus Status { get; set; }
    }
}