using System.Windows.Documents;

namespace Proyectof.Strategies;

public class Papel : IJugada
{
public string Nombre => "Papel";
public string ResolverContra(IJugada oponente)
{
if (oponente is Tijera){
return "Pierde Tijera corta Papel";}

else 
if (oponente is Piedra){
return "Gana: Papel cubre Piedra";}

else
if (oponente is Lagarto){
return "Pierde: Lagarto devora Papel";}

else
if (oponente is Spock){
return "Gana: Papel corta Spock";}

else{
return "Empate";}
}
}