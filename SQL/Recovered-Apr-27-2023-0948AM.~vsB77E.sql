INSERT INTO client_master (client_no, Name_emp,address1,address2, city, pin, state_emp, baldue) VALUES ('C00001', 'Ivan Bayross','','', 'Mumbai', 400054, 'Maharashtra', 15000); 
INSERT INTO PRODUCT_MASTER (productno,description,profitperc,unitmeasure,qtyonhand,reorderlvl,sellprice,costprice) VALUES ('P00001', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250); 
INSERT INTO SALESMANMaster (salesmanno,salesmanname,address1,address2,city,pincode,state,salamt,tgttoget,ytdsales,remarks) VALUES ('S00001', 'Aman', 'A/14', 'Worli', 'Mumbai', 400002, 'Maharashtra', 3000, 100, 50, 'Good'); 
INSERT INTO SALESORDER(orderno,clientno, orderdate,delyaddr,salesmanno, delytype, billedyn, delydate, orderstatus) 
 VALUES('O19001',  'C00001','12-june-02','','S00001', 'F', ' N', '20-july-02', 'In Process'); 
INSERT INTO SALESORDERDETAILS (orderno, productno, qtyordered, qtydisp, productrate) VALUES('O19001', 'P00001', 4, 4, 525);