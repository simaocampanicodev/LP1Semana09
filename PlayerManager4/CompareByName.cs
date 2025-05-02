using System.Collections;

namespace PlayerManager4
{
    public class CompareByName : IComparer
    {

        private bool _ascending;
        public CompareByName(bool ascending)
        {
            _ascending = ascending;
        }

        public int Compare(object x, object y)
        {
            if (!(x is string xx) || !(y is string yy)) return -1;
            if (_ascending) return xx.CompareTo(yy);
            return yy.CompareTo(xx);
        }
    }
}