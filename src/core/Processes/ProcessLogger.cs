namespace TinyOS.Core.Processes {
    public interface IProcessLogger {
        void OnOutputDataReceived(string stdout);
        void OnErrorDataReceived(string stderr);
    }
}