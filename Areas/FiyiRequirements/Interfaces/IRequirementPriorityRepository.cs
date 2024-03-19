using FiyiRequirements.Areas.FiyiRequirements.Entities;
using FiyiRequirements.Areas.FiyiRequirements.DTOs;
using System.Data;

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

namespace FiyiRequirements.Areas.FiyiRequirements.Interfaces
{
    public interface IRequirementPriorityRepository
    {
        IQueryable<RequirementPriority> AsQueryable();

        #region Queries
        int Count();

        RequirementPriority? GetByRequirementPriorityId(int requirementpriorityId);

        List<RequirementPriority?> GetAll();

        paginatedRequirementPriorityDTO GetAllByRequirementPriorityIdPaginated(string textToSearch,
            bool strictSearch,
            int pageIndex,
            int pageSize);
        #endregion

        #region Non-Queries
        bool Add(RequirementPriority requirementpriority);

        bool Update(RequirementPriority requirementpriority);

        bool DeleteByRequirementPriorityId(int requirementpriority);
        #endregion

        #region Other methods
        DataTable GetAllInDataTable();
        #endregion
    }
}
