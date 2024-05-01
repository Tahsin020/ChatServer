namespace ChatServer.WebApi.Dtos;

public sealed record SendMessageDto(
    Guid UserId,
    Guid ToUserId,
    string Message);
