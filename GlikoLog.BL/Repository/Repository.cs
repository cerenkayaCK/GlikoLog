using GlikoLog.BL.Interfaces;
using GlikoLog.DAL.Context;
using GlikoLog.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GlikoLog.BL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private static UygulamaDbContext _db = new UygulamaDbContext();
        
        private DbSet<T> varliklar;

        //DbSette kullanan bilmem için T dediğimiz temsilci (genel) reference type olmalıdır DİYOR :)

        public Repository()
        {           
            varliklar = _db.Set<T>();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Ekle(T eklenecekOge)
        {
           
             try
            {
                varliklar.Add(eklenecekOge);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        public async Task EkleAsync(T eklenecekOge)
        {
            varliklar.Add(eklenecekOge);
            await _db.SaveChangesAsync();
        }
        public T FirstOrDefault(Expression< Func<T, bool>> varlik) 
        {
            return varliklar.FirstOrDefault(varlik);
        }

        public void Guncelle()
        {
            _db.SaveChanges();

        }
        public async Task GuncelleAsync()
        {
            await _db.SaveChangesAsync();
            
        }

        public List<T> HepsiniGetir() //IQueryable 
        {
            return varliklar.ToList();
        }
        public DbSet<T> HepsiniGetirDbSet() //IQueryable 
        {
            return varliklar;
        }

        public T IdYeGoreGetir(int id)
        {
            //Id'ye göre bulmak için bir de find metodu vardır.
            return varliklar.Find(id);
        }

        public IQueryable<T> Include(string navigationPropertyPath)
        {
            
                return varliklar.Include(navigationPropertyPath);
            
        }

        public void Sil(T silinecekOge)
        {
            varliklar.Remove(silinecekOge);
            _db.SaveChanges();
        }
        public async Task SilAsync(T silinecekOge)
        {
            varliklar.Remove(silinecekOge);
            _db.SaveChanges();
        }

    }
}
