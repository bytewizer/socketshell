using System.Diagnostics;

namespace TinyOS.Core {

    public static class ProcessExtensions {
        private const int ExitTimeout = 5000;
    
        public static void Terminate(this Process process) {
            if (!process.HasExited) {
                process.Kill();
                process.WaitForExit(ExitTimeout);
            }
            process.Close();
        }
    }
}