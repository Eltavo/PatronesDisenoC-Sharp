using System.Collections.Generic;
using System.Linq;
using ElTavo.RepositoryPattern.Contrato;

namespace ElTavo.RepositoryPattern.SqlRepository.Empleado
{
    public class EmpleadoRepository : BaseRepository<Empleado>, IEmpleadoRepository
    {
        public List<Dominio.Empleado> ObtenerEmpleados()
        {
            AutoMapper.Mapper.CreateMap<Empleado, Dominio.Empleado>();
            return
                new List<Dominio.Empleado>(ObtenerTodos().AsEnumerable().Select(AutoMapper.Mapper.Map<Dominio.Empleado>
                    )).ToList();
        }

        public Dominio.Empleado ObtenEmpleadoPoId(string id)
        {
            var empleado = ObtenerPorId(id);

            AutoMapper.Mapper.CreateMap<Empleado, Dominio.Empleado>();
            return AutoMapper.Mapper.Map<Dominio.Empleado>(empleado);
        }

        public void GuardarEmpleado(Dominio.Empleado empleado)
        {
            AutoMapper.Mapper.CreateMap<Dominio.Empleado, Empleado>();
            var emple = AutoMapper.Mapper.Map<Empleado>(empleado);

            Insertar(emple);
        }
    }
}
