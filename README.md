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

	+Alejandro Guill�n(48790456G)(Coordinador):
		Crear repositorio (ramas, issues, ...)
		Crear la BD
		Entidad Provincia
		Entidad Localidad

	+Victor Padr�n(55178804X):
		Entidad Usuario
		Entidad Pais

	+Iv�n �lvarez(49623492A):
		Entidad Tarjetas
		Entidad Publicidad
		Organizaci�n del CSS

	+Ilyas Umatolov(X7279165E):
		Entidad Articulo
		Entidad Redes Sociales

	+Younes Zahid(51237104G):
		Entidad Carrito
		Entidad LinCarrito
	
	+Aurelio Bonilla(29523160S):
		Entidad Pedido
		Entidad TipoArticulo

	+Javier Arribas(05445569C):
		Entidad LinPedido
		Funcionalidad Estad�sticas

## Reparto de trabajo final
	+Alejandro Guill�n(48790456G)(Coordinador):
		Crear repositorio (ramas, issues, ...)
		Crear la BD y el script
		Entidad Provincia
		Entidad Localidad
		Interfaz Localidades
		Interfaz Provincias
		Interfaz Paises
		Interfaz MenuUsuario
		Interfaz Administrador
		Interfaz ModificarUsuario
		Interfaz PaginaPrincipal (1/2)
		Interfaz Site1.Master (1/2)
		Css de varias interfaces
		Arreglar fallos en otras entidades e interfaces

	+Victor Padr�n(55178804X):
		Entidad Usuario
		Entidad Pais
		Interfaz Usuario
		Interfaz VerUsuario
		Interfaz SignUp
		Css gen�rico (masterStyle.css)

	+Iv�n �lvarez(49623492A):
		Entidad Tarjetas
		Entidad Publicidad
		Interfaz Tarjetas
		Interfaz PaginaPrincipal (1/2)
		Interfaz Site1.Master
		Interfaz Publicidad
		Interfaz PasarelaPago
		Css de varias interfaces

	+Ilyas Umatolov(X7279165E):
		Entidad Articulo
		Entidad Redes Sociales
		Interfaz A�adirArticulo
		Interfaz Articulos
		Interfaz RedesSociales
		Interfaz VerArticulo

	+Younes Zahid(51237104G):
		Entidad Carrito
		Entidad LinCarrito
		Interfaz Carrito
	
	+Aurelio Bonilla(29523160S):
		Entidad Pedido
		Entidad TipoArticulo
		Interfaz Pedido (1/2)
		Interfaz VerPedido (1/2)
		Interfaz TipoArticulo

	+Javier Arribas(05445569C):
		Entidad LinPedido
		Funcionalidad Estad�sticas
		Interfaz Pedido (1/2)
		Interfaz VerPedido (1/2)
		Interfaz Estad�sticas

## Base de Datos

El archivo de la Base de Datos se encuentra en el directorio principal del repositorio. Su nombre es "FrikiPopBD.pdf".
Adem�s, se ha incluido un archivo llamado "scriptBD.txt" para que quien lo necesite pueda crear la BD directamente.
Se explica en la descripcion como crear la BD.


