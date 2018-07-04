using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Newtonsoft.Json.Linq;
using StrataDashboard.Entities;

namespace StrataDashboard.EntityFramework.Repositories
{
    public class BuildingsRepository : IBuildingsRepository
    {
        public IQueryable<Building> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Building> GetAllIncluding(params Expression<Func<Building, object>>[] propertySelectors)
        {
            throw new NotImplementedException();
        }

        public List<Building> GetAllList()
        {
            string json = string.Empty;

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\building-data.json");
            json = File.ReadAllText(path);

            //var json = File.ReadAllText("data/building-data.json");
            JObject buildingsJSON = JObject.Parse(json);

            var buildings = buildingsJSON["buildings"].Select(b => new Building()
            {
                Id = int.Parse(b["id"].ToString()),
                BuildingDisplay = b["buildingdisplay"].ToString(),
                LocalGovernment = b["localgovernment"].ToString(),
                NumberOfLots = int.Parse(b["numberoflots"].ToString()),
                PostCode = int.Parse(b["postcode"].ToString()),
                StrataManager = b["stratamanager"].ToString(),
                StrataPlanNumber = long.Parse(b["strataplannumber"].ToString())
            });

            return buildings.ToList();
        }

        public Task<List<Building>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        public List<Building> GetAllList(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<Building>> GetAllListAsync(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Query<T>(Func<IQueryable<Building>, T> queryMethod)
        {
            throw new NotImplementedException();
        }

        public Building Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Building> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Building Single(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Building> SingleAsync(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Building FirstOrDefault(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Building> FirstOrDefaultAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Building FirstOrDefault(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Building> FirstOrDefaultAsync(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Building Load(int id)
        {
            throw new NotImplementedException();
        }

        public Building Insert(Building entity)
        {
            throw new NotImplementedException();
        }

        public Task<Building> InsertAsync(Building entity)
        {
            throw new NotImplementedException();
        }

        public int InsertAndGetId(Building entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAndGetIdAsync(Building entity)
        {
            throw new NotImplementedException();
        }

        public Building InsertOrUpdate(Building entity)
        {
            throw new NotImplementedException();
        }

        public Task<Building> InsertOrUpdateAsync(Building entity)
        {
            throw new NotImplementedException();
        }

        public int InsertOrUpdateAndGetId(Building entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertOrUpdateAndGetIdAsync(Building entity)
        {
            throw new NotImplementedException();
        }

        public Building Update(Building entity)
        {
            throw new NotImplementedException();
        }

        public Task<Building> UpdateAsync(Building entity)
        {
            throw new NotImplementedException();
        }

        public Building Update(int id, Action<Building> updateAction)
        {
            throw new NotImplementedException();
        }

        public Task<Building> UpdateAsync(int id, Func<Building, Task> updateAction)
        {
            throw new NotImplementedException();
        }

        public void Delete(Building entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Building entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public long LongCount()
        {
            throw new NotImplementedException();
        }

        public Task<long> LongCountAsync()
        {
            throw new NotImplementedException();
        }

        public long LongCount(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<long> LongCountAsync(Expression<Func<Building, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}