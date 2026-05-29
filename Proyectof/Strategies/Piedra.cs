using System.Windows.Documents;

namespace Proyectof.Strategies;

public class Piedra : IJugada
{
public string Nombre => "Piedra";
public string ResolverContra(IJugada oponente)
{
if (oponente is Tijera){
return "Gana: Piedra rompe Tijera";}

else 
if (oponente is Papel){
return "Pierde: Papel cubre Piedra";}

else
if (oponente is Lagarto){
return "Gana: Piedra aplasta Lagarto";}

else
if (oponente is Spock){
return "Pierde: Spock rompe Piedra";}

else{
return "Empate";}
}
}