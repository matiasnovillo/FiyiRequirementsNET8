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
    public class RequirementStateRepository : IRequirementStateRepository
    {
        protected readonly FiyiRequirementsContext _context;

        public RequirementStateRepository(FiyiRequirementsContext context)
        {
            _context = context;
        }

        public IQueryable<RequirementState> AsQueryable()
        {
            try
            {
                return _context.RequirementState.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.RequirementState.Count();
            }
            catch (Exception) { throw; }
        }

        public RequirementState? GetByRequirementStateId(int requirementstateId)
        {
            try
            {
                return _context.RequirementState
                            .FirstOrDefault(x => x.RequirementStateId == requirementstateId);
            }
            catch (Exception) { throw; }
        }

        public List<RequirementState?> GetAll()
        {
            try
            {
                return _context.RequirementState.ToList();
            }
            catch (Exception) { throw; }
        }

        public paginatedRequirementStateDTO GetAllByNamePaginated(string textToSearch,
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

                int TotalRequirementState = _context.RequirementState.Count();

                var paginatedRequirementState = _context.RequirementState
                        .Where(x => strictSearch ?
                            words.All(word => x.Name.Contains(word)) :
                            words.Any(word => x.Name.Contains(word)))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                return new paginatedRequirementStateDTO
                {
                    lstRequirementState = paginatedRequirementState,
                    TotalItems = TotalRequirementState,
                    PageIndex = pageIndex,
                    PageSize = pageSize
                };
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(RequirementState requirementstate)
        {
            try
            {
                _context.RequirementState.Add(requirementstate);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(RequirementState requirementstate)
        {
            try
            {
                _context.RequirementState.Update(requirementstate);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByRequirementStateId(int requirementstateId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.RequirementStateId == requirementstateId)
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
                List<RequirementState> lstRequirementState = _context.RequirementState.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("RequirementStateId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Name", typeof(string));
                

                foreach (RequirementState requirementstate in lstRequirementState)
                {
                    DataTable.Rows.Add(
                        requirementstate.RequirementStateId,
                        requirementstate.Active,
                        requirementstate.DateTimeCreation,
                        requirementstate.DateTimeLastModification,
                        requirementstate.UserCreationId,
                        requirementstate.UserLastModificationId,
                        requirementstate.Name
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
