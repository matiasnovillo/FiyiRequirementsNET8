using DocumentFormat.OpenXml.EMMA;
using FiyiRequirements.Areas.CMSCore.Entities;
using FiyiRequirements.Areas.FiyiRequirements.Entities;

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

namespace FiyiRequirements.Areas.FiyiRequirements.DTOs
{
    public class paginatedRequirementDTO
    {
        public List<Requirement?> lstRequirement { get; set; }
        public List<RequirementPriority> lstRequirementPriority { get; set; }
        public List<RequirementState> lstRequirementState { get; set; }
        public List<User> lstUserEmployee { get; set; }
        public int TotalItems { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        public int TotalPages => (int)Math.Ceiling(TotalItems / (double)PageSize);

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;
    }
}