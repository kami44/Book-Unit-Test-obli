using System;

namespace Book
{
    public class Books
    {
        private string _titel { get; set; }
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;

        public Books(string forfatter, int sidetal, string isbn13, string titel)
        {
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn13 = isbn13;
            _titel = titel;
        }

        public string Forfatter
        {
            get => _forfatter;
            set
            {
                if (value.Length > 2) throw new ArgumentException();
                _forfatter = value;
            }
        }

        public int Sidetal
        {
            get => _sidetal;
            set
            {
                if (value > 4||value < 1000)
                    if (value >= 4 && value <= 1000) throw new ArgumentOutOfRangeException();
                _sidetal = value;
            }
        }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value.Length == 13) throw new ArgumentOutOfRangeException();
                    _isbn13 = value;
            }
        }
    }
}
