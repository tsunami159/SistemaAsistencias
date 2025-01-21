CREATE DATABASE Asistencias;

USE Asistencias;


CREATE TABLE Usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,  
    correo_electronico VARCHAR(100) NOT NULL, 
    telefono VARCHAR(15),  --
    tipo_usuario VARCHAR(50),  
    fecha_registro DATE NOT NULL DEFAULT GETDATE() 
);

CREATE TABLE Asistencias (
    id_asistencia INT IDENTITY(1,1) PRIMARY KEY,  
    id_usuario INT,  
    fecha DATE NOT NULL,  
    hora_entrada TIME(0),
    hora_salida TIME(0), 
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario) 
);


INSERT INTO Usuarios (nombre, correo_electronico, telefono, tipo_usuario)
VALUES 
    ('Laura Martínez', 'laura.martinez@gmail.com', '5566778899', 'empleado'),
    ('Pedro Ramírez', 'pedro.ramirez@gmail.com', '6677889900', 'estudiante'),
    ('Marta Sánchez', 'marta.sanchez@gmail.com', '7788990011', 'empleado'),
    ('Luis Torres', 'luis.torres@gmail.com', '8899001122', 'empleado'),
    ('Claudia Ortiz', 'claudia.ortiz@gmail.com', '9900112233', 'empleado'),
    ('Hugo Castillo', 'hugo.castillo@gmail.com', '1011121314', 'empleado'),
    ('Sofía Ruiz', 'sofia.ruiz@gmail.com', '1112131415', 'estudiante'),
    ('Diego Fernández', 'diego.fernandez@gmail.com', '1213141516', 'empleado'),
    ('Isabel García', 'isabel.garcia@gmail.com', '1314151617', 'empleado'),
    ('Javier Moreno', 'javier.moreno@gmail.com', '1415161718', 'empleado'),
    ('Sara Vega', 'sara.vega@gmail.com', '1516171819', 'estudiante'),
    ('David Ramos', 'david.ramos@gmail.com', '1617181920', 'empleado'),
    ('Paula Herrera', 'paula.herrera@gmail.com', '1718192021', 'empleado'),
    ('Andrés Rojas', 'andres.rojas@gmail.com', '1819202122', 'empleado'),
    ('Gloria Díaz', 'gloria.diaz@gmail.com', '1920212223', 'empleado'),
    ('Víctor Muñoz', 'victor.munoz@gmail.com', '2021222324', 'estudiante'),
    ('Julia Navarro', 'julia.navarro@gmail.com', '2122232425', 'empleado'),
    ('Pablo Medina', 'pablo.medina@gmail.com', '2223242526', 'empleado'),
    ('Teresa Flores', 'teresa.flores@gmail.com', '2324252627', 'empleado'),
    ('Ricardo Soto', 'ricardo.soto@gmail.com', '2425262728', 'empleado'),
    ('Carmen Reyes', 'carmen.reyes@gmail.com', '2526272829', 'empleado'),
    ('Mario Aguilar', 'mario.aguilar@gmail.com', '2627282930', 'estudiante'),
    ('Natalia Vargas', 'natalia.vargas@gmail.com', '2728293031', 'empleado'),
    ('Álvaro Delgado', 'alvaro.delgado@gmail.com', '2829303132', 'empleado'),
    ('Victoria León', 'victoria.leon@gmail.com', '2930313233', 'empleado'),
    ('Roberto Guzmán', 'roberto.guzman@gmail.com', '3031323334', 'empleado'),
    ('Gabriela Romero', 'gabriela.romero@gmail.com', '3132333435', 'empleado');

	INSERT INTO Asistencias (id_usuario, fecha, hora_entrada, hora_salida)
VALUES
    (1, '2025-01-19', '08:00:00', '17:00:00'),
    (2, '2025-01-19', '08:30:00', '16:30:00'),
    (3, '2025-01-19', '09:00:00', '15:00:00'),
    (4, '2025-01-19', '07:45:00', '16:15:00'),
    (5, '2025-01-19', '08:15:00', '16:45:00'),
    (6, '2025-01-19', '09:10:00', '15:40:00'),
    (7, '2025-01-19', '08:50:00', '17:20:00'),
    (8, '2025-01-19', '09:05:00', '16:35:00'),
    (9, '2025-01-19', '07:30:00', '14:30:00'),
    (10, '2025-01-19', '08:00:00', '15:00:00'),
    (11, '2025-01-19', '08:10:00', '16:10:00'),
    (12, '2025-01-19', '08:20:00', '17:20:00'),
    (13, '2025-01-19', '08:30:00', '16:30:00'),
    (14, '2025-01-19', '08:40:00', '16:40:00'),
    (15, '2025-01-19', '08:50:00', '16:50:00'),
    (16, '2025-01-19', '09:00:00', '17:00:00'),
    (17, '2025-01-19', '09:10:00', '17:10:00'),
    (18, '2025-01-19', '09:20:00', '17:20:00'),
    (19, '2025-01-19', '09:30:00', '17:30:00'),
    (20, '2025-01-19', '09:40:00', '17:40:00'),
    (21, '2025-01-19', '09:50:00', '17:50:00'),
    (22, '2025-01-19', '10:00:00', '18:00:00'),
    (23, '2025-01-19', '10:10:00', '18:10:00'),
    (24, '2025-01-19', '10:20:00', '18:20:00'),
    (25, '2025-01-19', '10:30:00', '18:30:00'),
    (26, '2025-01-19', '10:40:00', '18:40:00'),
    (27, '2025-01-19', '10:50:00', '18:50:00'),
    (28, '2025-01-19', '11:00:00', '19:00:00'),
    (29, '2025-01-19', '11:10:00', '19:10:00'),
    (30, '2025-01-19', '11:20:00', '19:20:00');
