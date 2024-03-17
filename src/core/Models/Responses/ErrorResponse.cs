using System.Diagnostics;

namespace TinyOS.Core.Models;

/// <summary>
/// Contains the error results of a response operation.
/// </summary>
[DebuggerDisplay("{DebuggerDisplay, nq}")]
public class ErrorResponse : IResponse
{
    public string Err { get; set; } = string.Empty;
    
    public string Code { get; set; } = string.Empty;

    ///	<summary>
    ///	Debugger display for this object.
    ///	</summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay
    {
        get { return $"{{{nameof(Err)}: {Err}, {nameof(Code)}: {Code}}}"; }
    }
}