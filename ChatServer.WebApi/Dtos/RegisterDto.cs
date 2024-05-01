namespace ChatServer.WebApi.Dtos;

public sealed record RegisterDto(
    string Name,
    IFormFile File);
