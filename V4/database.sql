DROP DATABASE IF EXISTS J;
CREATE DATABASE J;
USE J;
CREATE TABLE Jugador (
	Identificador INTEGER PRIMARY KEY NOT NULL,
	Nombre TEXT NOT NULL,
	Contrasena TEXT NOT NULL,
        DNI TEXT NOT NULL
	)ENGINE = InnoDB;

INSERT INTO Jugador VALUES(1,'arnau12','arnau12','1111111D');
INSERT INTO Jugador VALUES(2,'Martin','Martin1','2222222B');
INSERT INTO Jugador VALUES(3,'Vector','Vector','3333333R');
INSERT INTO Jugador VALUES(4,'Lewis','Lewis','4444444L');
INSERT INTO Jugador VALUES(5,'Julian','Julian','5555555T');

CREATE TABLE Partida (
	Identificador INTEGER PRIMARY KEY NOT NULL,
	Fecha TEXT NOT NULL,
	Duracion INTEGER NOT NULL,
	Ganador INTEGER NOT NULL,
	FOREIGN KEY (Ganador) REFERENCES Jugador(Identificador)
	)ENGINE = InnoDB;

INSERT INTO Partida VALUES(1,'12/01/2003',15,1);
INSERT INTO Partida VALUES(2,'29/02/2023',6,3);
INSERT INTO Partida VALUES(3,'31/08/2005',21,2);
INSERT INTO Partida VALUES(4,'31/08/2010',34,5);
INSERT INTO Partida VALUES(5,'01/01/1960',20,4);
INSERT INTO Partida VALUES(6,'02/01/1960',20,4);

CREATE TABLE Participacion (
	Jugador INTEGER NOT NULL,
	Partida INTEGER NOT NULL,
	Puntos INTEGER NOT NULL,
	FOREIGN KEY (Jugador) REFERENCES Jugador(Identificador),
	FOREIGN KEY (Partida) REFERENCES Partida(Identificador)
	)ENGINE = InnoDB;
							   

INSERT INTO Participacion VALUES(1,1,10);
INSERT INTO Participacion VALUES(3,1,5);
INSERT INTO Participacion VALUES(4,2,0);
INSERT INTO Participacion VALUES(1,2,10);
INSERT INTO Participacion VALUES(2,3,0);
INSERT INTO Participacion VALUES(5,3,10);
INSERT INTO Participacion VALUES(4,4,10);
INSERT INTO Participacion VALUES(5,4,10);
INSERT INTO Participacion VALUES(3,5,10);
INSERT INTO Participacion VALUES(2,5,5);

