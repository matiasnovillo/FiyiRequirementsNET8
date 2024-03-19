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
    public class RequirementFileRepository : IRequirementFileRepository
    {
        protected readonly FiyiRequirementsContext _context;

        public RequirementFileRepository(FiyiRequirementsContext context)
        {
            _context = context;
        }

        public IQueryable<RequirementFile> AsQueryable()
        {
            try
            {
                return _context.RequirementFile.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.RequirementFile.Count();
            }
            catch (Exception) { throw; }
        }

        public RequirementFile? GetByRequirementFileId(int requirementfileId)
        {
            try
            {
                return _context.RequirementFile
                            .FirstOrDefault(x => x.RequirementFileId == requirementfileId);
            }
            catch (Exception) { throw; }
        }

        public List<RequirementFile?> GetAll()
        {
            try
            {
                return _context.RequirementFile.ToList();
            }
            catch (Exception) { throw; }
        }

        public paginatedRequirementFileDTO GetAllByRequirementFileIdPaginated(string textToSearch,
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

                int TotalRequirementFile = _context.RequirementFile.Count();

                var paginatedRequirementFile = _context.RequirementFile
                        .Where(x => strictSearch ?
                            words.All(word => x.RequirementFileId.ToString().Contains(word)) :
                            words.Any(word => x.RequirementFileId.ToString().Contains(word)))
                        .OrderBy(p => p.RequirementFileId)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                return new paginatedRequirementFileDTO
                {
                    lstRequirementFile = paginatedRequirementFile,
                    TotalItems = TotalRequirementFile,
                    PageIndex = pageIndex,
                    PageSize = pageSize
                };
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(RequirementFile requirementfile)
        {
            try
            {
                _context.RequirementFile.Add(requirementfile);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(RequirementFile requirementfile)
        {
            try
            {
                _context.RequirementFile.Update(requirementfile);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByRequirementFileId(int requirementfileId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.RequirementFileId == requirementfileId)
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
                List<RequirementFile> lstRequirementFile = _context.RequirementFile.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("RequirementFileId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("RequirementId", typeof(string));
                DataTable.Columns.Add("FilePath", typeof(string));
                

                foreach (RequirementFile requirementfile in lstRequirementFile)
                {
                    DataTable.Rows.Add(
                        requirementfile.RequirementFileId,
                        requirementfile.Active,
                        requirementfile.DateTimeCreation,
                        requirementfile.DateTimeLastModification,
                        requirementfile.UserCreationId,
                        requirementfile.UserLastModificationId,
                        requirementfile.RequirementId,
                        requirementfile.FilePath
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
