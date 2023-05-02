INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00001', 'Ivan Bayross', 'Mumbai', 400054, 'Maharashtra', 15000);

INSERT INTO Product_Master VALUES ('P00001', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250);

INSERT INTO Salesman_Master VALUES ('S00001', 'Aman', 'A/14', 'Worli', 'Mumbai', 400002, 'Maharashtra', 3000, 100, 50, 'Good');

INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BILLENDYN, SalesmanNo, DelyDate, OrderStatus)

VALUES('O19001', '12-june-02', 'C00001', '', 'N', 'S00001', '20-july-02', 'In Process');

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19001', 'P00001', 4, 4, 525);

SELECT * FROM SALES_ORDER

INSERT INTO Sales_Order (ORDERNO,ORDERDATE, CLIENTNO,DELYTYPE, BILLENDYN, SALESMANNO, DELYDATE, ORDERSTATUS)

VALUES('O19001', '12-june-02', 'C00001', 'S', 'N', 'S00001', '20-july-02', 'Process');