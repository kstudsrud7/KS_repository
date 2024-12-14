-- Query to get table names, row counts, sizes, and comments
SELECT 
    t.NAME AS TableName,
    s.Name AS SchemaName,
    p.rows AS RecordCount,
    CAST(ROUND(((SUM(a.total_pages) * 8.0) / 1024.0), 2) AS NUMERIC(18, 2)) AS SizeInMB,
    CAST(ROUND(((SUM(a.used_pages) * 8.0) / 1024.0), 2) AS NUMERIC(18, 2)) AS DataSizeInMB,
    CAST(ROUND(((SUM(a.total_pages - a.used_pages) * 8.0) / 1024.0), 2) AS NUMERIC(18, 2)) AS IndexSizeInMB,
    EP.value AS TableComment
FROM 
    sys.tables t
INNER JOIN 
    sys.schemas s ON t.schema_id = s.schema_id
INNER JOIN 
    sys.indexes i ON t.OBJECT_ID = i.object_id
INNER JOIN 
    sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id
INNER JOIN 
    sys.allocation_units a ON p.partition_id = a.container_id
LEFT JOIN 
    sys.extended_properties EP ON t.object_id = EP.major_id 
                                AND EP.minor_id = 0 
                                AND EP.name = 'Comment' -- Extended property for table description
WHERE 
    t.is_ms_shipped = 0 -- Exclude system tables 
GROUP BY 
    t.Name, s.Name, p.Rows, EP.value
ORDER BY 
    SizeInMB DESC; -- Orders the result by size (optional)
