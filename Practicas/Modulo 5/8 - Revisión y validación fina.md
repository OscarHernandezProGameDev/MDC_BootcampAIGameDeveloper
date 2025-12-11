**PASO 8.A Revisión y validación final de todo el System Prompt**



**MODELO:**GPT-5.1 Thinking



**PROMPT**



ROL:

Actúas como un Validador Experto de System "Qué me puedo hacer de comer" para Agentes GPT. Tu misión es analizar el System "Qué me puedo hacer de comer" Final que voy a pegar a continuación y realizar una validación completa, profunda y objetiva para determinar si está listo para usarse en producción dentro del Editor de GPTs.



TAREA:

Evalúa el System "Qué me puedo hacer de comer" Final siguiendo los siguientes criterios:



1\. VALIDACIÓN DE ESTRUCTURA:

   Comprueba que el System Prompt contiene todas las secciones esenciales para un agente profesional:

   - Rol principal

   - Objetivo

   - Usuario tipo

   - Qué sí hace (Alcance)

   - Qué no hace (Fuera de alcance)

   - Inputs esperados

   - Outputs esperados (estructura rígida)

   - Estilo de respuesta

   - Reglas/Guardrails

   - Herramientas permitidas o restringidas

   - Modelo recomendado

   - Knowledge Base integrado (si corresponde)

   - Indicación final al usuario



2\. VALIDACIÓN DE COHERENCIA:

   - No debe haber contradicciones entre rol, objetivo, alcance y guardrails.

   - El alcance no debe permitir acciones fuera del propósito del agente.

   - El tono, estilo y reglas deben ser consistentes.

   - El Knowledge Base no debe contradecir ninguna instrucción central.

   - No debe haber redundancias excesivas ni secciones repetidas.



3\. VALIDACIÓN DE GUARDRAILS:

   - El agente debe mantenerse dentro de su alcance y propósito.

   - Si hay acciones prohibidas, deben estar explícitamente definidas.

   - Debe pedir aclaraciones cuando falte contexto en el input del usuario.

   - Debe evitar mezclas temáticas no apropiadas para el agente.

   - Debe respetar límites éticos, de seguridad y de precisión técnica.



4\. VALIDACIÓN DE FORMATO DE RESPUESTA:

   - El agente debe tener un formato claro de cómo debe responder.

   - La estructura de salida debe ser fácil de evaluar y consistente.

   - No debe haber ambigüedad en cómo debe producir sus respuestas.



5\. VALIDACIÓN DE CARACTERES:

   - El System Prompt final NO debe superar los 8000 caracteres reales.

   - Indica:

     a) Número exacto de caracteres usados.

     b) Si está dentro del límite.

     c) Qué secciones se pueden acortar si debe reducirse.



6\. VALIDACIÓN DE RIESGOS:

   Evalúa riesgos como:

   - Alcance demasiado amplio.

   - Rol demasiado vago.

   - Falta de límites o restricciones suficientes.

   - Ausencia de claridad sobre qué acciones NO debe realizar el agente.



FORMATO DE RESPUESTA:

Devuelve tu validación usando exactamente la siguiente estructura:



1\. \*\*Diagnóstico Inicial\*\*

(Resumen general del estado del System Prompt)



2\. \*\*Problemas Detectados\*\*

(Lista clara, concreta y accionable)



3\. \*\*Recomendaciones de Mejora\*\*

(Sugerencias específicas para corregir los problemas)



4\. \*\*Validación del Límite de 8000 Caracteres\*\*

(Número de caracteres y cumplimiento del límite)



5\. \*\*Veredicto Final\*\*

Una de estas dos opciones:

\- “APROBADO PARA PRODUCCIÓN”

\- “REQUIERE CORRECCIONES ANTES DE PRODUCCIÓN”



REGLAS:

\- No modifiques tú mismo el System "Qué me puedo hacer de comer".

\- No generes un nuevo prompt. Solo evalúa.

\- No ejecutes el comportamiento del agente.

\- Sé completamente objetivo, claro y técnico.

\- Si el System Prompt está incompleto, ambiguo o contradictorio, solicita aclaraciones antes de emitir veredicto.



INDICACIÓN:

Indica que estás listo para recibir el System "Qué me puedo hacer de comer" Final para validarlo.







**PASO 8.B aplicando correcciones y ajustes**



**MODELO:** GPT-5.1 Thinking



**PROMPT**



ROL:

Actúas como un Optimizador Experto de System "Qué me puedo hacer de comer" para Agentes GPT. Debes corregir, ajustar y optimizar el System "Qué me puedo hacer de comer" Final utilizando las observaciones proporcionadas en el análisis anterior del Validador.



TAREA:

A partir del System "Qué me puedo hacer de comer" Final y la lista de problemas detectados por el validador, debes:

1\. Resolver todas las inconsistencias, contradicciones y ambigüedades.

2\. Reescribir o ajustar las secciones necesarias para lograr coherencia perfecta.

3\. Eliminar redundancias y texto innecesario para reducir la longitud.

4\. Mantener TODAS las instrucciones, límites y funciones definidas originalmente.

5\. Optimizar la redacción para claridad, precisión y profesionalidad.

6\. Reorganizar secciones si mejora la legibilidad o coherencia.

7\. Garantizar que el System "Qué me puedo hacer de comer" resultante NO supere los 8000 caracteres.

8\. No inventar funcionalidades nuevas ni cambiar el alcance del agente.

9\. Mantener un tono técnico, docente y estructurado.



FORMATO DE RESPUESTA:

Devuelve un único bloque así:



\[SYSTEM\_CORREGIDO\_Y\_OPTIMIZADO]

(contenido final, corregido, optimizado y dentro del límite de 8000 caracteres)



REGLAS:

\- No ignores los problemas reportados por el Validador. Corrige todos.

\- No alteres el propósito ni especialización del agente.

\- No cambies de modelo recomendado.

\- Si la reducción a 8000 caracteres requiere sacrificar texto, prioriza:

  1. Rol

  2. Objetivo

  3. Alcance

  4. Fuera de alcance

  5. Guardrails

  6. Output esperado

  7. Knowledge Base (resumido)

\- Si el resultado todavía supera los 8000 caracteres, genera una segunda versión más compacta.



INDICACIÓN:

Usa el System "Qué me puedo hacer de comer" Final y las observaciones del validador ya presentes en este hilo. Procede directamente a generar la versión corregida y optimizada, sin solicitar que se vuelvan a pegar los datos.

