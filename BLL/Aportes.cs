using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Miguel_AP1_AP.BLL
{
    public class Aportes
    {

        private Contexto _contexto;

        public Aportes(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int LibroId)
        {
            return _contexto.libros.Any(o => o.LibroId == LibroId);

        }

        private bool Insertar(Aportes libros)
        {
            _contexto.libros.Add(libros);
            return _contexto.SaveChanges() > 0;
        }

        private bool Modificar(Aportes libros)
        {
            _contexto.Entry(libros).State = EntityState.Modified;
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
}

