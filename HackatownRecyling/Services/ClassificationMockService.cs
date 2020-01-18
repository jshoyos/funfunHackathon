using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackatownRecyling.Interfaces;
using HackatownRecyling.Models;
using Matrox.MatroxImagingLibrary;
namespace HackatownRecyling.Services
{
    public class ClassificationMockService : IClassificationService
    {
        public void Classify(string filename)
        {
            ResultChoiceModel CurrentResult = new ResultChoiceModel("Classification Context 0", 100.0);
            //TODO -- To be removed
            
        }
    }
}
