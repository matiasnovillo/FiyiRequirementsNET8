using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using FiyiRequirements.Areas.CMSCore.Entities;
using FiyiRequirements.Areas.CMSCore.DTOs;
using FiyiRequirements.Areas.CMSCore.Interfaces;
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

namespace FiyiRequirements.Areas.CMSCore.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        protected readonly FiyiRequirementsContext _context;

        public MenuRepository(FiyiRequirementsContext context)
        {
            _context = context;
        }

        public IQueryable<Menu> AsQueryable()
        {
            try
            {
                return _context.Menu.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Menu.Count();
            }
            catch (Exception) { throw; }
        }

        public Menu? GetByMenuId(int menuId)
        {
            try
            {
                return _context.Menu
                                .FirstOrDefault(x => x.MenuId == menuId);
            }
            catch (Exception) { throw; }
        }

        public List<Menu> GetAll()
        {
            try
            {
                return _context.Menu.ToList();
            }
            catch (Exception) { throw; }
        }

        public paginatedMenuDTO GetAllByNameOrURLPathPaginated(string textToSearch,
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

                int TotalMenu = _context.Menu.Count();

                var query = from menu in _context.Menu
                            join userCreation in _context.User on menu.UserCreationId equals userCreation.UserId
                            join userLastModification in _context.User on menu.UserLastModificationId equals userLastModification.UserId
                            select new { Menu = menu, UserCreation = userCreation, UserLastModification = userLastModification };

                // Extraemos los resultados en listas separadas
                List<Menu> lstMenu = query.Select(result => result.Menu)
                        .Where(x => strictSearch ?
                            words.All(word => x.Name.Contains(word)) :
                            words.Any(word => x.Name.Contains(word)))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();
                List<User> lstUserCreation = query.Select(result => result.UserCreation).ToList();
                List<User> lstUserLastModification = query.Select(result => result.UserLastModification).ToList();

                return new paginatedMenuDTO
                {
                    lstMenu = lstMenu,
                    lstUserCreation = lstUserCreation,
                    lstUserLastModification = lstUserLastModification,
                    TotalItems = TotalMenu,
                    PageIndex = pageIndex,
                    PageSize = pageSize
                };
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(Menu menu)
        {
            try
            {
                _context.Menu.Add(menu);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(Menu menu)
        {
            try
            {
                _context.Menu.Update(menu);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByMenuId(int menuId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.MenuId == menuId)
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
                List<Menu> lstMenu = _context.Menu.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("MenuId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Name", typeof(string));
                DataTable.Columns.Add("MenuFatherId", typeof(string));
                DataTable.Columns.Add("Order", typeof(string));
                DataTable.Columns.Add("URLPath", typeof(string));
                DataTable.Columns.Add("IconURLPath", typeof(string));
                

                foreach (Menu menu in lstMenu)
                {
                    DataTable.Rows.Add(
                        menu.MenuId,
                        menu.Active,
                        menu.DateTimeCreation,
                        menu.DateTimeLastModification,
                        menu.UserCreationId,
                        menu.UserLastModificationId,
                        menu.Name,
                        menu.MenuFatherId,
                        menu.Order,
                        menu.URLPath,
                        menu.IconURLPath
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
