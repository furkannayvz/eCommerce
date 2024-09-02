
using System.Collections.Generic;
using System.Threading.Tasks;
using eCommerceProject.Models;

namespace eCommerceProject.Business.Abstract
{
    public interface IMemberService
    {
       
        Task<List<Member>> GetAllMembersAsync();

      
        Task<Member> GetMemberByIdAsync(int memberId);

        
        Task<Member> AddMemberAsync(Member member);

        
        Task<Member> UpdateMemberAsync(Member member);

      
        Task<bool> DeleteMemberAsync(int memberId);

       
        Task<Member> LoginAsync(string username, string password);

        
        Task<Member> RegisterAsync(Member member);
    }
}





