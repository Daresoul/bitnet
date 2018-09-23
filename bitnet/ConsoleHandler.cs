using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace bitnet
{
    class ConsoleHandler
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        // If true window is visible
        private bool _windowStatus = true;

        /// <summary>
        /// This will hide the window or show if already hidden
        /// </summary>
        public void ToggleWindow()
        {
            var handle = GetConsoleWindow();

            if (_windowStatus)
            {
                ShowWindow(handle, SW_HIDE);
                _windowStatus = false;
            }
            else
            {
                ShowWindow(handle, SW_SHOW);
                _windowStatus = true;
            }
        }
    }
}
