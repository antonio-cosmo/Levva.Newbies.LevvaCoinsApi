﻿namespace LevvaCoins.Application.Accounts.Dtos
{
    public class LoginResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}