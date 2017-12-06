using Domain;
using System;
using System.Collections.Generic;

namespace BLL
{
    public interface IProfileBLL
    {
        Profile Add(Profile profile);

        Profile Update(Profile profile);

        Boolean Remove(Profile profile);

        Boolean RemoveCascade(Profile profile);

        List<Profile> View();

        Profile View(String profile);

        List<String> ListProfile();

    }
}
