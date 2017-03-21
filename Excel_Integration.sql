create table if not exists `ProjectData` (
 `id` int(1) not null auto_increment,	
 `Term_Year` int(5) not null,
 `Department` varchar(40) not null,
 `Course_Number` int(5) not null,
 `Number_Enrolled` float not null,
 `Average_Grade` float not null,
 `Percent_A` float not null,
 `Percent_B` float not null,
 `Hours_per_week` varchar(40) not null,
 `Average_Course_Rating` float not null,
 `Average_Instructor_Rating` float not null,
 primary key (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=7;
load data infile '/var/lib/mysql-files/test1.csv' into table ProjectData
fields terminated by',';
