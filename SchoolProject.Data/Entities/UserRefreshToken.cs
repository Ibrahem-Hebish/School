﻿namespace SchoolProject.Data.Entities;

public class UserToken
{
    public bool IsUsed { get; set; }
    public bool IsExpired { get; set; }
    [Key]
    public int Id { get; set; }
    [ForeignKey(nameof(User))]
    public int Userid { get; set; }

    public DateTime AddedDate { get; set; }
    public DateTime ExpiredDate { get; set; }
    public string AccessToken { get; set; } = null!;
    public string Token { get; set; } = null!;
    [InverseProperty(nameof(User.Tokens))]
    public User User { get; set; } = null!;

}
