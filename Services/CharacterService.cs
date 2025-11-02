using System.Net.Http.Json;
using BlazorDbzApiPersonaExtra.Models;

namespace BlazorDbzApiPersonaExtra.Services
{
    public class CharacterService
    {
        private readonly HttpClient _http;

        public CharacterService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Character?> GetCharacterAsync(int id)
        {
            try
            {
                var url = $"https://dragonball-api.com/api/characters/{id}";
                return await _http.GetFromJsonAsync<Character>(url);
            }
            catch
            {
                return null;
            }
        }
    }
}