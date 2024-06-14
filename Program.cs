using System.Net.Http.Json;
using System.Net.NetworkInformation;

var diccionarioJugadores = Jugadores.obtenerDiccionarioJugadores();
string urlJugadores = Jugadores.obtenerURLJugadores(diccionarioJugadores);
string apiKey = "d464875f-8435-459e-9caa-4cbd46861aed";

HttpClient client = new HttpClient();
client.DefaultRequestHeaders.Add("Authorization", apiKey);

HttpResponseMessage response = await client.GetAsync(urlJugadores);
response.EnsureSuccessStatusCode();

JugadorData jugadoresResponseBody = await response.Content.ReadFromJsonAsync<JugadorData>();
List<Jugador> listaJugadores = jugadoresResponseBody.ListaJugadores;

Console.ReadKey();