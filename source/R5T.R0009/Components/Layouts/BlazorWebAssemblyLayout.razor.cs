using System;

using R5T.T0154;


namespace R5T.R0009.Layouts
{
    /// <summary>
    /// Basic layout, <strong>without</strong> the &lt;html&gt;, &lt;head&gt;, and &lt;body&gt; elements, with the &lt;head&gt;
    /// (that for Blazor WebAssembly clients are provided by the project's index.html file).
    /// <para>
    /// This layout should be used in Blazor WebAssembly clients, since it will try to provide the &lt;html&gt;, &lt;head&gt;, and &lt;body&gt; elements
    /// that are already provided by the Blazor WebAssembly client projects index.html.
    /// </para>
    /// <para>
    /// This layout should <strong>not</strong> be used with static Razor components, since it does not provide the &lt;html&gt;, &lt;head&gt;, and &lt;body&gt; elements
    /// that the _Host.cshtml file also does not provide (since the _Host.cshtml file defines no layout, and simply returns what the result of rendering the selected component).
    /// </para>
    /// </summary>
    [RazorLayoutMarker]
    public partial class BlazorWebAssemblyLayout : IRazorComponentMarker
    {

    }
}
