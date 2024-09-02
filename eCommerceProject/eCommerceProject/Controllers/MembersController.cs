using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using eCommerceProject.Business.Abstract;
using System.Data.SqlClient;
using eCommerceProject.Entities;
using eCommerceProject.Models;
using eCommerceProject.DataAccess;

namespace ECommerceProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MemberController : ControllerBase
    {
        private readonly string connectionString;
        public IMemberService _memberService;
        public MemberController(IConfiguration configuration, IMemberService memberService)
        {
            connectionString = configuration["ConnectionStrings:SqlServerDb"] ?? "";
            _memberService = memberService;
        }


        [HttpPost]
        public IActionResult CreateMember(Member member)
        {

            try
            {
                _memberService.AddMemberAsync(member);
                //using (var connection = new SqlConnection(connectionString))
                //{
                //    connection.Open();

                //    string sql = "INSERT INTO members" + "(name) " + "(@name)";

                //    using (var command = new SqlCommand(sql, connection))
                //    {

                //        command.Parameters.AddWithValue("@name", member.Name);
                //        command.ExecuteNonQuery();
                //    }
                //}
                return Ok(member);
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("Members", "Sorry but we have an expection");
                return BadRequest(ModelState);

            }

        }   
    }
}
