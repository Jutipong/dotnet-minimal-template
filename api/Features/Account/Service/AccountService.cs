using Web_Minimal.Features.Account.Dto;

namespace Web_Minimal.Features.Account.Service
{
    public class AccountService : IAccountService
    {
        public JsonResponse<Response.Create> Create(Request.CreateAccount create)
        {
            return new JsonResponse<Response.Create>
            {
                Datas = new Response.Create { Id = 99, Name = create.Name, Last = create.Last }
            };
        }

        public JsonResponse<Response.Update> Update(Request.UpdateAccount update)
        {
            return new JsonResponse<Response.Update>
            {
                Datas = new Response.Update { Id = update.Id, Name = update.Name, Last = update.Last, DateTime = DateTime.Now }
            };
        }

        public JsonResponse<Response.Delete> Delete(Request.DeleteAccount delete)
        {
            return new JsonResponse<Response.Delete> { Datas = new Response.Delete { Id = delete.Id, } };
        }

    }
}
