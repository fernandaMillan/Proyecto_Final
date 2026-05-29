using PPTLS.Strategies;
namespace PPTLS.Models;
public class Jugador
{
//Atributos 
public string Nombre { get; set; }
public IJugada JugadaActual { get; private set; }

//Constructor
public Jugador(string nombre)

//Métodos
public void ElegirJugada(IJugada jugada)
{
JugadaActual = jugada;
}
}