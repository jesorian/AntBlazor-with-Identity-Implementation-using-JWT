using System.Collections.Generic;
using hosted.Models;
using Microsoft.AspNetCore.Components;

namespace hosted.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}