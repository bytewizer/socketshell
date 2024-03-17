using System.Diagnostics;

namespace TinyOS.Core.Models;

/// <summary>
/// Contains information to specify a default value for an environment variable.
/// </summary>
[DebuggerDisplay("{DebuggerDisplay, nq}")]
public class EnvironmentSetRequest : IRequest
{
        /// <inheritdoc />
        public string Req { get; set; } = string.Empty;
        
        /// <summary>
        /// The name of the environment variable (case-insensitive).
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The value of the variable. Pass "" or omit from the request to delete it.
        /// </summary>
        public string? Text { get; set; } = null;

        /// <summary>
        /// Debugger display for this object.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get { return $"{{{nameof(Req)}: {Req}, {nameof(Name)}: {Name}, {nameof(Text)}: {Text}}}"; }
        }
}
