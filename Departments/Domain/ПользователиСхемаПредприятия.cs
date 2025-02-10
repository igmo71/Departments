using Departments.Common;
using System.ComponentModel.DataAnnotations;

namespace Departments.Domain
{
    public class ПользователиСхемаПредприятия
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public required string СхемаПредприятия_Key { get; set; }
    }
}
