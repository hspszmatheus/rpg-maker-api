using RpgMakerAPI.DTOs;
using RpgMakerAPI.Interfaces;

namespace RpgMakerAPI.Services;

public class CharacterService : ICharacterService
{
    // Lista em memória para teste (simula o banco de dados)
    private static readonly List<CharacterResponseDto> _characters = new();

    public async Task<IEnumerable<CharacterResponseDto>> GetAllAsync()
    {
        return await Task.FromResult(_characters);
    }

    public async Task<CharacterResponseDto?> GetByIdAsync(int id)
    {
        var character = _characters.FirstOrDefault(c => c.Id == id);
        return await Task.FromResult(character);
    }

    public async Task<CharacterResponseDto> CreateAsync(CharacterCreateDto dto)
    {
        var newId = _characters.Count > 0 ? _characters.Max(c => c.Id) + 1 : 1;

        var newCharacter = new CharacterResponseDto(
            newId,
            dto.Name,
            dto.Description,
            dto.UserId
        );

        _characters.Add(newCharacter);
        return await Task.FromResult(newCharacter);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var character = _characters.FirstOrDefault(c => c.Id == id);
        if (character == null) return false;

        _characters.Remove(character);
        return await Task.FromResult(true);
    }
}