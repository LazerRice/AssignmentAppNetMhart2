using AssignmentAppNetMhart2.Enums;
using AssignmentAppNetMhart2.Interfaces;

namespace AssignmentAppNetMhart2.Responses;
public class ServiceResult : IServiceResult
{
    public ServiceStatus Status { get; set; }

    public object Result { get; set; } = null!;
}
