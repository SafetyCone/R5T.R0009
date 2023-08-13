using System;

using Microsoft.AspNetCore.Components.Web;

using R5T.T0154;


namespace R5T.R0009.Layouts
{
    /// <summary>
    /// Basic HTML layout, with &lt;html&gt;, &lt;head&gt;, and &lt;body&gt; elements, with the &lt;head&gt; element includes the <see cref="HeadOutlet"/>.
    /// <para>
    /// This layout should be used with static Razor components, since it provides the &lt;html&gt;, &lt;head&gt;, and &lt;body&gt; elements that the _Host.cshtml file does not
    /// (since the _Host.cshtml file defines no layout, and simply returns what the result of rendering the selected component).
    /// </para>
    /// <para>
    /// This layout should <strong>not</strong> be used in Blazor WebAssembly clients, since it will try to provide the &lt;html&gt;, &lt;head&gt;, and &lt;body&gt; elements
    /// that are already provided by the Blazor WebAssembly client projects index.html.
    /// </para>
    /// </summary>
    [RazorLayoutMarker]
    public partial class HtmlLayout : IRazorComponentMarker
    {
    }
}
