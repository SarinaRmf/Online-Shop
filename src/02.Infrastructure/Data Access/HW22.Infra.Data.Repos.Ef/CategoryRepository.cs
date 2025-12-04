using HW22.Domain.Core.Contracts.Category;
using HW22.Domain.Core.Dtos.Category;
using HW22.Infra.Db.SqlServer.Ef;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Infra.Data.Repos.Ef
{
    public class CategoryRepository(AppDbContext _context) : ICategoryRepository
    {
        public async Task<List<GetCategoryDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Categories.AsNoTracking().Select(c => new GetCategoryDto
            {
                Id = c.Id,
                Name = c.Name,
                ImagePath = c.ImagePath
            }).ToListAsync(cancellationToken);
        }

        public async Task<GetCategoryDto?> GetById(int id, CancellationToken cancellationToken) {

            return await _context.Categories.Where(c => c.Id == id)
                .Select(c => new GetCategoryDto
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
