using Microsoft.EntityFrameworkCore;
using Miguel_AP1_AP.DAL;
using Radzen;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace Miguel_AP1_AP.BLL
{
    public class AportesBll
    {

        private Contexto _contexto;

        public int AportesId { get; private set; }

        public AportesBll(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int AportesId)
        {
            return _contexto.aportes.Any(o => o.AportesId == AportesId);

        }

        private bool Insertar(AportesBll aportes)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Aportes> entityEntry = _contexto.aportes.Add(aportes);
            return _contexto.SaveChanges() > 0;
        }

        private bool Modificar(AportesBll aportes)
        {
            _contexto.Entry(aportes).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;

        }

        public bool Guardar(AportesBll aportes)
        {
            if (!Existe(aportes.AportesId))
                return this.Insertar(aportes);
            else
                return this.Modificar(aportes);
        }

        public bool Eliminar(AportesBll aportes)
        {
            _contexto.Entry(aportes).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }

        public AportesBll? Buscar(int AportesId)
        {
            return _contexto.aportes
            .Where(o => o.AportesId == AportesId)
            .AsNoTracking()
            .SingleOrDefault();
        }

        public List<AportesBll> GetList(Expression<Func<AportesBll, bool>> Criterio)
        {
            return _contexto.aportes
            .AsNoTracking()
            .Where(Criterio)
            .ToList();
        }

    }
}

