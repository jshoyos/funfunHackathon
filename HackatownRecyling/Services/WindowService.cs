using HackatownRecyling.Interfaces;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatownRecyling.Services
{
    internal class WindowService : IWindowService
    {
        public void ShowFileDialog()
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
        }
    }
}
