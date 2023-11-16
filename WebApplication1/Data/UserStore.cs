using WebApplication1.Models.Dto;

namespace WebApplication1.Data
{
    public static class UserStore
    {
        public static List<UserDTO> userList = new List<UserDTO>
        {
             new UserDTO{Id=1, Username="admin", Password="admin"},
             new UserDTO{Id=2, Username="raf", Password="12345"}
        };

    }
}
