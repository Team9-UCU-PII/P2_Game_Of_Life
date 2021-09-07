# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

## Conway's Game of Life
[John Conway](https://en.wikipedia.org/wiki/John_Horton_Conway) fue un matemático inglés muy conocido por sus aportes matemáticos en diversas áreas, pero lo que realmente lo hizo famoso fue su creación lúdica: [juego de la vida](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life).

![](https://upload.wikimedia.org/wikipedia/commons/e/e5/Gospers_glider_gun.gif)

El juego de la vida consiste en un autómata celular con unas pocas reglas muy simples.
El universo es una grilla ortogonal de dos dimensiones, donde cada espacio de la grilla representa una única célula.
Cada célula puede estar viva o muerta.
Cada una de estas células tendra 8 vecinos.
En cada iteración del tiempo (generación) una célula estará viva o muerta según la cantidad de vecinos vivos o muertos que tenga. Siguiendo estas reglas:
* Una célula viva con menos de 2 vecinos vivos muere, por soledad.
* Una célula viva con 2 o 3 vecinos vivos sobrevive a la siguiente generación.
* Una célula viva con más de 3 vecinos vivos muere, por sobrepoblación.
* Una célula muerta con exactamente 3 vecinos vivos se convierte en una célula viva, por reproducción

Ejercicio realizado por Maximiliano Benítez, Marcelo Arrarte, Dana Castroman y Santiago Alonso.

Link a repositorio de GitHub: https://github.com/Team9-UCU-PII/P2_Game_Of_Life.git
