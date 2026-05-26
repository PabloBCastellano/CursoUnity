<h1><b><u>¿En qué consiste el juego?</h1></b></u>
<p>Juego 2D en el que simulamos el vuelo de un pájaro  y debemos superar obstáculos haciendo click o space
    durante el máximo de tiempo posible</p>
<h2><b><u>¿Cuántos objetos identificas? </b></u><i>(Sólo identificar)</i></h2>
   <ol> <b>Gameplay</b>
      <li>  Pájaro</li>
        <li>Tubería arriba</li> 
        <li>Hueco entre tuberías</li>
        <li>Tubería abajo</li>
        <li>Cielo con nubes (fondo)</li>
        <li>Contador de puntos</li>
        <li>Suelo</li>
        <li>Meta<li>
         Audio:<ul style="list-style-type:circle;"> 
            <li>Volar</li>
            <li>Chocar</li>
            <li>Puntos</li>
            </ul>
    </ol>
    <ol type="I"><b>Menú:</b>
       <li> Texto animado</li>
        <li>Botón de Play</li>
    </ol>
    <ol type="a">Tutorial:
        <li>Imagen de tap</li>
        <li>Gameplay en modo pausa</li>
    </ol>
    <ol type="i"><b style="color:red;">GameOver:</b>
       <li> Fondo del juego</li>
        <li>Texto Game Over</li>
        <li>Marcador de Score actual</li>
        <li>Marcador de HighScore actual</li>
        <li>Botón Play</li>
    </ol>
    <ol type="a"> <b style="color:green;">Victory:</b>
       <li> Fondo del juego</li>
       <li> Texto Victory</li>
       <li> Marcador de Score actual</li>
       <li> Marcador de HighScore actual</li>
       <li> Botón Play</li>
    </ol>
    <ol><b>Game Flow:</b>
            <li>Menú -> Tutorial (click botón Play)</li>
            <li>Tutorial -> Gameplay (click en pantalla Tap)</li>
            <li>Gameplay -> GameOver (chocar con tubería o suelo)</li>
            <li>Gameplay -> Victory (llegar a la meta)</li>
            <li>GameOver -> Menú (click botón Play)</li>
            <li>Victory -> Menú (click botón Play)</li>
    </ol>
    ¿Qué objetos son puramente estéticos?
        Cielo con Nubes(Fondo)
    ¿Qué objetos tienen comportamiento? ¿Qué comportamientos identificas?
        -Pajaro(bird)
            *Fisicas 2D Realistas
            * Sprits 2D
            * Tiene colisiones
            *Se mueve hacia delante con una velocidad constante
            *Aletea con impulso al pulsar espacio
            *Tiene una inclinacion
    ¿Qué elementos tiene el HUD?

¿Quién tiene la responsabilidad de esos comportamientos?

<style>
    li{
        margin-left:2em;
    }
    ul{
        margin-left:-3em;
    }
</style>