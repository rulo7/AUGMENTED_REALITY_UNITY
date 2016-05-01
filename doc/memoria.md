## INTRODUCCIÓN

## La realidad aumentada

La realidad aumentada, en adelante RA, es el término que se usa para definir una visión a través de un dispositivo tecnológico, directa o indirecta, de un entorno físico del mundo real, cuyos elementos se combinan con elementos virtuales para la creación de una realidad mixta en tiempo real.

Según Ronald Azuma, desarrollador y lider de proyecto en New Media, *Intel Corporation*, y uno de los pioneros en el campo de la realidad aumentada, dice que la RA consta de las siguientes características:

+ Combina elementos reales y virtuales.
+ Es interactiva en tiempo real.
+ Está registrada en 3D.

A su vez, consta de unos requisitos mínimos para poder ser emulada, los cuales son:

+ Una pantalla, donde mostrar la combinación de los elementos reales captados por algún dispositivo y los elementos virtuales generados por un software.
+ Un conjunto de dispositivos que capturen los elementos del entorno y nuestra situación como son una cámara, acelerómetro, acelerometro... de tal forma que permita al software tener referencias de como y donde debe mostrar sus elementos virtuales.
+ Un hardware relativamente potente, para poder realizar los cálculos necesarios para mostrar el entorno que captura la cámara y ser capaz de hacer frente al software que genera los elementos virtuales y combinarlos en la pantalla con los reales.
+ Un software capaz de reconocer el entorno y calcular donde y como debe representar los elementos virtuales combinados con los reales para conseguir una visión de RA.

Con el continuo avance de los dispositivos móviles y la potencia, a un coste aceptable para la mayoría, de la que constan ahora mismo estos, permiten que cualquier usuario pueda hacer uso de la RA, ya que sus smartphones cumplen todos los requisitos para ello.

## Alcance

Actualmente, el hecho de que la era de los smartphones ha puesto practicamente en la mano de la mayoría de las personas uno de estos dispositivos hace que la RA esté ahora mismo en su punto mas alto y que su crecimiento sea cada vez mayor.

Ahora mismo, tiene diferentes aplicaciones en diversos campos como son:

### Información interactiva

En este caso se utiliza para dar a conocer de forma interactiva, información acerca de un elemento cercano al usuario   de tal forma que se puede mostrar un tipo de información u otra en función de la interacción entre el usuario y dicho elemento.

Ahora mismo este area está muy presente en museos como forma dinámica de conseguir una inmersión del usuario con lo que está viendo y hacer de su visita una experiencia más atractiva e incluso hasta más productiva.

Dentro de este campo también se hace uso de la RA en herramientas utilizadas para el intercambio de información en proyectos profesionales o con fines comerciales como el de mostrar catálogos productos de una forma interactiva.

### Entretenimiento

En la actualidad, aunque no está todavía muy popularizado su uso, existen una gran cantidad de videojuegos que hacen uso de está tecnología que, junto con diferentes mecánicas que se adaptan a ella, generan una novedosa experiencia para entretener el usuario.

### Ciencia y desarrollo

Aunque todavía no está normalizado el uso de la RA en este campo, si están naciendo númerosos proyectos con el fin de desarrollar está tecnología para utilizarse en areas como la medicina y la construcción entre otras.

### Otros

Además de los ya mencionados, existen todavía muchísimas areas en las que  tienen cabida en sus tecnologías la RA además de muchos otros usos que o bien están por descubir o no se consta todavía de la tecnología suficiente como para integrarlo.

Algo que todavía está en una fase temprana de desarrollo pero que tiene un futuro prometedor es el uso de la RA para generación de terreno de forma que se pueda reconocer el mismo y en función de su forma generar un medio en relación un entorno que todavía no estaba registrado. Esta tecnología dota de un sinfín de posibilidades añadidas a las ya existentes para el uso de la RA en muchos otros campos.


## ESTADO DEL ARTE

### Impacto

... Puestos de trabajo relacionados con la RA, inversión destinada a su desarrollo, estudios y empresas que trabajan con RA, crecimiento del nivel de investigación en el sector.

### Historia y evolución

... Breve descripción de como ha evolucionado la RA a lo largo de los años.

### Avances

... Lo que se está investigando, mejorando o desarrollando sobre RA.

### Algunos ejemplos

... Ejemplos de aplicaciones y usos de la RA que esten ahora mismo vigentes o que se esten desarrollando.

## TECNOLOGÍA

### Cómo funciona

... Resumen y de las diapositivas de Guillermo del drive [drive_pdf](https://drive.google.com/open?id=0B56Lo6upu8nQNF9wTmRHWmVQYzQ))

### Herramientas para el desarrollo

... Vuforia y otras alternativas para la programación de RA.

### Vuforia

#### Cómo genera realidad aumentada

... Describir el funcionamiento superficial de Vuforia para facilitar el uso de la programación de RA.

#### Plataformas de desarrollo

... SDK de android, IOS y Unity y un poco de como se integran con sus plataformas, ventajas y desventajas.

#### Unity como herramienta y C# como lenguaje

... Como funciona unity, su sistema de componentes y escenas, su IDE, sus herramientas, su comunidad, sus extensiones, su integración y C# como lenguaje para usar, su paradigma OO, la clase MonoBehaviour, su arquitectura basada en componentes.

#### Unity + Vuforia

... Como se hace uso de Vuforia en Unity

## MEMORIA

## Introducción

El trabajo que se ha realizado para este proyecto para este proyecto, es un videojuego. Este, está ambientado en el espacio y hace uso de la realidad aumentada como entorno.

La idea principal del proyecto es la de implementar juegos con diferentes mecánicas y adaptarlos a su uso con RA y la tecnología móvil. Con este fin, creemos que se puede hacer de cualquier espacio, un lugar mucho más interesante haciendo uso de esta tecnología, ya que no solo imaginas la realidad del lugar si no que puedes interactuar con él.

Con el fin de hacer uso de la tecnología actual que se nos brinda para el desarrollo de la RA, hemos implementado tres juegos que creíamos viables, y que nos permiten poder experimentar con ella. Estos tres juegos son el Arkanoid, un Space invaders adaptado al uso de la RA y WaterPipes. Los tres, están unidos haciendo uso de un hilo argumental que no solo da coherencia a los juegos, sino que obliga al usuario a moverse por la facultad para poder completar los niveles.

### ARKANOID

#### Historia

El Arkanoid des un juego de los 80, donde el jugador controla una plataforma que impide que una bola se salga de la superficie que limita el juego. El objectivo principal de la bola es el de destruir todos los ladrillos o bloques de la pantalla sin salirse de esta. La misión del jugador es la de, no solo impedir que la bola se salga de la escena, si no la de situar la plataforma que maneja de tal forma que consiga que la bola rebote y destruya todos los bloques.

[imagen de la portada del arkanoid]

A lo largo del juego puede haber un gran numero de variaciones que complican el juego o que facilitan las cosas. La plataforma del jugador puede modificar su tamaño, u obtener mejoras como disparos para romper los bloques. La bola, puede verse modificada mediante variaciones de tamaño o en la fisica del juego como  romper varios bloques sin rebotar o incluso multiplicarse. Y los bloques pueden variar en su posición e incluso desplazarse con el fin de finalizar el juego cuando llegan abajo.

[imagen de la escena de arkanoid]

#### Nuestra versión

Es nuestra verión las cosas son sencillas. El usuario proviene de defender la facultad (*nave espacial tfg-III*) de unos invasores, y tras finalizar, recibirá una misión, que es la de despejar el campo de batalla para poder despegar la nave. Para ello debe abrir paso reciclando escombros, haciendo uso del panel de reciclaje que se situa en la tercera planta, y que se accede a él, apuntando al código QR de *Super Mario*  situado junto a una de las consolas.

[imagen del qr de super mario]

Una vez se reconozca el ImageTarget (*el QR de Super Mario*), aparecerá un viejo televisor, y en su pantalla se observa el juego y dos contadores. El objetivo es sencillo, hay que despejar los escombros. Hay un minuto para realizar dicha tarea o hasta que la bola atraviese la deathzone. Cuantos mas residuos recicle, mayor será la puntuación que arrastrá al siguiente juego.

Una vez en situación, mientras enfoca al target para no perder de vista la escena, el jugador deberá arrastrar su dedo por la pantalla de su smartphone para poder desplazar la plataforma y controlar donde rebota la bola. Mientras hace eso, la bola irá rebotando y el tiempo decrementando. A medida que destruya objetivos, la puntuación crecerá y el tiempo se irá agotando.

[captura del juego enfocado en el museo de la facultad]

El juego está ambientado en un entorno espacial, haciendo referencia al hilo del juego pero solo de forma superficial. Lo que conforma el tema del espacio es lo que aparece en la pantalla del televisor que contiene la escena. Pero, en realidad, la escena tiene una connotación *retro*, donde un antiguo televisor al lado de una de las consolas que en un pasado ejecutaba el juego, quiere recrear la forma primitiva de jugar al Arkanoid; *en un televisor de tubo* y con un juego sencillo que era para lo que daba de sí la tecnología y los medios de la época.

Con esta recreación, lo que se intenta es, no tanto simular un juego entretenido para cumplir con el objetivo de la historia, si no el recrear una escena pasada basada en este juego. De esta forma, se hace uso de la RA en este caso, no como medio de entretenimiento a través las mecánicas que proporciona, si no generando una escena para mejorar la experiencia del visitante del lugar, el museo de la facultad.

#### Implementación

##### Diseño

La escena se conforman por los siguientes elementos:

+ Un modelo 3D de un televisor que hace de contendor de la escena y que no tiene ninguna mecánica asociada.

+ La bola, en la que se han implementado dos componentes; uno físico para hacer que esta rebote, y un script cuya finalidad es la de destruir los bloques, o mejor dicho, la de lanzar la animación de destrucción del bloque y finzalizar el juego al acabar con todos los bloques, o, al salirse de la zona de juego. Para evitar probloemas y por lógica del juego, aunque la escena sea 3D los compoenentes sobre este juego son en 2D.

  + **Ball Material**: Es un material de unity que, junto al componente *RigidBody2D*, elimina la gravedad en el objeto, configura a este oara poder rebotar, consigue que la fuerza aplicada sobre la bola sea infinita, de forma que no pare jamás de desplazarse; y, define las coordenadas en las que puede desplazarse el objeto (x e y) y en las que puede rotar (ninguna).

    [imagen del inspector con mostrando el componente ballMaterial]

  + **BoxCollider2D**: Para controlar todo el tema de colisiones. En este caso, el collider que envuelve a la bola es un cuadrado rotado 45 grados para evitar problemas en los rebotes.

    [imagen del boxcollider de la bola del arkanoid]

+ Los bloques, que se reparten por la escena esperando a que la bola colisione con ellos y recibir así, la orden de que se lance su animación de destrucción y se aumente el marcador.
  + **Audio source**: el componente que da sonido a la acción de destrucción.
  + **Animacion**: la animación de destrucción que se lanza al colisionar con la bola. Esta se genera por interpolación, ya que es el sistema del que nos dota Unity, y lo que hace es reducir la escala del objeto a cero.

  [imagen de los 4 bloques de Arkanoid]
  
+ La plataforma:  Esta contiene un componente que reacciona a los eventos de  la pantalla táctil y que le permite deplazarse, además también tiene un *RigidBody2D* cuyas constraints impiden que pueda verse desplazado en el eje vertical o rotado.

+ Canvas: Contiene la información del estado del juego. Este objeto y sus hijos, a diferencia del resto, en escena, se muestra en función a la pantalla del dispositivo en el que se ejecuta el juego y no en función de lo que enfoca la cámara. Sus hijos son, el marcador, el contador de tiempo y la pantalla de precarga que muestra la información de la ejecución del juego al usuario.

##### Desarrollo

Para el Arkanoid, se han tenido que implementar las siguientes lógicas de juego:

1. **Captura de los eventos de pantalla**: El script que se encarga de capturar las pulsaciones en pantalla es *ScreenDragListener.cs*. En su método *Update()* se comprueba con cada llamada si la pantalla ha sido pulsada; si es así, se guarda el punto inicial donde se detectó la pulsación y se guarda, de forma que al volverse a llamar al método, esta vez, no solo se comprueba si ha habido contacto con la pantalla, sino que, además, se comprueba si ha habido variación en la posición del punto.

  El script, tiene una interfaz interna. En el método *Start()*, se comprueba todos los componentes que implementan dicha interfaz en la escena y se almacenan en un aray. Cada vez que se detecta y cálcula un movimiento de *drag* sobre la pantalla del dispositivo, se recorren los componentes del array. Estos reciben, a través del método, las variaciones en los ejes de la pulsación; y así pueden realizar las acciones correspondientes.

```c#
public class ScreenDragListener : MonoBehaviour {
	...
	private Component[] onDragListeners;
	...
	void Start () {
		onDragListeners = (Component[])GetComponentsInChildren(typeof(OnDragListener));
	}
	
	void Update () {
	  ...
	  if (horiz != 0 || vert != 0) {
					foreach(OnDragListener onDragListener in onDragListeners){
						onDragListener.onDrag (vert, horiz);
					}
				}
				touchOrigin = myTouch.position;
			}
		} else {
			foreach(OnDragListener onDragListener in onDragListeners){
				onDragListener.onRelease();
			}
		}
	}
	
	...
	public interface OnDragListener {
		  void onDrag (float vertical, float horizontal);
		  void onRelease();
	}
}
```

2. 

#### Conclusiones

### SPACE INVADERS

### WATER PIPES

### ESCENAS INTERMEDIAS

### SISTEMA DE PERSISTENCIA DE PUNTUACIONES

## BIBLIOGRAFIA

[https://es.wikipedia.org/wiki/Realidad_aumentada#Definiciones](https://es.wikipedia.org/wiki/Realidad_aumentada#Definiciones)

[http://www.ronaldazuma.com/publications.html](http://www.ronaldazuma.com/publications.html)
