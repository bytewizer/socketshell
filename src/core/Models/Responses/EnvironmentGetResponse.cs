using System.Diagnostics;

namespace TinyOS.Core.Models;

/// <summary>
/// Contains the results of a <see cref="EnvironmentGetRequest"/> operation.
/// </summary>
[DebuggerDisplay("{DebuggerDisplay, nq}")]
public class EnvironmentGetResponse : IResponse
{
    /// <summary>
    /// If a name was specified the value of the environment variable.
    /// </summary>
    public string? Text { get; set; }
    
    /// <summary>
    /// If a name was not specified an object with name and value pairs for all environment variables.
    /// </summary>
    //public Dictionary<string, string> Body { get; set; }

    ///	<summary>
    ///	Debugger display for this object.
    ///	</summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay
    {
        get { return $""; }
    }
}