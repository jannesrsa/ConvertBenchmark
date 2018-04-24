using System;
using System.Data;

namespace ConvertBenchmark
{
    public static class TestData
    {
        static TestData()
        {
            DataTable = CreateInsertAllProperty(false, 1);
            StringDataTable = CreateInsertAllProperty(true, 1);
        }

        public static DataTable DataTable { get; }

        public static DataTable StringDataTable { get; }

        public static DataTable CreateInsertAllProperty(bool stringValues, int numberOfRecords = 1)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("DateTime", stringValues ? typeof(string) : typeof(DateTime));
            dataTable.Columns.Add("Decimal", stringValues ? typeof(string) : typeof(Decimal));
            dataTable.Columns.Add("String", typeof(string));
            dataTable.Columns.Add("Guid", stringValues ? typeof(string) : typeof(Guid));
            dataTable.Columns.Add("Int16", stringValues ? typeof(string) : typeof(Int16));
            dataTable.Columns.Add("Int32", stringValues ? typeof(string) : typeof(Int32));
            dataTable.Columns.Add("Int64", stringValues ? typeof(string) : typeof(Int64));
            dataTable.Columns.Add("Bool", stringValues ? typeof(string) : typeof(bool));

            for (int i = 1; i <= numberOfRecords; i++)
            {
                var newRow = dataTable.NewRow();

                newRow["DateTime"] = DateTime.MaxValue;
                newRow["Decimal"] = Decimal.MaxValue;
                newRow["String"] = Guid.NewGuid().ToString();
                newRow["Guid"] = Guid.NewGuid();
                newRow["Int16"] = Int16.MaxValue;
                newRow["Int32"] = Int32.MaxValue;
                newRow["Int64"] = Int64.MaxValue;
                newRow["Bool"] = i % 2 == 0;

                if (stringValues)
                {
                    foreach (DataColumn dataColumn in dataTable.Columns)
                    {
                        newRow[dataColumn] = newRow[dataColumn].ToString();
                    }
                }

                dataTable.Rows.Add(newRow);
            }

            return dataTable;
        }
    }
}