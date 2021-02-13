USE MASTER
create DATABASE MedicHelpperBDD
GO
USE MedicHelpperBDD
GO
CREATE TABLE TipoUsuario(
IdTipoUsuario INT IDENTITY(0,1) PRIMARY KEY,
TipoUsuario VARCHAR(25) NOT NULL,
DescipcionTipoUsuario VARCHAR(255)
)
GO
--Insercion en tipos de usuarios
insert into TipoUsuario VALUES('Administrador','Posee todos los permisos dentro del software')
insert into TipoUsuario VALUES('Enfermeria','Encargado de la administración de citas')
insert into TipoUsuario VALUES('Dotores','Encargado de atender a los pacientes en sus consultas')
insert into TipoUsuario VALUES('Farmaceutico','Encargado de la administración de la farmacia')
---
CREATE TABLE Usuarios(
IdUsuario CHAR(6) PRIMARY KEY,
Contraseña VARCHAR(75) NOT NULL,
Nombre VARCHAR(75) NOT NULL,
Apellido VARCHAR(75) NOT NULL,
FechaDeNacimiento DATE NOT NULL,
DUI CHAR(9) NOT NULL UNIQUE,
IdTipoUsuarioUsusarios INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario) ON DELETE CASCADE ON UPDATE CASCADE
)
GO
INSERT INTO Usuarios VALUES ('AA0001','password','Admin','Admin','1-10-2020','123456789','0'),
('EE0001','password','Enfermeria','Enfermeria','1-10-2020','234567890','1'),
('DD0001','password','Dotores','Dotores','1-10-2020','345678901','2'),
('FF0001','password','Farmaceutico','Farmaceutico','1-10-2020','456789012','3');

CREATE TABLE Pacientes(
IdPaciente CHAR(6) PRIMARY KEY,
Nombre VARCHAR(75) NOT NULL,
Apellido VARCHAR(75) NOT NULL,
FechaDeNacimiento DATE NOT NULL
)
GO
CREATE TABLE Cita(
idCita INT IDENTITY PRIMARY KEY,
IdPacienteCita CHAR(6) FOREIGN KEY REFERENCES Pacientes(IdPaciente) ON DELETE CASCADE ON UPDATE CASCADE,
FechaCita DATETIME,
Estado INT NOT NULL CONSTRAINT CK_EstadoCita CHECK ((Estado = 1) OR (Estado = 0))
)
GO
CREATE TABLE Medicamentos(
[Codigo de Medicamento] INT IDENTITY(0,1) PRIMARY KEY,
Nombre VARCHAR(75) NOT NULL,
Descripcion VARCHAR(255) NOT NULL,
FechaExpiracion DATE NOT NULL,
Ubicacion VARCHAR(100) NOT NULL,
Cantidad INT
)
GO
CREATE TABLE Consulta(
IdConsulta INT IDENTITY(0,1) PRIMARY KEY,
CodReceta INT UNIQUE,
IdUsuarioConsulta CHAR(6) FOREIGN KEY REFERENCES Usuarios(IdUsuario) ON DELETE CASCADE ON UPDATE CASCADE,
idCita INT FOREIGN KEY REFERENCES Cita(idCita) ON DELETE CASCADE ON UPDATE CASCADE,
Descripcion VARCHAR(255) NOT NULL,
Fecha DATETIME NOT NULL
)
GO
---RECETA MEDICA
CREATE TABLE Receta(
IdConsultaReceta INT FOREIGN KEY REFERENCES Consulta(IdConsulta),
DescripcionReceta VARCHAR(255) NOT NULL,
Estado INT NOT NULL CONSTRAINT CK_EstadoReceta CHECK ((Estado = 1) OR (Estado = 0))
)
GO
ALTER TABLE Pacientes add constraint CK_CodigoPaciente
CHECK (IdPaciente LIKE 'P[0-9][0-9][0-9][0-9][0-9]')
GO


--PROCEDIMIENTOS ALMACENADOS
CREATE PROCEDURE SP_MostrarPacientes
AS
SELECT pacien.IdPaciente ,pacien.Nombre, pacien.Apellido, pacien.FechaDeNacimiento
FROM Pacientes pacien 
GO

--Procedimiento BusquedaDeMedicamentos
CREATE PROCEDURE BMD_Medicamento
AS
SELECT * FROM Medicamentos 
GO
--Procedimiento para saber si un paciente ya tiene una cita pra el mismo momento
CREATE TRIGGER TriggerCita ON dbo.Cita
AFTER INSERT
AS
if exists ( select * from  Cita c
       inner join inserted i on i.IdPacienteCita = c.IdPacienteCita and i.FechaCita=c.FechaCita and i.idCita <> c.idCita)
begin
       rollback
       RAISERROR ('Duplicate Data', 16, 1);
end
GO
