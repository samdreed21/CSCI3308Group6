create table if not exists `Class_Data` (
 `Term_Year` int(1) not null auto_increment,
 `Department` varchar(40) not null,
 `Course_Number` int(1) not null,
 `Number_Enrolled` float not null,
 'Percent_A' float not null,
 'Percent_B' float not null,
 'Hours_per_week' int(1) not null,
 'Average_Course_Rating' float not null,
 'Average_Instructor_Rating' float not null,
 primary key (`Course Number`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=7;
insert into `Class_Data` (`Term_Year`, `Department`, `Course_number`, `Number_Enrolled`,'Percent_A','Percent_B','Hours_per_week','Average_Course_Rating','Average_Instructor_Rating') values
 