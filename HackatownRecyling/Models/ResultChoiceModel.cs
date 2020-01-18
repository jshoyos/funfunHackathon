using HackatownRecyling.Common;

namespace HackatownRecyling.Models
{
    public class ResultChoiceModel : BindableBase
    {
        private string _name;
        private int _score;

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

        public int Score
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
