using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_InfrastructureLayer
{
    public class FilterTheData
    {
        public static  DataView MakeAFilter(DataTable FilteredDataTable, string columnName, string filterVariable)
        {
            if (FilteredDataTable == null)
                throw new InvalidOperationException("The data table is not initialized or available.");

            if (!FilteredDataTable.Columns.Contains(columnName))
                throw new ArgumentException($"The column '{columnName}' does not exist in the data table.");

            var view = FilteredDataTable.DefaultView;

            if (string.IsNullOrWhiteSpace(filterVariable))
            {
                view.RowFilter = "";
                return view;
            }

            var columnType = FilteredDataTable.Columns[columnName].DataType;

            try
            {
                if (columnType == typeof(DateTime))
                {
                    if (DateTime.TryParse(filterVariable, out DateTime time))
                    {
                        view.RowFilter = $"{columnName} = #{time:yyyy-MM-dd}#";
                    }
                    else
                    {
                        view.RowFilter = "1=0";
                    }
                }
                else if (columnType == typeof(int) || columnType == typeof(long) || columnType == typeof(short))
                {
                    if (int.TryParse(filterVariable, out int numericValue))
                        view.RowFilter = $"{columnName} = {numericValue}";
                    else
                        view.RowFilter = "1=0";
                }
                else if (columnType == typeof(decimal) || columnType == typeof(long) || columnType == typeof(short))
                {
                    if (int.TryParse(filterVariable, out int numericValue))
                        view.RowFilter = $"{columnName} = {numericValue}";
                    else
                        view.RowFilter = "1=0";
                }
                else if (columnType == typeof(bool))
                {
                    if (bool.TryParse(filterVariable, out bool boolVal))
                        view.RowFilter = $"{columnName} = {boolVal}";
                    else
                        view.RowFilter = "1=0";
                }
                else
                {
                    string escaped = filterVariable.Replace("'", "''");
                    view.RowFilter = $"{columnName} LIKE '%{escaped}%'";
                }
            }
            catch
            {
                view.RowFilter = "";
            }

            return view;
        }

    }
}
