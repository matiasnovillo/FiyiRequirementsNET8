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
    public interface IRequirementFileRepository
    {
        IQueryable<RequirementFile> AsQueryable();

        #region Queries
        int Count();

        RequirementFile? GetByRequirementFileId(int requirementfileId);

        List<RequirementFile?> GetAll();

        paginatedRequirementFileDTO GetAllByRequirementFileIdPaginated(string textToSearch,
            bool strictSearch,
            int pageIndex,
            int pageSize);
        #endregion

        #region Non-Queries
        bool Add(RequirementFile requirementfile);

        bool Update(RequirementFile requirementfile);

        bool DeleteByRequirementFileId(int requirementfile);
        #endregion

        #region Other methods
        DataTable GetAllInDataTable();
        #endregion
    }
}
