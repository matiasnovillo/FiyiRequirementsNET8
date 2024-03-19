using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using FiyiRequirements.Areas.FiyiRequirements.Entities;
using FiyiRequirements.Areas.BasicCore.Entities.Configuration;
using FiyiRequirements.Areas.FiyiRequirements.DTOs;
using FiyiRequirements.Areas.FiyiRequirements.Interfaces;
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

namespace FiyiRequirements.Areas.FiyiRequirements.Repositories
{
    public class RequirementNoteRepository : IRequirementNoteRepository
    {
        protected readonly EFCoreContext _context;

        public RequirementNoteRepository(EFCoreContext context)
        {
            _context = context;
        }

        public IQueryable<RequirementNote> AsQueryable()
        {
            try
            {
                return _context.RequirementNote.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.RequirementNote.Count();
            }
            catch (Exception) { throw; }
        }

        public RequirementNote? GetByRequirementNoteId(int requirementnoteId)
        {
            try
            {
                return _context.RequirementNote
                            .FirstOrDefault(x => x.RequirementNoteId == requirementnoteId);
            }
            catch (Exception) { throw; }
        }

        public List<RequirementNote?> GetAll()
        {
            try
            {
                return _context.RequirementNote.ToList();
            }
            catch (Exception) { throw; }
        }

        public paginatedRequirementNoteDTO GetAllByRequirementNoteIdPaginated(string textToSearch,
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

                int TotalRequirementNote = _context.RequirementNote.Count();

                var paginatedRequirementNote = _context.RequirementNote
                        .Where(x => strictSearch ?
                            words.All(word => x.RequirementNoteId.ToString().Contains(word)) :
                            words.Any(word => x.RequirementNoteId.ToString().Contains(word)))
                        .OrderBy(p => p.RequirementNoteId)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                return new paginatedRequirementNoteDTO
                {
                    lstRequirementNote = paginatedRequirementNote,
                    TotalItems = TotalRequirementNote,
                    PageIndex = pageIndex,
                    PageSize = pageSize
                };
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(RequirementNote requirementnote)
        {
            try
            {
                _context.RequirementNote.Add(requirementnote);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(RequirementNote requirementnote)
        {
            try
            {
                _context.RequirementNote.Update(requirementnote);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByRequirementNoteId(int requirementnoteId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.RequirementNoteId == requirementnoteId)
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
                List<RequirementNote> lstRequirementNote = _context.RequirementNote.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("RequirementNoteId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Title", typeof(string));
                DataTable.Columns.Add("Body", typeof(string));
                DataTable.Columns.Add("RequirementId", typeof(string));
                

                foreach (RequirementNote requirementnote in lstRequirementNote)
                {
                    DataTable.Rows.Add(
                        requirementnote.RequirementNoteId,
                        requirementnote.Active,
                        requirementnote.DateTimeCreation,
                        requirementnote.DateTimeLastModification,
                        requirementnote.UserCreationId,
                        requirementnote.UserLastModificationId,
                        requirementnote.Title,
                        requirementnote.Body,
                        requirementnote.RequirementId
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
