using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using FiyiRequirements.Areas.FiyiRequirements.Entities;
using FiyiRequirements.Areas.FiyiRequirements.DTOs;
using FiyiRequirements.Areas.FiyiRequirements.Interfaces;
using System.Data;
using FiyiRequirements.Areas.BasicCore;

/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 */

namespace FiyiRequirements.Areas.FiyiRequirements.Repositories
{
    public class RequirementChangehistoryRepository : IRequirementChangehistoryRepository
    {
        protected readonly FiyiRequirementsContext _context;

        public RequirementChangehistoryRepository(FiyiRequirementsContext context)
        {
            _context = context;
        }

        public IQueryable<RequirementChangehistory> AsQueryable()
        {
            try
            {
                return _context.RequirementChangehistory.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.RequirementChangehistory.Count();
            }
            catch (Exception) { throw; }
        }

        public RequirementChangehistory? GetByRequirementChangehistoryId(int requirementchangehistoryId)
        {
            try
            {
                return _context.RequirementChangehistory
                            .FirstOrDefault(x => x.RequirementChangehistoryId == requirementchangehistoryId);
            }
            catch (Exception) { throw; }
        }

        public List<RequirementChangehistory?> GetAll()
        {
            try
            {
                return _context.RequirementChangehistory.ToList();
            }
            catch (Exception) { throw; }
        }

        public paginatedRequirementChangehistoryDTO GetAllByRequirementChangehistoryIdPaginated(string textToSearch,
            bool strictSearch,
            int pageIndex, 
            int pageSize)
        {
            try
            {
                //textToSearch: "novillo matias  com" -> words: {novillo,matias,com}
                string[] words = Regex
                    .Replace(textToSearch
                    .Trim(), @"\s+", " ")
                    .Split(" ");

                int TotalRequirementChangehistory = _context.RequirementChangehistory.Count();

                var paginatedRequirementChangehistory = _context.RequirementChangehistory
                        .Where(x => strictSearch ?
                            words.All(word => x.RequirementChangehistoryId.ToString().Contains(word)) :
                            words.Any(word => x.RequirementChangehistoryId.ToString().Contains(word)))
                        .OrderBy(p => p.RequirementChangehistoryId)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                return new paginatedRequirementChangehistoryDTO
                {
                    lstRequirementChangehistory = paginatedRequirementChangehistory,
                    TotalItems = TotalRequirementChangehistory,
                    PageIndex = pageIndex,
                    PageSize = pageSize
                };
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(RequirementChangehistory requirementchangehistory)
        {
            try
            {
                _context.RequirementChangehistory.Add(requirementchangehistory);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(RequirementChangehistory requirementchangehistory)
        {
            try
            {
                _context.RequirementChangehistory.Update(requirementchangehistory);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByRequirementChangehistoryId(int requirementchangehistoryId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.RequirementChangehistoryId == requirementchangehistoryId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Other methods
        public DataTable GetAllInDataTable()
        {
            try
            {
                List<RequirementChangehistory> lstRequirementChangehistory = _context.RequirementChangehistory.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("RequirementChangehistoryId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("RequirementId", typeof(string));
                DataTable.Columns.Add("RequirementStateId", typeof(string));
                DataTable.Columns.Add("RequirementPriorityId", typeof(string));
                

                foreach (RequirementChangehistory requirementchangehistory in lstRequirementChangehistory)
                {
                    DataTable.Rows.Add(
                        requirementchangehistory.RequirementChangehistoryId,
                        requirementchangehistory.Active,
                        requirementchangehistory.DateTimeCreation,
                        requirementchangehistory.DateTimeLastModification,
                        requirementchangehistory.UserCreationId,
                        requirementchangehistory.UserLastModificationId,
                        requirementchangehistory.RequirementId,
                        requirementchangehistory.RequirementStateId,
                        requirementchangehistory.RequirementPriorityId
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
