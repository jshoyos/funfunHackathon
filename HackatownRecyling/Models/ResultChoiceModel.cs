using HackatownRecyling.Common;
using System.ComponentModel;

namespace HackatownRecyling.Models
{
    public class ResultChoiceModel : BindableBase
    {
        private string _name;
        private double _score;

        public ResultChoiceModel()
        {
            _name = "DummyResult";
            _score = 0.0;
        }
        public ResultChoiceModel(string name, double score)
        {
            _name = name;
            _score = score;
        }
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Score
        {
            get => _score;
            set
            {
                if (_score != value)
                {
                    _score = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
