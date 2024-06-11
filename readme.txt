-Es necesario tener instalado visual studio y Microsoft sql management
Ejecutar la base de datos la cual ya tiene datos precargados para poder hacer una prueba
Ahora si dirigirse a la carpeta “Softech app” y dentro de sistemaVentas darle doble click al archivo llamado “Sistemaventas.sln”
Eso abrira el proyecto y le permitirá poder ejecutarlo para poder hacer la prueba  
En caso de que no se conecte con la base de datos, revise en el App.config de la aplicación, corrobore que el nombre con el que se conecta al sql management sea igual a la parte de data source=(local) en caso de no serlo copie el nombre con el que se conecta al sql management y peguelo reemplazando el “(local)” 

Usuario admin:12345  Clave:12345
Usuario común: 678 Clave:678