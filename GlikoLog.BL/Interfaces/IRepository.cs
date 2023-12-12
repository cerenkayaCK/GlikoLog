using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GlikoLog.BL.Interfaces
{
    public interface IRepository<T>
    {
        public void Ekle(T eklenecekOge);
        public void Guncelle();
        public void Dispose();
        public T FirstOrDefault(Expression<Func<T, bool>> varlik);
        public void Sil(T silinecekOge);

        public T IdYeGoreGetir(int id);

        public List<T> HepsiniGetir();
        IQueryable<T> Include(string navigationPropertyPath);



    }
}
