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
    public interface IRequirementRepository
    {
        IQueryable<Requirement> AsQueryable();

        #region Queries
        int Count();

        Requirement? GetByRequirementId(int requirementId);

        List<Requirement?> GetAll();

        paginatedRequirementDTO GetAllByTitlePaginatedAndOtherFilters(string textToSearch,
            bool strictSearch,
            int pageIndex,
            int pageSize,
            int requirementStateId);
        #endregion

        #region Non-Queries
        bool Add(Requirement requirement);

        bool Update(Requirement requirement);

        bool DeleteByRequirementId(int requirement);
        #endregion

        #region Other methods
        DataTable GetAllInDataTable();
        #endregion
    }
}
