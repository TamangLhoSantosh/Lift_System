create database Lift_Management_System;

use Lift_Management_System;

create table lift_logs(
	id int not null,
    message varchar(80) not null,
    created timestamp not null default current_timestamp
);

alter table lift_management_system
add constraint pk_pid
primary key(id);

alter table lift_management_system
modify column id int auto_increment;

INSERT INTO lift_logs (id, message, created) VALUES
(1, 'Log message 1', '2023-10-30 08:00:00');
