CREATE DATABASE motel_booking_db;
USE motel_booking_db;

CREATE TABLE customers(
	id VARCHAR(40) PRIMARY KEY,
	username VARCHAR(30) UNIQUE NOT NULL,
	acc_password VARCHAR(255) UNIQUE NOT NULL,
	email VARCHAR(50) UNIQUE NOT NULL,
	NRC VARCHAR(80) UNIQUE NOT NULL,
	ph_number VARCHAR(40) UNIQUE
);


CREATE TABLE administrators(
	id VARCHAR(40) PRIMARY KEY,
	username VARCHAR(30) UNIQUE NOT NULL,
	acc_password VARCHAR(255) UNIQUE NOT NULL
);


CREATE TABLE room_types(
	id int PRIMARY KEY IDENTITY,
	type_description VARCHAR(40) UNIQUE NOT NULL
);

CREATE TABLE rooms(
	id int PRIMARY KEY,
	room_type INT,
	CONSTRAINT FK_rooms_roomType 
		FOREIGN KEY(room_type) 
		REFERENCES room_types(id) 
		ON DELETE CASCADE
);


CREATE TABLE bookings(
	id int PRIMARY KEY IDENTITY,
	room_id INT,
	cus_id VARCHAR(40),
	check_in DATE,
	check_out DATE,
	CONSTRAINT FK_bookings_roomId 
		FOREIGN KEY(room_id)
		REFERENCES rooms(id)  
		ON DELETE CASCADE,
	CONSTRAINT FK_bookings_cusId 
		FOREIGN KEY(cus_id) 
		REFERENCES customers(id)  
		ON DELETE CASCADE
);
