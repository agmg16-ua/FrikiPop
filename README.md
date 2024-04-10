# FrikiPop

## Descripcion

Se va a desarrollar una web de compra-venta de articulos relacionados con el mundo de los videojuegos, donde 
los usuarios pueden comprar y vender art�culos y ponerle el precio que deseen. 

IMPORTANTE: DADO QUE LA VERSION DE SQLSERVER CON LA QUE SE HA GENERADO LA BD ES DIFERENTE A LA DE LOS LABORATORIOS DE LA EPS, SE
DEBE GENERAR A PARTIR DEL SCRIPT LA BD. SE DEBEN SEGUIR LOS SIGUIENTES PASOS:
>CARPETA APP_DATA >CLICK DERECHO >ELIMINAR

>CLICK DERECHO EN USUWEB >AGREGAR NUEVO ELEMENTO >BASE DE DATOS SQLSERVER

>ACEPTAR CREACION DE LA CARPETA APP_DATA. LA BD SE DEBE LLAMAR 'Database1.mdf'

>DOBLE CLICK EN 'Database1.mdf' >A LA IZQUIERDA, CLICK DERECHO EN 'Database' >NUEVA CONSULTA

>PEGAR EL SCRIPT >CLICK EN 'EJECUTAR' >BD CREADA CORRECTAMENTE, TODO LISTO PARA EJECUTAR

SE RECOMIENDA EJECUTAR LA APLICACI�N WEB EN EL NAVEGADOR GOOGLE CHROME, YA QUE HAY ALGUNAS IM�GENES QUE POR ALGUNA RAZ�N EN EL
NAVEGADOR MICROSOFT EDGE NO CARGAN CORRECTAMENTE.

## Parte p�blica

Desde la parte p�blica se podr� ver el logo de la web. Adem�s, se podr� acceder a una secci�n para hacer log in o crear un usuario.
Se visualizar� tambien a una columna con un men� donde poder aplicar filtros a los productos mostrados.
Por �ltimo, en la zona principal de la pantalla se mostrar� un listado de articulos en venta por usuarios, pero que hasta no estar identificado
no se podr� comprar. Adem�s, se mostrar�n las redes sociales de la web y una zona con publicidad.

### Listado EN publica

	+ENUsuarios: Servir� para iniciar sesi�n y saber de quien es cada art�culo.
	+ENProvincia: Seleccionar la provincia al crear cuenta.
	+ENLocalidad: Seleccionar la localidad al crear cuenta.
	+ENPais: Seleccionar el pais al crear cuenta.
	+ENArticulos: Servir� para poder ver los art�culos de otras personas.
	+ENTipoArticulo: Servir� para saber de que tipo es cada art�culo de los mostrados.
	+ENPublicidad: Servir� para visualizar alguna de las empresas que se publicitan almacenadas en la BD.
	+ENRedesSociales: Servir� para poder acceder a los perfiles de redes sociales de la web.

## Parte privada

	+Usuario normal: Se visualizar� lo mismo que en la parte p�blica, con la diferencia de 
	que se mostrar� el username y accediendo a este se puede modificar la informaci�n del 
	usuario. Adem�s, se mostrar� una opci�n "vender" para a�adir articulos en venta a tu perfil.

	+Administrador: Muestra lo mismo que en la parte p�blica a diferencia que en vez de hacer 
	log in aparecer� un boton para administrar la informacion de
	la web. Todo lo que hay en la web se puede administrar desde ah� (usuarios, productos, ver estado de pedidos, etc).

### Listado EN privada

	+ENUsuario: Servir� para configurar el perfil de usuario.
	+ENArticulos: Servir� para poder acceder a los articulos propios que vendes o a los 
	de otros usuarios que se pueden comprar.
	+ENProvincia: Servir� para seleccionar una provincia para gestionar el usuario, las entregas, ...
	+ENLocalidad: Servir� para seleccionar una localidad de las almacenadas a la 
	hora de crear gestionar el usuario.
	+ENPais: Servir� para almacenar paises en la BD que los ususario podr�n seleccionar 
	al registrarse o seleccionar la direcci�n de env�o.
	+ENTarjetas: Servir� para acceder a la tarjeta de credito que tenga el usuario guardado.
	+ENCarrito: Servir� para almacenar varios articulos y hacer una compra conjunta.
	+ENLinCarrito: Servir� para ver cada articulo dentro del carrito.
	+ENPedido: Se podr� ver el pedido del usuario y el estado del mismo.
	+ENLinPedido: Servir� para acceder a cada articulo del pedido.
	+ENTipoArticulo: Servir� para saber de que tipo es cada art�culo, o asignar un tipo al crear 
	uno nuevo. Adem�s, se podr�n a�adir nuevos tipos.
	+ENPublicidad: Servir� para visualizar alguna de las empresas que se publicitan almacenadas en la BD.
	+ENRedesSociales: Servir� para poder acceder a los perfiles de redes sociales de la web.

## Posibles mejoras
    En las mejoras, tenemos en mente algunas funcionalidades para desarrollar:
	+Estad�sticas: Funcionalidad donde se mostrar�n algunos tops de mas vendidos, mejor valorados, etc.
	+Filtros: Funcionalidad donde se podr� agudizar la busqueda filtrando por tipo, vendedor, etc.


## Reparto del trabajo Inicial

	+Alejandro Guill�n(agmg16-ua)(Coordinador):
		Crear repositorio (ramas, issues, ...)
		Crear la BD
		Entidad Provincia
		Entidad Localidad

	+Victor Padr�n(vpg66-ua):
		Entidad Usuario
		Entidad Pais

	+Iv�n �lvarez(iaga2-ua):
		Entidad Tarjetas
		Entidad Publicidad
		Organizaci�n del CSS

	+Ilyas Umatolov(isumalotov):
		Entidad Articulo
		Entidad Redes Sociales

	+Younes Zahid(yzcz1):
		Entidad Carrito
		Entidad LinCarrito
	
	+Aurelio Bonilla(abab4-ua):
		Entidad Pedido
		Entidad TipoArticulo

	+Javier Arribas(jag99-ua):
		Entidad LinPedido
		Funcionalidad Estad�sticas

## Reparto de trabajo final
	+Alejandro Guill�n(agmg16-ua)(Coordinador):
		Crear repositorio (ramas, issues, ...)
		Crear la BD y el script
		Entidad Provincia
		Entidad Localidad
		Interfaz Localidades
		Interfaz Provincias
		Interfaz Paises
		Interfaz MenuUsuario
		Interfaz Administrador
		Interfaz PaginaPrincipal (1/2)
		Interfaz Site1.Master (1/2)
		Interfaz TipoArticulo
		Css de varias interfaces
		Arreglar fallos en otras entidades e interfaces

	+Victor Padr�n(vpg66-ua):
		Entidad Usuario
		Entidad Pais
		Interfaz Usuario
		Interfaz VerUsuario
		Interfaz SignUp
		Interfaz ModificarUsuario
		Css gen�rico (masterStyle.css)

	+Iv�n �lvarez(iaga2-ua):
		Entidad Tarjetas
		Entidad Publicidad
		Interfaz Tarjetas
		Interfaz PaginaPrincipal (1/2)
		Interfaz Site1.Master
		Interfaz Publicidad
		Interfaz PasarelaPago
		Css de varias interfaces

	+Ilyas Umatolov(isumalotov):
		Entidad Articulo
		Entidad Redes Sociales
		Interfaz A�adirArticulo
		Interfaz Articulos
		Interfaz RedesSociales
		Interfaz VerArticulo

	+Younes Zahid(yzcz1):
		Entidad Carrito
		Entidad LinCarrito
		Interfaz Carrito
	
	+Aurelio Bonilla(abab4-ua):
		Entidad Pedido
		Entidad TipoArticulo
		Interfaz Pedido
		Interfaz VerPedido

	+Javier Arribas(jag99-ua):
		Entidad LinPedido
		Funcionalidad Estad�sticas
		Interfaz Pedido (Ayuda)
		Interfaz VerPedido (Ayuda)
		Interfaz Estad�sticas

## Base de Datos

El archivo de la Base de Datos se encuentra en el directorio principal del repositorio. Su nombre es "FrikiPopBD.pdf".
Adem�s, se ha incluido un archivo llamado "scriptBD.txt" para que quien lo necesite pueda crear la BD directamente.
Se explica en la descripcion como crear la BD.

## Presentaci�n

La presentaci�n se entucantra dentro de una carpeta en el directorio principal del repositorio llamada Presentaci�n.
El nombre del archivo es Presentacion FrikiPop.pdf

## EntregaFinal

La entrega final es demasiado pesada para github, por lo que se ha optado por subir el archivo a google drive y 
poner el enlace en un archivo en el repositorio. El archivo se llama Enlace engregaFinal.txt y se encuentra donde 
deber�a estar el archivo comprimido. Desde el enlace se puede descargar el comprimido.

## Evaluaciones Finales

La aplicaci�n web creada consiste en una aplicaci�n de compra-venta de articulo cuyos propietarios son los mismos usuarios.
Cuenta con una parte p�blica y otra privada, dividida entre el usuario normal y el usuario-administrador, cada uno con mas 
privilegios que el anterior. Los usuarios pueden comprar uno o m�s art�culos al mismo tiempo, almacenar tarjetas de cr�dito
para pagar y visualizar sus pedidos. Adem�s, se lleva un conteo de ventas de cada usuario, con las que se hacen estad�sticas, 
y se tiene un apartado de acuerdos con empresas para publicitarse en la web.

Entre las dificultades mas notables est� poder coordinar lo que otros van a necesitar de lo que uno mismo est� haciendo, ya que
alguien puede necesitar un m�todo/bot�n/par�metro/validaci�n que no controlas y a la larga dan fallos. Otra cosa que se nos ha
complicado es la validaci�n de ciertos datos, aunque todos estos problemas los hemos podido solucionar.

Se plante� en un inicio finalizar la pr�ctica una semana antes de la fecha de la presentaci�n, para dejar suficiente margen para
soluci�n de errores. Al final, la pr�ctica visualmente se termin� dos dias antes de la presentaci�n, por lo que pudimos hacer una 
presentaci�n real con lo que nuestra aplicaci�n web presenta sin faltar nada por hacer. Durante la realizaci�n de toda la pr�ctica,
se iban planteando unos objetivos semanales adaptados al avance de las tareas particulares de cada integrante de grupo, pudiendo 
organizarse con tiempo suficiente para prevenir errores. Adem�s, de esta manera quien acabase en su tiempo estimado podr�a ayudar
a otro integrante a quien se le est� acumulando el trabajo.

En general, estamos satisfechos con el trabajo realizado, con el resultado final y con el ambiente y organizaci�n del grupo.

## Usuarios y Contrase�as

Con la finalidad de poder a�adir diversos art�culos a la BD, se han necesitado crear varios usuarios. Muchos de ellos son s�mplemente
para poseer art�culos y que aporten lo que la p�gina necesita. Sin embargo, hay otros con pedidos, carrito, etc... Se puede acceder a cualquiera,
pero para poder visualizar todos los rincones de la web solo se necesitar�an 2 o 3:

Para acceder a la parte p�blica no se necesita estar logueado

Para acceder a la parte privada de usuario, con una cuenta estandar es suficiente. A continuaci�n est�n el usuario y contrase�a:
Usuario: Usuario_Promedio
Contrase�a: Contrasenya123

Para acceder a la parte privada con permisos de administrador, hace falta que la cuenta est� reconocida como tal. A continuaci�n se muestran
dos cuentas disponibles para ello:
Usuario: TuAdminDeConfianza
Contrase�a: Eladmin03

Usuario: alex_gm_03	
Contrase�a: Secreto123

