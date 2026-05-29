using System.Windows.Documents;

namespace Proyectof.Strategies;
public class Spock : IJugada
{
public string Nombre => "Spock";
public string ResolverContra(IJugada oponente)
{
if (oponente is Tijera){
return "Gana: Spock rompe Tijera";}

else 
if (oponente is Papel){
return "Pierde: Papel corta Spock";}

else
if (oponente is Lagarto){
return "Pierde: Lagarto muerde Spock";}

else
if (oponente is Piedra){
return "Gana: Spock rompe Piedra";}

else{
return "Empate";}
}
}