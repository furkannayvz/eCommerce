using eCommerceProject.Models;

namespace eCommerceProject.DataAccess
{
    public interface IMemberRepository
    {
        Task<List<Member>> GetAllAsync();
        Task<Member> GetByIdAsync(int id);
        Task<Member> AddAsync(Member member);
        Task<Member> UpdateAsync(Member member);
        Task<bool> DeleteAsync(int id);
        Task<Member> LoginAsync(string username, string password);
    }
}
