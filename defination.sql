/*

*/
drop database leftover;
CREATE DATABASE leftover;
USE leftover;

CREATE TABLE Userbasictb
(
userid INT(11) NOT NULL AUTO_INCREMENT,
username VARCHAR(20) NOT NULL,
passwd CHAR(20) NOT NULL,
PRIMARY KEY(userid)
);

CREATE TABLE Usertradetb
(
userid INT(11) NOT NULL,
userlevel INT(11) default '0',
certified INT(1) default '0' ,
inrank INT(11) default '0',
outrank INT(11) default '0',
nin INT(11) default '0',
nout INT(11) default '0',
contact VARCHAR(30) NOT NULL,
reliable FLOAT(2,1) default '1.0',
primary key(userid)
);

CREATE TABLE Itemtypetb
(
typeid INT(11) NOT NULL AUTO_INCREMENT,
typename VARCHAR(50) NOT NULL,
basictype VARCHAR(50) NOT NULL,
price INT(11) default '0',
description TEXT,
primary key(typeid)
);

CREATE TABLE Itemtb
(
itemid INT(11) NOT NULL AUTO_INCREMENT ,
itemname VARCHAR(100) NOT NULL UNIQUE,
itemdescribe TEXT NOT NULL ,
depreciation FLOAT(2,2) NOT NULL,
price FLOAT(9,2) NOT NULL,
available INT(1) DEFAULT 1,
typeid INT(11) NOT NULL,
constraint
primary key(itemid),
foreign key (typeid)references Itemtypetb(typeid)
);

CREATE TABLE Commenttb
(
commentid INT(11) NOT NULL,
content TEXT,
score INT(11) NOT NULL,
primary key (commentid)
);

CREATE TABLE Paytb
(
payid INT(11) NOT NULL AUTO_INCREMENT,
cardid VARCHAR(20) NOT NULL,
quickpay INT(1) default '0',
primary key (payid)
);

CREATE TABLE Positiontb
(
positionid INT(11) NOT NULL AUTO_INCREMENT,
postcode VARCHAR(10) NOT NULL,
posdescribe TEXT NOT NULL,
primary key (positionid)
);
CREATE TABLE OrderRecord
(
oid INT(11) NOT NULL AUTO_INCREMENT,
odate DATE DEFAULT NULL,
positionid VARCHAR(200) DEFAULT NULL,
buyerid INT(11) NOT NULL,
itemid INT(11) NOT NULL,
payid VARCHAR(15) default NULL,
primary key(oid)
);

CREATE TABLE Post
(
userid INT(11) NOT NULL ,
itemid INT(11) NOT NULL,
primary key(itemid)
);

CREATE TABLE UserPayment
(
    userid INT(11) NOT NULL ,
    payid INT(11) NOT NULL,
    constraint
    primary key(payid),
    foreign key (userid) references Userbasictb (userid),
    foreign key (payid) references Paytb (payid)
);

CREATE TABLE UserPos
(
    userid INT(11) NOT NULL,
    positionid INT(11) NOT NULL,
    constraint
    foreign key (userid) references Userbasictb (userid),
    foreign key (positionid) references Positiontb (positionid),
    primary key(positionid)
);


CREATE TABLE CartItem
(
    userid INT(11) NOT NULL,
    itemid INT(11) NOT NULL,
     constraint
    foreign key (userid) references Userbasictb (userid),
    foreign key (itemid) references Itemtb (itemid),   
    primary key(userid,itemid)
);

CREATE VIEW Userview AS
SELECT Userbasictb.userid, username, passwd, userlevel, certified, nin, nout, inrank, outrank, contact, reliable
FROM Userbasictb,Usertradetb
WHERE Userbasictb.userid=Usertradetb.userid;

CREATE VIEW Orderview AS
SELECT oid, odate, Userbasictb.username, itemname, price
FROM Itemtb, OrderRecord, Post, Userbasictb
WHERE Itemtb.itemid = OrderRecord.Itemid 
    AND OrderRecord.itemid = Post.itemid 
    AND Post.userid = Userbasictb.userid;

delimiter //
create procedure count_total(userid int)
begin 
    declare total int;
    declare good int;
    SELECT COUNT(*) INTO TOTAL FROM OrderRecord WHERE buyerid = userid;
    SELECT COUNT(*) INTO GOOD FROM commenttb, OrderRecord WHERE commentid = oid AND score = 5 AND buyerid = userid; 
    UPDATE usertradetb SET reliable = (good / total);
END;
//
delimiter ;

delimiter //
create procedure publish(IN itypename VARCHAR(50), IN iitemname VARCHAR(100), IN iprice FLOAT,
    IN idepreciation FLOAT(2,2), IN iitemdescribe TEXT, IN iuserid INT(11))
begin 
    declare newtypeid int;
    declare newitemid int;
    SELECT typeid INTO newtypeid 
    FROM Itemtypetb 
    WHERE typename = itypename;
    
    INSERT INTO Itemtb (itemname,price,typeid,depreciation,itemdescribe,available) 
    VALUES (iitemname, iprice, newtypeid, idepreciation, iitemdescribe, 1);
    
    SELECT itemid INTO newitemid 
    FROM Itemtb 
    WHERE itemname = iitemname;
    
    INSERT INTO Post (userid, itemid) 
    VALUES (iuserid, newitemid);
END;
//
delimiter ;

delimiter //
create procedure addpayment(IN Icardid VARCHAR(100),IN Iquickpay INT(1),IN Iuserid INT(11) ,IN Ipayid INT(11))
BEGIN
    IF(Ipayid != -1)
    THEN 
        UPDATE Paytb SET cardid= Icardid , quickpay = Iquickpay WHERE payid = Ipayid;
    ELSE
        BEGIN
            INSERT INTO paytb (cardid,quickpay) VALUES (Icardid, Iquickpay);
            SELECT payid INTO @R FROM paytb WHERE cardid = icardid  AND quickpay = Iquickpay;
            INSERT INTO Userpayment VALUES (Iuserid ,@R);
        END;
    END IF;
END;
//
delimiter ;


delimiter //
create procedure addposition(IN Iposdescribe TEXT,IN Icode VARCHAR(20),IN Iuserid INT(11) ,IN Iposid INT(11))
BEGIN
    IF(Iposid != -1)
    THEN 
        UPDATE positiontb SET posdescribe = Iposdescribe , postcode = Icode WHERE positionid = Iposid;
    ELSE
        BEGIN
            INSERT INTO positiontb (postcode, posdescribe) VALUES (Icode, Iposdescribe);
            SELECT positionid INTO @R FROM positiontb WHERE posdescribe = Iposdescribe  AND postcode = Icode;
            INSERT INTO Userpos VALUES (Iuserid ,@R);
        END;
    END IF;
END;
//
delimiter ;


delimiter |
CREATE TRIGGER record_trigger BEFORE INSERT ON OrderRecord for each row 
BEGIN
    SET NEW.odate = CURDATE();
    UPDATE Itemtb SET available = 0 WHERE Itemtb.itemid = NEW.itemid;
    UPDATE usertradetb SET nout = nout + 1 WHERE userid IN
    (SELECT userid FROM userpayment WHERE userpayment.payid = NEW.payid);
    UPDATE usertradetb SET nin = nin +1 WHERE userid = NEW.buyerid;
    UPDATE usertradetb SET userlevel = nin/5 WHERE userid = NEW.buyerid;
END;
|
delimiter ;

delimiter |
CREATE TRIGGER comment_trigger AFTER INSERT ON Commenttb for each row 
BEGIN
    declare buyer int;
    SELECT buyerid into buyer FROM OrderRecord WHERE oid = NEW.commentid;
    CALL count_total(buyer);
END;
|
delimiter ;



