using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppealsAndRKK
{
    public class NameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            DataGridViewRow row1 = (DataGridViewRow)x;
            DataGridViewRow row2 = (DataGridViewRow)y;

            return System.String.Compare(
                row1.Cells["responsibleExecutor"].Value.ToString(),
                row2.Cells["responsibleExecutor"].Value.ToString());
        }
    }

    public class RowsComparer : IComparer
    {
        private string firstColumn;
        private string secondColumn;
        private ListSortDirection direction;

        public RowsComparer(string firstColumn, string secondColumn, ListSortDirection direction)
        {
            this.firstColumn = firstColumn;
            this.secondColumn = secondColumn;
            this.direction = direction;
        }

        public int Compare(object x, object y)
        {
            DataGridViewRow row1 = (DataGridViewRow)x;
            DataGridViewRow row2 = (DataGridViewRow)y;

            int CompareResult = ((int)row1.Cells[firstColumn].Value)
                .CompareTo((int)row2.Cells[firstColumn].Value);

            if (CompareResult == 0)
            {
                CompareResult = ((int)row1.Cells[secondColumn].Value)
                    .CompareTo((int)row2.Cells[secondColumn].Value);
            }
            return direction == ListSortDirection.Ascending ? CompareResult : CompareResult * (-1);
        }
    }

    public class RKKCountComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return new RowsComparer("RKKCount", "AppealsCount", ListSortDirection.Descending).Compare(x, y);
        }
    }

    public class AppealsCountComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return new RowsComparer("AppealsCount", "RKKCount", ListSortDirection.Descending).Compare(x, y);
        }
    }

    public class TotalCountComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return new RowsComparer("TotalAmount", "RKKCount", ListSortDirection.Descending).Compare(x, y);
        }
    }
}
