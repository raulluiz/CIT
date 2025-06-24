using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

public interface ISaleRepository
{
    Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<PagedResult<Sale>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default);
    Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default);
    Task UpdateAsync(Sale sale, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Sale>> GetSalesByCustomerAsync(string customerName, CancellationToken cancellationToken = default);
    Task<IEnumerable<Sale>> GetSalesByBranchAsync(string branchName, CancellationToken cancellationToken = default);
}
