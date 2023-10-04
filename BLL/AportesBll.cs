using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;


    public class AportesBll
    {

        private Contexto _contexto;

        public AportesBll(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int AportesId)
        {
            return _contexto.aportes.Any(o => o.AportesId == AportesId);

        }

        private bool Insertar(Aportes aportes)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Aportes> entityEntry = _contexto.aportes.Add(aportes);
            return _contexto.SaveChanges() > 0;
        }

        private bool Modificar(Aportes aportes)
        {
            _contexto.Entry(aportes).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;

        }

        public bool Guardar(Aportes aportes)
        {
            if (!Existe(aportes.AportesId))
                return this.Insertar(aportes);
            else
                return this.Modificar(aportes);
        }

        public bool Eliminar(Aportes aportes)
        {
            _contexto.Entry(aportes).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }

        public Aportes? Buscar(int AportesId)
        {
            return _contexto.aportes
            .Where(o => o.AportesId == AportesId)
            .AsNoTracking()
            .SingleOrDefault();
        }

        public List<Aportes> GetList(Expression<Func<Aportes, bool>> Criterio)
        {
            return _contexto.aportes
            .AsNoTracking()
            .Where(Criterio)
            .ToList();
        }

    }

