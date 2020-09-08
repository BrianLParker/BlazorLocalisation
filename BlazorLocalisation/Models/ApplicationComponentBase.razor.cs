namespace BlazorLocalisation.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Components;
    using Microsoft.Extensions.Localization;

    public class ApplicationComponentBase : ComponentBase
    {
        [Inject]
        public IStringLocalizer<App> L { get; set; }
    }
}
