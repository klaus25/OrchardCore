using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.Autoroute.Models;
using OrchardCore.ContentManagement;

namespace OrchardCore.Autoroute.ViewModels
{
    public class AutoroutePartViewModel: IContent
    {
        public string Path { get; set; }
        public bool SetHomepage { get; set; }
        public bool UpdatePath { get; set; }
        public bool IsHomepage { get; set; }

        [BindNever]
        public ContentItem ContentItem { get; set; }

        [BindNever]
        public AutoroutePart AutoroutePart { get; set; }

        [BindNever]
        public AutoroutePartSettings Settings { get; set; }
    }
}
