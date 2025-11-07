# 🧠 **Seminario: Mundos virtuales.**

> 💡 **Instrucciones:**  
> Responde a las siguientes cuestiones y, en los casos que sea posible, relaciónalas con los contenidos explicados en la sesión de *Mundos Virtuales*.  
> Usa ejemplos, imágenes o fragmentos de código cuando ayuden a ilustrar tu respuesta.

## 🌍 **Pregunta 1**
**🔹 Enunciado:**  
¿Qué funciones se pueden usar en los scripts de Unity para llevar a cabo traslaciones, rotaciones y escalados?  

**✏️ Respuesta:**  

Las funciones que se utilizan en Unity para realizar transformaciones en los *scripts* son las siguientes:

### 🔹 Traslaciones
- `Translate()`: permite mover un objeto de forma **relativa** respecto a su posición actual.  
  
  ```csharp
  transform.Translate(2, 0, 0); // Mueve el objeto 2 unidades en el eje X
  ```
### 🔹 Rotaciones
- `Rotate()`: realiza una rotación relativa expresada en grados.
  ```csharp
  transform.Rotate(0, 45, 0); // Rota el objeto 45º en el eje Y
  ```
- `LookAt()`: orienta el objeto para que mire hacia un punto objetivo.

  ```csharp
  transform.LookAt(target);
  ```
- `rotation`: define una rotación absoluta, normalmente usando `Quaternion`.

  ```csharp
  transform.rotation = Quaternion.Euler(0, 90, 0);
  ```
### 🔹 Escalado
- `localScale`: modifica el tamaño del objeto de manera absoluta en los tres ejes.

  ```csharp
  transform.localScale = new Vector3(2, 1, 1); // Escala el objeto al doble en el eje X
  ```

## 🌍 **Pregunta 2**
**🔹 Enunciado:**  
¿Cómo trasladarías la cámara 2 metros en cada uno de los ejes y luego la rotas 30º alrededor del eje Y?  
Rota la cámara alrededor del eje Y 30º y desplázala 2 metros en cada uno de los ejes.  
¿Obtendrías el mismo resultado en ambos casos? Justifica el resultado.  

**✏️ Respuesta:**  
  Para este caso hemos realizado dos scripts: uno de movimiento y rotación.  
  
👉[MovimientoRotación](./scripts/trasladarRotar.cs)

![img1](img/moverrotar.PNG)

  Y el segundo para rotar y luego mover.
  
👉[RotaciónMovimiento](./scripts/rotarTrasladar.cs)

![img2](img/rotarmover.PNG)

  Llegamos a la conclusión de que no es lo mismo rotar y mover que mover y rotar.Esto es porque la rotación cambia el sistema de ejes locales del objeto; si trasladas después, esa traslación se interpreta respecto a los ejes ya rotados, por lo que el vector de movimiento apunta en una dirección distinta. En cambio, si trasladas antes (cuando los ejes locales coinciden con los globales), la rotación posterior solo cambia la orientación del objeto y no su posición.


## 🌍 **Pregunta 3**
**🔹 Enunciado:**  
Sitúa la esfera de radio 1 en el campo de visión de la cámara y configura un volumen de vista que la recorte parcialmente.  

**✏️ Respuesta:**  
Se ha modificado la variable `near` de los planos de la cámara con los cuales se obtiene el frustum, de tal forma que corta parcialmente la esfera, esto provoca que se renderice parte de la misma.

![apartado3.png](media/apartado3.png)

## 🌍 **Pregunta 4**
**🔹 Enunciado:**  
Sitúa la esfera de radio 1 en el campo de visión de la cámara y configura el volumen de vista para que la deje fuera de la vista.  

**✏️ Respuesta:**  
Al modificar la variable `near` de los planos de la cámara que resultan en el frustum de tal forma que la esfera quede fuera de este volumen, provoca que la esfera no se renderice.

![apartado4.png](media/apartado4.png)

## 🌍 **Pregunta 5**
**🔹 Enunciado:**  
¿Cómo puedes aumentar el ángulo de la cámara? ¿Qué efecto tiene disminuir el ángulo de la cámara?  

**✏️ Respuesta:**  
 Podemos hacerlo con un script, pero de manera más comoda desde el inspector de escena.

 ![img](./img/capturacamara.PNG)

 En el Inspector de la cámara, podemos modificar el parámetro "Field of View"  bajo la sección de "Projection". Aumentar el valor del "Field of View" hará que la cámara abarque un ángulo más amplio, lo que puede generar una sensación de mayor amplitud o de espacio abierto. Disminuir el ángulo, reduciendo el valor del Field of View , hace que la cámara tenga un ángulo más cerrado, lo que podría resultar en una sensación de claustrofobia o enfoque en un área más reducida.

## 🌍 **Pregunta 6**
**🔹 Enunciado:**  
¿Es correcta la siguiente afirmación?  
> “Para realizar la proyección al espacio 2D, en el inspector de la cámara, cambiaremos el valor de *Projection*, asignándole el valor de *Orthographic*.”

**✏️ Respuesta:**  
En efecto esta sentencia si entendemos “proyección al espacio 2D” como una proyección sin profundidad (una vista ortográfica de un entorno 3D).

## 🌍 **Pregunta 7**
**🔹 Enunciado:**  
Especifica las rotaciones que se han indicado en los ejercicios previos con la utilidad `Quaternion`.  

**✏️ Respuesta:**  
Para ello hemos modificada los 2 scrips anteriores implementado Quaterniones

👉[MovimientoRotación](./scripts/trasladarMQuaterniones.cs)

👉[RotacioónMovimiento](./scripts/rotarTQuaerniones.cs)

  Al implementar cuaterniones conseguimos  que las rotaciones se realizan de forma más precisa y estable, evitando los problemas de Gimbal Lock (bloqueo de ejes) que pueden ocurrir al usar rotaciones basadas directamente en ángulos de Euler.

## 🌍 **Pregunta 8**
**🔹 Enunciado:**  
¿Cómo puedes averiguar la matriz de proyección en perspectiva que se ha usado para proyectar la escena al último *frame* renderizado?  

**✏️ Respuesta:**  
El componente `Camera` posee las variables `projectionMatrix` y `previousViewProjectionMatrix` las cuales almacenan las matrices de proyección utilizada en el frame actual, y la utilizada en el frame inmediatamente anterior respectivamente.

Podemos observar como se obtiene en el script [ProjectionApartado8.cs](src/ProjectionApartado8.cs).

![apartado8.png](media/apartado8.png)

## 🌍 **Pregunta 9**
**🔹 Enunciado:**  
¿Cómo puedes averiguar la matriz de proyección ortográfica que se ha usado para proyectar la escena al último *frame* renderizado?  

**✏️ Respuesta:**  

Para obtener la matriz de proyección ortográfica usada por la cámara en el último frame renderizado, se puede acceder a la propiedad `camera.projectionMatrix` dentro de un script en Unity. Hemos realizado un pequeño script de depuración llamado **[`ProjectionDebugger.cs`](./Scripts/ProjectionDebugger.cs)**. Este script obtiene la cámara del objeto al que está adjunto y muestra por consola su matriz de proyección con formato legible.

## 🌍 **Pregunta 10**
**🔹 Enunciado:**  
¿Cómo puedes obtener la matriz de transformación entre el sistema de coordenadas local y el mundial?  

**✏️ Respuesta:**  
Cada **GameObject** contiene su componente `Transform`, dicho componente posee las variables `worldToLocalMatrix` y `localToWorldMatrix`, las variables contienen las matrices de transformación entre los sistemas de referencia local y mundial.

Para obtener ambas matrices se puede utilizar el script [MatrixLocalWorldApartado10.cs](src/MatrixLocalWorldApartado10.cs).

![apartado10.png](media/apartado10.png)

## 🌍 **Pregunta 11**
**🔹 Enunciado:**  
¿Cómo puedes obtener la matriz para cambiar al sistema de referencia de vista?  

**✏️ Respuesta:**  
Podemos obtenerla con un script en C# como el que hemos realizado para este caso.

👉[MatrizDeVista](./scripts/matrizVista.cs)

![img3](img/matrizvista.PNG)

El resultado de la matriz de vista nos  dice dónde está la cámara y cómo está orientada en el espacio del mundo,

## 🌍 **Pregunta 12**
**🔹 Enunciado:**  
Especifica la matriz de proyección usada en un instante de la ejecución del ejercicio 1 de la práctica 1.  

**✏️ Respuesta:**  
En la escena de la práctica 3, se ha utilizado el script [MostrarMatrizApartado12.cs](src/MostrarMatrizApartado12.cs) para obtener la matriz de proyección.

![apartado12.png](media/apartado12.png)

## 🌍 **Pregunta 13**
**🔹 Enunciado:**  
Especifica la matriz de modelo y vista de la escena del ejercicio 1 de la práctica 1.

**✏️ Respuesta:**  
En la escena de la práctica 3, se ha utilizado el script [MostrarMatricesApartado13.cs](src/MostrarMatricesApartado13.cs) para obtener la matriz de modelo de la cápsula y la matriz de vista de la cámara.

![apartado13_1.png](media/apartado13_1.png)
![apartado13_2.png](media/apartado13_2.png)

## 🌍 **Pregunta 14**
**🔹 Enunciado:**  
Aplica una rotación en el método `Start()` de uno de los objetos de la escena y muestra la matriz de cambio al sistema de referencias mundial.  

**✏️ Respuesta:**  
Este es el scipt que hemos usado para obtener la matriz de cambio.

👉[MatrizDeCambio](./scripts/matrizCambio.cs)

![img4](img/matizcambio.PNG)

Los números de rotación (0.7071) provienen de la  de un giro de 45° sobre el eje Y,
y los de posición (1.4440, 2.0600, 0.4800) se leen directamente de la última columna de la matriz.

## 🌍 **Pregunta 15**
**🔹 Enunciado:**  
¿Cómo puedes calcular las coordenadas del sistema de referencia de un objeto con las siguientes propiedades del `Transform`?  
- Position: (3, 1, 1)  
- Rotation: (45, 0, 45)

**✏️ Respuesta:**  

Se ha utilizado el script **[`ReferenceSystem.cs`](./Scripts/ReferenceSystem.cs)**, que obtiene e imprime en consola la posición del origen y los ejes locales expresados en coordenadas globales. El script también muestra la matriz `localToWorldMatrix`, que combina traslación, rotación y escala, y permite transformar cualquier punto del espacio local a coordenadas mundiales.

![imgEjer15](./Multimedia/Ejer15.png)

## 🌍 **Pregunta 16**
**🔹 Enunciado:**  
Crea una escena en Unity con los siguientes elementos:  
- Cámara principal  
- Plano base (como suelo)  
- Tres cubos de distinto color (rojo, verde y azul) en posiciones distintas  

Realiza un script de depuración adjunto a la cámara que muestre en consola o pantalla las matrices de transformación (`Model`, `View`, `Projection`) y sus resultados sobre un vértice de cada cubo.  

**✏️ Respuesta:**  
Se ha creado la escena con los elementos necesarios, y el script [DebugVertex.cs](src/DebugVertex.cs) para calcular las coordenadas respecto al clip de la cámara en base a cada vértice izquierdo más próximo a la cámara de cada cubo.

![apartado16.png](media/apartado16.png)

## 🌍 **Pregunta 17**
**🔹 Enunciado:**  
Dibuja en un programa el recorrido de las coordenadas de un vértice específico del cubo rojo:  
`Local → World → Camera/View → Clip → NDC → Viewport`.  
Indica cómo cambia su valor en cada espacio.  
Aplica la transformación manualmente a un punto (por ejemplo `(0.5, 0.5, 0.5)`) y registra los resultados paso a paso.  

**✏️ Respuesta:**  
Se ha aplicado el proceso de conversión de coordenadas locales hasta coordenadas en el viewport como utilizando el script [DebugVertexApartado17.cs](src/DebugVertexApartado17.cs).

Procedimiento a papel:
![calculosApartado17.png](media/calculosApartado17.png)

Y podemos verlo en Unity:
![apartado17.png](media/apartado17.png)

## 🌍 **Pregunta 18**
**🔹 Enunciado:**  
Mueve o rota uno de los cubos y muestra cómo cambian los valores de su matriz de modelo. Rota la cámara y muestra cómo se modifica la matriz de vista. Cambia entre proyección ortográfica y perspectiva y compara las diferencias numéricas en la matriz de proyección.  

**✏️ Respuesta:**  
Para responder a la pregunta se dividirá en tres apartados:  
1. El primero consiste en la rotación o movimiento de un cubo y exponer los valores de la matriz. Para ello se le hizo un movimiento a la posición (2, 1, 0) partiendo de (0, 0.5, 0). Además una rotación de 15º en X y Z. A continuación se muestran las matrices:

    🟦 Matriz inicial de modelo:
    | m00 | m01 | m02 | m03 |
    |:----:|:----:|:----:|:----:|
    | 1.000 | 0.000 | 0.000 | 0.000 |
    | 0.000 | 1.000 | 0.000 | 0.500 |
    | 0.000 | 0.000 | 1.000 | 0.000 |
    | 0.000 | 0.000 | 0.000 | 1.000 |

    🔁 Matriz de modelo actualizada:
    | m00 | m01 | m02 | m03 |
    |:----:|:----:|:----:|:----:|
    | 0,9659 | -0,2588 | 0,0000 | 2,0000 |
    | 0,2500 | 0,9330 | -0,2588 | 1,0000 |
    | 0,0670 | 0,2500 | 0,9659 | 0,0000 |
    | 0,0000 | 0,0000 | 0,0000 | 1,0000 |

2. En el segundo se realizó el script **[`ViewMatrixDebugger.cs`](./Scripts/ViewMatrixDebbuger.cs)** a la cámara principal (`Main Camera`). Al ejecutar la escena y rotar la cámara +45° en Y se registra la matriz `Camera.worldToCameraMatrix` antes y después del cambio.

    🟦 Matriz inicial de modelo:
    | m00 | m01 | m02 | m03 |
    |:----:|:----:|:----:|:----:|
    | 1.000 | 0.000 | 0.000 | 0.000 |
    | 0.000 | 1.000 | 0.000 | -1.000 |
    | 0.000 | 0.000 | 1.000 | -10.000 |
    | 0.000 | 0.000 | 0.000 | 1.000 |

    🔁 Matriz de modelo actualizada:
    | m00 | m01 | m02 | m03 |
    |:----:|:----:|:----:|:----:|
    | 0,7071 | 0,0000 | -0,7071 | -7,0711 |
    | 0,0000 |  1,0000 |  0,0000 | -1,0000 |
    | -0,7071 |  0,0000 | -0,7071 | -7,0711 |
    | 0,0000 | 0,0000 | 0,0000 | 1,0000 |

3. Para analizar las diferencias entre ambos tipos de proyección se usó el script **[`ProjectionMatrixDebugger.cs`](./Scripts/ProjectionMatrixDebugger.cs)**, que muestra en consola la matriz `Camera.projectionMatrix` y permite alternar entre modos pulsando la tecla **C**.

    🟦 Matriz inicial de modelo:
    | m00 | m01 | m02 | m03 |
    |:----:|:----:|:----:|:----:|
    | 0,0620 | 0,0000 | 0,0000 | 0,0000 |
    | 0.000 | 2.000 | 0.000 | 0.000 |
    | 0.000 | 0.000 | 0.0020 | -1,0006 |
    | 0,0000 | 0,0000 | 0,0000 | 1,0000 |

    🔁 Matriz de modelo actualizada:
    | m00 | m01 | m02 | m03 |
    |:----:|:----:|:----:|:----:|
    | 0,0000 | 0,0000 | 0,0000 | 1,0000 |
    | 0,0000 | 1,7321 | 0,0000 | 0,0000 |
    | 0,0000 | 0,0000 | -1,0006 | -0,6002 |
    | 0,0000 |  0,0000 | -1,0000 | 0,0000 |
