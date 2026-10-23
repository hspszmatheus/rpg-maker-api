namespace RpgMakerAPI.DTOs;

// DTO para entrada de dados (o que o usuário envia)
public record CharacterCreateDto(
    string Name,
    string Description,
    int UserId
);

// DTO para saída de dados (o que a API retorna)
public record CharacterResponseDto(
    int Id,
    string Name,
    string Description,
    int UserId
);