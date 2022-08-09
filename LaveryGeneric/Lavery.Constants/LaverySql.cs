using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Constants
{
    public class LaverySql
    {
		public static String sSqlForSimpleEntitieDescriptions =
@"select distinct Info.TABLE_NAME as TableName, Info.COLUMN_NAME as ColumnName, Info.IS_NULLABLE isNullable, case when constrainte.CONSTRAINT_NAME is null then 0 else 1 end is_PK, 
		fkTemp2.Target as TargetTableName,  fkTemp2.TargetColumn, DATA_TYPE as ColumnType, fk_col.max_length as ColumnMaxLength, fk_col.precision as ColumnPrecision, fk_col.scale as ColumnScale
from INFORMATION_SCHEMA.COLUMNS Info
left outer join sys.tables pk_tab on pk_tab.name = Info.TABLE_NAME
left outer  join sys.columns fk_col  on fk_col.object_id = pk_tab.object_id and Info.COLUMN_NAME = fk_col.name
left Outer JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE usage  ON Info.TABLE_NAME=usage.TABLE_NAME and Info.COLUMN_NAME=usage.COLUMN_NAME
left outer join INFORMATION_SCHEMA.TABLE_CONSTRAINTS constrainte on  constrainte.CONSTRAINT_NAME =  usage.CONSTRAINT_NAME and constrainte.CONSTRAINT_TYPE='PRIMARY KEY'
left outer join(select distinct    OBJECT_NAME(fk_tab.object_id) as Source, OBJECT_NAME(fk_ref.object_id) as Target , fk_col.name as foreignKey, fk_col2.name as TargetColumn
  from sys.foreign_key_columns fk
  inner join sys.tables fk_tab on fk_tab.object_id = fk.parent_object_id
  inner join sys.tables fk_ref on fk_ref.object_id = fk.referenced_object_id
  inner join sys.foreign_key_columns fk_cols on fk_cols.constraint_object_id = fk.constraint_object_id
  inner join sys.columns fk_col  on fk_col.column_id = fk_cols.parent_column_id and fk_col.object_id = fk_tab.object_id
  inner join sys.columns fk_col2  on fk_col2.column_id = fk_cols.referenced_column_id and fk_col2.object_id = fk.referenced_object_id
  where OBJECT_NAME(fk_tab.object_id)  in( {0} )) as fkTemp2 on Info.TABLE_NAME = fkTemp2.source and  info.COLUMN_NAME = fkTemp2.foreignKey
  where Info.TABLE_NAME in( {0} )
  union 
select distinct Info.TABLE_NAME as TableName, Info.COLUMN_NAME as ColumnName, Info.IS_NULLABLE isNullable, case when constrainte.CONSTRAINT_NAME is null then 0 else 1 end is_PK, 
		fkTemp2.Target as TargetTableName,  fkTemp2.TargetColumn, DATA_TYPE as ColumnType, fk_col.max_length as ColumnMaxLength, fk_col.precision as ColumnPrecision, fk_col.scale as ColumnScale
from INFORMATION_SCHEMA.COLUMNS Info
left outer join sys.tables pk_tab on pk_tab.name = Info.TABLE_NAME
left outer  join sys.columns fk_col  on fk_col.object_id = pk_tab.object_id and Info.COLUMN_NAME = fk_col.name
left Outer JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE usage  ON Info.TABLE_NAME=usage.TABLE_NAME and Info.COLUMN_NAME=usage.COLUMN_NAME
left outer join INFORMATION_SCHEMA.TABLE_CONSTRAINTS constrainte on  constrainte.CONSTRAINT_NAME =  usage.CONSTRAINT_NAME and constrainte.CONSTRAINT_TYPE='PRIMARY KEY'
inner join (select distinct OBJECT_NAME(fk_tab.object_id) as Source, OBJECT_NAME(fk_ref.object_id) as Target
	from sys.foreign_key_columns fk
	inner join sys.tables fk_tab on fk_tab.object_id = fk.parent_object_id
	inner join sys.tables fk_ref on fk_ref.object_id = fk.referenced_object_id
	inner join sys.foreign_key_columns fk_cols on fk_cols.constraint_object_id = fk.constraint_object_id
	inner join sys.columns fk_col  on fk_col.column_id = fk_cols.parent_column_id and fk_col.object_id = fk_tab.object_id
	where OBJECT_NAME(fk_tab.object_id) in( {0} )) as fkTemp on Info.TABLE_NAME = fkTemp.Target
left outer join(select distinct    OBJECT_NAME(fk_tab.object_id) as Source, OBJECT_NAME(fk_ref.object_id) as Target , fk_col.name as foreignKey, fk_col2.name as TargetColumn
  from sys.foreign_key_columns fk
  inner join sys.tables fk_tab on fk_tab.object_id = fk.parent_object_id
  inner join sys.tables fk_ref on fk_ref.object_id = fk.referenced_object_id
  inner join sys.foreign_key_columns fk_cols on fk_cols.constraint_object_id = fk.constraint_object_id
  inner join sys.columns fk_col  on fk_col.column_id = fk_cols.parent_column_id and fk_col.object_id = fk_tab.object_id
  inner join sys.columns fk_col2  on fk_col2.column_id = fk_cols.referenced_column_id and fk_col2.object_id = fk.referenced_object_id
  where OBJECT_NAME(fk_tab.object_id)  in( {0} )) as fkTemp2 on Info.TABLE_NAME = fkTemp2.source and  info.COLUMN_NAME = fkTemp2.foreignKey
";
		public static String sSqlForComplexEntitieDescriptions =
@"select distinct * from (select distinct Info.TABLE_NAME as TableName, Info.COLUMN_NAME as ColumnName, Info.IS_NULLABLE isNullable, case when constrainte.CONSTRAINT_NAME is null then 0 else 1 end is_PK, 
		fkTemp2.Target as TargetTableName,  fkTemp2.TargetColumn, DATA_TYPE as ColumnType, fk_col.max_length as ColumnMaxLength, fk_col.precision as ColumnPrecision, fk_col.scale as ColumnScale
from INFORMATION_SCHEMA.COLUMNS Info
left outer join sys.tables pk_tab on pk_tab.name = Info.TABLE_NAME
left outer  join sys.columns fk_col  on fk_col.object_id = pk_tab.object_id and Info.COLUMN_NAME = fk_col.name
left Outer JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE usage  ON Info.TABLE_NAME=usage.TABLE_NAME and Info.COLUMN_NAME=usage.COLUMN_NAME
left outer join INFORMATION_SCHEMA.TABLE_CONSTRAINTS constrainte on  constrainte.CONSTRAINT_NAME =  usage.CONSTRAINT_NAME and constrainte.CONSTRAINT_TYPE='PRIMARY KEY'
left outer join(select distinct    OBJECT_NAME(fk_tab.object_id) as Source, OBJECT_NAME(fk_ref.object_id) as Target , fk_col.name as foreignKey, fk_col2.name as TargetColumn
  from sys.foreign_key_columns fk
  inner join sys.tables fk_tab on fk_tab.object_id = fk.parent_object_id
  inner join sys.tables fk_ref on fk_ref.object_id = fk.referenced_object_id
  inner join sys.foreign_key_columns fk_cols on fk_cols.constraint_object_id = fk.constraint_object_id
  inner join sys.columns fk_col  on fk_col.column_id = fk_cols.parent_column_id and fk_col.object_id = fk_tab.object_id
  inner join sys.columns fk_col2  on fk_col2.column_id = fk_cols.referenced_column_id and fk_col2.object_id = fk.referenced_object_id
  where OBJECT_NAME(fk_tab.object_id)  in( {0} )) as fkTemp2 on Info.TABLE_NAME = fkTemp2.source and  info.COLUMN_NAME = fkTemp2.foreignKey
  where Info.TABLE_NAME in( {0} )
  union 
select distinct Info.TABLE_NAME as TableName, Info.COLUMN_NAME as ColumnName, Info.IS_NULLABLE isNullable, case when constrainte.CONSTRAINT_NAME is null then 0 else 1 end is_PK, 
		fkTemp2.Target as TargetTableName,  fkTemp2.TargetColumn, DATA_TYPE as ColumnType, fk_col.max_length as ColumnMaxLength, fk_col.precision as ColumnPrecision, fk_col.scale as ColumnScale
from INFORMATION_SCHEMA.COLUMNS Info
left outer join sys.tables pk_tab on pk_tab.name = Info.TABLE_NAME
left outer  join sys.columns fk_col  on fk_col.object_id = pk_tab.object_id and Info.COLUMN_NAME = fk_col.name
left Outer JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE usage  ON Info.TABLE_NAME=usage.TABLE_NAME and Info.COLUMN_NAME=usage.COLUMN_NAME
left outer join INFORMATION_SCHEMA.TABLE_CONSTRAINTS constrainte on  constrainte.CONSTRAINT_NAME =  usage.CONSTRAINT_NAME and constrainte.CONSTRAINT_TYPE='PRIMARY KEY'
inner join (select distinct OBJECT_NAME(fk_tab.object_id) as Source, OBJECT_NAME(fk_ref.object_id) as Target
	from sys.foreign_key_columns fk
	inner join sys.tables fk_tab on fk_tab.object_id = fk.parent_object_id
	inner join sys.tables fk_ref on fk_ref.object_id = fk.referenced_object_id
	inner join sys.foreign_key_columns fk_cols on fk_cols.constraint_object_id = fk.constraint_object_id
	inner join sys.columns fk_col  on fk_col.column_id = fk_cols.parent_column_id and fk_col.object_id = fk_tab.object_id
	where OBJECT_NAME(fk_tab.object_id) in( {0} )) as fkTemp on Info.TABLE_NAME = fkTemp.Target
left outer join(select distinct    OBJECT_NAME(fk_tab.object_id) as Source, OBJECT_NAME(fk_ref.object_id) as Target , fk_col.name as foreignKey, fk_col2.name as TargetColumn
  from sys.foreign_key_columns fk
  inner join sys.tables fk_tab on fk_tab.object_id = fk.parent_object_id
  inner join sys.tables fk_ref on fk_ref.object_id = fk.referenced_object_id
  inner join sys.foreign_key_columns fk_cols on fk_cols.constraint_object_id = fk.constraint_object_id
  inner join sys.columns fk_col  on fk_col.column_id = fk_cols.parent_column_id and fk_col.object_id = fk_tab.object_id
  inner join sys.columns fk_col2  on fk_col2.column_id = fk_cols.referenced_column_id and fk_col2.object_id = fk.referenced_object_id
  where OBJECT_NAME(fk_tab.object_id)  in( {0} )) as fkTemp2 on Info.TABLE_NAME = fkTemp2.source and  info.COLUMN_NAME = fkTemp2.foreignKey
Union
select distinct Info.TABLE_NAME as TableName, Info.COLUMN_NAME as ColumnName, Info.IS_NULLABLE isNullable, case when constrainte.CONSTRAINT_NAME is null then 0 else 1 end is_PK, 
		fkTemp2.Target,  fkTemp2.TargetColumn,  DATA_TYPE, fk_col.max_length, fk_col.precision, fk_col.scale
from INFORMATION_SCHEMA.COLUMNS Info
left outer join sys.tables pk_tab on pk_tab.name = Info.TABLE_NAME
left outer  join sys.columns fk_col  on fk_col.object_id = pk_tab.object_id and Info.COLUMN_NAME = fk_col.name
left Outer JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE usage  ON Info.TABLE_NAME=usage.TABLE_NAME and Info.COLUMN_NAME=usage.COLUMN_NAME 
left outer join INFORMATION_SCHEMA.TABLE_CONSTRAINTS constrainte on  constrainte.CONSTRAINT_NAME =  usage.CONSTRAINT_NAME and constrainte.CONSTRAINT_TYPE='PRIMARY KEY'
inner join (select distinct OBJECT_NAME(fk_tab.object_id) as Source, OBJECT_NAME(fk_ref.object_id) as Target --, fk_col.name as fk
	from sys.foreign_key_columns fk
	inner join sys.tables fk_tab on fk_tab.object_id = fk.parent_object_id
	inner join sys.tables fk_ref on fk_ref.object_id = fk.referenced_object_id
	inner join sys.foreign_key_columns fk_cols on fk_cols.constraint_object_id = fk.constraint_object_id
	inner join sys.columns fk_col  on fk_col.column_id = fk_cols.parent_column_id and fk_col.object_id = fk_tab.object_id
	where    OBJECT_NAME(fk_tab.object_id) in ({1})  and OBJECT_NAME(fk_ref.object_id)  in( {0} )) as fkTemp on Info.TABLE_NAME = fkTemp.Source
left outer join(select distinct    OBJECT_NAME(fk_tab.object_id) as Source, OBJECT_NAME(fk_ref.object_id) as Target , fk_col.name as foreignKey, fk_col2.name as TargetColumn
from sys.foreign_key_columns fk
inner join sys.tables fk_tab on fk_tab.object_id = fk.parent_object_id
inner join sys.tables fk_ref on fk_ref.object_id = fk.referenced_object_id
inner join sys.foreign_key_columns fk_cols on fk_cols.constraint_object_id = fk.constraint_object_id
inner join sys.columns fk_col  on fk_col.column_id = fk_cols.parent_column_id and fk_col.object_id = fk_tab.object_id
inner join sys.columns fk_col2  on fk_col2.column_id = fk_cols.referenced_column_id and fk_col2.object_id = fk.referenced_object_id
where  OBJECT_NAME(fk_tab.object_id) in ({1})  and OBJECT_NAME(fk_ref.object_id)  in( {0} )) as fkTemp2 on Info.TABLE_NAME = fkTemp2.source and info.COLUMN_NAME = fkTemp2.foreignKey) generation
order by TableName";

	}
}
