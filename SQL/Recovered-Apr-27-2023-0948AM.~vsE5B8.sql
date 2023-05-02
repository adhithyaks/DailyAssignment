-- Local variables
DECLARE @order_num INT;
-- Define the cursor
DECLARE orders_cursor CURSOR
FOR
SELECT order_num FROM orders ORDER BY order_num;
-- Open cursor (retrieve data)
OPEN orders_cursor;
-- Perform the first fetch (get first row)
FETCH NEXT FROM orders_cursor INTO @order_num;
-- Close cursor
CLOSE orders_cursor
-- And finally, remove it
DEALLOCATE orders_cursor;
