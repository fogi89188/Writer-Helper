CREATE DATABASE writerhelper;
USE writerhelper;

SHOW TABLES;

CREATE TABLE IF NOT EXISTS Users (
id INT(16) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
email VARCHAR(100) NOT NULL,
password VARCHAR(256),
isAdmin BOOL
);

CREATE TABLE IF NOT EXISTS Names (
id INT(16) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
firstName VARCHAR(50),
race VARCHAR(50),
sex VARCHAR(10)
);

CREATE TABLE IF NOT EXISTS Favourites (
id INT(16) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
email VARCHAR(100) NOT NULL,
firstName VARCHAR(50),
race VARCHAR(50),
sex VARCHAR(10)
);

CREATE TABLE IF NOT EXISTS Suggestions (
id INT(16) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
firstName VARCHAR(50),
race VARCHAR(50),
sex VARCHAR(10)
);

SET SQL_SAFE_UPDATES = 0;
DELETE FROM names;
SET SQL_SAFE_UPDATES = 1;

INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Joshua', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Jeremy', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Denis', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Petrov', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Viktor', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Nikola', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Osborne', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Alex', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Aleks', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Atanas', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Gosho', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Pesho', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Miroslav', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Georgi', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Velizar', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Velin', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Venelin', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Valentin', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Daniel', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Bobby', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Boris', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Borislav', 'Human', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Emil', 'Human', 'male');

INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Elise', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Ysdra', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Tess', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Esvele', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Elena', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Leah', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Brandy', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Sonar', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Nyx', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Nox', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Violet', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Allura', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Lura', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Cindy', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Tiamat', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Sarah', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Stacy', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Sindragosa', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Noah', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Sofia', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Stela', 'Human', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Anna', 'Human', 'female');

INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Folas', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Urifir', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Eriladar', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Biren', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Marikoth', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Omayarus', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Yhendorn', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Virmenor', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Kiirion', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Umecyne', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Tanithil', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Ralolynn', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Aywin', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Beiwarin', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Sylvar', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Uriyra', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Castien', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Valnelis', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Iolrath', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Zumfir', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Rolim', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Inapetor', 'Elf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Kesefeon', 'Elf', 'male');

INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Halaema', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Wranrel', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Eirina', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Zyldithas', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Eshenesra', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Keytris', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Penelo', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Ergolor', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Ciradyl', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Zyljyre', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Eliyen', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Leomaris', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Myantha', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Orifiel', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Alavara', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Caimaris', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Halaema', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Neristina', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Isarrel', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Zinjor', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Ochilysse', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Kelna', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Jeardra', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Vaynore', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Maeralya', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Engeiros', 'Elf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Lazziar', 'Elf', 'female');

INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Gindatir', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Aletank', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Grumblegrog', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Broukoid', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Brewfall', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Bordret', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Trollback', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Yurdaer', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Onyxhead', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Berylthane', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Bonehorn', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Doraldrouck', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Rubysword', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Webrat', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Forgebeard', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Datdrous', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Earthpike', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Momrac', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Iceback', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Dabramri', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Goldenfoot', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Kalik', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Mudforged', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Thrandel', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Broadbrand', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Holgreth', 'Dwarf', 'male');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Goldenbraid', 'Dwarf', 'male');

INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Danwamora', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Silverbane', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Flintsword', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Windgut', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Noblethane', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Chainstone', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Barbeddelver', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Blessedmaster', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Berylguard', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Largebane', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Hammerbraid', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Dedola', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Krovrahilda', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Khurnutryd', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Grabungrid', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Yuwaegret', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Kirdrutaine', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Groorgeabelyn', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Netolydd', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Raddusli', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Greythane', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Icefury', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Boneheart', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Nurargregit', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Broulaelda', 'Dwarf', 'female');
INSERT INTO `writerhelper`.`names` (`firstName`, `race`, `sex`) VALUES ('Sizneginn', 'Dwarf', 'female');


INSERT INTO `writerhelper`.`suggestions` (`firstName`, `race`, `sex`) VALUES ('David', 'Human', 'Male');
INSERT INTO `writerhelper`.`suggestions` (`firstName`, `race`, `sex`) VALUES ('Xerlay', 'Elf', 'Female');