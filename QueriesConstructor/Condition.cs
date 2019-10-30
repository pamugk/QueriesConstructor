using System;

namespace QueryConstructor
{
    internal class Condition
    {
        public ColumnInfo Column { get; set; }
        public string Criterion { get; set; }
        public object Value { get; set; }
        public LogicOperation LogicOp { get; set; }
        public string Variable { get; set; }

        public Condition(ColumnInfo column, string criterion, object value, string variable, LogicOperation logicOp)
        {
            Column = column;
            Criterion = criterion;
            Value = value;
            Variable = variable;
            LogicOp = logicOp;
        }

        public string ToString(bool withVals)
        {
            return $"{LogicOp.RealName} [{Column.TableName}].[{Column.RealName}] {Criterion} {(withVals ? ValToString() : Variable)}";
        }

        private string ValToString()
        {
            var result = "";
            switch (Column.ValType.Description.Class)
            {
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Boolean:
                    {
                        result = (bool)Value ? "1" : "0";
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.DateTime:
                    {
                        result = "{" + DateToString(Column.ValType.Name, (DateTime)Value) + "}";
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Floating:
                    {
                        result = Convert.ToString(Value);
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Integer:
                    {
                        result = Convert.ToString(Value);
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Text:
                    {
                        result = $"'{Value as string}'";
                        break;
                    }
            }
            return result;
        }

        private static string DateToString(string colType, DateTime value)
        {
            var result = "";
            switch (colType)
            {
                case "date":
                    {
                        result = value.ToString("dd.MM.yyyy");
                        break;
                    }
                case "datetime":
                    {
                        result = value.ToString("dd.MM.yyyy HH:mm:ss");
                        break;
                    }
                case "datetime2":
                    {
                        result = value.ToString("dd.MM.yyyy HH:mm:ss");
                        break;
                    }
                case "datetimeoffset":
                    {
                        result = value.ToString("dd.MM.yyyy HH:mm:ss");
                        break;
                    }
                case "smalldatetime":
                    {
                        result = value.ToString("dd.MM.yyyy HH:mm:ss");
                        break;
                    }
                case "time":
                    {
                        result = value.ToString("HH:mm:ss");
                        break;
                    }
            }
            return result;
        }
    }
}