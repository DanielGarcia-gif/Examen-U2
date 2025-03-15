CREATE DATABASE
Agenda

USE Agenda

--Usuarios
CREATE TABLE USUARIOS
(
	ID			int identity(100,1) primary key not null ,
	APATERNO	varchar(50) not null,
	AMATERNO	varchar(50) not null,
	NOMBRE		varchar(100) not null,
	TELEFONO	varchar(10),
	CORREO		varchar(100)
)

DROP TABLE usuarios

INSERT INTO USUARIOS (APATERNO, AMATERNO, NOMBRE, TELEFONO, CORREO) 
VALUES 
('García', 'López', 'Juan', '8711234567', 'juan.garcia@gmail.com'),
('Martínez', 'Hernández', 'Ana', '8719876543', 'ana.martinez@gmail.com'),
('Rodríguez', 'Gómez', 'Carlos', '8712345678', 'carlos.rodriguez@gmail.com'),
('Fernández', 'Díaz', 'María', '8718765432', 'maria.fernandez@gmail.com'),
('Pérez', 'Sánchez', 'Luis', '8713456789', 'luis.perez@gmail.com'),
('Gómez', 'Torres', 'Laura', '8717654321', 'laura.gomez@gmail.com'),
('Sánchez', 'Ramírez', 'David', '8714567890', 'david.sanchez@gmail.com'),
('Díaz', 'Vargas', 'Sofía', '8716789012', 'sofia.diaz@gmail.com'),
('Hernández', 'Mendoza', 'Javier', '8715678901', 'javier.hernandez@gmail.com'),
('Torres', 'Ortega', 'Elena', '8717890123', 'elena.torres@gmail.com');
