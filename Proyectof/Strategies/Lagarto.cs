using System.Windows.Documents;
using Proyectof.Models;

namespace Proyectof.Strategies;
public class Lagarto : IJugada
{
public string Nombre => "Lagarto";
public string ResolverContra(IJugada oponente)
{
if (oponente is Tijera){
return "Pierde: Tijera corta Lagarto";}

else 
if (oponente is Papel){
return "Gana: Lagarto devora Papel";}

else
if (oponente is Piedra){
return "Pierde: Piedra aplasta Lagarto";}

else
if (oponente is Spock){
return "Gana: Lagarto muerde Spock";}

else{
return "Empate";}
}
}