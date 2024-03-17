using System.Diagnostics;

namespace TinyOS.Core.Models;

/// <summary>
/// Contains information to create an appliciaon request.
/// </summary>
[DebuggerDisplay("{DebuggerDisplay, nq}")]
public class DefaultRequest : IRequest
{
        /// <inheritdoc />
        public string Req { get; set; } = string.Empty;
        
        /// <summary>
        /// Debugger display for this object.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get { return $"{{{nameof(Req)}: {Req}"; }
        }

}
