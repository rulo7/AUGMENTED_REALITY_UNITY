## INTRODUCCI�N

## La realidad aumentada

La realidad aumentada, en adelante RA, es el t�rmino que se usa para definir una visi�n a trav�s de un dispositivo tecnol�gico, directa o indirecta, de un entorno f�sico del mundo real, cuyos elementos se combinan con elementos virtuales para la creaci�n de una realidad mixta en tiempo real.

Seg�n Ronald Azuma, desarrollador y lider de proyecto en New Media, *Intel Corporation*, y uno de los pioneros en el campo de la realidad aumentada, dice que la RA consta de las siguientes caracter�sticas:

+ Combina elementos reales y virtuales.
+ Es interactiva en tiempo real.
+ Est� registrada en 3D.

A su vez, consta de unos requisitos m�nimos para poder ser emulada, los cuales son:

+ Una pantalla, donde mostrar la combinaci�n de los elementos reales captados por alg�n dispositivo y los elementos virtuales generados por un software.
+ Un conjunto de dispositivos que capturen los elementos del entorno y nuestra situaci�n como son una c�mara, aceler�metro, acelerometro... de tal forma que permita al software tener referencias de como y donde debe mostrar sus elementos virtuales.
+ Un hardware relativamente potente, para poder realizar los c�lculos necesarios para mostrar el entorno que captura la c�mara y ser capaz de hacer frente al software que genera los elementos virtuales y combinarlos en la pantalla con los reales.
+ Un software capaz de reconocer el entorno y calcular donde y como debe representar los elementos virtuales combinados con los reales para conseguir una visi�n de RA.

Con el continuo avance de los dispositivos m�viles y la potencia, a un coste aceptable para la mayor�a, de la que constan ahora mismo estos, permiten que cualquier usuario pueda hacer uso de la RA, ya que sus smartphones cumplen todos los requisitos para ello.

## Alcance

Actualmente, el hecho de que la era de los smartphones ha puesto practicamente en la mano de la mayor�a de las personas uno de estos dispositivos hace que la RA est� ahora mismo en su punto mas alto y que su crecimiento sea cada vez mayor.

Ahora mismo, tiene diferentes aplicaciones en diversos campos como son:

### Informaci�n interactiva

En este caso se utiliza para dar a conocer de forma interactiva, informaci�n acerca de un elemento cercano al usuario   de tal forma que se puede mostrar un tipo de informaci�n u otra en funci�n de la interacci�n entre el usuario y dicho elemento.

Ahora mismo este area est� muy presente en museos como forma din�mica de conseguir una inmersi�n del usuario con lo que est� viendo y hacer de su visita una experiencia m�s atractiva e incluso hasta m�s productiva.

Dentro de este campo tambi�n se hace uso de la RA en herramientas utilizadas para el intercambio de informaci�n en proyectos profesionales o con fines comerciales como el de mostrar cat�logos productos de una forma interactiva.

### Entretenimiento

En la actualidad, aunque no est� todav�a muy popularizado su uso, existen una gran cantidad de videojuegos que hacen uso de est� tecnolog�a que, junto con diferentes mec�nicas que se adaptan a ella, generan una novedosa experiencia para entretener el usuario.

### Ciencia y desarrollo

Aunque todav�a no est� normalizado el uso de la RA en este campo, si est�n naciendo n�merosos proyectos con el fin de desarrollar est� tecnolog�a para utilizarse en areas como la medicina y la construcci�n entre otras.

### Otros

Adem�s de los ya mencionados, existen todav�a much�simas areas en las que  tienen cabida en sus tecnolog�as la RA adem�s de muchos otros usos que o bien est�n por descubir o no se consta todav�a de la tecnolog�a suficiente como para integrarlo.

Algo que todav�a est� en una fase temprana de desarrollo pero que tiene un futuro prometedor es el uso de la RA para generaci�n de terreno de forma que se pueda reconocer el mismo y en funci�n de su forma generar un medio en relaci�n un entorno que todav�a no estaba registrado. Esta tecnolog�a dota de un sinf�n de posibilidades a�adidas a las ya existentes para el uso de la RA en muchos otros campos.


## ESTADO DEL ARTE

### Impacto

... Puestos de trabajo relacionados con la RA, inversi�n destinada a su desarrollo, estudios y empresas que trabajan con RA, crecimiento del nivel de investigaci�n en el sector.

### Historia y evoluci�n

... Breve descripci�n de como ha evolucionado la RA a lo largo de los a�os.

### Avances

... Lo que se est� investigando, mejorando o desarrollando sobre RA.

### Algunos ejemplos

... Ejemplos de aplicaciones y usos de la RA que esten ahora mismo vigentes o que se esten desarrollando.

## TECNOLOG�A

### C�mo funciona

... Resumen y de las diapositivas de Guillermo del drive [drive_pdf](https://drive.google.com/open?id=0B56Lo6upu8nQNF9wTmRHWmVQYzQ))

### Herramientas para el desarrollo

... Vuforia y otras alternativas para la programaci�n de RA.

### Vuforia

#### C�mo genera realidad aumentada

... Describir el funcionamiento superficial de Vuforia para facilitar el uso de la programaci�n de RA.

#### Plataformas de desarrollo

... SDK de android, IOS y Unity y un poco de como se integran con sus plataformas, ventajas y desventajas.

#### Unity como herramienta y C# como lenguaje

... Como funciona unity, su sistema de componentes y escenas, su IDE, sus herramientas, su comunidad, sus extensiones, su integraci�n y C# como lenguaje para usar, su paradigma OO, la clase MonoBehaviour, su arquitectura basada en componentes.

#### Unity + Vuforia

... Como se hace uso de Vuforia en Unity

## MEMORIA

## Introducci�n

El trabajo que se ha realizado para este proyecto para este proyecto, es un videojuego. Este, est� ambientado en el espacio y hace uso de la realidad aumentada como entorno.

La idea principal del proyecto es la de implementar juegos con diferentes mec�nicas y adaptarlos a su uso con RA y la tecnolog�a m�vil. Con este fin, creemos que se puede hacer de cualquier espacio, un lugar mucho m�s interesante haciendo uso de esta tecnolog�a, ya que no solo imaginas la realidad del lugar si no que puedes interactuar con �l.

Con el fin de hacer uso de la tecnolog�a actual que se nos brinda para el desarrollo de la RA, hemos implementado tres juegos que cre�amos viables, y que nos permiten poder experimentar con ella. Estos tres juegos son el Arkanoid, un Space invaders adaptado al uso de la RA y WaterPipes. Los tres, est�n unidos haciendo uso de un hilo argumental que no solo da coherencia a los juegos, sino que obliga al usuario a moverse por la facultad para poder completar los niveles.

### ARKANOID

#### Historia

El Arkanoid des un juego de los 80, donde el jugador controla una plataforma que impide que una bola se salga de la superficie que limita el juego. El objectivo principal de la bola es el de destruir todos los ladrillos o bloques de la pantalla sin salirse de esta. La misi�n del jugador es la de, no solo impedir que la bola se salga de la escena, si no la de situar la plataforma que maneja de tal forma que consiga que la bola rebote y destruya todos los bloques.

[imagen de la portada del arkanoid]

A lo largo del juego puede haber un gran numero de variaciones que complican el juego o que facilitan las cosas. La plataforma del jugador puede modificar su tama�o, u obtener mejoras como disparos para romper los bloques. La bola, puede verse modificada mediante variaciones de tama�o o en la fisica del juego como  romper varios bloques sin rebotar o incluso multiplicarse. Y los bloques pueden variar en su posici�n e incluso desplazarse con el fin de finalizar el juego cuando llegan abajo.

[imagen de la escena de arkanoid]

#### Nuestra versi�n

Es nuestra veri�n las cosas son sencillas. El usuario proviene de defender la facultad (*nave espacial tfg-III*) de unos invasores, y tras finalizar, recibir� una misi�n, que es la de despejar el campo de batalla para poder despegar la nave. Para ello debe abrir paso reciclando escombros, haciendo uso del panel de reciclaje que se situa en la tercera planta, y que se accede a �l, apuntando al c�digo QR de *Super Mario*  situado junto a una de las consolas.

[imagen del qr de super mario]

Una vez se reconozca el ImageTarget (*el QR de Super Mario*), aparecer� un viejo televisor, y en su pantalla se observa el juego y dos contadores. El objetivo es sencillo, hay que despejar los escombros. Hay un minuto para realizar dicha tarea o hasta que la bola atraviese la deathzone. Cuantos mas residuos recicle, mayor ser� la puntuaci�n que arrastr� al siguiente juego.

Una vez en situaci�n, mientras enfoca al target para no perder de vista la escena, el jugador deber� arrastrar su dedo por la pantalla de su smartphone para poder desplazar la plataforma y controlar donde rebota la bola. Mientras hace eso, la bola ir� rebotando y el tiempo decrementando. A medida que destruya objetivos, la puntuaci�n crecer� y el tiempo se ir� agotando.

[captura del juego enfocado en el museo de la facultad]

El juego est� ambientado en un entorno espacial, haciendo referencia al hilo del juego pero solo de forma superficial. Lo que conforma el tema del espacio es lo que aparece en la pantalla del televisor que contiene la escena. Pero, en realidad, la escena tiene una connotaci�n *retro*, donde un antiguo televisor al lado de una de las consolas que en un pasado ejecutaba el juego, quiere recrear la forma primitiva de jugar al Arkanoid; *en un televisor de tubo* y con un juego sencillo que era para lo que daba de s� la tecnolog�a y los medios de la �poca.

Con esta recreaci�n, lo que se intenta es, no tanto simular un juego entretenido para cumplir con el objetivo de la historia, si no el recrear una escena pasada basada en este juego. De esta forma, se hace uso de la RA en este caso, no como medio de entretenimiento a trav�s las mec�nicas que proporciona, si no generando una escena para mejorar la experiencia del usuario en el lugar, en este caso, el museo.

#### Implementaci�n

##### Dise�o

La escena se conforman por los siguientes elementos:

+ Un modelo 3D de un televisor que hace de contendor de la escena y que no tiene ninguna mec�nica asociada.

+ La bola, en la que se han implementado dos componentes; uno f�sico para hacer que esta rebote, y un script cuya finalidad es la de destruir los bloques, o mejor dicho, la de lanzar la animaci�n de destrucci�n del bloque y finzalizar el juego al acabar con todos los bloques, o, al salirse de la zona de juego. Para evitar probloemas y por l�gica del juego, aunque la escena sea 3D los compoenentes sobre este juego son en 2D.

  + **Ball Material**: Es un material de unity que, junto al componente *RigidBody2D*, elimina la gravedad en el objeto, configura a este oara poder rebotar, consigue que la fuerza aplicada sobre la bola sea infinita, de forma que no pare jam�s de desplazarse; y, define las coordenadas en las que puede desplazarse el objeto (x e y) y en las que puede rotar (ninguna).

    [imagen del inspector con mostrando el componente ballMaterial]

  + **BoxCollider2D**: Para controlar todo el tema de colisiones. En este caso, el collider que envuelve a la bola es un cuadrado rotado 45 grados para evitar problemas en los rebotes.

    [imagen del boxcollider de la bola del arkanoid]

+ Los bloques, que se reparten por la escena esperando a que la bola colisione con ellos y recibir as�, la orden de que se lance su animaci�n de destrucci�n y se aumente el marcador.
  + **Audio source**: el componente que da sonido a la acci�n de destrucci�n.
  + **Animacion**: la animaci�n de destrucci�n que se lanza al colisionar con la bola. Esta se genera por interpolaci�n, ya que es el sistema del que nos dota Unity, y lo que hace es reducir la escala del objeto a cero.

  [imagen de los 4 bloques de Arkanoid]
  
+ La plataforma:  Esta contiene un componente que reacciona a los eventos de  la pantalla t�ctil y que le permite deplazarse, adem�s tambi�n tiene un *RigidBody2D* cuyas constraints impiden que pueda verse desplazado en el eje vertical o rotado.

+ Canvas: Contiene la informaci�n del estado del juego. Este objeto y sus hijos, a diferencia del resto, en escena, se muestra en funci�n a la pantalla del dispositivo en el que se ejecuta el juego y no en funci�n de lo que enfoca la c�mara. Sus hijos son, el marcador, el contador de tiempo y la pantalla de precarga que muestra la informaci�n de la ejecuci�n del juego al usuario.

##### Desarrollo

#### Conclusiones

### SPACE INVADERS

### WATER PIPES

### ESCENAS INTERMEDIAS

### SISTEMA DE PERSISTENCIA DE PUNTUACIONES

## BIBLIOGRAFIA

[https://es.wikipedia.org/wiki/Realidad_aumentada#Definiciones](https://es.wikipedia.org/wiki/Realidad_aumentada#Definiciones)

[http://www.ronaldazuma.com/publications.html](http://www.ronaldazuma.com/publications.html)
