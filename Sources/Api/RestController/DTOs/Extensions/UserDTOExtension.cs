﻿using System;
using AutoMapper;
using Model.Players;

namespace RestController.DTOs.Extensions;

internal static class UserDTOExtensions
{
    private static readonly MapperConfiguration MapperConfig =
        new(cfg =>
        {
            cfg.CreateMap<User, UserDTO>().ReverseMap();
            cfg.CreateMap<UserInsertRequest, User>().ReverseMap();
        });

    private static readonly Mapper Mapper = new(MapperConfig);

    public static UserDTO UserToDTO(this User user) => Mapper.Map<User, UserDTO>(user);

    public static UserDTO PlayerToDTO(this Player player) => new()
    {
        Id = player.Id,
        FirstName = player.FirstName,
        LastName = player.LastName,
        Nickname = player.NickName,
        Avatar = player.Avatar
    };
}