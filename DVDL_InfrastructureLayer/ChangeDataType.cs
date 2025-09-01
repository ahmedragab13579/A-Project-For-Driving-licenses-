using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_InfrastructureLayer
{
    public static class ChangeDataType
    {
        public static DataTable ToDataTable<T>(IEnumerable<T> items)
        {
            DataTable table = new DataTable();

            if (items == null) return table;

            Type type = typeof(T);
            if (type == typeof(object) && items.Any())
            {
                type = items.First().GetType();
            }

            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in items)
            {
                var row = table.NewRow();
                foreach (var prop in props)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }


    }
}
