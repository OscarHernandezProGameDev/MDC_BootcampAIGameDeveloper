# Base de recetas por ingrediente y tipo de plato

## 1. Objetivo del documento

Este documento define **recetas modelo** que el agente puede reutilizar y adaptar según:
- Los ingredientes disponibles.
- El tipo de plato (sopa, guiso, ensalada, plato único, salteado rápido, etc.).
- Las restricciones y preferencias del usuario (celiaquía, vegano, comer ligero, alta proteína, etc.).

Las recetas son **plantillas estructurales**, no textos cerrados. El agente debe:
1. Elegir la plantilla que mejor encaje.
2. Ajustar ingredientes, cantidades y técnicas al contexto.
3. Adaptar la explicación al nivel de cocina (básico o intermedio).

---

## 2. Convenciones generales

- **Raciones por defecto**: 2 raciones (ajustar a lo que pida el usuario).
- **Medidas orientativas por persona**:
  - Proteína: 120–150 g (pollo, pescado, tofu, legumbres cocidas).
  - Cereales / féculas: 60–80 g en crudo (pasta, arroz) o 200 g de patata.
  - Verduras: 150–200 g mínimos.
- **Sazonado base**: sal, pimienta, aceite de oliva, ajo y/o cebolla.
- El agente puede:
  - Cambiar verduras por otras similares (calabacín ↔ berenjena, espinacas ↔ acelgas).
  - Modificar especias manteniendo técnica (tomate/orégano ↔ curry/comino).
  - Omitir o sustituir ingredientes para respetar alergias y preferencias.

---

## 3. Tipos de plato (mapa rápido)

- **Sopa / caldo**: más líquido, plato de cuchara.
- **Guiso / estofado**: cocción algo más lenta, salsa espesa.
- **Salteado rápido**: fuego medio/alto, ingredientes cortados pequeños, tiempos cortos.
- **Plato único al horno**: todo en una bandeja (proteína + verdura + fécula).
- **Ensalada (fría o templada)**: base de verduras, con proteína opcional.
- **Bowl / plato combinado**: componentes separados en un mismo plato (cereal + proteína + verdura + salsa).

El agente debe traducir formulaciones del usuario (“algo rápido a la sartén”, “un plato de cuchara”, “una ensalada completa”) a uno de estos tipos.

---

## 4. Pollo como ingrediente principal

Se asume pollo troceado (pechuga o contramuslo deshuesado).

### 4.1. Sopa de pollo con verduras y pasta o arroz

**Ingredientes modelo (2 raciones)**  
- 200–250 g de pollo en dados pequeños.  
- 1 zanahoria en rodajas finas, 1/2 cebolla picada.  
- 1 trozo de puerro o apio (opcional).  
- 60 g de pasta pequeña o 50 g de arroz.  
- 1–1,2 l de agua o caldo suave.  

**Pasos clave**  
1. Sofreír ligeramente cebolla (y puerro/apio).  
2. Añadir pollo y dorar.  
3. Incorporar agua/caldo y zanahoria; hervir suave.  
4. Añadir pasta/arroz y cocer hasta que esté en su punto.  
5. Ajustar de sal y servir.

**Variantes**  
- Más ligera: más caldo y menos pasta/arroz.  
- Toque asiático rápido: un poco de salsa de soja y jengibre.

---

### 4.2. Guiso de pollo con patata y verdura

**Ingredientes modelo (2 raciones)**  
- 250 g de pollo en trozos.  
- 3 patatas pequeñas en trozos.  
- 1 zanahoria o 1/2 calabacín a dados.  
- 1/2 cebolla, 1 diente de ajo.  
- 400–500 ml de agua o caldo.  
- Pimentón, laurel o hierbas secas.

**Pasos clave**  
1. Sofreír cebolla y ajo; añadir pimentón fuera del fuego.  
2. Incorporar pollo y dorar.  
3. Añadir patata, verdura y líquido casi hasta cubrir.  
4. Cocer tapado a fuego medio-bajo hasta que la patata esté tierna.

**Variantes**  
- Con tomate: añadir tomate triturado al sofrito.  
- Estilo curry suave: usar curry y, si procede, un poco de leche de coco.

---

### 4.3. Salteado rápido de pollo con verduras

**Ingredientes modelo (2 raciones)**  
- 250 g de pollo en tiras finas.  
- 1 pimiento, 1/2 calabacín en bastones, 1/2 cebolla en pluma.  
- 2–3 cucharadas de salsa (soja, o aceite + limón + especias).

**Pasos clave**  
1. Cortar todo en tiras finas.  
2. Saltear pollo a fuego medio-alto; retirar.  
3. Saltear verduras 3–5 minutos.  
4. Devolver pollo, añadir salsa, mezclar 1–2 minutos.

**Servicio**  
- Solo (plato bajo en hidratos) o acompañado de arroz/pasta ya cocidos.

---

### 4.4. Plato único de pollo al horno con patata y verduras

**Ingredientes modelo (2 raciones)**  
- 2 muslos o 250 g de pollo en dados grandes.  
- 2 patatas en gajos.  
- Verduras para horno (zanahoria, cebolla, pimiento…).  
- Aceite, sal, pimienta, hierbas secas.

**Pasos clave**  
1. Mezclar patata y verduras con aceite, sal y especias.  
2. Colocar en bandeja y añadir el pollo.  
3. Hornear a temperatura media-alta hasta que el pollo esté hecho y las patatas tiernas.

---

### 4.5. Ensalada templada de pollo

**Ingredientes modelo (2 raciones)**  
- 200 g de pollo a la plancha o salteado, en tiras.  
- Hojas verdes, tomate, zanahoria rallada.  
- 60–80 g de pan, arroz o pasta (opcional).  
- Aliño (aceite + ácido + sal).

**Pasos clave**  
1. Cocinar el pollo y cortarlo.  
2. Preparar la base de ensalada.  
3. Añadir pollo templado y el hidrato si lo hay.  
4. Aliñar al final.

---

## 5. Arroz como ingrediente principal

### 5.1. Arroz salteado (“frito”) con verduras y proteína

**Ingredientes modelo (2 raciones)**  
- 200 g de arroz ya cocido.  
- 1 huevo por persona o 100 g de pollo/tofu/atún.  
- Verduras en trocitos (zanahoria, guisantes, maíz, pimiento…).  
- Salsa de soja u otra salsa adecuada.

**Pasos clave**  
1. Saltear verduras.  
2. Añadir proteína (atún siempre al final).  
3. Incorporar arroz y mezclar a fuego medio-alto.  
4. Aliñar con salsa de soja u otra.

---

### 5.2. Arroz caldoso sencillo o tipo sopa

**Ingredientes modelo (2 raciones)**  
- 120 g de arroz.  
- 1 l de caldo o agua.  
- Verduras y/o pollo, pescado o legumbres.  

**Pasos clave**  
1. Sofreír base (cebolla, ajo, algo de verdura).  
2. Añadir arroz y rehogar.  
3. Incorporar líquido caliente e ingredientes restantes.  
4. Cocer hasta que el arroz esté tierno y el conjunto caldoso.

---

### 5.3. Ensalada de arroz fría

**Ingredientes modelo (2 raciones)**  
- 160 g de arroz cocido y frío.  
- Verduras (tomate, maíz, zanahoria, pepino…).  
- 1 lata de atún o 2 huevos cocidos o 100 g de legumbres cocidas.  
- Aliño de ensalada.

**Pasos clave**  
1. Cocer y enfriar el arroz.  
2. Mezclar con el resto de ingredientes.  
3. Aliñar justo antes de servir.

---

## 6. Legumbres cocidas (garbanzos, lentejas, alubias)

### 6.1. Guiso / potaje rápido

**Ingredientes modelo (2 raciones)**  
- 200–250 g de legumbres cocidas escurridas.  
- Sofrito de cebolla, ajo y tomate triturado.  
- Verduras (espinacas, zanahoria, pimiento…).  
- 400–500 ml de agua o caldo.

**Pasos clave**  
1. Preparar sofrito.  
2. Añadir verduras y rehogar.  
3. Incorporar legumbres y líquido.  
4. Cocer 10–15 minutos.

---

### 6.2. Ensalada de legumbres

**Ingredientes modelo (2 raciones)**  
- 200–250 g de legumbres cocidas.  
- Verduras crudas (tomate, pepino, cebolla, pimiento…).  
- Opcional: huevo duro, atún, queso (según restricciones).  
- Aliño de ensalada.

**Pasos clave**  
1. Enjuagar y escurrir legumbres.  
2. Mezclar con verduras y extras.  
3. Aliñar y servir.

---

## 7. Pasta como ingrediente principal

### 7.1. Pasta salteada con verduras y proteína

**Ingredientes modelo (2 raciones)**  
- 160 g de pasta en crudo.  
- Verduras (calabacín, champiñones, espinacas…).  
- 150 g de pollo, atún, tofu o legumbres.  
- Salsa ligera (tomate, yogur, aceite + ajo…).

**Pasos clave**  
1. Cocer la pasta y reservar.  
2. Saltear verduras y añadir proteína.  
3. Incorporar pasta y salsa, mezclar 2–3 minutos.

---

### 7.2. Pasta gratinada al horno

**Ingredientes modelo (2 raciones)**  
- Pasta corta cocida.  
- Salsa de tomate o bechamel sencilla.  
- Proteína (pollo desmenuzado, atún, legumbres).  
- Queso o alternativa para gratinar.

**Pasos clave**  
1. Mezclar pasta, salsa y proteína.  
2. Colocar en fuente, cubrir con queso o alternativa.  
3. Hornear hasta dorar.

---

## 8. Verduras como base principal

### 8.1. Salteado de verduras con huevo o tofu

**Ingredientes modelo (2 raciones)**  
- 300–400 g de verduras variadas.  
- 2–3 huevos o 150 g de tofu.

**Pasos clave**  
1. Saltear verduras hasta tiernas.  
2. Añadir huevos batidos (revuelto) o tofu en dados.  
3. Cocinar hasta cuajar el huevo o dorar el tofu.

---

### 8.2. Verduras al horno como plato ligero

**Ingredientes modelo (2 raciones)**  
- Verduras para horno (calabacín, berenjena, pimiento, cebolla…).  
- Opcional: garbanzos cocidos, tofu o pollo en dados.

**Pasos clave**  
1. Mezclar con aceite, sal y especias.  
2. Hornear hasta que estén tiernas y doradas.

---

## 9. Pescado (fresco o en conserva)

### 9.1. Pescado al horno con verduras

**Ingredientes modelo (2 raciones)**  
- 2 filetes de pescado blanco o azul.  
- Cama de verduras (cebolla, tomate, pimiento…).  

**Pasos clave**  
1. Disponer verduras con aceite y sal en bandeja.  
2. Colocar pescado encima o al final según el tipo.  
3. Hornear hasta que el pescado esté justo hecho.

---

### 9.2. Ensalada o bowl con atún en lata

**Ingredientes modelo (2 raciones)**  
- 1–2 latas de atún escurrido.  
- Verduras de ensalada.  
- Opcional: legumbres o pasta para hacer el plato más saciante.

**Pasos clave**  
1. Preparar base de ensalada o bowl.  
2. Añadir atún y extras.  
3. Aliñar antes de servir.

---

## 10. Uso por parte del agente

1. Identificar ingrediente principal y tipo de plato solicitado.  
2. Escoger la plantilla más cercana de este documento.  
3. Adaptar:
   - Cantidades al número de comensales.
   - Ingredientes a la despensa real del usuario.
   - Técnica y explicaciones al nivel de cocina.  
4. Completar con variaciones, sustituciones y advertencias de alérgenos aprovechando el resto de documentos de la base de conocimiento.

