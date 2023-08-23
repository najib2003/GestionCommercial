using System;
using System.Collections.Generic;

namespace GestionCommercial.Models;

public partial class User
{
    internal DateTime TokenExpires;

    public string IdUser { get; set; } = null!;

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;
    public byte[] PasswordHash { get; internal set; }
    public byte[] PasswordSalt { get; internal set; }
    public object RefreshToken { get; internal set; }

    public DateTime TokenCreated { get; set; }
}
