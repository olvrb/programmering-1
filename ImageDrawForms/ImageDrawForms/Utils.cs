using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageDrawForms
{
    static class Utils
    {
        public static Color GetColorFromPrompt()
        {
            ColorDialog dia = new ColorDialog();
            dia.AllowFullOpen = true;
            dia.ShowDialog();
            return dia.Color;
        }

        public static string GetFileFromPrompt()
        {
            FileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return "";
        }

        // Basically just a wrapper for Task.Run...
        // Wannabe objective c dispatch_async(dispatch_get_global_queue(DISPATCH_QUEUE_PRIORITY_DEFAULT, 0), ^{  })
        public static Task DispatchAsync(Action func)
        {
            return Task.Run(func);
        }
    }
}
