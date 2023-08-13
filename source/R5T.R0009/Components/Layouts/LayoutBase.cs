using System;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using R5T.T0154;


namespace R5T.R0009.Layouts
{
    /// <summary>
    /// A base component containing the head and body render fragment parameters for a layout.
    /// </summary>
    [RazorComponentMarker]
    public abstract class LayoutBase : ComponentBase
    {
        /// <summary>
        /// Markup within the head node will be placed after the <see cref="HeadOutlet"/>.
        /// </summary>
        [Parameter]
        public RenderFragment Head { get; set; }

        /// <summary>
        /// Markup within the body node will occupy the entirety of the HTML body element.
        /// </summary>
        [Parameter]
        public RenderFragment Body { get; set; }
    }
}
