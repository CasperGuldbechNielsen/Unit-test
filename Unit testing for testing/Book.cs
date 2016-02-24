namespace Unit_testing_for_testing
{
    public class Book
    {
        private string _title;
        private int _year;

        public Book()
        {
            
        }

        public Book(string title, int year)
        {
            if (title.Length <= 2)
            {
                throw new TitleTooShortException("Title too short");
            }

            this._title = title;

            if (year < 1100 || year > 2016)
            {
                throw new IncorrectYearException("Incorrect year");
            }

            this._year = year;
        }

        public string Title
        {
            get { return _title; }
            set {
                if (value.Length < 2)
                {
                    throw new TitleTooShortException("Title too short");
                }
                else
                {
                    _title = value;
                } }
        }

        public int Year
        {
            get { return _year; }
            set {
                if (value < 1100 || value > 2016)
                {
                    throw new IncorrectYearException("Incorrect year");
                }
                else
                {
                    _year = value;
                } }
        }
    }
}