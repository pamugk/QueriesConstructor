namespace QueryConstructor
{
    public partial class ConstructorForm
    {
        private const string TableColumn = "TABLE_NAME";
        private const string ColColumn = "COLUMN_NAME";
        private const string ColTypeColumn = "DATA_TYPE";
        private const string MaxLength = "CHARACTER_MAXIMUM_LENGTH";

        private const string PkTableName = "PK_Tab_Name";
        private const string PkColName = "PK_Col_Name";
        private const string FkTableName = "FK_Tab_Name";
        private const string FkColName = "FK_Col_Name";

        private const string FieldsColumnCol = "Field_name";
        private const string FieldsTableCol = "Table_name";
        private const string FieldsVisibleCol = "Transl_fn";

        private readonly string _getColumnsQuery = 
            $@"SELECT {TableColumn}, {ColColumn}, {ColTypeColumn}, {MaxLength}
            FROM [INFORMATION_SCHEMA].[COLUMNS]
            WHERE {TableColumn} <> 'sysdiagrams'
            ORDER BY {TableColumn} ASC, ORDINAL_POSITION ASC";

        private readonly string _getRealColumnsQuery =
            $@"SELECT {FieldsColumnCol}, {FieldsTableCol}, {FieldsVisibleCol} FROM _Fields";

        private readonly string _getPrimaryKeysQuery =
            $@"SELECT INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.TABLE_NAME AS '{PkTableName}', COLUMN_NAME AS '{PkColName}'
               FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE 
			        JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
			        ON INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_NAME = INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.CONSTRAINT_NAME
               WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.TABLE_NAME <> 'sysdiagrams'
               ORDER BY {PkTableName}";

        private readonly string _getLinksQuery =
            $@"SELECT {FkTableName}, {FkColName}, {PkTableName}, {PkColName}
                FROM
	            (
		            SELECT INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.TABLE_NAME AS '{FkTableName}', 
				            COLUMN_NAME AS '{FkColName}', REFERENTIAL_CONSTRAINTS.UNIQUE_CONSTRAINT_NAME AS 'Key' 
		            FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
			                JOIN INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS
			                ON INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS.CONSTRAINT_NAME = INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.CONSTRAINT_NAME 
				                AND NOT INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.TABLE_NAME = 'sysdiagrams'
	            ) AS ForeignKeys 
	            JOIN
	            (
		            SELECT INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.TABLE_NAME AS '{PkTableName}', 
				            COLUMN_NAME AS '{PkColName}', INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.CONSTRAINT_NAME AS 'Key'
		            FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
			                JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
			                ON INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_NAME = INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.CONSTRAINT_NAME
			        WHERE CONSTRAINT_TYPE = 'PRIMARY KEY'
	            ) AS PrimaryKeys ON ForeignKeys.[Key] = PrimaryKeys.[Key]";
    }
}