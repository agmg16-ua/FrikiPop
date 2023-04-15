# FrikiPop

-Descripcion:
Se va a desarrollar una web de compra-venta de articulos relacionados con el mundo de los videojuegos, donde 
los usuarios pueden comprar y vender artículos y ponerle el precio que deseen.

-Parte pública:
Desde la parte pública se podrá ver el logo de la web. Además, se podrá acceder a una sección para hacer log in o crear un usuario.
Se visualizará tambien a una columna con un menú donde poder aplicar filtros a los productos mostrados.
Por último, en la zona principal de la pantalla se mostrará un listado de articulos en venta por usuarios, pero que hasta no estar identificado
no se podrá comprar.

-Listado EN publica:
	+ENUsuarios: Servirá para iniciar sesión.
	+ENArticulos: Servirá para poder ver los artículos de otras personas.
	+ENTipoArticulo: Servirá para saber de que tipo es cada artículo de los mostrados.

-Parte privada:
	+Usuario normal: Se visualizará lo mismo que en la parte pública, con la diferencia de 
	que se mostrará el username y accediendo a este se puede modificar la información del 
	usuario. Además, se mostrará una opción "vender" para añadir articulos en venta a tu perfil.

	+Administrador: Muestra lo mismo que en la parte pública a diferencia que en vez de hacer 
	log in aparecerá un boton para administrar la informacion de
	la web. Todo lo que hay en la web se puede administrar desde ahí (usuarios, productos, ver estado de pedidos, etc).

-Listado EN privada:
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
	+ENTipoArticulo: Servirá para saber de que tipo es cada artículo, o asignar un tipo al crear 
	uno nuevo. Además, se podrán añadir nuevos tipos.

-Posibles mejoras:
    En las mejoras, tenemos en mente algunas funcionalidades para desarrollar:
	+Estadísticas: Funcionalidad donde se mostrarán algunos tops de mas vendidos, mejor valorados, etc
	+Publicidad: Crear una pequeña franja con publicidad de alguna empresa ficticia relacionada con el contenido de la página.
	+Redes Sociales: Incluir al final de la página enlaces a Redes Sociales, dirección de la empresa y un contacto.

    Si tenemos tiempo, implementaremos más a parte de las anteriores.


-El trabajo se va a distribuir de la siguiente manera:
	+Alejandro Guillén(48790456G)(Coordinador):
		Crear repositorio (ramas, issues, ...)
		Crear la BD
		Entidad Provincia
		Entidad Localidad

	+Victor Padrón(55178804X):
		Entidad Usuario
		Entidad Pais

	+Iván Álvarez(49623492A):
		Entidad Tarjetas
		Entidad LinCarrito
		Organización del CSS

	+Ilyas ():
		Entidad Articulo
		Funcionalidad Redes Sociales

	+Youness ():
		Entidad Carrito
		Funcionalidad Publicidad
	
	+Aurelio Bonilla():
		Entidad Pedido
		Entidad TipoArticulo

	+Javier ():
		Entidad LinPedido
		Funcionalidad Estadísticas
		
		
