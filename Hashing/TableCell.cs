namespace Hashing
{
    public class TableCell
    {
        public EmployeeInfo Info { get; set; }
        public int Next { get; set; }

        public TableCell(EmployeeInfo info, int next = -1)
        {
            Info = info;
            Next = next;
        }
    }
}