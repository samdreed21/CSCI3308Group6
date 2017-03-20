create table if not exists `ProjectData` (	
 `id` int(1) not null auto_increment,
 `Term_Year` int(1) not null,
 `Department` varchar(40) not null,
 `Course_Number` int(1) not null,
 `Number_Enrolled` float not null,
 `Average_Grade` float not null,
 `Percent_A` float not null,
 `Percent_B` float not null,
 `Hours_per_week` int(1) not null,
 `Average_Course_Rating` float not null,
 `Average_Instructor_Rating` float not null,
 primary key (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=7;
insert into `ProjectData` (`id`,`Term_Year`, `Department`, `Course_Number`, `Number_Enrolled`,`Average_Grade`,`Percent_A`,`Percent_B`,`Hours_per_week`,`Average_Course_Rating`,`Average_Instructor_Rating`) values
(1,20067,'CSCI',1200,61,2.6,2.63,38,26,3.41,3.64),
(2,20067,'CSCI',1300,25,3.2,2.55,28,38,4.59,5.00);
