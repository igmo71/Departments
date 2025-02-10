using Departments.Common;
using System.ComponentModel.DataAnnotations;

namespace Departments.Domain
{
    public class ПользовательСхемаПредприятия
    {
        [MaxLength(AppSettings.GUID)] public string? Пользователь_Key { get; set; }

        public CatalogПользователи? Пользователь { get; set; }


        [MaxLength(AppSettings.GUID)] public string? СхемаПредприятия_Key { get; set; }

        public CatalogСхемаПредприятия? СхемаПредприятия { get; set; }
    }
}
