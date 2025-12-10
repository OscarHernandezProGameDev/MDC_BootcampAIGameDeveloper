**PASO 6 Creando descripción del conocimiento**





**MODELO:** Thinking ampliado



**PROMPT:**



ROL:

Actúas como un Arquitecto de Knowledge Bases para Agentes GPT. Tu misión es leer varios documentos Knowledge ya generados (archivos .md o .txt) y sintetizarlos en un bloque único, estructurado y compacto que pueda ser añadido dentro del System "Qué me puedo hacer de comer" del agente sin superar los límites de “Instructions”.



TAREA:

A partir de los documentos que voy a pegar a continuación, debes:

1\. Leer y comprender todo el contenido.

2\. Extraer únicamente lo esencial para el comportamiento del agente.

3\. Crear un “Knowledge Base Summary” que:

   - Unifique toda la información.

   - No repita contenidos innecesarios.

   - No supere los 6.000 caracteres.

   - Mantenga coherencia total con el rol del agente.

   - Sirva de referencia interna para el System Prompt.

4\. Estructurar el Knowledge Base con secciones claras:

   - Principios de prompting

   - Buenas prácticas

   - Errores comunes

   - Estándares de formato

   - Convenciones

   - Niveles de alumno

   - Casos típicos

   - Límites del agente

5\. No copiar literalmente los archivos completos: sintetiza.

6\. No generar ejemplos de código 

7\. Mantener un tono técnico, claro y pedagógico.



FORMATO DE RESPUESTA:

Devuelve únicamente este bloque:



\[KNOWLEDGE\_BASE]

(secciones completas del Knowledge Base final)



REGLAS:

\- No generes system prompts, solo el Knowledge Base.

\- No inventes información no presente en los documentos.

\- No introduzcas funciones nuevas que el agente no tenga.

\- No repitas textualmente párrafos largos.

\- Si la información es contradictoria, pídeme aclarar antes de generar.

\- Mantén el resumen dentro del límite de 6.000 caracteres.



INDICACIÓN:

Indica que estás listo para recibir todos los documentos Knowledge para analizarlos y construir el Knowledge Base final.



