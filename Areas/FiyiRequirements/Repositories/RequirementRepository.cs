using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using FiyiRequirements.Areas.FiyiRequirements.Entities;
using FiyiRequirements.Areas.FiyiRequirements.DTOs;
using FiyiRequirements.Areas.FiyiRequirements.Interfaces;
using System.Data;
using FiyiRequirements.Areas.BasicCore;
using DocumentFormat.OpenXml.InkML;
using FiyiRequirements.Areas.CMSCore.Entities;

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
    public class RequirementRepository : IRequirementRepository
    {
        protected readonly FiyiRequirementsContext _context;

        public RequirementRepository(FiyiRequirementsContext context)
        {
            _context = context;
        }

        public IQueryable<Requirement> AsQueryable()
        {
            try
            {
                return _context.Requirement.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Requirement.Count();
            }
            catch (Exception) { throw; }
        }

        public Requirement? GetByRequirementId(int requirementId)
        {
            try
            {
                return _context.Requirement
                            .FirstOrDefault(x => x.RequirementId == requirementId);
            }
            catch (Exception) { throw; }
        }

        public List<Requirement?> GetAll()
        {
            try
            {
                return _context.Requirement.ToList();
            }
            catch (Exception) { throw; }
        }

        public paginatedRequirementDTO GetAllByTitlePaginatedAndOtherFilters(string textToSearch,
            bool strictSearch,
            int pageIndex, 
            int pageSize,
            int requirementStateId)
        {
            try
            {
                //textToSearch: "novillo matias  com" -> words: {novillo,matias,com}
                string[] words = Regex
                    .Replace(textToSearch
                    .Trim(), @"\s+", " ")
                    .Split(" ");

                int TotalRequirement = _context.Requirement.Count();

                List<Requirement> lstRequirement = [];
                List<RequirementState> lstRequirementState = [];
                List<RequirementPriority> lstRequirementPriority = [];
                List<User> lstUserEmployee = [];

                var query = from requirement in _context.Requirement
                            join user in _context.User on requirement.UserEmployeeId equals user.UserId
                            join state in _context.RequirementState on requirement.RequirementStateId equals state.RequirementStateId
                            join priority in _context.RequirementPriority on requirement.RequirementPriorityId equals priority.RequirementPriorityId
                            select new
                            {
                                Requirement = requirement,
                                User = user,
                                State = state,
                                Priority = priority
                            };

                if (requirementStateId == 0)
                {
                    var query2 = query
                        .Where(x => strictSearch ?
                            words.All(word => x.Requirement.Title.ToString().Contains(word)) :
                            words.Any(word => x.Requirement.Title.ToString().Contains(word)))
                        .OrderByDescending(p => p.Requirement.DateTimeLastModification)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    foreach (var item in query2)
                    {
                        lstRequirement.Add(item.Requirement);
                        lstUserEmployee.Add(item.User);
                        lstRequirementState.Add(item.State);
                        lstRequirementPriority.Add(item.Priority);
                    }

                    return new paginatedRequirementDTO
                    {
                        lstRequirement = lstRequirement,
                        lstRequirementPriority = lstRequirementPriority,
                        lstRequirementState = lstRequirementState,
                        lstUserEmployee = lstUserEmployee,
                        TotalItems = TotalRequirement,
                        PageIndex = pageIndex,
                        PageSize = pageSize
                    };
                }
                else
                {
                    var query2 = query
                        .Where(x => strictSearch ?
                            words.All(word => x.Requirement.Title.Contains(word)) :
                            words.Any(word => x.Requirement.Title.Contains(word)))
                        .Where(x => x.Requirement.RequirementStateId == requirementStateId)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    foreach (var item in query2)
                    {
                        lstRequirement.Add(item.Requirement);
                        lstUserEmployee.Add(item.User);
                        lstRequirementState.Add(item.State);
                        lstRequirementPriority.Add(item.Priority);
                    }

                    return new paginatedRequirementDTO
                    {
                        lstRequirement = lstRequirement,
                        lstRequirementPriority = lstRequirementPriority,
                        lstRequirementState = lstRequirementState,
                        lstUserEmployee = lstUserEmployee,
                        TotalItems = TotalRequirement,
                        PageIndex = pageIndex,
                        PageSize = pageSize
                    };
                }
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(Requirement requirement)
        {
            try
            {
                _context.Requirement.Add(requirement);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(Requirement requirement)
        {
            try
            {
                _context.Requirement.Update(requirement);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByRequirementId(int requirementId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.RequirementId == requirementId)
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
                List<Requirement> lstRequirement = _context.Requirement.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("RequirementId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Title", typeof(string));
                DataTable.Columns.Add("Body", typeof(string));
                DataTable.Columns.Add("RequirementStateId", typeof(string));
                DataTable.Columns.Add("RequirementPriorityId", typeof(string));
                DataTable.Columns.Add("UserEmployeeId", typeof(string));
                

                foreach (Requirement requirement in lstRequirement)
                {
                    DataTable.Rows.Add(
                        requirement.RequirementId,
                        requirement.Active,
                        requirement.DateTimeCreation,
                        requirement.DateTimeLastModification,
                        requirement.UserCreationId,
                        requirement.UserLastModificationId,
                        requirement.Title,
                        requirement.Body,
                        requirement.RequirementStateId,
                        requirement.RequirementPriorityId,
                        requirement.UserEmployeeId
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
