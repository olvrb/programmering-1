using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageDrawForms {
    internal static class Utils {
        public static Color GetColorFromPrompt() {
            ColorDialog dia = new ColorDialog {AllowFullOpen = true};
            dia.ShowDialog();
            return dia.Color;
        }

        public static string GetFileFromPrompt() {
            FileDialog dialog = new OpenFileDialog();
            // Return null if the user cancelled the prompt.
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
        }

        // Basically just a wrapper for Task.Run...
        // Wannabe objective c dispatch_async(dispatch_get_global_queue(DISPATCH_QUEUE_PRIORITY_DEFAULT, 0), ^{  });
        public static Task DispatchAsync(Action func) {
            return Task.Run(func);
        }
    }
}