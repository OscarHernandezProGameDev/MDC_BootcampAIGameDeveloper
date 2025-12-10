# Plantilla de formato de receta del agente

## 1. Objetivo del documento

Esta plantilla define el **formato estándar** que debe seguir el agente en todas las recetas que genere.

Beneficios:
- Facilita que el usuario entienda rápidamente la información importante (qué es, qué lleva, cómo se hace, cuánto tarda).
- Permite que otros sistemas puedan **parsear** o reutilizar las recetas de forma consistente.
- Mantiene un estilo homogéneo en el proyecto “Qué me puedo hacer de comer”.

---

## 2. Estructura obligatoria de la receta

Cada receta generada por el agente debe incluir, en este orden, las siguientes secciones:

1. **TÍTULO**  
2. **RESUMEN BREVE**  
3. **INGREDIENTES**  
4. **INSTRUCCIONES PASO A PASO**  
5. **TIEMPO ESTIMADO Y RACIONES**  
6. **VARIANTES Y SUSTITUCIONES**  
7. **RECORDATORIO DE RESTRICCIONES ATENDIDAS**

A continuación se detalla cómo debe escribir el agente cada sección.

---

## 3. TÍTULO

- Breve, descriptivo y claro.  
- Debe incluir el **ingrediente principal** y el **tipo de plato** cuando sea posible.
- Evitar títulos excesivamente genéricos.

**Ejemplos correctos:**
- “Salteado rápido de pollo con verduras y arroz”
- “Ensalada templada de garbanzos y verduras al horno”
- “Sopa ligera de verduras y arroz (apta para celíacos)”

---

## 4. RESUMEN BREVE

- 2–4 frases máximo.  
- Explicar de forma sencilla:
  - Qué tipo de plato es (sopa, ensalada, plato único, etc.).
  - Para qué contexto puede servir (comida/cena ligera, plato completo, etc.).
  - Cualquier característica relevante para el usuario (rápido, usa solo una sartén, sin horno, etc.).

**Ejemplo de resumen:**

> “Plato único rápido a la sartén con pollo, verduras y arroz ya cocido. Es una opción completa para comida o cena, fácil de adaptar a lo que tengas en la nevera. Solo necesitas una sartén y unos 20–25 minutos en total.”

---

## 5. INGREDIENTES

### 5.1. Formato

- Iniciar con una línea tipo:  
  - “Ingredientes para X raciones:”
- Listar los ingredientes en viñetas, uno por línea.
- Incluir cantidades aproximadas, preferiblemente en gramos/ml o unidades claras.

**Ejemplo de formato:**

> Ingredientes para 2 raciones:  
> - 250 g de pechuga de pollo en tiras  
> - 200 g de arroz ya cocido (puede ser de aprovechamiento)  
> - 1/2 pimiento rojo en tiras  
> - 1/2 calabacín en medias lunas  
> - 1/2 cebolla en juliana  
> - 2 cucharadas de aceite de oliva  
> - 2–3 cucharadas de salsa de soja (o equivalente sin gluten si hace falta)  
> - Sal y pimienta al gusto

### 5.2. Notas para el agente

- Si hay ingredientes opcionales, marcarlo explícitamente:  
  - “(opcional)” o “si tienes”.
- Adaptar cantidades al número de comensales indicado por el usuario.  
- Tener en cuenta las **restricciones** antes de proponer ingredientes (sin gluten, sin lácteos, vegano…).

---

## 6. INSTRUCCIONES PASO A PASO

### 6.1. Formato

- Enumerar los pasos como lista ordenada: 1, 2, 3…
- Cada paso debe ser **corto, claro y accionable**.
- Incluir señales visuales/temporales para que el usuario sepa que va bien.

**Ejemplo de pasos:**

1. Corta la pechuga de pollo en tiras finas y las verduras en trozos pequeños (pimiento y cebolla en tiras, calabacín en medias lunas).  
2. Calienta 1 cucharada de aceite en una sartén amplia a fuego medio-alto. Añade el pollo, sala ligeramente y cocínalo 4–5 minutos, hasta que esté dorado por fuera y hecho por dentro. Retíralo a un plato.  
3. En la misma sartén, añade la otra cucharada de aceite y echa la cebolla y el pimiento. Saltea 3–4 minutos, removiendo de vez en cuando, hasta que empiecen a estar tiernos.  
4. Agrega el calabacín y cocina 2–3 minutos más, hasta que las verduras estén tiernas pero aún con algo de firmeza.  
5. Incorpora el arroz cocido y el pollo reservado. Mezcla bien. Añade la salsa de soja (o su alternativa) y saltea todo junto 2–3 minutos, probando de sal al final.

### 6.2. Notas para el agente

- Adaptar el vocabulario al **nivel de cocina** del usuario (básico o intermedio).  
- Evitar agrupar demasiadas acciones en un único paso.  
- Usar las descripciones de técnicas definidas en la guía de técnicas (saltear, sofreír, pochar…).

---

## 7. TIEMPO ESTIMADO Y RACIONES

### 7.1. Formato

- Incluir un pequeño bloque al final, por ejemplo:

> Tiempo estimado: X minutos (preparación + cocción).  
> Raciones: X personas.

### 7.2. Notas para el agente

- Usar los tiempos de referencia del documento de **tiempos de cocción aproximados**.  
- Indicar claramente si el tiempo se reduce usando ingredientes ya cocidos (arroz de aprovechamiento, legumbres en conserva, etc.).

---

## 8. VARIANTES Y SUSTITUCIONES

### 8.1. Objetivo

Esta sección sirve para que el usuario pueda **adaptar la receta** a lo que tiene en casa o a sus preferencias sin necesidad de rehacer todo desde cero.

### 8.2. Formato sugerido

Utilizar viñetas o frases separadas. Ejemplos:

- “Si no tienes pollo, puedes usar pavo, tofu firme o garbanzos cocidos (escurridos y enjuagados).”  
- “En lugar de arroz, puedes usar pasta corta ya cocida o quinoa.”  
- “Para una versión sin gluten, usa salsa de soja sin gluten o tamari y asegúrate de que el arroz y el resto de ingredientes sean aptos.”

### 8.3. Uso de la tabla de sustituciones

- Apoyarse en el documento de **sustituciones y equivalencias culinarias** para ofrecer cambios coherentes (sin lácteos, sin gluten, sin huevo, más ligero, vegano).  
- Explicar en una frase cómo cambia el resultado (sabor, textura) si la sustitución es significativa.

---

## 9. RECORDATORIO DE RESTRICCIONES ATENDIDAS

### 9.1. Objetivo

Cerrar la receta recordando al usuario **qué restricciones se han tenido en cuenta** y emitiendo, si procede, un aviso de prudencia.

### 9.2. Formato sugerido

- Frases cortas al final de la receta, por ejemplo:

> “Receta adaptada para: sin gluten (usando salsa de soja sin gluten y revisando todos los productos envasados).”  
> “Receta adaptada para: sin lácteos (usando solo aceite y evitando quesos y mantequilla).”  
> “Receta apta para veganos si usas tofu o legumbres en lugar de pollo y verificas que la salsa utilizada no contenga productos animales.”

- Añadir, cuando sea relevante:

> “Recuerda revisar siempre las etiquetas de los productos envasados por si contienen o pueden contener el alérgeno que quieres evitar. Estas indicaciones son orientativas y no sustituyen el consejo de un profesional de la salud.”

---

## 10. Ejemplo completo de receta con la plantilla

A continuación se muestra un ejemplo completo siguiendo el formato estándar.

### TÍTULO

Salteado rápido de pollo con arroz y verduras de la nevera

### RESUMEN BREVE

Plato único rápido hecho en una sola sartén, ideal para aprovechar arroz ya cocido y verduras que tengas en la nevera. Es una opción completa para comida o cena, con proteína, hidratos y verduras, lista en unos 20–25 minutos.

### INGREDIENTES

Ingredientes para 2 raciones:

- 250 g de pechuga de pollo en tiras finas  
- 200 g de arroz ya cocido (puede ser del día anterior)  
- 1/2 pimiento (rojo o verde) en tiras  
- 1/2 calabacín en medias lunas  
- 1/2 cebolla en juliana  
- 2 cucharadas de aceite de oliva  
- 2–3 cucharadas de salsa de soja (o tamari sin gluten, si es necesario)  
- Sal y pimienta al gusto

### INSTRUCCIONES PASO A PASO

1. Prepara los ingredientes: corta el pollo en tiras finas. Corta la cebolla y el pimiento en tiras y el calabacín en medias lunas. Ten el arroz cocido listo.  
2. Calienta 1 cucharada de aceite en una sartén grande a fuego medio-alto. Añade el pollo, sala ligeramente y cocínalo 4–5 minutos, removiendo de vez en cuando, hasta que esté dorado por fuera y sin zonas rosadas por dentro. Retira el pollo a un plato.  
3. En la misma sartén, añade la otra cucharada de aceite y echa la cebolla y el pimiento. Saltea 3–4 minutos a fuego medio-alto, removiendo, hasta que empiecen a estar tiernos.  
4. Añade el calabacín y cocina 2–3 minutos más, hasta que las verduras estén tiernas pero aún con algo de firmeza (no demasiado blandas).  
5. Incorpora el arroz cocido y el pollo reservado. Remueve bien para repartir los ingredientes.  
6. Añade la salsa de soja (o su alternativa sin gluten) y saltea todo junto 2–3 minutos más. Prueba y ajusta de sal y pimienta al gusto. Sirve caliente.

### TIEMPO ESTIMADO Y RACIONES

- Tiempo estimado: 20–25 minutos (incluyendo preparación y cocción).  
- Raciones: 2 personas.

### VARIANTES Y SUSTITUCIONES

- Si no tienes pollo, puedes usar pavo, tofu firme en dados o garbanzos cocidos (bien escurridos y enjuagados).  
- Si no tienes arroz, puedes hacer algo similar con pasta corta ya cocida o con quinoa cocida.  
- Para una versión sin gluten, usa salsa de soja sin gluten o tamari y asegúrate de que el arroz y cualquier producto envasado sean aptos.  
- Para hacer el plato más ligero, reduce la cantidad de arroz y aumenta la cantidad de verduras.

### RECORDATORIO DE RESTRICCIONES ATENDIDAS

- En esta versión se puede adaptar la receta para:  
  - **Sin gluten**: utilizando salsa de soja sin gluten/tamari y revisando todos los productos envasados.  
  - **Sin lácteos**: la receta no usa lácteos por defecto.  
- Recuerda revisar siempre las etiquetas de los productos envasados por si contienen o pueden contener el alérgeno que necesitas evitar. Estas indicaciones son orientativas y no sustituyen el consejo de un profesional de la salud.