# FrikiPop

-Descripcion:
Se va a desarrollar una web de compra-venta de articulos relacionados con el mundo de los videojuegos, donde 
los usuarios pueden comprar y vender art�culos y ponerle el precio que deseen.

-Parte p�blica:
Desde la parte p�blica se podr� ver el logo de la web. Adem�s, se podr� acceder a una secci�n para hacer log in o crear un usuario.
Se visualizar� tambien a una columna con un men� donde poder aplicar filtros a los productos mostrados.
Por �ltimo, en la zona principal de la pantalla se mostrar� un listado de articulos en venta por usuarios, pero que hasta no estar identificado
no se podr� comprar.

-Listado EN publica:
	+ENUsuarios: Servir� para iniciar sesi�n.
	+ENArticulos: Servir� para poder ver los art�culos de otras personas.
	+ENTipoArticulo: Servir� para saber de que tipo es cada art�culo de los mostrados.

-Parte privada:
	+Usuario normal: Se visualizar� lo mismo que en la parte p�blica, con la diferencia de 
	que se mostrar� el username y accediendo a este se puede modificar la informaci�n del 
	usuario. Adem�s, se mostrar� una opci�n "vender" para a�adir articulos en venta a tu perfil.

	+Administrador: Muestra lo mismo que en la parte p�blica a diferencia que en vez de hacer 
	log in aparecer� un boton para administrar la informacion de
	la web. Todo lo que hay en la web se puede administrar desde ah� (usuarios, productos, ver estado de pedidos, etc).

-Listado EN privada:
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

-Posibles mejoras:
    En las mejoras, tenemos en mente algunas funcionalidades para desarrollar:
	+Estad�sticas: Funcionalidad donde se mostrar�n algunos tops de mas vendidos, mejor valorados, etc
	+Publicidad: Crear una peque�a franja con publicidad de alguna empresa ficticia relacionada con el contenido de la p�gina.
	+Redes Sociales: Incluir al final de la p�gina enlaces a Redes Sociales, direcci�n de la empresa y un contacto.

    Si tenemos tiempo, implementaremos m�s a parte de las anteriores.


-El trabajo se va a distribuir de la siguiente manera:
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
		Entidad LinCarrito
		Organizaci�n del CSS

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
		Funcionalidad Estad�sticas
		
		
