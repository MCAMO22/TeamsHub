using System;

namespace TeamHubServiceUser.DTOs;

public class UserActionDTO
{
    public int? IdUser {get; set;}
    public int? IdUserSession {get; set;}
    public string Action {get; set;}
    
}