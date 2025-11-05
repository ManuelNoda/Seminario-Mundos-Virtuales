# 🧠 **Seminario: Mundos virtuales.**

> 💡 **Instrucciones:**  
> Responde a las siguientes cuestiones y, en los casos que sea posible, relaciónalas con los contenidos explicados en la sesión de *Mundos Virtuales*.  
> Usa ejemplos, imágenes o fragmentos de código cuando ayuden a ilustrar tu respuesta.

## 🌍 **Pregunta 1**
**🔹 Enunciado:**  
¿Qué funciones se pueden usar en los scripts de Unity para llevar a cabo traslaciones, rotaciones y escalados?  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 2**
**🔹 Enunciado:**  
¿Cómo trasladarías la cámara 2 metros en cada uno de los ejes y luego la rotas 30º alrededor del eje Y?  
Rota la cámara alrededor del eje Y 30º y desplázala 2 metros en cada uno de los ejes.  
¿Obtendrías el mismo resultado en ambos casos? Justifica el resultado.  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 3**
**🔹 Enunciado:**  
Sitúa la esfera de radio 1 en el campo de visión de la cámara y configura un volumen de vista que la recorte parcialmente.  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 4**
**🔹 Enunciado:**  
Sitúa la esfera de radio 1 en el campo de visión de la cámara y configura el volumen de vista para que la deje fuera de la vista.  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 5**
**🔹 Enunciado:**  
¿Cómo puedes aumentar el ángulo de la cámara? ¿Qué efecto tiene disminuir el ángulo de la cámara?  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 6**
**🔹 Enunciado:**  
¿Es correcta la siguiente afirmación?  
> “Para realizar la proyección al espacio 2D, en el inspector de la cámara, cambiaremos el valor de *Projection*, asignándole el valor de *Orthographic*.”

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 7**
**🔹 Enunciado:**  
Especifica las rotaciones que se han indicado en los ejercicios previos con la utilidad `Quaternion`.  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 8**
**🔹 Enunciado:**  
¿Cómo puedes averiguar la matriz de proyección en perspectiva que se ha usado para proyectar la escena al último *frame* renderizado?  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 9**
**🔹 Enunciado:**  
¿Cómo puedes averiguar la matriz de proyección ortográfica que se ha usado para proyectar la escena al último *frame* renderizado?  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 10**
**🔹 Enunciado:**  
¿Cómo puedes obtener la matriz de transformación entre el sistema de coordenadas local y el mundial?  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 11**
**🔹 Enunciado:**  
¿Cómo puedes obtener la matriz para cambiar al sistema de referencia de vista?  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 12**
**🔹 Enunciado:**  
Especifica la matriz de proyección usada en un instante de la ejecución del ejercicio 1 de la práctica 1.  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 13**
**🔹 Enunciado:**  
Especifica la matriz de modelo y vista de la escena del ejercicio 1 de la práctica 1.  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 14**
**🔹 Enunciado:**  
Aplica una rotación en el método `Start()` de uno de los objetos de la escena y muestra la matriz de cambio al sistema de referencias mundial.  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 15**
**🔹 Enunciado:**  
¿Cómo puedes calcular las coordenadas del sistema de referencia de un objeto con las siguientes propiedades del `Transform`?  
- Position: (3, 1, 1)  
- Rotation: (45, 0, 45)

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 16**
**🔹 Enunciado:**  
Crea una escena en Unity con los siguientes elementos:  
- Cámara principal  
- Plano base (como suelo)  
- Tres cubos de distinto color (rojo, verde y azul) en posiciones distintas  

Realiza un script de depuración adjunto a la cámara que muestre en consola o pantalla las matrices de transformación (`Model`, `View`, `Projection`) y sus resultados sobre un vértice de cada cubo.  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 17**
**🔹 Enunciado:**  
Dibuja en un programa el recorrido de las coordenadas de un vértice específico del cubo rojo:  
`Local → World → Camera/View → Clip → NDC → Viewport`.  
Indica cómo cambia su valor en cada espacio.  
Aplica la transformación manualmente a un punto (por ejemplo `(0.5, 0.5, 0.5)`) y registra los resultados paso a paso.  

**✏️ Respuesta:**  
...

## 🌍 **Pregunta 18**
**🔹 Enunciado:**  
Mueve o rota uno de los cubos y muestra cómo cambian los valores de su matriz de modelo.  
Rota la cámara y muestra cómo se modifica la matriz de vista.  
Cambia entre proyección ortográfica y perspectiva y compara las diferencias numéricas en la matriz de proyección.  

**✏️ Respuesta:**  
...

## 📝 **Notas finales**
- Utiliza formato Markdown para una mejor presentación:  
  - **Negrita** → conceptos clave  
  - *Cursiva* → ejemplos o aclaraciones  
  - `Código` → términos técnicos  
- Si una pregunta requiere un cálculo, inclúyelo así:

  ```text
  Ejemplo de cálculo:
  Z = X + Y / 2
