namespace Unit_testing_for_testing
{
    public class Book
    {
        private string _title;
        private int _year;

        public Book(string title, int year)
        {
            if (title.Length <= 2)
            {
                throw new TitleTooShortException();
            }

            this._title = title;

            if (year <= 1100 || year > 2016)
            {
                throw new IncorrectYearException();
            }

            this._year = year;
        }

        public string Title
        {
            get { return _title; }
        }

        public int Year
        {
            get { return _year; }
        }
    }
}