﻿using System;
using System.Collections.Generic;

namespace AutenticarconToken.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; }

    public string Clave { get; set; }
}
