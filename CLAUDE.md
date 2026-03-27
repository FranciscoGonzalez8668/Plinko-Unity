# AI Context File – TP Plinko (My Project)

## Proyecto
Trabajo práctico de la diplomatura de videojuegos. Se implementa un juego estilo Plinko con simulación física en Unity 2D.

- **Motor:** Unity 6.3.6 — C#
- **Proyecto Unity:** My Project
- **Desarrollador:** 1 persona, nivel intermedio

## Lo que ya existe en el proyecto
- Escena con pelotas cayendo y Rigidbody
- Material con Rigidbody aplicado
- TP anterior (Basic Projectile) completado

---

## Objetivo del TP — Plinko

### Parte 1 — Spawn con click del mouse
- Script que lee la posición del mouse en pantalla
- Al hacer click izquierdo: spawnea un círculo con gravedad en esa posición

### Parte 2 — Figuras 2D con colliders
- Crear figuras 2D básicas: círculos, rectángulos, triángulos
- Distintos tamaños y formas
- Todas con Colliders 2D
- Estructura de Prefabs y Variantes de Prefabs

### Parte 3 — Escena estilo Plinko
- Usar todos los elementos para armar una escena jugable tipo Plinko
- Clavijas (pegs) distribuidas en el tablero
- Zona de caída arriba, zonas de puntuación abajo

### Parte 4 — Fuerzas con teclas A y D
- Script que aplica fuerza hacia la izquierda (A) o derecha (D)
- Agregarlo al círculo para que todos los círculos spawneados respondan al input

### Parte 5 — Mecánica nueva con Space
- Definir e implementar una mecánica nueva que se active con la tecla Space
- Aplicada a los círculos

---

## Instrucciones para Claude Code
- Guiarme paso a paso — no tirar todo el código de una
- Explicar brevemente qué hace cada script antes de escribirlo
- Código C# listo para copiar en Unity, con comentarios claros
- Recordar que es Unity 2D — usar Rigidbody2D, Collider2D, Physics2D
- Avisar si algo puede romper lo que ya existe en el proyecto
- Al terminar cada parte, decirme qué marcar como hecho en TASKS.md
