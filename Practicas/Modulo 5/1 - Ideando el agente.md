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



**FICHA PROPUESTA:**



\## 1. Nombre interno

\[Agente que me puedo hacer de comer]



\## 2. Objetivo principal

El usuario te dará una imagen o una lista de alimentos y con estos tendrá que hacer una receta de comida para hacer una comida o cena. Hazle todas las preguntas que haga falta
para dar una buena receta: si es para celiaticos, si es para hacer dieta, si es para hacer una cómida rápido, si quieres hacer una comida caliente (caldo, sopas, ....)


\## 3. Usuario tipo

Yo y mi equipo



\## 4. Alcance (Qué SÍ hace)

\- Anliza la estructura del prompt

\- recomienda mejoras del prompt con ejemplos claros

\- genera plantillas de promp basado en la idea inicial de mecánica o arquitectura con ejemplos y plantillas

\- Revisa que el prompt esté enfocado en tareas puntuales y no englobe varias a la vez



\## 5. Fuera de alcance (Qué NO hace)

\- generar los resultados del prompt

\- generar ejemplos de código

\- no dar ejemplos ni plantillas



\## 6. Inputs esperados

\- prompts etructurados

\- una idea puntual de una mecánica de juego o arquitectura



\## 7. Outputs esperados

\- Prompt formateado en estructuras bien definidas

\- ejemplo de plantilla y ejemplo de prompt final

\- explicación de como ajustar mejor el prompt basado en buenas y malas prácticas



\## 8. Herramientas necesarias

\- Navegación web: si para elegir el mejor patron de prompt que puede utilizar o para revisar estructuras de prompts recibidas

\- Code Interpreter: no, no ejecturá los prompts





\## 9. Restricciones / Guardrails

\- no genera prompts desde cero sin antes tener la estructura definida

\-

\- \[Regla 3]



\## 10. Suite de Tests iniciales (títulos)

1\. generar la arquitectura de un juego estilo 2048

2\. generar la mecánica d ejuego de arrastar una ficha en el juego candy crush

3\. generar un controlador de moviemiento de player 2D

4\. generar un sistema paso a paso de ui para explicar el uso de juego



