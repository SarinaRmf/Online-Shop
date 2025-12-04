using HW22.Domain.Core.Contracts.Product;
using HW22.Domain.Core.Dtos.Product;
using HW22.Infra.Db.SqlServer.Ef;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Infra.Data.Repos.Ef
{
    public class ProductRepository(AppDbContext _context) : IProductRepository
    {
        public async Task<List<GetProductDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Products.AsNoTracking()
                .Select(p => new GetProductDto
                {
                    Id = p.Id,  
                    Category = p.Category.Name,
                    Name = p.Name,
                    Count = p.Count,
                    Price = p.Price,
                    ImagePath = p.ImagePath,
                }).ToListAsync(cancellationToken);
        }
        public async Task<GetProductDto?> GetDetails(int id, CancellationToken cancellationToken)
        {
            return await _context.Products.AsNoTracking()
                .Where(p => p.Id == id)
                .Select(p => new GetProductDto
                {
                    Id = p.Id,
                    Category = p.Category.Name,
                    Name = p.Name,
                    Count = p.Count,
                    Price = p.Price,
                    Description = p.Description,
                    ImagePath = p.ImagePath,
                }).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<List<GetProductDto>> GetCategoryProducts(int categoryId,CancellationToken cancellationToken)
        {
            return await _context.Products.AsNoTracking()
                .Where(p => p.CategoryId == categoryId)
                .Select(p => new GetProductDto
                {
                    Id = p.Id,
                    Category = p.Category.Name,
                    Name = p.Name,
                    Count = p.Count,
                    Price = p.Price,
                    ImagePath= p.ImagePath,
                }).ToListAsync(cancellationToken);

        }

        public async Task<int> GetProductCount(int productId, CancellationToken cancellationToken)
        {
            return await _context.Products.Where(p => p.Id == productId)
                .Select(p => p.Count)
                .FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<bool> UpdateCount(int productId, int count, CancellationToken cancellationToken) { 
        
            return await _context.Products.Where(p => p.Id == productId)
                .ExecuteUpdateAsync(p => p.SetProperty(p => p.Count, count), cancellationToken) > 0;
        }

    }
}
