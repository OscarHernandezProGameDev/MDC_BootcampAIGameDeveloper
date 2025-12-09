**WORKFLOW CREACIÓN DE AGENTES**





**PASO 1 Diseño inicial del agente

Estructura:**

1. Nombre

2\. Objetivo

3\. Usuario tipo

4\. Alcance

5\. Fuera de alcance

6\. Inputs

7\. Outputs

8\. Herramientas

9\. Guardrails

10\. Tests



**Plantilla:**



\# FICHA DE DISEÑO DEL AGENTE

\## 1. Nombre interno

\[Ej: Agente Revisor de Prompts Unity 6.2]



\## 2. Objetivo principal

\[¿Qué problema resuelve? ¿Para qué lo usarás?]



\## 3. Usuario tipo

\[¿Quién lo usará? Tú, equipo...]



\## 4. Alcance (Qué SÍ hace)

\- \[Punto 1]

\- \[Punto 2]

\- \[Punto 3]



\## 5. Fuera de alcance (Qué NO hace)

\- \[Punto A]

\- \[Punto B]

\- \[Punto C]



\## 6. Inputs esperados

\- \[Tipo de contenido que recibe]

\- \[Nivel de detalle mínimo que necesita]



\## 7. Outputs esperados

\- \[Formato]

\- \[Estructura]

\- \[Uso final]



\## 8. Herramientas necesarias

\- Navegación web: \[Sí/No y por qué]

\- Code Interpreter: \[Sí/No y por qué]

\- Otros: \[Si aplica]



\## 9. Restricciones / Guardrails

\- \[Regla 1]

\- \[Regla 2]

\- \[Regla 3]



\## 10. Suite de Tests iniciales (títulos)

1\. \[Test 1]

2\. \[Test 2]

3\. \[Test 3]

4\. \[Test 4]

5\. \[Test 5]

6\. \[Test 6]

7\. \[Test 7]

8\. \[Test 8]

9\. \[Test 9]

10\. \[Test 10]

### Desarrollar Objetivo principal

CONTEXTO:

Hoy hacer un gpt con una base de conocimientos de recetas y conceptos de alimentación para hacer una receta para hacerme de comer.

TAREA:

Desarrollame mejor el objetivo principal que he hecho:

El usuario te dará una imagen o una lista de alimentos y con estos tendrá que hacer una receta de comida para hacer una comida o cena. Hazle todas las preguntas que haga falta
para dar una buena receta: si es para celiaticos, si es para hacer dieta, si es para hacer una cómida rápido, si quieres hacer una comida caliente (caldo, sopas, ....)

RETRICCIONES:

Solo quiero el desarrollo del objetivo principal

OUTPUT:

El texto plano del objetivo principal


**FICHA PROPUESTA:**



\## 1. Nombre interno

\[Agente que me puedo hacer de comer]



\## 2. Objetivo principal

El objetivo principal consiste en generar, a partir de una imagen o de una lista de alimentos proporcionados por el usuario, una propuesta de receta totalmente adaptada a sus necesidades y preferencias. Para construir la receta más adecuada, el sistema deberá realizar todas las preguntas necesarias relacionadas con restricciones alimentarias (por ejemplo, celiaquía u otras intolerancias), objetivos nutricionales (como si el usuario está siguiendo una dieta), condiciones de preparación (si requiere una comida rápida o con un tiempo de elaboración determinado) y preferencias sobre el tipo de plato (caliente, frío, sopas, caldos, etc.). El propósito final es entregar una receta personalizada, viable y optimizada en función de los ingredientes disponibles y las especificaciones del usuario.


\## 3. Usuario tipo

Yo y mi equipo



\## 4. Alcance (Qué SÍ hace)

\- Anliza la lista de alimentos propocionados

\- preguntar lo necesario para garantizar el objetivo principal

\- genera la receta sobre los alimentos propocionados,las preguntas hechas y que garantice el objetivo principal

\- Revisa que los alimentos proporcioados sean correctos


\## 5. Fuera de alcance (Qué NO hace)

\- solo generará la receta


\## 6. Inputs esperados

\- receta que cumpla los conceptos alimentarios


\## 7. Outputs esperados

\- Prompt formateado en estructuras bien definidas


\## 8. Herramientas necesarias

\- Navegación web: si buscar mas recetas y conocimiento de alimentación

\- Code Interpreter: no, no ejecturá los prompts





\## 9. Restricciones / Guardrails

\- solo generará la receta

\## 10. Suite de Tests iniciales (títulos)

1\. generar ejemplos de lista de alimentos para hacer una comida
2\. generar ejemplos de alimentos que puedes usar para hacerte de comer que esten en la nevera
