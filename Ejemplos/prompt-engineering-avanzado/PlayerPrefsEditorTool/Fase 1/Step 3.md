### PUNTO 1 → aporta contenido técnico
* OBJETIVO        → TASK
* ALCANCE         → CONTEXT
* RESTRICCIONES   → CONSTRAINTS
* AUDIENCIA       → ROL
* CRITERIOS       → OUTPUT

### PUNTO 2 → aporta cómo debe pensar GPT

* TIPO DE PROMPT      → Selección de plantilla
* MODELO              → Selección de modelo en ejecución

### PUNTO 3 → aporta estructura formal

**PLANTILLA FINAL:**

**ROL:**  
Eres un desarrollador senior de Unity 6.2 y C# moderno.

**TASK:**  
Diseñar un script de editor que cree EditorWindow para Mostrar, crear, editar o borrar los PlayerPrefs del juego.

**CONTEXT:**  
Debe incluir layout, botones, validaciones y flujo general.

**CONSTRAINTS:**
- Unity 6.2
- C# moderno con properties
- Evitar singletons globales
- Código compilable y limpio
- Un archivo por salida
- Comentarios breves con ///
- Compatible con Unity UI.

**OUTPUT:**  
- Diseño claro, extensible, sin acoplar UI con lógica de datos.
- Código completo en bloque listo para pegar.

**TIPO DE PROMPT:**  
Generativo

**MODELO GPT RECOMENDADO:**  
GPT-5.1 Instant (ideal para iterar rápido en código)
