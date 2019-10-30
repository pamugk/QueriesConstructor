using System.Collections.Generic;

namespace QueryConstructor
{
    public class ColumnInfo
    {
        public enum Ordering
        {
            None,
            Ascending,
            Descending
        }

        public string TableName { get; }
        public string RealName { get; }
        public ColumnTypeInfo ValType { get; }
        public string VisibleName { get; set; }
        public int? CharMaxLength { get; }
        public Ordering Order { get; set; }

        public ColumnInfo(string tableName, string name, string valType, int? maxLength)
        {
            TableName = tableName;
            RealName = name;
            VisibleName = name;
            ValType = new ColumnTypeInfo(valType);
            CharMaxLength = maxLength;
            Order = Ordering.None;
        }

        public ColumnInfo(string tableName, string name, string visibleName)
        {
            TableName = tableName;
            RealName = name;
            VisibleName = visibleName;
        }

        public override string ToString()
        {
            return VisibleName;
        }

        public string ToLongString()
        {
            return $"[{TableName}].[{RealName}]";
        }

        public string OrderedColumnToString()
        {
            return $"{ToLongString()} {(Order == Ordering.Ascending ? "ASC" : "DESC")}";
        }

        public class ColumnTypeInfo
        {
            public enum TypeClasses
            {
                Integer,
                Boolean,
                Floating,
                DateTime,
                Text,
            }

            private static readonly List<string> EqualityOperations = new List<string> { "=" };
            private static readonly List<string> CommonComparsionOps = new List<string>(EqualityOperations) { "<>", ">", "<", ">=", "<="};
            private static readonly List<string> TextOperations = new List<string>(CommonComparsionOps) {"LIKE"};

            private static readonly TypeClassDesciption IntegerTypeDescr = new TypeClassDesciption(TypeClasses.Integer, CommonComparsionOps);
            private static readonly TypeClassDesciption BoolTypeDescr = new TypeClassDesciption(TypeClasses.Boolean, EqualityOperations);
            private static readonly TypeClassDesciption FloatTypeDescr = new TypeClassDesciption(TypeClasses.Floating, CommonComparsionOps);
            private static readonly TypeClassDesciption DateTimeTypeDescr = new TypeClassDesciption(TypeClasses.DateTime, CommonComparsionOps);
            private static readonly TypeClassDesciption TextTypeDescr = new TypeClassDesciption(TypeClasses.Text, TextOperations);

            private static readonly Dictionary<string, TypeClassDesciption> TypesDescription = new Dictionary<string, TypeClassDesciption>
            {
                { "bit",  BoolTypeDescr },
                { "bigint", IntegerTypeDescr} ,
                { "int", IntegerTypeDescr },
                { "smallint",  IntegerTypeDescr },
                { "tinyint",  IntegerTypeDescr },
                { "float",  FloatTypeDescr },
                { "real", FloatTypeDescr },
                { "decimal", FloatTypeDescr },
                { "money",  FloatTypeDescr },
                { "smallmoney", FloatTypeDescr },
                { "numeric",  FloatTypeDescr },
                { "date", DateTimeTypeDescr },
                { "datetime2",DateTimeTypeDescr },
                { "datetime", DateTimeTypeDescr },
                { "datetimeoffset", DateTimeTypeDescr },
                { "smalldatetime",DateTimeTypeDescr },
                { "time", DateTimeTypeDescr },
                { "char", TextTypeDescr },
                { "text", TextTypeDescr },
                { "varchar", TextTypeDescr },
                { "nchar", TextTypeDescr },
                { "ntext", TextTypeDescr },
                { "nvarchar", TextTypeDescr }
            };

            public string Name { get; }
            public TypeClassDesciption Description { get; }

            public ColumnTypeInfo(string name)
            {
                Name = name.ToLower();
                Description = TypesDescription[Name];
            }

            public override string ToString()
            {
                return Name;
            }

            public class TypeClassDesciption
            {
                public TypeClasses Class { get; }
                public List<string> Operations { get; }

                public TypeClassDesciption(TypeClasses typeClass, List<string> operations)
                {
                    Class = typeClass;
                    Operations = operations;
                }
            }
        }
    }
}