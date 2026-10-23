namespace RpgMakerAPI.Interfaces;

using RpgMakerAPI.DTOs;

public interface ICharacterService
{
    Task<IEnumerable<CharacterResponseDto>> GetAllAsync();
    Task<CharacterResponseDto?> GetByIdAsync(int id);
    Task<CharacterResponseDto> CreateAsync(CharacterCreateDto dto);
    Task<bool> DeleteAsync(int id);
}