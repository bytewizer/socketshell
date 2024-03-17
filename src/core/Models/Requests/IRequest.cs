namespace TinyOS.Core.Models
{
    /// <summary>
    /// An interface for <see cref="IRequest"/>.
    /// </summary>
    public interface IRequest 
    {
        /// <summary>
        /// The request type provided with every request.
        /// </summary>

        string Req {get; set;} 
    }
}