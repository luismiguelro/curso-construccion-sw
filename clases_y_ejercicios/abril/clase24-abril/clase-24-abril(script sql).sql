-- Crear Base Datos
CREATE DATABASE clase24_abril;

-- Crear tabla
CREATE TABLE articulo (
  codigo_articulo INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL,
  descripcion VARCHAR(255),
  precio FLOAT NOT NULL,
  cantidad INT NOT NULL
);

-- SelectTop1000Rows 
SELECT TOP (1000) [codigo_articulo]
      ,[nombre]
      ,[descripcion]
      ,[precio]
      ,[cantidad]
  FROM [clase24_abril].[dbo].[articulo]