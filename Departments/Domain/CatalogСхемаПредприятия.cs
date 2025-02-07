using Departments.Common;
using System.ComponentModel.DataAnnotations;

namespace Departments.Domain
{
    public class CatalogСхемаПредприятия
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
    }
}
