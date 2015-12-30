
use leftover;
insert into userbasictb (username, passwd) values ("001", "11111");
insert into usertradetb (userid, contact) values (1, "13240326786");
insert into paytb (cardid,quickpay) values ("13061156",1);
insert into userpayment (userid, payid) values (1, 1);
insert into itemtypetb (typename, basictype,price) values("电烤箱", "家用电器",600);
insert into itemtb (itemname, depreciation, itemdescribe, price, typeid)
 values ("32L家用电烤箱", .8, "1、32L家用最佳容量，红色面板，高档大气；
2、4根电热管立方体上下对称发热内腔，空间更合理，受热更均匀
3、多层烤架轨道设置，更多DIY选择；
4、特设腔内照明功能，食物烤制过程一目了然。
5、简洁功能面板及清晰的独立功能操作旋钮，使用更便捷；
6、五大全能烘烤（上火、下火、烘烤、旋转烤、发酵/解冻）功能选择，120分钟超长定时，让烹饪随心所欲；
7、全温区功能设置，精准低温控制，轻松实现解冻、发酵功能；
8、上下管独立控温装置，能根据不同烘烤设置，实现精准控温；
9、多面散热孔设计，有效保持机身合理温度，避免机体损坏，延长使用时间；
10、机体背部特设靠墙顶角，预留有效散热空间，顶角电木材质，绝缘耐热、耐腐蚀", 319.00, 1);
insert into itemtypetb (typename ,basictype,price) values("吹风机","家用电器",180);
insert into itemtypetb (typename,basictype,price) values("发夹","钟表、首饰",39);
insert into itemtb(itemname,depreciation,itemdescribe,price,typeid)
values ("Panasonic 松下 电烤箱 NB-H3200 ",0.6,"品牌：松下
外观颜色：银黑色
类别：机械版
外观式样：台式
外观材质：电镀钢板
容量：32L
定时功能：支持
温度调节：支持
内胆材质：电镀钢板
开门方式：下开门
温控形式：机械温控器
加热方式：发热管加热
温控范围（℃）：30~230
定时范围（分钟）：0~120
额定电压：220v
额定功率（w）：1500",810,1);
insert into itemtb (itemname,depreciation,itemdescribe,price,typeid)
values ("Midea/美的 MG25NF-AD小烤箱家用",0.5,"披萨盘和托盘还有托网都是铝制品",199.90,1);
insert into itemtb(itemname,depreciation,itemdescribe,price,typeid)
values("飞科 电吹风",0.6,"品牌：飞科
型号：FH6257
便携性能：手柄可折叠
最大功率：1200W
颜 色：白色
档 位：2档
功 能：恒温冷热风
风嘴样式：整发风嘴 ",29,2);
insert into itemtb(itemname,depreciation,itemdescribe,price,typeid)
values("she s茜子正品发饰 She's抓夹",0.3,"水钻小号刘海夹发夹发抓夹子顶夹 ",20,3);
insert into positiontb (postcode,posdescribe) values ("100191","北京航空航天大学");
insert into userpos (userid,positionid) values (1,1);
insert into post (userid,itemid) values(1,1);
insert into post (userid,itemid) values(1,2);
insert into post (userid,itemid) values(1,3);
insert into post (userid,itemid) values(1,4);
insert into post (userid,itemid) values(1,5);







