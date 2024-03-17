using System.Diagnostics;

namespace TinyOS.Core.Models;

/// <summary>
/// Contains information to specify a default value for an environment variable.
/// </summary>
[DebuggerDisplay("{DebuggerDisplay, nq}")]
public class EnvironmentGetRequest : IRequest
{
        /// <inheritdoc />
        public string Req { get; set; } = string.Empty;
        
        /// <summary>
        /// The name of the environment variable (case-insensitive). Omit to return all environment variables known to TinyOS.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Debugger display for this object.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get { return $"{{{nameof(Req)}: {Req}, {nameof(Name)}: {Name}}}"; }
        }
}
