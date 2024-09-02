using eCommerceProject.Business.Abstract;
using eCommerceProject.Models;

namespace eCommerceProject.Business.Concrete
{
    public class MemberService : IMemberService
    {
        public Task<Member> AddMemberAsync(Member member)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMemberAsync(int memberId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Member>> GetAllMembersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Member> GetMemberByIdAsync(int memberId)
        {
            throw new NotImplementedException();
        }

        public Task<Member> LoginAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Member> RegisterAsync(Member member)
        {
            throw new NotImplementedException();
        }

        public Task<Member> UpdateMemberAsync(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
