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

## Parte pública

Desde la parte pública se podrá ver el logo de la web. Además, se podrá acceder a una sección para hacer log in o crear un usuario.
Se visualizará tambien a una columna con un menú donde poder aplicar filtros a los productos mostrados.
Por último, en la zona principal de la pantalla se mostrará un listado de articulos en venta por usuarios, pero que hasta no estar identificado
no se podrá comprar. Además, se mostrarán las redes sociales de la web y una zona con publicidad.

### Listado EN publica

	+ENUsuarios: Servirá para iniciar sesión y saber de quien es cada artículo.
	+ENProvincia: Seleccionar la provincia al crear cuenta.
	+ENLocalidad: Seleccionar la localidad al crear cuenta.
	+ENPais: Seleccionar el pais al crear cuenta.
	+ENArticulos: Servirá para poder ver los artículos de otras personas.
	+ENTipoArticulo: Servirá para saber de que tipo es cada artículo de los mostrados.
	+ENPublicidad: Servirá para visualizar alguna de las empresas que se publicitan almacenadas en la BD.
	+ENRedesSociales: Servirá para poder acceder a los perfiles de redes sociales de la web.

## Parte privada

	+Usuario normal: Se visualizará lo mismo que en la parte pública, con la diferencia de 
	que se mostrará el username y accediendo a este se puede modificar la información del 
	usuario. Además, se mostrará una opción "vender" para añadir articulos en venta a tu perfil.

	+Administrador: Muestra lo mismo que en la parte pública a diferencia que en vez de hacer 
	log in aparecerá un boton para administrar la informacion de
	la web. Todo lo que hay en la web se puede administrar desde ahí (usuarios, productos, ver estado de pedidos, etc).

### Listado EN privada

	+ENUsuario: Servirá para configurar el perfil de usuario.
	+ENArticulos: Servirá para poder acceder a los articulos propios que vendes o a los 
	de otros usuarios que se pueden comprar.
	+ENProvincia: Servirá para seleccionar una provincia para gestionar el usuario, las entregas, ...
	+ENLocalidad: Servirá para seleccionar una localidad de las almacenadas a la 
	hora de crear gestionar el usuario.
	+ENPais: Servirá para almacenar paises en la BD que los ususario podrán seleccionar 
	al registrarse o seleccionar la dirección de envío.
	+ENTarjetas: Servirá para acceder a la tarjeta de credito que tenga el usuario guardado.
	+ENCarrito: Servirá para almacenar varios articulos y hacer una compra conjunta.
	+ENLinCarrito: Servirá para ver cada articulo dentro del carrito.
	+ENPedido: Se podrá ver el pedido del usuario y el estado del mismo.
	+ENLinPedido: Servirá para acceder a cada articulo del pedido.
	+ENTipoArticulo: Servirá para saber de que tipo es cada art�culo, o asignar un tipo al crear 
	uno nuevo. Además, se podrán añadir nuevos tipos.
	+ENPublicidad: Servir� para visualizar alguna de las empresas que se publicitan almacenadas en la BD.
	+ENRedesSociales: Servir� para poder acceder a los perfiles de redes sociales de la web.

## Posibles mejoras
    En las mejoras, tenemos en mente algunas funcionalidades para desarrollar:
	+Estadísticas: Funcionalidad donde se mostrar�n algunos tops de mas vendidos, mejor valorados, etc.
	+Filtros: Funcionalidad donde se podr� agudizar la busqueda filtrando por tipo, vendedor, etc.


## Reparto del trabajo Inicial

	+Alejandro Guillén(agmg16-ua)(Coordinador):
		Crear repositorio (ramas, issues, ...)
		Crear la BD
		Entidad Provincia
		Entidad Localidad

	+Victor Padrón(vpg66-ua):
		Entidad Usuario
		Entidad Pais

	+Iván Álvarez(iaga2-ua):
		Entidad Tarjetas
		Entidad Publicidad
		Organización del CSS

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
		Funcionalidad Estadísticas

## Reparto de trabajo final
	+Alejandro Guillén(agmg16-ua)(Coordinador):
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

	+Victor Padrón(vpg66-ua):
		Entidad Usuario
		Entidad Pais
		Interfaz Usuario
		Interfaz VerUsuario
		Interfaz SignUp
		Interfaz ModificarUsuario
		Css genérico (masterStyle.css)

	+Iván Álvarez(iaga2-ua):
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
		Interfaz AñadirArticulo
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
Además, se ha incluido un archivo llamado "scriptBD.txt" para que quien lo necesite pueda crear la BD directamente.
Se explica en la descripcion como crear la BD.

## Presentación

La presentación se encuentra dentro de una carpeta en el directorio principal del repositorio llamada Presentación.
El nombre del archivo es Presentacion FrikiPop.pdf

## EntregaFinal

La entrega final es demasiado pesada para github, por lo que se ha optado por subir el archivo a google drive y 
poner el enlace en un archivo en el repositorio. El archivo se llama Enlace engregaFinal.txt y se encuentra donde 
debería estar el archivo comprimido. Desde el enlace se puede descargar el comprimido.

## Evaluaciones Finales

La aplicación web creada consiste en una aplicación de compra-venta de articulo cuyos propietarios son los mismos usuarios.
Cuenta con una parte pública y otra privada, dividida entre el usuario normal y el usuario-administrador, cada uno con mas 
privilegios que el anterior. Los usuarios pueden comprar uno o más artículos al mismo tiempo, almacenar tarjetas de crédito
para pagar y visualizar sus pedidos. Además, se lleva un conteo de ventas de cada usuario, con las que se hacen estadísticas, 
y se tiene un apartado de acuerdos con empresas para publicitarse en la web.

Entre las dificultades mas notables está poder coordinar lo que otros van a necesitar de lo que uno mismo está haciendo, ya que
alguien puede necesitar un método/botón/parámetro/validación que no controlas y a la larga dan fallos. Otra cosa que se nos ha
complicado es la validación de ciertos datos, aunque todos estos problemas los hemos podido solucionar.

Se planteó en un inicio finalizar la práctica una semana antes de la fecha de la presentación, para dejar suficiente margen para
solución de errores. Al final, la práctica visualmente se terminó dos dias antes de la presentación, por lo que pudimos hacer una 
presentación real con lo que nuestra aplicación web presenta sin faltar nada por hacer. Durante la realización de toda la práctica,
se iban planteando unos objetivos semanales adaptados al avance de las tareas particulares de cada integrante de grupo, pudiendo 
organizarse con tiempo suficiente para prevenir errores. Además, de esta manera quien acabase en su tiempo estimado podría ayudar
a otro integrante a quien se le está acumulando el trabajo.

En general, estamos satisfechos con el trabajo realizado, con el resultado final y con el ambiente y organización del grupo.

## Usuarios y Contraseñas

Con la finalidad de poder añadir diversos artículos a la BD, se han necesitado crear varios usuarios. Muchos de ellos son simplemente
para poseer artículos y que aporten lo que la página necesita. Sin embargo, hay otros con pedidos, carrito, etc... Se puede acceder a cualquiera,
pero para poder visualizar todos los rincones de la web solo se necesitarían 2 o 3:

Para acceder a la parte pública no se necesita estar logueado

Para acceder a la parte privada de usuario, con una cuenta estandar es suficiente. A continuación están el usuario y contraseña:
Usuario: Usuario_Promedio
Contraseña: Contrasenya123

Para acceder a la parte privada con permisos de administrador, hace falta que la cuenta está reconocida como tal. A continuación se muestran
dos cuentas disponibles para ello:

Usuario: TuAdminDeConfianza

Contraseña: Eladmin03

Usuario: alex_gm_03	

Contraseña: Secreto123

