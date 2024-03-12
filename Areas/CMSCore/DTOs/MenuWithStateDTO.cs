using FiyiRequirements.Areas.CMSCore.Entities;

namespace FiyiRequirements.Areas.CMSCore.DTOs
{
    public class MenuWithStateDTO : Menu
    {
        public bool IsSelected { get; set; }
    }
}
