DELIMITER $$
	CREATE PROCEDURE insertarGeneros(IN nombre varchar(20))
	BEGIN
		INSERT INTO generos VALUES(DEFAULT, nombre);
	END$$

DELIMITER $$
CREATE PROCEDURE insertarPelicula(IN nombre varchar(20), descripcion varchar(300), imagen BLOB)
BEGIN
	INSERT INTO peliculas VALUES(DEFAULT,nombre,descripcion,imagen);
END$$

DELIMITER $$
CREATE PROCEDURE insertarActor(IN nombre varchar(50))
BEGIN
    INSERT INTO actores VALUES(DEFAULT,nombre);
END $$

DELIMITER $$
CREATE PROCEDURE insertarDirector(IN nombre varchar(50))
BEGIN
    INSERT INTO directores VALUES(DEFAULT,nombre);
END $$

DELIMITER $$
CREATE PROCEDURE insertarPlataforma(nombre varchar(50))
BEGIN
    INSERT INTO plataformas VALUES(DEFAULT,nombre);
END $$

DELIMITER $$
CREATE PROCEDURE insertarTipo(IN nombre varchar(13))
BEGIN
    INSERT INTO tipos VALUES(DEFAULT,nombre);
END $$

DELIMITER $$
CREATE PROCEDURE insertarDistribucion(IN precio int,calidad varchar(5),tipo int)
BEGIN
    INSERT INTO distribuciones VALUES(DEFAULT,precio,calidad,tipo);
END $$

DELIMITER $$
CREATE PROCEDURE insertarUsuario(IN nombre varchar(20) , contrasena varchar (20))
BEGIN
    INSERT INTO usuarios VALUES(DEFAULT,nombre,contrasena,false);
END $$

DELIMITER $$
CREATE PROCEDURE insertarComentario(IN idUsuario int,comentario varchar(300), idPelicula int)
BEGIN
    INSERT INTO comentarios VALUES(DEFAULT,idUsuario,comentario,idPelicula);
END $$

DELIMITER $$
CREATE PROCEDURE insertarInterpretes(IN idActor int,idPelicula int)
BEGIN
    INSERT INTO directores VALUES(DEFAULT,idActor,idPelicula);
END $$

DELIMITER $$
CREATE PROCEDURE insertarCordinadores(IN idPelicula int,idDirector int)
BEGIN
    INSERT INTO directores VALUES(DEFAULT,idPelicula ,idDirector);
END $$

DELIMITER $$
CREATE PROCEDURE insertarContine(IN idPelicula int,idGenero int)
BEGIN
    INSERT INTO directores VALUES(DEFAULT,idPelicula ,idGenero);
END $$

DELIMITER $$
CREATE PROCEDURE insertarServicios(IN idPlataforma int, idDistribucion int)
BEGIN
    INSERT INTO directores VALUES(DEFAULT,idPlataforma ,idDistribucion);
END $$

DELIMITER $$
CREATE PROCEDURE insertarCategoria(IN idPelicula int,idGenero int)
BEGIN
    INSERT INTO directores VALUES(DEFAULT,idPelicula ,idGenero);
END $$

DELIMITER $$
CREATE PROCEDURE mostrarGeneros(IN idPelicula int)
BEGIN
    SELECT generos.nombreGenero FROM generos
	INNER JOIN categorias ON generos.idgenero = categorias.idgenero 
	INNER JOIN peliculas ON categorias.idpelicula = peliculas.idpelicula
	WHERE peliculas.idpelicula = idPelicula;
END $$

DELIMITER $$
CREATE PROCEDURE mostrarPlataformas(IN idPelicula int)
BEGIN
    SELECT plataformas.nombrePlataforma FROM plataformas
	INNER JOIN contiene ON plataformas.idPlataforma = contiene.idplataforma 
	INNER JOIN peliculas ON contiene.idpelicula = peliculas.idpelicula
	WHERE peliculas.idpelicula = idPelicula;
END $$

DELIMITER $$
CREATE PROCEDURE mostrarDirectores(IN idPelicula int)
BEGIN
    SELECT directores.nombreDirector FROM directores 
	INNER JOIN cordinadores ON directores.iddirector = cordinadores.iddirector 
	INNER JOIN peliculas ON cordinadores.idpelicula = peliculas.idpelicula
	WHERE peliculas.idpelicula = idPelicula;
END $$

DELIMITER $$
CREATE PROCEDURE mostrarActores(IN idPelicula int)
BEGIN
    SELECT actores.nombreActor FROM actores 
	INNER JOIN interpretes ON actores.idactor = interpretes.idactor 
	INNER JOIN peliculas ON interpretes.idpelicula = peliculas.idpelicula
	WHERE peliculas.idpelicula = idPelicula;
END $$