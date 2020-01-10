# Procedimiento para ejecutar el aplicativo
Este repositorio contiene 3 proyecto:

- AppWebSite
- AppWebSite.UnitTest
- AppWebSite.IntegrationTests


Instalar Docker:
 - El requisito para poder ejecutar el proyecto, es tener instalado Docker en la maquina local
 - url : https://www.docker.com/products/docker-desktop

Una ves instalado clonar el projecto en la maquina local ejecutar el siguiente comando en la terminal:

```git
git clone https://github.com/CesarBracoL/CustomerSatisfation.git
```

Cuando termine de decargar los archivos, luego dirigirse dentro del proyecto AppWebSite/
- Ejecutar el siguiente comando para compilar todo el proyecto:

```docker-compose
docker-compose -f docker-compose.override.yml build
```

- Y luego ejecutar el siguiente codigo para ejecutar el proyecto completo:
```docker-compose
docker-compose -f docker-compose.override.yml up
```

Gracias.