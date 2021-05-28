USE PeliculasWeb;

CREATE PROCEDURE insertarGeneros
@nombre varchar(20)
AS
	INSERT INTO Generos VALUES(@nombre);
GO

CREATE PROCEDURE insertarPelicula
@nombre varchar(20),
@descripcion varchar(300),
@imagen IMAGE
AS
	INSERT INTO peliculas VALUES(@nombre,@descripcion,@imagen);
GO

CREATE PROCEDURE insertarActor
@nombre varchar(50)
AS
	INSERT INTO actores VALUES(@nombre);
GO

CREATE PROCEDURE insertarDirector
@nombre varchar(50)
AS
    INSERT INTO directores VALUES(@nombre);
GO

CREATE PROCEDURE insertarPlataforma
@nombre varchar(50)
AS
    INSERT INTO plataformas VALUES(@nombre);
GO

CREATE PROCEDURE insertarTipos
@nombre varchar(13)
AS
    INSERT INTO tipos VALUES(@nombre);
GO

CREATE PROCEDURE insertarDistribucion
@precio int,
@calidad varchar(5),
@tipo int
AS
	INSERT INTO distribuciones VALUES(@precio,@calidad,@tipo);
GO

CREATE PROCEDURE insertarUsuarios
@nombre varchar(20),
@contrasena varchar (20)
AS
    INSERT INTO usuarios VALUES(@nombre,@contrasena);
GO

CREATE PROCEDURE insertarComentarios
@idUsuario int,
@comentario varchar(300),
@idPelicula int
AS
    INSERT INTO comentarios VALUES(@idUsuario, @comentario, @idPelicula);
GO

CREATE PROCEDURE insertarInterpretes
@idActor int,
@idPelicula int
AS
    INSERT INTO directores VALUES(idActor,idPelicula);
GO

CREATE PROCEDURE insertarCordinadores
@idPelicula int,
@idDirector int
AS
    INSERT INTO directores VALUES(idPelicula ,idDirector);
GO

CREATE PROCEDURE insertarContine
@idPelicula int,
@idGenero int
AS
    INSERT INTO directores VALUES(@idPelicula ,@idGenero);
GO


CREATE PROCEDURE insertarServicios
@idPlataforma int,
@idDistribucion int
AS
    INSERT INTO directores VALUES(@idPlataforma ,@idDistribucion);
GO

CREATE PROCEDURE insertarCategoria
@idPelicula int,
@idGenero int
AS
    INSERT INTO directores VALUES(@idPelicula ,@idGenero);
GO