﻿namespace HackatownRecyling.Interfaces
{
    public interface IWindowService
    {
        void ShowResultView(string fileName);
        void ShowLiveCameraView();
        /// <summary>
        /// Starts the file dialog. Returns the file name or null if the user cancelled.
        /// </summary>
        /// <returns></returns>
        string ShowFileDialog();
    }
}
