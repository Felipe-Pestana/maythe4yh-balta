CREATE TABLE Movie (
	Id int NOT NULL PRIMARY KEY,
    Title varchar(50) NOT NULL,
	Episode int NOT NULL,
	Opening_crawl  varchar(1000),
	Director varchar(50),
	Producer varchar(152),
	Release_date date NOT NULL,
	Created date NOT NULL,
	Edited date NOT NULL
);


CREATE TABLE Planet(
    Id int NOT NULL PRIMARY KEY,
    Name varchar(50) NOT NULL,
    Rotationperiod float NOT NULL,
    Orbitalperiod int NOT NULL,
    Diameter int NOT NULL,
    Climate varchar(10) NOT NULL,
    Gravity varchar(10) NOT NULL,
    Terrain varchar(10) NOT NULL,
    Surfacewater float NOT NULL,
    Population int NOT NULL,
    Created date NOT NULL,
    Edited date NOT NULL
);

CREATE TABLE Character (
    Id int NOT NULL PRIMARY KEY,
    Name varchar(50) NOT NULL,
    Height float NOT NULL,
    Weight float NOT NULL,
    Haircolor varchar(10) NOT NULL,
    Skincolor varchar(10) NOT NULL,
    Eyecolor varchar(10) NOT NULL,
    Birth_year int,
    Gender varchar(10),
    Id_planet int NOT NULL,
    FOREIGN KEY (Id_planet) REFERENCES Planet(Id)
);

CREATE TABLE Vehicle(
    Id int NOT NULL PRIMARY KEY,
    Model varchar(50) NOT NULL,
    Manufacturer varchar(50) NOT NULL,
    Cost_in_credits float NOT NULL,
    Length float NOT NULL,
    Maxspeed int NOT NULL,
    Crew int NOT NULL,
    Passengers int NOT NULL,
    Cargocapacity float NOT NULL,
    Consumables varchar(50) NOT NULL,
    Class varchar(50) NOT NULL,
    Created date NOT NULL,
    Edited date NOT NULL
);

CREATE TABLE Starship(
    Id int NOT NULL PRIMARY KEY,
    Name varchar(50) NOT NULL,
    Model varchar(50) NOT NULL,
    Manufacturer varchar(50) NOT NULL,
    Cost_in_credits float NOT NULL,
    Length float NOT NULL,
    Maxspeed int NOT NULL,
    Crew int NOT NULL,
    Passengers int NOT NULL,
    Cargocapacity float NOT NULL,
    Hyperdriverating int NOT NULL, 
    Mglt int NOT NULL,
    Consumables varchar(50) NOT NULL,
    Class varchar(50) NOT NULL
);

CREATE TABLE MovieVehicle (
    Id_movie int NOT NULL,
    Id_vehicle int NOT NULL,
    FOREIGN KEY (Id_movie) REFERENCES Movie(Id),
    FOREIGN KEY (Id_vehicle) REFERENCES Vehicle(Id)
);

CREATE TABLE MovieStarship (
    Id_movie int NOT NULL,
    Id_starship int NOT NULL,
    FOREIGN KEY (Id_movie) REFERENCES Movie(Id),
    FOREIGN KEY (Id_starship) REFERENCES Starship(Id)
);

CREATE TABLE MovieCharacter (
    Id_movie int NOT NULL,
    Id_character int NOT NULL,
    FOREIGN KEY (Id_movie) REFERENCES Movie(Id),
    FOREIGN KEY (Id_character) REFERENCES Character(Id)
);

CREATE TABLE MoviePlanet (
    Id_movie int NOT NULL, 
    Id_planet int NOT NULL,
    FOREIGN KEY (Id_movie) REFERENCES Movie(Id),
    FOREIGN KEY (Id_planet) REFERENCES Planet(Id)
);