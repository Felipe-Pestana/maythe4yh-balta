CREATE TABLE Movie (
	id int NOT NULL PRIMARY KEY,
    title varchar(50) NOT NULL,
	episode int NOT NULL,
	opening_crawl varchar(1000),
	director varchar(50),
	producer varchar(152),
	release_date date NOT NULL,
	created date NOT NULL,
	edited date NOT NULL,
	url varchar(50) NOT NULL
);


CREATE TABLE Planet(
    id int NOT NULL PRIMARY KEY,
    name varchar(50) NOT NULL,
    rotationperiod float NOT NULL,
    orbitalperiod int NOT NULL,
    diameter int NOT NULL,
    climate varchar(10) NOT NULL,
    gravity varchar(10) NOT NULL,
    terrain varchar(10) NOT NULL,
    surfacewater float NOT NULL,
    population int NOT NULL,
    created date NOT NULL,
    edited date NOT NULL,
    url varchar(50) NOT NULL
);

CREATE TABLE Character (
    id int NOT NULL PRIMARY KEY,
    name varchar(50) NOT NULL,
    height float NOT NULL,
    weight float NOT NULL,
    haircolor varchar(10) NOT NULL,
    skincolor varchar(10) NOT NULL,
    eyecolor varchar(10) NOT NULL,
    birth_year int,
    gender varchar(10),
    id_planet int NOT NULL,
    FOREIGN KEY (id_planet) REFERENCES Planet(id)
);

CREATE TABLE Vehicle(
    id int NOT NULL PRIMARY KEY,
    model varchar(50) NOT NULL,
    manufacturer varchar(50) NOT NULL,
    cost_in_credits float NOT NULL,
    length float NOT NULL,
    maxspeed int NOT NULL,
    crew int NOT NULL,
    passengers int NOT NULL,
    cargocapacity float NOT NULL,
    consumables varchar(50) NOT NULL,
    class varchar(50) NOT NULL,
    created date NOT NULL,
    edited date NOT NULL,
    url varchar(50) NOT NULL
);

CREATE TABLE Starship(
    id int NOT NULL PRIMARY KEY,
    name varchar(50) NOT NULL,
    model varchar(50) NOT NULL,
    manufacturer varchar(50) NOT NULL,
    cost_in_credits float NOT NULL,
    length float NOT NULL,
    maxspeed int NOT NULL,
    crew int NOT NULL,
    passengers int NOT NULL,
    cargocapacity float NOT NULL,
    hyperdriverating int NOT NULL, 
    MGLT int NOT NULL,
    consumables varchar(50) NOT NULL,
    class varchar(50) NOT NULL
);

CREATE TABLE MovieVehicle (
    id_movie int NOT NULL,
    id_vehicle int NOT NULL,
    FOREIGN KEY (id_movie) REFERENCES Movie(id),
    FOREIGN KEY (id_vehicle) REFERENCES Vehicle(id)
);

CREATE TABLE MovieStarship (
    id_movie int NOT NULL,
    id_starship int NOT NULL,
    FOREIGN KEY (id_movie) REFERENCES Movie(id),
    FOREIGN KEY (id_starship) REFERENCES Starship(id)
);

CREATE TABLE MovieCharacter (
    id_movie int NOT NULL,
    id_character int NOT NULL,
    FOREIGN KEY (id_movie) REFERENCES Movie(id),
    FOREIGN KEY (id_character) REFERENCES Character(id)
);

CREATE TABLE MoviePlanet (
    id_movie int NOT NULL, 
    id_planet int NOT NULL,
    FOREIGN KEY (id_movie) REFERENCES Movie(id),
    FOREIGN KEY (id_planet) REFERENCES Planet(id)
);