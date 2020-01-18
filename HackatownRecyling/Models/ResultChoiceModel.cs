using HackatownRecyling.Common;

namespace HackatownRecyling.Models
{
    public class ResultChoiceModel : BindableBase
    {
        private string _name;
        private double _score;

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
