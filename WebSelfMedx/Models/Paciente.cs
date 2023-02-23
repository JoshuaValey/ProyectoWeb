using System;
using System.Collections.Generic;
using WebSelfMedx.Models;

namespace WebSelfMedx.Models;

public partial class Paciente
{
    public int Id { get; set; }

    public int IdUsuarioPaciente { get; set; }

    public virtual ICollection<Cita> Cita { get; } = new List<Cita>();

    public virtual ICollection<Historialmedico> Historialmedicos { get; } = new List<Historialmedico>();

    public virtual Usuario IdUsuarioPacienteNavigation { get; set; } = null!;
}
