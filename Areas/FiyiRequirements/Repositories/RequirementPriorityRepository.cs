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
    public class RequirementPriorityRepository : IRequirementPriorityRepository
    {
        protected readonly FiyiRequirementsContext _context;

        public RequirementPriorityRepository(FiyiRequirementsContext context)
        {
            _context = context;
        }

        public IQueryable<RequirementPriority> AsQueryable()
        {
            try
            {
                return _context.RequirementPriority.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.RequirementPriority.Count();
            }
            catch (Exception) { throw; }
        }

        public RequirementPriority? GetByRequirementPriorityId(int requirementpriorityId)
        {
            try
            {
                return _context.RequirementPriority
                            .FirstOrDefault(x => x.RequirementPriorityId == requirementpriorityId);
            }
            catch (Exception) { throw; }
        }

        public List<RequirementPriority?> GetAll()
        {
            try
            {
                return _context.RequirementPriority.ToList();
            }
            catch (Exception) { throw; }
        }

        public paginatedRequirementPriorityDTO GetAllByNamePaginated(string textToSearch,
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

                int TotalRequirementPriority = _context.RequirementPriority.Count();

                var paginatedRequirementPriority = _context.RequirementPriority
                        .Where(x => strictSearch ?
                            words.All(word => x.Name.Contains(word)) :
                            words.Any(word => x.Name.Contains(word)))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                return new paginatedRequirementPriorityDTO
                {
                    lstRequirementPriority = paginatedRequirementPriority,
                    TotalItems = TotalRequirementPriority,
                    PageIndex = pageIndex,
                    PageSize = pageSize
                };
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(RequirementPriority requirementpriority)
        {
            try
            {
                _context.RequirementPriority.Add(requirementpriority);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(RequirementPriority requirementpriority)
        {
            try
            {
                _context.RequirementPriority.Update(requirementpriority);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByRequirementPriorityId(int requirementpriorityId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.RequirementPriorityId == requirementpriorityId)
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
                List<RequirementPriority> lstRequirementPriority = _context.RequirementPriority.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("RequirementPriorityId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Name", typeof(string));
                DataTable.Columns.Add("Description", typeof(string));
                

                foreach (RequirementPriority requirementpriority in lstRequirementPriority)
                {
                    DataTable.Rows.Add(
                        requirementpriority.RequirementPriorityId,
                        requirementpriority.Active,
                        requirementpriority.DateTimeCreation,
                        requirementpriority.DateTimeLastModification,
                        requirementpriority.UserCreationId,
                        requirementpriority.UserLastModificationId,
                        requirementpriority.Name,
                        requirementpriority.Description
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
