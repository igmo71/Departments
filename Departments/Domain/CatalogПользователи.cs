using Departments.Common;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Departments.Domain
{
    public class CatalogПользователи
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Доброга_СхемаПредприятия_Key { get; set; }

        [JsonPropertyName("Доброга_Должность")]
        [MaxLength(AppSettings.VALUE)] public string? Должность { get; set; }
    }
}
